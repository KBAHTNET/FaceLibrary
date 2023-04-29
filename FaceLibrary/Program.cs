using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace FaceLibrary
{
    static class Program
    {
        public static MainForm mainForm;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            #region Проверка наличия файлов
            //if(!Directory.Exists("Models"))
            //{
            //    Directory.CreateDirectory("Models");
            //}

            //if(!File.Exists(Application.StartupPath + @"\Models\dlib_face_recognition_resnet_model_v1.dat"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\Models\dlib_face_recognition_resnet_model_v1.dat", FileMode.Create);
            //    fs.Write(Properties.Resources.dlib_face_recognition_resnet_model_v1, 0, Properties.Resources.dlib_face_recognition_resnet_model_v1.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\Models\mmod_human_face_detector.dat"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\Models\mmod_human_face_detector.dat", FileMode.Create);
            //    fs.Write(Properties.Resources.mmod_human_face_detector, 0, Properties.Resources.mmod_human_face_detector.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\Models\shape_predictor_5_face_landmarks.dat"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\Models\shape_predictor_5_face_landmarks.dat", FileMode.Create);
            //    fs.Write(Properties.Resources.shape_predictor_5_face_landmarks, 0, Properties.Resources.shape_predictor_5_face_landmarks.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\Models\shape_predictor_68_face_landmarks.dat"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\Models\shape_predictor_68_face_landmarks.dat", FileMode.Create);
            //    fs.Write(Properties.Resources.shape_predictor_68_face_landmarks, 0, Properties.Resources.shape_predictor_68_face_landmarks.Length);
            //    fs.Close();
            //}

            //if (!File.Exists("DirectShowLib.dll"))
            //{
            //    FileStream fs = new FileStream("DirectShowLib.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.DirectShowLib, 0, Properties.Resources.DirectShowLib.Length);
            //    fs.Close();
            //}

            //if (!File.Exists("DlibDotNet.dll"))
            //{
            //    FileStream fs = new FileStream("DlibDotNet.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.DlibDotNet, 0, Properties.Resources.DlibDotNet.Length);
            //    fs.Close();
            //}

            //if (!File.Exists("DlibDotNetNative.dll"))
            //{
            //    FileStream fs = new FileStream("DlibDotNetNative.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.DlibDotNetNative, 0, Properties.Resources.DlibDotNetNative.Length);
            //    fs.Close();
            //}

            //if (!File.Exists("DlibDotNetNativeDnn.dll"))
            //{
            //    FileStream fs = new FileStream("DlibDotNetNativeDnn.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.DlibDotNetNativeDnn, 0, Properties.Resources.DlibDotNetNativeDnn.Length);
            //    fs.Close();
            //}

            //if (!File.Exists("Emgu.CV.UI.dll"))
            //{
            //    FileStream fs = new FileStream("Emgu.CV.UI.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.Emgu_CV_UI, 0, Properties.Resources.Emgu_CV_UI.Length);
            //    fs.Close();
            //}

            //if (!File.Exists("Emgu.CV.World.NetStandard.dll"))
            //{
            //    FileStream fs = new FileStream("Emgu.CV.World.NetStandard.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.Emgu_CV_World_NetStandard, 0, Properties.Resources.Emgu_CV_World_NetStandard.Length);
            //    fs.Close();
            //}

            //if (!File.Exists("FaceRecognitionDotNet.dll"))
            //{
            //    FileStream fs = new FileStream("FaceRecognitionDotNet.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.FaceRecognitionDotNet, 0, Properties.Resources.FaceRecognitionDotNet.Length);
            //    fs.Close();
            //}

            //if (!Directory.Exists("x64"))
            //{
            //    Directory.CreateDirectory("x64");
            //}

            //if (!File.Exists(Application.StartupPath + @"\x64\concrt140.dll"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\x64\concrt140.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.concrt140, 0, Properties.Resources.concrt140.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\x64\cvextern.dll"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\x64\cvextern.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.cvextern, 0, Properties.Resources.cvextern.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\x64\msvcp140.dll"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\x64\msvcp140.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.msvcp140, 0, Properties.Resources.msvcp140.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\x64\msvcp140_1.dll"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\x64\msvcp140_1.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.msvcp140_1, 0, Properties.Resources.msvcp140_1.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\x64\msvcp140_2.dll"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\x64\msvcp140_2.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.msvcp140_2, 0, Properties.Resources.msvcp140_2.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\x64\msvcp140_codecvt_ids.dll"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\x64\msvcp140_codecvt_ids.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.msvcp140_codecvt_ids, 0, Properties.Resources.msvcp140_codecvt_ids.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\x64\opencv_videoio_ffmpeg420_64.dll"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\x64\opencv_videoio_ffmpeg420_64.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.opencv_videoio_ffmpeg420_64, 0, Properties.Resources.opencv_videoio_ffmpeg420_64.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\x64\vcruntime140.dll"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\x64\vcruntime140.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.vcruntime140, 0, Properties.Resources.vcruntime140.Length);
            //    fs.Close();
            //}

            //if (!File.Exists(Application.StartupPath + @"\x64\vcruntime140_1.dll"))
            //{
            //    FileStream fs = new FileStream(Application.StartupPath + @"\x64\vcruntime140_1.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.vcruntime140_1, 0, Properties.Resources.vcruntime140_1.Length);
            //    fs.Close();
            //}

            //if (!File.Exists("ZedGraph.dll"))
            //{
            //    FileStream fs = new FileStream("ZedGraph.dll", FileMode.Create);
            //    fs.Write(Properties.Resources.ZedGraph, 0, Properties.Resources.ZedGraph.Length);
            //    fs.Close();
            //}

            if (!File.Exists("haarcascade_frontalface_default.xml"))
            {
                byte[] bytes = Encoding.Default.GetBytes(Properties.Resources.haarcascade_frontalface_default);
                FileStream fs = new FileStream("haarcascade_frontalface_default.xml", FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }

            if (!File.Exists("haarcascade_profileface.xml"))
            {
                byte[] bytes = Encoding.Default.GetBytes(Properties.Resources.haarcascade_profileface);
                FileStream fs = new FileStream("haarcascade_profileface.xml", FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreen splash = new SplashScreen();

            //поточные распознаватели
            Task t = new Task(() => MyRecognizer.InitLibs());
            t.Start();
            splash.Show();

            t.Wait();

            splash.Close();
            splash.Dispose();

            mainForm = new MainForm();
            Application.Run(mainForm);

        }
    }
}
