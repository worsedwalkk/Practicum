namespace Practicum
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAssignments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddGroup = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDiscipline = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAssignment = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewReports = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAssignments
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvAssignments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAssignments.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignments.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAssignments.EnableHeadersVisualStyles = false;
            this.dgvAssignments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAssignments.Location = new System.Drawing.Point(12, 12);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.RowHeadersVisible = false;
            this.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignments.Size = new System.Drawing.Size(600, 300);
            this.dgvAssignments.TabIndex = 0;
            this.dgvAssignments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvAssignments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAssignments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAssignments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAssignments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAssignments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAssignments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAssignments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAssignments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAssignments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAssignments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAssignments.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvAssignments.ThemeStyle.ReadOnly = false;
            this.dgvAssignments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAssignments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAssignments.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAssignments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAssignments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.CheckedState.Parent = this.btnAddGroup;
            this.btnAddGroup.CustomImages.Parent = this.btnAddGroup;
            this.btnAddGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.HoverState.Parent = this.btnAddGroup;
            this.btnAddGroup.Location = new System.Drawing.Point(618, 12);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.ShadowDecoration.Parent = this.btnAddGroup;
            this.btnAddGroup.Size = new System.Drawing.Size(180, 45);
            this.btnAddGroup.TabIndex = 1;
            this.btnAddGroup.Text = "Добавить группу";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnAddDiscipline
            // 
            this.btnAddDiscipline.CheckedState.Parent = this.btnAddDiscipline;
            this.btnAddDiscipline.CustomImages.Parent = this.btnAddDiscipline;
            this.btnAddDiscipline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDiscipline.ForeColor = System.Drawing.Color.White;
            this.btnAddDiscipline.HoverState.Parent = this.btnAddDiscipline;
            this.btnAddDiscipline.Location = new System.Drawing.Point(618, 96);
            this.btnAddDiscipline.Name = "btnAddDiscipline";
            this.btnAddDiscipline.ShadowDecoration.Parent = this.btnAddDiscipline;
            this.btnAddDiscipline.Size = new System.Drawing.Size(180, 45);
            this.btnAddDiscipline.TabIndex = 2;
            this.btnAddDiscipline.Text = "Добавить дисциплину";
            this.btnAddDiscipline.Click += new System.EventHandler(this.btnAddDiscipline_Click);
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.CheckedState.Parent = this.btnAddAssignment;
            this.btnAddAssignment.CustomImages.Parent = this.btnAddAssignment;
            this.btnAddAssignment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAssignment.ForeColor = System.Drawing.Color.White;
            this.btnAddAssignment.HoverState.Parent = this.btnAddAssignment;
            this.btnAddAssignment.Location = new System.Drawing.Point(618, 179);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.ShadowDecoration.Parent = this.btnAddAssignment;
            this.btnAddAssignment.Size = new System.Drawing.Size(180, 45);
            this.btnAddAssignment.TabIndex = 3;
            this.btnAddAssignment.Text = "Добавить работы";
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.CheckedState.Parent = this.btnViewReports;
            this.btnViewReports.CustomImages.Parent = this.btnViewReports;
            this.btnViewReports.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewReports.ForeColor = System.Drawing.Color.White;
            this.btnViewReports.HoverState.Parent = this.btnViewReports;
            this.btnViewReports.Location = new System.Drawing.Point(618, 267);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.ShadowDecoration.Parent = this.btnViewReports;
            this.btnViewReports.Size = new System.Drawing.Size(180, 45);
            this.btnViewReports.TabIndex = 4;
            this.btnViewReports.Text = "Просмотр отчётов";
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnAddAssignment);
            this.Controls.Add(this.btnAddDiscipline);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.dgvAssignments);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAssignments;
        private Guna.UI2.WinForms.Guna2Button btnAddGroup;
        private Guna.UI2.WinForms.Guna2Button btnAddDiscipline;
        private Guna.UI2.WinForms.Guna2Button btnAddAssignment;
        private Guna.UI2.WinForms.Guna2Button btnViewReports;
    }
}