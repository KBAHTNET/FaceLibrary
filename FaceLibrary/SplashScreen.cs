using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceLibrary
{
    public partial class SplashScreen : Form
    {
        #region Функции
        private static IEnumerable<Image> Frames(Image gif)
        {
            FrameDimension d = new FrameDimension(gif.FrameDimensionsList[0]);
            for (int i = 0; i < gif.GetFrameCount(d); i++)
            {
                gif.SelectActiveFrame(d, i);
                Bitmap ci = new Bitmap(gif.Width, gif.Height);
                using (Graphics g = Graphics.FromImage(ci))
                    g.DrawImageUnscaled(gif, 0, 0);
                yield return ci;
            }
        }

        private void Animate()
        {
            int k = 0;
            while (run)
            {
                try
                {
                    SplashBox.Image = img[k];
                }
                catch { }
                Thread.Sleep(40);
                k++;
                if (k > img.Count - 1)
                {
                    img.Reverse();
                    k = 0;
                }
            }
        }
        #endregion
        private List<Image> img = new List<Image>();
        private bool run = false;

        public SplashScreen()
        {
            InitializeComponent();

            Image gif = null;
            using (Stream s = new MemoryStream(Properties.Resources.Animation_gif))
            {
                gif = Image.FromStream(s);


                foreach (Image frame in Frames(gif))
                {
                    img.Add(frame);
                }

                SplashBox.Image = img[0];

                timer1.Start();
                Task t = new Task(() => Animate());
                t.Start();
                run = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.02;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void SplashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            run = false;
        }
    }
}
