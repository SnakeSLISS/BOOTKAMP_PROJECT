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
    public partial class калькулятор : Form
    {
        public калькулятор()
        {
            InitializeComponent();
        }
        private bool isNumber = false;
        private double numFirst;
        private double numSecond;
        private double numRes;
        private void txt_keyDown(object sender, KeyEventArgs e)
        {
            isNumber = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9
            || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9
            || e.KeyCode == Keys.Back;
        }


        private void txt_keyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            switch (e.KeyChar)
            {
                case '-':
                    if (box.Text.Length == 0)
                    {
                        isNumber = true;
                    }
                    break;
                case '.':
                case ',':
                    if (box.Text.Length == 0)
                    {
                        isNumber = false;
                        break;
                    }
                    if ((box.Text[0] != '-' && box.Text.Length == 1 && !(box.Text.Contains('.') || box.Text.Contains(','))) || (box.Text.Length == 2 && !(box.Text.Contains('.') || box.Text.Contains(','))))
                    {
                        isNumber = true;
                        break;
                    }
                    break;
                case '!':
                case '@':
                case '#':
                case '$':
                case '%':
                case '^':
                case '&':
                case '*':
                case '(':
                case ')':
                case '№':
                case ';':
                case ':':
                case '?':
                    isNumber = false;
                    break;


            }

            if (!isNumber)
            {
                e.Handled = true;
            }

         }

        private void btn_Click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(textBnumber1.Text);
            string strSecond = string.Copy(textBnumber2.Text);
            if (textBnumber1.Text.Length > 0)
            {
                numFirst = Convert.ToDouble(strFirst);
            }
            else
            {
                numFirst = 0;
            }
            if (textBnumber2.Text.Length > 0)
            {
                numSecond = Convert.ToDouble(strSecond);
            }
            else
            {
                numSecond = 0;
            }
            bool divideFlag = false;
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "buttonplus":
                    numRes = numFirst + numSecond;
                    labelresalt.Text = numRes.ToString();
                    break;
                case "buttonmines":
                    numRes = numFirst - numSecond;
                    labelresalt.Text = numRes.ToString();
                    break;
                case "buttondivision":
                    numRes = numFirst * numSecond;
                    labelresalt.Text = numRes.ToString();
                    break;
                case "buttonmultiply":
                    if (Math.Abs(numSecond) < 1.0E-30)
                    {
                        MessageBox.Show("делить на ноль нельзя", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        numRes = numFirst / numSecond;
                        labelresalt.Text = numRes.ToString();
                    }
                    break;

            }
            if (!divideFlag)
            {
                lblResalt.Text = numRes.ToString();
            }

        }
            
        private void btn_exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void калькулятор_Load(object sender, EventArgs e)
        {

        }
    }
}
