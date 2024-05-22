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
    public partial class TeacherForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BFCMD50\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True";
        private int teacherId;

        public TeacherForm(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            LoadAssignmentsAsync();
        }
        private async void LoadAssignmentsAsync()
        {
            try
            {
                var assignments = await GetAssignmentsAsync(teacherId);
                dgvAssignments.DataSource = assignments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assignments: " + ex.Message);
            }
        }

        private async Task<DataTable> GetAssignmentsAsync(int teacherId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Assignments WHERE DisciplineID IN (SELECT DisciplineID FROM Disciplines WHERE TeacherID = @TeacherID)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TeacherID", teacherId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                await connection.OpenAsync();
                adapter.Fill(dt);
                return dt;
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm();
            addGroupForm.ShowDialog();
        }

        private void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            AddDisciplineForm addDisciplineForm = new AddDisciplineForm(teacherId);
            addDisciplineForm.ShowDialog();
        }

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            AddAssignmentForm addAssignmentForm = new AddAssignmentForm(teacherId);
            addAssignmentForm.ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            ViewReportsForm viewReportsForm = new ViewReportsForm(teacherId);
            viewReportsForm.ShowDialog();
        }
    }
}
