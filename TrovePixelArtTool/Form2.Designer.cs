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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonS3 = new System.Windows.Forms.RadioButton();
            this.radioButtonS2 = new System.Windows.Forms.RadioButton();
            this.labelZoom = new System.Windows.Forms.Label();
            this.radioButtonS1 = new System.Windows.Forms.RadioButton();
            this.buttonHideIDs = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Layout)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLayout
            // 
            this.dataGridViewLayout.AllowUserToResizeColumns = false;
            this.dataGridViewLayout.AllowUserToResizeRows = false;
            this.dataGridViewLayout.ColumnHeadersHeight = 100;
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
            this.dataGridViewLayout.Name = "dataGridViewLayout";
            this.dataGridViewLayout.ReadOnly = true;
            this.dataGridViewLayout.RowHeadersVisible = false;
            this.dataGridViewLayout.RowHeadersWidth = 5;
            this.dataGridViewLayout.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLayout.RowTemplate.Height = 26;
            this.dataGridViewLayout.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewLayout.Size = new System.Drawing.Size(1110, 579);
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
            this.dataGridView1Layout.Location = new System.Drawing.Point(1110, 0);
            this.dataGridView1Layout.Name = "dataGridView1Layout";
            this.dataGridView1Layout.ReadOnly = true;
            this.dataGridView1Layout.RowHeadersVisible = false;
            this.dataGridView1Layout.Size = new System.Drawing.Size(174, 611);
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
            this.ColorName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hide GUI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSaveLayout
            // 
            this.buttonSaveLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveLayout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveLayout.Enabled = false;
            this.buttonSaveLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveLayout.Location = new System.Drawing.Point(112, 0);
            this.buttonSaveLayout.Name = "buttonSaveLayout";
            this.buttonSaveLayout.Size = new System.Drawing.Size(137, 32);
            this.buttonSaveLayout.TabIndex = 20;
            this.buttonSaveLayout.Text = "Save Layout";
            this.buttonSaveLayout.UseVisualStyleBackColor = false;
            this.buttonSaveLayout.Click += new System.EventHandler(this.buttonSaveLayout_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image file|*.jpeg";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonS3);
            this.panel1.Controls.Add(this.radioButtonS2);
            this.panel1.Controls.Add(this.labelZoom);
            this.panel1.Controls.Add(this.radioButtonS1);
            this.panel1.Controls.Add(this.buttonHideIDs);
            this.panel1.Controls.Add(this.buttonZoomOut);
            this.panel1.Controls.Add(this.buttonZoomIn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonSaveLayout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 32);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(606, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Style:";
            // 
            // radioButtonS3
            // 
            this.radioButtonS3.AutoSize = true;
            this.radioButtonS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonS3.Location = new System.Drawing.Point(805, 5);
            this.radioButtonS3.Name = "radioButtonS3";
            this.radioButtonS3.Size = new System.Drawing.Size(82, 24);
            this.radioButtonS3.TabIndex = 2;
            this.radioButtonS3.Text = "Sunken";
            this.radioButtonS3.UseVisualStyleBackColor = true;
            this.radioButtonS3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonS2
            // 
            this.radioButtonS2.AutoSize = true;
            this.radioButtonS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonS2.Location = new System.Drawing.Point(731, 5);
            this.radioButtonS2.Name = "radioButtonS2";
            this.radioButtonS2.Size = new System.Drawing.Size(77, 24);
            this.radioButtonS2.TabIndex = 1;
            this.radioButtonS2.Text = "Raised";
            this.radioButtonS2.UseVisualStyleBackColor = true;
            this.radioButtonS2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZoom.Location = new System.Drawing.Point(478, 7);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(54, 20);
            this.labelZoom.TabIndex = 24;
            this.labelZoom.Text = "Zoom";
            // 
            // radioButtonS1
            // 
            this.radioButtonS1.AutoSize = true;
            this.radioButtonS1.Checked = true;
            this.radioButtonS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonS1.Location = new System.Drawing.Point(662, 5);
            this.radioButtonS1.Name = "radioButtonS1";
            this.radioButtonS1.Size = new System.Drawing.Size(71, 24);
            this.radioButtonS1.TabIndex = 0;
            this.radioButtonS1.TabStop = true;
            this.radioButtonS1.Text = "Single";
            this.radioButtonS1.UseVisualStyleBackColor = true;
            this.radioButtonS1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonHideIDs
            // 
            this.buttonHideIDs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHideIDs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHideIDs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHideIDs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHideIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHideIDs.Location = new System.Drawing.Point(255, 0);
            this.buttonHideIDs.Name = "buttonHideIDs";
            this.buttonHideIDs.Size = new System.Drawing.Size(106, 32);
            this.buttonHideIDs.TabIndex = 23;
            this.buttonHideIDs.Text = "Hide IDs";
            this.buttonHideIDs.UseVisualStyleBackColor = false;
            this.buttonHideIDs.Click += new System.EventHandler(this.buttonHideIDs_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZoomOut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonZoomOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZoomOut.Location = new System.Drawing.Point(434, 0);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(38, 32);
            this.buttonZoomOut.TabIndex = 22;
            this.buttonZoomOut.Text = "-";
            this.buttonZoomOut.UseVisualStyleBackColor = false;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZoomIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonZoomIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZoomIn.Location = new System.Drawing.Point(390, 0);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(38, 32);
            this.buttonZoomIn.TabIndex = 21;
            this.buttonZoomIn.Text = "+";
            this.buttonZoomIn.UseVisualStyleBackColor = false;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.dataGridViewLayout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1Layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "PixelArtTool Block Layout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Layout)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewLayout;
        public System.Windows.Forms.DataGridView dataGridView1Layout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Button buttonSaveLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonHideIDs;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonS3;
        private System.Windows.Forms.RadioButton radioButtonS2;
        private System.Windows.Forms.RadioButton radioButtonS1;
    }
}