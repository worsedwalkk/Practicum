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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAssignments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddGroup = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDiscipline = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAssignment = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewReports = new Guna.UI2.WinForms.Guna2Button();
            this.cbGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnDeleteAssignment = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.AllowUserToAddRows = false;
            this.dgvAssignments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAssignments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignments.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssignments.ColumnHeadersHeight = 45;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAssignments.GridColor = System.Drawing.Color.LightGray;
            this.dgvAssignments.Location = new System.Drawing.Point(12, 22);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.ReadOnly = true;
            this.dgvAssignments.RowHeadersVisible = false;
            this.dgvAssignments.RowHeadersWidth = 10;
            this.dgvAssignments.Size = new System.Drawing.Size(748, 290);
            this.dgvAssignments.TabIndex = 0;
            this.dgvAssignments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAssignments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAssignments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAssignments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAssignments.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvAssignments.ThemeStyle.GridColor = System.Drawing.Color.LightGray;
            this.dgvAssignments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAssignments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAssignments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAssignments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAssignments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAssignments.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvAssignments.ThemeStyle.ReadOnly = true;
            this.dgvAssignments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAssignments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAssignments.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAssignments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAssignments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAssignments.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignments_CellContentDoubleClick);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AutoRoundedCorners = true;
            this.btnAddGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnAddGroup.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnAddGroup.BorderRadius = 28;
            this.btnAddGroup.BorderThickness = 2;
            this.btnAddGroup.FillColor = System.Drawing.Color.Transparent;
            this.btnAddGroup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddGroup.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnAddGroup.Location = new System.Drawing.Point(12, 318);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(215, 58);
            this.btnAddGroup.TabIndex = 1;
            this.btnAddGroup.Text = "Добавить группу";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnAddDiscipline
            // 
            this.btnAddDiscipline.AutoRoundedCorners = true;
            this.btnAddDiscipline.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDiscipline.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnAddDiscipline.BorderRadius = 28;
            this.btnAddDiscipline.BorderThickness = 2;
            this.btnAddDiscipline.FillColor = System.Drawing.Color.Transparent;
            this.btnAddDiscipline.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddDiscipline.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnAddDiscipline.Location = new System.Drawing.Point(12, 382);
            this.btnAddDiscipline.Name = "btnAddDiscipline";
            this.btnAddDiscipline.Size = new System.Drawing.Size(243, 58);
            this.btnAddDiscipline.TabIndex = 2;
            this.btnAddDiscipline.Text = "Добавить дисциплину";
            this.btnAddDiscipline.Click += new System.EventHandler(this.btnAddDiscipline_Click);
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.AutoRoundedCorners = true;
            this.btnAddAssignment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAssignment.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnAddAssignment.BorderRadius = 28;
            this.btnAddAssignment.BorderThickness = 2;
            this.btnAddAssignment.FillColor = System.Drawing.Color.Transparent;
            this.btnAddAssignment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAssignment.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnAddAssignment.Location = new System.Drawing.Point(233, 318);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.Size = new System.Drawing.Size(243, 58);
            this.btnAddAssignment.TabIndex = 3;
            this.btnAddAssignment.Text = "Добавить работы";
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.AutoRoundedCorners = true;
            this.btnViewReports.BackColor = System.Drawing.Color.Transparent;
            this.btnViewReports.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnViewReports.BorderRadius = 28;
            this.btnViewReports.BorderThickness = 2;
            this.btnViewReports.FillColor = System.Drawing.Color.Transparent;
            this.btnViewReports.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnViewReports.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnViewReports.Location = new System.Drawing.Point(261, 382);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(215, 58);
            this.btnViewReports.TabIndex = 4;
            this.btnViewReports.Text = "Просмотр отчётов";
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.AutoRoundedCorners = true;
            this.cbGroup.BackColor = System.Drawing.Color.Transparent;
            this.cbGroup.BorderColor = System.Drawing.Color.PapayaWhip;
            this.cbGroup.BorderRadius = 17;
            this.cbGroup.BorderThickness = 2;
            this.cbGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbGroup.FocusedColor = System.Drawing.Color.Empty;
            this.cbGroup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGroup.ForeColor = System.Drawing.Color.PapayaWhip;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.ItemHeight = 30;
            this.cbGroup.Location = new System.Drawing.Point(544, 318);
            this.cbGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(216, 36);
            this.cbGroup.TabIndex = 5;
            this.cbGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(746, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(24, 18);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // btnDeleteAssignment
            // 
            this.btnDeleteAssignment.AutoRoundedCorners = true;
            this.btnDeleteAssignment.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAssignment.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnDeleteAssignment.BorderRadius = 28;
            this.btnDeleteAssignment.BorderThickness = 2;
            this.btnDeleteAssignment.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteAssignment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAssignment.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnDeleteAssignment.Location = new System.Drawing.Point(544, 382);
            this.btnDeleteAssignment.Name = "btnDeleteAssignment";
            this.btnDeleteAssignment.Size = new System.Drawing.Size(216, 58);
            this.btnDeleteAssignment.TabIndex = 7;
            this.btnDeleteAssignment.Text = "Удалить работу";
            this.btnDeleteAssignment.Click += new System.EventHandler(this.btnDeleteAssignment_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::Practicum.Properties.Resources._189271609765514;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 454);
            this.Controls.Add(this.btnDeleteAssignment);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnAddAssignment);
            this.Controls.Add(this.btnAddDiscipline);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.dgvAssignments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(772, 454);
            this.MinimumSize = new System.Drawing.Size(772, 454);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Guna.UI2.WinForms.Guna2ComboBox cbGroup;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAssignment;
    }
}