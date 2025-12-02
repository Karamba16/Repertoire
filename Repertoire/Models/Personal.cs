using System;
using System.Data;

namespace Theaters
{
    public class Personal
    {
        private int personal_id;

        private int theater_id;

        private string username;

        private string password;

        private string first_name;

        private string last_name;

        private string second_name;

        public Personal(int personal_id, int theater_id, string username, string password, string first_name, string last_name, string second_name)
        {
            this.personal_id = personal_id;
            this.theater_id = theater_id;
            this.username = username;
            this.password = password;
            this.first_name = first_name;
            this.last_name = last_name;
            this.second_name = second_name;
        }

        public static Personal GetPersonalByUsername(string username)
        {
            string sql = $"SELECT * FROM personal WHERE username = '{username}'";
            DB.Select(sql, out DataSet dataSet);

            var admin_id = Convert.ToInt32(dataSet.Tables[0].Rows[0][0]);
            var theater_id = Convert.ToInt32(dataSet.Tables[0].Rows[0][1]);
            var password = Convert.ToString(dataSet.Tables[0].Rows[0][3]);
            var first_name = Convert.ToString(dataSet.Tables[0].Rows[0][4]);
            var last_name = Convert.ToString(dataSet.Tables[0].Rows[0][5]);
            var second_name = Convert.ToString(dataSet.Tables[0].Rows[0][6]);

            var personal = new Personal(admin_id, theater_id, username, password, first_name, last_name, second_name);

            return personal;
        }

        public static bool IsUsernameCorrect(string username)
        {
            string sql = $"SELECT 1 FROM personal WHERE username = '{username}'";
            return DB.Exists(sql);
        }

        public static bool IsPasswordCorrect(string username, string password)
        {
            string sql = $"SELECT password FROM personal WHERE username = '{username}'";
            DB.Select(sql, out DataSet dataSet);

            string dbPassword = dataSet.Tables[0].Rows[0][0].ToString();
            return dbPassword.Equals(password);
        }

        public Theater GetTheater() => Theater.GetTheaterById(theater_id);

        public int GetId()
        {
            return this.personal_id;
        }

        public string GetUsername()
        {
            return this.username;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public string GetFullName() => second_name + " " + first_name + " " + last_name;
    }
}
