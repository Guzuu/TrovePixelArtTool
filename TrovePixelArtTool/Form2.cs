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
                button1.Text = "Show GUI";
            }
            else
            {
                dataGridView1Layout.Show();
                button1.Text = "Hide GUI";
            }
        }
    }
}
