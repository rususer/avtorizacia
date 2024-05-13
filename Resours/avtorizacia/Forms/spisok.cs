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

namespace avtorizacia.Forms
{
    public partial class spisok : Form
    {
        public spisok()
        {
            InitializeComponent();
        }

        private void spisok_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5432; database = inventory_data_base; user id = postgres; password=12345");
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter("SELECT * from devices", conn);
            DataTable dt = new DataTable();
            adp.Fill( dt );
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5432; database = inventory_data_dase; user id = postgres; password=12345");
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter("* from devices", conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5432; database = inventory_data_dase; user id = postgres; password=12345");
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter("* from devices", conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
