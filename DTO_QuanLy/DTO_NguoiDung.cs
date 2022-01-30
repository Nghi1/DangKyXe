using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_NguoiDung
    {
        private int _NGUOIDUNG_ID;
        private string _NGUOIDUNG_TENND;
        private int _NGUOIDUNG_PHONE;
        private string _NGUOIDUNG_TAIKHOAN;
        private string _NGUOIDUNG_MATKHAU;
        private string _NGUOIDUNG_XACNHANMK;
        private string _NGUOIDUNG_MAQUYEN;

        /* ======== GETTER/SETTER ======== */
        public int NGUOIDUNG_ID
        {
            get
            {
                return _NGUOIDUNG_ID;
            }

            set
            {
                _NGUOIDUNG_ID = value;
            }
        }

        public string NGUOIDUNG_TENND
        {
            get
            {
                return _NGUOIDUNG_TENND;
            }

            set
            {
                _NGUOIDUNG_TENND = value;
            }
        }
        public int NGUOIDUNG_PHONE
        {
            get
            {
                return _NGUOIDUNG_PHONE;
            }

            set
            {
                _NGUOIDUNG_PHONE = value;
            }
        }
        public string NGUOIDUNG_TAIKHOAN
        {
            get
            {
                return _NGUOIDUNG_TAIKHOAN;
            }

            set
            {
                _NGUOIDUNG_TAIKHOAN = value;
            }
        }
        public string NGUOIDUNG_MATKHAU
        {
            get
            {
                return _NGUOIDUNG_MATKHAU;
            }

            set
            {
                _NGUOIDUNG_MATKHAU = value;
            }
        }
        public string NGUOIDUNG_XACNHANMK
        {
            get
            {
                return _NGUOIDUNG_XACNHANMK;
            }

            set
            {
                _NGUOIDUNG_XACNHANMK = value;
            }
        }
        public string NGUOIDUNG_MAQUYEN
        {
            get
            {
                return _NGUOIDUNG_MAQUYEN;
            }

            set
            {
                _NGUOIDUNG_MAQUYEN = value;
            }
        }

        /* === Constructor === */
        public DTO_NguoiDung()
        {

        }

        public DTO_NguoiDung(int id, string tennd, int phone, string tk, string mk, string remk, string mq)
        {
            this.NGUOIDUNG_ID = id;
            this.NGUOIDUNG_TENND = tennd;
            this.NGUOIDUNG_PHONE = phone;
            this.NGUOIDUNG_TAIKHOAN = tk;
            this.NGUOIDUNG_MATKHAU = mk;
            this.NGUOIDUNG_XACNHANMK = remk;
            this.NGUOIDUNG_MAQUYEN = mq;
        }
    }
}