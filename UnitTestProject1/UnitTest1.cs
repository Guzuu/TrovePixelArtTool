using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrovePixelArtTool;
using System.Drawing;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBlocks()
        {
            //Arrange
            Blocks.Block b1 = new Blocks.Block("Primal Red", 155, 039, 039);
            Blocks.Block b2 = new Blocks.Block("Verdant Green", 083, 175, 020);

            //Act
            Blocks blocks = new Blocks();

            //Assert
            Assert.AreEqual(b1.Color, blocks.Standard[0].Color);
            Assert.AreEqual(b2.Color, blocks.Standard[blocks.Standard.Count - 1].Color);
        }

        [TestMethod]
        public void TestPixelArtScaling()
        {
            //Arrange
            Bitmap b1 = new Bitmap(4, 4);
            PixelArt px = new PixelArt(b1);

            //Act
            px.ScaleImage(50);

            //Assert
            Assert.AreEqual(2, px.OutImage.Width);
            Assert.AreEqual(2, px.OutImage.Height);

            //Act
            px.ScaleImage(100);

            //Assert
            Assert.AreEqual(4, px.OutImage.Width);
            Assert.AreEqual(4, px.OutImage.Height);
        }

        [TestMethod]
        public void TestPixelArtRGBtoCIELab()
        {
            //Arrange
            Bitmap b1 = new Bitmap(1, 1);
            b1.SetPixel(0, 0, Color.FromArgb(50, 50, 50));
            PixelArt px = new PixelArt(b1);
            PixelArt.CIELab c1, c2, c3;
            c3.L = 20.78777714137035;
            c3.a = 0.0016682939665280117;
            c3.b = -0.003300810110029584;
            px.ScaleImage(100);

            //Act
            c1 = px.RGBtoLAB(0, 0);
            c2 = PixelArt.RGBtoLAB(50, 50, 50);

            //Assert
            Assert.AreEqual(c1, c2);
            Assert.AreEqual(c2, c3);
        }

        [TestMethod]
        public void TestPixelArtDelta()
        {
            //Arrange
            Bitmap b1 = new Bitmap(1, 1);
            b1.SetPixel(0, 0, Color.FromArgb(50, 50, 50));
            PixelArt px = new PixelArt(b1);
            PixelArt.CIELab c1, c2;
            px.ScaleImage(100);
            c1 = px.RGBtoLAB(0, 0);
            c2 = PixelArt.RGBtoLAB(50, 50, 50);
            double deltaE;

            //Act
            deltaE = px.DeltaE(c1, c2);

            //Assert
            Assert.AreEqual(0, deltaE);
        }

        [TestMethod]
        public void TestPixelArtCieLab2Hue()
        {
            //Arrange
            Bitmap b1 = new Bitmap(1, 1);
            PixelArt px = new PixelArt(b1);
            double Hue;

            //Act
            Hue = px.CieLab2Hue(0, 0);

            //Assert
            Assert.AreEqual(0, Hue);

            //Act
            Hue = px.CieLab2Hue(1, 1);

            //Assert
            Assert.AreEqual(px.rad2deg(Math.Atan(1)), Hue);
        }

        [TestMethod]
        public void TestPixelArtrad2deg()
        {
            //Arrange
            Bitmap b1 = new Bitmap(1, 1);
            PixelArt px = new PixelArt(b1);
            double rad = 123;
            double result;
            double exdeg = 7047.38088;

            //Act
            result = px.rad2deg(rad);

            //Assert
            Assert.AreEqual(exdeg, result, 0.00001);
        }

        [TestMethod]
        public void TestPixelArtdeg2rad()
        {
            //Arrange
            Bitmap b1 = new Bitmap(1, 1);
            PixelArt px = new PixelArt(b1);
            double deg = 123;
            double result;
            double exrad = 2.14675498;

            //Act
            result = px.deg2rad(deg);

            //Assert
            Assert.AreEqual(exrad, result, 0.00001);
        }
    }
}
