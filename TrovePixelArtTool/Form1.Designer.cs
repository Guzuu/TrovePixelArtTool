namespace TrovePixelArtTool
{
    partial class Form1
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxPixelArtPreview = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutputPixelArt = new System.Windows.Forms.PictureBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxInputSize = new System.Windows.Forms.TextBox();
            this.textBoxOutputSize = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonSaveOutput = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxBlockTypes = new System.Windows.Forms.GroupBox();
            this.checkBoxGlowing = new System.Windows.Forms.CheckBox();
            this.checkBoxGlass = new System.Windows.Forms.CheckBox();
            this.checkBoxMetalic = new System.Windows.Forms.CheckBox();
            this.checkBoxStandard = new System.Windows.Forms.CheckBox();
            this.buttonConvertColors = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPixelArtPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutputPixelArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBoxBlockTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOpenFile.Location = new System.Drawing.Point(134, 529);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(201, 62);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open Image";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxPixelArtPreview
            // 
            this.pictureBoxPixelArtPreview.Location = new System.Drawing.Point(56, 93);
            this.pictureBoxPixelArtPreview.MaximumSize = new System.Drawing.Size(400, 400);
            this.pictureBoxPixelArtPreview.Name = "pictureBoxPixelArtPreview";
            this.pictureBoxPixelArtPreview.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxPixelArtPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPixelArtPreview.TabIndex = 1;
            this.pictureBoxPixelArtPreview.TabStop = false;
            // 
            // pictureBoxOutputPixelArt
            // 
            this.pictureBoxOutputPixelArt.Location = new System.Drawing.Point(579, 93);
            this.pictureBoxOutputPixelArt.MaximumSize = new System.Drawing.Size(400, 400);
            this.pictureBoxOutputPixelArt.MinimumSize = new System.Drawing.Size(400, 400);
            this.pictureBoxOutputPixelArt.Name = "pictureBoxOutputPixelArt";
            this.pictureBoxOutputPixelArt.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxOutputPixelArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOutputPixelArt.TabIndex = 2;
            this.pictureBoxOutputPixelArt.TabStop = false;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInput.Location = new System.Drawing.Point(50, 43);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(157, 31);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "Input Image";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOutput.Location = new System.Drawing.Point(573, 43);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(196, 31);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output PixelArt";
            // 
            // textBoxInputSize
            // 
            this.textBoxInputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInputSize.Location = new System.Drawing.Point(341, 46);
            this.textBoxInputSize.Name = "textBoxInputSize";
            this.textBoxInputSize.ReadOnly = true;
            this.textBoxInputSize.Size = new System.Drawing.Size(115, 31);
            this.textBoxInputSize.TabIndex = 5;
            this.textBoxInputSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOutputSize
            // 
            this.textBoxOutputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOutputSize.Location = new System.Drawing.Point(864, 46);
            this.textBoxOutputSize.Name = "textBoxOutputSize";
            this.textBoxOutputSize.ReadOnly = true;
            this.textBoxOutputSize.Size = new System.Drawing.Size(115, 31);
            this.textBoxOutputSize.TabIndex = 6;
            this.textBoxOutputSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(495, 93);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 213);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonSaveOutput
            // 
            this.buttonSaveOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveOutput.Location = new System.Drawing.Point(637, 529);
            this.buttonSaveOutput.Name = "buttonSaveOutput";
            this.buttonSaveOutput.Size = new System.Drawing.Size(132, 62);
            this.buttonSaveOutput.TabIndex = 8;
            this.buttonSaveOutput.Text = "Save";
            this.buttonSaveOutput.UseVisualStyleBackColor = true;
            this.buttonSaveOutput.Click += new System.EventHandler(this.buttonSaveOutput_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image file|*.jpeg";
            // 
            // groupBoxBlockTypes
            // 
            this.groupBoxBlockTypes.Controls.Add(this.checkBoxGlowing);
            this.groupBoxBlockTypes.Controls.Add(this.checkBoxGlass);
            this.groupBoxBlockTypes.Controls.Add(this.checkBoxMetalic);
            this.groupBoxBlockTypes.Controls.Add(this.checkBoxStandard);
            this.groupBoxBlockTypes.Location = new System.Drawing.Point(462, 338);
            this.groupBoxBlockTypes.Name = "groupBoxBlockTypes";
            this.groupBoxBlockTypes.Size = new System.Drawing.Size(111, 155);
            this.groupBoxBlockTypes.TabIndex = 9;
            this.groupBoxBlockTypes.TabStop = false;
            this.groupBoxBlockTypes.Text = "Block Types";
            // 
            // checkBoxGlowing
            // 
            this.checkBoxGlowing.AutoSize = true;
            this.checkBoxGlowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxGlowing.Location = new System.Drawing.Point(6, 121);
            this.checkBoxGlowing.Name = "checkBoxGlowing";
            this.checkBoxGlowing.Size = new System.Drawing.Size(98, 28);
            this.checkBoxGlowing.TabIndex = 3;
            this.checkBoxGlowing.Text = "Glowing";
            this.checkBoxGlowing.UseVisualStyleBackColor = true;
            // 
            // checkBoxGlass
            // 
            this.checkBoxGlass.AutoSize = true;
            this.checkBoxGlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxGlass.Location = new System.Drawing.Point(6, 87);
            this.checkBoxGlass.Name = "checkBoxGlass";
            this.checkBoxGlass.Size = new System.Drawing.Size(75, 28);
            this.checkBoxGlass.TabIndex = 2;
            this.checkBoxGlass.Text = "Glass";
            this.checkBoxGlass.UseVisualStyleBackColor = true;
            // 
            // checkBoxMetalic
            // 
            this.checkBoxMetalic.AutoSize = true;
            this.checkBoxMetalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMetalic.Location = new System.Drawing.Point(6, 53);
            this.checkBoxMetalic.Name = "checkBoxMetalic";
            this.checkBoxMetalic.Size = new System.Drawing.Size(88, 28);
            this.checkBoxMetalic.TabIndex = 1;
            this.checkBoxMetalic.Text = "Metalic";
            this.checkBoxMetalic.UseVisualStyleBackColor = true;
            // 
            // checkBoxStandard
            // 
            this.checkBoxStandard.AutoSize = true;
            this.checkBoxStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxStandard.Location = new System.Drawing.Point(6, 19);
            this.checkBoxStandard.Name = "checkBoxStandard";
            this.checkBoxStandard.Size = new System.Drawing.Size(104, 28);
            this.checkBoxStandard.TabIndex = 0;
            this.checkBoxStandard.Text = "Standard";
            this.checkBoxStandard.UseVisualStyleBackColor = true;
            // 
            // buttonConvertColors
            // 
            this.buttonConvertColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConvertColors.Location = new System.Drawing.Point(405, 529);
            this.buttonConvertColors.Name = "buttonConvertColors";
            this.buttonConvertColors.Size = new System.Drawing.Size(201, 62);
            this.buttonConvertColors.TabIndex = 10;
            this.buttonConvertColors.Text = "Convert Colors";
            this.buttonConvertColors.UseVisualStyleBackColor = true;
            this.buttonConvertColors.Click += new System.EventHandler(this.buttonConvertColors_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.ColorName,
            this.ColorValue});
            this.dataGridView1.Location = new System.Drawing.Point(997, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 589);
            this.dataGridView1.TabIndex = 11;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.Width = 50;
            // 
            // ColorName
            // 
            this.ColorName.HeaderText = "Color Name";
            this.ColorName.Name = "ColorName";
            this.ColorName.Width = 90;
            // 
            // ColorValue
            // 
            this.ColorValue.HeaderText = "Color";
            this.ColorValue.Name = "ColorValue";
            this.ColorValue.Width = 40;
            // 
            // buttonGrid
            // 
            this.buttonGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGrid.Location = new System.Drawing.Point(830, 529);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.Size = new System.Drawing.Size(149, 62);
            this.buttonGrid.TabIndex = 12;
            this.buttonGrid.Text = "Grid";
            this.buttonGrid.UseVisualStyleBackColor = true;
            this.buttonGrid.Click += new System.EventHandler(this.buttonGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 613);
            this.Controls.Add(this.buttonGrid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonConvertColors);
            this.Controls.Add(this.groupBoxBlockTypes);
            this.Controls.Add(this.buttonSaveOutput);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBoxOutputSize);
            this.Controls.Add(this.textBoxInputSize);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.pictureBoxOutputPixelArt);
            this.Controls.Add(this.pictureBoxPixelArtPreview);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPixelArtPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutputPixelArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBoxBlockTypes.ResumeLayout(false);
            this.groupBoxBlockTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxPixelArtPreview;
        private System.Windows.Forms.PictureBox pictureBoxOutputPixelArt;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxInputSize;
        private System.Windows.Forms.TextBox textBoxOutputSize;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonSaveOutput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxBlockTypes;
        private System.Windows.Forms.CheckBox checkBoxGlowing;
        private System.Windows.Forms.CheckBox checkBoxGlass;
        private System.Windows.Forms.CheckBox checkBoxMetalic;
        private System.Windows.Forms.CheckBox checkBoxStandard;
        private System.Windows.Forms.Button buttonConvertColors;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorValue;
        private System.Windows.Forms.Button buttonGrid;
    }
}

