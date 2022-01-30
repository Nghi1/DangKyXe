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
    public partial class GUI_DangNhapAD : Form
    {
        BUS_DangKyXe busTV = new BUS_DangKyXe();
        public GUI_DangNhapAD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttk.Text != "" && txtmk.Text != "")
            {
                string tk = txttk.Text;
                string mk = txtmk.Text;
                if (busTV.dnNguoiDungAD(tk, mk))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    GUI_QLND qlnd = new GUI_QLND();
                    qlnd.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
