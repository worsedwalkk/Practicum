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
    public partial class AddDisciplineForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BFCMD50\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True";
        private int teacherId;
        public AddDisciplineForm(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
        }

        private async void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            string disciplineName = txtDisciplineName.Text;
            if (string.IsNullOrWhiteSpace(disciplineName))
            {
                MessageBox.Show("Пожалуйста введите название дисциплины!");
                return;
            }

            try
            {
                await AddDisciplineAsync(disciplineName, teacherId);
                MessageBox.Show("Дисциплина успешно добавлена.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибки добавления дисциплины: " + ex.Message);
            }
        }

        private async Task AddDisciplineAsync(string disciplineName, int teacherId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Disciplines (DisciplineName, TeacherID) VALUES (@DisciplineName, @TeacherID)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DisciplineName", disciplineName);
                cmd.Parameters.AddWithValue("@TeacherID", teacherId);

                await connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
