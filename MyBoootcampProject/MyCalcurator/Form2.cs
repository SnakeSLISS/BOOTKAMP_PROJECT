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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string windowsTitle,string message)
        {
            InitializeComponent();
            this.Text = windowsTitle;
            lblpasword.Text = message;
        }
        public static string Show(string windowsTitle, string message)
        {
            using (Form2 inputDlg = new Form2(windowsTitle, message))
            {
                inputDlg.ShowDialog();
                return inputDlg.textbpassword.Text;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblpasword_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
