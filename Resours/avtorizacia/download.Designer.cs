namespace avtorizacia
{
    partial class download
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(download));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradientFon1 = new GradientFon.GradientFon();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.animationComponent1 = new avtorizacia.AnimationComponent(this.components);
            this.gradientFon1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gradientFon1
            // 
            this.gradientFon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientFon1.BackgroundImage")));
            this.gradientFon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gradientFon1.ColorFillFirst = System.Drawing.Color.White;
            this.gradientFon1.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(114)))), ((int)(((byte)(224)))));
            this.gradientFon1.Controls.Add(this.pictureBox1);
            this.gradientFon1.Controls.Add(this.progressBar1);
            this.gradientFon1.ForeColor = System.Drawing.Color.Transparent;
            this.gradientFon1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientFon1.Location = new System.Drawing.Point(2, 1);
            this.gradientFon1.Name = "gradientFon1";
            this.gradientFon1.Size = new System.Drawing.Size(361, 183);
            this.gradientFon1.TabIndex = 2;
            this.gradientFon1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientFon1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 143);
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 28);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // animationComponent1
            // 
            this.animationComponent1.ActivateEffect = avtorizacia.FormAnimationEffect.ПОЯВЛЕНИЕ_ЗАТУХАНИЕ;
            this.animationComponent1.CloseEffect = avtorizacia.FormAnimationEffect.ПОЯВЛЕНИЕ_ЗАТУХАНИЕ;
            this.animationComponent1.SourseForm = this;
            // 
            // download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(361, 184);
            this.ControlBox = false;
            this.Controls.Add(this.gradientFon1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "download";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gradientFon1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AnimationComponent animationComponent1;
        private System.Windows.Forms.Timer timer1;
        private GradientFon.GradientFon gradientFon1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}