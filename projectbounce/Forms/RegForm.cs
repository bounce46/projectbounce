using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectbounce.Forms
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void checkBoxViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViewPass.Checked)
            {
                textBoxPass.UseSystemPasswordChar = false; 
                textBoxPassRepeat.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                textBoxPassRepeat.UseSystemPasswordChar = true;
            }
        }

        private void buttonRegIn_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && 
                textBoxPass.Text != "" && 
                textBoxPassRepeat.Text != "")
            {
                if (textBoxPass.Text == textBoxPassRepeat.Text)
                {
                    MessageBox.Show("Успешная регистрация","Информация",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пустые поля", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
