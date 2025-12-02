using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Theaters
{
    public class Theater
    {
        private int theater_id;

        private string title;

        private string address;

        public Theater(int theater_id, string title, string address)
        {
            this.theater_id = theater_id;
            this.title = title;
            this.address = address;
        }

        public static Theater GetTheaterById(int theater_id)
        {
            string sql = "SELECT * FROM theaters WHERE theater_id = @Id";
            MySqlConnection con = DB.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", theater_id);

            var dataSet = cmd.GetDataSet();

            var title = Convert.ToString(dataSet.Tables[0].Rows[0][1]);
            var address = Convert.ToString(dataSet.Tables[0].Rows[0][2]);

            var theater = new Theater(theater_id, title, address);

            con.Close();

            return theater;
        }

        public static List<Theater> SearchTheaters(string query)
        {
            Debug.WriteLine(query);

            string sql = $"SELECT * FROM theaters title WHERE title LIKE concat('%', '{query}', '%')";
            DB.Select(sql, out DataSet dataSet);


            var theaters = new List<Theater>();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                var theater_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][0]);
                var title = Convert.ToString(dataSet.Tables[0].Rows[i][1]);
                var address = Convert.ToString(dataSet.Tables[0].Rows[i][2]);

                var theater = new Theater(theater_id, title, address);

                theaters.Add(theater);
            }


            return theaters;
        }

        public List<Performance> GetPerformancesByDate(DateTime dateTime)
        {
            var sql = $"SELECT * FROM performances WHERE theater_id = {theater_id} AND DATE_FORMAT(date, '%Y-%m-%d') = '{dateTime.ToString("yyyy-MM-dd")}'";
            DB.Select(sql, out DataSet dataSet);


            var performances = new List<Performance>();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                var performance_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][0]);
                var theater_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][1]);
                var producer_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][2]);
                var genre_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][3]);
                var title = Convert.ToString(dataSet.Tables[0].Rows[i][4]);
                var description = Convert.ToString(dataSet.Tables[0].Rows[i][5]);
                var price = Convert.ToInt32(dataSet.Tables[0].Rows[i][6]);
                var date = DateTime.Parse(Convert.ToString(dataSet.Tables[0].Rows[i][7]));

                var performance = new Performance(performance_id, theater_id, producer_id, genre_id, title, description, price, date);

                performances.Add(performance);
            }

            return performances;
        }

        public List<Performance> SearchPerformances(string queryTitle, DateTime dateTime)
        {
            string sql = $"SELECT * FROM performances WHERE theater_id = {theater_id} AND DATE_FORMAT(date, '%Y-%m-%d') = '{dateTime.ToString("yyyy-MM-dd")}' AND title LIKE concat('%', '{queryTitle}', '%')";

            DB.Select(sql, out DataSet dataSet);


            var performances = new List<Performance>();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                var performance_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][0]);
                var producer_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][2]);
                var genre_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][3]);
                var title = Convert.ToString(dataSet.Tables[0].Rows[i][4]);
                var description = Convert.ToString(dataSet.Tables[0].Rows[i][5]);
                var price = Convert.ToInt32(dataSet.Tables[0].Rows[i][6]);
                var date = DateTime.Parse(Convert.ToString(dataSet.Tables[0].Rows[i][7]));

                var performance = new Performance(performance_id, theater_id, producer_id, genre_id, title, description, price, date);

                performances.Add(performance);
            }

            return performances;
        }

        public void AddPerformance(int producer_id, int genre_id, string title, string description, int price, DateTime date)
        {
            string sql = $@"INSERT INTO performances (theater_id, producer_id, genre_id, title, description, price, date) 
                            VALUES ({theater_id}, {producer_id}, {genre_id}, '{title}', '{description}', {price}, '{date.ToString("yyyy-MM-dd HH:mm:ss")}')";

            DB.Query(sql);
        }

        public string GetTitle() => title;

        public string GetAddress() => address;
    }
}
