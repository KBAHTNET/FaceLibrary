namespace FaceLibrary
{
    partial class ChoseDetectedRegions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoseDetectedRegions));
            this.NameTextBox = new CustomDesign.CustomTextBox();
            this.RegionsListView = new System.Windows.Forms.ListView();
            this.NumRegionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.faceBox = new Emgu.CV.UI.ImageBox();
            this.ChoseDetectedRegionsStyle = new CustomDesign.Components.CustomFormStyle(this.components);
            this.AddButton = new CustomDesign.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.faceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NameTextBox.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.NameTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.NameTextBox.ForeColor = System.Drawing.Color.Black;
            this.NameTextBox.Location = new System.Drawing.Point(16, 15);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(585, 49);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextInput = "";
            this.NameTextBox.TextPreview = "Имя лица";
            this.NameTextBox.UseSystemPasswordChar = false;
            // 
            // RegionsListView
            // 
            this.RegionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumRegionColumn});
            this.RegionsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionsListView.FullRowSelect = true;
            this.RegionsListView.HideSelection = false;
            this.RegionsListView.Location = new System.Drawing.Point(347, 71);
            this.RegionsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegionsListView.MultiSelect = false;
            this.RegionsListView.Name = "RegionsListView";
            this.RegionsListView.ShowItemToolTips = true;
            this.RegionsListView.Size = new System.Drawing.Size(253, 356);
            this.RegionsListView.TabIndex = 1;
            this.RegionsListView.TileSize = new System.Drawing.Size(25, 45);
            this.RegionsListView.UseCompatibleStateImageBehavior = false;
            this.RegionsListView.View = System.Windows.Forms.View.Details;
            this.RegionsListView.SelectedIndexChanged += new System.EventHandler(this.RegionsListView_SelectedIndexChanged);
            // 
            // NumRegionColumn
            // 
            this.NumRegionColumn.Text = "№";
            this.NumRegionColumn.Width = 180;
            // 
            // faceBox
            // 
            this.faceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.faceBox.Location = new System.Drawing.Point(16, 71);
            this.faceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.faceBox.Name = "faceBox";
            this.faceBox.Size = new System.Drawing.Size(323, 357);
            this.faceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.faceBox.TabIndex = 2;
            this.faceBox.TabStop = false;
            // 
            // ChoseDetectedRegionsStyle
            // 
            this.ChoseDetectedRegionsStyle.AllowUserResize = false;
            this.ChoseDetectedRegionsStyle.ContextMenuForm = null;
            this.ChoseDetectedRegionsStyle.EnableControlBoxIconsLight = true;
            this.ChoseDetectedRegionsStyle.EnableControlBoxMouseLight = true;
            this.ChoseDetectedRegionsStyle.Form = this;
            this.ChoseDetectedRegionsStyle.FormStyle = CustomDesign.Components.CustomFormStyle.fStyle.None;
            this.ChoseDetectedRegionsStyle.HeaderColor = System.Drawing.Color.Navy;
            this.ChoseDetectedRegionsStyle.HeaderFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ChoseDetectedRegionsStyle.HeaderHeight = 30;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddButton.ColorHoverFill = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.AddButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(468, 436);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.RoundingEnable = false;
            this.AddButton.Size = new System.Drawing.Size(133, 37);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextHover = null;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChoseDetectedRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 479);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.faceBox);
            this.Controls.Add(this.RegionsListView);
            this.Controls.Add(this.NameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChoseDetectedRegions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление лица с кадра";
            ((System.ComponentModel.ISupportInitialize)(this.faceBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDesign.CustomTextBox NameTextBox;
        private System.Windows.Forms.ListView RegionsListView;
        private Emgu.CV.UI.ImageBox faceBox;
        private CustomDesign.Components.CustomFormStyle ChoseDetectedRegionsStyle;
        private CustomDesign.CustomButton AddButton;
        private System.Windows.Forms.ColumnHeader NumRegionColumn;
    }
}