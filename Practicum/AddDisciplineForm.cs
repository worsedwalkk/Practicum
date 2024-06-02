using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practicum
{
    public partial class AddDisciplineForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BFCMD50\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True";
        private int teacherId;
        public AddDisciplineForm(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
        }

        private async void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            string disciplineName = txtDisciplineName.Text.Trim();

            // Проверка заполненности поля
            if (string.IsNullOrWhiteSpace(disciplineName))
            {
                MessageBox.Show("Введите название дисциплины.");
                return;
            }

            // Проверка оригинальности введенных данных
            if (!IsUniqueDisciplineName(disciplineName))
            {
                MessageBox.Show("Такая дисциплина уже существует.");
                return;
            }

            try
            {
                await AddDisciplineAsync(teacherId, disciplineName);
                MessageBox.Show("Дисциплина успешно добавлена.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        private async Task AddDisciplineAsync(int teacherId, string disciplineName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Проверяем, существует ли TeacherID в таблице Teachers
                    string checkTeacherQuery = "SELECT COUNT(*) FROM Teachers WHERE TeacherID = @TeacherID";
                    SqlCommand checkTeacherCmd = new SqlCommand(checkTeacherQuery, connection);
                    checkTeacherCmd.Parameters.AddWithValue("@TeacherID", teacherId);

                    await connection.OpenAsync();

                    // Отладочное сообщение для проверки teacherId
                    MessageBox.Show("Проверка TeacherID: " + teacherId);

                    int teacherExists = (int)await checkTeacherCmd.ExecuteScalarAsync();

                    // Отладочное сообщение для проверки результата запроса
                    MessageBox.Show("Результат проверки TeacherID: " + teacherExists);

                    if (teacherExists == 0)
                    {
                        MessageBox.Show("Указанный TeacherID не существует. Пожалуйста, проверьте данные и повторите попытку.");
                        return;
                    }

                    // Если TeacherID существует, добавляем запись в таблицу Disciplines
                    string insertQuery = "INSERT INTO Disciplines (TeacherID, DisciplineName) VALUES (@TeacherID, @DisciplineName)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@TeacherID", teacherId);
                    insertCmd.Parameters.AddWithValue("@DisciplineName", disciplineName);

                    await insertCmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении дисциплины: " + ex.Message);
            }
        }

        private bool IsUniqueDisciplineName(string disciplineName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Disciplines WHERE DisciplineName = @DisciplineName";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DisciplineName", disciplineName);

                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count == 0;
            }
        }


    }
}
