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
            int width = Convert.ToInt32(srcImage.Width * (0.01f * scalar)); //rozmiar skalowany
            int height = Convert.ToInt32(srcImage.Height * (0.01f * scalar));

            var destRect = new Rectangle(0, 0, width, height);
            var OutputImage = new Bitmap(width, height);

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
            OutImage = OutputImage;
            return OutputImage;
        }

        public void RGBtoLAB(int x, int y)
        {
            double var_R, var_G, var_B, X, Y, Z, ref_X = 95.047, ref_Y= 100.000, ref_Z = 108.883, CIE_L, CIE_a, CIE_b; //reference D65 2*

            var_R = (OutImage.GetPixel(x, y).R / 255.0);
            var_G = (OutImage.GetPixel(x, y).G / 255.0);
            var_B = (OutImage.GetPixel(x, y).B / 255.0);

            if (var_R > 0.04045) var_R = Math.Pow((var_R + 0.055) / 1.055, 2.4);
            else var_R = var_R / 12.92;
            if (var_G > 0.04045) var_G = Math.Pow((var_G + 0.055) / 1.055, 2.4);
            else var_G = var_G / 12.92;
            if (var_B > 0.04045) var_B = Math.Pow((var_B + 0.055) / 1.055, 2.4);
            else var_B = var_B / 12.92;

            var_R = var_R * 100.0;
            var_G = var_G * 100.0;
            var_B = var_B * 100.0;

            X = var_R * 0.4124 + var_G * 0.3576 + var_B * 0.1805;
            Y = var_R * 0.2126 + var_G * 0.7152 + var_B * 0.0722;
            Z = var_R * 0.0193 + var_G * 0.1192 + var_B * 0.9505;

            X = X / ref_X;
            Y = Y / ref_Y;
            Z = Z / ref_Z;

            if (X > 0.008856) X = Math.Pow(X, (1.0 / 3.0));
            else X = (7.787 * X) + (16.0 / 116.0);
            if (Y > 0.008856) Y = Math.Pow(Y, (1.0 / 3.0));
            else Y = (7.787 * Y) + (16.0 / 116.0);
            if (Z > 0.008856) Z = Math.Pow(Z, (1.0 / 3.0));
            else Z = (7.787 * Z) + (16.0 / 116.0);

            CIE_L = (116.0 * Y) - 16.0;
            CIE_a = 500.0 * (X - Y);
            CIE_b = 200.0 * (Y - Z);

            Console.WriteLine(CIE_L + " " + CIE_a + " " + CIE_b);
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
        public Bitmap OutImage { get; private set; }
        public Resolution PixelArtResolution { get; private set; }
    }
}
