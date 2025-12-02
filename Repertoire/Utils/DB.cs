using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace Theaters
{
    class DB
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=repertoire";

            MySqlConnection con = new MySqlConnection(sql);
            con.Open();

            return con;
        }

        public static void Select(string query, out DataSet dataSet)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            dataSet = cmd.GetDataSet();

            con.Close();
        }

        public static bool Exists(string query)
        {
            MySqlConnection con = DB.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            bool flag = cmd.ExecuteScalar() != null;

            con.Close();

            return flag;
        }

        public static void Query(string query)
        {
            MySqlConnection con = DB.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteScalar();

            con.Close();
        }
    }
}
