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

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển sang kiểu số
                double so1 = Convert.ToDouble(txtso1.Text);
                double so2 = Convert.ToDouble(txtso2.Text);

                // Kiểm tra chia cho 0
                if (so2 == 0)
                {
                    MessageBox.Show("Không thể chia cho 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thực hiện phép chia
                double ketQua = so1 / so2;

                // Hiển thị kết quả ra TextBox hoặc Label
                txtKQ.Text = ketQua.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
