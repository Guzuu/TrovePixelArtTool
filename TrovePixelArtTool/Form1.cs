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
            openFileDialog1.FileName = "Open Image File";
            openFileDialog1.ShowDialog();
            px1 = new PixelArt(new Bitmap(openFileDialog1.FileName, true));

            pictureBoxPixelArtPreview.Image = px1.srcImage;
            pictureBoxOutputPixelArt.Image = px1.srcImage;
            trackBar1.Value = 100;
            trackBar1.Enabled = true;

            textBoxInputSize.Text = px1.srcImage.Width.ToString()+"x"+ px1.srcImage.Height.ToString();
            textBoxOutputSize.Text = textBoxInputSize.Text;


            



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

        private void buttonConvertColors_Click(object sender, EventArgs e)
        {
            Blocks b1 = new Blocks();
            Bitmap OutputRecolored = new Bitmap(px1.PixelArtResolution.X, px1.PixelArtResolution.Y);
            //Color newColor;

            /*if (checkBoxStandard.Checked)
            {
                b1.InitializeStandard();
            }

            if (checkBoxMetalic.Checked)
            {
                b1.InitializeMetalic();
            }

            if (checkBoxGlass.Checked)
            {
                b1.InitializeGlass();
            }

            if (checkBoxGlowing.Checked)
            {
                b1.InitializeGlowing();
            }*/


            for (int y = 0; y < px1.PixelArtResolution.Y; y++)
            {
                for (int x = 0; x < px1.PixelArtResolution.X; x++)
                {
                    px1.RGBtoLAB(x, y);
                    //OutputRecolored.SetPixel(x, y, newColor);
                }
                Console.Write("\n");
            }
        }
    }
}
