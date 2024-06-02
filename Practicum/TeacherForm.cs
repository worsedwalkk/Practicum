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
            SetupDataGridView();
            // Запуск асинхронной инициализации
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await LoadAssignmentsAsync(teacherId);
            await LoadGroupsAsync();
        }

        private void SetupDataGridView()
        {

            // Устанавливаем шрифт для ячеек и заголовков
            dgvAssignments.DefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvAssignments.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);

        }
        private async Task LoadGroupsAsync()
        {
            try
            {
                var groups = await GetGroupsAsync();
                cbGroup.DataSource = groups;
                cbGroup.DisplayMember = "GroupName";
                cbGroup.ValueMember = "GroupID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки групп: " + ex.Message);
            }
        }

        private async Task<DataTable> GetGroupsAsync()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Groups";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                await connection.OpenAsync();
                adapter.Fill(dt);
                return dt;
            }
        }

        private async Task LoadAssignmentsAsync(int teacherId, int? groupId = null)
        {
            try
            {
                var assignments = await GetAssignmentsAsync(teacherId, groupId);
                dgvAssignments.DataSource = assignments;
                SetColumnHeaders();
                dgvAssignments.Refresh(); // Обновление DataGridView после загрузки данных
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки работ: " + ex.Message);
            }
        }

        private async Task<DataTable> GetAssignmentsAsync(int teacherId, int? groupId = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT d.DisciplineName, g.GroupName, a.AssignmentID, a.FilePath, a.DateAdded " +
                               "FROM Assignments a " +
                               "INNER JOIN Disciplines d ON a.DisciplineID = d.DisciplineID " +
                               "INNER JOIN Groups g ON a.GroupID = g.GroupID " +
                               "WHERE d.TeacherID = @TeacherID";

                if (groupId.HasValue)
                {
                    query += " AND a.GroupID = @GroupID";
                }

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TeacherID", teacherId);

                if (groupId.HasValue)
                {
                    cmd.Parameters.AddWithValue("@GroupID", groupId.Value);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                await connection.OpenAsync();
                adapter.Fill(dt);
                return dt;
            }
        }

        

        private void SetColumnHeaders()
        {
            if (dgvAssignments.Columns["DisciplineName"] != null)
                dgvAssignments.Columns["DisciplineName"].HeaderText = "Название дисциплины";
            if (dgvAssignments.Columns["GroupName"] != null)
                dgvAssignments.Columns["GroupName"].HeaderText = "Название группы";
            if (dgvAssignments.Columns["AssignmentID"] != null)
                dgvAssignments.Columns["AssignmentID"].HeaderText = "Номер задания";
            if (dgvAssignments.Columns["FilePath"] != null)
                dgvAssignments.Columns["FilePath"].HeaderText = "Работа";
            if (dgvAssignments.Columns["DateAdded"] != null)
                dgvAssignments.Columns["DateAdded"].HeaderText = "Дата добавления";
        }
        public async Task ReloadGroupsAsync()
        {
            await LoadGroupsAsync();
            cbGroup.SelectedIndex = cbGroup.Items.Count - 1; // Выбираем последнюю добавленную группу
        }


        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm(this);
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
            addAssignmentForm.AssignmentAdded += AddAssignmentForm_AssignmentAdded; // Подписываемся на событие
            addAssignmentForm.ShowDialog();
        }
        private async void AddAssignmentForm_AssignmentAdded(object sender, EventArgs e)
        {
            // Обновляем dgvAssignments при добавлении нового задания
            await LoadAssignmentsAsync(teacherId);
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            ViewReportsForm viewReportsForm = new ViewReportsForm(teacherId);
            viewReportsForm.ShowDialog();
        }

        private async void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroup.SelectedValue != null && cbGroup.SelectedValue is int)
            {
                int groupId = (int)cbGroup.SelectedValue;
                await LoadAssignmentsAsync(teacherId, groupId);
            }
        }

        private void dgvAssignments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvAssignments.Columns["FilePath"].Index)
                {
                    string filePath = dgvAssignments.Rows[e.RowIndex].Cells["FilePath"].Value.ToString();
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(filePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка открытия файла: " + ex.Message);
                        }
                    }
                }
            }
        }

        private async void btnDeleteAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count > 0)
            {
                int assignmentId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["AssignmentID"].Value);
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранное задание?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "DELETE FROM Assignments WHERE AssignmentID = @AssignmentID";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@AssignmentID", assignmentId);
                            await connection.OpenAsync();
                            await cmd.ExecuteNonQueryAsync();
                        }

                        // Удаление из DataGridView
                        dgvAssignments.Rows.RemoveAt(dgvAssignments.SelectedRows[0].Index);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении задания: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите задание для удаления.");
            }
        }
    }
}
