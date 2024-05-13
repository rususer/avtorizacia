using avtorizacia.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtorizacia
{
    public partial class AdmMenu : Form
    {
        userss us = new userss();
        informachion info = new informachion();
        public AdmMenu()
        {
            InitializeComponent();
        }

        private void buttonUserss_Click(object sender, EventArgs e)
        {
            lbtForm.Text = buttonUserss.Text;
            panelDesktop.Controls.Clear();
            us.Close();
            us = new userss();
            us.TopLevel = false;
            us.Parent = this.panelDesktop;
            us.FormBorderStyle = FormBorderStyle.None;
            us.Height = this.panelDesktop.Height;
            us.Width = this.panelDesktop.Width;
            us.Show();
        }

        private void Inform_button_Click(object sender, EventArgs e)
        {
            lbtForm.Text = Inform_button.Text;
            panelDesktop.Controls.Clear();
            info.Close();
            info = new informachion();
            info.TopLevel = false;
            info.Parent = this.panelDesktop;
            info.FormBorderStyle = FormBorderStyle.None;
            info.Height = this.panelDesktop.Height;
            info.Width = this.panelDesktop.Width;
            info.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login form2 = new login();
            form2.Show();
            this.Hide();
        }
    }
}
