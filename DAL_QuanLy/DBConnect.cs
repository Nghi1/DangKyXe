using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=LAPTOP-LTSR3KDB;Initial Catalog=DangKyXe;Integrated Security=True");
    }
}