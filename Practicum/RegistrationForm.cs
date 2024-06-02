using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BFCMD50\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True";
        public RegistrationForm()
        {
            InitializeComponent();
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            HideGroupSelection();
            LoadGroups();
        }
        //Видимость элемента управления
        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideGroupSelection();
        }

        private void HideGroupSelection()
        {
            bool isStudent = cbRole.SelectedItem?.ToString() == "Student";
            lblGroup.Visible = isStudent;
            cbGroup.Visible = isStudent;
        }
        //Загрузка групп в элемент управления
        private void LoadGroups()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Groups";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbGroup.DataSource = dt;
                cbGroup.DisplayMember = "GroupName";
                cbGroup.ValueMember = "GroupID";
            }
        }
        //Кнопка для регистрации
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string role = cbRole.SelectedItem?.ToString();
            int groupId = cbGroup.SelectedValue != null ? (int)cbGroup.SelectedValue : 0;

            // Проверка заполненности полей
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            // Проверка валидности email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Введите правильный Email.");
                return;
            }

            // Проверка оригинальности email
            if (!IsUniqueEmail(email))
            {
                MessageBox.Show("Такой Email зарегистрирован.");
                return;
            }

            // Проверка длины пароля
            if (password.Length < 8)
            {
                MessageBox.Show("Пароль должен состоять минимум из 8 символов.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверка оригинальности имени пользователя
                if (!IsUniqueName(name, connection))
                {
                    MessageBox.Show("Имя пользователя занято.");
                    connection.Close();
                    return;
                }

                string query = "INSERT INTO Users (Name, Email, Password, Role) OUTPUT INSERTED.UserID VALUES (@Name, @Email, @Password, @Role)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                int userId = (int)cmd.ExecuteScalar();

                if (role == "Teacher")
                {
                    string teacherQuery = "INSERT INTO Teachers (UserID) VALUES (@UserID)";
                    SqlCommand teacherCmd = new SqlCommand(teacherQuery, connection);
                    teacherCmd.Parameters.AddWithValue("@UserID", userId);
                    teacherCmd.ExecuteNonQuery();
                }
                else if (role == "Student")
                {
                    string studentQuery = "INSERT INTO Students (UserID, GroupID) VALUES (@UserID, @GroupID)";
                    SqlCommand studentCmd = new SqlCommand(studentQuery, connection);
                    studentCmd.Parameters.AddWithValue("@UserID", userId);
                    studentCmd.Parameters.AddWithValue("@GroupID", groupId);
                    studentCmd.ExecuteNonQuery();
                }

                connection.Close();
                MessageBox.Show("Регистрация успешна.");
                this.Close();
            }
        }
        //Проверка правильности email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsUniqueEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Email", email);
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                connection.Close();
                return count == 0;
            }
        }

        private bool IsUniqueName(string name, SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Name = @Name";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", name);
            int count = (int)cmd.ExecuteScalar();
            return count == 0;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}

