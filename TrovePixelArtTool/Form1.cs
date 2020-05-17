using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TrovePixelArtTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form2 f2 = new Form2();
        public PixelArt px1;

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Open Image File";
            openFileDialog1.ShowDialog();
            try
            {
                px1 = new PixelArt(new Bitmap(openFileDialog1.FileName, true));
            }
            catch (ArgumentException)
            {
                return;
            }
            pictureBoxPixelArtPreview.Image = px1.SrcImage;
            pictureBoxOutputPixelArt.Image = px1.SrcImage;
            trackBar1.Value = 100;
            trackBar1.Enabled = true;

            textBoxInputSize.Text = px1.SrcImage.Width.ToString()+"x"+ px1.SrcImage.Height.ToString();
            textBoxOutputSize.Text = textBoxInputSize.Text;
            trackBar1_Scroll(sender, e);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBoxOutputPixelArt.Image = px1.ScaleImage(trackBar1.Value);
            textBoxOutputSize.Text = px1.OutImage.Width.ToString() + "x" + px1.OutImage.Height.ToString();
            if (px1.OutImage.Width * px1.OutImage.Height > 600000) label5warning.Visible = true;
            else label5warning.Visible = false;
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
            Blocks.Block tempBlock = new Blocks.Block();
            Dictionary<Blocks.Block, int> keyValuePairs = new Dictionary<Blocks.Block, int>();
            Color c1 = Color.Black;
            Color c2 = px1.OutImage.GetPixel(0, 0);

            progressBarGenerate.Maximum = px1.OutImage.Width * px1.OutImage.Height;

            keyValuePairs.Clear();
            dataGridView1.Rows.Clear();
            f2.dataGridViewLayout.Rows.Clear();

            f2.dataGridViewLayout.ColumnCount = px1.OutImage.Width;
            f2.dataGridViewLayout.RowCount = px1.OutImage.Height;

            for (int y = 0; y < px1.OutImage.Height; y++)
            {
                for (int x = 0; x < px1.OutImage.Width; x++)
                {
                    if (c2 == px1.OutImage.GetPixel(x, y) && x != 0 && y != 0)
                    {
                        keyValuePairs[tempBlock]++;
                    }
                    else
                    {
                        TempCL = px1.RGBtoLAB(x, y);

                        if (checkBoxStandard.Checked) foreach (Blocks.Block block in b1.Standard)
                            {
                                newDelta = px1.DeltaE(TempCL, block.CL);
                                if (newDelta < minDelta)
                                {
                                    minDelta = newDelta;
                                    tempBlock = block;
                                }
                            }

                        if (checkBoxMetalic.Checked) foreach (Blocks.Block block in b1.Metalic)
                            {
                                newDelta = px1.DeltaE(TempCL, block.CL);
                                if (newDelta < minDelta)
                                {
                                    minDelta = newDelta;
                                    tempBlock = block;
                                }
                            }

                        if (checkBoxGlass.Checked) foreach (Blocks.Block block in b1.Glass)
                            {
                                newDelta = px1.DeltaE(TempCL, block.CL);
                                if (newDelta < minDelta)
                                {
                                    minDelta = newDelta;
                                    tempBlock = block;
                                }
                            }

                        if (checkBoxGlowing.Checked) foreach (Blocks.Block block in b1.Glowing)
                            {
                                newDelta = px1.DeltaE(TempCL, block.CL);
                                if (newDelta < minDelta)
                                {
                                    minDelta = newDelta;
                                    tempBlock = block;
                                }
                            }

                        if (!keyValuePairs.ContainsKey(tempBlock)) keyValuePairs.Add(tempBlock, 1);
                        else keyValuePairs[tempBlock]++;

                        c1 = Color.FromArgb(tempBlock.R, tempBlock.G, tempBlock.B);
                        c2 = px1.OutImage.GetPixel(x, y);
                    }

                    OutputRecolored.SetPixel(x, y, c1);
                    f2.dataGridViewLayout[x, y].Style.BackColor = c1;
                    if (tempBlock.CL.L < 40) f2.dataGridViewLayout[x, y].Style.ForeColor = Color.White;
                    f2.dataGridViewLayout[x, y].Value = tempBlock.ID;

                    minDelta = 1000;
                    progressBarGenerate.PerformStep();
                }
            }
            pictureBoxOutputPixelArt.Image = OutputRecolored;
            progressBarGenerate.Value = 0;
            progressBarGenerate.Maximum = keyValuePairs.Count;
            foreach (KeyValuePair<Blocks.Block, int> pair in keyValuePairs)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                DataGridViewRow row2 = (DataGridViewRow)f2.dataGridView1Layout.Rows[0].Clone();
                c2 = Color.FromArgb(pair.Key.R, pair.Key.G, pair.Key.B);

                row.Cells[0].Value = pair.Key.ID;
                row.Cells[1].Value = pair.Value;
                row.Cells[2].Value = pair.Key.Color;
                row.Cells[3].Style.BackColor = c2;

                row2.Cells[0].Value = pair.Key.ID;
                row2.Cells[1].Value = pair.Key.Color;
                row2.Cells[2].Style.BackColor = c2;
                dataGridView1.Rows.Add(row);
                f2.dataGridView1Layout.Rows.Add(row2);

                progressBarGenerate.PerformStep();
            }
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
            f2.dataGridView1Layout.Sort(f2.dataGridView1Layout.Columns[0], ListSortDirection.Descending);
            f2.dataGridViewLayout.AutoResizeColumns();
            progressBarGenerate.Value = 0;
        }

        private void buttonGrid_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            f2.Dispose();
        }
    }
}
