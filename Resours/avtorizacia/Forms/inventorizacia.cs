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
    public partial class inventorizacia : Form
    {
        public inventorizacia()
        {
            InitializeComponent();
        }

        private void inventorizacia_Load(object sender, EventArgs e)
        {
                NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5432; database = usersdb; user id = postgres; password=12345");
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter("select id, Тип_техники, Наименование_техники, Дата_установки, Кабинет, Сотрудник, Серийный_номер, Количество, Наличие from spisok_technik", conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
