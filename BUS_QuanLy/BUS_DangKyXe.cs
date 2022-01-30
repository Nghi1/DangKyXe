using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_DangKyXe
    {
        DAL_DangKyXe dalDangKyXe = new DAL_DangKyXe();

        public DataTable getDangKyXe()
        {
            return dalDangKyXe.getDangKyXe();
        }
        public DataTable getNguoiDung()
        {
            return dalDangKyXe.getNguoiDung();
        }

        public bool themDangKyXe(DTO_DangKyXe tv)
        {
            return dalDangKyXe.themDangKyXe(tv);
        }

        public bool suaDangKyXe(DTO_DangKyXe tv)
        {
            return dalDangKyXe.suaDangKyXe(tv);
        }

        public bool xoaDangKyXe(int TV_ID)
        {
            return dalDangKyXe.xoaDangKyXe(TV_ID);
        }
        public DataTable Get_find(string ttt)
        {
            return dalDangKyXe.findThongTinDK(ttt);
        }
        public bool themNguoiDung(DTO_NguoiDung tv)
        {
            return dalDangKyXe.themND(tv);
        }
        public bool dnNguoiDung(string tk, string mk)
        {
            return dalDangKyXe.dnNguoiDung(tk, mk);
        }
        public bool dnNguoiDungAD(string tk, string mk)
        {
            return dalDangKyXe.dnNguoiDungAD(tk, mk);
        }
        public bool suaNguoiDung(DTO_NguoiDung tv)
        {
            return dalDangKyXe.suaNguoiDung(tv);
        }
    }
}