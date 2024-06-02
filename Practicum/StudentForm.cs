using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            SetupDataGridView();
            if (this.studentId <= 0)
            {
                MessageBox.Show("Неправильный ID студента.");
                this.Close();
                return;
            }
            LoadDisciplinesAsync();
        }

        private void SetupDataGridView()
        {
            // Устанавливаем шрифт для ячеек и заголовков
            dgvAssignments.DefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            dgvAssignments.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
        }
        // Загружаем дисциплины
        private async void LoadDisciplinesAsync()
        {
            try
            {
                groupId = await GetStudentGroupIdAsync(studentId);
                var disciplines = await GetDisciplinesAsync(groupId);
                cbDisciplines.DataSource = disciplines;
                cbDisciplines.DisplayMember = "DisciplineName";
                cbDisciplines.ValueMember = "DisciplineID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки дисциплин: " + ex.Message);
            }
        }
        // Получаем группу студента
        private async Task<int> GetStudentGroupIdAsync(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT GroupID FROM Students WHERE StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                await connection.OpenAsync();
                object result = await cmd.ExecuteScalarAsync();

                if (result == null || result == DBNull.Value)
                {
                    MessageBox.Show($"Группа не найдена для студента с ID: {studentId}");
                    throw new Exception("Group not found");
                }

                int groupId = (int)result;
                return groupId;
            }
        }
        // Отображение информации
        private async Task<DataTable> GetDisciplinesAsync(int groupId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT d.DisciplineID, d.DisciplineName FROM Disciplines d " +
                               "INNER JOIN Assignments a ON d.DisciplineID = a.DisciplineID " +
                               "WHERE a.GroupID = @GroupID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@GroupID", groupId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                await connection.OpenAsync();
                adapter.Fill(dt);
                return dt;
            }
        }
        // Загрузка работ 
        private async void LoadAssignmentsAsync()
        {
            if (cbDisciplines.SelectedValue == null)
                return;

            int disciplineId;

            // Проверяем, является ли SelectedValue объектом DataRowView
            if (cbDisciplines.SelectedValue is DataRowView rowView)
            {
                disciplineId = Convert.ToInt32(rowView["DisciplineID"]);
            }
            else
            {
                // Если SelectedValue не является DataRowView, попробуем выполнить прямое преобразование
                if (!int.TryParse(cbDisciplines.SelectedValue.ToString(), out disciplineId))
                {
                    MessageBox.Show("Не удалось определить дисциплину.");
                    return;
                }
            }

            try
            {
                var assignments = await GetAssignmentsAsync(disciplineId, groupId);
                dgvAssignments.DataSource = assignments;
                SetColumnHeaders();
                dgvAssignments.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки работ: " + ex.Message);
            }
        }
        // Устанавливаем названия для ячеек и заголовков
        private void SetColumnHeaders()
        {
            if (dgvAssignments.Columns["AssignmentID"] != null)
                dgvAssignments.Columns["AssignmentID"].HeaderText = "ID задания";
            if (dgvAssignments.Columns["DisciplineName"] != null)
                dgvAssignments.Columns["DisciplineName"].HeaderText = "Название дисциплины";
            if (dgvAssignments.Columns["GroupName"] != null)
                dgvAssignments.Columns["GroupName"].HeaderText = "Название группы";
            if (dgvAssignments.Columns["FilePath"] != null)
                dgvAssignments.Columns["FilePath"].HeaderText = "Работа";
            if (dgvAssignments.Columns["DateAdded"] != null)
                dgvAssignments.Columns["DateAdded"].HeaderText = "Дата добавления";
        }

        private async Task<DataTable> GetAssignmentsAsync(int disciplineId, int groupId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT a.AssignmentID, d.DisciplineName, g.GroupName, a.FilePath, a.DateAdded " +
                               "FROM Assignments a " +
                               "INNER JOIN Disciplines d ON a.DisciplineID = d.DisciplineID " +
                               "INNER JOIN Groups g ON a.GroupID = g.GroupID " +
                               "WHERE a.DisciplineID = @DisciplineID AND a.GroupID = @GroupID";
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

        private async void btnUploadReport_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста выберите файл.");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                int assignmentId = (int)dgvAssignments.SelectedRows[0].Cells["AssignmentID"].Value;
                DateTime dateUploaded = DateTime.Now;

                try
                {
                    await UploadReportAsync(studentId, assignmentId, filePath, dateUploaded);
                    MessageBox.Show("Работа добавлена.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки работы: " + ex.Message);
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

        private void dgvAssignments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAssignments.Rows.Count)
            {
                string filePath = dgvAssignments.Rows[e.RowIndex].Cells["FilePath"].Value.ToString();
                System.Diagnostics.Process.Start(filePath);
            }
        }

        private void cbDisciplines_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAssignmentsAsync();
        }
    }
}
