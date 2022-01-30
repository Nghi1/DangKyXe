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
    public partial class GUI_DangNhap : Form
    {
        BUS_DangKyXe busTV = new BUS_DangKyXe();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttk.Text != "" && txtmk.Text != "")
            {
                string tk = txttk.Text;
                string mk = txtmk.Text;
                if (busTV.dnNguoiDung(tk, mk))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    GUI_DangKyXe dkx = new GUI_DangKyXe();
                    dkx.ShowDialog();
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
    }
}
