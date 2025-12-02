using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Theaters
{
    public class Producer
    {
        private int producer_id;

        private string first_name;

        private string second_name;

        private string last_name;

        private DateTime birthday_date;

        private string institution;

        public Producer(int producer_id, string first_name, string second_name, string last_name, DateTime birthday_date, string institution) 
        {
            this.producer_id = producer_id;
            this.first_name = first_name;
            this.second_name = second_name;
            this.last_name = last_name;
            this.birthday_date = birthday_date;
            this.institution = institution;
        }

        public static Producer GetProducerById(int producer_id)
        {
            string sql = "SELECT * FROM producers WHERE producer_id = " + producer_id;
            DB.Select(sql, out DataSet dataSet);

            var first_name = Convert.ToString(dataSet.Tables[0].Rows[0][1]);
            var second_name = Convert.ToString(dataSet.Tables[0].Rows[0][2]);
            var last_name = Convert.ToString(dataSet.Tables[0].Rows[0][3]);
            var birthday_date = DateTime.Parse(Convert.ToString(dataSet.Tables[0].Rows[0][4]));
            var institution = Convert.ToString(dataSet.Tables[0].Rows[0][5]);

            var producer = new Producer(producer_id, first_name, second_name, last_name, birthday_date, institution);


            return producer;
        }


        public static List<Producer> GetProducers()
        {
            string sql = "SELECT * FROM producers";
            DB.Select(sql, out DataSet dataSet);


            var producers = new List<Producer>();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                var producer_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][0]);
                var first_name = Convert.ToString(dataSet.Tables[0].Rows[i][1]);
                var second_name = Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                var last_name = Convert.ToString(dataSet.Tables[0].Rows[i][3]);
                var birthday_date = DateTime.Parse(Convert.ToString(dataSet.Tables[0].Rows[i][4]));
                var institution = Convert.ToString(dataSet.Tables[0].Rows[i][5]);

                var producer = new Producer(producer_id, first_name, second_name, last_name, birthday_date, institution);

                producers.Add(producer);
            }

            return producers;
        }

        public int GetId() => producer_id;

        public string GetFullName() => second_name + " " + first_name[0] + ". " + last_name[0] + ".";
    }
}
