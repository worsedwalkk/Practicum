namespace Practicum
{
    partial class AddDisciplineForm
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
            this.btnAddDiscipline = new Guna.UI2.WinForms.Guna2Button();
            this.txtDisciplineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDisciplineName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddDiscipline
            // 
            this.btnAddDiscipline.CheckedState.Parent = this.btnAddDiscipline;
            this.btnAddDiscipline.CustomImages.Parent = this.btnAddDiscipline;
            this.btnAddDiscipline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDiscipline.ForeColor = System.Drawing.Color.White;
            this.btnAddDiscipline.HoverState.Parent = this.btnAddDiscipline;
            this.btnAddDiscipline.Location = new System.Drawing.Point(489, 86);
            this.btnAddDiscipline.Name = "btnAddDiscipline";
            this.btnAddDiscipline.ShadowDecoration.Parent = this.btnAddDiscipline;
            this.btnAddDiscipline.Size = new System.Drawing.Size(180, 45);
            this.btnAddDiscipline.TabIndex = 5;
            this.btnAddDiscipline.Text = "Добавить дисциплину";
            this.btnAddDiscipline.Click += new System.EventHandler(this.btnAddDiscipline_Click);
            // 
            // txtDisciplineName
            // 
            this.txtDisciplineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisciplineName.DefaultText = "";
            this.txtDisciplineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDisciplineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDisciplineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDisciplineName.DisabledState.Parent = this.txtDisciplineName;
            this.txtDisciplineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDisciplineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDisciplineName.FocusedState.Parent = this.txtDisciplineName;
            this.txtDisciplineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDisciplineName.HoverState.Parent = this.txtDisciplineName;
            this.txtDisciplineName.Location = new System.Drawing.Point(191, 107);
            this.txtDisciplineName.Name = "txtDisciplineName";
            this.txtDisciplineName.PasswordChar = '\0';
            this.txtDisciplineName.PlaceholderText = "";
            this.txtDisciplineName.SelectedText = "";
            this.txtDisciplineName.ShadowDecoration.Parent = this.txtDisciplineName;
            this.txtDisciplineName.Size = new System.Drawing.Size(200, 36);
            this.txtDisciplineName.TabIndex = 4;
            // 
            // lblDisciplineName
            // 
            this.lblDisciplineName.AutoSize = true;
            this.lblDisciplineName.Location = new System.Drawing.Point(43, 119);
            this.lblDisciplineName.Name = "lblDisciplineName";
            this.lblDisciplineName.Size = new System.Drawing.Size(122, 13);
            this.lblDisciplineName.TabIndex = 3;
            this.lblDisciplineName.Text = "Название дисциплины";
            // 
            // AddDisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddDiscipline);
            this.Controls.Add(this.txtDisciplineName);
            this.Controls.Add(this.lblDisciplineName);
            this.Name = "AddDisciplineForm";
            this.Text = "AddDisciplineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddDiscipline;
        private Guna.UI2.WinForms.Guna2TextBox txtDisciplineName;
        private System.Windows.Forms.Label lblDisciplineName;
    }
}