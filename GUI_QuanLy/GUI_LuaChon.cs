using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class GUI_LuaChon : Form
    {
        public GUI_LuaChon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_DangNhap dn = new GUI_DangNhap();
            dn.ShowDialog();
        }

        private void GUI_LuaChon_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI_DangKyND dk = new GUI_DangKyND();
            dk.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI_DangNhapAD dnad = new GUI_DangNhapAD();
            dnad.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
