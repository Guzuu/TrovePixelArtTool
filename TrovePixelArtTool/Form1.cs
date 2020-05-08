using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrovePixelArtTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PixelArt px1;

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            px1 = new PixelArt(new Bitmap(openFileDialog1.FileName, true));

            pictureBoxPixelArtPreview.Image = px1.srcImage;
            pictureBoxOutputPixelArt.Image = px1.srcImage;
            trackBar1.Value = 50;

            trackBar1.Enabled = true;

            textBoxInputSize.Text = px1.srcImage.Width.ToString()+"x"+ px1.srcImage.Height.ToString();

            // Loop through the images pixels
            /*for (int y = 0; y < img1.Height; y++)
            {
                for (int x = 0; x < img1.Width; x++)
                {
                    Console.Write(img1.GetPixel(x, y));
                }
                Console.Write("\n");
            }*/



        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBoxOutputPixelArt.Image = px1.ScaleImage(trackBar1.Value);
            textBoxOutputSize.Text = px1.PixelArtResolution.X.ToString() + "x" + px1.PixelArtResolution.Y.ToString();
        }

        private void buttonSaveOutput_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName += "PixelArt" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            saveFileDialog1.ShowDialog();
            Console.WriteLine(saveFileDialog1.FileName);
            pictureBoxOutputPixelArt.Image.Save(saveFileDialog1.FileName);
        }
    }
}
