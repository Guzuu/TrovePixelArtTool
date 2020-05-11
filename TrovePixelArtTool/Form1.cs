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
            textBoxOutputSize.Text = px1.OutImage.Width.ToString() + "x" + px1.OutImage.Height.ToString();
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
            Bitmap OutputRecolored = new Bitmap(px1.OutImage.Width, px1.OutImage.Height);
            double minDelta=1000, newDelta;
            PixelArt.CIELab TempCL;
            string blockName = "";
            Blocks.Block tempBlock = new Blocks.Block();


            for (int y = 0; y < px1.OutImage.Height; y++)
            {
                for (int x = 0; x < px1.OutImage.Width; x++)
                {
                    TempCL = px1.RGBtoLAB(x, y);

                    if(checkBoxStandard.Checked) foreach (Blocks.Block block in b1.Standard)
                    {
                        newDelta = px1.DeltaE(TempCL, block.CL);
                        if (newDelta < minDelta)
                        {
                            minDelta = newDelta;
                            blockName = block.Color;
                        }
                    }

                    if (checkBoxMetalic.Checked) foreach (Blocks.Block block in b1.Metalic)
                        {
                            newDelta = px1.DeltaE(TempCL, block.CL);
                            if (newDelta < minDelta)
                            {
                                minDelta = newDelta;
                                blockName = block.Color;
                            }
                        }

                    if (checkBoxGlass.Checked) foreach (Blocks.Block block in b1.Glass)
                        {
                            newDelta = px1.DeltaE(TempCL, block.CL);
                            if (newDelta < minDelta)
                            {
                                minDelta = newDelta;
                                blockName = block.Color;
                            }
                        }

                    if (checkBoxGlowing.Checked) foreach (Blocks.Block block in b1.Glowing)
                        {
                            newDelta = px1.DeltaE(TempCL, block.CL);
                            if (newDelta < minDelta)
                            {
                                minDelta = newDelta;
                                blockName = block.Color;
                            }
                        }
                    if (b1.Standard.Any(block => block.Color == blockName)) tempBlock = b1.Standard.Find(block => block.Color.Contains(blockName));
                    if (b1.Metalic.Any(block => block.Color == blockName)) tempBlock = b1.Metalic.Find(block => block.Color.Contains(blockName));
                    if (b1.Glass.Any(block => block.Color == blockName)) tempBlock = b1.Glass.Find(block => block.Color.Contains(blockName));
                    if (b1.Glowing.Any(block => block.Color == blockName)) tempBlock = b1.Glowing.Find(block => block.Color.Contains(blockName));

                    OutputRecolored.SetPixel(x, y, Color.FromArgb(tempBlock.R, tempBlock.G, tempBlock.B));
                    minDelta = 1000;
                }
            }
            pictureBoxOutputPixelArt.Image = OutputRecolored;
        }
    }
}
