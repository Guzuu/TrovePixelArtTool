using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace TrovePixelArtTool
{
    public class PixelArt
    {
        public PixelArt(Bitmap srcImage)
        {
            this.srcImage = srcImage;
        }

        public Bitmap ScaleImage(int scalar)
        {
            int width = Convert.ToInt32(srcImage.Width * (0.02f * scalar)); //rozmiar skalowany
            int height = Convert.ToInt32(srcImage.Height * (0.02f * scalar));

            var destRect = new Rectangle(0, 0, width, height);
            var OutputImage = new Bitmap(width, height);

            OutputImage.SetResolution(srcImage.HorizontalResolution, srcImage.VerticalResolution);

            using (var graphics = Graphics.FromImage(OutputImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.None;
                graphics.PixelOffsetMode = PixelOffsetMode.Half;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.Clamp);
                    graphics.DrawImage(srcImage, destRect, 0, 0, srcImage.Width, srcImage.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            PixelArtResolution = new Resolution(OutputImage.Width, OutputImage.Height);
            return OutputImage;
        }

        public struct Resolution
        {
            public Resolution(int X, int Y) : this()
            {
                this.X = X;
                this.Y = Y;
            }

            public int X;
            public int Y;
        }

        public Bitmap srcImage { get; private set; }
        public Resolution PixelArtResolution { get; private set; }
    }
}
