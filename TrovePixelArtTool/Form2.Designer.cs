namespace TrovePixelArtTool
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridViewLayout = new System.Windows.Forms.DataGridView();
            this.dataGridView1Layout = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSaveLayout = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Layout)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLayout
            // 
            this.dataGridViewLayout.AllowUserToResizeColumns = false;
            this.dataGridViewLayout.AllowUserToResizeRows = false;
            this.dataGridViewLayout.ColumnHeadersHeight = 10;
            this.dataGridViewLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLayout.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLayout.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLayout.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLayout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 500);
            this.dataGridViewLayout.MultiSelect = false;
            this.dataGridViewLayout.Name = "dataGridViewLayout";
            this.dataGridViewLayout.ReadOnly = true;
            this.dataGridViewLayout.RowHeadersVisible = false;
            this.dataGridViewLayout.RowHeadersWidth = 5;
            this.dataGridViewLayout.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLayout.RowTemplate.Height = 26;
            this.dataGridViewLayout.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewLayout.Size = new System.Drawing.Size(626, 450);
            this.dataGridViewLayout.TabIndex = 0;
            this.dataGridViewLayout.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridLayout_ColumnAdded);
            // 
            // dataGridView1Layout
            // 
            this.dataGridView1Layout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Layout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColorName,
            this.ColorValue});
            this.dataGridView1Layout.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1Layout.Location = new System.Drawing.Point(626, 0);
            this.dataGridView1Layout.Name = "dataGridView1Layout";
            this.dataGridView1Layout.ReadOnly = true;
            this.dataGridView1Layout.RowHeadersVisible = false;
            this.dataGridView1Layout.Size = new System.Drawing.Size(174, 450);
            this.dataGridView1Layout.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // ColorName
            // 
            this.ColorName.HeaderText = "Color Name";
            this.ColorName.Name = "ColorName";
            this.ColorName.ReadOnly = true;
            this.ColorName.Width = 90;
            // 
            // ColorValue
            // 
            this.ColorValue.HeaderText = "Color";
            this.ColorValue.Name = "ColorValue";
            this.ColorValue.ReadOnly = true;
            this.ColorValue.Width = 50;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(0, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hide GUI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSaveLayout
            // 
            this.buttonSaveLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveLayout.Enabled = false;
            this.buttonSaveLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveLayout.Location = new System.Drawing.Point(654, 409);
            this.buttonSaveLayout.Name = "buttonSaveLayout";
            this.buttonSaveLayout.Size = new System.Drawing.Size(121, 32);
            this.buttonSaveLayout.TabIndex = 20;
            this.buttonSaveLayout.Text = "Save Layout";
            this.buttonSaveLayout.UseVisualStyleBackColor = true;
            this.buttonSaveLayout.Click += new System.EventHandler(this.buttonSaveLayout_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image file|*.jpeg";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveLayout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewLayout);
            this.Controls.Add(this.dataGridView1Layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "PixelArtTool Block Layout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Layout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewLayout;
        public System.Windows.Forms.DataGridView dataGridView1Layout;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Button buttonSaveLayout;
    }
}