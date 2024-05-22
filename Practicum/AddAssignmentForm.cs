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
    public partial class AddAssignmentForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BFCMD50\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True";
        private int teacherId;
        public AddAssignmentForm(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            LoadDisciplinesAsync();
            LoadGroupsAsync();
        }
        private async void LoadDisciplinesAsync()
        {
            try
            {
                var disciplines = await GetDisciplinesAsync(teacherId);
                cbDisciplines.DataSource = disciplines;
                cbDisciplines.DisplayMember = "DisciplineName";
                cbDisciplines.ValueMember = "DisciplineID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading disciplines: " + ex.Message);
            }
        }

        private async void LoadGroupsAsync()
        {
            try
            {
                var groups = await GetGroupsAsync();
                cbGroups.DataSource = groups;
                cbGroups.DisplayMember = "GroupName";
                cbGroups.ValueMember = "GroupID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading groups: " + ex.Message);
            }
        }

        private async Task<DataTable> GetDisciplinesAsync(int teacherId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Disciplines WHERE TeacherID = @TeacherID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TeacherID", teacherId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                await connection.OpenAsync();
                adapter.Fill(dt);
                return dt;
            }
        }

        private async Task<DataTable> GetGroupsAsync()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Groups";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                await connection.OpenAsync();
                adapter.Fill(dt);
                return dt;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private async void btnAddAssignment_Click(object sender, EventArgs e)
        {
            if (cbDisciplines.SelectedValue == null || cbGroups.SelectedValue == null || string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                MessageBox.Show("Please select discipline, group, and file.");
                return;
            }

            int disciplineId = (int)cbDisciplines.SelectedValue;
            int groupId = (int)cbGroups.SelectedValue;
            string filePath = txtFilePath.Text;
            DateTime dateAdded = DateTime.Now;

            try
            {
                await AddAssignmentAsync(disciplineId, groupId, filePath, dateAdded);
                MessageBox.Show("Assignment added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding assignment: " + ex.Message);
            }
        }

        private async Task AddAssignmentAsync(int disciplineId, int groupId, string filePath, DateTime dateAdded)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Assignments (DisciplineID, GroupID, FilePath, DateAdded) VALUES (@DisciplineID, @GroupID, @FilePath, @DateAdded)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DisciplineID", disciplineId);
                cmd.Parameters.AddWithValue("@GroupID", groupId);
                cmd.Parameters.AddWithValue("@FilePath", filePath);
                cmd.Parameters.AddWithValue("@DateAdded", dateAdded);

                await connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
