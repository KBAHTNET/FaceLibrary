namespace FaceDetectionAndRecognition_By_IlyaBratskih
{
    partial class ChoseDetectRegion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoseDetectRegion));
            this.PreviewRegion = new Emgu.CV.UI.ImageBox();
            this.ChosenRegionsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChoseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewRegion
            // 
            this.PreviewRegion.Location = new System.Drawing.Point(12, 12);
            this.PreviewRegion.Name = "PreviewRegion";
            this.PreviewRegion.Size = new System.Drawing.Size(320, 253);
            this.PreviewRegion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewRegion.TabIndex = 2;
            this.PreviewRegion.TabStop = false;
            // 
            // ChosenRegionsList
            // 
            this.ChosenRegionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ChosenRegionsList.FullRowSelect = true;
            this.ChosenRegionsList.HideSelection = false;
            this.ChosenRegionsList.Location = new System.Drawing.Point(338, 12);
            this.ChosenRegionsList.Name = "ChosenRegionsList";
            this.ChosenRegionsList.Size = new System.Drawing.Size(98, 224);
            this.ChosenRegionsList.TabIndex = 3;
            this.ChosenRegionsList.UseCompatibleStateImageBehavior = false;
            this.ChosenRegionsList.View = System.Windows.Forms.View.Details;
            this.ChosenRegionsList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ChosenRegionsList_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер региона";
            this.columnHeader1.Width = 94;
            // 
            // ChoseButton
            // 
            this.ChoseButton.Location = new System.Drawing.Point(338, 242);
            this.ChoseButton.Name = "ChoseButton";
            this.ChoseButton.Size = new System.Drawing.Size(98, 23);
            this.ChoseButton.TabIndex = 4;
            this.ChoseButton.Text = "Выбрать";
            this.ChoseButton.UseVisualStyleBackColor = true;
            this.ChoseButton.Click += new System.EventHandler(this.Chose_Click);
            // 
            // ChoseDetectRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 277);
            this.Controls.Add(this.ChoseButton);
            this.Controls.Add(this.ChosenRegionsList);
            this.Controls.Add(this.PreviewRegion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChoseDetectRegion";
            this.Text = "ChoseDetectRegion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChoseDetectRegion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewRegion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox PreviewRegion;
        private System.Windows.Forms.ListView ChosenRegionsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button ChoseButton;
    }
}