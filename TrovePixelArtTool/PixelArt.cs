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

            OutImage = OutputImage;
            return OutputImage;
        }

        public CIELab RGBtoLAB(int x, int y)
        {
            double var_R, var_G, var_B, X, Y, Z, ref_X = 95.047, ref_Y= 100.000, ref_Z = 108.883; //reference D65 2*
            CIELab c1;

            var_R = (OutImage.GetPixel(x, y).R / 255.0);
            var_G = (OutImage.GetPixel(x, y).G / 255.0);
            var_B = (OutImage.GetPixel(x, y).B / 255.0);

            if (var_R > 0.04045) var_R = Math.Pow((var_R + 0.055) / 1.055, 2.4);
            else var_R /= 12.92;
            if (var_G > 0.04045) var_G = Math.Pow((var_G + 0.055) / 1.055, 2.4);
            else var_G /= 12.92;
            if (var_B > 0.04045) var_B = Math.Pow((var_B + 0.055) / 1.055, 2.4);
            else var_B /= 12.92;

            var_R *= 100.0;
            var_G *= 100.0;
            var_B *= 100.0;

            X = var_R * 0.4124 + var_G * 0.3576 + var_B * 0.1805;
            Y = var_R * 0.2126 + var_G * 0.7152 + var_B * 0.0722;
            Z = var_R * 0.0193 + var_G * 0.1192 + var_B * 0.9505;

            X /= ref_X;
            Y /= ref_Y;
            Z /= ref_Z;

            if (X > 0.008856) X = Math.Pow(X, (1.0 / 3.0));
            else X = (7.787 * X) + (16.0 / 116.0);
            if (Y > 0.008856) Y = Math.Pow(Y, (1.0 / 3.0));
            else Y = (7.787 * Y) + (16.0 / 116.0);
            if (Z > 0.008856) Z = Math.Pow(Z, (1.0 / 3.0));
            else Z = (7.787 * Z) + (16.0 / 116.0);

            c1.L = (116.0 * Y) - 16.0;
            c1.a = 500.0 * (X - Y);
            c1.b = 200.0 * (Y - Z);

            return c1;
        }

        static public CIELab RGBtoLAB(byte R, byte G, byte B)
        {
            double var_R, var_G, var_B, X, Y, Z, ref_X = 95.047, ref_Y = 100.000, ref_Z = 108.883; //reference D65 2*
            CIELab c1;

            var_R = (R / 255.0);
            var_G = (G / 255.0);
            var_B = (B / 255.0);

            if (var_R > 0.04045) var_R = Math.Pow((var_R + 0.055) / 1.055, 2.4);
            else var_R /= 12.92;
            if (var_G > 0.04045) var_G = Math.Pow((var_G + 0.055) / 1.055, 2.4);
            else var_G /= 12.92;
            if (var_B > 0.04045) var_B = Math.Pow((var_B + 0.055) / 1.055, 2.4);
            else var_B /= 12.92;

            var_R *= 100.0;
            var_G *= 100.0;
            var_B *= 100.0;

            X = var_R * 0.4124 + var_G * 0.3576 + var_B * 0.1805;
            Y = var_R * 0.2126 + var_G * 0.7152 + var_B * 0.0722;
            Z = var_R * 0.0193 + var_G * 0.1192 + var_B * 0.9505;

            X /= ref_X;
            Y /= ref_Y;
            Z /= ref_Z;

            if (X > 0.008856) X = Math.Pow(X, (1.0 / 3.0));
            else X = (7.787 * X) + (16.0 / 116.0);
            if (Y > 0.008856) Y = Math.Pow(Y, (1.0 / 3.0));
            else Y = (7.787 * Y) + (16.0 / 116.0);
            if (Z > 0.008856) Z = Math.Pow(Z, (1.0 / 3.0));
            else Z = (7.787 * Z) + (16.0 / 116.0);

            c1.L = (116.0 * Y) - 16.0;
            c1.a = 500.0 * (X - Y);
            c1.b = 200.0 * (Y - Z);

            return c1;
        }

        public double DeltaE(CIELab c1, CIELab c2)
        {
            double xC1, xC2, xCX, xGX, xNN, xH1, xH2, xDL, xDC, xDH, xLX, xCY, xHX, xTX, xPH, xRC, xSL, xSC, xSH, xRT, WHT_L=1, WHT_C=1, WHT_H=1;

            xC1 = Math.Sqrt(c1.a * c1.a + c1.b * c1.b);
            xC2 = Math.Sqrt(c2.a * c2.a + c2.b * c2.b);
            xCX = (xC1 + xC2) / 2;
            xGX = 0.5 * (1 - Math.Sqrt(Math.Pow(xCX, 7) / (Math.Pow(xCX, 7) + Math.Pow(25, 7))));
            xNN = (1 + xGX) * c1.a;
            xC1 = Math.Sqrt(xNN * xNN + c1.b * c1.b);
            xH1 = CieLab2Hue(xNN, c1.b);
            xNN = (1 + xGX) * c2.a;
            xC2 = Math.Sqrt(xNN * xNN + c2.b * c2.b);
            xH2 = CieLab2Hue(xNN, c2.b);
            xDL = c2.L - c1.L;
            xDC = xC2 - xC1;
            if ((xC1 * xC2) == 0) {
                xDH = 0;
            }
            else {
                xNN = Math.Round(xH2 - xH1, 12);
                if (Math.Abs(xNN) <= 180) {
                    xDH = xH2 - xH1;
                }
                else {
                    if (xNN > 180) xDH = xH2 - xH1 - 360;
                    else xDH = xH2 - xH1 + 360;
                }
            }

            xDH = 2 * Math.Sqrt(xC1 * xC2) * Math.Sin(deg2rad(xDH / 2));
            xLX = (c1.L + c2.L) / 2;
            xCY = (xC1 + xC2) / 2;
            if ((xC1 * xC2) == 0) {
                xHX = xH1 + xH2;
            }
            else {
                xNN = Math.Abs(Math.Round(xH1 - xH2, 12));
                if (xNN > 180) {
                    if ((xH2 + xH1) < 360) xHX = xH1 + xH2 + 360;
                    else xHX = xH1 + xH2 - 360;
                }
                else {
                    xHX = xH1 + xH2;
                }
                xHX /= 2;
            }
            xTX = 1 - 0.17 * Math.Cos(deg2rad(xHX - 30)) + 0.24
                           * Math.Cos(deg2rad(2 * xHX)) + 0.32
                           * Math.Cos(deg2rad(3 * xHX + 6)) - 0.20
                           * Math.Cos(deg2rad(4 * xHX - 63));
            xPH = 30 * Math.Exp(-((xHX - 275) / 25) * ((xHX - 275) / 25));
            xRC = 2 * Math.Sqrt(Math.Pow(xCY, 7) / (Math.Pow(xCY, 7) + Math.Pow(25, 7)));
            xSL = 1 + ((0.015 * ((xLX - 50) * (xLX - 50)))
                     / Math.Sqrt(20 + ((xLX - 50) * (xLX - 50))));

            xSC = 1 + 0.045 * xCY;
            xSH = 1 + 0.015 * xCY * xTX;
            xRT = -1 * Math.Sin(deg2rad(2 * xPH)) * xRC;
            xDL /= (WHT_L * xSL);
            xDC /= (WHT_C * xSC);
            xDH /= (WHT_H * xSH);

            return Math.Sqrt(Math.Pow(xDL, 2) + Math.Pow(xDC, 2) + Math.Pow(xDH, 2) + xRT * xDC * xDH);
        }

        double CieLab2Hue(double a, double b)          //Function returns CIE-H° value
        {
            double bias = 0;
            if (a >= 0 && b == 0) return 0;
            if (a < 0 && b == 0) return 180;
            if (a == 0 && b > 0) return 90;
            if (a == 0 && b < 0) return 270;
            if (a > 0 && b > 0) bias = 0;
            if (a < 0) bias = 180;
            if (a > 0 && b < 0) bias = 360;
            return rad2deg(Math.Atan(b / a)) + bias;
        }

        double deg2rad(double deg)
        {
            return deg * Math.PI / 180;
        }

        double rad2deg(double rad)
        {
            return (180 / Math.PI) * rad;
        }

        public struct CIELab 
        {
            public double L;
            public double a;
            public double b;
        }

        public Bitmap srcImage { get; private set; }
        public Bitmap OutImage { get; private set; }
    }
}
