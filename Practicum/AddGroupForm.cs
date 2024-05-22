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
        public AddGroupForm()
        {
            InitializeComponent();
        }

        private async void btnAddGroup_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupName.Text;
            if (string.IsNullOrWhiteSpace(groupName))
            {
                MessageBox.Show("Please enter a group name.");
                return;
            }

            try
            {
                await AddGroupAsync(groupName);
                MessageBox.Show("Group added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding group: " + ex.Message);
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
    }
}
