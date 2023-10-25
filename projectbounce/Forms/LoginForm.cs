using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectbounce.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && 
                textBoxPassword.Text != "")
            {
                if (textBoxLogin.Text == "1" &&
                    textBoxPassword.Text == "1")
                {
                    MessageBox.Show("Успешная авторизация", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mf = new MainForm();
                    this.Hide();
                    mf.ShowDialog();
                    this.Show();
                }
                else if(textBoxLogin.Text == "admin" &&
                    textBoxPassword.Text == "admin")
                {
                    DialogResult result = MessageBox.Show("Войти как администратор?", "Информация",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        AdminForm af = new AdminForm();
                        this.Hide();
                        af.ShowDialog();
                        this.Show();
                    }
                    else if(result == DialogResult.No)
                    {
                        MainForm mf = new MainForm();
                        this.Hide();
                        mf.ShowDialog();
                        this.Show();
                    }
                }    
                else
                {
                    MessageBox.Show("Ошибка авторизации", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Пустые поля", "Передупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
                
        }

        private void checkBoxViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViewPass.Checked)
            { 
                textBoxPassword.UseSystemPasswordChar = false;
            } 
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            } 
        }

        private void buttonRegIn_Click(object sender, EventArgs e)
        {
            RegForm rf = new RegForm();
            this.Hide();
            rf.ShowDialog();
            this.Show();
        }
    }
}
