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
    public partial class CustomMessageBoxForm : Form
    {
        public CustomMessageBoxForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Set the form properties
            this.Text = "Информация о программе";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Create and set the label properties
            Label label = new Label();
            label.Text = "Разработчик - Пушкарев Егор Александрович, студент 4-го курса специальности 09.02.07 Информационные системы и программирование.\n" +
                         "Почта: dovakin_2019@mail.ru\n\n" +
                         "Руководитель - Акулова Наталья Александровна.\n\n" +
                         "Источники:\n" +
                         "ru.wikipedia.org, studfile.net, studbooks.net, rtek24.ru, profstandart.rosmintrud.ru, consultant.ru, rosmintrud.ru, kcson-kr.ru, msp.midural.ru.";
            label.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            label.AutoSize = false;
            label.Size = new Size(560, 320);
            label.Location = new Point(20, 20);
            label.TextAlign = ContentAlignment.MiddleLeft;

            // Add the label to the form
            this.Controls.Add(label);

            // Create and set the OK button properties
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            okButton.Size = new Size(100, 40);
            okButton.Location = new Point((this.ClientSize.Width - okButton.Width) / 2, this.ClientSize.Height - okButton.Height - 20);
            okButton.Click += (sender, e) => this.Close();

            // Add the OK button to the form
            this.Controls.Add(okButton);
        }
    }
}
