using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_DangKyXe
    {
        private int _DANGKYXE_ID;
        private string _DANGKYXE_NGUOICB;
        private string _DANGKYXE_NOIDI;
        private string _DANGKYXE_NOIDEN;
        private string _DANGKYXE_THANHPHAN;
        private int _DANGKYXE_SOKM;
        private int _DANGKYXE_SOGHE;
        private string _DANGKYXE_NOIDUNG;
        private string _DANGKYXE_DNVI;
        private string _DANGKYXE_GHICHU;
        private string _DANGKYXE_TGBD;
        private string _DANGKYXE_TGKT;

        /* ======== GETTER/SETTER ======== */
        public int DANGKYXE_ID
        {
            get
            {
                return _DANGKYXE_ID;
            }

            set
            {
                _DANGKYXE_ID = value;
            }
        }

        public string DANGKYXE_TGBD
        {
            get
            {
                return _DANGKYXE_TGBD;
            }

            set
            {
                _DANGKYXE_TGBD = value;
            }
        }

        public string DANGKYXE_TGKT
        {
            get
            {
                return _DANGKYXE_TGKT;
            }

            set
            {
                _DANGKYXE_TGKT = value;
            }
        }
        public string DANGKYXE_NGUOICB
        {
            get
            {
                return _DANGKYXE_NGUOICB;
            }

            set
            {
                _DANGKYXE_NGUOICB = value;
            }
        }
        public string DANGKYXE_NOIDI
        {
            get
            {
                return _DANGKYXE_NOIDI;
            }

            set
            {
                _DANGKYXE_NOIDI = value;
            }
        }
        public string DANGKYXE_NOIDEN
        {
            get
            {
                return _DANGKYXE_NOIDEN;
            }

            set
            {
                _DANGKYXE_NOIDEN = value;
            }
        }
        public string DANGKYXE_THANHPHAN
        {
            get
            {
                return _DANGKYXE_THANHPHAN;
            }

            set
            {
                _DANGKYXE_THANHPHAN = value;
            }
        }
        public int DANGKYXE_SOKM
        {
            get
            {
                return _DANGKYXE_SOKM;
            }

            set
            {
                _DANGKYXE_SOKM = value;
            }
        }
        public int DANGKYXE_SOGHE
        {
            get
            {
                return _DANGKYXE_SOGHE;
            }

            set
            {
                _DANGKYXE_SOGHE = value;
            }
        }
        public string DANGKYXE_NOIDUNG
        {
            get
            {
                return _DANGKYXE_NOIDUNG;
            }

            set
            {
                _DANGKYXE_NOIDUNG = value;
            }
        }
        public string DANGKYXE_DNVI
        {
            get
            {
                return _DANGKYXE_DNVI;
            }

            set
            {
                _DANGKYXE_DNVI = value;
            }
        }
        public string DANGKYXE_GHICHU
        {
            get
            {
                return _DANGKYXE_GHICHU;
            }

            set
            {
                _DANGKYXE_GHICHU = value;
            }
        }

        /* === Constructor === */
        public DTO_DangKyXe()
        {

        }

        public DTO_DangKyXe(int id, string tgbd, string tgkt, string nguoicb, string noidi, string noiden, string thanhphan, int sokm, int soghe, string noidung, string dnvi, string ghichu)
        {
            this.DANGKYXE_ID = id;
            this.DANGKYXE_TGBD = tgbd;
            this.DANGKYXE_TGKT = tgkt;
            this.DANGKYXE_NGUOICB = nguoicb;
            this.DANGKYXE_NOIDI = noidi;
            this.DANGKYXE_NOIDEN = noiden;
            this.DANGKYXE_THANHPHAN = thanhphan;
            this.DANGKYXE_SOKM = sokm;
            this.DANGKYXE_SOGHE = soghe;
            this.DANGKYXE_NOIDUNG = noidung;
            this.DANGKYXE_DNVI = dnvi;
            this.DANGKYXE_GHICHU = ghichu;
        }
    }
}