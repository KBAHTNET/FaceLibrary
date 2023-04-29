using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using CustomDesign;
using CustomDesign.Components;
using CustomDesign.Controls;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;

using FaceONNX;
using FaceONNX.Core;

namespace FaceLibrary
{
    public partial class MainForm : ShadowedForm
    {

        public static VideoCapture capture;
        public Mat m = new Mat();

        public static int selectCamId = 0;

        //для добавления лиц в боковое окно imagebox  с интервалом
        public System.Windows.Forms.Timer timer; //устанавливает интерва, в течение которого создается список обнаруженных лиц

        //public static List<string> DetectedFacesYet = new List<string>(); //список уже обнаруженых лиц за установленный интервал
        //public static List<Image<Bgr, byte>> detectedFaces = new List<Image<Bgr, byte>>(); //список обнаруженных лиц

        public static List<Face> DetectedFaces = new List<Face>();
        public static List<Face> DetectedFacesYet = new List<Face>();


        #region Контролы, создающие динамические элементы на форме
        #region Картинки рядом с кнопками
        private PictureBox pbCam = new PictureBox();
        private PictureBox pbVideo = new PictureBox();
        private PictureBox pbSettings = new PictureBox();
        private PictureBox pbWebCam = new PictureBox();
        private PictureBox pbPhoto = new PictureBox();
        private PictureBox pbStop = new PictureBox();
        private PictureBox pbAdd = new PictureBox();
        private PictureBox pbTrain = new PictureBox();
        #endregion
        #region Контрол переключения при закрытом меню
        /*private PictureBox pb2 = new PictureBox();
        private CustomButton strelka1 = new CustomButton();
        private CustomButton strelka2 = new CustomButton();
        private Label cifra = new Label();*/
        #endregion
        #endregion


        public MainForm()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000 * Configs.secondsInterval;
            timer.Tick += Timer_Tick;

            Animator.Start();//анимация для кастомных элементов
            InitializeComponent();

            Configs.InitFindNames("evidenceNames.txt");

            timer.Start();

            #region Инициализация динамичских элементов

            pb.Location = new Point(0, 0);
            pb.Size = new Size(40, 36);
            this.pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Visible = false;
            pb.Enabled = true;
            pb.Click += new EventHandler(menuOpen_Click);
            frameBox.Controls.Add(pb);

            this.Size = new Size(1024, 768);

            Image gifMenu = Properties.Resources.Меню;
            foreach (Image manuFrame in Frames(gifMenu))
            {
                menuFrames.Add(manuFrame);
            }
            MenuPicrureBox.Image = menuFrames[0];
            pb.Image = menuFrames[0];


            pbCam.Location = new Point(-2, -2);
            pbCam.Size = new Size(40, 40);
            pbCam.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCam.Image = Properties.Resources.CamPicture;
            CameraButton.Controls.Add(pbCam);

            pbVideo.Location = new Point(0, 0);
            pbVideo.Size = new Size(39, 39);
            pbVideo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVideo.Image = Properties.Resources.VideoPicture;
            VideoButton.Controls.Add(pbVideo);

            pbWebCam.Location = new Point(-3, -3);
            pbWebCam.Size = new Size(40, 40);
            pbWebCam.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWebCam.Image = Properties.Resources.WebCamPicture;
            WebCamButton.Controls.Add(pbWebCam);

            pbSettings.Location = new Point(0, 0);
            pbSettings.Size = new Size(39, 39);
            pbSettings.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSettings.Image = Properties.Resources.SettingsPicture;
            SettingsButton.Controls.Add(pbSettings);

            pbPhoto.Location = new Point(0, 0);
            pbPhoto.Size = new Size(39, 39);
            pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPhoto.Image = Properties.Resources.PhotoPicture;
            PhotoButton.Controls.Add(pbPhoto);

            pbStop.Location = new Point(0, 0);
            pbStop.Size = new Size(39, 39);
            pbStop.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStop.Image = Properties.Resources.StopPicture;
            StopButton.Controls.Add(pbStop);

            pbAdd.Location = new Point(0, 0);
            pbAdd.Size = new Size(39, 39);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.Image = Properties.Resources.AddPicture;
            AddButton.Controls.Add(pbAdd);

            pbTrain.Location = new Point(1, 1);
            pbTrain.Size = new Size(37, 37);
            pbTrain.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTrain.Image = Properties.Resources.trainPicture;
            TrainButton.Controls.Add(pbTrain);


            /*pb2.Location = new Point(frameBox.Width - 220, frameBox.Height - 220);
            pb2.Size = new Size(180, 180);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            frameBox.Controls.Add(pb2);

            strelka1.Text = "<";
            strelka1.RoundingEnable = true;
            strelka1.Size = new Size(20, 20);
            strelka1.Location = new Point(pb.Location.X, pb2.Location.Y + pb.Height + 5);

            strelka2.Text = ">";
            strelka2.RoundingEnable = true;
            strelka2.Size = new Size(20, 20);
            strelka2.Location = new Point(pb.Location.X + pb.Width, pb2.Location.Y + pb.Height + 5);

            cifra.Text = "3/15 лиц";
            cifra.ForeColor = Color.Lime;
            cifra.BackColor = Color.Transparent;
            cifra.Location = new Point(strelka1.Location.X + strelka1.Width + 5, strelka1.Location.Y);

            frameBox.Controls.Add(strelka1);
            frameBox.Controls.Add(strelka2);
            frameBox.Controls.Add(cifra);*/
            #endregion
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DetectedFacesYet.Clear();
        }



