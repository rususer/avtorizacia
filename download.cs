using Npgsql;
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
    public partial class download : Form
    {
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                base.WndProc(ref m);
                if ((int)m.Result == 0x1)
                    m.Result = (IntPtr)0x2;
                return;
            }
            base.WndProc(ref m);
        }
        public download()
        {
            InitializeComponent();
            animationComponent1.ShowForm(1000);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = 100;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Maximum == progressBar1.Value)
            {
                timer1.Enabled = false;
                this.Hide();
            }
            else
            {
                progressBar1.Value++;
            }
        }


        private void gradientFon1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
