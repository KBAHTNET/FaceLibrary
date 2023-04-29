using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using FaceONNX;
using System;

namespace FaceLibrary
{
    public class MyDetector
    {
        public Mat bmp;
        public int frameNumber;
        //public Frame fr;

        public Rectangle[] facesLocation;
        public FaceRecognitionDotNet.Location[] facesLocation2;

        public FaceRecognitionDotNet.FaceRecognition libraryRecognizer;
        private bool IsDisposeLibrary;

        public List<Face> faces;

        public MyDetector(Mat image, bool InitLibrary = true)
        {
            bmp = image;
            faces = new List<Face>();

            if (InitLibrary)
            {
                IsDisposeLibrary = true;
                libraryRecognizer = FaceRecognitionDotNet.FaceRecognition.Create("Models");
            }
        }

        public MyDetector(bool InitLibraty = true)
        {
            faces = new List<Face>();

            if (InitLibraty)
            {
                IsDisposeLibrary = true;
                libraryRecognizer = FaceRecognitionDotNet.FaceRecognition.Create("Models");
            }
        }

        public MyDetector(Mat image, FaceRecognitionDotNet.FaceRecognition library)
        {
            bmp = image;
            IsDisposeLibrary = false;
            libraryRecognizer = library;
            faces = new List<Face>();
        }

        public MyDetector(FaceRecognitionDotNet.FaceRecognition library)
        {
            IsDisposeLibrary = false;
            libraryRecognizer = library;
            faces = new List<Face>();
        }

        ~MyDetector()
        {
            if (IsDisposeLibrary)
                libraryRecognizer.Dispose();

            bmp = null;
            facesLocation = null;
            facesLocation2 = null;

            faces = null;
        }

        public void Dispose()
        {
            if (IsDisposeLibrary)
                libraryRecognizer.Dispose();

            bmp = null;
            facesLocation = null;
            facesLocation2 = null;

            faces = null;
        }

        public void DetectFaces()
        {
            facesLocation = GetFacesLocation();
            facesLocation2 = new FaceRecognitionDotNet.Location[facesLocation.Length];
            for (int i = 0; i < facesLocation.Length; i++) facesLocation2[i] = RecToLoc(facesLocation[i]);
        }

        private Rectangle[] GetFacesLocation()
        {
            List<Rectangle> facesLocation = new List<Rectangle>();

            if (Configs.chosenAlgoritmDetection == Configs.AlgoritmDetection.Hog)
            {
                if (Configs.IsResizeFrame)
                {
                    var resizeBmp = bmp.ToImage<Bgr, byte>().Resize(Configs.PictureResize.Width, Configs.PictureResize.Height, Inter.Cubic).Mat;

                    using (var unknownImage = FaceRecognitionDotNet.FaceRecognition.LoadImage(resizeBmp.ToBitmap()))
                    {
                        var faceLocations = libraryRecognizer.FaceLocations(unknownImage, 1, FaceRecognitionDotNet.Model.Hog).ToArray();

                        foreach (var faceLocation in faceLocations)
                        {
                            facesLocation.Add(LocToRec(faceLocation));
                        }
                    }

                    bmp = resizeBmp;
                }
                else
                {
                    using (var unknownImage = FaceRecognitionDotNet.FaceRecognition.LoadImage(bmp.ToBitmap()))
                    {
                        var faceLocations = libraryRecognizer.FaceLocations(unknownImage, 1, FaceRecognitionDotNet.Model.Hog).ToArray();

                        foreach (var faceLocation in faceLocations)
                        {
                            facesLocation.Add(LocToRec(faceLocation));
                        }
                    }
                }
            }
            if (Configs.chosenAlgoritmDetection == Configs.AlgoritmDetection.Cnn)
            {
                if (Configs.IsResizeFrame)
                {
                    var resizeBmp = bmp.ToImage<Bgr, byte>().Resize(Configs.PictureResize.Width, Configs.PictureResize.Height, Inter.Cubic).ToBitmap();

                    using (var unknownImage = FaceRecognitionDotNet.FaceRecognition.LoadImage(resizeBmp))
                    {
                        var faceLocations = libraryRecognizer.FaceLocations(unknownImage, 1, FaceRecognitionDotNet.Model.Cnn).ToArray();

                        foreach (var faceLocation in faceLocations)
                        {
                            facesLocation.Add(LocToRec(faceLocation));
                        }
                    }
                }
                else
                {
                    using (var unknownImage = FaceRecognitionDotNet.FaceRecognition.LoadImage(bmp.ToBitmap()))
                    {
                        var faceLocations = libraryRecognizer.FaceLocations(unknownImage, 1, FaceRecognitionDotNet.Model.Cnn).ToArray();

                        foreach (var faceLocation in faceLocations)
                        {
                            facesLocation.Add(LocToRec(faceLocation));
                        }
                    }
                }
            }
            if (Configs.chosenAlgoritmDetection == Configs.AlgoritmDetection.Haar)
            {
                Mat m = bmp.ToImage<Bgr, byte>().Mat;
                Rectangle[] detectedObjectsByHaar1 = null;

                if (Configs.IsResizeFrame)
                {
                    detectedObjectsByHaar1 = Configs.haarFaceCascade.DetectMultiScale
                        (m.ToImage<Gray, byte>().Resize(Configs.PictureResize.Width, Configs.PictureResize.Height, Inter.Cubic),
                        Configs.multiScale, Configs.minNeig, Configs.MinFaceSize);

                    bmp = bmp.ToImage<Bgr, byte>().Resize(Configs.PictureResize.Width, Configs.PictureResize.Height, Inter.Cubic).Mat;
                }
                if (!Configs.IsResizeFrame)
                {
                    detectedObjectsByHaar1 = Configs.haarFaceCascade.DetectMultiScale
                        (m.ToImage<Gray, byte>(),
                        Configs.multiScale, Configs.minNeig, Configs.MinFaceSize);
                }

                facesLocation = detectedObjectsByHaar1.ToList();
            }
            if (Configs.chosenAlgoritmDetection == Configs.AlgoritmDetection.FasterR_CNN)
            {
                if (Configs.IsResizeFrame)
                {
                    var resizeBmp = bmp.ToImage<Bgr, byte>().Resize(Configs.PictureResize.Width, Configs.PictureResize.Height, Inter.Cubic).Mat;
                    var faceDetectorLight = new FaceDetectorLight(0.75f, 0.25f);
                    facesLocation = faceDetectorLight.Forward(resizeBmp.ToBitmap()).ToList();

                    bmp = resizeBmp;
                }
                else
                {
                    var faceDetectorLight = new FaceDetectorLight(0.75f, 0.25f);
                    facesLocation = faceDetectorLight.Forward(bmp.ToBitmap()).ToList();
                }
            }
            return facesLocation.ToArray();
        }

