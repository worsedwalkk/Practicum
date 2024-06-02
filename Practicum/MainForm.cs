using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        //Открытие новой формы
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginForm lgnfrm = new LoginForm();
            lgnfrm.Show();
            this.Hide();
            lgnfrm.FormClosed += (s, args) => this.Close();
        }
        //Вывов диалогового окна
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomMessageBoxForm msgBox = new CustomMessageBoxForm();
            msgBox.ShowDialog();
        }
    }
}
