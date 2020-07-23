using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrovePixelArtTool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridLayout_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 10;
            e.Column.Width = 1;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form1.Show();
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1Layout.Visible)
            {
                Program.form1.Hide();
                dataGridView1Layout.Hide();
                button1.Text = "Show GUI";
            }
            else
            {
                Program.form1.Show();
                dataGridView1Layout.Show();
                dataGridView1Layout.AutoResizeColumns();
                button1.Text = "Hide GUI";
            }
        }

        private void buttonSaveLayout_Click(object sender, EventArgs e)
        {
            int DGVw = dataGridViewLayout[0, 0].Size.Width * dataGridViewLayout.ColumnCount, DGVh = dataGridViewLayout[0, 0].Size.Height * dataGridViewLayout.RowCount;
            Bitmap Layout = new Bitmap(DGVw, DGVh);

            dataGridViewLayout.Hide();
            dataGridViewLayout.Dock = DockStyle.None;
            dataGridViewLayout.Width = DGVw+3;
            dataGridViewLayout.Height = DGVh+3;
            dataGridViewLayout.DrawToBitmap(Layout, new Rectangle(0,0, DGVw, DGVh));
            
            saveFileDialog1.FileName = "PixelArtLayout" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            saveFileDialog1.ShowDialog();
            Console.WriteLine(saveFileDialog1.FileName);
            Layout.Save(saveFileDialog1.FileName);
            Layout.Dispose();
            dataGridViewLayout.Dock = DockStyle.Fill;
            dataGridViewLayout.Show();
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow y in dataGridViewLayout.Rows) y.Height += 2;
            foreach (DataGridViewColumn x in dataGridViewLayout.Columns) x.Width += 2;
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow y in dataGridViewLayout.Rows) y.Height -= 2;
            foreach (DataGridViewColumn x in dataGridViewLayout.Columns) x.Width -= 2;
        }

        private void buttonHideIDs_Click(object sender, EventArgs e)
        {
            if(buttonHideIDs.Text == "Hide IDs")
            {
                for (int y = 0; y < dataGridViewLayout.RowCount; y++)
                {
                    for (int x = 0; x < dataGridViewLayout.ColumnCount; x++)
                    {
                        if (Program.form1.DGVPixelArt[x, y].Color == null) continue;
                        else dataGridViewLayout[x, y].Value = "";
                    }
                }
                buttonHideIDs.Text = "Show IDs";
            }
            else
            {
                for (int y = 0; y < dataGridViewLayout.RowCount; y++)
                {
                    for (int x = 0; x < dataGridViewLayout.ColumnCount; x++)
                    {
                        if (Program.form1.DGVPixelArt[x, y].Color == null) continue;
                        else dataGridViewLayout[x, y].Value = Program.form1.DGVPixelArt[x, y].ID;
                    }
                }
                buttonHideIDs.Text = "Hide IDs";
            }
            
        }
    }
}
