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

        private void btnCong_Click(object sender, EventArgs e)
        {
            // Chuyển giá trị từ TextBox sang số nguyên (int)
            int so1 = int.Parse(txtso1.Text);
            int so2 = int.Parse(txtso2.Text);

            // Thực hiện phép tính cộng
            int ketQua = so1 + so2;

            // Hiển thị kết quả lên Label
            txtKQ.Text = ketQua.ToString();
        }

    }
}
