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
    public partial class LoginForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BFCMD50\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Проверка заполненности полей
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            try
            {
                int userId = AuthenticateUser(email, password);
                if (userId != 0)
                {
                    MessageBox.Show($"Успешный вход.");
                    OpenUserForm(userId);
                }
                else
                {
                    MessageBox.Show("Неправильный Email или пароль.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        //Аунтефикация пользователя
        private int AuthenticateUser(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID FROM Users WHERE Email = @Email AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return (int)result;
                }
                return 0;
            }
        }
        //Открытие соотвествующей формы для пользователя
        private void OpenUserForm(int userId)
        {
            string role = GetUserRole(userId);
            if (role == "Teacher")
            {
                int teacherId = GetTeacherId(userId);
                if (teacherId != 0)
                {
                    TeacherForm teacherForm = new TeacherForm(teacherId);
                    teacherForm.Show();
                    this.Hide();
                    teacherForm.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось найти учителя с указанным UserID.");
                }
            }
            else if (role == "Student")
            {
                int studentId = GetStudentId(userId);
                if (studentId != 0)
                {
                    StudentForm studentForm = new StudentForm(studentId);
                    studentForm.Show();
                    this.Hide();
                    studentForm.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось найти студента с указанным UserID.");
                }
            }
            else
            {
                MessageBox.Show("Неизвестная роль пользователя.");
            }
        }
        //Получение роли пользователя
        private string GetUserRole(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Role FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", userId);

                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                return "";
            }
        }
        //Получение ID Преподавателя
        private int GetTeacherId(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TeacherID FROM Teachers WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", userId);

                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return (int)result;
                }
                return 0;
            }
        }
        //Получение ID Студента
        private int GetStudentId(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT StudentID FROM Students WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", userId);

                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return (int)result;
                }
                return 0;
            }
        }
        //Открытие формы
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Показываем или скрываем пароль в зависимости от состояния checkbox
            if (guna2CheckBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
