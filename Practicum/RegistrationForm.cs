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

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideGroupSelection();
        }
        private void HideGroupSelection()
        {
            if (cbRole.Text == "Teacher")
            {
                lblGroup.Hide();
                cbGroup.Hide();
            }
            else
            {
                lblGroup.Show();
                cbGroup.Show();
            }
        }
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string role = cbRole.SelectedItem.ToString();
            int groupId = cbGroup.SelectedValue != null ? (int)cbGroup.SelectedValue : 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Name, Email, Password, Role) OUTPUT INSERTED.UserID VALUES (@Name, @Email, @Password, @Role)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                connection.Open();
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
                MessageBox.Show("Registration successful.");
                this.Close();
            }
        }
    }
}
