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
    public partial class StudentForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BFCMD50\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True";
        private int studentId;
        private int groupId;

        public StudentForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadGroupsAsync();
        }
        private async void LoadGroupsAsync()
        {
            try
            {
                groupId = await GetStudentGroupIdAsync(studentId);
                var groups = await GetGroupsAsync();
                cbGroups.DataSource = groups;
                cbGroups.DisplayMember = "GroupName";
                cbGroups.ValueMember = "GroupID";
                cbGroups.SelectedValue = groupId;
                LoadDisciplinesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading groups: " + ex.Message);
            }
        }

        private async Task<int> GetStudentGroupIdAsync(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT GroupID FROM Students WHERE StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                await connection.OpenAsync();
                return (int)await cmd.ExecuteScalarAsync();
            }
        }

        private async Task<DataTable> GetGroupsAsync()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT GroupID, GroupName FROM Groups";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                await connection.OpenAsync();
                adapter.Fill(dt);
                return dt;
            }
        }

        private async void LoadDisciplinesAsync()
        {
            try
            {
                var disciplines = await GetDisciplinesAsync(groupId);
                cbDisciplines.DataSource = disciplines;
                cbDisciplines.DisplayMember = "DisciplineName";
                cbDisciplines.ValueMember = "DisciplineID";
                LoadAssignmentsAsync(); // Ensure assignments load initially
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading disciplines: " + ex.Message);
            }
        }

        private async Task<DataTable> GetDisciplinesAsync(int groupId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT d.DisciplineID, d.DisciplineName
                FROM Disciplines d
                INNER JOIN Assignments a ON d.DisciplineID = a.DisciplineID
                WHERE a.GroupID = @GroupID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@GroupID", groupId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                await connection.OpenAsync();
                adapter.Fill(dt);
                return dt;
            }
        }

        private async void LoadAssignmentsAsync()
        {
            if (cbDisciplines.SelectedValue == null)
                return;

            int disciplineId = Convert.ToInt32(cbDisciplines.SelectedValue);

            try
            {
                var assignments = await GetAssignmentsAsync(disciplineId, groupId);
                dgvAssignments.DataSource = assignments;

                // Ensure columns are auto-generated
                dgvAssignments.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assignments: " + ex.Message);
            }
        }

        private async Task<DataTable> GetAssignmentsAsync(int disciplineId, int groupId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Assignments WHERE DisciplineID = @DisciplineID AND GroupID = @GroupID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DisciplineID", disciplineId);
                cmd.Parameters.AddWithValue("@GroupID", groupId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                await connection.OpenAsync();
                adapter.Fill(dt);
                return dt;
            }
        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroups.SelectedValue != null && int.TryParse(cbGroups.SelectedValue.ToString(), out groupId))
            {
                LoadDisciplinesAsync();
            }
        }

        private void cbDisciplines_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAssignmentsAsync();
        }

        private void btnDownloadAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count > 0)
            {
                string filePath = dgvAssignments.SelectedRows[0].Cells["FilePath"].Value.ToString();
                System.Diagnostics.Process.Start(filePath);
            }
        }

        private async void btnUploadReport_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment.");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files|*.pdf"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                int assignmentId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["AssignmentID"].Value);
                DateTime dateUploaded = DateTime.Now;

                try
                {
                    await UploadReportAsync(studentId, assignmentId, filePath, dateUploaded);
                    MessageBox.Show("Report uploaded successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading report: " + ex.Message);
                }
            }
        }

        private async Task UploadReportAsync(int studentId, int assignmentId, string filePath, DateTime dateUploaded)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Reports (StudentID, AssignmentID, FilePath, DateUploaded) VALUES (@StudentID, @AssignmentID, @FilePath, @DateUploaded)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentId);
                cmd.Parameters.AddWithValue("@FilePath", filePath);
                cmd.Parameters.AddWithValue("@DateUploaded", dateUploaded);

                await connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
