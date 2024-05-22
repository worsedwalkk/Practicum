namespace Practicum
{
    partial class AddAssignmentForm
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
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.cbDisciplines = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbGroups = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSelectFile = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAssignment = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(10, 10);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(119, 13);
            this.lblDiscipline.TabIndex = 0;
            this.lblDiscipline.Text = "Выберите дисциплину";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(10, 92);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(93, 13);
            this.lblGroup.TabIndex = 1;
            this.lblGroup.Text = "Выберите группу";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(17, 182);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(86, 13);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "Выберите файл";
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
            this.cbDisciplines.Location = new System.Drawing.Point(152, 10);
            this.cbDisciplines.Name = "cbDisciplines";
            this.cbDisciplines.ShadowDecoration.Parent = this.cbDisciplines;
            this.cbDisciplines.Size = new System.Drawing.Size(140, 36);
            this.cbDisciplines.TabIndex = 3;
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
            this.cbGroups.Location = new System.Drawing.Point(152, 92);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.ShadowDecoration.Parent = this.cbGroups;
            this.cbGroups.Size = new System.Drawing.Size(140, 36);
            this.cbGroups.TabIndex = 4;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.DefaultText = "";
            this.txtFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.DisabledState.Parent = this.txtFilePath;
            this.txtFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.FocusedState.Parent = this.txtFilePath;
            this.txtFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.HoverState.Parent = this.txtFilePath;
            this.txtFilePath.Location = new System.Drawing.Point(142, 170);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.PlaceholderText = "";
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.ShadowDecoration.Parent = this.txtFilePath;
            this.txtFilePath.Size = new System.Drawing.Size(200, 36);
            this.txtFilePath.TabIndex = 5;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.CheckedState.Parent = this.btnSelectFile;
            this.btnSelectFile.CustomImages.Parent = this.btnSelectFile;
            this.btnSelectFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.HoverState.Parent = this.btnSelectFile;
            this.btnSelectFile.Location = new System.Drawing.Point(375, 161);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.ShadowDecoration.Parent = this.btnSelectFile;
            this.btnSelectFile.Size = new System.Drawing.Size(180, 45);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "Выбрать файл";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.CheckedState.Parent = this.btnAddAssignment;
            this.btnAddAssignment.CustomImages.Parent = this.btnAddAssignment;
            this.btnAddAssignment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAssignment.ForeColor = System.Drawing.Color.White;
            this.btnAddAssignment.HoverState.Parent = this.btnAddAssignment;
            this.btnAddAssignment.Location = new System.Drawing.Point(323, 312);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.ShadowDecoration.Parent = this.btnAddAssignment;
            this.btnAddAssignment.Size = new System.Drawing.Size(180, 45);
            this.btnAddAssignment.TabIndex = 7;
            this.btnAddAssignment.Text = "Добавить работу";
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // AddAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddAssignment);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.cbGroups);
            this.Controls.Add(this.cbDisciplines);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblDiscipline);
            this.Name = "AddAssignmentForm";
            this.Text = "AddAssignmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblFilePath;
        private Guna.UI2.WinForms.Guna2ComboBox cbDisciplines;
        private Guna.UI2.WinForms.Guna2ComboBox cbGroups;
        private Guna.UI2.WinForms.Guna2TextBox txtFilePath;
        private Guna.UI2.WinForms.Guna2Button btnSelectFile;
        private Guna.UI2.WinForms.Guna2Button btnAddAssignment;
    }
}