namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openPicture = new System.Windows.Forms.PictureBox();
            this.openPicBtn = new System.Windows.Forms.Button();
            this.transformPic = new System.Windows.Forms.PictureBox();
            this.btnGray = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.Invert = new System.Windows.Forms.Button();
            this.btnRain = new System.Windows.Forms.Button();
            this.Embossment = new System.Windows.Forms.Button();
            this.sharp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformPic)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openPicture
            // 
            this.openPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.openPicture.Location = new System.Drawing.Point(12, 12);
            this.openPicture.Name = "openPicture";
            this.openPicture.Size = new System.Drawing.Size(473, 554);
            this.openPicture.TabIndex = 0;
            this.openPicture.TabStop = false;
            // 
            // openPicBtn
            // 
            this.openPicBtn.Location = new System.Drawing.Point(12, 643);
            this.openPicBtn.Name = "openPicBtn";
            this.openPicBtn.Size = new System.Drawing.Size(77, 52);
            this.openPicBtn.TabIndex = 1;
            this.openPicBtn.Text = "打开";
            this.openPicBtn.UseVisualStyleBackColor = true;
            this.openPicBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // transformPic
            // 
            this.transformPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transformPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transformPic.Location = new System.Drawing.Point(540, 12);
            this.transformPic.Name = "transformPic";
            this.transformPic.Size = new System.Drawing.Size(473, 554);
            this.transformPic.TabIndex = 2;
            this.transformPic.TabStop = false;
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(121, 643);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(77, 52);
            this.btnGray.TabIndex = 3;
            this.btnGray.Text = "灰化";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.BtnGray_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(936, 643);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Invert
            // 
            this.Invert.Location = new System.Drawing.Point(233, 643);
            this.Invert.Name = "Invert";
            this.Invert.Size = new System.Drawing.Size(77, 52);
            this.Invert.TabIndex = 5;
            this.Invert.Text = "取反";
            this.Invert.UseVisualStyleBackColor = true;
            this.Invert.Click += new System.EventHandler(this.Invert_Click);
            // 
            // btnRain
            // 
            this.btnRain.Location = new System.Drawing.Point(337, 643);
            this.btnRain.Name = "btnRain";
            this.btnRain.Size = new System.Drawing.Size(77, 52);
            this.btnRain.TabIndex = 6;
            this.btnRain.Text = "雾化";
            this.btnRain.UseVisualStyleBackColor = true;
            this.btnRain.Click += new System.EventHandler(this.BtnRain_Click);
            // 
            // Embossment
            // 
            this.Embossment.Location = new System.Drawing.Point(450, 643);
            this.Embossment.Name = "Embossment";
            this.Embossment.Size = new System.Drawing.Size(77, 52);
            this.Embossment.TabIndex = 7;
            this.Embossment.Text = "浮雕";
            this.Embossment.UseVisualStyleBackColor = true;
            this.Embossment.Click += new System.EventHandler(this.Embossment_Click);
            // 
            // sharp
            // 
            this.sharp.Location = new System.Drawing.Point(557, 643);
            this.sharp.Name = "sharp";
            this.sharp.Size = new System.Drawing.Size(77, 52);
            this.sharp.TabIndex = 8;
            this.sharp.Text = "锐化";
            this.sharp.UseVisualStyleBackColor = true;
            this.sharp.Click += new System.EventHandler(this.Sharp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "柔化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(797, 643);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "水印";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 775);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sharp);
            this.Controls.Add(this.Embossment);
            this.Controls.Add(this.btnRain);
            this.Controls.Add(this.Invert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.transformPic);
            this.Controls.Add(this.openPicBtn);
            this.Controls.Add(this.openPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox openPicture;
        private System.Windows.Forms.Button openPicBtn;
        private System.Windows.Forms.PictureBox transformPic;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Invert;
        private System.Windows.Forms.Button btnRain;
        private System.Windows.Forms.Button Embossment;
        private System.Windows.Forms.Button sharp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

