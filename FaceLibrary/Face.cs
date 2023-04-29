using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceLibrary
{
    public class Face
    {
        private Rectangle location;
        public Bitmap bmp;
        public string name;

        public FaceRecognitionDotNet.FaceEncoding encoding;

        public Face()
        {
            bmp = null;
            name = "";
            location = new Rectangle(0, 0, 0, 0);
            encoding = null;
        }

        public Face(Rectangle location, Bitmap bmp, string name)
        {
            encoding = null;
            this.location = location;
            this.bmp = bmp;
            this.name = name;
        }

        public Face(Rectangle location, Bitmap bmp, string name, FaceRecognitionDotNet.FaceEncoding encoding)
        {
            this.encoding = encoding;
            this.location = location;
            this.bmp = bmp;
            this.name = name;
        }

        public FaceRecognitionDotNet.Location GetLocation()
        {
            return new FaceRecognitionDotNet.Location(location.X, location.Y, location.X + location.Width, location.Y + location.Height);
        }

        public Rectangle GetRectangle()
        {
            return location;
        }

        public void SetLocation(Rectangle location)
        {
            this.location = location;
        }

        public void SetLocation(FaceRecognitionDotNet.Location location)
        {
            SetLocation(new Rectangle(new Point(location.Left,location.Top), 
                new Size(location.Right - location.Left, location.Bottom - location.Top)));
        }
    }
}
