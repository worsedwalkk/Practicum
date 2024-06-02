﻿namespace Practicum
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
            this.components = new System.ComponentModel.Container();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.cbDisciplines = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbGroups = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSelectFile = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAssignment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscipline.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscipline.ForeColor = System.Drawing.Color.PapayaWhip;
            this.lblDiscipline.Location = new System.Drawing.Point(12, 22);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(259, 25);
            this.lblDiscipline.TabIndex = 0;
            this.lblDiscipline.Text = "Выберите дисциплину:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblGroup.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroup.ForeColor = System.Drawing.Color.PapayaWhip;
            this.lblGroup.Location = new System.Drawing.Point(12, 81);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(202, 25);
            this.lblGroup.TabIndex = 1;
            this.lblGroup.Text = "Выберите группу:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblFilePath.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilePath.ForeColor = System.Drawing.Color.PapayaWhip;
            this.lblFilePath.Location = new System.Drawing.Point(12, 145);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(189, 25);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "Выберите файл:";
            // 
            // cbDisciplines
            // 
            this.cbDisciplines.AutoRoundedCorners = true;
            this.cbDisciplines.BackColor = System.Drawing.Color.Transparent;
            this.cbDisciplines.BorderColor = System.Drawing.Color.PapayaWhip;
            this.cbDisciplines.BorderRadius = 17;
            this.cbDisciplines.BorderThickness = 2;
            this.cbDisciplines.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDisciplines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplines.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbDisciplines.FocusedColor = System.Drawing.Color.Empty;
            this.cbDisciplines.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDisciplines.ForeColor = System.Drawing.Color.PapayaWhip;
            this.cbDisciplines.FormattingEnabled = true;
            this.cbDisciplines.ItemHeight = 30;
            this.cbDisciplines.Location = new System.Drawing.Point(274, 22);
            this.cbDisciplines.Name = "cbDisciplines";
            this.cbDisciplines.Size = new System.Drawing.Size(288, 36);
            this.cbDisciplines.TabIndex = 3;
            // 
            // cbGroups
            // 
            this.cbGroups.AutoRoundedCorners = true;
            this.cbGroups.BackColor = System.Drawing.Color.Transparent;
            this.cbGroups.BorderColor = System.Drawing.Color.PapayaWhip;
            this.cbGroups.BorderRadius = 17;
            this.cbGroups.BorderThickness = 2;
            this.cbGroups.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroups.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbGroups.FocusedColor = System.Drawing.Color.Empty;
            this.cbGroups.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGroups.ForeColor = System.Drawing.Color.PapayaWhip;
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.ItemHeight = 30;
            this.cbGroups.Location = new System.Drawing.Point(274, 81);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(288, 36);
            this.cbGroups.TabIndex = 4;
            // 
            // txtFilePath
            // 
            this.txtFilePath.AutoRoundedCorners = true;
            this.txtFilePath.BackColor = System.Drawing.Color.Transparent;
            this.txtFilePath.BorderColor = System.Drawing.Color.PapayaWhip;
            this.txtFilePath.BorderRadius = 20;
            this.txtFilePath.BorderThickness = 2;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.DefaultText = "";
            this.txtFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtFilePath.ForeColor = System.Drawing.Color.PapayaWhip;
            this.txtFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.Location = new System.Drawing.Point(274, 136);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.PlaceholderText = "";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.Size = new System.Drawing.Size(288, 42);
            this.txtFilePath.TabIndex = 5;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.AutoRoundedCorners = true;
            this.btnSelectFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectFile.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnSelectFile.BorderRadius = 24;
            this.btnSelectFile.BorderThickness = 2;
            this.btnSelectFile.FillColor = System.Drawing.Color.Transparent;
            this.btnSelectFile.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnSelectFile.Location = new System.Drawing.Point(274, 185);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(288, 50);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "Добавить файл";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.AutoRoundedCorners = true;
            this.btnAddAssignment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAssignment.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnAddAssignment.BorderRadius = 24;
            this.btnAddAssignment.BorderThickness = 2;
            this.btnAddAssignment.FillColor = System.Drawing.Color.Transparent;
            this.btnAddAssignment.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAssignment.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnAddAssignment.Location = new System.Drawing.Point(17, 233);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.Size = new System.Drawing.Size(236, 50);
            this.btnAddAssignment.TabIndex = 7;
            this.btnAddAssignment.Text = "Добавить работу";
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(566, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(20, 13);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // AddAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::Practicum.Properties.Resources._189271609765514;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 295);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnAddAssignment);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.cbGroups);
            this.Controls.Add(this.cbDisciplines);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblDiscipline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(591, 295);
            this.MinimumSize = new System.Drawing.Size(591, 295);
            this.Name = "AddAssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}