using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_DangKyXe : Form
    {
        BUS_DangKyXe busTV = new BUS_DangKyXe();
        public GUI_DangKyXe()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUI_DangKyXe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busTV.getDangKyXe();
            txtnguoicb.DataSource = busTV.getDangKyXe();
            txtnguoicb.DisplayMember = "TV_NGUOICB";
            txtnguoicb.ValueMember = "TV_ID";
            txtthanhphan.DataSource = busTV.getDangKyXe();
            txtthanhphan.DisplayMember = "TV_THANHPHAN";
            txtthanhphan.ValueMember = "TV_ID";
            txtdnvi.DataSource = busTV.getDangKyXe();
            txtdnvi.DisplayMember = "TV_DNVI";
            txtdnvi.ValueMember = "TV_ID";
            MessageBox.Show("Open Full Screen, thanks!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtptgbd.Value.ToString() != "" && dtptgkt.Value.ToString() != "" && txtsokm.Text != "" && txtsoghe.Text != "" && txtnoidung.Text != "")
            {
                // Tạo DTo
                DTO_DangKyXe tv = new DTO_DangKyXe(0, dtptgbd.Value.ToString(), dtptgkt.Value.ToString(), txtnguoicb.Text, txtnoidi.Text, txtnoiden.Text, txtthanhphan.Text, int.Parse(txtsokm.Text), int.Parse(txtsoghe.Text), txtnoidung.Text, txtdnvi.Text, txtghichu.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (busTV.themDangKyXe(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = busTV.getDangKyXe();
                    txtnguoicb.DataSource = busTV.getDangKyXe();
                    txtnguoicb.DisplayMember = "TV_NGUOICB";
                    txtnguoicb.ValueMember = "TV_ID";
                    txtthanhphan.DataSource = busTV.getDangKyXe();
                    txtthanhphan.DisplayMember = "TV_THANHPHAN";
                    txtthanhphan.ValueMember = "TV_ID";
                    txtdnvi.DataSource = busTV.getDangKyXe();
                    txtdnvi.DisplayMember = "TV_DNVI";
                    txtdnvi.ValueMember = "TV_ID";// refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các chỗ có *");
            }

        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dtptgbd.Value.ToString() != "" && dtptgkt.Value.ToString() != "" && txtsokm.Text != "" && txtsoghe.Text != "" && txtnoidung.Text != "")
                    {
                    // Lấy row hiện tại
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_DangKyXe tv = new DTO_DangKyXe(ID, dtptgbd.Value.ToString(), dtptgkt.Value.ToString(), txtnguoicb.Text, txtnoidi.Text, txtnoiden.Text, txtthanhphan.Text, int.Parse(txtsokm.Text), int.Parse(txtsoghe.Text), txtnoidung.Text, txtdnvi.Text, txtghichu.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                    // Sửa
                    if (busTV.suaDangKyXe(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridView1.DataSource = busTV.getDangKyXe();
                        txtnguoicb.DataSource = busTV.getDangKyXe();
                        txtnguoicb.DisplayMember = "TV_NGUOICB";
                        txtnguoicb.ValueMember = "TV_ID";
                        txtthanhphan.DataSource = busTV.getDangKyXe();
                        txtthanhphan.DisplayMember = "TV_THANHPHAN";
                        txtthanhphan.ValueMember = "TV_ID";
                        txtdnvi.DataSource = busTV.getDangKyXe();
                        txtdnvi.DisplayMember = "TV_DNVI";
                        txtdnvi.ValueMember = "TV_ID";// refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các chỗ có * ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int t = dataGridView1.CurrentCell.RowIndex;

            // Chuyển giá trị lên form
            dtptgbd.Value = (DateTime)dataGridView1.Rows[t].Cells[1].Value;
            dtptgkt.Value = (DateTime)dataGridView1.Rows[t].Cells[2].Value;
            txtnguoicb.Text = dataGridView1.Rows[t].Cells[3].Value.ToString();
            txtnoidi.Text = dataGridView1.Rows[t].Cells[4].Value.ToString();
            txtnoiden.Text = dataGridView1.Rows[t].Cells[5].Value.ToString();
            txtthanhphan.Text = dataGridView1.Rows[t].Cells[6].Value.ToString();
            txtsokm.Text = dataGridView1.Rows[t].Cells[7].Value.ToString();
            txtsoghe.Text = dataGridView1.Rows[t].Cells[8].Value.ToString();
            txtnoidung.Text = dataGridView1.Rows[t].Cells[9].Value.ToString();
            txtdnvi.Text = dataGridView1.Rows[t].Cells[10].Value.ToString();
            txtghichu.Text = dataGridView1.Rows[t].Cells[11].Value.ToString();
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Xóa
                if (busTV.xoaDangKyXe(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridView1.DataSource = busTV.getDangKyXe(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void buttim_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string values = txttim.Text;
            if (!string.IsNullOrEmpty(values))
            {
                DataTable dt = busTV.Get_find(values);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = busTV.getDangKyXe();
            }

        }

        private void txtnguoicb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rp_DangKyXe rp = new Rp_DangKyXe();
            rp.ShowDialog();
        }
    }
}