        private FaceRecognitionDotNet.Location RecToLoc(Rectangle rectangle)
        {
            return new FaceRecognitionDotNet.Location(rectangle.X, rectangle.Y, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);
        }

        private Rectangle LocToRec(FaceRecognitionDotNet.Location location)
        {
            return new Rectangle(
                new Point(location.Left, location.Top),
                new Size(location.Right - location.Left, location.Bottom - location.Top)
            );
        }

        public void DrawRectangles(System.Drawing.Drawing2D.SmoothingMode quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality)
        {
            if (Configs.IsResizeFrame)
            {
                var resizeBmp = bmp.ToImage<Bgr, byte>().Resize(Configs.PictureResize.Width, Configs.PictureResize.Height, Inter.Cubic).Mat;

                using (Graphics g = Graphics.FromImage(resizeBmp.ToBitmap()))
                {
                    g.SmoothingMode = quality;

                    foreach (var faceLocation in facesLocation)
                    {
                        g.DrawRectangle(new Pen(Configs.ColorFrontal, Configs.PenSize), faceLocation);
                    }

                    bmp = resizeBmp;
                }
            }
            else
            {
                using (Graphics g = Graphics.FromImage(bmp.ToBitmap()))
                {
                    g.SmoothingMode = quality;

                    foreach (var faceLocation in facesLocation)
                    {
                        g.DrawRectangle(new Pen(Configs.ColorFrontal, Configs.PenSize), faceLocation);
                    }
                }
            }
            if (Configs.IsDrawFaceLandmarks)
            {
                DrawFaceLandmarks();
            }
        }

