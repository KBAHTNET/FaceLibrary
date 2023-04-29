using Emgu.CV;
using Emgu.CV.Structure;

using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FaceLibrary
{
    public static class MyRecognizer
    {

        public static List<Face> TrainFaces = new List<Face>();
        public static List<Face> faces = new List<Face>();

        public static int ThreadsNumber = 50;
        //public static Dictionary<MyDetector, MyRecognizer2> Proccessing = new Dictionary<MyDetector, MyRecognizer2>();
        public static Dictionary<int, FaceRecognitionDotNet.FaceRecognition> libs = new Dictionary<int, FaceRecognitionDotNet.FaceRecognition>();

        public static void Recognize(MyDetector[] detectors)
        {
            List<Task> tasks = new List<Task>();
            foreach (var detector in detectors)
            {
                Task t = new Task(() =>
                {
                    Recognize2(detector);
                    detector.DrawRectanglesWithNames();
                });
                t.Start();
                tasks.Add(t);
            }

            Task.WaitAll(tasks.ToArray());

            tasks.Clear();
            tasks = null;
        }

        public static void Recognize2(MyDetector detector, int numJitters = 1,
            FaceRecognitionDotNet.PredictorModel predictModel = FaceRecognitionDotNet.PredictorModel.Large,
            FaceRecognitionDotNet.Model model = FaceRecognitionDotNet.Model.Cnn)
        {
            faces = new List<Face>();
            List<Task> tasks = new List<Task>();
            int ii = -1;
            foreach (var faceLocation in detector.facesLocation2)
            {
                var loc = faceLocation;
                //Bitmap newBmp = detector.bmp.Clone(new Rectangle(0, 0, detector.bmp.Width, detector.bmp.Height), detector.bmp.PixelFormat);
                ii++;
                int f = ii;

                Task t = new Task(() =>
                {
                    FaceRecognitionDotNet.FaceEncoding faceEncoding = libs[f].FaceEncoding(
                       FaceRecognitionDotNet.FaceRecognition.LoadImage(detector.bmp.ToBitmap()), loc, numJitters,
                       predictModel, model);

                    List<FaceRecognitionDotNet.FaceEncoding> knownEncodings = new List<FaceRecognitionDotNet.FaceEncoding>();
                    foreach (var face in TrainFaces)
                    {
                        knownEncodings.Add(face.encoding);
                    }
                    double[] distances = FaceRecognitionDotNet.FaceRecognition.FaceDistances(knownEncodings, faceEncoding).ToArray();

                    string name = "Неизвестное лицо";
                    int bestMatchIndex = -1;
                    double minDistance = 1;
                    for (int i = 0; i < distances.Count(); i++)
                    {
                        if (distances[i] < minDistance)
                        {
                            minDistance = distances[i];
                            bestMatchIndex = i;
                        }
                    }

                    if (minDistance < Configs.PorogDouble)
                    {
                        name = TrainFaces[bestMatchIndex].name;

                        if (Configs.EvidenceNames.Contains(name))
                        {
                            if (!Informator.DetectedFaces.Contains(TrainFaces[bestMatchIndex]))
                            {
                                Informator.PlaySignal();
                                Informator.DetectedFaces.Add(TrainFaces[bestMatchIndex]);
                                if (File.Exists("phones.txt"))
                                {
                                    List<string> phones = new List<string>();
                                    string filename = "phones.txt";
                                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                                    {
                                        FileInfo file = new FileInfo(filename);
                                        byte[] bytes = new byte[file.Length];
                                        fs.Read(bytes, 0, bytes.Length);
                                        string Phones = System.Text.Encoding.UTF8.GetString(bytes);

                                        foreach (var phone in Phones.Replace("\r\n", "\n").Split('\n'))
                                        {
                                            phones.Add(phone);
                                        }
                                    }

                                    Informator.SendMsg("Обнаружен преступник - " + name, phones.ToArray());
                                }
                            }
                        }
                    }


                    Face RecognizeFace = new Face(LocToRec(faceLocation), detector.bmp.ToBitmap(), name, faceEncoding);

                    detector.faces.Add(RecognizeFace);
                });
                t.Start();
                tasks.Add(t);
            }

            Task.WaitAll(tasks.ToArray());

            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i] = null;
            }

            tasks = null;
        }

        public static void Recognize(MyDetector detector)
        {
            faces = new List<Face>();

            foreach (var faceLocation in detector.facesLocation2)
            {
                FaceRecognitionDotNet.FaceEncoding faceEncoding = Configs.libraryRecognizer.FaceEncoding(
                    FaceRecognitionDotNet.FaceRecognition.LoadImage(detector.bmp.ToBitmap()), faceLocation, 1,
                    FaceRecognitionDotNet.PredictorModel.Large, FaceRecognitionDotNet.Model.Cnn);



                List<FaceRecognitionDotNet.FaceEncoding> knownEncodings = new List<FaceRecognitionDotNet.FaceEncoding>();
                foreach (var face in TrainFaces)
                {
                    knownEncodings.Add(face.encoding);
                }
                double[] distances = FaceRecognitionDotNet.FaceRecognition.FaceDistances(knownEncodings, faceEncoding).ToArray();

                string name = "Неизвестное лицо";
                int bestMatchIndex = -1;
                double minDistance = 1;
                for (int i = 0; i < distances.Count(); i++)
                {
                    if (distances[i] < minDistance)
                    {
                        minDistance = distances[i];
                        bestMatchIndex = i;
                    }
                }

                if (minDistance < Configs.PorogDouble)
                {
                    name = TrainFaces[bestMatchIndex].name;

                    if (Configs.EvidenceNames.Contains(name))
                    {
                        Informator.PlaySignal();
                    }
                }

                Bitmap bmp = detector.bmp.ToBitmap();

                Face RecognizeFace = new Face(LocToRec(faceLocation), bmp, name, faceEncoding);

                faces.Add(RecognizeFace);
            }
        }


        private static Rectangle LocToRec(FaceRecognitionDotNet.Location location)
        {
            return new Rectangle(
                new Point(location.Left, location.Top),
                new Size(location.Right - location.Left, location.Bottom - location.Top)
            );
        }

        public static void InitLibs()
        {
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < ThreadsNumber; i++)
            {
                int f = i;
                Task t3 = new Task(() =>
                {
                    if (!libs.ContainsKey(f))
                    {
                    init:
                        try
                        {
                            var recognizer = FaceRecognitionDotNet.FaceRecognition.Create("Models");
                            libs.Add(f, recognizer);
                        }
                        catch { goto init; }
                    }
                });
                t3.Start();
                tasks.Add(t3);
            }
            Task.WaitAll(tasks.ToArray());
        }

        public static void Train(DirectoryInfo directoryWithTrainImages, ListView listView = null)
        {
            if (directoryWithTrainImages.Exists)
            {
                //TrainFaces.Clear();

                List<Task> tasks = new List<Task>();

                Configs.chosenAlgoritmDetection = Configs.AlgoritmDetection.Hog;

                foreach (var trainImage in directoryWithTrainImages.GetFiles())
                {
                    Task t = new Task(() =>
                    {
                        try
                        {
                            Bitmap bmp = (Bitmap)Image.FromFile(trainImage.FullName);

                            FaceRecognitionDotNet.Image img = FaceRecognitionDotNet.FaceRecognition.LoadImage(bmp);

                            var temp = Configs.IsResizeFrame;
                            Configs.IsResizeFrame = false;

                            MyDetector detector = new MyDetector();
                            detector.bmp = bmp.ToImage<Bgr, byte>().Mat;
                            detector.DetectFaces();

                            var faceLocation = detector.facesLocation2[0];

                            Configs.IsResizeFrame = temp;

                            FaceRecognitionDotNet.FaceEncoding faceEncoding = detector.libraryRecognizer.FaceEncoding(
                                img, faceLocation, 1, FaceRecognitionDotNet.PredictorModel.Large);


                            TrainFaces.Add(new Face(LocToRec(faceLocation), bmp.Clone(LocToRec(faceLocation), System.Drawing.Imaging.PixelFormat.Format24bppRgb)/*.ToImage<Bgr, byte>().Copy(LocToRec(faceLocation)).ToBitmap()*/, trainImage.Name.Split('.')[0], faceEncoding));

                            if (listView != null)
                            {
                                listView.BeginInvoke((MethodInvoker)(() =>
                                {
                                    if (!listView.Items.Contains(new ListViewItem(trainImage.Name.Split('.')[0])))
                                        listView.Items.Add(trainImage.Name.Split('.')[0]);
                                }));
                            }

                            detector.Dispose();
                        }
                        catch
                        {
                            MessageBox.Show($"Файл с именем \"{trainImage.Name}\" " +
                                $"не является изображением. Пожалуйста, уберите из папки с датасетом лиц " +
                                $"лишние файлы во избежании подобных сообщений.", "Информация",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    });

                    t.Start();
                    tasks.Add(t);
                }
                Task.WaitAll(tasks.ToArray());

                tasks.Clear();

                //tasks = new List<Task>();
                //for (int i = 0; i < ThreadsNumber; i++)
                //{
                //    int f = i;
                //    Task t3 = new Task(() =>
                //    {
                //        if (!libs.ContainsKey(f))
                //        {
                //        init:
                //            try
                //            {
                //                var recognizer = FaceRecognitionDotNet.FaceRecognition.Create("Models");
                //                libs.Add(f, recognizer);
                //            }
                //            catch { goto init; }
                //        }
                //    });
                //    t3.Start();
                //    tasks.Add(t3);
                //}
                //Task.WaitAll(tasks.ToArray());
                tasks.Clear();
                tasks = null;

                Configs.IsUseRecognition = true;

                Configs.chosenAlgoritmDetection = Configs.AlgoritmDetection.FasterR_CNN;

                MessageBox.Show("Обучение завершено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Такой папки нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
