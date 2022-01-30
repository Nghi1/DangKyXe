using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_DangKyXe : DBConnect
    {
        /// <summary>
        /// Get toàn bộ thành viên
        /// </summary>
        /// <returns></returns>
        public DataTable getDangKyXe()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DANGKYXE", _conn);
            DataTable dtDangkyxe = new DataTable();
            da.Fill(dtDangkyxe);
            return dtDangkyxe;
        }
        public DataTable getNguoiDung()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NGUOIDUNG", _conn);
            DataTable dtNguoidung = new DataTable();
            da.Fill(dtNguoidung);
            return dtNguoidung;
        }

        /// <summary>
        /// Thêm thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool themDangKyXe(DTO_DangKyXe tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì  để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO DANGKYXE(TV_TGBD, TV_TGKT, TV_NGUOICB, TV_NOIDI, TV_NOIDEN, TV_THANHPHAN, TV_SOKM, TV_SOGHE, TV_NOIDUNG, TV_DNVI, TV_GHICHU) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", tv.DANGKYXE_TGBD, tv.DANGKYXE_TGKT, tv.DANGKYXE_NGUOICB, tv.DANGKYXE_NOIDI, tv.DANGKYXE_NOIDEN, tv.DANGKYXE_THANHPHAN, tv.DANGKYXE_SOKM, tv.DANGKYXE_SOGHE, tv.DANGKYXE_NOIDUNG, tv.DANGKYXE_DNVI, tv.DANGKYXE_GHICHU);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Sửa thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool suaDangKyXe(DTO_DangKyXe tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE DANGKYXE SET TV_TGBD = '{0}', TV_TGKT = '{1}', TV_NGUOICB = '{2}', TV_NOIDI = '{3}', TV_NOIDEN = '{4}', TV_THANHPHAN = '{5}', TV_SOKM = '{6}', TV_SOGHE = '{7}', TV_NOIDUNG = '{8}', TV_DNVI = '{9}', TV_GHICHU = '{10}' WHERE TV_ID = {11}", tv.DANGKYXE_TGBD, tv.DANGKYXE_TGKT, tv.DANGKYXE_NGUOICB, tv.DANGKYXE_NOIDI, tv.DANGKYXE_NOIDEN, tv.DANGKYXE_THANHPHAN, tv.DANGKYXE_SOKM, tv.DANGKYXE_SOGHE, tv.DANGKYXE_NOIDUNG, tv.DANGKYXE_DNVI, tv.DANGKYXE_GHICHU, tv.DANGKYXE_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Xóa thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool xoaDangKyXe(int TV_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM DANGKYXE WHERE TV_ID = {0}", TV_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
        public DataTable findThongTinDK(string tt)
        {
            _conn.Open();
            string sql = string.Format("SELECT * FROM DANGKYXE WHERE TV_NOIDEN like '%" + tt.Trim() + "%'", tt);
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dtTimKiem = new DataTable();
            da.Fill(dtTimKiem);
            _conn.Close();
            return dtTimKiem;
        }
        //QLTK
        public bool themND(DTO_NguoiDung tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì  để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO NGUOIDUNG(TV_TENND, TV_PHONE, TV_TAIKHOAN, TV_MATKHAU, TV_XACNHANMK, TV_MAQUYEN) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", tv.NGUOIDUNG_TENND, tv.NGUOIDUNG_PHONE, tv.NGUOIDUNG_TAIKHOAN, tv.NGUOIDUNG_MATKHAU, tv.NGUOIDUNG_XACNHANMK, tv.NGUOIDUNG_MAQUYEN);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
        public bool dnNguoiDung(string tk, string mk)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("SELECT *FROM NGUOIDUNG WHERE TV_TAIKHOAN='"+tk+"' and TV_MATKHAU='"+mk+"' and TV_MAQUYEN='' or TV_MAQUYEN='admin'", tk, mk);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader dta = cmd.ExecuteReader();
                // Query và kiểm tra
                if (dta.Read()== true)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
        public bool dnNguoiDungAD(string tk, string mk)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("SELECT *FROM NGUOIDUNG WHERE TV_TAIKHOAN='" + tk + "' and TV_MATKHAU='" + mk + "' AND TV_MAQUYEN='admin'", tk, mk);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader dta = cmd.ExecuteReader();
                // Query và kiểm tra
                if (dta.Read() == true)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
        public bool suaNguoiDung(DTO_NguoiDung tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE NGUOIDUNG SET TV_TENND = '{0}', TV_PHONE = '{1}', TV_TAIKHOAN ='{2}', TV_MATKHAU='{3}', TV_XACNHANMK='{4}', TV_MAQUYEN = '{5}' WHERE TV_ID = {6}", tv.NGUOIDUNG_TENND, tv.NGUOIDUNG_PHONE, tv.NGUOIDUNG_TAIKHOAN, tv.NGUOIDUNG_MATKHAU, tv.NGUOIDUNG_XACNHANMK, tv.NGUOIDUNG_MAQUYEN, tv.NGUOIDUNG_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}