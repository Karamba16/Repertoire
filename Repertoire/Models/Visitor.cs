using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Theaters
{
    public class Visitor
    {
        private int visitor_id;

        private string username;
        
        private string password;

        private string first_name;

        private string second_name;

        private string last_name;

        public Visitor(int visitor_id, string username, string password, string first_name, string second_name, string last_name)
        {
            this.visitor_id = visitor_id;
            this.username = username;
            this.password = password;
            this.first_name = first_name;
            this.second_name = second_name;
            this.last_name = last_name;
        }

        public static bool IsUsernameCorrect(string username)
        {
            string sql = $"SELECT 1 FROM visitors WHERE username = '{username}'";
            return DB.Exists(sql);
        }

        public static bool IsPasswordCorrect(string username, string password)
        {
            string sql = $"SELECT password FROM visitors WHERE username = '{username}'";
            DB.Select(sql, out DataSet dataSet);

            string dbPassword = dataSet.Tables[0].Rows[0][0].ToString();

            return dbPassword.Equals(password);
        }

        public static Visitor GetVisitorByUsername(string username)
        {
            string sql = $"SELECT * FROM visitors WHERE username = '{username}'";
            DB.Select(sql, out DataSet dataSet);

            var visitor_id = Convert.ToInt32(dataSet.Tables[0].Rows[0][0]);
            var password = Convert.ToString(dataSet.Tables[0].Rows[0][2]);
            var first_name = Convert.ToString(dataSet.Tables[0].Rows[0][3]);
            var second_name = Convert.ToString(dataSet.Tables[0].Rows[0][4]);
            var last_name = Convert.ToString(dataSet.Tables[0].Rows[0][5]);

            var visitor = new Visitor(visitor_id, username, password, first_name, second_name, last_name);

            return visitor;
        }

        public List<Performance> GetPerformances()
        {
            var sql = "SELECT * FROM performances JOIN tickets ON (performances.performance_id = tickets.performance_id) WHERE tickets.visitor_id = " + visitor_id; 
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

        public bool HasAlreadyOrdered(int performance_id)
        {
            string sql = $"SELECT 1 FROM tickets WHERE performance_id = {performance_id} AND visitor_id = {visitor_id}";
            return DB.Exists(sql);
        }

        public void MakeOrder(int performance_id)
        {
            string sql = $"INSERT INTO tickets (performance_id, visitor_id) VALUES ({performance_id}, {visitor_id})";
            DB.Select(sql, out DataSet dataSet);
        }

        public void ReturnTicket(Performance performance)
        {
            string sql = $"DELETE FROM tickets WHERE performance_id = {performance.GetId()} AND visitor_id = {visitor_id}";
            DB.Query(sql);
        }

        public int GetId() => visitor_id;

        public string GetFullName() => second_name + " " + first_name[0] + ". " + last_name[0] + ".";

        public string GetName() => second_name + " " + first_name + " " + last_name;
    }
}
