using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TrovePixelArtTool
{
    public partial class Form1 : Form
    {

        BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        public Form2 f2 = new Form2();
        public PixelArt px1;
        Dictionary<Blocks.Block, int> keyValuePairs = new Dictionary<Blocks.Block, int>();
        public Blocks.Block[,] DGVPixelArt;

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork +=
                new DoWorkEventHandler(backgroundWorker1_DoWork);

            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            backgroundWorker1.ProgressChanged +=
                new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarGenerate.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                progressBarGenerate.Value = 0;
                trackBar1.Enabled = true;
                buttonSaveOutput.Enabled = true;
                return;
            }
            else
            {
                pictureBoxOutputPixelArt.Image = (Bitmap)e.Result;
                f2.dataGridViewLayout.ColumnCount = px1.OutImage.Width;
                f2.dataGridViewLayout.RowCount = px1.OutImage.Height;
                Blocks.Block tempBL;

                for (int y = 0; y < px1.OutImage.Height; y++)
                {
                    for (int x = 0; x < px1.OutImage.Width; x++)
                    {
                        tempBL = DGVPixelArt[x, y];
                        if (tempBL.Color == null)
                        {
                            f2.dataGridViewLayout[x, y].Style.BackColor = Color.White;
                            continue;
                        }
                        f2.dataGridViewLayout[x, y].Style.BackColor = Color.FromArgb(tempBL.R, tempBL.G, tempBL.B);
                        if (tempBL.CL.L < 40) f2.dataGridViewLayout[x, y].Style.ForeColor = Color.White;
                        f2.dataGridViewLayout[x, y].Value = tempBL.ID;

                        f2.dataGridViewLayout.Columns[x].Width = 30;
                    }
                    f2.dataGridViewLayout.Rows[y].Height = 30;
                }

                foreach (KeyValuePair<Blocks.Block, int> pair in keyValuePairs)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    DataGridViewRow row2 = (DataGridViewRow)f2.dataGridView1Layout.Rows[0].Clone();

                    Color c = Color.FromArgb(pair.Key.R, pair.Key.G, pair.Key.B);

                    row.Cells[0].Value = pair.Key.ID;
                    row.Cells[1].Value = pair.Value;
                    row.Cells[2].Value = pair.Key.Color;
                    row.Cells[3].Style.BackColor = c;

                    row2.Cells[0].Value = pair.Key.ID;
                    row2.Cells[1].Value = pair.Key.Color;
                    row2.Cells[2].Style.BackColor = c;
                    dataGridView1.Rows.Add(row);
                    f2.dataGridView1Layout.Rows.Add(row2);
                }

                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
                f2.dataGridView1Layout.Sort(f2.dataGridView1Layout.Columns[0], ListSortDirection.Ascending);
                progressBarGenerate.Value = 0;
                f2.buttonSaveLayout.Enabled = true;
                buttonSaveOutput.Enabled = true;
                trackBar1.Enabled = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;
            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the 
            // RunWorkerCompleted eventhandler.
            e.Result = ConvertColors(worker, e);
        }

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
            buttonConvertColors.Enabled = true;
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
            saveFileDialog1.FileName = "PixelArt" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            saveFileDialog1.ShowDialog();
            Console.WriteLine(saveFileDialog1.FileName);
            pictureBoxOutputPixelArt.Image.Save(saveFileDialog1.FileName);
        }

        private Bitmap ConvertColors(BackgroundWorker worker, DoWorkEventArgs e)
        {
            Blocks b1 = new Blocks();
            Bitmap OutputRecolored = new Bitmap(px1.OutImage.Width, px1.OutImage.Height);
            double minDelta = 1000, newDelta;
            PixelArt.CIELab TempCL;
            Blocks.Block tempBlock = new Blocks.Block();
            Color c1 = Color.Black;
            Color c2 = Color.Transparent;
            int PercentComplete=0, ValueMaximum = px1.OutImage.Width * px1.OutImage.Height, n = 0, HighestPercentReached = 0;

            keyValuePairs.Clear();

            for (int y = 0; y < px1.OutImage.Height; y++)
            {
                for (int x = 0; x < px1.OutImage.Width; x++)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return null;
                    }

                    if (px1.OutImage.GetPixel(x, y).ToArgb() == Color.Empty.ToArgb()) continue;
                    else if (c2 == px1.OutImage.GetPixel(x, y))
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

                        c1 = Color.FromArgb(tempBlock.A, tempBlock.R, tempBlock.G, tempBlock.B);
                        c2 = px1.OutImage.GetPixel(x, y);
                    }

                    OutputRecolored.SetPixel(x, y, c1);

                    minDelta = 1000;
                    n++;

                    DGVPixelArt[x, y] = tempBlock;

                    PercentComplete =(int)((float)n / (float)ValueMaximum * 100);
                    if(PercentComplete > HighestPercentReached)
                    {
                        HighestPercentReached = PercentComplete;
                        worker.ReportProgress(PercentComplete);
                    }
                }
            }

            return OutputRecolored;
        }

        private void buttonConvertColors_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                dataGridView1.Rows.Clear();
                f2.dataGridViewLayout.Rows.Clear();
                f2.dataGridView1Layout.Rows.Clear();
                trackBar1.Enabled = false;
                DGVPixelArt = new Blocks.Block[px1.OutImage.Width, px1.OutImage.Height];

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void buttonGrid_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            f2.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PixelArtTool v1.5 by Guzuu\nReport any issues by a discord DM:\nDizzy#5556 or 186104843478368256\nPage: https://github.com/Guzuu/TrovePixelArtTool");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }
    }
}
