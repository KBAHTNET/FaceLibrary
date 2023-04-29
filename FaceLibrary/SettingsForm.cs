using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CustomDesign.Controls;

namespace FaceLibrary
{
    public partial class SettingsForm : ShadowedForm
    {
        public SettingsForm()
        {
            InitializeComponent();

            #region Инициализация сопсобы обработки видеопотока
            if (Configs.IsUseRecognition)
            {
                IsUseRecognizerCheckBox.Checked = true;
            }
            else
            {
                IsUseRecognizerCheckBox.Checked = false;
            }

            if (Configs.IsShowMiddleProccess)
            {
                IsShowMiddleCheckBox.Checked = true;
            }
            else
            {
                IsShowMiddleCheckBox.Checked = false;
            }
            #endregion

            #region Инициализация алгоритма обнаружения
            if (Configs.chosenAlgoritmDetection == Configs.AlgoritmDetection.Hog)
                HogRadioButton.Checked = true;
            if (Configs.chosenAlgoritmDetection == Configs.AlgoritmDetection.Haar)
                HaarRadioButton.Checked = true;
            if (Configs.chosenAlgoritmDetection == Configs.AlgoritmDetection.Cnn)
                CnnRadioButton.Checked = true;
            if (Configs.chosenAlgoritmDetection == Configs.AlgoritmDetection.FasterR_CNN)
                FasterR_CNN_RadioButton.Checked = true;

            #endregion

            #region Инициализаяи алгоритма распознавания
            if (Configs.chosenAlgoritmRegognition == Configs.AlgoritmRecognition.DNN)
                DNNRadioButton.Checked = true;

            if (Configs.IsUseRecognition)
            {
                IsUseRecognizerCheckBox.Checked = true;
            }
            else
            {
                IsUseRecognizerCheckBox.Checked = false;
            }

            if(Configs.PredictorModel == FaceRecognitionDotNet.PredictorModel.Large)
            {
                LargeRadioButton.Checked = true;
                SmallRadioButton.Checked = false;
            }
            else
            {
                LargeRadioButton.Checked = false;
                SmallRadioButton.Checked = true;
            }

            if(Configs.Model == FaceRecognitionDotNet.Model.Cnn)
            {
                Cnn_RRadioButton.Checked = true;
                Hog_RRadioButton.Checked = false;
            }
            else
            {
                Cnn_RRadioButton.Checked = false;
                Hog_RRadioButton.Checked = true;
            }

            #endregion

            #region Инициализация настроек Haar'a
            if (Configs.chosenAlgoritmDetection == Configs.AlgoritmDetection.Haar)
            {
                ScaleFactorTextBox.Text = Configs.multiScale.ToString().Replace(',', '.');
                MinNeighborsTextBox.Text = Configs.minNeig.ToString();
                MinFaceSizeTextBox.Text = Configs.MinFaceSize.Width.ToString() + ";" +
                    Configs.MinFaceSize.Height.ToString();
            }
            else
            {
                ScaleFactorTextBox.Enabled = true;
                MinNeighborsTextBox.Enabled = true;
                MinFaceSizeTextBox.Enabled = true;

                ScaleFactorTextBox.Text = "";
                MinNeighborsTextBox.Text = "";
                MinFaceSizeTextBox.Text = "";
            }
            #endregion

            #region Инициализация цвета и размера ручки
            RectangleFaceColorButton.BackColor = Configs.ColorFrontal;
            RectangleEvidenceColor.BackColor = Configs.ColorEvidenceFrontal;
            PenColorButton.BackColor = Configs.FontColor;
            PenSizeTextBox.Text = Configs.PenSize.ToString();
            #endregion

            #region Инициализация порогов
            PorogTextBox.Text = Configs.PorogDouble.ToString().Replace(',', '.');
            #endregion

            #region Инициализация размеров кадра и лица
            if (Configs.IsResizeFrame) ResizeCheckBox.CheckState = CheckState.Checked;
            if (!Configs.IsResizeFrame) ResizeCheckBox.CheckState = CheckState.Unchecked;
            FrameSizeTextBox.Text = Configs.PictureResize.Width.ToString() + ";" +
                Configs.PictureResize.Height.ToString();
            FaceSizeTextBox.Text = Configs.ResizeTrainAndPredictPicture.Width.ToString() + ";" +
                Configs.ResizeTrainAndPredictPicture.Height.ToString();
            #endregion


            #region Остальное
            IntervalTextBox.Text = Configs.secondsInterval.ToString();

            if (Configs.IsDrawFaceLandmarks)
            {
                IsDrawLandmarksCheckBox.Checked = true;
            }
            else
            {
                IsDrawLandmarksCheckBox.Checked = false;
            }

            if (Configs.IsDrawCiphers)
            {
                IsDrawCiphersCheckBox.Checked = true;
            }
            else
            {
                IsDrawCiphersCheckBox.Checked = false;
            }
            #endregion
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (IsUseRecognizerCheckBox.Checked)
            {
                Configs.IsUseRecognition = true;
            }
            else
            {
                Configs.IsUseRecognition = false;
            }

            if (IsShowMiddleCheckBox.Checked)
            {
                Configs.IsShowMiddleProccess = true;
            }
            else
            {
                Configs.IsShowMiddleProccess = false;
            }

            #region Выбор алгоритма обнаружения
            if (HogRadioButton.Checked == true)
            {
                Configs.chosenAlgoritmDetection = Configs.AlgoritmDetection.Hog;
            }
            if (HaarRadioButton.Checked == true)
            {
                Configs.chosenAlgoritmDetection = Configs.AlgoritmDetection.Haar;
            }
            if (CnnRadioButton.Checked == true)
            {
                Configs.chosenAlgoritmDetection = Configs.AlgoritmDetection.Cnn;
            }
            if (FasterR_CNN_RadioButton.Checked == true)
            {
                Configs.chosenAlgoritmDetection = Configs.AlgoritmDetection.FasterR_CNN;
            }
            #endregion
            #region Выбор алгоритма распознавания
            if (DNNRadioButton.Checked == true)
            {
                Configs.chosenAlgoritmRegognition = Configs.AlgoritmRecognition.DNN;
            }

            if(LargeRadioButton.Checked == true)
            {
                Configs.PredictorModel = FaceRecognitionDotNet.PredictorModel.Large;
            }
            else
            {
                Configs.PredictorModel = FaceRecognitionDotNet.PredictorModel.Small;
            }

            if(Cnn_RRadioButton.Checked == true)
            {
                Configs.Model = FaceRecognitionDotNet.Model.Cnn;
            }
            else
            {
                Configs.Model = FaceRecognitionDotNet.Model.Hog;
            }
            #endregion


            #region Установка настроек Haar'a   
            if (HaarRadioButton.Checked == true)
            {
                try
                {
                    Configs.multiScale = double.Parse(ScaleFactorTextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    ScaleFactorTextBox.Text = "";
                    MessageBox.Show("Введено неверное значение в поле. Введите заново. Формат: \"1.число\"",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    Configs.minNeig = Convert.ToInt32(MinNeighborsTextBox.Text);
                }
                catch
                {
                    MinNeighborsTextBox.Text = "";
                    MessageBox.Show("Введено неверное значение в поле. Введите заново. Формат: \"число (от 0-20)\"",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    Configs.MinFaceSize = new Size(
                        Convert.ToInt32(MinFaceSizeTextBox.Text.Split(';')[0]),
                        Convert.ToInt32(MinFaceSizeTextBox.Text.Split(';')[1]));
                }
                catch
                {
                    MinFaceSizeTextBox.Text = "";
                    MessageBox.Show("Введены неверные размеры в поле. Введите заново. Формат: \"число;число\"",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
            #region Установка цвета и размера ручки
            Configs.ColorFrontal = RectangleFaceColorButton.BackColor;
            Configs.ColorEvidenceFrontal = RectangleEvidenceColor.BackColor;
            Configs.FontColor = PenColorButton.BackColor;

            try
            {
                Configs.PenSize = Convert.ToInt32(PenSizeTextBox.Text);
            }
            catch
            {
                PenSizeTextBox.Text = "";
                MessageBox.Show("Введено неверное значение в поле. Введите заново. Формат: \"число\"",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            #region Установка порогов
            if (DNNRadioButton.Checked == true)
            {
                try
                {
                    Configs.PorogDouble = double.Parse(PorogTextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    PorogTextBox.Text = "";
                    MessageBox.Show("Введено неверное значение в поле. Введите заново. Формат: \"0.число\". Рекомендуется 0.52-0.6",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
            #region Установка размеров кадра и лица
            try
            {
                if (Configs.IsResizeFrame)
                {
                    Configs.PictureResize = new Size(Convert.ToInt32(FrameSizeTextBox.Text.Split(';')[0]),
                        Convert.ToInt32(FrameSizeTextBox.Text.Split(';')[1]));
                }
                if (Configs.IsResizeFrame)
                {
                    Configs.PictureResize = new Size(Convert.ToInt32(FrameSizeTextBox.Text.Split(';')[0]),
                        Convert.ToInt32(FrameSizeTextBox.Text.Split(';')[1]));
                }
            }
            catch
            {
                FrameSizeTextBox.Text = "";
                MessageBox.Show("Введены неверные размеры в поле. Введите заново. Формат: \"число;число\". Рекомендуется 800;600 - 1920;1440",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                Configs.ResizeTrainAndPredictPicture = new Size(Convert.ToInt32(FaceSizeTextBox.Text.Split(';')[0]),
                    Convert.ToInt32(FaceSizeTextBox.Text.Split(';')[1]));

                Configs.ResizeTrainAndPredictPicture = new Size(Convert.ToInt32(FaceSizeTextBox.Text.Split(';')[0]),
                    Convert.ToInt32(FaceSizeTextBox.Text.Split(';')[1]));
            }
            catch
            {
                FaceSizeTextBox.Text = "";
                MessageBox.Show("Введены неверные размеры в поле. Введите заново. Формат: \"число;число\". Рекомендуется 640;480 - 1280;1024",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            #region Установка интервала
            try
            {
                Configs.secondsInterval = Convert.ToInt32(IntervalTextBox.Text);

                try
                {
                    Program.mainForm.timer.Stop();
                    Program.mainForm.timer.Interval = 1000 * Configs.secondsInterval;
                    Program.mainForm.timer.Start();
                }
                catch
                {
                    MessageBox.Show("Непредвиденная ошибка, связанная с установкой интервала добавления лиц.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                IntervalTextBox.Text = "";
                MessageBox.Show("Введено неверное значение в поле. Введите заново. Формат: \"число\". Рекомендуется 10-50 (секунды)",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            if (IsDrawLandmarksCheckBox.Checked)
            {
                Configs.IsDrawFaceLandmarks = true;
            }
            else
            {
                Configs.IsDrawFaceLandmarks = false;
            }

            this.Close();
        }

        #region  Алгоритм обнаружения
        private void HogRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ScaleFactorTextBox.Enabled = false;
            MinNeighborsTextBox.Enabled = false;
            MinFaceSizeTextBox.Enabled = false;
            ScaleFactorTextBox.Text = "";
            MinNeighborsTextBox.Text = "";
            MinFaceSizeTextBox.Text = "";
        }

        private void HaarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ScaleFactorTextBox.Text = Configs.multiScale.ToString();
            MinNeighborsTextBox.Text = Configs.minNeig.ToString();
            MinFaceSizeTextBox.Text = Configs.MinFaceSize.Width.ToString() + ";" +
                Configs.MinFaceSize.Height.ToString();

            ScaleFactorTextBox.Enabled = true;
            MinNeighborsTextBox.Enabled = true;
            MinFaceSizeTextBox.Enabled = true;

            ScaleFactorTextBox.Focus();
            MinNeighborsTextBox.Focus();
            MinFaceSizeTextBox.Focus();

            this.Focus();
        }

        private void CnnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ScaleFactorTextBox.Enabled = false;
            MinNeighborsTextBox.Enabled = false;
            MinFaceSizeTextBox.Enabled = false;
            ScaleFactorTextBox.Text = "";
            MinNeighborsTextBox.Text = "";
            MinFaceSizeTextBox.Text = "";
        }
        #endregion

        #region Алгоритм распознавания
        private void SiameseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //
        }
        #endregion

        private void ResizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ResizeCheckBox.CheckState == CheckState.Checked)
            {
                Configs.IsResizeFrame = true;
                FrameSizeTextBox.Text = Configs.PictureResize.Width.ToString() + ";" +
                    Configs.PictureResize.Height.ToString();
                FrameSizeTextBox.Enabled = true;
            }
            if (ResizeCheckBox.CheckState == CheckState.Unchecked)
            {
                Configs.IsResizeFrame = false;
                FrameSizeTextBox.Text = "";
                FrameSizeTextBox.Enabled = false;
            }
        }

        private void ScaleFactorTextBox_Click(object sender, EventArgs e)
        {
            ScaleFactorTextBox.Text = ScaleFactorTextBox.Text.Replace(',', '.');
        }

        private void Porog2TextBox_Click(object sender, EventArgs e)
        {
            PorogTextBox.Text = PorogTextBox.Text.Replace(',', '.');
        }

        private void RectangleFaceColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                RectangleFaceColorButton.BackColor = cd.Color;
                Configs.ColorFrontal = cd.Color;
            }
        }

        private void PenColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                PenColorButton.BackColor = cd.Color;
                Configs.FontColor = cd.Color;
            }
        }

        private void RectangleEvidenceColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                RectangleEvidenceColor.BackColor = cd.Color;
                Configs.ColorEvidenceFrontal = cd.Color;
            }
        }

        private void IsUseRecognizerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsUseRecognizerCheckBox.Checked)
            {
                Configs.IsUseRecognition = true;
            }
            else
            {
                Configs.IsUseRecognition = false;
            }
        }

        private void IsShowMiddle_CheckedChanged(object sender, EventArgs e)
        {
            if (IsShowMiddleCheckBox.Checked)
            {
                Configs.IsShowMiddleProccess = true;
            }
            else
            {
                Configs.IsShowMiddleProccess = false;
            }
        }


        public static void StartPythonScriptInformation(string pathToPythonExe, string pathToScript)
        {
            string command = "python.exe parser.py";
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "C:/Windows/System32/cmd.exe";
            p.StartInfo.Arguments = "/C " + command;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            //var str = p.StandardInput.BaseStream;

            //Console.SetOut(wr);
            //p.StandardInput.BaseStream.Write(b, 0, b.Length);
            //str.Write(b, 0, b.Length);
            //str.Flush();
            //str.Close();
            //p.WaitForExit();
            //try
            //{
            //    p.Close();
            //    p.Dispose();
            //}
            //finally
            //{
            //    p = null;
            //}
        }

        private void CheckPhotoUpdatesButton_Click(object sender, EventArgs e)
        {
            StartPythonScriptInformation("python\\python.exe", @"python\\parser.py");
        }

        private void IsDrawLandmarksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDrawLandmarksCheckBox.Checked) Configs.IsDrawFaceLandmarks = true;
            else Configs.IsDrawFaceLandmarks = false;
        }

        private void IsDrawCiphersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDrawLandmarksCheckBox.Checked) Configs.IsDrawCiphers = true;
            else Configs.IsDrawCiphers = false;
        }

        private void SmallRadioButton_Click(object sender, EventArgs e)
        {
            SmallRadioButton.Checked = true;
            LargeRadioButton.Checked = false;
        }

        private void LargeRadioButton_Click(object sender, EventArgs e)
        {
            LargeRadioButton.Checked = true;
            SmallRadioButton.Checked = false;
        }

        private void Hog_RRadioButton_Click(object sender, EventArgs e)
        {
            Hog_RRadioButton.Checked = true;
            Cnn_RRadioButton.Checked = false;
        }

        private void Cnn_RRadioButton_Click(object sender, EventArgs e)
        {
            Cnn_RRadioButton.Checked = true;
            Hog_RRadioButton.Checked = false;
        }
    }
}