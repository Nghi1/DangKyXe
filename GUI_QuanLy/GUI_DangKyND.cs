using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_DangKyND : Form
    {
        BUS_DangKyXe busTV = new BUS_DangKyXe();
        public GUI_DangKyND()
        {
            InitializeComponent();
        }

        private void butdk_Click(object sender, EventArgs e)
        {
            if (txttennd.Text != "" && txtphone.Text != "" && txttk.Text != "" && txtmk.Text != "" && txtremk.Text != "" && txtremk.Text == txtmk.Text) 
            {
                // Tạo DTo
                DTO_NguoiDung tv = new DTO_NguoiDung(0, txttennd.Text, int.Parse(txtphone.Text), txttk.Text, txtmk.Text, txtremk.Text, txtmq.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (busTV.themNguoiDung(tv))
                {
                    MessageBox.Show("Thêm thành công");

                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và xác nhận mật khẩu chuẩn xác");
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_DangKyND_Load(object sender, EventArgs e)
        {

        }
    }
}
