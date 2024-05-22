namespace Practicum
{
    partial class AddGroupForm
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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddGroup = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(23, 83);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(96, 13);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "Название группы";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupName.DefaultText = "";
            this.txtGroupName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGroupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGroupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupName.DisabledState.Parent = this.txtGroupName;
            this.txtGroupName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupName.FocusedState.Parent = this.txtGroupName;
            this.txtGroupName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupName.HoverState.Parent = this.txtGroupName;
            this.txtGroupName.Location = new System.Drawing.Point(171, 71);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.PasswordChar = '\0';
            this.txtGroupName.PlaceholderText = "";
            this.txtGroupName.SelectedText = "";
            this.txtGroupName.ShadowDecoration.Parent = this.txtGroupName;
            this.txtGroupName.Size = new System.Drawing.Size(200, 36);
            this.txtGroupName.TabIndex = 1;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.CheckedState.Parent = this.btnAddGroup;
            this.btnAddGroup.CustomImages.Parent = this.btnAddGroup;
            this.btnAddGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.HoverState.Parent = this.btnAddGroup;
            this.btnAddGroup.Location = new System.Drawing.Point(469, 50);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.ShadowDecoration.Parent = this.btnAddGroup;
            this.btnAddGroup.Size = new System.Drawing.Size(180, 45);
            this.btnAddGroup.TabIndex = 2;
            this.btnAddGroup.Text = "Добавить группу";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblGroupName);
            this.Name = "AddGroupForm";
            this.Text = "AddGroupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroupName;
        private Guna.UI2.WinForms.Guna2TextBox txtGroupName;
        private Guna.UI2.WinForms.Guna2Button btnAddGroup;
    }
}