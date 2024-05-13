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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace avtorizacia.Forms
{
    public partial class AddSpisok : Form
    {
        public AddSpisok()
        {
            InitializeComponent();
        }



        private const string connectionString = "Host=localhost;Port=5433;Database=inventory_data_base;Username=postgres;Password=12345";

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string tipo = textBox1.Text;
            string model = textBox2.Text;
            string serialNumber = textBox3.Text;
            DateTime installationDate = dateTimePicker1.Value;
            DateTime disposalDate = dateTimePicker2.Value;
            int employeeId = GetEmployeeId(comboBox1.SelectedItem.ToString());
            string location = textBox4.Text;
            string quantityStr = textBox5.Text;
            bool temporarilyMoved = checkBox1.Checked;
            string room = textBox6.Text;
            bool availability = checkBox2.Checked;
            bool requiresRepair = checkBox3.Checked;

            // Проверка типа введенных данных

            int quantity;
            if (!int.TryParse(quantityStr, out quantity))
            {
                MessageBox.Show("Некорректное значение для количества. Введите целое число.");
                return;
            }

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO devices (device_Тип, device_Модель, device_Серийный_номер, device_Дата_установки, device_Дата_списания, employees_id, device_Нахождение, device_Колличество, device_Временно_перемещён, device_Кабинет_в_который_перемещён, device_Наличие, device_repair) " +
                                              "VALUES (@Tipo, @Model, @SerialNumber, @InstallationDate, @DisposalDate, @EmployeeId, @Location, @Quantity, @TemporarilyMoved, @Room, @Availability, @RequiresRepair)";

                        command.Parameters.AddWithValue("@Tipo", tipo);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@SerialNumber", serialNumber);
                        command.Parameters.AddWithValue("@InstallationDate", installationDate);
                        command.Parameters.AddWithValue("@DisposalDate", disposalDate);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@TemporarilyMoved", temporarilyMoved);
                        command.Parameters.AddWithValue("@Room", room);
                        command.Parameters.AddWithValue("@Availability", availability);
                        command.Parameters.AddWithValue("@RequiresRepair", requiresRepair);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Данные успешно добавлены в таблицу devices.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message);
            }
        }



        private int GetEmployeeId(string employeeFullName)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT employees_id FROM employees WHERE employees_ФИО = @EmployeeFullName";
                        command.Parameters.AddWithValue("@EmployeeFullName", employeeFullName);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении ID сотрудника: " + ex.Message);
            }

            return 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSpisok_Load(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            try
            {
                connection.Open();

                string sql = "SELECT DISTINCT employees_ФИО FROM employees";
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string employeeName = reader.GetString(0);
                    comboBox1.Items.Add(employeeName);
                }

                reader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                // Обработка ошибок при подключении или выполнении запроса
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = textBox1.Text;
            string model = textBox2.Text;
            string serialNumber = textBox3.Text;
            DateTime installationDate = dateTimePicker1.Value;
            DateTime disposalDate = dateTimePicker2.Value;
            int employeeId = GetEmployeeId(comboBox1.SelectedItem.ToString());
            string location = textBox4.Text;
            string quantityStr = textBox5.Text;
            bool temporarilyMoved = checkBox1.Checked;
            string room = textBox6.Text;
            bool availability = checkBox2.Checked;
            bool requiresRepair = checkBox3.Checked;

            // Проверка типа введенных данных

            int quantity;
            if (!int.TryParse(quantityStr, out quantity))
            {
                MessageBox.Show("Некорректное значение для количества. Введите целое число.");
                return;
            }

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO devices (device_Тип, device_Модель, device_Серийный_номер, device_Дата_установки, device_Дата_списания, employees_id, device_Нахождение, device_Колличество, device_Временно_перемещён, device_Кабинет_в_который_перемещён, device_Наличие, device_repair) " +
                                              "VALUES (@Tipo, @Model, @SerialNumber, @InstallationDate, @DisposalDate, @EmployeeId, @Location, @Quantity, @TemporarilyMoved, @Room, @Availability, @RequiresRepair) RETURNING device_id";

                        command.Parameters.AddWithValue("@Tipo", tipo);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@SerialNumber", serialNumber);
                        command.Parameters.AddWithValue("@InstallationDate", installationDate);
                        command.Parameters.AddWithValue("@DisposalDate", disposalDate);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@TemporarilyMoved", temporarilyMoved);
                        command.Parameters.AddWithValue("@Room", room);
                        command.Parameters.AddWithValue("@Availability", availability);
                        command.Parameters.AddWithValue("@RequiresRepair", requiresRepair);

                        // Получение автоматически сгенерированного device_id
                        int deviceId = Convert.ToInt32(command.ExecuteScalar());

                        MessageBox.Show("Данные успешно добавлены в таблицу devices. Номер новой записи: " + deviceId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

