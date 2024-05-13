using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace avtorizacia
{
    public partial class login : Form
    {


        public login()
        {
            InitializeComponent();
            animationComponent1.ShowForm(1000);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;port=5433;database=usersdb;user id=postgres;password=12345");
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter("SELECT password, preoritet FROM userss WHERE login = '" + textBox1.Text + "';", conn);
                DataTable dt = new DataTable();

                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string password = dt.Rows[0]["password"].ToString();
                    int preoritet = Convert.ToInt32(dt.Rows[0]["preoritet"]);

                    if (password == textBox2.Text)
                    {
                        if (preoritet == 1)
                        {
                            menu form2 = new menu();
                            form2.Show();
                            this.Hide();
                        }
                        else if (preoritet == 2)
                        {
                            AdmMenu form3 = new AdmMenu();
                            form3.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден!");
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Проблема с подключением, проверьте доступ к интернету!" + ex);
            }
        }



        private void gradientFon1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void gradientFon1_MouseClick(object sender, MouseEventArgs e)
        { 



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = (sender as CheckBox).Checked ? '*' : '\0';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace GradientFon
{
    class GradientFon : Panel
    {
        private Color _firstFillColor;
        private Color _secondfFillColor;
        private LinearGradientMode _gradientDirection;

        [Description("Первый цвет для градиентного заполнения"), DefaultValue(typeof(Color), "")]
        public Color ColorFillFirst
        {
            get => _firstFillColor;
            set => _firstFillColor = value;
        }
        [Description("Второй цвет для градиентного заполнения"), DefaultValue(typeof(Color), "")]
        public Color ColorFillSecond
        {
            get => _secondfFillColor;
            set => _secondfFillColor = value;
        }
        [Description("Тип (направление) градиента"), DefaultValue(LinearGradientMode.ForwardDiagonal)]
        public LinearGradientMode GradientDirection
        {
            get => _gradientDirection;
            set => _gradientDirection = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var lgb = new LinearGradientBrush(ClientRectangle, _firstFillColor, _secondfFillColor, _gradientDirection);
            var graphics = e.Graphics;
            graphics.FillRectangle(lgb, ClientRectangle);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            base.OnPaint(e);
        }
    }
}
