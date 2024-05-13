using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;port=5433;database=inventory_data_base;user id=postgres;password=12345");
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter("SELECT devices.device_id, devices.device_Тип, devices.device_Модель, devices.Описание, devices.device_Серийный_номер, devices.device_Дата_установки, devices.device_Дата_списания, employees.employees_ФИО AS Сотрудник, devices.device_Нахождение, devices.device_Временно_перемещён, devices.device_Кабинет_в_который_перемещён, devices.device_Наличие, devices.device_repair, devices.Описание_поломки FROM devices INNER JOIN employees ON devices.employees_id = employees.employees_id", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            // Получаем коллекцию столбцов DataGridView
            DataGridViewColumnCollection columns = dataGridView1.Columns;

            // Проходимся по каждому столбцу
            foreach (DataGridViewColumn column in columns)
            {
                // Заменяем название столбца, удаляя слово "device_"
                column.HeaderText = column.HeaderText.Replace("device_", "");
                column.HeaderText = column.HeaderText.Replace("_id", "");
                column.HeaderText = column.HeaderText.Replace("_", " ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Сотрудник"].Index)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string employeeIdFromDevices = cell.Value.ToString();

                // Строка подключения к базе данных PostgreSQL
                string connectionString = "Host=localhost;Port=5433;Database=inventory_data_base;Username=postgres;Password=12345";

                // Запрос для получения информации о сотруднике по ID из таблицы "Сотрудник"
                string query = $"SELECT employees_id, employees_ФИО, employees_Отдел, employees_email, employees_Номер_телефона FROM Сотрудник WHERE employees_id = '{employeeIdFromDevices}'";

                // Создание подключения к базе данных
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Выполнение запроса
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                DataRow row = dataTable.Rows[0];

                                // Получение информации о сотруднике
                                string employeeId = row["employees_id"].ToString();
                                string fullName = row["employees_ФИО"].ToString();
                                string department = row["employees_Отдел"].ToString();
                                string email = row["employees_email"].ToString();
                                string phoneNumber = row["employees_Номер_телефона"].ToString();

                                // Формирование текста окна с информацией о сотруднике
                                string message = $"Employee ID: {employeeId}\n" +
                                                 $"Full Name: {fullName}\n" +
                                                 $"Department: {department}\n" +
                                                 $"Email: {email}\n" +
                                                 $"Phone Number: {phoneNumber}";

                                MessageBox.Show(message, "Employee Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;port=5433;database=inventory_data_base;user id=postgres;password=12345");
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter("SELECT * FROM devices JOIN Сотрудник ON devices.employees_id = Сотрудник.employees_id WHERE Сотрудник.employees_ФИО = '" + FindBox.Text + "';", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
           
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5433; database = inventory_data_base; user id = postgres; password=12345");
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter("SELECT * FROM devices WHERE device_Нахождение = '" + textBox2.Text + "';", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5433; database = inventory_data_base; user id = postgres; password=12345");
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter("SELECT * FROM devices WHERE device_Серийный_номер = '" + textBox3.Text + "';", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5433; database = inventory_data_base; user id = postgres; password=12345");
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter("SELECT * FROM devices WHERE device_repair = 'true';", conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5433; database = inventory_data_base; user id = postgres; password=12345");
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter("SELECT * from devices", conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что индекс строки больше или равен нулю, чтобы исключить заголовок DataGridView
            if (e.RowIndex >= 0)
            {
                // Получаем ссылку на DataGridView, который вызвал это событие
                DataGridView dgv = sender as DataGridView;

                // Получаем значения ячеек, которые были изменены
                int deviceId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["device_id"].Value);
                string deviceType = dgv.Rows[e.RowIndex].Cells["device_Тип"].Value.ToString();
                string deviceModel = dgv.Rows[e.RowIndex].Cells["device_Модель"].Value.ToString();
                string serialNumber = dgv.Rows[e.RowIndex].Cells["device_Серийный_номер"].Value.ToString();
                DateTime installationDate = Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["device_Дата_установки"].Value);
                DateTime writeOffDate = Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["device_Дата_списания"].Value);
                int employeeId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["employees_id"].Value);
                string location = dgv.Rows[e.RowIndex].Cells["device_Нахождение"].Value.ToString();
                int quantity = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["device_Колличество"].Value);
                bool temporarilyMoved = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["device_Временно_перемещён"].Value);
                string temporaryLocation = dgv.Rows[e.RowIndex].Cells["device_Кабинет_в_который_перемещён"].Value.ToString();
                bool isPresent = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["device_Наличие"].Value);
                bool isRepaired = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["device_repair"].Value);

                // Создаем подключение к базе данных PostgreSQL
                // получаем подключение к базе данных
                NpgsqlConnection conn = new NpgsqlConnection("Host = localhost;port = 5433; database = inventory_data_base; user id = postgres; password=12345;Database=devices;");
                try
                {
                    // Открываем соединение с базой данных
                    conn.Open();

                    // Создаем объект команды для выполнения SQL-запроса
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE devices SET device_type = @DeviceType, device_model = @DeviceModel, serial_number = @SerialNumber, installation_date = @InstallationDate, write_off_date = @WriteOffDate, employee_id = @EmployeeId, location = @Location, quantity = @Quantity, temporarily_moved = @TemporarilyMoved, temporary_location = @TemporaryLocation, is_present = @IsPresent, is_repaired = @IsRepaired WHERE device_id = @DeviceId;", conn);

                    // Добавляем параметры в запрос
                    command.Parameters.AddWithValue("@DeviceId", deviceId);
                    command.Parameters.AddWithValue("@DeviceType", deviceType);
                    command.Parameters.AddWithValue("@DeviceModel", deviceModel);
                    command.Parameters.AddWithValue("@SerialNumber", serialNumber);
                    command.Parameters.AddWithValue("@InstallationDate", installationDate);
                    command.Parameters.AddWithValue("@WriteOffDate", writeOffDate);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@TemporarilyMoved", temporarilyMoved);
                    command.Parameters.AddWithValue("@TemporaryLocation", temporaryLocation);
                    command.Parameters.AddWithValue("@IsPresent", isPresent);
                    command.Parameters.AddWithValue("@IsRepaired", isRepaired);

                    // Выполняем команду
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении данных в базу данных: " + ex.Message);
                }
                finally
                {
                    // Закрываем соединение с базой данных
                    conn.Close();
                }
            }

        }

        private void butnPrint_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSpisok form3 = new AddSpisok();
            form3.Show();
        }
    }
}