        #region Установка размеров и позиции динамических элементов
        private void frameBox_SizeChanged(object sender, EventArgs e)
        {
            /*pb2.Location = new Point(frameBox.Width - 220, frameBox.Height - 220);
            strelka1.Location = new Point(pb2.Location.X, pb2.Location.Y + pb2.Height + 2);
            strelka2.Location = new Point(pb2.Location.X + pb2.Width - 20, pb2.Location.Y + pb2.Height + 2);
            cifra.Location = new Point(pb2.Location.X + pb2.Width / 2, pb2.Location.Y + pb2.Width + 2);*/
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            mainPanel.Size = new Size(this.Width - 4, this.Height - 32);
            mainPanel.Location = new Point(2, 31);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainPanel.Size = new Size(this.Width - 4, this.Height - 32);
            mainPanel.Location = new Point(2, 31);
        }
        #endregion

        #region Меню

        private List<Image> menuFrames = new List<Image>();
        private static bool open = false;
        private PictureBox pb = new PictureBox();
        private void menuClose_Click(object sender, EventArgs e)
        {
            run = true;
            Thread t = new Thread(() => Animate());
            t.Start();


            try
            {
                while (mainPanel.ColumnStyles[0].Width > 1)
                {
                    mainPanel.ColumnStyles[0].Width -= 15;
                    Refresh();
                }
            }
            catch { }
            mainPanel.ColumnStyles[0].Width = 0;
            ElementsMenuPanel.Visible = false;
            MenuPicrureBox.Visible = false;
            pb.Visible = true;

            run = false;

            mainPanel.ColumnStyles[0].Width = 0;

            MenuPicrureBox.Image = menuFrames[0];
            pb.Image = menuFrames[0];
            open = false;

            /*pb2.Visible = true;
            strelka1.Visible = true;
            strelka2.Visible = true;
            cifra.Visible = true;*/
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            pb.Visible = false;
            ElementsMenuPanel.Visible = true;
            MenuPicrureBox.Visible = true;

            /*pb2.Visible = false;
            strelka1.Visible = false;
            strelka2.Visible = false;
            cifra.Visible = false;*/

            run = true;
            Thread t = new Thread(() => Animate());
            t.Start();

            try
            {
                while (mainPanel.ColumnStyles[0].Width < 200)
                {
                    mainPanel.ColumnStyles[0].Width += 15;
                    Refresh();
                }
            }
            catch { }

            run = false;

            MenuPicrureBox.Image = menuFrames[58];
            pb.Image = menuFrames[58];
            open = true;
        }


        private static IEnumerable<Image> Frames(Image gif)
        {
            FrameDimension d = new FrameDimension(gif.FrameDimensionsList[0]);
            for (int i = 0; i < gif.GetFrameCount(d); i++)
            {
                gif.SelectActiveFrame(d, i);
                Bitmap ci = new Bitmap(gif.Width, gif.Height);
                using (Graphics g = Graphics.FromImage(ci))
                    g.DrawImageUnscaled(gif, 0, 0);
                yield return ci;
            }
        }


        private bool run = false;
        private void Animate()
        {
            if (open)
            {
                int k = 58;
                while (run)
                {
                    try
                    {
                        MenuPicrureBox.Image = menuFrames[k];
                        pb.Image = menuFrames[k];
                        pb.Image = menuFrames[k];
                    }
                    catch { }
                    Thread.Sleep(20);
                    k++;
                    if (k > menuFrames.Count - 1) k = 0;
                }
            }
            else
            {
                int k = 0;
                while (run)
                {
                    try
                    {
                        MenuPicrureBox.Image = menuFrames[k];
                        pb.Image = menuFrames[k];
                    }
                    catch { }
                    Thread.Sleep(20);
                    k++;
                    if (k > menuFrames.Count - 62) k = 0;
                }
            }
        }

        #endregion