        public void DrawRectanglesWithNames(List<Face> faces, System.Drawing.Drawing2D.SmoothingMode quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality)
        {
            int fontSize = 12;

            if (Configs.IsResizeFrame)
            {
                var resizeBmp = bmp.ToImage<Bgr, byte>().Resize(Configs.PictureResize.Width, Configs.PictureResize.Height, Inter.Cubic).Mat;

                using (Graphics g = Graphics.FromImage(resizeBmp.ToBitmap()))
                {
                    g.SmoothingMode = quality;

                    foreach (var face in faces)
                    {
                        Rectangle rect = face.GetRectangle();
                        FaceRecognitionDotNet.Location faceLocation = face.GetLocation();

                        Pen currentPen = null;
                        if (!Configs.EvidenceNames.Contains(face.name))
                        {
                            currentPen = new Pen(Configs.ColorFrontal, Configs.PenSize);
                        }
                        else
                        {
                            currentPen = new Pen(Configs.ColorEvidenceFrontal, Configs.PenSize);
                        }

                        g.DrawRectangle(currentPen, rect);

                        if (!face.name.Contains("Неизвестное лицо"))
                        {
                            g.FillRectangle(new SolidBrush(currentPen.Color), new Rectangle(new Point
                                (Convert.ToInt32(faceLocation.Left),
                                    Convert.ToInt32(faceLocation.Top)),
                                new Size
                                (faceLocation.Right - faceLocation.Left, (faceLocation.Bottom - faceLocation.Top) / 7)));

                            g.DrawString($"{face.name}",
                                new Font("Times New Roman", (faceLocation.Bottom - faceLocation.Top) / 9),
                                new SolidBrush(Configs.FontColor), faceLocation.Left, faceLocation.Top - 2);
                        }
                        //else
                        //    g.DrawString($"{face.name}",
                        //        new Font("Times New Roman", (faceLocation.Bottom - faceLocation.Top) / 9),
                        //        new SolidBrush(Configs.FontColor), faceLocation.Left, faceLocation.Top - 2);

                        fontSize = (faceLocation.Bottom - faceLocation.Top) / 9;
                    }

                    bmp = resizeBmp;
                }
            }
            else
            {
                using (Graphics g = Graphics.FromImage(bmp.ToBitmap()))
                {
                    g.SmoothingMode = quality;

                    foreach (var face in faces)
                    {
                        Rectangle rect = face.GetRectangle();
                        FaceRecognitionDotNet.Location faceLocation = face.GetLocation();

                        Pen currentPen = null;
                        if (!Configs.EvidenceNames.Contains(face.name))
                        {
                            currentPen = new Pen(Configs.ColorFrontal, Configs.PenSize);
                        }
                        else
                        {
                            currentPen = new Pen(Configs.ColorEvidenceFrontal, Configs.PenSize);
                        }

                        g.DrawRectangle(currentPen, rect);

                        if (!face.name.ToLower().Contains("неизвестное лицо"))
                        {
                            g.FillRectangle(new SolidBrush(currentPen.Color), new Rectangle(new Point
                                (Convert.ToInt32(faceLocation.Left),
                                    Convert.ToInt32(faceLocation.Top)),
                                new Size
                                (faceLocation.Right - faceLocation.Left, (faceLocation.Bottom - faceLocation.Top) / 7)));

                            g.DrawString($"{face.name}",
                                new Font("Times New Roman", (faceLocation.Bottom - faceLocation.Top) / 9),
                                new SolidBrush(Configs.FontColor), faceLocation.Left, faceLocation.Top - 1.8f);
                        }
                        //else
                        //    g.DrawString($"{face.name}",
                        //        new Font("Times New Roman", (faceLocation.Bottom - faceLocation.Top) / 9),
                        //        new SolidBrush(Configs.FontColor), faceLocation.Left, faceLocation.Top - 1.8f);

                        fontSize = (faceLocation.Bottom - faceLocation.Top) / 9;
                    }
                }
            }
            if (Configs.IsDrawFaceLandmarks) DrawFaceLandmarks(fontSize);
            //fr.frame = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), bmp.PixelFormat).ToImage<Bgr,byte>();
        }

        public void DrawRectanglesWithNames(System.Drawing.Drawing2D.SmoothingMode quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality)
        {
            DrawRectanglesWithNames(this.faces, quality);
        }

        public void DrawRectanglesWithNames(Face[] faces, System.Drawing.Drawing2D.SmoothingMode quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality)
        {
            List<Face> _faces = faces.ToList();
            DrawRectanglesWithNames(_faces, quality);
        }

        public void DrawFaceLandmarks(int FontSize = 12)
        {
            int i = 0;

            var points = Configs.libraryRecognizer.FaceLandmark(FaceRecognitionDotNet.FaceRecognition.LoadImage(bmp.ToBitmap()), 
                null, Configs.PredictorModel, Configs.Model);

            using (Graphics g = Graphics.FromImage(bmp.ToBitmap()))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                Pen pen = new Pen(Color.Green, Configs.PenSize);
                Font f = new Font(FontFamily.GenericSerif.Name, 12f, FontStyle.Regular);
                foreach (var dict in points)
                {
                    foreach (var point in dict)
                    {
                        foreach (var p in point.Value)
                        {
                            g.FillEllipse(new SolidBrush(Color.Red), p.Point.X - 2, p.Point.Y - 2, 4, 4);
                            if (Configs.IsDrawCiphers)
                            {
                                i++;
                                g.DrawString(i.ToString(), f, new SolidBrush(Color.Black), p.Point.X - 4, p.Point.Y - 4);
                            }
                        }
                    }
                    i = 0;
                }
            }
        }
    }
}
