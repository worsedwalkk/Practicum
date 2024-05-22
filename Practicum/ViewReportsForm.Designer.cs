namespace Practicum
{
    partial class ViewReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cbGroups = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvReports = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDownloadReport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(16, 30);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(42, 13);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Группа";
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
            this.cbGroups.Location = new System.Drawing.Point(69, 16);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.ShadowDecoration.Parent = this.cbGroups;
            this.cbGroups.Size = new System.Drawing.Size(140, 36);
            this.cbGroups.TabIndex = 1;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // dgvReports
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.BackgroundColor = System.Drawing.Color.White;
            this.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReports.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReports.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReports.EnableHeadersVisualStyles = false;
            this.dgvReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReports.Location = new System.Drawing.Point(19, 77);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(600, 250);
            this.dgvReports.TabIndex = 2;
            this.dgvReports.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReports.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReports.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReports.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReports.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReports.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReports.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReports.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReports.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvReports.ThemeStyle.ReadOnly = false;
            this.dgvReports.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReports.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReports.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReports.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReports.ThemeStyle.RowsStyle.Height = 22;
            this.dgvReports.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReports.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnDownloadReport
            // 
            this.btnDownloadReport.CheckedState.Parent = this.btnDownloadReport;
            this.btnDownloadReport.CustomImages.Parent = this.btnDownloadReport;
            this.btnDownloadReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDownloadReport.ForeColor = System.Drawing.Color.White;
            this.btnDownloadReport.HoverState.Parent = this.btnDownloadReport;
            this.btnDownloadReport.Location = new System.Drawing.Point(19, 356);
            this.btnDownloadReport.Name = "btnDownloadReport";
            this.btnDownloadReport.ShadowDecoration.Parent = this.btnDownloadReport;
            this.btnDownloadReport.Size = new System.Drawing.Size(180, 45);
            this.btnDownloadReport.TabIndex = 3;
            this.btnDownloadReport.Text = "Скачать отчёт";
            this.btnDownloadReport.Click += new System.EventHandler(this.btnDownloadReport_Click);
            // 
            // ViewReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDownloadReport);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.cbGroups);
            this.Controls.Add(this.lblGroup);
            this.Name = "ViewReportsForm";
            this.Text = "ViewReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroup;
        private Guna.UI2.WinForms.Guna2ComboBox cbGroups;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReports;
        private Guna.UI2.WinForms.Guna2Button btnDownloadReport;
    }
}