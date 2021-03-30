using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string stock = "";
        string flag = "";

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        //7번 번호 클릭
        private void b7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        // 8번 번호 클릭
        private void btn8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        // 9번 번호 클릭
        private void btn9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        // 4번 번호 클릭
        private void btn4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        // 5번 번호 클릭
        private void btn5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        // 6번 번호 클릭
        private void btn6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        // 3번 번호 클릭
        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        // 2번 번호 클릭
        private void btn2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        // 1번 번호 클릭
        private void btn3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        // 0번 번호 클릭
        private void btn0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        // 더하기(+) 클릭
        private void btnPlus_Click(object sender, EventArgs e)
        {
            stock = label1.Text;
            label1.Text = "";
            flag += "+";
        }

        // 빼기(-) 클릭
        private void btnMinus_Click(object sender, EventArgs e)
        {
            stock = label1.Text;
            label1.Text = "";
            flag += "-";
        }

        // 곱하기(X) 클릭
        private void btnXX_Click(object sender, EventArgs e)
        {
            stock = label1.Text;
            label1.Text = "";
            flag += "*";
        }

        // 나누기(/) 클릭
        private void btnMod_Click(object sender, EventArgs e)
        {
            stock = label1.Text;
            label1.Text = "";
            flag += "/";
        }

        // 결과(=) 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            // 저장된 부호에 따라 연산 진행
            // 앞서 저장한 숫자를 저장한 stock과 현재 화면에 나오는 숫자를 연산진행
            if (flag == "+")
            {
                label1.Text =
                    (double.Parse(stock) + double.Parse(label1.Text.Trim())).ToString("0.000");
            }
            else if (flag == "-")
            {
                label1.Text =
                    (double.Parse(stock) - double.Parse(label1.Text.Trim())).ToString("0.000");
            }
            else if (flag == "*")
            {
                label1.Text =
                    (double.Parse(stock) * double.Parse(label1.Text.Trim())).ToString("0.000");
            }
            else if (flag == "/")
            {
                label1.Text =
                    (double.Parse(stock) / double.Parse(label1.Text.Trim())).ToString("0.000");
            }
            else
            {

            }

            label1.Text += "\n" + label1.Text;

            flag = "";
            stock = label1.Text;
        }

        // 숫자 앞에 Plus or Minus 부호 변경
        private void btnPM_Click(object sender, EventArgs e)
        {
            if (label1.Text.Trim() != "")
            {
                label1.Text = (-(double.Parse(label1.Text))).ToString("0.000");
            }
        }
    }
}
