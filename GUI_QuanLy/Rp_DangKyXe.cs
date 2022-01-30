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
    public partial class Rp_DangKyXe : Form
    {
        public Rp_DangKyXe()
        {
            InitializeComponent();
        }

        private void Rp_DangKyXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DaS_DangKyXe.DANGKYXE' table. You can move, or remove it, as needed.
            this.DANGKYXETableAdapter.Fill(this.DaS_DangKyXe.DANGKYXE);

            this.reportViewer1.RefreshReport();
        }
    }
}
