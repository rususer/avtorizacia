using avtorizacia.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace avtorizacia
{

    public partial class menu : Form
    {

        inventorizacia inv = new inventorizacia();
        spisok sp = new spisok();
        informachion info = new informachion();
        employees empl = new employees();
        private Form activeForm;
        private Random random;
        private int tempIndex;
        private Form currentChildForm;
        public menu()
        {

            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbtForm.Text = childForm.Text;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, UnmanagedType wParam, int lParam);


        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SendMessage(IntPtr handle, int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonInventoriz_Click(object sender, EventArgs e)
        {
            lbtForm.Text = buttonInventoriz.Text;
            panelDesktop.Controls.Clear();
            inv.Close();
            inv = new inventorizacia();
            inv.TopLevel = false;
            inv.Parent = this.panelDesktop;
            inv.FormBorderStyle = FormBorderStyle.None;
            inv.Height = this.panelDesktop.Height;
            inv.Width = this.panelDesktop.Width;
            inv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbtForm.Text = buttonSpisok.Text;
            panelDesktop.Controls.Clear();
            sp.Close();
            sp = new spisok();
            sp.TopLevel = false;
            sp.Parent = this.panelDesktop;
            sp.FormBorderStyle = FormBorderStyle.None;
            sp.Height = this.panelDesktop.Height;
            sp.Width = this.panelDesktop.Width;
            sp.Show();
        }



        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
        }

        private void buttonInform_Click(object sender, EventArgs e)
        {
            lbtForm.Text = buttonEmployees.Text;
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

        private void exit_profiles_Click(object sender, EventArgs e)
        {
            login form2 = new login();
            form2.Show();
            this.Hide();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Inform_button_Click(object sender, EventArgs e)
        {
            lbtForm.Text = buttonEmployees.Text;
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

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            lbtForm.Text = buttonEmployees.Text;
            panelDesktop.Controls.Clear();
            empl.Close();
            empl = new employees();
            empl.TopLevel = false;
            empl.Parent = this.panelDesktop;
            empl.FormBorderStyle = FormBorderStyle.None;
            empl.Height = this.panelDesktop.Height;
            empl.Width = this.panelDesktop.Width;
            empl.Show();
        }
    }
}