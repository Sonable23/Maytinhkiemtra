using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maytinhkiemtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Calculate(string operation)
        {
            double number1, number2;

            // Kiểm tra và chuyển đổi giá trị đầu vào
            if (double.TryParse(txtso1.Text, out number1) && double.TryParse(txtso2.Text, out number2))
            {
                double result = 0;

                // Thực hiện phép toán dựa trên tham số operation
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                            result = number1 / number2;
                        else
                            MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                txtKQ.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            Calculate("+");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            Calculate("-");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Calculate("*");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Calculate("/");
        }
    }
     private void btnTru_Click(object sender, EventArgs e)
        {
            Calculate("-");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double number1, number2;
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
            {
                double result = number1 - number2;
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
}
