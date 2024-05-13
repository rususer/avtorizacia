using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace avtorizacia.Forms
{
    public partial class informachion : Form
    {
        public informachion()
        {
            InitializeComponent();
        }

        private void vk_button_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/id457006454");
        }

        private void button_tg_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/stbbu");
        }

        private void button_mail_Click(object sender, EventArgs e)
        {
            Process.Start("https://e.mail.ru/inbox/?utm_source=portal&utm_medium=new_portal_navigation&utm_campaign=e.mail.ru&mt_sub5=94&mt_sub1=account.mail.ru&mt_click_id=mt-y7s979-1684818976-1198205976");
        }
    }
}
