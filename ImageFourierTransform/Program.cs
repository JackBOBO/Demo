using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV;
using Emgu.CV.CvEnum;
using System.Drawing;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace ImageFourierTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();

            Demo6();

        }

        public static void Test()
        {
            //DFTUtil dftUtil = DFTUtil.GetInstance();
            //Mat input = new Mat("logo_right-233f0e2604.min.jpg", LoadImageType.AnyColor);
            //dftUtil.transformImageWithText(input, "test", new System.Drawing.Point(), 12, new Emgu.CV.Structure.MCvScalar(0, 255, 0));

            //Mat output = dftUtil.TransformImage(input);
            //output.Save("resultImage.jpg");
        }

        public static void Demo1()
        {
            Mat image = CvInvoke.Imread(@"C:\Users\v-chenlong1\Desktop\sample3.jpg", LoadImageType.Color); //从文件中读取图像

            CvInvoke.NamedWindow("AJpg", NamedWindowType.Normal); //创建一个显示窗口

            CvInvoke.Imshow("AJpg", image); //显示图片

            CvInvoke.WaitKey(0); //等待按键输入
            CvInvoke.DestroyWindow("AJpg");

            image.Dispose();
        }

        public static void Demo2()
        {
            String win1 = "Test Window"; //The name of the window
            CvInvoke.NamedWindow(win1); //Create the window using the specific name

            Mat img = new Mat(200, 400, DepthType.Cv8U, 3); //Create a 3 channel image of 400x200
            img.SetTo(new Bgr(255, 0, 0).MCvScalar); // set it to Blue color

            //Draw "Hello, world." on the image using the specific font
            CvInvoke.PutText(
               img,
               "Hello, world",
               new System.Drawing.Point(10, 80),
               FontFace.HersheyComplex,
               1.0,
               new Bgr(0, 255, 0).MCvScalar);


            CvInvoke.Imshow(win1, img); //Show the image
            CvInvoke.WaitKey(0);  //Wait for the key pressing event
            CvInvoke.DestroyWindow(win1); //Destroy the window if key is pressed
        }

        public static void Demo3()
        {
            //Mat image = CvInvoke.Imread(@"C:\Users\v-chenlong1\Desktop\sample3.jpg", LoadImageType.Color); //从文件中读取图像


            Image<Gray, Single> image = new Image<Gray, Single>(@"C:\Users\v-chenlong1\Desktop\sample3.jpg");
            UMat DFTimage = new UMat(image.Size, Emgu.CV.CvEnum.DepthType.Cv32F, 2);
            UMat Original = new UMat(image.Size, Emgu.CV.CvEnum.DepthType.Cv32F, 2);



            CvInvoke.Dft(image, DFTimage, Emgu.CV.CvEnum.DxtType.Forward, image.Rows);
            CvInvoke.Dft(Original, DFTimage, Emgu.CV.CvEnum.DxtType.Inverse, image.Rows);


            CvInvoke.NamedWindow("AJpg", NamedWindowType.Normal); //创建一个显示窗口

            CvInvoke.Imshow("AJpg", DFTimage); //显示图片


            CvInvoke.WaitKey(0); //等待按键输入
            CvInvoke.DestroyWindow("AJpg");

        }

        public static void Demo4()
        {
            Mat image = new Mat(@"C:\Users\v-chenlong1\Desktop\sample3.jpg", LoadImageType.AnyColor);

            Mat mat1 = image;
            mat1.ConvertTo(mat1, DepthType.Cv32F);
            Mat mat2 = new Mat(image.Size, DepthType.Cv32F, 2);
            //Mat mat3 = new Mat(image.Size, DepthType.Cv32F, 2);


            UMat umat = new UMat();

            using (VectorOfMat vm = new VectorOfMat(mat1, mat2))
            {
                CvInvoke.Merge(vm, umat);
            }



            CvInvoke.NamedWindow("AJpg", NamedWindowType.Normal); //创建一个显示窗口

            CvInvoke.Imshow("AJpg", mat1); //显示图片


            CvInvoke.WaitKey(0); //等待按键输入
            CvInvoke.DestroyWindow("AJpg");

        }

        public static void Demo5()
        {
            Image<Gray, Single> image = new Image<Gray, Single>(@"C:\Users\v-chenlong1\Desktop\sample3.jpg");
            //Mat image = Mat image = CvInvoke.Imread(@"C:\Users\v-chenlong1\Desktop\sample3.jpg", LoadImageType.Color); 

            Mat mat1 = image.Mat;
            mat1.ConvertTo(mat1, DepthType.Cv32F);
            Mat mat2 = new Mat(image.Size, DepthType.Cv32F, 2);

            UMat umat = new UMat();

            using (VectorOfMat vm = new VectorOfMat(mat1, mat2))
            {
                CvInvoke.Merge(vm, umat);
            }


            CvInvoke.Dft(image, umat, Emgu.CV.CvEnum.DxtType.Forward, image.Rows);


            CvInvoke.PutText(
               umat,
               "Hello, world",
               new System.Drawing.Point(10, 80),
               FontFace.HersheyComplex,
               1.0,
               new Bgr(0, 255, 0).MCvScalar);

            CvInvoke.Flip(umat, umat, FlipType.None);



            CvInvoke.NamedWindow("AJpg", NamedWindowType.Normal); //创建一个显示窗口

            CvInvoke.Imshow("AJpg", umat); //显示图片


            CvInvoke.WaitKey(0); //等待按键输入
            CvInvoke.DestroyWindow("AJpg");
        }

        public static void Demo6()
        {
            Image<Gray, Single> image1 = new Image<Gray, Single>(@"C:\Users\v-chenlong1\Desktop\sample3.jpg");
            Mat umat = new Mat();

            

            Image<Gray, Single> image2 = image1.Clone();
            image2.SetZero();
            Mat mat1 = image1.Mat.Clone();
            Mat mat2 = image2.Mat.Clone();

            using (VectorOfMat vm = new VectorOfMat(mat1, mat2))
            {
                CvInvoke.Merge(vm, umat);
            }

            CvInvoke.Dft(umat, umat, DxtType.Forward, mat1.Rows);

            Mat[] ssss = umat.Split();
            //magnitude

            Mat res1 = new Mat();
            Mat res2 = new Mat();

            CvInvoke.CartToPolar(ssss[0], ssss[1], res1, res2);

            CvInvoke.NamedWindow("AJpg", NamedWindowType.Normal); //创建一个显示窗口

            CvInvoke.Imshow("AJpg", res2); //显示图片

            CvInvoke.WaitKey(0); //等待按键输入
            CvInvoke.DestroyWindow("AJpg");

            umat.Dispose();
        }
    }
}
