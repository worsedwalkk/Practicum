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
    public partial class AddGroupForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BFCMD50\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True";
        private TeacherForm teacherForm;

        public AddGroupForm(TeacherForm form)
        {
            InitializeComponent();
            teacherForm = form;
        }

        private async void btnAddGroup_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupName.Text.Trim();

            // Проверка заполненности поля
            if (string.IsNullOrWhiteSpace(groupName))
            {
                MessageBox.Show("Введите название группы.");
                return;
            }

            // Проверка оригинальности введенных данных
            if (!IsUniqueGroupName(groupName))
            {
                MessageBox.Show("Tакая группа уже существует.");
                return;
            }

            try
            {
                await AddGroupAsync(groupName);
                MessageBox.Show("Группа успешно добавлена.");
                await teacherForm.ReloadGroupsAsync(); // Вызов метода для перезагрузки групп
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления группы: " + ex.Message);
            }
        }

        private async Task AddGroupAsync(string groupName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Groups (GroupName) VALUES (@GroupName)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@GroupName", groupName);

                await connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }

        private bool IsUniqueGroupName(string groupName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Groups WHERE GroupName = @GroupName";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@GroupName", groupName);

                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count == 0;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
