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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPixelArtPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutputPixelArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonSaveOutput
            // 
            this.buttonSaveOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveOutput.Location = new System.Drawing.Point(683, 529);
            this.buttonSaveOutput.Name = "buttonSaveOutput";
            this.buttonSaveOutput.Size = new System.Drawing.Size(201, 62);
            this.buttonSaveOutput.TabIndex = 8;
            this.buttonSaveOutput.Text = "Save";
            this.buttonSaveOutput.UseVisualStyleBackColor = true;
            this.buttonSaveOutput.Click += new System.EventHandler(this.buttonSaveOutput_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image file|*.jpeg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 625);
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
    }
}

