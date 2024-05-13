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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace avtorizacia.Forms
{

    public partial class userss : Form
    {
        public userss()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userss_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5433; database = usersdb; user id = postgres; password=12345");
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter("SELECT * from userss", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получение значений из TextBox-ов
            string login = textBox1.Text;
            string password = textBox2.Text;
            string name = textBox3.Text;
            string priority = textBox4.Text;

            // Параметры подключения к базе данных PostgreSQL
            string host = "localhost";
            int port = 5433;
            string database = "usersdb";
            string userId = "postgres";
            string pasword = "12345";
            // Получение выделенной строки
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
            // Подключение к базе данных PostgreSQL
            string connectionString = $"Host={host};Port={port};Database={database};Username={userId};Password={pasword}";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Вставка нового пользователя в таблицу "userss"
                string insertQuery = "INSERT INTO userss (login, password, name, preoritet) VALUES (@login, @password, @name, @priority)";
                NpgsqlCommand insertCommand = new NpgsqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@login", login);
                insertCommand.Parameters.AddWithValue("@password", password);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@priority", priority);

                insertCommand.ExecuteNonQuery();
            }

            // Обновление данных в DataGridView
            selectedRow.Cells["login"].Value = login;
            selectedRow.Cells["password"].Value = password;
            selectedRow.Cells["name"].Value = name;
            selectedRow.Cells["preoritet"].Value = priority;

            // Очистка TextBox-ов после сохранения данных
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;

            MessageBox.Show("Новый пользователь успешно сохранен!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Проверка, что в DataGridView есть выделенная строка
            if (dataGridView1.CurrentRow != null)
            {
                // Получение выделенной строки
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Получение значений из TextBox-ов
                string login = textBox1.Text;
                string password = textBox2.Text;
                string name = textBox3.Text;
                string priority = textBox4.Text;

                // Получение ID выделенной строки из ячейки "ID" (предполагается, что у вас есть столбец "ID" в DataGridView)
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // Параметры подключения к базе данных PostgreSQL
                string connectionString = "Host=localhost;Port=5433;Database=usersdb;Username=postgres;Password=12345";

                // Обновление данных в таблице "userss"
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE userss SET login = @login, password = @password, name = @name, preoritet = @priority WHERE id = @id";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@priority", priority);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }

                // Обновление данных в DataGridView
                selectedRow.Cells["login"].Value = login;
                selectedRow.Cells["password"].Value = password;
                selectedRow.Cells["name"].Value = name;
                selectedRow.Cells["preoritet"].Value = priority;

                // Очистка TextBox-ов после обновления данных
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;

                MessageBox.Show("Данные успешно обновлены!");
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что выбрана конкретная ячейка (не заголовок столбца и т. д.)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Получаем значение каждой ячейки выбранной строки
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = selectedRow.Cells["login"].Value.ToString();
                textBox2.Text = selectedRow.Cells["password"].Value.ToString();
                textBox3.Text = selectedRow.Cells["name"].Value.ToString();
                textBox4.Text = selectedRow.Cells["preoritet"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка, что в DataGridView есть выделенная строка
            if (dataGridView1.CurrentRow != null)
            {
                // Получение выделенной строки
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Получение ID выделенной строки из ячейки "ID" (предполагается, что у вас есть столбец "id" в DataGridView)
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // Параметры подключения к базе данных PostgreSQL
                string connectionString = "Host=localhost;Port=5433;Database=usersdb;Username=postgres;Password=12345";

                // Удаление данных из таблицы "userss"
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM userss WHERE id = @id";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }

                // Удаление строки из DataGridView
                dataGridView1.Rows.Remove(selectedRow);

                MessageBox.Show("Данные успешно удалены!");
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }
    }
}
