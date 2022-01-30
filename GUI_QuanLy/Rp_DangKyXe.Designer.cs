
namespace GUI_QuanLy
{
    partial class Rp_DangKyXe
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DaS_DangKyXe = new GUI_QuanLy.DaS_DangKyXe();
            this.DANGKYXEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DANGKYXETableAdapter = new GUI_QuanLy.DaS_DangKyXeTableAdapters.DANGKYXETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DaS_DangKyXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DANGKYXEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DANGKYXEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QuanLy.Rp_DSDangKyXe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1217, 531);
            this.reportViewer1.TabIndex = 0;
            // 
            // DaS_DangKyXe
            // 
            this.DaS_DangKyXe.DataSetName = "DaS_DangKyXe";
            this.DaS_DangKyXe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DANGKYXEBindingSource
            // 
            this.DANGKYXEBindingSource.DataMember = "DANGKYXE";
            this.DANGKYXEBindingSource.DataSource = this.DaS_DangKyXe;
            // 
            // DANGKYXETableAdapter
            // 
            this.DANGKYXETableAdapter.ClearBeforeFill = true;
            // 
            // Rp_DangKyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 531);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rp_DangKyXe";
            this.Text = "Thống kê danh sách đăng ký xe";
            this.Load += new System.EventHandler(this.Rp_DangKyXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaS_DangKyXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DANGKYXEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DANGKYXEBindingSource;
        private DaS_DangKyXe DaS_DangKyXe;
        private DaS_DangKyXeTableAdapters.DANGKYXETableAdapter DANGKYXETableAdapter;
    }
}