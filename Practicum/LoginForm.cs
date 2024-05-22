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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            try
            {
                int userId = AuthenticateUser(email, password);
                if (userId != 0)
                {
                    MessageBox.Show("Login successful.");
                    OpenUserForm(userId);
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

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

        private void OpenUserForm(int userId)
        {
            string role = GetUserRole(userId);
            if (role == "Teacher")
            {
                TeacherForm teacherForm = new TeacherForm(userId);
                teacherForm.Show();
            }
            else if (role == "Student")
            {
                StudentForm studentForm = new StudentForm(userId);
                studentForm.Show();
            }
            // Handle other roles if necessary
        }

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
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}
