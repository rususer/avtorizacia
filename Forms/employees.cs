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
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employees_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5433; database = inventory_data_base; user id = postgres; password=12345");
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter("SELECT * from employees", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Получение данных из выделенной строки DataGridView
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string fullName = row.Cells["employees_ФИО"].Value.ToString();
                string department = row.Cells["employees_Отдел"].Value.ToString();
                string email = row.Cells["employees_email"].Value.ToString();
                string phoneNumber = row.Cells["employees_Номер_телефона"].Value.ToString();

                // Отображение данных в TextBox-ах
                textBox1.Text = fullName;
                textBox2.Text = department;
                textBox3.Text = email;
                textBox4.Text = phoneNumber;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Проверка, что в DataGridView есть выделенная строка
            if (dataGridView1.CurrentRow != null)
            {
                // Получение выделенной строки
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Получение значений из TextBox-ов
                string fullName = textBox1.Text;
                string department = textBox2.Text;
                string email = textBox3.Text;
                string phoneNumber = textBox4.Text;

                // Получение ID выделенной строки из ячейки "ID" (предполагается, что у вас есть столбец "ID" в DataGridView)
                int id = Convert.ToInt32(selectedRow.Cells["employees_id"].Value);

                // Параметры подключения к базе данных PostgreSQL
                string host = "localhost";
                int port = 5433;
                string database = "inventory_data_base";
                string userId = "postgres";
                string password = "12345";

                // Обновление данных в таблице "employees"
                string connectionString = $"Host={host};Port={port};Database={database};User Id={userId};Password={password}";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE employees SET employees_ФИО = @fullName, employees_Отдел = @department, employees_email = @email, employees_Номер_телефона = @phoneNumber WHERE employees_id = @id";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@department", department);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }

                // Обновление данных в DataGridView
                selectedRow.Cells["employees_ФИО"].Value = fullName;
                selectedRow.Cells["employees_Отдел"].Value = department;
                selectedRow.Cells["employees_email"].Value = email;
                selectedRow.Cells["employees_Номер_телефона"].Value = phoneNumber;

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получение значений из TextBox-ов
            string fullName = textBox1.Text;
            string department = textBox2.Text;
            string email = textBox3.Text;
            string phoneNumber = textBox4.Text;

            // Параметры подключения к базе данных PostgreSQL
            string host = "localhost";
            int port = 5433;
            string database = "inventory_data_base";
            string userId = "postgres";
            string password = "12345";

            // Подключение к базе данных PostgreSQL
            string connectionString = $"Host={host};Port={port};Database={database};User Id={userId};Password={password}";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Вставка нового сотрудника в таблицу "employees"
                string insertQuery = "INSERT INTO employees (employees_ФИО, employees_Отдел, employees_email, employees_Номер_телефона) VALUES (@fullName, @department, @email, @phoneNumber)";
                NpgsqlCommand insertCommand = new NpgsqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@fullName", fullName);
                insertCommand.Parameters.AddWithValue("@department", department);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                insertCommand.ExecuteNonQuery();
            }

            // Очистка TextBox-ов после сохранения данных
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;

            MessageBox.Show("Новый сотрудник успешно сохранен!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка, что в DataGridView есть выделенная строка
            if (dataGridView1.CurrentRow != null)
            {
                // Получение выделенной строки
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Получение ID выделенной строки из ячейки "ID" (предполагается, что у вас есть столбец "ID" в DataGridView)
                int id = Convert.ToInt32(selectedRow.Cells["employees_id"].Value);

                // Параметры подключения к базе данных PostgreSQL
                string host = "localhost";
                int port = 5433;
                string database = "inventory_data_base";
                string userId = "postgres";
                string password = "12345";

                // Удаление данных из таблицы "employees"
                string connectionString = $"Host={host};Port={port};Database={database};User Id={userId};Password={password}";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM employees WHERE employees_id = @id";
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
