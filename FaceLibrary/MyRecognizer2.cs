using Emgu.CV;
using Emgu.CV.Structure;

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FaceLibrary
{
    public class MyRecognizer2
    {
        public MyRecognizer2(List<Face> trainFaces)
        {
            TrainFaces = trainFaces;
        }

        public List<Face> TrainFaces = new List<Face>();
        public List<Face> faces = new List<Face>();

        public void Recognize0(MyDetector detector)
        {
            faces = new List<Face>();

            List<FaceRecognitionDotNet.FaceEncoding> knownEncodings = new List<FaceRecognitionDotNet.FaceEncoding>();
            foreach (var face in TrainFaces)
            {
                knownEncodings.Add(face.encoding);
            }

            var faceEncodings = detector.libraryRecognizer.FaceEncodings(
                           FaceRecognitionDotNet.FaceRecognition.LoadImage(detector.bmp.ToBitmap()), detector.facesLocation2, 1,
                           FaceRecognitionDotNet.PredictorModel.Large, FaceRecognitionDotNet.Model.Cnn);


            for(int i = 0; i < detector.facesLocation2.Count(); i++)
            {
                var faceEncoding = faceEncodings.ElementAt(i);
 
                double[] distances = FaceRecognitionDotNet.FaceRecognition.FaceDistances(knownEncodings, faceEncoding).ToArray();

                string name = "Неизвестное лицо";
                int bestMatchIndex = -1;
                double minDistance = 1;
                for (int j = 0; j < distances.Count(); j++)
                {
                    if (distances[j] < minDistance)
                    {
                        minDistance = distances[j];
                        bestMatchIndex = j;
                    }
                }

                if (minDistance < Configs.PorogDouble)
                {
                    name = TrainFaces[bestMatchIndex].name;

                    Face RecognizeFace = new Face(detector.facesLocation[i], detector.bmp.ToBitmap(), name, faceEncoding);

                    detector.faces.Add(RecognizeFace);

                    if (Configs.EvidenceNames.Contains(name))
                    {
                        EvidenceDetect = true;
                        RecogEvidFaces.Add(RecognizeFace);
                    }
                }
                else
                {
                    Face RecognizeFace = new Face(detector.facesLocation[i], detector.bmp.ToBitmap(), name, faceEncoding);

                    detector.faces.Add(RecognizeFace);
                }
            }
        }

        public void Recognize(MyDetector detector)
        {
            faces = new List<Face>();

            //var img = detector.bmp.ToImage<Bgr, byte>().Copy(new Rectangle(0, 0, detector.bmp.Width, detector.bmp.Height));

            //Bitmap newBmp = detector.bmp.Clone(new Rectangle(0, 0, detector.bmp.Width, detector.bmp.Height), detector.bmp.PixelFormat);
            #region Line
            List<FaceRecognitionDotNet.FaceEncoding> knownEncodings = new List<FaceRecognitionDotNet.FaceEncoding>();
            foreach (var face in TrainFaces)
            {
                knownEncodings.Add(face.encoding);
            }

            foreach (var faceLocation in detector.facesLocation2)
            {
                FaceRecognitionDotNet.FaceEncoding faceEncoding = detector.libraryRecognizer.FaceEncoding(
                           FaceRecognitionDotNet.FaceRecognition.LoadImage(detector.bmp.ToBitmap()), faceLocation, 1,
                           FaceRecognitionDotNet.PredictorModel.Large, FaceRecognitionDotNet.Model.Cnn);


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

                    Face RecognizeFace = new Face(LocToRec(faceLocation), detector.bmp.ToBitmap(), name, faceEncoding);

                    detector.faces.Add(RecognizeFace);

                    if (Configs.EvidenceNames.Contains(name))
                    {
                        EvidenceDetect = true;
                        RecogEvidFaces.Add(RecognizeFace);
                    }
                }
                else
                {
                    Face RecognizeFace = new Face(LocToRec(faceLocation), detector.bmp.ToBitmap(), name, faceEncoding);

                    detector.faces.Add(RecognizeFace);
                }
            }
            #endregion

            #region Thread
            //List<Task> tasks = new List<Task>();
            //int ii = -1;
            //foreach (var faceLocation in detector.facesLocation2)
            //{
            //    var loc = faceLocation;
            //    Bitmap newBmp = detector.bmp.Clone(new Rectangle(0, 0, detector.bmp.Width, detector.bmp.Height), detector.bmp.PixelFormat);
            //    ii++;
            //    int f = ii;

            //    Task t = new Task(() =>
            //    {
            //        //FaceRecognitionDotNet.FaceRecognition lib = FaceRecognitionDotNet.FaceRecognition.Create("Models");

            //        FaceRecognitionDotNet.FaceEncoding faceEncoding = detector.libraryRecognizer.FaceEncoding(
            //           FaceRecognitionDotNet.FaceRecognition.LoadImage(newBmp), loc, 1,
            //           FaceRecognitionDotNet.PredictorModel.Large, FaceRecognitionDotNet.Model.Cnn);

            //        List<FaceRecognitionDotNet.FaceEncoding> knownEncodings = new List<FaceRecognitionDotNet.FaceEncoding>();
            //        foreach (var face in TrainFaces)
            //        {
            //            knownEncodings.Add(face.encoding);
            //        }
            //        double[] distances = FaceRecognitionDotNet.FaceRecognition.FaceDistances(knownEncodings, faceEncoding).ToArray();

            //        string name = "Неизвестное лицо";
            //        int bestMatchIndex = -1;
            //        double minDistance = 1;
            //        for (int i = 0; i < distances.Count(); i++)
            //        {
            //            if (distances[i] < minDistance)
            //            {
            //                minDistance = distances[i];
            //                bestMatchIndex = i;
            //            }
            //        }

            //        if (minDistance < Configs.PorogDouble)
            //        {
            //            name = TrainFaces[bestMatchIndex].name;

            //            //if (Configs.EvidenceNames.Contains(name))
            //            //{
            //            //    if (!Informator.DetectedFaces.Contains(TrainFaces[bestMatchIndex]))
            //            //    {
            //            //        Informator.PlaySignal();
            //            //        Informator.DetectedFaces.Add(TrainFaces[bestMatchIndex]);
            //            //        if (File.Exists("phones.txt"))
            //            //        {
            //            //            List<string> phones = new List<string>();
            //            //            string filename = "phones.txt";
            //            //            using (FileStream fs = new FileStream(filename, FileMode.Open))
            //            //            {
            //            //                FileInfo file = new FileInfo(filename);
            //            //                byte[] bytes = new byte[file.Length];
            //            //                fs.Read(bytes, 0, bytes.Length);
            //            //                string Phones = System.Text.Encoding.UTF8.GetString(bytes);

            //            //                foreach (var phone in Phones.Replace("\r\n", "\n").Split('\n'))
            //            //                {
            //            //                    phones.Add(phone);
            //            //                }
            //            //            }

            //            //            Informator.SendMsg("Обнаружен преступник - " + name, phones.ToArray());
            //            //        }
            //            //    }
            //            //}
            //        }


            //        Face RecognizeFace = new Face(LocToRec(faceLocation), newBmp, name, faceEncoding);

            //        detector.faces.Add(RecognizeFace);
            //    });
            //    t.Start();
            //    tasks.Add(t);
            //}

            //Task.WaitAll(tasks.ToArray());
            #endregion
        }

        public bool EvidenceDetect = false;
        public List<Face> RecogEvidFaces = new List<Face>();
        public void Recognize2(MyDetector detector, int thread, int numJitters = 1,
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
                    //FaceRecognitionDotNet.FaceRecognition lib = FaceRecognitionDotNet.FaceRecognition.Create("Models");

                    FaceRecognitionDotNet.FaceEncoding faceEncoding = MyRecognizer.libs[thread].FaceEncoding(
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

                        Face RecognizeFace = new Face(LocToRec(faceLocation), detector.bmp.ToBitmap(), name, faceEncoding);

                        detector.faces.Add(RecognizeFace);

                        if (Configs.EvidenceNames.Contains(name)) 
                        {
                            EvidenceDetect = true;
                            RecogEvidFaces.Add(RecognizeFace);
                        }
                    }
                    else
                    {
                        Face RecognizeFace = new Face(LocToRec(faceLocation), detector.bmp.ToBitmap(), name, faceEncoding);

                        detector.faces.Add(RecognizeFace);
                    }



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



        //public void Recognize(MyDetector[] detectors)
        //{
        //    List<Task> tasks = new List<Task>();
        //    foreach (var detector in detectors)
        //    {
        //        Task t = new Task(() =>
        //        {
        //            Recognize2(detector);
        //            detector.DrawRectanglesWithNames();
        //        });
        //        t.Start();
        //        tasks.Add(t);
        //    }

        //    Task.WaitAll(tasks.ToArray());

        //    tasks.Clear();
        //    tasks = null;
        //}

        //public void Recognize2(MyDetector detector)
        //{
        //    faces = new List<Face>();

        //    foreach (var faceLocation in detector.facesLocation2)
        //    {
        //        FaceRecognitionDotNet.FaceEncoding faceEncoding = Configs.libraryRecognizer.FaceEncoding(
        //            FaceRecognitionDotNet.FaceRecognition.LoadImage(detector.bmp), faceLocation, 1,
        //            FaceRecognitionDotNet.PredictorModel.Large, FaceRecognitionDotNet.Model.Cnn);



        //        List<FaceRecognitionDotNet.FaceEncoding> knownEncodings = new List<FaceRecognitionDotNet.FaceEncoding>();
        //        foreach (var face in TrainFaces)
        //        {
        //            knownEncodings.Add(face.encoding);
        //        }
        //        double[] distances = FaceRecognitionDotNet.FaceRecognition.FaceDistances(knownEncodings, faceEncoding).ToArray();

        //        string name = "Неизвестное лицо";
        //        int bestMatchIndex = -1;
        //        double minDistance = 1;
        //        for (int i = 0; i < distances.Count(); i++)
        //        {
        //            if (distances[i] < minDistance)
        //            {
        //                minDistance = distances[i];
        //                bestMatchIndex = i;
        //            }
        //        }

        //        if (minDistance < Configs.PorogDouble)
        //        {
        //            name = TrainFaces[bestMatchIndex].name;

        //            if (Configs.EvidenceNames.Contains(name))
        //            {
        //                Informator.PlaySignal();
        //                //detector.bmp.Save("Evidence.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        //            }
        //        }

        //        Bitmap bmp = detector.bmp;


        //        Face RecognizeFace = new Face(LocToRec(faceLocation), bmp, name, faceEncoding);

        //        detector.faces.Add(RecognizeFace);
        //    }
        //}

        //public void Recognize(MyDetector detector)
        //{
        //    //Faces = new Dictionary<FaceRecognitionDotNet.FaceEncoding, Face>();
        //    faces = new List<Face>();
        //    //Bitmap currentBitmap = detector.bmp;

        //    foreach (var faceLocation in detector.facesLocation2)
        //    {
        //        FaceRecognitionDotNet.FaceEncoding faceEncoding = Configs.libraryRecognizer.FaceEncoding(
        //            FaceRecognitionDotNet.FaceRecognition.LoadImage(detector.bmp), faceLocation, 1,
        //            FaceRecognitionDotNet.PredictorModel.Large, FaceRecognitionDotNet.Model.Cnn);

        //        List<FaceRecognitionDotNet.FaceEncoding> knownEncodings = new List<FaceRecognitionDotNet.FaceEncoding>();
        //        foreach (var face in TrainFaces)
        //        {
        //            knownEncodings.Add(face.encoding);
        //        }
        //        double[] distances = FaceRecognitionDotNet.FaceRecognition.FaceDistances(knownEncodings, faceEncoding).ToArray();

        //        string name = "Неизвестное лицо";
        //        int bestMatchIndex = -1;
        //        double minDistance = 1;
        //        for (int i = 0; i < distances.Count(); i++)
        //        {
        //            if (distances[i] < minDistance)
        //            {
        //                minDistance = distances[i];
        //                bestMatchIndex = i;
        //            }
        //        }

        //        if (minDistance < Configs.PorogDouble)
        //        {
        //            name = TrainFaces[bestMatchIndex].name;

        //            if (Configs.EvidenceNames.Contains(name))
        //            {
        //                Informator.PlaySignal();

        //                //DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        //                //int evidencePhotos = 0;
        //                //foreach(var file in directory.GetFiles())
        //                //{
        //                //    if (file.Name.ToLower().Contains("evidence"))
        //                //    {
        //                //        evidencePhotos++;
        //                //    }
        //                //}
        //                //detector.faces = faces;
        //                //detector.DrawRectanglesWithNames();
        //                //detector.bmp.Save($"Evidence.{evidencePhotos}.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        //            }

        //        }

        //        Bitmap bmp = null;

        //        bmp = detector.bmp.ToImage<Bgr, byte>()
        //            .Copy(LocToRec(faceLocation)).ToBitmap();

        //        Face RecognizeFace = new Face(LocToRec(faceLocation), bmp, name, faceEncoding);

        //        faces.Add(RecognizeFace);
        //        detector.faces.Add(RecognizeFace);
        //    }
        //}


        private Rectangle LocToRec(FaceRecognitionDotNet.Location location)
        {
            return new Rectangle(
                new Point(location.Left, location.Top),
                new Size(location.Right - location.Left, location.Bottom - location.Top)
            );
        }
    }
}
