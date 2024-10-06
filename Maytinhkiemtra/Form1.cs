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



        private void btnNhan_Click(object sender, EventArgs e)
        {
            double number1, number2;
            if (double.TryParse(txtso1.Text, out number1) && double.TryParse(txtso2.Text, out number2))
            {
                double result = number1 * number2;
                txtKQ.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}
