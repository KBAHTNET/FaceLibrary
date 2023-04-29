using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CustomDesign.Controls;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using FaceRecognitionDotNet;

namespace FaceLibrary
{
    public partial class ChoseDetectedRegions : ShadowedForm
    {
        private List<Image<Bgr, byte>> faces; //лица
        private int index = 0;

        private static readonly CascadeClassifier haarFaceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");

        public ChoseDetectedRegions(Bitmap frame)
        {

            InitializeComponent();

            MyDetector detector = new MyDetector(Configs.libraryRecognizer);
            detector.bmp = frame.ToImage<Bgr,byte>().Mat;
            detector.DetectFaces();
            faces = new List<Image<Bgr, byte>>();
            foreach(var faceLocation in detector.facesLocation)
            {
                faces.Add(frame.ToImage<Bgr,byte>()
                    
                    .Copy(faceLocation));
            }
            faceBox.Image = faces[0];

            for(int i = 0; i < faces.Count; i++)
            {
                RegionsListView.Items.Add(Convert.ToString(i + 1));
            }
        }

        private void RegionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                index = Convert.ToInt32(RegionsListView.FocusedItem.Text) - 1;
                faceBox.Image = faces[index];
            }
            catch { }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Выберите папку с датасетом для сохранения этого лица";
            sfd.Filter = "Все файлы|*.*";
            sfd.InitialDirectory = Application.StartupPath;
            sfd.DefaultExt = "bmp";
            sfd.FileName = NameTextBox.Text;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                faces[index].Save(sfd.FileName);

                FaceRecognitionDotNet.Image img = FaceRecognition.LoadImage(faces[index].Mat.GetUMat(AccessType.Fast).ToBitmap());

                var faceLocation = Configs.libraryRecognizer.FaceLocations(img).First();

                FaceEncoding faceEncoding = Configs.libraryRecognizer.FaceEncoding(
                    img, faceLocation, 1, PredictorModel.Large);


                Face face = new Face();
                face.encoding = faceEncoding;
                face.name = NameTextBox.Text;
                face.bmp = faces[index].ToBitmap();
                MyRecognizer.TrainFaces.Add(face);

                Program.mainForm.AddedFacesList.Items.Add(face.name);
            }
        }
    }
}
