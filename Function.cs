using System.Data;
using System.Data.SqlClient;

namespace management_store
{
    class Function
    {
        // Hoa
        //private string connectionString = "Data Source=QHPSER\\SQLEXPRESS;Initial Catalog=CNPM_PHONG_PHAM;Integrated Security=True;MultipleActiveResultSets=true"

        // Hao
        //private string connectionString = "Data Source=;Initial Catalog=CNPM_PHONG_PHAM;Integrated Security=True;MultipleActiveResultSets=true"

        // Phi
        private string connectionString = "Data Source=PhiVo-Z1704;Initial Catalog=CNPM_PHONG_PHAM;Integrated Security=True;MultipleActiveResultSets=true";

        // Thang
        //private string connectionString = "Data Source=DESKTOP-N0B1KM6\\SQLEXPRESS;Initial Catalog=CNPM_PHONG_PHAM;Integrated Security=True;MultipleActiveResultSets=true"

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

        public DataTable ExecuteQueryDataTable(string strSql, CommandType ct, params SqlParameter[] param)
        {
            cmd.CommandText = strSql;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
