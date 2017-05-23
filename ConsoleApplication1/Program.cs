using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.CV.Structure;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MessageBox.Show(textBox1.Text);  
                // CvInvoke.cvNamedWindow("打开图片");  
                IntPtr img = CvInvoke.cvLoadImage(@"C:\Users\v-chenlong1\Desktop\sample3.jpg", Emgu.CV.CvEnum.LOAD_IMAGE_TYPE.CV_LOAD_IMAGE_ANYDEPTH);
                //CvInvoke.cvShowImage("打开图片",img);  
                //CvInvoke.cvWaitKey(0);  
                //CvInvoke.cvReleaseImage(ref img);  
                //CvInvoke.cvDestroyWindow("打开图片");  
               var dest = new Image<Bgr, byte>(CvInvoke.cvGetSize(img));
                CvInvoke.cvCopy(img, dest, IntPtr.Zero);
            dest.Save("test.jpg");
            }
    }
}
