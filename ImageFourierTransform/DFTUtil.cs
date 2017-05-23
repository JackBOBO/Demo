using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util.TypeEnum;
using Emgu.CV.Util;
using Emgu.CV.Cuda;
using Emgu.Util;

namespace ImageFourierTransform
{
    public class DFTUtil
    {
        private static List<Mat> planes;

        private static Mat complexImage;

        private DFTUtil() { }

        private static readonly DFTUtil dftUtil = new DFTUtil();


        public static DFTUtil GetInstance()
        {
            planes = new List<Mat>();
            complexImage = new Mat();
            return dftUtil;
        }

        public Mat TransformImage(Mat image)
        {
            if (planes.Count != 0)
                planes.Clear();

            // optimize the dimension of the loaded image  
            Mat padded = this.OptimizeImageDim(image);
            padded.ConvertTo(padded, DepthType.Cv32F);

            // prepare the image planes to obtain the complex image  
            planes.Add(padded);
            //planes.add(Mat.zeros(padded.size(), CvType.CV_32F));
            planes.Add(new Mat(padded.Size, DepthType.Cv32F, 0));


            // prepare a complex image for performing the dft  
            CvInvoke.Merge(new Matrix<Mat>(planes.ToArray()), complexImage);

            // dft  
            //CvInvoke.Dft(complexImage, complexImage, 0);
            CvInvoke.Dft(complexImage, complexImage, DxtType.Forward, 0);
            // optimize the image resulting from the dft operation  
            Mat magnitude = this.CreateOptimizedMagnitude(complexImage);
            planes.Clear();
            return magnitude;
        }

        private Mat CreateOptimizedMagnitude(Mat complexImage)
        {
            // init  
            List<Mat> newPlanes = new List<Mat>();
            Mat mag = new Mat();
            // split the comples image in two planes  
            //CvInvoke.Split(complexImage, newPlanes);
            using (VectorOfMat vm = new VectorOfMat(newPlanes.ToArray()))
            {
                CvInvoke.Split(complexImage, vm);
            }

            // compute the magnitude  
            CudaInvoke.Magnitude(newPlanes[0], newPlanes[1], mag);

            // move to a logarithmic scale  
            CvInvoke.Add(new Mat(mag.Size, DepthType.Cv32F, 0), mag, mag);

            CvInvoke.Log(mag, mag);
            // optionally reorder the 4 quadrants of the magnitude image  
            this.shiftDFT(mag);
            // normalize the magnitude image for the visualization since both JavaFX  
            // and OpenCV need images with value between 0 and 255  
            // convert back to CV_8UC1  
            mag.ConvertTo(mag, DepthType.Cv8U);
            CvInvoke.Normalize(mag, mag, 0, 255, NormType.MinMax, DepthType.Cv8U);

            return mag;
        }

        public void transformImageWithText(Mat image, String watermarkText, Point point, Double fontSize, MCvScalar scalar)
        {
            // planes数组中存的通道数若开始不为空,需清空.  
            if (planes.Count > 0)
            {
                planes.Clear();
            }

            // optimize the dimension of the loaded image  
            //Mat padded = this.optimizeImageDim(image);  
            Mat padded = image;

            padded.ConvertTo(padded, DepthType.Cv32F);
            // prepare the image planes to obtain the complex image  
            planes.Add(padded);
            planes.Add(new Mat(padded.Size, DepthType.Cv32F, 1));

            // prepare a complex image for performing the dft  

            //CvInvoke.Merge(new Matrix<Mat>(planes.ToArray()), complexImage);
            using (VectorOfMat vm = new VectorOfMat(planes.ToArray()))
            {
                CvInvoke.Merge(vm, complexImage);
            }

            // dft  
            CvInvoke.Dft(complexImage, complexImage, DxtType.Forward, 0);

            // 频谱图上添加文本  FONT_HERSHEY_DUPLEX
            CvInvoke.PutText(complexImage, watermarkText, point, FontFace.HersheyDuplex, fontSize, scalar, 2);
            CvInvoke.Flip(complexImage, complexImage, FlipType.None);
            CvInvoke.PutText(complexImage, watermarkText, point, FontFace.HersheyDuplex, fontSize, scalar, 2);
            CvInvoke.Flip(complexImage, complexImage, FlipType.None);

            planes.Clear();
        }

        private void shiftDFT(Mat image)
        {
            image = new Mat(image, new Rectangle(0, 0, image.Cols & -2, image.Rows & -2));
            int cx = image.Cols / 2;
            int cy = image.Rows / 2;

            Mat q0 = new Mat(image, new Rectangle(0, 0, cx, cy));
            Mat q1 = new Mat(image, new Rectangle(cx, 0, cx, cy));
            Mat q2 = new Mat(image, new Rectangle(0, cy, cx, cy));
            Mat q3 = new Mat(image, new Rectangle(cx, cy, cx, cy));

            Mat tmp = new Mat();
            q0.CopyTo(tmp);
            q3.CopyTo(q0);
            tmp.CopyTo(q3);

            q1.CopyTo(tmp);
            q2.CopyTo(q1);
            tmp.CopyTo(q2);
        }

        private Mat OptimizeImageDim(Mat image)
        {
            // init  
            Mat padded = new Mat();
            // get the optimal rows size for dft  
            int addPixelRows = CvInvoke.GetOptimalDFTSize(image.Rows);
            // get the optimal cols size for dft  
            int addPixelCols = CvInvoke.GetOptimalDFTSize(image.Cols);
            // apply the optimal cols and rows size to the image  
            CvInvoke.CopyMakeBorder(image, padded, 0, addPixelRows - image.Rows, 0, addPixelCols - image.Cols,
                    BorderType.Constant, new MCvScalar(0));

            return padded;
        }

        public Mat antitransformImage()
        {
            Mat invDFT = new Mat();
            CvInvoke.Dft(complexImage, invDFT, DxtType.Inverse| DxtType.InvScale, complexImage.Rows);
            Mat restoredImage = new Mat();

            invDFT.ConvertTo(restoredImage, DepthType.Cv8U);
            planes.Clear();

            return restoredImage;
        }
    }
}
