using System.Threading.Tasks;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGrid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarGenerate = new System.Windows.Forms.ProgressBar();
            this.label5warning = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
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
            this.buttonOpenFile.Location = new System.Drawing.Point(22, 496);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(176, 62);
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
            this.pictureBoxPixelArtPreview.Location = new System.Drawing.Point(22, 77);
            this.pictureBoxPixelArtPreview.MaximumSize = new System.Drawing.Size(400, 400);
            this.pictureBoxPixelArtPreview.Name = "pictureBoxPixelArtPreview";
            this.pictureBoxPixelArtPreview.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxPixelArtPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPixelArtPreview.TabIndex = 1;
            this.pictureBoxPixelArtPreview.TabStop = false;
            // 
            // pictureBoxOutputPixelArt
            // 
            this.pictureBoxOutputPixelArt.Location = new System.Drawing.Point(591, 77);
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
            this.labelInput.Location = new System.Drawing.Point(16, 27);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(182, 31);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "Source Image";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOutput.Location = new System.Drawing.Point(585, 27);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(225, 31);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Pixel Art Preview ";
            // 
            // textBoxInputSize
            // 
            this.textBoxInputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInputSize.Location = new System.Drawing.Point(307, 30);
            this.textBoxInputSize.Name = "textBoxInputSize";
            this.textBoxInputSize.ReadOnly = true;
            this.textBoxInputSize.Size = new System.Drawing.Size(115, 31);
            this.textBoxInputSize.TabIndex = 5;
            this.textBoxInputSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOutputSize
            // 
            this.textBoxOutputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOutputSize.Location = new System.Drawing.Point(876, 30);
            this.textBoxOutputSize.Name = "textBoxOutputSize";
            this.textBoxOutputSize.ReadOnly = true;
            this.textBoxOutputSize.Size = new System.Drawing.Size(115, 31);
            this.textBoxOutputSize.TabIndex = 6;
            this.textBoxOutputSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(484, 77);
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
            this.buttonSaveOutput.Enabled = false;
            this.buttonSaveOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveOutput.Location = new System.Drawing.Point(751, 496);
            this.buttonSaveOutput.Name = "buttonSaveOutput";
            this.buttonSaveOutput.Size = new System.Drawing.Size(100, 62);
            this.buttonSaveOutput.TabIndex = 8;
            this.buttonSaveOutput.Text = "Save Preview";
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
            this.groupBoxBlockTypes.Location = new System.Drawing.Point(451, 322);
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
            this.buttonConvertColors.Enabled = false;
            this.buttonConvertColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConvertColors.Location = new System.Drawing.Point(417, 496);
            this.buttonConvertColors.Name = "buttonConvertColors";
            this.buttonConvertColors.Size = new System.Drawing.Size(176, 62);
            this.buttonConvertColors.TabIndex = 10;
            this.buttonConvertColors.Text = "Convert Colors";
            this.buttonConvertColors.UseVisualStyleBackColor = true;
            this.buttonConvertColors.Click += new System.EventHandler(this.buttonConvertColors_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Count,
            this.ColorName,
            this.ColorValue});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(1040, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(244, 611);
            this.dataGridView1.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 60;
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
            // buttonGrid
            // 
            this.buttonGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGrid.Location = new System.Drawing.Point(857, 496);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.Size = new System.Drawing.Size(134, 62);
            this.buttonGrid.TabIndex = 12;
            this.buttonGrid.Text = "Block Layout";
            this.buttonGrid.UseVisualStyleBackColor = true;
            this.buttonGrid.Click += new System.EventHandler(this.buttonGrid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(873, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Resolution:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(304, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Resolution:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(454, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Scale the image";
            // 
            // progressBarGenerate
            // 
            this.progressBarGenerate.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.progressBarGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBarGenerate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.progressBarGenerate.Location = new System.Drawing.Point(51, 586);
            this.progressBarGenerate.Name = "progressBarGenerate";
            this.progressBarGenerate.Size = new System.Drawing.Size(243, 23);
            this.progressBarGenerate.Step = 1;
            this.progressBarGenerate.TabIndex = 17;
            // 
            // label5warning
            // 
            this.label5warning.AutoSize = true;
            this.label5warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5warning.Location = new System.Drawing.Point(732, 58);
            this.label5warning.Name = "label5warning";
            this.label5warning.Size = new System.Drawing.Size(259, 16);
            this.label5warning.TabIndex = 18;
            this.label5warning.Text = "High resolution takes more time to convert!";
            this.label5warning.Visible = false;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInfo.Location = new System.Drawing.Point(1, 586);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(44, 23);
            this.buttonInfo.TabIndex = 19;
            this.buttonInfo.Text = "info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(300, 586);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(69, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.label5warning);
            this.Controls.Add(this.progressBarGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PixelArtTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Button buttonGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarGenerate;
        private System.Windows.Forms.Label label5warning;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonCancel;
    }
}

