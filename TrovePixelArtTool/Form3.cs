using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrovePixelArtTool
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            initializeColors(b1.Standard, "Standard");
            initializeColors(b1.Metalic, "Metalic");
            initializeColors(b1.Glass, "Glass");
            initializeColors(b1.Glowing, "Glowing");
            dataGridViewColors.ClearSelection();
            dataGridViewPalette.ClearSelection();
        }

        private void initializeColors(List<Blocks.Block> blocks, string name)
        {
            foreach (Blocks.Block block in blocks)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewColors.Rows[0].Clone();
                row.Cells[0].Style.BackColor = Color.FromArgb(block.R, block.G, block.B);
                row.Cells[1].Value = block.Color;
                row.Cells[2].Value = name;
                dataGridViewColors.Rows.Add(row);
                All.Add(block);
            }
        }

        public List<Blocks.Block> Custom = new List<Blocks.Block>();
        List<Blocks.Block> All = new List<Blocks.Block>();
        Blocks b1 = new Blocks();

        private void dataGridViewColors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewColors.Rows[e.RowIndex].Cells[1].Value == null) throw new Exception();

                DataGridViewRow row = (DataGridViewRow)dataGridViewPalette.Rows[0].Clone();

                row.Cells[0].Style.BackColor = dataGridViewColors.Rows[e.RowIndex].Cells[0].Style.BackColor;
                row.Cells[1].Value = dataGridViewColors.Rows[e.RowIndex].Cells[1].Value;
                row.Cells[2].Value = dataGridViewColors.Rows[e.RowIndex].Cells[2].Value;

                dataGridViewPalette.Rows.Insert(0, row);
                dataGridViewColors.Rows.RemoveAt(e.RowIndex);
                Custom.Insert(0, All[e.RowIndex]);
                All.RemoveAt(e.RowIndex);
                dataGridViewColors.ClearSelection();
                dataGridViewPalette.ClearSelection();
            }
            catch(Exception)
            {
                return;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Custom.Clear();
            All.Clear();
            dataGridViewColors.Rows.Clear();
            dataGridViewPalette.Rows.Clear();

            initializeColors(b1.Standard, "Standard");
            initializeColors(b1.Metalic, "Metalic");
            initializeColors(b1.Glass, "Glass");
            initializeColors(b1.Glowing, "Glowing");
        }

        private void dataGridViewPalette_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewPalette.Rows[e.RowIndex].Cells[1].Value == null) throw new Exception();

                DataGridViewRow row = (DataGridViewRow)dataGridViewColors.Rows[0].Clone();

                row.Cells[0].Style.BackColor = dataGridViewPalette.Rows[e.RowIndex].Cells[0].Style.BackColor;
                row.Cells[1].Value = dataGridViewPalette.Rows[e.RowIndex].Cells[1].Value;
                row.Cells[2].Value = dataGridViewPalette.Rows[e.RowIndex].Cells[2].Value;

                dataGridViewColors.Rows.Insert(0, row);
                dataGridViewPalette.Rows.RemoveAt(e.RowIndex);
                All.Insert(0, Custom[e.RowIndex]);
                Custom.RemoveAt(e.RowIndex);
                dataGridViewColors.ClearSelection();
                dataGridViewPalette.ClearSelection();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.form1.checkBoxCustom.Checked = false;
            e.Cancel = true;
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPalette.Rows.Count == 1)
            {
                MessageBox.Show("Palette is empty");
            }
            else
            {
                this.Hide();
                Program.form1.checkBoxCustom.Checked = true;
            }
        }
    }
}
