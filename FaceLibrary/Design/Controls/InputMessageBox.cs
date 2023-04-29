using System;
using System.Drawing;

namespace CustomDesign.Controls
{
    public partial class InputMessageBox : ShadowedForm
    {
        public InputMessageBox()
        {
            InitializeComponent();
            Animator.Start();
        }

        public static string ShowMessage(string Message, string Titile = "", string DefaulValue = "", string TextPreview = "Поле ввода",Image Icon = null)
        {
            InputMessageBox inputMessageBox = new InputMessageBox();
            inputMessageBox.MessageLabel.Text = Message;
            inputMessageBox.Text = Titile;
            inputMessageBox.InputTextBox.Text = DefaulValue;
            inputMessageBox.InputTextBox.TextPreview = TextPreview;
            inputMessageBox.IconBox.Image = Icon;
            inputMessageBox.ShowDialog();
            return inputMessageBox.InputTextBox.Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
