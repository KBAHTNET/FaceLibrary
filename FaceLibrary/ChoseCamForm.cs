using System;
using System.Windows.Forms;
using DirectShowLib;
using Emgu.CV;

namespace FaceLibrary
{
    public partial class ChoseCamForm : Form
    {

        private DsDevice[] webCams = null; //для хранения доступных веб-камер


        public ChoseCamForm()
        {
            InitializeComponent();

            //получение массива доступных камер
            webCams = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            foreach (DsDevice cam in webCams)
            {
                CamsBox.Items.Add(cam.Name);
            }

            try { CamsBox.SelectedIndex = 0; }
            catch { CamsBox.Text = "Подключенных камер не обнаружено"; }
        }

        private void CamsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.selectCamId = CamsBox.SelectedIndex;
        }

        private void ChoseCamButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainForm.capture != null)
                    if (MainForm.capture.IsOpened)
                        MainForm.capture.Stop();
            }
            finally
            {
                try
                {
                    if (MainForm.capture != null)
                        MainForm.capture.Dispose();
                }
                finally
                {
                    MainForm.capture = new VideoCapture(MainForm.selectCamId);
                    MainForm.capture.ImageGrabbed += Program.mainForm.GetFrame_FaceRecognitionDotNet;
                    MainForm.capture.Start();
                }
            }
            this.Close();
        }
    }
}
