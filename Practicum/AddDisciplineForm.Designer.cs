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
            this.components = new System.ComponentModel.Container();
            this.btnAddDiscipline = new Guna.UI2.WinForms.Guna2Button();
            this.txtDisciplineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // btnAddDiscipline
            // 
            this.btnAddDiscipline.AutoRoundedCorners = true;
            this.btnAddDiscipline.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDiscipline.BorderColor = System.Drawing.Color.Snow;
            this.btnAddDiscipline.BorderRadius = 30;
            this.btnAddDiscipline.BorderThickness = 3;
            this.btnAddDiscipline.FillColor = System.Drawing.Color.Transparent;
            this.btnAddDiscipline.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddDiscipline.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnAddDiscipline.Location = new System.Drawing.Point(85, 142);
            this.btnAddDiscipline.Name = "btnAddDiscipline";
            this.btnAddDiscipline.Size = new System.Drawing.Size(299, 63);
            this.btnAddDiscipline.TabIndex = 5;
            this.btnAddDiscipline.Text = "Добавить дисциплину";
            this.btnAddDiscipline.Click += new System.EventHandler(this.btnAddDiscipline_Click);
            // 
            // txtDisciplineName
            // 
            this.txtDisciplineName.AutoRoundedCorners = true;
            this.txtDisciplineName.BackColor = System.Drawing.Color.Transparent;
            this.txtDisciplineName.BorderColor = System.Drawing.Color.Snow;
            this.txtDisciplineName.BorderRadius = 27;
            this.txtDisciplineName.BorderThickness = 3;
            this.txtDisciplineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisciplineName.DefaultText = "";
            this.txtDisciplineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDisciplineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDisciplineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDisciplineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDisciplineName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDisciplineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDisciplineName.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtDisciplineName.ForeColor = System.Drawing.Color.PapayaWhip;
            this.txtDisciplineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDisciplineName.Location = new System.Drawing.Point(12, 46);
            this.txtDisciplineName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDisciplineName.Name = "txtDisciplineName";
            this.txtDisciplineName.PasswordChar = '\0';
            this.txtDisciplineName.PlaceholderForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDisciplineName.PlaceholderText = "Название дисциплины:";
            this.txtDisciplineName.SelectedText = "";
            this.txtDisciplineName.Size = new System.Drawing.Size(443, 57);
            this.txtDisciplineName.TabIndex = 4;
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
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.CustomIconSize = 50F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(440, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(25, 28);
            this.guna2ControlBox1.TabIndex = 20;
            // 
            // AddDisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::Practicum.Properties.Resources._189271609765514;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 242);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnAddDiscipline);
            this.Controls.Add(this.txtDisciplineName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(469, 242);
            this.MinimumSize = new System.Drawing.Size(469, 242);
            this.Name = "AddDisciplineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDisciplineForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddDiscipline;
        private Guna.UI2.WinForms.Guna2TextBox txtDisciplineName;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}