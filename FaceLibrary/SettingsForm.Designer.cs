namespace FaceLibrary
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsFormStyle = new CustomDesign.Components.CustomFormStyle(this.components);
            this.HaarRadioButton = new CustomDesign.CustomRadioButton();
            this.HogRadioButton = new CustomDesign.CustomRadioButton();
            this.CnnRadioButton = new CustomDesign.CustomRadioButton();
            this.DNNRadioButton = new CustomDesign.CustomRadioButton();
            this.DetectionAlgoritmPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FasterR_CNN_RadioButton = new CustomDesign.CustomRadioButton();
            this.DetectionAlgoritmLabel = new System.Windows.Forms.Label();
            this.DetectionAlgoritmPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RecognitionPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RecognitionPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RecognitionAlgoritmLabel = new System.Windows.Forms.Label();
            this.IsUseRecognizerCheckBox = new System.Windows.Forms.CheckBox();
            this.RecognitionPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PredictionModelLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SmallRadioButton = new CustomDesign.CustomRadioButton();
            this.LargeRadioButton = new CustomDesign.CustomRadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Hog_RRadioButton = new CustomDesign.CustomRadioButton();
            this.Cnn_RRadioButton = new CustomDesign.CustomRadioButton();
            this.ColorPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ColorPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RectangleEvidenceColor = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.RectangleFaceColorButton = new System.Windows.Forms.Button();
            this.PenColorButton = new System.Windows.Forms.Button();
            this.HaarPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HaarPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.HaarSettingsLabel = new System.Windows.Forms.Label();
            this.ScaleFactorTextBox = new CustomDesign.CustomTextBox();
            this.MinFaceSizeTextBox = new CustomDesign.CustomTextBox();
            this.MinNeighborsTextBox = new CustomDesign.CustomTextBox();
            this.ColorRectangleFaceLabel = new System.Windows.Forms.Label();
            this.ColorPenLabel = new System.Windows.Forms.Label();
            this.PenSizeTextBox = new CustomDesign.CustomTextBox();
            this.IntervalTextBox = new CustomDesign.CustomTextBox();
            this.OkButton = new CustomDesign.CustomButton();
            this.FrameSizeTextBox = new CustomDesign.CustomTextBox();
            this.FaceSizeTextBox = new CustomDesign.CustomTextBox();
            this.PorogTextBox = new CustomDesign.CustomTextBox();
            this.ResizePanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ResizeCheckBox = new System.Windows.Forms.CheckBox();
            this.ResizePanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.IsShowMiddleCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckPhotoUpdatesButton = new CustomDesign.CustomButton();
            this.IsDrawLandmarksCheckBox = new System.Windows.Forms.CheckBox();
            this.IsDrawCiphersCheckBox = new System.Windows.Forms.CheckBox();
            this.DetectionAlgoritmPanel2.SuspendLayout();
            this.DetectionAlgoritmPanel1.SuspendLayout();
            this.RecognitionPanel1.SuspendLayout();
            this.RecognitionPanel2.SuspendLayout();
            this.RecognitionPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ColorPanel1.SuspendLayout();
            this.ColorPanel2.SuspendLayout();
            this.HaarPanel1.SuspendLayout();
            this.HaarPanel2.SuspendLayout();
            this.ResizePanel2.SuspendLayout();
            this.ResizePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsFormStyle
            // 
            this.SettingsFormStyle.AllowUserResize = false;
            this.SettingsFormStyle.ContextMenuForm = null;
            this.SettingsFormStyle.EnableControlBoxIconsLight = true;
            this.SettingsFormStyle.EnableControlBoxMouseLight = true;
            this.SettingsFormStyle.Form = this;
            this.SettingsFormStyle.FormStyle = CustomDesign.Components.CustomFormStyle.fStyle.SimpleDark;
            this.SettingsFormStyle.HeaderColor = System.Drawing.SystemColors.WindowFrame;
            this.SettingsFormStyle.HeaderFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SettingsFormStyle.HeaderHeight = 30;
            // 
            // HaarRadioButton
            // 
            this.HaarRadioButton.AutoSize = true;
            this.HaarRadioButton.BackColor = System.Drawing.Color.White;
            this.HaarRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HaarRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.HaarRadioButton.FlatAppearance.BorderSize = 5;
            this.HaarRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.HaarRadioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.HaarRadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.HaarRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HaarRadioButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.HaarRadioButton.Location = new System.Drawing.Point(4, 37);
            this.HaarRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.HaarRadioButton.Name = "HaarRadioButton";
            this.HaarRadioButton.Size = new System.Drawing.Size(149, 25);
            this.HaarRadioButton.TabIndex = 1;
            this.HaarRadioButton.Text = "Haar";
            this.HaarRadioButton.UseVisualStyleBackColor = false;
            this.HaarRadioButton.CheckedChanged += new System.EventHandler(this.HaarRadioButton_CheckedChanged);
            // 
            // HogRadioButton
            // 
            this.HogRadioButton.AutoSize = true;
            this.HogRadioButton.BackColor = System.Drawing.Color.White;
            this.HogRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HogRadioButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.HogRadioButton.Location = new System.Drawing.Point(4, 70);
            this.HogRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.HogRadioButton.Name = "HogRadioButton";
            this.HogRadioButton.Size = new System.Drawing.Size(149, 25);
            this.HogRadioButton.TabIndex = 2;
            this.HogRadioButton.Text = "Hog";
            this.HogRadioButton.UseVisualStyleBackColor = false;
            this.HogRadioButton.CheckedChanged += new System.EventHandler(this.HogRadioButton_CheckedChanged);
            // 
            // CnnRadioButton
            // 
            this.CnnRadioButton.AutoSize = true;
            this.CnnRadioButton.BackColor = System.Drawing.Color.White;
            this.CnnRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CnnRadioButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.CnnRadioButton.Location = new System.Drawing.Point(4, 103);
            this.CnnRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.CnnRadioButton.Name = "CnnRadioButton";
            this.CnnRadioButton.Size = new System.Drawing.Size(149, 25);
            this.CnnRadioButton.TabIndex = 3;
            this.CnnRadioButton.Text = "Cnn";
            this.CnnRadioButton.UseVisualStyleBackColor = false;
            this.CnnRadioButton.CheckedChanged += new System.EventHandler(this.CnnRadioButton_CheckedChanged);
            // 
            // DNNRadioButton
            // 
            this.DNNRadioButton.AutoSize = true;
            this.DNNRadioButton.BackColor = System.Drawing.Color.White;
            this.DNNRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DNNRadioButton.Font = new System.Drawing.Font("Verdana", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DNNRadioButton.Location = new System.Drawing.Point(4, 74);
            this.DNNRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.DNNRadioButton.Name = "DNNRadioButton";
            this.DNNRadioButton.Size = new System.Drawing.Size(159, 15);
            this.DNNRadioButton.TabIndex = 4;
            this.DNNRadioButton.TabStop = true;
            this.DNNRadioButton.Text = "DNN";
            this.DNNRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DNNRadioButton.UseVisualStyleBackColor = false;
            this.DNNRadioButton.CheckedChanged += new System.EventHandler(this.SiameseRadioButton_CheckedChanged);
            // 
            // DetectionAlgoritmPanel2
            // 
            this.DetectionAlgoritmPanel2.ColumnCount = 1;
            this.DetectionAlgoritmPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DetectionAlgoritmPanel2.Controls.Add(this.FasterR_CNN_RadioButton, 0, 4);
            this.DetectionAlgoritmPanel2.Controls.Add(this.CnnRadioButton, 0, 3);
            this.DetectionAlgoritmPanel2.Controls.Add(this.HogRadioButton, 0, 2);
            this.DetectionAlgoritmPanel2.Controls.Add(this.HaarRadioButton, 0, 1);
            this.DetectionAlgoritmPanel2.Controls.Add(this.DetectionAlgoritmLabel, 0, 0);
            this.DetectionAlgoritmPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetectionAlgoritmPanel2.Location = new System.Drawing.Point(5, 5);
            this.DetectionAlgoritmPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.DetectionAlgoritmPanel2.Name = "DetectionAlgoritmPanel2";
            this.DetectionAlgoritmPanel2.RowCount = 5;
            this.DetectionAlgoritmPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DetectionAlgoritmPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DetectionAlgoritmPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DetectionAlgoritmPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DetectionAlgoritmPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DetectionAlgoritmPanel2.Size = new System.Drawing.Size(157, 168);
            this.DetectionAlgoritmPanel2.TabIndex = 8;
            // 
            // FasterR_CNN_RadioButton
            // 
            this.FasterR_CNN_RadioButton.AutoSize = true;
            this.FasterR_CNN_RadioButton.BackColor = System.Drawing.Color.White;
            this.FasterR_CNN_RadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FasterR_CNN_RadioButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.FasterR_CNN_RadioButton.Location = new System.Drawing.Point(4, 136);
            this.FasterR_CNN_RadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.FasterR_CNN_RadioButton.Name = "FasterR_CNN_RadioButton";
            this.FasterR_CNN_RadioButton.Size = new System.Drawing.Size(149, 28);
            this.FasterR_CNN_RadioButton.TabIndex = 5;
            this.FasterR_CNN_RadioButton.Text = "Faster R-CNN";
            this.FasterR_CNN_RadioButton.UseVisualStyleBackColor = false;
            // 
            // DetectionAlgoritmLabel
            // 
            this.DetectionAlgoritmLabel.AutoSize = true;
            this.DetectionAlgoritmLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetectionAlgoritmLabel.Location = new System.Drawing.Point(4, 0);
            this.DetectionAlgoritmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetectionAlgoritmLabel.Name = "DetectionAlgoritmLabel";
            this.DetectionAlgoritmLabel.Size = new System.Drawing.Size(149, 33);
            this.DetectionAlgoritmLabel.TabIndex = 4;
            this.DetectionAlgoritmLabel.Text = "Алгоритм обнаружения";
            this.DetectionAlgoritmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetectionAlgoritmPanel1
            // 
            this.DetectionAlgoritmPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DetectionAlgoritmPanel1.ColumnCount = 1;
            this.DetectionAlgoritmPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetectionAlgoritmPanel1.Controls.Add(this.DetectionAlgoritmPanel2, 0, 0);
            this.DetectionAlgoritmPanel1.Location = new System.Drawing.Point(16, 5);
            this.DetectionAlgoritmPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.DetectionAlgoritmPanel1.Name = "DetectionAlgoritmPanel1";
            this.DetectionAlgoritmPanel1.RowCount = 1;
            this.DetectionAlgoritmPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetectionAlgoritmPanel1.Size = new System.Drawing.Size(167, 178);
            this.DetectionAlgoritmPanel1.TabIndex = 9;
            // 
            // RecognitionPanel1
            // 
            this.RecognitionPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.RecognitionPanel1.ColumnCount = 1;
            this.RecognitionPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RecognitionPanel1.Controls.Add(this.RecognitionPanel2, 0, 0);
            this.RecognitionPanel1.Location = new System.Drawing.Point(427, 5);
            this.RecognitionPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.RecognitionPanel1.Name = "RecognitionPanel1";
            this.RecognitionPanel1.RowCount = 1;
            this.RecognitionPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RecognitionPanel1.Size = new System.Drawing.Size(177, 244);
            this.RecognitionPanel1.TabIndex = 10;
            // 
            // RecognitionPanel2
            // 
            this.RecognitionPanel2.ColumnCount = 1;
            this.RecognitionPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RecognitionPanel2.Controls.Add(this.DNNRadioButton, 0, 2);
            this.RecognitionPanel2.Controls.Add(this.RecognitionAlgoritmLabel, 0, 1);
            this.RecognitionPanel2.Controls.Add(this.IsUseRecognizerCheckBox, 0, 0);
            this.RecognitionPanel2.Controls.Add(this.RecognitionPanel3, 0, 3);
            this.RecognitionPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecognitionPanel2.Location = new System.Drawing.Point(5, 5);
            this.RecognitionPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.RecognitionPanel2.Name = "RecognitionPanel2";
            this.RecognitionPanel2.RowCount = 4;
            this.RecognitionPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.RecognitionPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.RecognitionPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RecognitionPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.RecognitionPanel2.Size = new System.Drawing.Size(167, 234);
            this.RecognitionPanel2.TabIndex = 11;
            // 
            // RecognitionAlgoritmLabel
            // 
            this.RecognitionAlgoritmLabel.AutoSize = true;
            this.RecognitionAlgoritmLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecognitionAlgoritmLabel.Location = new System.Drawing.Point(4, 35);
            this.RecognitionAlgoritmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RecognitionAlgoritmLabel.Name = "RecognitionAlgoritmLabel";
            this.RecognitionAlgoritmLabel.Size = new System.Drawing.Size(159, 35);
            this.RecognitionAlgoritmLabel.TabIndex = 0;
            this.RecognitionAlgoritmLabel.Text = "Алгоритм распознавания";
            this.RecognitionAlgoritmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IsUseRecognizerCheckBox
            // 
            this.IsUseRecognizerCheckBox.AutoSize = true;
            this.IsUseRecognizerCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IsUseRecognizerCheckBox.Location = new System.Drawing.Point(3, 3);
            this.IsUseRecognizerCheckBox.Name = "IsUseRecognizerCheckBox";
            this.IsUseRecognizerCheckBox.Size = new System.Drawing.Size(161, 29);
            this.IsUseRecognizerCheckBox.TabIndex = 5;
            this.IsUseRecognizerCheckBox.Text = "Распознавать";
            this.IsUseRecognizerCheckBox.UseVisualStyleBackColor = true;
            this.IsUseRecognizerCheckBox.CheckedChanged += new System.EventHandler(this.IsUseRecognizerCheckBox_CheckedChanged);
            // 
            // RecognitionPanel3
            // 
            this.RecognitionPanel3.ColumnCount = 2;
            this.RecognitionPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RecognitionPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RecognitionPanel3.Controls.Add(this.PredictionModelLabel, 0, 0);
            this.RecognitionPanel3.Controls.Add(this.ModelLabel, 1, 0);
            this.RecognitionPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.RecognitionPanel3.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.RecognitionPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecognitionPanel3.Location = new System.Drawing.Point(3, 96);
            this.RecognitionPanel3.Name = "RecognitionPanel3";
            this.RecognitionPanel3.RowCount = 2;
            this.RecognitionPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RecognitionPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RecognitionPanel3.Size = new System.Drawing.Size(161, 135);
            this.RecognitionPanel3.TabIndex = 6;
            // 
            // PredictionModelLabel
            // 
            this.PredictionModelLabel.AutoSize = true;
            this.PredictionModelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredictionModelLabel.Location = new System.Drawing.Point(3, 0);
            this.PredictionModelLabel.Name = "PredictionModelLabel";
            this.PredictionModelLabel.Size = new System.Drawing.Size(74, 67);
            this.PredictionModelLabel.TabIndex = 0;
            this.PredictionModelLabel.Text = "PredictionModel";
            this.PredictionModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelLabel.Location = new System.Drawing.Point(83, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(75, 67);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SmallRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LargeRadioButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(74, 62);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // SmallRadioButton
            // 
            this.SmallRadioButton.AutoSize = true;
            this.SmallRadioButton.BackColor = System.Drawing.Color.White;
            this.SmallRadioButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SmallRadioButton.Location = new System.Drawing.Point(4, 4);
            this.SmallRadioButton.Name = "SmallRadioButton";
            this.SmallRadioButton.Size = new System.Drawing.Size(66, 21);
            this.SmallRadioButton.TabIndex = 0;
            this.SmallRadioButton.TabStop = true;
            this.SmallRadioButton.Text = "Small";
            this.SmallRadioButton.UseVisualStyleBackColor = false;
            this.SmallRadioButton.Click += new System.EventHandler(this.SmallRadioButton_Click);
            // 
            // LargeRadioButton
            // 
            this.LargeRadioButton.AutoSize = true;
            this.LargeRadioButton.BackColor = System.Drawing.Color.White;
            this.LargeRadioButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LargeRadioButton.Location = new System.Drawing.Point(4, 34);
            this.LargeRadioButton.Name = "LargeRadioButton";
            this.LargeRadioButton.Size = new System.Drawing.Size(66, 21);
            this.LargeRadioButton.TabIndex = 1;
            this.LargeRadioButton.TabStop = true;
            this.LargeRadioButton.Text = "Large";
            this.LargeRadioButton.UseVisualStyleBackColor = false;
            this.LargeRadioButton.Click += new System.EventHandler(this.LargeRadioButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Hog_RRadioButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Cnn_RRadioButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 70);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(75, 62);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Hog_RRadioButton
            // 
            this.Hog_RRadioButton.AutoSize = true;
            this.Hog_RRadioButton.BackColor = System.Drawing.Color.White;
            this.Hog_RRadioButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.Hog_RRadioButton.Location = new System.Drawing.Point(4, 4);
            this.Hog_RRadioButton.Name = "Hog_RRadioButton";
            this.Hog_RRadioButton.Size = new System.Drawing.Size(59, 22);
            this.Hog_RRadioButton.TabIndex = 0;
            this.Hog_RRadioButton.TabStop = true;
            this.Hog_RRadioButton.Text = "Hog";
            this.Hog_RRadioButton.UseVisualStyleBackColor = false;
            this.Hog_RRadioButton.Click += new System.EventHandler(this.Hog_RRadioButton_Click);
            // 
            // Cnn_RRadioButton
            // 
            this.Cnn_RRadioButton.AutoSize = true;
            this.Cnn_RRadioButton.BackColor = System.Drawing.Color.White;
            this.Cnn_RRadioButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.Cnn_RRadioButton.Location = new System.Drawing.Point(4, 34);
            this.Cnn_RRadioButton.Name = "Cnn_RRadioButton";
            this.Cnn_RRadioButton.Size = new System.Drawing.Size(58, 22);
            this.Cnn_RRadioButton.TabIndex = 1;
            this.Cnn_RRadioButton.TabStop = true;
            this.Cnn_RRadioButton.Text = "Cnn";
            this.Cnn_RRadioButton.UseVisualStyleBackColor = false;
            this.Cnn_RRadioButton.Click += new System.EventHandler(this.Cnn_RRadioButton_Click);
            // 
            // ColorPanel1
            // 
            this.ColorPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ColorPanel1.ColumnCount = 1;
            this.ColorPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ColorPanel1.Controls.Add(this.ColorPanel2, 0, 0);
            this.ColorPanel1.Location = new System.Drawing.Point(332, 274);
            this.ColorPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.ColorPanel1.Name = "ColorPanel1";
            this.ColorPanel1.RowCount = 1;
            this.ColorPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ColorPanel1.Size = new System.Drawing.Size(67, 126);
            this.ColorPanel1.TabIndex = 11;
            // 
            // ColorPanel2
            // 
            this.ColorPanel2.ColumnCount = 1;
            this.ColorPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColorPanel2.Controls.Add(this.RectangleEvidenceColor, 0, 3);
            this.ColorPanel2.Controls.Add(this.ColorLabel, 0, 0);
            this.ColorPanel2.Controls.Add(this.RectangleFaceColorButton, 0, 1);
            this.ColorPanel2.Controls.Add(this.PenColorButton, 0, 2);
            this.ColorPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorPanel2.Location = new System.Drawing.Point(5, 5);
            this.ColorPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.ColorPanel2.Name = "ColorPanel2";
            this.ColorPanel2.RowCount = 4;
            this.ColorPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ColorPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ColorPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ColorPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ColorPanel2.Size = new System.Drawing.Size(57, 116);
            this.ColorPanel2.TabIndex = 12;
            // 
            // RectangleEvidenceColor
            // 
            this.RectangleEvidenceColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectangleEvidenceColor.Location = new System.Drawing.Point(4, 91);
            this.RectangleEvidenceColor.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleEvidenceColor.Name = "RectangleEvidenceColor";
            this.RectangleEvidenceColor.Size = new System.Drawing.Size(49, 21);
            this.RectangleEvidenceColor.TabIndex = 3;
            this.RectangleEvidenceColor.UseVisualStyleBackColor = true;
            this.RectangleEvidenceColor.Click += new System.EventHandler(this.RectangleEvidenceColor_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorLabel.Location = new System.Drawing.Point(4, 0);
            this.ColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(49, 29);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Цвет";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RectangleFaceColorButton
            // 
            this.RectangleFaceColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectangleFaceColorButton.Location = new System.Drawing.Point(4, 33);
            this.RectangleFaceColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleFaceColorButton.Name = "RectangleFaceColorButton";
            this.RectangleFaceColorButton.Size = new System.Drawing.Size(49, 21);
            this.RectangleFaceColorButton.TabIndex = 1;
            this.RectangleFaceColorButton.UseVisualStyleBackColor = true;
            this.RectangleFaceColorButton.Click += new System.EventHandler(this.RectangleFaceColorButton_Click);
            // 
            // PenColorButton
            // 
            this.PenColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PenColorButton.Location = new System.Drawing.Point(4, 62);
            this.PenColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.PenColorButton.Name = "PenColorButton";
            this.PenColorButton.Size = new System.Drawing.Size(49, 21);
            this.PenColorButton.TabIndex = 2;
            this.PenColorButton.UseVisualStyleBackColor = true;
            this.PenColorButton.Click += new System.EventHandler(this.PenColorButton_Click);
            // 
            // HaarPanel1
            // 
            this.HaarPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.HaarPanel1.ColumnCount = 1;
            this.HaarPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HaarPanel1.Controls.Add(this.HaarPanel2, 0, 0);
            this.HaarPanel1.Location = new System.Drawing.Point(16, 191);
            this.HaarPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.HaarPanel1.Name = "HaarPanel1";
            this.HaarPanel1.RowCount = 1;
            this.HaarPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HaarPanel1.Size = new System.Drawing.Size(167, 268);
            this.HaarPanel1.TabIndex = 12;
            // 
            // HaarPanel2
            // 
            this.HaarPanel2.ColumnCount = 1;
            this.HaarPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HaarPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.HaarPanel2.Controls.Add(this.HaarSettingsLabel, 0, 0);
            this.HaarPanel2.Controls.Add(this.ScaleFactorTextBox, 0, 1);
            this.HaarPanel2.Controls.Add(this.MinFaceSizeTextBox, 0, 2);
            this.HaarPanel2.Controls.Add(this.MinNeighborsTextBox, 0, 3);
            this.HaarPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HaarPanel2.Location = new System.Drawing.Point(5, 5);
            this.HaarPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.HaarPanel2.Name = "HaarPanel2";
            this.HaarPanel2.RowCount = 4;
            this.HaarPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HaarPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HaarPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HaarPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HaarPanel2.Size = new System.Drawing.Size(157, 258);
            this.HaarPanel2.TabIndex = 13;
            // 
            // HaarSettingsLabel
            // 
            this.HaarSettingsLabel.AutoSize = true;
            this.HaarSettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HaarSettingsLabel.Location = new System.Drawing.Point(4, 0);
            this.HaarSettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HaarSettingsLabel.Name = "HaarSettingsLabel";
            this.HaarSettingsLabel.Size = new System.Drawing.Size(149, 64);
            this.HaarSettingsLabel.TabIndex = 13;
            this.HaarSettingsLabel.Text = "Настройки Haar\'а";
            this.HaarSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScaleFactorTextBox
            // 
            this.ScaleFactorTextBox.BackColor = System.Drawing.Color.White;
            this.ScaleFactorTextBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.ScaleFactorTextBox.BorderColorNotActive = System.Drawing.Color.Lime;
            this.ScaleFactorTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScaleFactorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScaleFactorTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.ScaleFactorTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScaleFactorTextBox.ForeColor = System.Drawing.Color.Black;
            this.ScaleFactorTextBox.Location = new System.Drawing.Point(4, 68);
            this.ScaleFactorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScaleFactorTextBox.Name = "ScaleFactorTextBox";
            this.ScaleFactorTextBox.Size = new System.Drawing.Size(149, 56);
            this.ScaleFactorTextBox.TabIndex = 14;
            this.ScaleFactorTextBox.TextInput = "";
            this.ScaleFactorTextBox.TextPreview = "ScaleFactor";
            this.ScaleFactorTextBox.UseSystemPasswordChar = false;
            this.ScaleFactorTextBox.Click += new System.EventHandler(this.ScaleFactorTextBox_Click);
            // 
            // MinFaceSizeTextBox
            // 
            this.MinFaceSizeTextBox.BackColor = System.Drawing.Color.White;
            this.MinFaceSizeTextBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.MinFaceSizeTextBox.BorderColorNotActive = System.Drawing.Color.Lime;
            this.MinFaceSizeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinFaceSizeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinFaceSizeTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.MinFaceSizeTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinFaceSizeTextBox.ForeColor = System.Drawing.Color.Black;
            this.MinFaceSizeTextBox.Location = new System.Drawing.Point(4, 132);
            this.MinFaceSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MinFaceSizeTextBox.Name = "MinFaceSizeTextBox";
            this.MinFaceSizeTextBox.Size = new System.Drawing.Size(149, 56);
            this.MinFaceSizeTextBox.TabIndex = 15;
            this.MinFaceSizeTextBox.TextInput = "";
            this.MinFaceSizeTextBox.TextPreview = "MinFaceSize";
            this.MinFaceSizeTextBox.UseSystemPasswordChar = false;
            // 
            // MinNeighborsTextBox
            // 
            this.MinNeighborsTextBox.BackColor = System.Drawing.Color.White;
            this.MinNeighborsTextBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.MinNeighborsTextBox.BorderColorNotActive = System.Drawing.Color.Lime;
            this.MinNeighborsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinNeighborsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinNeighborsTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.MinNeighborsTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinNeighborsTextBox.ForeColor = System.Drawing.Color.Black;
            this.MinNeighborsTextBox.Location = new System.Drawing.Point(4, 196);
            this.MinNeighborsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MinNeighborsTextBox.Name = "MinNeighborsTextBox";
            this.MinNeighborsTextBox.Size = new System.Drawing.Size(149, 58);
            this.MinNeighborsTextBox.TabIndex = 16;
            this.MinNeighborsTextBox.TextInput = "";
            this.MinNeighborsTextBox.TextPreview = "MinNeighbors";
            this.MinNeighborsTextBox.UseSystemPasswordChar = false;
            // 
            // ColorRectangleFaceLabel
            // 
            this.ColorRectangleFaceLabel.AutoSize = true;
            this.ColorRectangleFaceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorRectangleFaceLabel.Location = new System.Drawing.Point(191, 317);
            this.ColorRectangleFaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorRectangleFaceLabel.Name = "ColorRectangleFaceLabel";
            this.ColorRectangleFaceLabel.Size = new System.Drawing.Size(137, 19);
            this.ColorRectangleFaceLabel.TabIndex = 13;
            this.ColorRectangleFaceLabel.Text = "Цвет обводки лица";
            // 
            // ColorPenLabel
            // 
            this.ColorPenLabel.AutoSize = true;
            this.ColorPenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPenLabel.Location = new System.Drawing.Point(228, 343);
            this.ColorPenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorPenLabel.Name = "ColorPenLabel";
            this.ColorPenLabel.Size = new System.Drawing.Size(100, 19);
            this.ColorPenLabel.TabIndex = 14;
            this.ColorPenLabel.Text = "Цвет шрифта";
            // 
            // PenSizeTextBox
            // 
            this.PenSizeTextBox.BackColor = System.Drawing.Color.White;
            this.PenSizeTextBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.PenSizeTextBox.BorderColorNotActive = System.Drawing.Color.Lime;
            this.PenSizeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PenSizeTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.PenSizeTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8F);
            this.PenSizeTextBox.ForeColor = System.Drawing.Color.Black;
            this.PenSizeTextBox.Location = new System.Drawing.Point(213, 215);
            this.PenSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PenSizeTextBox.Name = "PenSizeTextBox";
            this.PenSizeTextBox.Size = new System.Drawing.Size(185, 49);
            this.PenSizeTextBox.TabIndex = 15;
            this.PenSizeTextBox.TextInput = "";
            this.PenSizeTextBox.TextPreview = "Размер ручки";
            this.PenSizeTextBox.UseSystemPasswordChar = false;
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.BackColor = System.Drawing.Color.White;
            this.IntervalTextBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.IntervalTextBox.BorderColorNotActive = System.Drawing.Color.Lime;
            this.IntervalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IntervalTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.IntervalTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8F);
            this.IntervalTextBox.ForeColor = System.Drawing.Color.Black;
            this.IntervalTextBox.Location = new System.Drawing.Point(213, 401);
            this.IntervalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(185, 49);
            this.IntervalTextBox.TabIndex = 16;
            this.IntervalTextBox.TextInput = "";
            this.IntervalTextBox.TextPreview = "Интервал добавления";
            this.IntervalTextBox.UseSystemPasswordChar = false;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(145)))));
            this.OkButton.ColorHoverFill = System.Drawing.Color.LightSeaGreen;
            this.OkButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.OkButton.ForeColor = System.Drawing.Color.Black;
            this.OkButton.Location = new System.Drawing.Point(427, 422);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4);
            this.OkButton.Name = "OkButton";
            this.OkButton.RoundingEnable = false;
            this.OkButton.Size = new System.Drawing.Size(177, 37);
            this.OkButton.TabIndex = 17;
            this.OkButton.Text = "Применить";
            this.OkButton.TextHover = "Принять изменения";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // FrameSizeTextBox
            // 
            this.FrameSizeTextBox.BackColor = System.Drawing.Color.White;
            this.FrameSizeTextBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.FrameSizeTextBox.BorderColorNotActive = System.Drawing.Color.Lime;
            this.FrameSizeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FrameSizeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrameSizeTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.FrameSizeTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8F);
            this.FrameSizeTextBox.ForeColor = System.Drawing.Color.Black;
            this.FrameSizeTextBox.Location = new System.Drawing.Point(4, 37);
            this.FrameSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FrameSizeTextBox.Name = "FrameSizeTextBox";
            this.FrameSizeTextBox.Size = new System.Drawing.Size(210, 59);
            this.FrameSizeTextBox.TabIndex = 18;
            this.FrameSizeTextBox.TextInput = "";
            this.FrameSizeTextBox.TextPreview = "Размер кадра";
            this.FrameSizeTextBox.UseSystemPasswordChar = false;
            // 
            // FaceSizeTextBox
            // 
            this.FaceSizeTextBox.BackColor = System.Drawing.Color.White;
            this.FaceSizeTextBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.FaceSizeTextBox.BorderColorNotActive = System.Drawing.Color.Lime;
            this.FaceSizeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FaceSizeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FaceSizeTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.FaceSizeTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8F);
            this.FaceSizeTextBox.ForeColor = System.Drawing.Color.Black;
            this.FaceSizeTextBox.Location = new System.Drawing.Point(4, 104);
            this.FaceSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FaceSizeTextBox.Name = "FaceSizeTextBox";
            this.FaceSizeTextBox.Size = new System.Drawing.Size(210, 60);
            this.FaceSizeTextBox.TabIndex = 19;
            this.FaceSizeTextBox.TextInput = "";
            this.FaceSizeTextBox.TextPreview = "Размер лица для обработки";
            this.FaceSizeTextBox.UseSystemPasswordChar = false;
            // 
            // PorogTextBox
            // 
            this.PorogTextBox.BackColor = System.Drawing.Color.White;
            this.PorogTextBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.PorogTextBox.BorderColorNotActive = System.Drawing.Color.Lime;
            this.PorogTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PorogTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.PorogTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8F);
            this.PorogTextBox.ForeColor = System.Drawing.Color.Black;
            this.PorogTextBox.Location = new System.Drawing.Point(418, 257);
            this.PorogTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PorogTextBox.Name = "PorogTextBox";
            this.PorogTextBox.Size = new System.Drawing.Size(177, 49);
            this.PorogTextBox.TabIndex = 21;
            this.PorogTextBox.TextInput = "";
            this.PorogTextBox.TextPreview = "Вероятность (все, что ниже считается неизвестно)";
            this.PorogTextBox.UseSystemPasswordChar = false;
            this.PorogTextBox.Click += new System.EventHandler(this.Porog2TextBox_Click);
            // 
            // ResizePanel2
            // 
            this.ResizePanel2.ColumnCount = 1;
            this.ResizePanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResizePanel2.Controls.Add(this.ResizeCheckBox, 0, 0);
            this.ResizePanel2.Controls.Add(this.FaceSizeTextBox, 0, 2);
            this.ResizePanel2.Controls.Add(this.FrameSizeTextBox, 0, 1);
            this.ResizePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResizePanel2.Location = new System.Drawing.Point(5, 5);
            this.ResizePanel2.Margin = new System.Windows.Forms.Padding(4);
            this.ResizePanel2.Name = "ResizePanel2";
            this.ResizePanel2.RowCount = 3;
            this.ResizePanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResizePanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ResizePanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ResizePanel2.Size = new System.Drawing.Size(218, 168);
            this.ResizePanel2.TabIndex = 23;
            // 
            // ResizeCheckBox
            // 
            this.ResizeCheckBox.AutoSize = true;
            this.ResizeCheckBox.Checked = true;
            this.ResizeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResizeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResizeCheckBox.Location = new System.Drawing.Point(4, 4);
            this.ResizeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResizeCheckBox.Name = "ResizeCheckBox";
            this.ResizeCheckBox.Size = new System.Drawing.Size(210, 25);
            this.ResizeCheckBox.TabIndex = 25;
            this.ResizeCheckBox.Text = "Менять размеры кадра";
            this.ResizeCheckBox.UseVisualStyleBackColor = true;
            this.ResizeCheckBox.CheckedChanged += new System.EventHandler(this.ResizeCheckBox_CheckedChanged);
            // 
            // ResizePanel1
            // 
            this.ResizePanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ResizePanel1.ColumnCount = 1;
            this.ResizePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResizePanel1.Controls.Add(this.ResizePanel2, 0, 0);
            this.ResizePanel1.Location = new System.Drawing.Point(191, 5);
            this.ResizePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.ResizePanel1.Name = "ResizePanel1";
            this.ResizePanel1.RowCount = 1;
            this.ResizePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResizePanel1.Size = new System.Drawing.Size(228, 178);
            this.ResizePanel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(208, 372);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Разыскиваемые";
            // 
            // IsShowMiddleCheckBox
            // 
            this.IsShowMiddleCheckBox.AutoSize = true;
            this.IsShowMiddleCheckBox.Location = new System.Drawing.Point(213, 191);
            this.IsShowMiddleCheckBox.Name = "IsShowMiddleCheckBox";
            this.IsShowMiddleCheckBox.Size = new System.Drawing.Size(180, 21);
            this.IsShowMiddleCheckBox.TabIndex = 27;
            this.IsShowMiddleCheckBox.Text = "Показывать все кадры";
            this.IsShowMiddleCheckBox.UseVisualStyleBackColor = true;
            this.IsShowMiddleCheckBox.CheckedChanged += new System.EventHandler(this.IsShowMiddle_CheckedChanged);
            // 
            // CheckPhotoUpdatesButton
            // 
            this.CheckPhotoUpdatesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckPhotoUpdatesButton.ColorHoverFill = System.Drawing.Color.Gray;
            this.CheckPhotoUpdatesButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.CheckPhotoUpdatesButton.ForeColor = System.Drawing.Color.White;
            this.CheckPhotoUpdatesButton.Location = new System.Drawing.Point(427, 370);
            this.CheckPhotoUpdatesButton.Name = "CheckPhotoUpdatesButton";
            this.CheckPhotoUpdatesButton.RoundingEnable = false;
            this.CheckPhotoUpdatesButton.Size = new System.Drawing.Size(177, 45);
            this.CheckPhotoUpdatesButton.TabIndex = 28;
            this.CheckPhotoUpdatesButton.Text = "Проверить наличие новых фото";
            this.CheckPhotoUpdatesButton.TextHover = "Проверка сайта МВД на наличие обновлений разыскиваемых";
            this.CheckPhotoUpdatesButton.Click += new System.EventHandler(this.CheckPhotoUpdatesButton_Click);
            // 
            // IsDrawLandmarksCheckBox
            // 
            this.IsDrawLandmarksCheckBox.AutoSize = true;
            this.IsDrawLandmarksCheckBox.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsDrawLandmarksCheckBox.Location = new System.Drawing.Point(406, 312);
            this.IsDrawLandmarksCheckBox.Name = "IsDrawLandmarksCheckBox";
            this.IsDrawLandmarksCheckBox.Size = new System.Drawing.Size(198, 21);
            this.IsDrawLandmarksCheckBox.TabIndex = 29;
            this.IsDrawLandmarksCheckBox.Text = "Рисовать ключевые точки лица";
            this.IsDrawLandmarksCheckBox.UseVisualStyleBackColor = true;
            this.IsDrawLandmarksCheckBox.CheckedChanged += new System.EventHandler(this.IsDrawLandmarksCheckBox_CheckedChanged);
            // 
            // IsDrawCiphersCheckBox
            // 
            this.IsDrawCiphersCheckBox.AutoSize = true;
            this.IsDrawCiphersCheckBox.Location = new System.Drawing.Point(406, 339);
            this.IsDrawCiphersCheckBox.Name = "IsDrawCiphersCheckBox";
            this.IsDrawCiphersCheckBox.Size = new System.Drawing.Size(194, 21);
            this.IsDrawCiphersCheckBox.TabIndex = 30;
            this.IsDrawCiphersCheckBox.Text = "Ставить цифры к точкам";
            this.IsDrawCiphersCheckBox.UseVisualStyleBackColor = true;
            this.IsDrawCiphersCheckBox.CheckedChanged += new System.EventHandler(this.IsDrawCiphersCheckBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 474);
            this.Controls.Add(this.IsDrawCiphersCheckBox);
            this.Controls.Add(this.IsDrawLandmarksCheckBox);
            this.Controls.Add(this.CheckPhotoUpdatesButton);
            this.Controls.Add(this.IsShowMiddleCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResizePanel1);
            this.Controls.Add(this.PorogTextBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.PenSizeTextBox);
            this.Controls.Add(this.ColorPenLabel);
            this.Controls.Add(this.ColorRectangleFaceLabel);
            this.Controls.Add(this.HaarPanel1);
            this.Controls.Add(this.ColorPanel1);
            this.Controls.Add(this.RecognitionPanel1);
            this.Controls.Add(this.DetectionAlgoritmPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.DetectionAlgoritmPanel2.ResumeLayout(false);
            this.DetectionAlgoritmPanel2.PerformLayout();
            this.DetectionAlgoritmPanel1.ResumeLayout(false);
            this.RecognitionPanel1.ResumeLayout(false);
            this.RecognitionPanel2.ResumeLayout(false);
            this.RecognitionPanel2.PerformLayout();
            this.RecognitionPanel3.ResumeLayout(false);
            this.RecognitionPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ColorPanel1.ResumeLayout(false);
            this.ColorPanel2.ResumeLayout(false);
            this.ColorPanel2.PerformLayout();
            this.HaarPanel1.ResumeLayout(false);
            this.HaarPanel2.ResumeLayout(false);
            this.HaarPanel2.PerformLayout();
            this.ResizePanel2.ResumeLayout(false);
            this.ResizePanel2.PerformLayout();
            this.ResizePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDesign.Components.CustomFormStyle SettingsFormStyle;
        private System.Windows.Forms.Label ColorPenLabel;
        private System.Windows.Forms.Label ColorRectangleFaceLabel;
        private System.Windows.Forms.TableLayoutPanel HaarPanel1;
        private System.Windows.Forms.TableLayoutPanel HaarPanel2;
        private System.Windows.Forms.Label HaarSettingsLabel;
        private CustomDesign.CustomTextBox ScaleFactorTextBox;
        private CustomDesign.CustomTextBox MinFaceSizeTextBox;
        private CustomDesign.CustomTextBox MinNeighborsTextBox;
        private System.Windows.Forms.TableLayoutPanel ColorPanel1;
        private System.Windows.Forms.TableLayoutPanel ColorPanel2;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button RectangleFaceColorButton;
        private System.Windows.Forms.Button PenColorButton;
        private System.Windows.Forms.TableLayoutPanel RecognitionPanel1;
        private System.Windows.Forms.TableLayoutPanel RecognitionPanel2;
        private System.Windows.Forms.Label RecognitionAlgoritmLabel;
        private CustomDesign.CustomRadioButton DNNRadioButton;
        private System.Windows.Forms.TableLayoutPanel DetectionAlgoritmPanel1;
        private System.Windows.Forms.TableLayoutPanel DetectionAlgoritmPanel2;
        private CustomDesign.CustomRadioButton CnnRadioButton;
        private CustomDesign.CustomRadioButton HogRadioButton;
        private CustomDesign.CustomRadioButton HaarRadioButton;
        private System.Windows.Forms.Label DetectionAlgoritmLabel;
        private CustomDesign.CustomTextBox PenSizeTextBox;
        private CustomDesign.CustomButton OkButton;
        private CustomDesign.CustomTextBox IntervalTextBox;
        private CustomDesign.CustomTextBox FaceSizeTextBox;
        private CustomDesign.CustomTextBox FrameSizeTextBox;
        private CustomDesign.CustomTextBox PorogTextBox;
        private System.Windows.Forms.TableLayoutPanel ResizePanel1;
        private System.Windows.Forms.TableLayoutPanel ResizePanel2;
        private System.Windows.Forms.CheckBox ResizeCheckBox;
        private CustomDesign.CustomRadioButton FasterR_CNN_RadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RectangleEvidenceColor;
        private System.Windows.Forms.CheckBox IsUseRecognizerCheckBox;
        private System.Windows.Forms.CheckBox IsShowMiddleCheckBox;
        private CustomDesign.CustomButton CheckPhotoUpdatesButton;
        private System.Windows.Forms.CheckBox IsDrawLandmarksCheckBox;
        private System.Windows.Forms.TableLayoutPanel RecognitionPanel3;
        private System.Windows.Forms.Label PredictionModelLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomDesign.CustomRadioButton SmallRadioButton;
        private CustomDesign.CustomRadioButton LargeRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomDesign.CustomRadioButton Hog_RRadioButton;
        private CustomDesign.CustomRadioButton Cnn_RRadioButton;
        private System.Windows.Forms.CheckBox IsDrawCiphersCheckBox;
    }
}