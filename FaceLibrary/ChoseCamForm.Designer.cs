namespace FaceLibrary
{
    partial class ChoseCamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoseCamForm));
            this.ChoseCamFormStyle = new CustomDesign.Components.CustomFormStyle(this.components);
            this.CamsBox = new System.Windows.Forms.ComboBox();
            this.ChoseCamLabel = new System.Windows.Forms.Label();
            this.ChoseCamButton = new CustomDesign.CustomButton();
            this.SuspendLayout();
            // 
            // ChoseCamFormStyle
            // 
            this.ChoseCamFormStyle.AllowUserResize = false;
            this.ChoseCamFormStyle.ContextMenuForm = null;
            this.ChoseCamFormStyle.EnableControlBoxIconsLight = true;
            this.ChoseCamFormStyle.EnableControlBoxMouseLight = true;
            this.ChoseCamFormStyle.Form = this;
            this.ChoseCamFormStyle.FormStyle = CustomDesign.Components.CustomFormStyle.fStyle.SimpleDark;
            this.ChoseCamFormStyle.HeaderColor = System.Drawing.Color.SteelBlue;
            this.ChoseCamFormStyle.HeaderFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ChoseCamFormStyle.HeaderHeight = 30;
            // 
            // CamsBox
            // 
            this.CamsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamsBox.FormattingEnabled = true;
            this.CamsBox.Location = new System.Drawing.Point(21, 80);
            this.CamsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CamsBox.Name = "CamsBox";
            this.CamsBox.Size = new System.Drawing.Size(284, 24);
            this.CamsBox.TabIndex = 0;
            this.CamsBox.SelectedIndexChanged += new System.EventHandler(this.CamsBox_SelectedIndexChanged);
            // 
            // ChoseCamLabel
            // 
            this.ChoseCamLabel.AutoSize = true;
            this.ChoseCamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoseCamLabel.Location = new System.Drawing.Point(16, 30);
            this.ChoseCamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChoseCamLabel.Name = "ChoseCamLabel";
            this.ChoseCamLabel.Size = new System.Drawing.Size(272, 25);
            this.ChoseCamLabel.TabIndex = 1;
            this.ChoseCamLabel.Text = "Выберите камеру из списка";
            // 
            // ChoseCamButton
            // 
            this.ChoseCamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(95)))), ((int)(((byte)(158)))));
            this.ChoseCamButton.ColorHoverFill = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.ChoseCamButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ChoseCamButton.ForeColor = System.Drawing.Color.Black;
            this.ChoseCamButton.Location = new System.Drawing.Point(69, 113);
            this.ChoseCamButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChoseCamButton.Name = "ChoseCamButton";
            this.ChoseCamButton.RoundingEnable = false;
            this.ChoseCamButton.Size = new System.Drawing.Size(181, 37);
            this.ChoseCamButton.TabIndex = 2;
            this.ChoseCamButton.Text = "Выбрать камеру";
            this.ChoseCamButton.TextHover = "Запустить видеопоток";
            this.ChoseCamButton.Click += new System.EventHandler(this.ChoseCamButton_Click);
            // 
            // ChoseCamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 181);
            this.Controls.Add(this.ChoseCamButton);
            this.Controls.Add(this.ChoseCamLabel);
            this.Controls.Add(this.CamsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChoseCamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите камеру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDesign.Components.CustomFormStyle ChoseCamFormStyle;
        private CustomDesign.CustomButton ChoseCamButton;
        private System.Windows.Forms.Label ChoseCamLabel;
        private System.Windows.Forms.ComboBox CamsBox;
    }
}