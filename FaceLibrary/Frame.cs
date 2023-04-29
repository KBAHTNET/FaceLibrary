using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace FaceLibrary
{
    public class Frame
    {
        public int frameNum;
        public Mat frame;

        public Frame()
        {
            frameNum = -1;
            frame = new Mat();
        }

        public Frame(Mat frame, int frameNum)
        {
            this.frame = frame;
            this.frameNum = frameNum;
        }
    }
}
