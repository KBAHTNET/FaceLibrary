using Emgu.CV;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace FaceLibrary
{
    public static class Configs
    {
        public static List<string> EvidenceNames = new List<string> 
        {
            "Объект"
        };
        
        public static bool IsSignalPlay = false; //проверка на воспроизхведение сигнализации

        //чтение имен разыскиваемых лиц из файла. P.S. имена разыскиваемых должны быть в отдельных строках без лишних знаков
        public static void InitFindNames(string filename)
        {
            EvidenceNames = new List<string>();
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                FileInfo file = new FileInfo(filename);
                byte[] bytes = new byte[file.Length];
                fs.Read(bytes, 0, bytes.Length);
                string Names = Encoding.UTF8.GetString(bytes);

                foreach (var name in Names.Replace("\r\n","\n").Split('\n'))
                {
                    EvidenceNames.Add(name);
                }
            }
        }

        public static bool IsDrawFaceLandmarks = false; //рисовать ли ключевые точки лица (5 точек и 68 точек в зависимости от модели)
        public static bool IsDrawCiphers = false; //рисовать цифры к точкам Facelandmarks

        public static bool IsShowMiddleProccess = true; //использовать линейное распознавание - показывать все кадры или поточное, только лицо в розыске
        public static bool IsUseRecognition = false; //использовать ли алгоритмы распознавания
        public static readonly FaceRecognitionDotNet.FaceRecognition libraryRecognizer = FaceRecognitionDotNet.FaceRecognition.Create("Models"); //содержит модель распознавания
        public static double PorogDouble = 0.52; //порог распознавания лиц, все что выше установленного порога считается неизвестным лицом

        //для добавления лиц в боковое окно imagebox  с интервалом
        public static int secondsInterval = 10; //интервал в секундах для добавления одинаковых лиц в список обнаруженных

        //указывает удалять или не удалять пересечения фронтального и профильных найденных лиц
        public static bool deleteIntersect = true;

        //каскады для обнаружения профильного и фронтальных лиц
        public static readonly CascadeClassifier haarFaceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");
        public static readonly CascadeClassifier haarProfileCascade = new CascadeClassifier("haarcascade_profileface.xml");


        #region Переменные, для выбора метода обнаружения и алгоритма распознавания
        public enum AlgoritmDetection { FasterR_CNN, Cnn, Hog, Haar }//имеющиеся алгоритмы обнаружения лиц
        public static AlgoritmDetection chosenAlgoritmDetection = AlgoritmDetection.Hog;//выбранный алгоритм обнаружения (по стандарту HOG)
        public enum AlgoritmRecognition { DNN }//имеющиеся алгоритмы распознаввания
        public static AlgoritmRecognition chosenAlgoritmRegognition = AlgoritmRecognition.DNN;//выбранный алгоритм распознавания (по стандарту симская сеть)

        public static FaceRecognitionDotNet.PredictorModel PredictorModel = FaceRecognitionDotNet.PredictorModel.Large; //Large - 68 точек, Small - 5 точек
        public static FaceRecognitionDotNet.Model Model = FaceRecognitionDotNet.Model.Cnn;
        #endregion

        #region Переменные, для изменения настроек хаара и цвета
        public static double multiScale = 1.2;//настройка хаара
        public static int minNeig = 4;//настройка хаара (минимальное кол-во соседей)
        public static Size MinFaceSize = new Size(20, 20);//настройка хаара (минимальный размер лица в кадре)

        public static bool IsResizeFrame = false; //изменять размер или нет
        public static Size PictureResize = new Size(1920, 1080); //для разрешения кадра после его получения

        public static Size ResizeTrainAndPredictPicture = new Size(1024, 768); //ресайз для распознавателя

        public static Color ColorFrontal = Color.Cyan; //цвет обводки фронтального лица
        //public static Color ColorProfile = Color.Cyan; //цвет обводки профильного лица
        public static Color FontColor = Color.Black;//цвет шрифта надписей
        public static Color ColorEvidenceFrontal = Color.OrangeRed;//цвет обводки преступников
        public static int PenSize = 3; //размер ручки для рисования обводки

        #endregion

    }
}
