namespace CustomDesign.Controls
{
    partial class InputMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputMessageBox));
            this.InputMessageBoxStyle = new CustomDesign.Components.CustomFormStyle(this.components);
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.InputTextBox = new CustomDesign.CustomTextBox();
            this.OkButton = new CustomDesign.CustomButton();
            this.labelPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputMessageBoxStyle
            // 
            this.InputMessageBoxStyle.AllowUserResize = false;
            this.InputMessageBoxStyle.ContextMenuForm = null;
            this.InputMessageBoxStyle.EnableControlBoxIconsLight = true;
            this.InputMessageBoxStyle.EnableControlBoxMouseLight = true;
            this.InputMessageBoxStyle.Form = this;
            this.InputMessageBoxStyle.FormStyle = CustomDesign.Components.CustomFormStyle.fStyle.SimpleDark;
            this.InputMessageBoxStyle.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputMessageBoxStyle.HeaderFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.InputMessageBoxStyle.HeaderHeight = 30;
            // 
            // IconBox
            // 
            this.IconBox.Location = new System.Drawing.Point(16, 10);
            this.IconBox.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(61, 57);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconBox.TabIndex = 2;
            this.IconBox.TabStop = false;
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.Color.White;
            this.InputTextBox.BorderColor = System.Drawing.Color.DarkOrchid;
            this.InputTextBox.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.InputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.InputTextBox.ForeColor = System.Drawing.Color.Black;
            this.InputTextBox.Location = new System.Drawing.Point(16, 164);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(720, 44);
            this.InputTextBox.TabIndex = 3;
            this.InputTextBox.TextInput = "customTextBox1";
            this.InputTextBox.TextPreview = "Input text";
            this.InputTextBox.UseSystemPasswordChar = false;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OkButton.ColorHoverFill = System.Drawing.Color.Gray;
            this.OkButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.Location = new System.Drawing.Point(299, 236);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.RoundingEnable = false;
            this.OkButton.Size = new System.Drawing.Size(185, 43);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ввод";
            this.OkButton.TextHover = "Подтвердить ввод";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // labelPanel
            // 
            this.labelPanel.ColumnCount = 1;
            this.labelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.labelPanel.Controls.Add(this.MessageLabel, 0, 0);
            this.labelPanel.Location = new System.Drawing.Point(95, 10);
            this.labelPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.RowCount = 1;
            this.labelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.labelPanel.Size = new System.Drawing.Size(641, 146);
            this.labelPanel.TabIndex = 5;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLabel.Location = new System.Drawing.Point(4, 4);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(633, 138);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "label1";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 294);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.IconBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InputMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Components.CustomFormStyle InputMessageBoxStyle;
        private System.Windows.Forms.TableLayoutPanel labelPanel;
        private System.Windows.Forms.Label MessageLabel;
        private CustomButton OkButton;
        private CustomTextBox InputTextBox;
        private System.Windows.Forms.PictureBox IconBox;
    }
}