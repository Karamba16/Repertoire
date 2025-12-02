using System;
using System.Collections.Generic;
using System.Data;

namespace Theaters
{
    public class Actor
    {
        private int actor_id;

        private string first_name;

        private string second_name;

        private string last_name;

        private DateTime birthday_date;

        private string institution;

        public Actor(int actor_id, string first_name, string second_name, string last_name, DateTime birthday_date, string institution)
        {
            this.actor_id = actor_id;
            this.first_name = first_name;
            this.second_name = second_name;
            this.last_name = last_name;
            this.birthday_date = birthday_date;
            this.institution = institution;
        }

        public static Actor GetActorById(int actor_id)
        {
            string sql = $"SELECT * FROM actors WHERE actor_id = '{actor_id}'";
            DB.Select(sql, out DataSet dataSet);

            var first_name = Convert.ToString(dataSet.Tables[0].Rows[0][1]);
            var second_name = Convert.ToString(dataSet.Tables[0].Rows[0][2]);
            var last_name = Convert.ToString(dataSet.Tables[0].Rows[0][3]);
            var birthday_date = DateTime.Parse(Convert.ToString(dataSet.Tables[0].Rows[0][4]));
            var institution = Convert.ToString(dataSet.Tables[0].Rows[0][5]);

            var actor = new Actor(actor_id, first_name, second_name, last_name, birthday_date, institution);

            return actor;
        }

        public static List<Actor> GetActors()
        {
            string sql = $"SELECT * FROM actors";
            DB.Select(sql, out DataSet dataSet);

            var actors = new List<Actor>();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                var actor_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][0]);
                var first_name = Convert.ToString(dataSet.Tables[0].Rows[i][1]);
                var second_name = Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                var last_name = Convert.ToString(dataSet.Tables[0].Rows[i][3]);
                var birthday_date = DateTime.Parse(Convert.ToString(dataSet.Tables[0].Rows[i][4]));
                var institution = Convert.ToString(dataSet.Tables[0].Rows[i][5]);

                var actor = new Actor(actor_id, first_name, second_name, last_name, birthday_date, institution);

                actors.Add(actor);
            }

            return actors;
        }


        public int GetId() => actor_id;

        public string GetFullName() => second_name + " " + first_name[0] + ". " + last_name[0] + ".";

        public string GetBirthdayDate() => birthday_date.ToString("yyyy.MM.dd");

        public string GetInstitution() => institution;
    }
}
