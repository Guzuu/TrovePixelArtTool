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
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1Layout.Visible)
            {
                dataGridView1Layout.Hide();
                buttonSaveLayout.Hide();
                button1.Text = "Show GUI";
            }
            else
            {
                dataGridView1Layout.Show();
                dataGridView1Layout.AutoResizeColumns();
                buttonSaveLayout.Show();
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
            
            saveFileDialog1.FileName += "PixelArtLayout" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            saveFileDialog1.ShowDialog();
            Console.WriteLine(saveFileDialog1.FileName);
            Layout.Save(saveFileDialog1.FileName);
            Layout.Dispose();
            dataGridViewLayout.Dock = DockStyle.Fill;
            dataGridViewLayout.Show();
        }
    }
}
