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
    public partial class ViewReportsForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BFCMD50\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True";
        private int teacherId;
        public ViewReportsForm(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            LoadGroups();
            cbGroups.SelectedIndexChanged += cbGroups_SelectedIndexChanged;
        }
        private void LoadGroups()
        {
            DataTable groupsDataTable = GetGroupsDataTable();

            cbGroups.DisplayMember = "GroupName";
            cbGroups.ValueMember = "GroupID";
            cbGroups.DataSource = groupsDataTable;
        }

        private DataTable GetGroupsDataTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT GroupID, GroupName FROM Groups";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroups.SelectedValue != null)
            {
                try
                {
                    int groupId = Convert.ToInt32(cbGroups.SelectedValue);
                    LoadReportsAsync(groupId);
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show($"Ошибка приведения значения: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Ошибка формата значения: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
        }
        private async Task LoadReportsAsync(int groupId)
        {
            // Пример асинхронной загрузки отчетов для выбранной группы
            // В этом примере используется простой DataGridView для отображения отчетов
            DataTable reportsDataTable = await GetReportsDataTableAsync(groupId);
            dgvReports.DataSource = reportsDataTable;
        }

        private async Task<DataTable> GetReportsDataTableAsync(int groupId)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT r.ReportID, r.StudentID, r.AssignmentID, r.FilePath, r.DateUploaded
                FROM Reports r
                INNER JOIN Assignments a ON r.AssignmentID = a.AssignmentID
                WHERE a.GroupID = @GroupID";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@GroupID", groupId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                await Task.Run(() => adapter.Fill(dataTable));
            }

            return dataTable;
        }


        private void btnDownloadReport_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count > 0)
            {
                string filePath = dgvReports.SelectedRows[0].Cells["FilePath"].Value.ToString();
                System.Diagnostics.Process.Start(filePath);
            }
        }
    }
}
