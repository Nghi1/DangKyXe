
namespace GUI_QuanLy
{
    partial class GUI_DangKyXe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtptgbd = new System.Windows.Forms.DateTimePicker();
            this.dtptgkt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnoidi = new System.Windows.Forms.TextBox();
            this.txtnoiden = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtnoidung = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.RichTextBox();
            this.butthem = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.txtsokm = new System.Windows.Forms.NumericUpDown();
            this.txtsoghe = new System.Windows.Forms.NumericUpDown();
            this.txtnguoicb = new System.Windows.Forms.ComboBox();
            this.txtthanhphan = new System.Windows.Forms.ComboBox();
            this.txtdnvi = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsokm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoghe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(773, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ XE CÔNG TÁC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2003, 38);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(518, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian bắt đầu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(648, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "*";
            // 
            // dtptgbd
            // 
            this.dtptgbd.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtptgbd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptgbd.Location = new System.Drawing.Point(669, 76);
            this.dtptgbd.Name = "dtptgbd";
            this.dtptgbd.Size = new System.Drawing.Size(209, 26);
            this.dtptgbd.TabIndex = 3;
            // 
            // dtptgkt
            // 
            this.dtptgkt.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtptgkt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptgkt.Location = new System.Drawing.Point(1024, 76);
            this.dtptgkt.Name = "dtptgkt";
            this.dtptgkt.Size = new System.Drawing.Size(201, 26);
            this.dtptgkt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(884, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1011, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(549, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Người chuẩn bị";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(615, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nơi đi";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnoidi
            // 
            this.txtnoidi.Location = new System.Drawing.Point(669, 143);
            this.txtnoidi.Name = "txtnoidi";
            this.txtnoidi.Size = new System.Drawing.Size(209, 26);
            this.txtnoidi.TabIndex = 4;
            // 
            // txtnoiden
            // 
            this.txtnoiden.Location = new System.Drawing.Point(1024, 146);
            this.txtnoiden.Name = "txtnoiden";
            this.txtnoiden.Size = new System.Drawing.Size(201, 26);
            this.txtnoiden.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(955, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nơi đến";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(569, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Thành phần";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(599, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số km";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(894, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số ghế dự kiến";
            this.label12.Click += new System.EventHandler(this.label3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(1003, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(577, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nội dung";
            this.label14.Click += new System.EventHandler(this.label3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(648, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "*";
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(669, 244);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(556, 62);
            this.txtnoidung.TabIndex = 5;
            this.txtnoidung.Text = "";
            this.txtnoidung.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(563, 318);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Đơn vị chủ trì";
            this.label16.Click += new System.EventHandler(this.label3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(599, 356);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Ghi chú";
            this.label17.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(669, 353);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(556, 62);
            this.txtghichu.TabIndex = 5;
            this.txtghichu.Text = "";
            this.txtghichu.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(530, 421);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(81, 38);
            this.butthem.TabIndex = 6;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(729, 421);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(81, 38);
            this.butxoa.TabIndex = 6;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(629, 421);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(81, 38);
            this.butsua.TabIndex = 6;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(1141, 421);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(81, 38);
            this.butthoat.TabIndex = 6;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1899, 573);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(654, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1007, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Searchnoiden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(825, 427);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(176, 26);
            this.txttim.TabIndex = 4;
            // 
            // txtsokm
            // 
            this.txtsokm.Location = new System.Drawing.Point(669, 210);
            this.txtsokm.Name = "txtsokm";
            this.txtsokm.Size = new System.Drawing.Size(120, 26);
            this.txtsokm.TabIndex = 9;
            // 
            // txtsoghe
            // 
            this.txtsoghe.Location = new System.Drawing.Point(1024, 211);
            this.txtsoghe.Name = "txtsoghe";
            this.txtsoghe.Size = new System.Drawing.Size(120, 26);
            this.txtsoghe.TabIndex = 9;
            // 
            // txtnguoicb
            // 
            this.txtnguoicb.FormattingEnabled = true;
            this.txtnguoicb.Location = new System.Drawing.Point(668, 107);
            this.txtnguoicb.Name = "txtnguoicb";
            this.txtnguoicb.Size = new System.Drawing.Size(557, 28);
            this.txtnguoicb.TabIndex = 10;
            this.txtnguoicb.SelectedIndexChanged += new System.EventHandler(this.txtnguoicb_SelectedIndexChanged);
            // 
            // txtthanhphan
            // 
            this.txtthanhphan.FormattingEnabled = true;
            this.txtthanhphan.Location = new System.Drawing.Point(668, 174);
            this.txtthanhphan.Name = "txtthanhphan";
            this.txtthanhphan.Size = new System.Drawing.Size(557, 28);
            this.txtthanhphan.TabIndex = 10;
            // 
            // txtdnvi
            // 
            this.txtdnvi.FormattingEnabled = true;
            this.txtdnvi.Location = new System.Drawing.Point(669, 312);
            this.txtdnvi.Name = "txtdnvi";
            this.txtdnvi.Size = new System.Drawing.Size(557, 28);
            this.txtdnvi.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1228, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thống Kê Danh Sách";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GUI_DangKyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtdnvi);
            this.Controls.Add(this.txtthanhphan);
            this.Controls.Add(this.txtnguoicb);
            this.Controls.Add(this.txtsoghe);
            this.Controls.Add(this.txtsokm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.txtnoidung);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.txtnoiden);
            this.Controls.Add(this.txtnoidi);
            this.Controls.Add(this.dtptgkt);
            this.Controls.Add(this.dtptgbd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_DangKyXe";
            this.Text = "Đăng ký xe";
            this.Load += new System.EventHandler(this.GUI_DangKyXe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsokm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoghe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtptgbd;
        private System.Windows.Forms.DateTimePicker dtptgkt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnoidi;
        private System.Windows.Forms.TextBox txtnoiden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox txtnoidung;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox txtghichu;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.NumericUpDown txtsokm;
        private System.Windows.Forms.NumericUpDown txtsoghe;
        private System.Windows.Forms.ComboBox txtnguoicb;
        private System.Windows.Forms.ComboBox txtthanhphan;
        private System.Windows.Forms.ComboBox txtdnvi;
        private System.Windows.Forms.Button button2;
    }
}