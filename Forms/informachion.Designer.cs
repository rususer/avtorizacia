namespace avtorizacia.Forms
{
    partial class informachion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informachion));
            this.label1 = new System.Windows.Forms.Label();
            this.vk_button = new System.Windows.Forms.Button();
            this.button_tg = new System.Windows.Forms.Button();
            this.button_mail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // vk_button
            // 
            this.vk_button.Image = ((System.Drawing.Image)(resources.GetObject("vk_button.Image")));
            this.vk_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vk_button.Location = new System.Drawing.Point(24, 292);
            this.vk_button.Name = "vk_button";
            this.vk_button.Size = new System.Drawing.Size(224, 73);
            this.vk_button.TabIndex = 1;
            this.vk_button.Text = "Мы в ВК";
            this.vk_button.UseVisualStyleBackColor = true;
            this.vk_button.Click += new System.EventHandler(this.vk_button_Click);
            // 
            // button_tg
            // 
            this.button_tg.Image = ((System.Drawing.Image)(resources.GetObject("button_tg.Image")));
            this.button_tg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_tg.Location = new System.Drawing.Point(264, 292);
            this.button_tg.Name = "button_tg";
            this.button_tg.Size = new System.Drawing.Size(224, 73);
            this.button_tg.TabIndex = 2;
            this.button_tg.Text = "Мы в Телеграм";
            this.button_tg.UseVisualStyleBackColor = true;
            this.button_tg.Click += new System.EventHandler(this.button_tg_Click);
            // 
            // button_mail
            // 
            this.button_mail.Image = ((System.Drawing.Image)(resources.GetObject("button_mail.Image")));
            this.button_mail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_mail.Location = new System.Drawing.Point(504, 292);
            this.button_mail.Name = "button_mail";
            this.button_mail.Size = new System.Drawing.Size(224, 73);
            this.button_mail.TabIndex = 3;
            this.button_mail.Text = "               mark.kysakin@gmail.com";
            this.button_mail.UseVisualStyleBackColor = true;
            this.button_mail.Click += new System.EventHandler(this.button_mail_Click);
            // 
            // informachion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.button_mail);
            this.Controls.Add(this.button_tg);
            this.Controls.Add(this.vk_button);
            this.Controls.Add(this.label1);
            this.Name = "informachion";
            this.Text = "informachion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vk_button;
        private System.Windows.Forms.Button button_tg;
        private System.Windows.Forms.Button button_mail;
    }
}