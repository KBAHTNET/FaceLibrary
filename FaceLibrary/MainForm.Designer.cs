namespace FaceLibrary
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.customMainFormStyle = new CustomDesign.Components.CustomFormStyle(this.components);
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MenuPicrureBox = new System.Windows.Forms.PictureBox();
            this.ElementsMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CameraButton = new CustomDesign.CustomButton();
            this.WebCamButton = new CustomDesign.CustomButton();
            this.VideoButton = new CustomDesign.CustomButton();
            this.SettingsButton = new CustomDesign.CustomButton();
            this.PhotoButton = new CustomDesign.CustomButton();
            this.TrainButton = new CustomDesign.CustomButton();
            this.faceListPanel = new System.Windows.Forms.TableLayoutPanel();
            this.faceBox = new Emgu.CV.UI.ImageBox();
            this.facesTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddedFacesList = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RecognitFacesList = new System.Windows.Forms.ListView();
            this.StopButton = new CustomDesign.CustomButton();
            this.AddButton = new CustomDesign.CustomButton();
            this.frameBox = new Emgu.CV.UI.ImageBox();
            this.progressBar = new CustomDesign.CustomProgressBar();
            this.mainPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPicrureBox)).BeginInit();
            this.ElementsMenuPanel.SuspendLayout();
            this.faceListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faceBox)).BeginInit();
            this.facesTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // customMainFormStyle
            // 
            this.customMainFormStyle.AllowUserResize = true;
            this.customMainFormStyle.ContextMenuForm = null;
            this.customMainFormStyle.EnableControlBoxIconsLight = true;
            this.customMainFormStyle.EnableControlBoxMouseLight = true;
            this.customMainFormStyle.Form = this;
            this.customMainFormStyle.FormStyle = CustomDesign.Components.CustomFormStyle.fStyle.SimpleDark;
            this.customMainFormStyle.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customMainFormStyle.HeaderFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.customMainFormStyle.HeaderHeight = 30;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Black;
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.menuPanel, 0, 0);
            this.mainPanel.Controls.Add(this.frameBox, 1, 0);
            this.mainPanel.Location = new System.Drawing.Point(0, 1);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(1339, 889);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuPanel.ColumnCount = 1;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.menuPanel.Controls.Add(this.MenuPicrureBox, 0, 0);
            this.menuPanel.Controls.Add(this.ElementsMenuPanel, 0, 1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 3;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.13953F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.860465F));
            this.menuPanel.Size = new System.Drawing.Size(267, 889);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseMove);
            // 
            // MenuPicrureBox
            // 
            this.MenuPicrureBox.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPicrureBox.Location = new System.Drawing.Point(4, 4);
            this.MenuPicrureBox.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPicrureBox.MaximumSize = new System.Drawing.Size(53, 44);
            this.MenuPicrureBox.MinimumSize = new System.Drawing.Size(53, 44);
            this.MenuPicrureBox.Name = "MenuPicrureBox";
            this.MenuPicrureBox.Size = new System.Drawing.Size(53, 44);
            this.MenuPicrureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuPicrureBox.TabIndex = 0;
            this.MenuPicrureBox.TabStop = false;
            this.MenuPicrureBox.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // ElementsMenuPanel
            // 
            this.ElementsMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.ElementsMenuPanel.ColumnCount = 1;
            this.ElementsMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ElementsMenuPanel.Controls.Add(this.CameraButton, 0, 0);
            this.ElementsMenuPanel.Controls.Add(this.WebCamButton, 0, 1);
            this.ElementsMenuPanel.Controls.Add(this.VideoButton, 0, 2);
            this.ElementsMenuPanel.Controls.Add(this.SettingsButton, 0, 7);
            this.ElementsMenuPanel.Controls.Add(this.PhotoButton, 0, 3);
            this.ElementsMenuPanel.Controls.Add(this.TrainButton, 0, 4);
            this.ElementsMenuPanel.Controls.Add(this.faceListPanel, 0, 8);
            this.ElementsMenuPanel.Controls.Add(this.StopButton, 0, 6);
            this.ElementsMenuPanel.Controls.Add(this.AddButton, 0, 5);
            this.ElementsMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElementsMenuPanel.Location = new System.Drawing.Point(0, 49);
            this.ElementsMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ElementsMenuPanel.Name = "ElementsMenuPanel";
            this.ElementsMenuPanel.RowCount = 9;
            this.ElementsMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ElementsMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ElementsMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ElementsMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ElementsMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ElementsMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ElementsMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ElementsMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ElementsMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ElementsMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ElementsMenuPanel.Size = new System.Drawing.Size(267, 824);
            this.ElementsMenuPanel.TabIndex = 2;
            this.ElementsMenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ElementsMenuPanel_MouseMove);
            // 
            // CameraButton
            // 
            this.CameraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(163)))), ((int)(((byte)(225)))));
            this.CameraButton.ColorHoverFill = System.Drawing.Color.Teal;
            this.CameraButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.CameraButton.ForeColor = System.Drawing.Color.Black;
            this.CameraButton.Location = new System.Drawing.Point(4, 4);
            this.CameraButton.Margin = new System.Windows.Forms.Padding(4);
            this.CameraButton.Name = "CameraButton";
            this.CameraButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CameraButton.RoundingEnable = false;
            this.CameraButton.Size = new System.Drawing.Size(259, 47);
            this.CameraButton.TabIndex = 0;
            this.CameraButton.Text = "Веб-Камера";
            this.CameraButton.TextHover = "         Подключиться к веб-камере";
            this.CameraButton.Click += new System.EventHandler(this.CameraButton_Click);
            // 
            // WebCamButton
            // 
            this.WebCamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(163)))), ((int)(((byte)(225)))));
            this.WebCamButton.ColorHoverFill = System.Drawing.Color.Teal;
            this.WebCamButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebCamButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.WebCamButton.ForeColor = System.Drawing.Color.Black;
            this.WebCamButton.Location = new System.Drawing.Point(4, 59);
            this.WebCamButton.Margin = new System.Windows.Forms.Padding(4);
            this.WebCamButton.Name = "WebCamButton";
            this.WebCamButton.RoundingEnable = false;
            this.WebCamButton.Size = new System.Drawing.Size(259, 47);
            this.WebCamButton.TabIndex = 2;
            this.WebCamButton.Text = " IP-камера";
            this.WebCamButton.TextHover = "         Подключиться к IP-камере";
            this.WebCamButton.Click += new System.EventHandler(this.WebCamButton_Click);
            // 
            // VideoButton
            // 
            this.VideoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(163)))), ((int)(((byte)(225)))));
            this.VideoButton.ColorHoverFill = System.Drawing.Color.Teal;
            this.VideoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.VideoButton.ForeColor = System.Drawing.Color.Black;
            this.VideoButton.Location = new System.Drawing.Point(4, 114);
            this.VideoButton.Margin = new System.Windows.Forms.Padding(4);
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.RoundingEnable = false;
            this.VideoButton.Size = new System.Drawing.Size(259, 47);
            this.VideoButton.TabIndex = 1;
            this.VideoButton.Text = "Видео";
            this.VideoButton.TextHover = "         Вставить видео фрагмент";
            this.VideoButton.Click += new System.EventHandler(this.VideoButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SettingsButton.ColorHoverFill = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(105)))));
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.SettingsButton.ForeColor = System.Drawing.Color.Black;
            this.SettingsButton.Location = new System.Drawing.Point(4, 389);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.RoundingEnable = false;
            this.SettingsButton.Size = new System.Drawing.Size(259, 47);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.TextHover = "       Метод обнаружения\n      и алгоритм распознавания";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // PhotoButton
            // 
            this.PhotoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(163)))), ((int)(((byte)(225)))));
            this.PhotoButton.ColorHoverFill = System.Drawing.Color.Teal;
            this.PhotoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.PhotoButton.ForeColor = System.Drawing.Color.Black;
            this.PhotoButton.Location = new System.Drawing.Point(4, 169);
            this.PhotoButton.Margin = new System.Windows.Forms.Padding(4);
            this.PhotoButton.Name = "PhotoButton";
            this.PhotoButton.RoundingEnable = false;
            this.PhotoButton.Size = new System.Drawing.Size(259, 47);
            this.PhotoButton.TabIndex = 4;
            this.PhotoButton.Text = " Фото";
            this.PhotoButton.TextHover = "         Обнаружить лица на фото";
            this.PhotoButton.Click += new System.EventHandler(this.PhotoButton_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(163)))), ((int)(((byte)(225)))));
            this.TrainButton.ColorHoverFill = System.Drawing.Color.Teal;
            this.TrainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.TrainButton.ForeColor = System.Drawing.Color.Black;
            this.TrainButton.Location = new System.Drawing.Point(4, 224);
            this.TrainButton.Margin = new System.Windows.Forms.Padding(4);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.RoundingEnable = false;
            this.TrainButton.Size = new System.Drawing.Size(259, 47);
            this.TrainButton.TabIndex = 5;
            this.TrainButton.Text = "    Обучить";
            this.TrainButton.TextHover = "           Тренировка на картинках из папки";
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // faceListPanel
            // 
            this.faceListPanel.ColumnCount = 1;
            this.faceListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.faceListPanel.Controls.Add(this.faceBox, 0, 0);
            this.faceListPanel.Controls.Add(this.facesTabControl, 0, 1);
            this.faceListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faceListPanel.Location = new System.Drawing.Point(4, 444);
            this.faceListPanel.Margin = new System.Windows.Forms.Padding(4);
            this.faceListPanel.Name = "faceListPanel";
            this.faceListPanel.RowCount = 2;
            this.faceListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.faceListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.faceListPanel.Size = new System.Drawing.Size(259, 376);
            this.faceListPanel.TabIndex = 6;
            // 
            // faceBox
            // 
            this.faceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.faceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faceBox.Location = new System.Drawing.Point(4, 4);
            this.faceBox.Margin = new System.Windows.Forms.Padding(4);
            this.faceBox.Name = "faceBox";
            this.faceBox.Size = new System.Drawing.Size(251, 180);
            this.faceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.faceBox.TabIndex = 0;
            this.faceBox.TabStop = false;
            // 
            // facesTabControl
            // 
            this.facesTabControl.Controls.Add(this.tabPage1);
            this.facesTabControl.Controls.Add(this.tabPage2);
            this.facesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facesTabControl.Location = new System.Drawing.Point(4, 192);
            this.facesTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.facesTabControl.Name = "facesTabControl";
            this.facesTabControl.SelectedIndex = 0;
            this.facesTabControl.Size = new System.Drawing.Size(251, 180);
            this.facesTabControl.TabIndex = 1;
            this.facesTabControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.facesTabControl_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.AddedFacesList);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(243, 151);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавленные";
            // 
            // AddedFacesList
            // 
            this.AddedFacesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddedFacesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddedFacesList.FullRowSelect = true;
            this.AddedFacesList.HideSelection = false;
            this.AddedFacesList.Location = new System.Drawing.Point(4, 4);
            this.AddedFacesList.Margin = new System.Windows.Forms.Padding(4);
            this.AddedFacesList.MultiSelect = false;
            this.AddedFacesList.Name = "AddedFacesList";
            this.AddedFacesList.ShowItemToolTips = true;
            this.AddedFacesList.Size = new System.Drawing.Size(235, 143);
            this.AddedFacesList.TabIndex = 0;
            this.AddedFacesList.TileSize = new System.Drawing.Size(200, 36);
            this.AddedFacesList.UseCompatibleStateImageBehavior = false;
            this.AddedFacesList.View = System.Windows.Forms.View.Tile;
            this.AddedFacesList.SelectedIndexChanged += new System.EventHandler(this.AddedFacesList_SelectedIndexChanged);
            this.AddedFacesList.Click += new System.EventHandler(this.AddedFacesList_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.RecognitFacesList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(243, 151);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Обнаруженные";
            // 
            // RecognitFacesList
            // 
            this.RecognitFacesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecognitFacesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecognitFacesList.FullRowSelect = true;
            this.RecognitFacesList.HideSelection = false;
            this.RecognitFacesList.Location = new System.Drawing.Point(4, 4);
            this.RecognitFacesList.Margin = new System.Windows.Forms.Padding(4);
            this.RecognitFacesList.MultiSelect = false;
            this.RecognitFacesList.Name = "RecognitFacesList";
            this.RecognitFacesList.ShowItemToolTips = true;
            this.RecognitFacesList.Size = new System.Drawing.Size(235, 143);
            this.RecognitFacesList.TabIndex = 0;
            this.RecognitFacesList.TileSize = new System.Drawing.Size(200, 36);
            this.RecognitFacesList.UseCompatibleStateImageBehavior = false;
            this.RecognitFacesList.View = System.Windows.Forms.View.Tile;
            this.RecognitFacesList.SelectedIndexChanged += new System.EventHandler(this.RecognitFacesList_SelectedIndexChanged);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StopButton.ColorHoverFill = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(136)))));
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(4, 334);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopButton.Name = "StopButton";
            this.StopButton.RoundingEnable = false;
            this.StopButton.Size = new System.Drawing.Size(259, 47);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "Стоп";
            this.StopButton.TextHover = "           Закрыть видео поток";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(163)))), ((int)(((byte)(225)))));
            this.AddButton.ColorHoverFill = System.Drawing.Color.Teal;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(4, 279);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.RoundingEnable = false;
            this.AddButton.Size = new System.Drawing.Size(259, 47);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "  Добавить";
            this.AddButton.TextHover = "      Добавить лицо с кадра";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // frameBox
            // 
            this.frameBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.frameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameBox.Location = new System.Drawing.Point(271, 4);
            this.frameBox.Margin = new System.Windows.Forms.Padding(4);
            this.frameBox.Name = "frameBox";
            this.frameBox.Size = new System.Drawing.Size(1064, 881);
            this.frameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frameBox.TabIndex = 1;
            this.frameBox.TabStop = false;
            this.frameBox.SizeChanged += new System.EventHandler(this.frameBox_SizeChanged);
            this.frameBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frameBox_MouseMove);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.progressBar.BackColorProgressLeft = System.Drawing.Color.Red;
            this.progressBar.BackColorProgressRight = System.Drawing.Color.Lime;
            this.progressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.progressBar.Location = new System.Drawing.Point(127, -31);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(267, 25);
            this.progressBar.Step = 10;
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 0;
            this.progressBar.ValueMaximum = 100;
            this.progressBar.ValueMinimum = 0;
            this.progressBar.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopIB";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.mainPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuPicrureBox)).EndInit();
            this.ElementsMenuPanel.ResumeLayout(false);
            this.faceListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.faceBox)).EndInit();
            this.facesTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDesign.Components.CustomFormStyle customMainFormStyle;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.PictureBox MenuPicrureBox;
        private System.Windows.Forms.TableLayoutPanel ElementsMenuPanel;
        private CustomDesign.CustomButton CameraButton;
        private CustomDesign.CustomButton SettingsButton;
        private CustomDesign.CustomButton PhotoButton;
        private CustomDesign.CustomButton TrainButton;
        private Emgu.CV.UI.ImageBox frameBox;
        private System.Windows.Forms.TableLayoutPanel faceListPanel;
        private Emgu.CV.UI.ImageBox faceBox;
        private System.Windows.Forms.TabControl facesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.ListView AddedFacesList;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ListView RecognitFacesList;
        private CustomDesign.CustomButton StopButton;
        private CustomDesign.CustomButton AddButton;
        private CustomDesign.CustomProgressBar progressBar;
        private CustomDesign.CustomButton VideoButton;
        private CustomDesign.CustomButton WebCamButton;
    }
}

