using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalcurator
{
    public partial class Form1 : Form
    {
        const string _password = "6878";
        public Form1()
        {
            InitializeComponent();
        }
        private void калькулятор_Load(object sender, EventArgs e)
        {
        enterPassword:
            string password = Form2.Show("калькулятор", "введите пароль");
            if (password == "")
            {
                this.Close();
            }
            if (password != _password && password != "")
            {
                MessageBox.Show("пароль не верен", "неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto enterPassword;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new калькулятор();
            frm.Show();
        }

    }
}