        #region MouseMove - Cursor.Default
        private void menuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            customMainFormStyle.BorderHoverPosition = CustomFormStyle.BorderHoverPositionEnum.None;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            customMainFormStyle.BorderHoverPosition = CustomFormStyle.BorderHoverPositionEnum.None;
        }

        private void ElementsMenuPanel_MouseMove(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            customMainFormStyle.BorderHoverPosition = CustomFormStyle.BorderHoverPositionEnum.None;
        }

        private void frameBox_MouseMove(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            customMainFormStyle.BorderHoverPosition = CustomFormStyle.BorderHoverPositionEnum.None;
        }
        #endregion

        #region Кнопки для выбора способа получения картинки
        private void CameraButton_Click(object sender, EventArgs e)
        {
            ChoseCamForm choseCamForm = new ChoseCamForm();
            choseCamForm.ShowDialog();
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выбрать видео";
            ofd.Filter = "Видео файлы|*.mp4;*.mkv;*.avi;*.mpeg;*.webm;*.wmv|Все файлы|*.*";
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (capture != null)
                        if (capture.IsOpened)
                            capture.Stop();
                }
                finally
                {
                    try
                    {
                        if (capture != null)
                            capture.Dispose();
                    }
                    finally
                    {
                        capture = new VideoCapture(ofd.FileName);
                        capture.ImageGrabbed += GetFrame_FaceRecognitionDotNet;
                        capture.Start();
                    }
                }
            }
        }

        private void WebCamButton_Click(object sender, EventArgs e)
        {
            string WebCamAdress = InputMessageBox.ShowMessage("Введите url камеры. Пример: \"http://<username:password>@<ip_address>/video.cgi?.mjpg\"");


            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
            foreach (string IP in WebCamAdress.Split('/'))
            {
                if (IP.Split('.').Length == 4)
                {
                    try
                    {
                        System.Net.NetworkInformation.PingReply reply = ping.Send(IP.Split(':')[0]);
                        MessageBox.Show($"IP: {reply.Address} Status: {reply.Status} Time: {reply.RoundtripTime} ms", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                        {
                            MessageBox.Show("Соединение может быть установлено", "Информация");

                            try
                            {
                                if (capture != null)
                                    if (capture.IsOpened)
                                        capture.Stop();
                            }
                            finally
                            {
                                try
                                {
                                    if (capture != null)
                                        capture.Dispose();
                                }
                                finally
                                {
                                    capture = new VideoCapture(WebCamAdress);
                                    capture.ImageGrabbed += GetFrame_FaceRecognitionDotNet;
                                    capture.Start();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Соединение не может быть установлено", "Информация");
                        }
                    }
                    catch { MessageBox.Show("Соединение не может быть установлено", "Информация"); }
                }
            }
        }

        private void PhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите картинку";
            ofd.Filter = "Картинки|*.png;*.jpg;*.bmp";
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                Bitmap picture = (Bitmap)Image.FromFile(ofd.FileName);
                m = picture.ToImage<Bgr, byte>().Mat;

                //var locations = Configs.libraryRecognizer.FaceLocations(FaceRecognitionDotNet.FaceRecognition.LoadImage(picture));

                //int i = 0;
                //var points = Configs.libraryRecognizer.FaceLandmark(FaceRecognitionDotNet.FaceRecognition.LoadImage(picture), null, FaceRecognitionDotNet.PredictorModel.Small, FaceRecognitionDotNet.Model.Hog);
                //using (Graphics g = Graphics.FromImage(picture))
                //{
                //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //    Pen pen = new Pen(Color.Green, 3);
                //    Font f = new Font(FontFamily.GenericSerif.Name, 12f, FontStyle.Regular);
                //    foreach (var dict in points)
                //    {
                //        foreach (var point in dict)
                //        {
                //            foreach (var p in point.Value)
                //            {
                //                g.FillEllipse(new SolidBrush(Color.Red), p.Point.X - 2, p.Point.Y - 2, 4, 4);
                //                i++;
                //                g.DrawString(i.ToString(),f, new SolidBrush(Color.Black), p.Point.X - 4, p.Point.Y - 4);
                //                //g.DrawPolygon(pen,  new Point[](new p.Point.X,p.Point.Y))
                //            }
                //        }
                //    }
                //}
                //frameBox.Image = picture.ToImage<Bgr, byte>();
                // frameBox.Image = picture.ToImage<Bgr, byte>();

                MyDetector detector = new MyDetector(Configs.libraryRecognizer);
                detector.bmp = picture.ToImage<Bgr, byte>().Mat;

                DateTime time = DateTime.Now;
                detector.DetectFaces();
                TimeSpan elaps = DateTime.Now - time;/*new TimeSpan(DateTime.Now - time);*/

                int faces = detector.facesLocation.Count();

                if (Configs.IsUseRecognition)
                {
                    MyRecognizer.Recognize2(detector, 0, Configs.PredictorModel, Configs.Model);

                    detector.DrawRectanglesWithNames();
                }
                else
                {
                    detector.DrawRectangles();
                }
                frameBox.Image = detector.bmp;

                MessageBox.Show(elaps.TotalMilliseconds.ToString() + " миллисекунд" + "\n" + faces.ToString() + " обнаружено людей", "Время");
            }
        }


        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                capture.Stop();
            }
            catch { }
        }
        #endregion



        public static MyDetector FrameDetector = new MyDetector(Configs.libraryRecognizer);

        private Dictionary<int, Mat> mats2 = new Dictionary<int, Mat>();
        int RecognitFrameNum = 100;
        int DetectFrameNum = 100;

        Dictionary<string, Rectangle> savedRect = new Dictionary<string, Rectangle>();
        Dictionary<string, Point[]> vector = new Dictionary<string, Point[]>();
        List<Face> TempFaces = new List<Face>();

        private Queue<Frame> mats = new Queue<Frame>();
        int FrameNumber = 0;

        List<Task> FrameProcessing = new List<Task>();
        public void GetFrame_FaceRecognitionDotNet(object sender, EventArgs e)
        {
            if (!Configs.IsShowMiddleProccess)
            {
                Mat m2 = new Mat();
                capture.Retrieve(m2);
                
                Task t = new Task(() =>
                {
                    MyDetector detector = new MyDetector(m2);
                    detector.DetectFaces();

                    MyRecognizer2 recognizer = new MyRecognizer2(MyRecognizer.TrainFaces);
                    recognizer.Recognize0(detector);

                    if (recognizer.EvidenceDetect)
                    {
                        detector.DrawRectanglesWithNames();
                        frameBox.Image = detector.bmp;

                        var photoName = DateTime.UtcNow.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + ".bmp";

                        try  
                        {
                            detector.bmp.Save("FindingEvidence/" + photoName.Replace(':', '-'));  
                        }
                        finally
                        {
                            Informator.PlaySignal();
                        }
                    }

                });
                t.Start();
                FrameProcessing.Add(t);

                if (FrameProcessing.Count() > 30)
                {
                    Task.WaitAll(FrameProcessing.ToArray());
                    FrameProcessing.Clear();
                }

                //FrameProcessing.Add(t);
                //FrameNumber++;

                //if (FrameNumber + 1 >= MyRecognizer.ThreadsNumber)
                //{
                //    Task.WaitAll(FrameProcessing.ToArray());
                //    FrameProcessing.Clear();
                //    FrameProcessing = new List<Task>();

                //    Dictionary<int, Mat> frames = new Dictionary<int, Mat>();
                //    int matsCount = mats.Count();
                //    for(int i=0;i< matsCount; i++)
                //    {
                //        Frame frame = mats.Dequeue();
                //        frames.Add(frame.frameNum, frame.frame);
                //    }

                //    List<Mat> lframes = new List<Mat>();
                //    foreach(var f in frames.OrderBy(x => x.Key))
                //    {
                //        lframes.Add(f.Value);
                //    }
                //    frames.Clear();

                //    Thread thread = new Thread(() =>
                //    {
                //        for (int i = 0; i < lframes.Count; i++)
                //        {
                //            int f = i;
                //            BeginInvoke((MethodInvoker)(() => 
                //            {
                //                frameBox.Image = lframes[f];
                //                Thread.Sleep(50);
                //            }));
                //        }
                //    });
                //    thread.Start();

                //    FrameNumber = 0;
                //}

            }


            #region Line

            if (Configs.IsShowMiddleProccess)
            {
                m = new Mat();
                capture.Retrieve(m);
                FrameDetector.bmp = m;


                RecognitFrameNum++;
                DetectFrameNum++;

                if (Configs.IsUseRecognition)
                {
                    if (RecognitFrameNum > 30)
                    {
                        RecognitFrameNum = 0;
                        savedRect = new Dictionary<string, Rectangle>();

                        FrameDetector.DetectFaces();
                        MyRecognizer.Recognize2(FrameDetector, 0, Configs.PredictorModel, Configs.Model);
                        FrameDetector.DrawRectanglesWithNames();

                        TempFaces = FrameDetector.faces;

                        #region Добавление в список
                        foreach (var face in FrameDetector.faces)
                        {
                            if (!face.name.Contains("Неизвестное лицо"))
                            {
                                if (!DetectedFacesYet.Contains(face))
                                {
                                    try
                                    {
                                        int recognized = DetectedFaces.FindAll(f => f.name.Contains(face.name)).Count();

                                        Face newFace = new Face();
                                        newFace.bmp = face.bmp.Clone(face.GetRectangle(), face.bmp.PixelFormat);//.ToImage<Bgr, byte>().Copy(face.GetRectangle()).ToBitmap();
                                        newFace.name = face.name + recognized.ToString();

                                        DetectedFaces.Add(newFace);
                                        DetectedFacesYet.Add(newFace);

                                        BeginInvoke((MethodInvoker)(() =>
                                        {
                                            RecognitFacesList.Items.Add(newFace.name);
                                        }));
                                    }
                                    catch { }
                                }
                            }
                            else
                            {
                                try
                                {
                                    int unrecognized = DetectedFaces.FindAll(f => f.name.ToLower().Contains("неизвестное лицо")).Count();

                                    Face newFace = new Face();
                                    newFace.bmp = face.bmp.Clone(face.GetRectangle(), face.bmp.PixelFormat);//ToImage<Bgr, byte>().Copy(face.GetRectangle()).ToBitmap();
                                    newFace.name = face.name + unrecognized.ToString();

                                    DetectedFaces.Add(newFace);
                                    DetectedFacesYet.Add(newFace);

                                    BeginInvoke((MethodInvoker)(() =>
                                    {
                                        RecognitFacesList.Items.Add(newFace.name);
                                    }));
                                }
                                catch { }
                            }
                        }
                        #endregion

                    }
                    else
                    {
                        //if (DetectFrameNum > 8)
                        //{
                        FrameDetector.DetectFaces();

                        int minX = 1000, minY = 1000, locationNumber = -1;
                        for (int j = 0; j < TempFaces.Count(); j++)
                        {
                            for (int i = 0; i < FrameDetector.facesLocation.Count(); i++)
                            {

                                int distanceX = Math.Abs(FrameDetector.facesLocation[i].X - TempFaces[j].GetRectangle().X);
                                int distanceY = Math.Abs(FrameDetector.facesLocation[i].Y - TempFaces[j].GetRectangle().Y);
                                if (distanceX < minX && distanceY < minY)
                                {
                                    minX = distanceX;
                                    minY = distanceY;
                                    locationNumber = i;
                                }
                            }

                            if (locationNumber != -1 && minX < m.Size.Width / 30 && minY < m.Size.Height / 30)
                                TempFaces[j].SetLocation(FrameDetector.facesLocation[locationNumber]);
                            //else
                            //{
                            //    TempFaces.RemoveAt(j);
                            //}

                            minX = 1000;
                            minY = 1000;
                            locationNumber = -1;
                        }
                        //}

                        FrameDetector.faces = TempFaces;
                        FrameDetector.DrawRectanglesWithNames();
                    }

                }
                else
                {
                    FrameDetector.DetectFaces();
                    FrameDetector.DrawRectangles();
                }
                frameBox.Image = FrameDetector.bmp.ToImage<Bgr, byte>();

                FrameDetector.faces = new List<Face>();
            }

            #endregion



            #region TestThread

            ////List<Task> tasks = new List<Task>();
            ////for(int i = 0; i < 50; i++)
            ////{
            ////    Task t = new Task(() => 
            ////    {
            ////        Mat m2 = new Mat();
            ////        capture.Retrieve(m2);

            ////        tempStack.Enqueue(m2.ToBitmap());
            ////    });
            ////    t.Start();
            ////    tasks.Add(t);
            ////}
            ////Task.WaitAll(tasks.ToArray());


            //Task t1 = new Task(() =>
            //{
            //    Mat m2 = new Mat();
            //    capture.Retrieve(m2);
            //    frs.Add(m2.ToImage<Bgr, byte>());
            //});
            //t1.Start();

            //t1.Wait();

            //if (frs.Count > 50)
            //{
            //    List<Task> tasks = new List<Task>();
            //    for (int i = 0; i < frs.Count(); i++)
            //    {
            //        int g = i;
            //        Task t2 = new Task(() =>
            //        {
            //            MyDetector detector = new MyDetector();
            //            detector.bmp = frs[g].ToBitmap();
            //            detector.DetectFaces();

            //            if (Configs.IsUseRecognition)
            //            {
            //                MyRecognizer2 recognizer = new MyRecognizer2(MyRecognizer.TrainFaces);
            //                recognizer.Recognize2(detector);
            //                detector.DrawRectanglesWithNames();
            //                frs2.Add(detector.bmp.ToImage<Bgr, byte>());
            //            }
            //            else
            //            {
            //                detector.DrawRectangles();
            //            }
            //        });
            //        t2.Start();
            //        tasks.Add(t2);

            //    }

            //    Task.WaitAll(tasks.ToArray());
            //    tasks.Clear();

            //    Task t = new Task(() =>
            //    {
            //        for (int i = 0; i < frs2.Count(); i++)
            //        {
            //            try
            //            {
            //                frameBox.Image = frs2[i];
            //                Thread.Sleep(100);
            //            }
            //            catch (System.AccessViolationException) { break; }
            //        }
            //    });
            //    t.Start();
            //    t.Wait();
            //    frs.Clear();
            //    frs2.Clear();
            //}

            #endregion

            #region Thread

            //tempStack.Push(m.ToBitmap());

            //if (tempStack.Count >= 40)
            //{
            //    List<Task> tasks = new List<Task>();
            //    int stackCount = tempStack.Count;
            //    for (int i = 0; i < stackCount; i++)
            //    {
            //        Task t = new Task(() =>
            //         {
            //             MyDetector detector = new MyDetector();
            //             MyRecognizer2 recognizer = new MyRecognizer2();
            //             recognizer.knownEncodings = MyRecognizer.knownEncodings;
            //             recognizer.knownNames = MyRecognizer.knownNames;
            //             recognizer.TrainFaces = MyRecognizer.TrainFaces;
            //             detector.bmp = tempStack.Pop();
            //             detector.DetectFaces();
            //             recognizer.Recognize(detector);
            //             detector.DrawRectanglesWithNames(recognizer.faces);
            //             frames.Enqueue(detector.bmp);
            //             //MyDetector detector = new MyDetector(Configs.libraryRecognizer);
            //             //detector.bmp = tempStack.Pop();
            //             //detector.DetectFaces();
            //             //tempStack2.Push(detector);
            //         });
            //        t.Start();
            //        tasks.Add(t);
            //    }

            //    Task.WaitAll(tasks.ToArray());

            //    Task t2 = new Task(() => 
            //    {
            //        int FRCount = frames.Count;
            //        for (int i = 0; i < FRCount; i++)
            //        {
            //            frameBox.Image = frames.Dequeue().ToImage<Bgr, byte>();
            //            Task.Delay(50);
            //            //Thread.Sleep(10);
            //        }
            //    });
            //    t2.Start();

            //    //tasks.Clear();
            //    //tasks = null;

            //    //stackCount = tempStack2.Count;
            //    //MyDetector[] detectors = new MyDetector[stackCount];
            //    //for (int i = 0; i < stackCount; i++)
            //    //{
            //    //    detectors[i] = tempStack2.Pop();
            //    //}

            //    //MyRecognizer.Recognize(detectors);

            //    //stackCount = MyRecognizer.stackDetectors.Count;
            //    ////List<Image<Bgr, byte>> frames = new List<Image<Bgr, byte>>();
            //    //List<MyDetector> frames = new List<MyDetector>();
            //    //for (int i = stackCount; i != 0; i--)
            //    //{
            //    //    //frames.Add(MyRecognizer.stackDetectors.Pop().bmp.ToImage<Bgr, byte>());
            //    //    frames.Add(MyRecognizer.stackDetectors.Pop());
            //    //}


            //    //Task t2 = new Task(() =>
            //    //{
            //    //    //var framesCount = frames.Count();
            //    //    //Stack<MyDetector> frameStack = new Stack<MyDetector>();
            //    //    //for (int i = framesCount - 1; i != 0; i--) frameStack.Push(frames[i]);
            //    //    //frames.Clear();

            //    //    //for(int i = 0; i < framesCount; i++)
            //    //    //{
            //    //    //    var frame = frameStack.Pop();
            //    //    //    frame.DrawRectanglesWithNames();
            //    //    //    BeginInvoke((MethodInvoker)(() =>
            //    //    //    {
            //    //    //        frameBox.Image = frame.bmp.ToImage<Bgr, byte>();
            //    //    //    }));
            //    //    //}

            //    //    MyDetector[] temp = new MyDetector[frames.Count];
            //    //    frames.CopyTo(temp);
            //    //    foreach (var frame in temp)
            //    //    {
            //    //        //frame.DrawRectanglesWithNames();
            //    //        //BeginInvoke((MethodInvoker)(() =>
            //    //        //{
            //    //        //    frameBox.Image = frame.bmp.ToImage<Bgr, byte>();
            //    //        //}));

            //    //        foreach (var face in frame.faces)
            //    //        {
            //    //            if (Configs.EvidenceNames.Contains(face.name))
            //    //            {
            //    //                frameBox.Image = frame.bmp.ToImage<Bgr, byte>();
            //    //            }
            //    //        }

            //    //    }
            //    //    frames.Clear();
            //    //});
            //    //t2.Start();

            //    //Thread thread = new Thread(() =>
            //    //{
            //    //    int k = 0;
            //    //    while (true)
            //    //    {
            //    //        try
            //    //        {
            //    //            frameBox.Image = frames[k];
            //    //        }
            //    //        catch { }
            //    //        Thread.Sleep(50);
            //    //        k++;
            //    //        if (k > frames.Count - 1) break;
            //    //    }
            //    //});

            //    //thread.Start();
            //    //while (thread.IsAlive) { }

            //    //frames.Clear();
            //    //frames = null;
            //}

            #endregion


            #region Thread
            //List<Task> tasks = new List<Task>();

            //for (int i = 0; i < MyRecognizer.ThreadsNumber; i++)
            //{
            //    capture.Retrieve(m);

            //    tempStack.Enqueue(m.ToBitmap());

            //    Task t1 = new Task(() =>
            //    {
            //        MyDetector detector = new MyDetector();
            //        detector.bmp = tempStack.Dequeue();
            //        detector.DetectFaces();

            //        MyRecognizer2 recognizer = new MyRecognizer2(MyRecognizer.TrainFaces, MyRecognizer.knownNames, MyRecognizer.knownEncodings);

            //        recognizer.Recognize(detector);
            //        detector.DrawRectanglesWithNames();
            //        try
            //        {
            //            detector.bmp.Save(new Random().Next().ToString() + ".bmp", ImageFormat.Bmp);
            //        }
            //        catch { }
            //        frames.Enqueue(detector.bmp);
            //    });
            //    t1.Start();
            //    tasks.Add(t1);
            //}

            //Task.WaitAll(tasks.ToArray());

            //tasks = new List<Task>();

            //Task t2 = new Task(() =>
            //{
            //    for (int i = 0; i < threads; i++)
            //    {
            //        frameBox.Image = frames.Dequeue().ToImage<Bgr, byte>();
            //        Thread.Sleep(50);
            //    }
            //});
            //t2.Start();

            //Task.WaitAll(t2); 

            #endregion

            #region ThreadProcessing
            //if (!Configs.IsShowMiddleProccess)
            //{
            //    Task t1 = new Task(() =>
            //    {
            //        Mat m1 = new Mat();
            //        capture.Retrieve(m1);
            //        mats.Enqueue(m1);
            //    });
            //    t1.Start();
            //    t1.Wait();

            //    //capture.Retrieve(m);
            //    //mats.Enqueue(m);


            //    if (mats.Count >= MyRecognizer.ThreadsNumber)
            //    {
            //        List<Task> tasks = new List<Task>();
            //        int stackCount = mats.Count;
            //        for (int i = 0; i < stackCount; i++)
            //        {
            //            int f = i;
            //            Task t = new Task(() =>
            //            {
            //                MyDetector detector = new MyDetector();
            //                MyRecognizer2 recognizer = new MyRecognizer2(MyRecognizer.TrainFaces);
            //                detector.bmp = mats.Dequeue();
            //                detector.DetectFaces();
            //                recognizer.Recognize2(detector, f, 0, Configs.PredictorModel, Configs.Model);

            //                foreach (var face in detector.faces)
            //                {
            //                    if (Configs.EvidenceNames.Contains(face.name) && !Informator.DetectedFaces.Contains(face))
            //                    {
            //                        detector.DrawRectanglesWithNames();

            //                        if (!Directory.Exists("FindingEvidence"))
            //                        {
            //                            Directory.CreateDirectory("FindingEvidence");
            //                        }

            //                        DirectoryInfo directory = new DirectoryInfo("FindingEvidence");

            //                        int files = directory.GetFiles().Length;

            //                        var photoName = DateTime.UtcNow.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + ".bmp";
            //                        try
            //                        {
            //                            detector.bmp.Save("FindingEvidence/" + photoName.Replace(':', '-'));
            //                            Informator.DetectedFaces.Add(face);
            //                            BeginInvoke((MethodInvoker)(() =>
            //                            {
            //                                try
            //                                {
            //                                    frameBox.Image = detector.bmp;//.ToImage<Bgr,byte>();
            //                                    //frameBox.Image = new Image<Bgr, byte>("FindingEvidence/" + photoName.Replace(':', '-'));
            //                                }
            //                                catch { }
            //                            }));
            //                        }
            //                        catch { }
            //                        Informator.PlaySignal();
            //                        Informator.DetectedFaces.Add(face);
            //                        if (File.Exists("phones.txt"))
            //                        {
            //                            try
            //                            {
            //                                List<string> phones = new List<string>();
            //                                string filename = "phones.txt";
            //                                using (FileStream fs = new FileStream(filename, FileMode.Open))
            //                                {
            //                                    FileInfo file = new FileInfo(filename);
            //                                    byte[] bytes = new byte[file.Length];
            //                                    fs.Read(bytes, 0, bytes.Length);
            //                                    string Phones = System.Text.Encoding.UTF8.GetString(bytes);

            //                                    foreach (var phone in Phones.Replace("\r\n", "\n").Split('\n'))
            //                                    {
            //                                        phones.Add(phone);
            //                                    }
            //                                }

            //                                Informator.SendMsg("Обнаружен преступник - " + face.name, phones.ToArray());
            //                            }
            //                            catch { }
            //                        }
            //                        break;
            //                    }
            //                }
            //            });
            //            t.Start();
            //            tasks.Add(t);
            //        }
            //        Task.WaitAll(tasks.ToArray());

            //        for (int i = 0; i < tasks.Count(); i++)
            //        {
            //            tasks[i].Dispose();
            //            tasks[i] = null;
            //        }
            //    }
            //}


            ////    Task.WaitAll(tasks.ToArray());

            ////    tasks = new List<Task>();

            ////    if (mats.Count >= MyRecognizer.ThreadsNumber)
            ////    {
            ////        List<Task> tasks = new List<Task>();
            ////        List<MyDetector> detectors = new List<MyDetector>();

            ////        for (int i = 0; i < MyRecognizer.ThreadsNumber; i++)
            ////        {
            ////            int f = i;
            ////            Task t2 = new Task(() =>
            ////            {
            ////                if (MyRecognizer.libs.ContainsKey(f))
            ////                {
            ////                    MyDetector detector = new MyDetector(MyRecognizer.libs[f]);
            ////                    detector.fr = new Frame(mats.Dequeue().ToBitmap(), f);
            ////                    detector.bmp = detector.fr.frame;
            ////                    detector.DetectFaces();
            ////                    detectors.Add(detector);
            ////                }
            ////            });
            ////            t2.Start();
            ////            tasks.Add(t2);
            ////        }
            ////        Task.WaitAll(tasks.ToArray());

            ////        tasks = new List<Task>();

            ////        for (int i = 0; i < MyRecognizer.ThreadsNumber; i++)
            ////        {
            ////            int f = i;
            ////            Task t3 = new Task(() =>
            ////            {
            ////                MyRecognizer2 recognizer = new MyRecognizer2(MyRecognizer.TrainFaces);
            ////                if (f < detectors.Count())
            ////                {
            ////                    recognizer.Recognize(detectors[f]);

            ////                    if (detectors[f].faces.FindAll(face => Configs.EvidenceNames.Contains(face.name)).Count > 0)
            ////                    {
            ////                        detectors[f].DrawRectangles();
            ////                        frameBox.Image = detectors[f].bmp.ToImage<Bgr, byte>();
            ////                    }
            ////                }
            ////            });
            ////            t3.Start();
            ////            tasks.Add(t3);
            ////        }

            ////        Task.WaitAll(tasks.ToArray());
            ////    }
            ////}
            #endregion


            #region newThreadTest

            //if (!Configs.IsShowMiddleProccess)
            //{
            //    Task t1 = new Task(() =>
            //    {
            //        Mat m1 = new Mat();
            //        capture.Retrieve(m1);
            //        mats.Enqueue(m1);
            //    });
            //    t1.Start();
            //    t1.Wait();

            //    frameNum = (frameNum <= MyRecognizer.ThreadsNumber) ? frameNum + 1 : 0;

            //    Task t = new Task(() =>
            //    {
            //        MyDetector detector = new MyDetector();
            //        MyRecognizer2 recognizer = new MyRecognizer2(MyRecognizer.TrainFaces);
            //        detector.bmp = mats.Dequeue();
            //        detector.DetectFaces();
            //        recognizer.Recognize2(detector, frameNum);
            //        detector.DrawRectanglesWithNames();



            //        if (recognizer.EvidenceDetect)
            //        {
            //            foreach(var f in recognizer.RecogEvidFaces)
            //            {
            //                f.bmp = null;
            //                if (!Informator.DetectedFaces.Contains(f))
            //                {
            //                    Informator.DetectedFaces.Add(f);
            //                    Informator.PlaySignal();
            //                    BeginInvoke((MethodInvoker)(() =>
            //                    {
            //                        try
            //                        {
            //                            frameBox.Image = detector.bmp;
            //                        }
            //                        catch { }
            //                    }));
            //                }
            //            }
            //        }
            //    });
            //    t.Start();


            ////    if (mats.Count >= MyRecognizer.ThreadsNumber)
            ////    {
            ////        //List<Task> tasks = new List<Task>();
            ////        int stackCount = mats.Count;
            ////        //for (int i = 0; i < stackCount; i++)
            ////        //{
            ////        //    //int f = i;
            ////        //    //Task t = new Task(() =>
            ////        //    //{
            ////        //    //    MyDetector detector = new MyDetector();
            ////        //    //    MyRecognizer2 recognizer = new MyRecognizer2(MyRecognizer.TrainFaces);
            ////        //    //    detector.bmp = mats.Dequeue();
            ////        //    //    detector.DetectFaces();
            ////        //    //    recognizer.Recognize2(detector, f);
            ////        //    //    detector.DrawRectanglesWithNames();

            ////        //    //    if (recognizer.EvidenceDetect)
            ////        //    //    {
            ////        //    //        Informator.PlaySignal();
            ////        //    //        BeginInvoke((MethodInvoker)(() =>
            ////        //    //        {
            ////        //    //            try
            ////        //    //            {
            ////        //    //                frameBox.Image = detector.bmp;
            ////        //    //            }
            ////        //    //            catch { }
            ////        //    //        }));
            ////        //    //    }

            ////        //    //    //mats2.Add(f, detector.bmp);

            ////        //    //    //foreach (var face in detector.faces)
            ////        //    //    //{
            ////        //    //    //    if (Configs.EvidenceNames.Contains(face.name) && !Informator.DetectedFaces.Contains(face))
            ////        //    //    //    {

            ////        //    //    //        if (!Directory.Exists("FindingEvidence"))
            ////        //    //    //        {
            ////        //    //    //            Directory.CreateDirectory("FindingEvidence");
            ////        //    //    //        }

            ////        //    //    //        DirectoryInfo directory = new DirectoryInfo("FindingEvidence");

            ////        //    //    //        int files = directory.GetFiles().Length;

            ////        //    //    //        var photoName = DateTime.UtcNow.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + ".bmp";
            ////        //    //    //        try
            ////        //    //    //        {
            ////        //    //    //            detector.bmp.Save("FindingEvidence/" + photoName.Replace(':', '-'));
            ////        //    //    //            Informator.DetectedFaces.Add(face);
            ////        //    //    //            BeginInvoke((MethodInvoker)(() =>
            ////        //    //    //            {
            ////        //    //    //                try
            ////        //    //    //                {
            ////        //    //    //                    frameBox.Image = detector.bmp;
            ////        //    //    //                }
            ////        //    //    //                catch { }
            ////        //    //    //            }));
            ////        //    //    //        }
            ////        //    //    //        catch { }
            ////        //    //    //        Informator.PlaySignal();
            ////        //    //    //        Informator.DetectedFaces.Add(face);
            ////        //    //    //        if (File.Exists("phones.txt"))
            ////        //    //    //        {
            ////        //    //    //            try
            ////        //    //    //            {
            ////        //    //    //                List<string> phones = new List<string>();
            ////        //    //    //                string filename = "phones.txt";
            ////        //    //    //                using (FileStream fs = new FileStream(filename, FileMode.Open))
            ////        //    //    //                {
            ////        //    //    //                    FileInfo file = new FileInfo(filename);
            ////        //    //    //                    byte[] bytes = new byte[file.Length];
            ////        //    //    //                    fs.Read(bytes, 0, bytes.Length);
            ////        //    //    //                    string Phones = System.Text.Encoding.UTF8.GetString(bytes);

            ////        //    //    //                    foreach (var phone in Phones.Replace("\r\n", "\n").Split('\n'))
            ////        //    //    //                    {
            ////        //    //    //                        phones.Add(phone);
            ////        //    //    //                    }
            ////        //    //    //                }

            ////        //    //    //                Informator.SendMsg("Обнаружен преступник - " + face.name, phones.ToArray());
            ////        //    //    //            }
            ////        //    //    //            catch { }
            ////        //    //    //        }
            ////        //    //    //        break;
            ////        //    //    //    }
            ////        //    //    //}
            ////        //    //});
            ////        //    //t.Start();
            ////        //    //tasks.Add(t);
            ////        //}
            ////        //Task.WaitAll(tasks.ToArray());


            ////        //Task t3 = new Task(() =>
            ////        //{
            ////        //    foreach(var m in mats2.OrderBy(x=>x.Key))
            ////        //    {
            ////        //        frameBox.Image = m.Value;
            ////        //        Thread.Sleep(33);
            ////        //    }
            ////        //});

            ////        //t3.Start();
            ////        //t3.Wait();

            ////        //mats = new Queue<Mat>();
            ////        //mats2 = new Dictionary<int, Mat>();

            ////        //for (int i = 0; i < tasks.Count(); i++)
            ////        //{
            ////        //    tasks[i].Dispose();
            ////        //    tasks[i] = null;
            ////        //}
            ////    }
            //}

            #endregion

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryWithTrainImages = new DirectoryInfo(InputMessageBox.ShowMessage
                ("Введите название директории с тренировочными изображениями.Должна находится в папке с файлом.",
                "Дериктоия для тренировки.", "DATASET", "Поле ввода", Properties.Resources.trainPicture));



            Task t = new Task(() => { MyRecognizer.Train(directoryWithTrainImages, AddedFacesList); });
            t.Start();

            //new Thread(() =>
            //{
            //    MyRecognizer.Train(directoryWithTrainImages, AddedFacesList);
            //})
            //{Priority = ThreadPriority.Highest, IsBackground = false }.Start();
        }

        private void AddedFacesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //faceBox.Image = MyRecognizer.AddedFaces[AddedFacesList.SelectedItems[0].Text]
                //    [new Random().Next() % MyRecognizer.AddedFaces[AddedFacesList.SelectedItems[0].Text].Count()];

                faceBox.Image = MyRecognizer.TrainFaces.FindAll(face => face.name == AddedFacesList.SelectedItems[0].Text)
                    [new Random().Next() % MyRecognizer.TrainFaces.FindAll(face => face.name == AddedFacesList.SelectedItems[0].Text).Count()].bmp.ToImage<Bgr, byte>();

            }
            catch { }
        }

        private void AddedFacesList_Click(object sender, EventArgs e)
        {
            AddedFacesList_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void RecognitFacesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                faceBox.Image = DetectedFaces.Find(f => f.name == RecognitFacesList.SelectedItems[0].Text).bmp.ToImage<Bgr, byte>();
                //faceBox.Image = detectedFaces[RecognitFacesList.SelectedIndices[0]];
            }
            catch { }
        }

        private void facesTabControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'c' || e.KeyChar == 'с')
            {
                DetectedFaces.Clear();
                DetectedFacesYet.Clear();
                RecognitFacesList.Items.Clear();
                Informator.DetectedFaces.Clear();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ChoseDetectedRegions choseDetectedRegions = new ChoseDetectedRegions(m.ToBitmap());
            choseDetectedRegions.ShowDialog();
        }
    }
}
