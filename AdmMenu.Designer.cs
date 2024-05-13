namespace avtorizacia
{
    partial class AdmMenu
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbtForm = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Inform_button = new System.Windows.Forms.Button();
            this.exit_profiles = new System.Windows.Forms.Button();
            this.buttonUserss = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.Location = new System.Drawing.Point(190, 76);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelDesktop.Size = new System.Drawing.Size(745, 430);
            this.panelDesktop.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(155)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.lbtForm);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 76);
            this.panel2.TabIndex = 4;
            // 
            // lbtForm
            // 
            this.lbtForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtForm.AutoSize = true;
            this.lbtForm.BackColor = System.Drawing.Color.Transparent;
            this.lbtForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbtForm.ForeColor = System.Drawing.Color.Black;
            this.lbtForm.Location = new System.Drawing.Point(368, 21);
            this.lbtForm.Name = "lbtForm";
            this.lbtForm.Size = new System.Drawing.Size(294, 33);
            this.lbtForm.TabIndex = 0;
            this.lbtForm.Text = "Домашняя страница";
            this.lbtForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(155)))), ((int)(((byte)(225)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.Inform_button);
            this.panelMenu.Controls.Add(this.exit_profiles);
            this.panelMenu.Controls.Add(this.buttonUserss);
            this.panelMenu.Location = new System.Drawing.Point(-1, 76);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(192, 486);
            this.panelMenu.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(0, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Выйти с аккаунта";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inform_button
            // 
            this.Inform_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.Inform_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Inform_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inform_button.Location = new System.Drawing.Point(0, 37);
            this.Inform_button.Name = "Inform_button";
            this.Inform_button.Size = new System.Drawing.Size(192, 37);
            this.Inform_button.TabIndex = 8;
            this.Inform_button.Text = "О программе";
            this.Inform_button.UseVisualStyleBackColor = false;
            this.Inform_button.Click += new System.EventHandler(this.Inform_button_Click);
            // 
            // exit_profiles
            // 
            this.exit_profiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.exit_profiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit_profiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_profiles.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.exit_profiles.Location = new System.Drawing.Point(0, 438);
            this.exit_profiles.Name = "exit_profiles";
            this.exit_profiles.Size = new System.Drawing.Size(192, 48);
            this.exit_profiles.TabIndex = 7;
            this.exit_profiles.Text = "Выйти с аккаунта";
            this.exit_profiles.UseVisualStyleBackColor = false;
            // 
            // buttonUserss
            // 
            this.buttonUserss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.buttonUserss.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUserss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUserss.Location = new System.Drawing.Point(0, 0);
            this.buttonUserss.Name = "buttonUserss";
            this.buttonUserss.Size = new System.Drawing.Size(192, 37);
            this.buttonUserss.TabIndex = 2;
            this.buttonUserss.Text = "Список пользователей";
            this.buttonUserss.UseVisualStyleBackColor = false;
            this.buttonUserss.Click += new System.EventHandler(this.buttonUserss_Click);
            // 
            // AdmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 506);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdmMenu";
            this.Text = "AdmMenu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbtForm;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button Inform_button;
        private System.Windows.Forms.Button exit_profiles;
        private System.Windows.Forms.Button buttonUserss;
        private System.Windows.Forms.Button button1;
    }
}