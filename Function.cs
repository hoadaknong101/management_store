using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management_store
{
    class Function
    {
        public string connectionString = "Data Source=DESKTOP-N0B1KM6\\SQLEXPRESS;Initial Catalog=CNPM_PHONG_PHAM;Integrated Security=True;MultipleActiveResultSets=true";
        public SqlConnection connection;
        public SqlCommand cmd;

        public Function()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();
                cmd = connection.CreateCommand();
            }
            catch (SqlException)
            {

            }
        }

        public DataTable GetDataToDataTable(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
            dataAdapter.Fill(table);
            return table;
        }
        public int? KiemTraThongTinDangNhap(string sql, CommandType type)
        {
            int? result = 0;
            cmd.CommandType = type;
            cmd.CommandText = sql;
            try
            {
                result = (int?)cmd.ExecuteScalar();
            }
            catch (SqlException)
            {

            }
            return result;
        }
        public DataTable GetDataToDataTable(string sqlExpess, CommandType type)
        {
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlExpess, connection);
            dataAdapter.Fill(table);
            return table;
        }
        public void ExcuteNonQuery(string sqlExpess, CommandType type, params SqlParameter[] pm)
        {
            cmd = connection.CreateCommand();
            cmd.CommandType = type;
            cmd.CommandText = sqlExpess;
            cmd.Parameters.Clear();
            foreach (SqlParameter a in pm)
            {
                cmd.Parameters.Add(a);
            }
            cmd.ExecuteNonQuery();
        }
    }
}
