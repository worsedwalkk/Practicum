namespace Practicum
{
    partial class StudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.cbGroups = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDisciplines = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvAssignments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDownloadAssignment = new Guna.UI2.WinForms.Guna2Button();
            this.btnUploadReport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(23, 15);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(42, 13);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Группа";
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(9, 67);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(70, 13);
            this.lblDiscipline.TabIndex = 1;
            this.lblDiscipline.Text = "Дисциплина";
            // 
            // cbGroups
            // 
            this.cbGroups.BackColor = System.Drawing.Color.Transparent;
            this.cbGroups.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroups.FocusedColor = System.Drawing.Color.Empty;
            this.cbGroups.FocusedState.Parent = this.cbGroups;
            this.cbGroups.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.HoverState.Parent = this.cbGroups;
            this.cbGroups.ItemHeight = 30;
            this.cbGroups.ItemsAppearance.Parent = this.cbGroups;
            this.cbGroups.Location = new System.Drawing.Point(86, 3);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.ShadowDecoration.Parent = this.cbGroups;
            this.cbGroups.Size = new System.Drawing.Size(140, 36);
            this.cbGroups.TabIndex = 6;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // cbDisciplines
            // 
            this.cbDisciplines.BackColor = System.Drawing.Color.Transparent;
            this.cbDisciplines.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDisciplines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplines.FocusedColor = System.Drawing.Color.Empty;
            this.cbDisciplines.FocusedState.Parent = this.cbDisciplines;
            this.cbDisciplines.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDisciplines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDisciplines.FormattingEnabled = true;
            this.cbDisciplines.HoverState.Parent = this.cbDisciplines;
            this.cbDisciplines.ItemHeight = 30;
            this.cbDisciplines.ItemsAppearance.Parent = this.cbDisciplines;
            this.cbDisciplines.Location = new System.Drawing.Point(82, 57);
            this.cbDisciplines.Name = "cbDisciplines";
            this.cbDisciplines.ShadowDecoration.Parent = this.cbDisciplines;
            this.cbDisciplines.Size = new System.Drawing.Size(140, 36);
            this.cbDisciplines.TabIndex = 5;
            // 
            // dgvAssignments
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvAssignments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAssignments.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignments.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAssignments.EnableHeadersVisualStyles = false;
            this.dgvAssignments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAssignments.Location = new System.Drawing.Point(12, 105);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.RowHeadersVisible = false;
            this.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignments.Size = new System.Drawing.Size(600, 200);
            this.dgvAssignments.TabIndex = 7;
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
            // btnDownloadAssignment
            // 
            this.btnDownloadAssignment.CheckedState.Parent = this.btnDownloadAssignment;
            this.btnDownloadAssignment.CustomImages.Parent = this.btnDownloadAssignment;
            this.btnDownloadAssignment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDownloadAssignment.ForeColor = System.Drawing.Color.White;
            this.btnDownloadAssignment.HoverState.Parent = this.btnDownloadAssignment;
            this.btnDownloadAssignment.Location = new System.Drawing.Point(12, 323);
            this.btnDownloadAssignment.Name = "btnDownloadAssignment";
            this.btnDownloadAssignment.ShadowDecoration.Parent = this.btnDownloadAssignment;
            this.btnDownloadAssignment.Size = new System.Drawing.Size(180, 45);
            this.btnDownloadAssignment.TabIndex = 8;
            this.btnDownloadAssignment.Text = "Скачать работу";
            this.btnDownloadAssignment.Click += new System.EventHandler(this.btnDownloadAssignment_Click);
            // 
            // btnUploadReport
            // 
            this.btnUploadReport.CheckedState.Parent = this.btnUploadReport;
            this.btnUploadReport.CustomImages.Parent = this.btnUploadReport;
            this.btnUploadReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadReport.ForeColor = System.Drawing.Color.White;
            this.btnUploadReport.HoverState.Parent = this.btnUploadReport;
            this.btnUploadReport.Location = new System.Drawing.Point(208, 323);
            this.btnUploadReport.Name = "btnUploadReport";
            this.btnUploadReport.ShadowDecoration.Parent = this.btnUploadReport;
            this.btnUploadReport.Size = new System.Drawing.Size(180, 45);
            this.btnUploadReport.TabIndex = 9;
            this.btnUploadReport.Text = "Загрузить отчёт";
            this.btnUploadReport.Click += new System.EventHandler(this.btnUploadReport_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.btnUploadReport);
            this.Controls.Add(this.btnDownloadAssignment);
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.cbGroups);
            this.Controls.Add(this.cbDisciplines);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.lblGroup);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblDiscipline;
        private Guna.UI2.WinForms.Guna2ComboBox cbGroups;
        private Guna.UI2.WinForms.Guna2ComboBox cbDisciplines;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAssignments;
        private Guna.UI2.WinForms.Guna2Button btnDownloadAssignment;
        private Guna.UI2.WinForms.Guna2Button btnUploadReport;
    }
}