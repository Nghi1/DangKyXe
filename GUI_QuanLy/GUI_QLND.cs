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
    public partial class GUI_QLND : Form
    {
        BUS_DangKyXe busTV = new BUS_DangKyXe();
        public GUI_QLND()
        {
            InitializeComponent();
        }

        private void GUI_QLND_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busTV.getNguoiDung();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int t = dataGridView1.CurrentCell.RowIndex;
            txtnd.Text = dataGridView1.Rows[t].Cells[1].Value.ToString();
            txtphone.Text = dataGridView1.Rows[t].Cells[2].Value.ToString();
            txttk.Text = dataGridView1.Rows[t].Cells[3].Value.ToString();
            txtmk.Text = dataGridView1.Rows[t].Cells[4].Value.ToString();
            txtremk.Text = dataGridView1.Rows[t].Cells[5].Value.ToString();
            txtmq.Text = dataGridView1.Rows[t].Cells[6].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (txtnd.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_NguoiDung tv = new DTO_NguoiDung(ID, txtnd.Text, int.Parse(txtphone.Text), txttk.Text, txtmk.Text, txtremk.Text, txtmq.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                    // Sửa
                    if (busTV.suaNguoiDung(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridView1.DataSource = busTV.getNguoiDung();             
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
