using System;
using System.Collections.Generic;
using System.Data;

namespace Theaters
{
    public class Performance
    {
        private int performance_id;

        private int theater_id;

        private int producer_id;

        private int genre_id;

        private string title;

        private string description;

        private int price;

        private DateTime date;


        public Performance(int performance_id, int theater_id, int producer_id, int genre_id, string title, string description, int price, DateTime date)
        {
            this.performance_id = performance_id;
            this.theater_id = theater_id;
            this.producer_id = producer_id;
            this.genre_id = genre_id;
            this.title = title;
            this.description = description;
            this.price = price;
            this.date = date;
        }

        public static List<Performance> GetPerformancesByDate(DateTime dateTime)
        {
            var sql = $"SELECT * FROM performances WHERE DATE_FORMAT(date, '%Y-%m-%d') = '{dateTime.ToString("yyyy-MM-dd")}'";
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

        public static List<Performance> SearchPerformances(string queryTitle, DateTime dateTime, int queryGenre = 0)
        {
            string sql = $"SELECT * FROM performances WHERE DATE_FORMAT(date, '%Y-%m-%d') = '{dateTime.ToString("yyyy-MM-dd")}' AND title LIKE concat('%', '{queryTitle}', '%')";
            
            if (queryGenre > 0)
            {
                sql += " AND genre_id = " + queryGenre;
            }
            
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

        public List<Actor> GetActors()
        {
            string sql = $"SELECT * FROM actors JOIN roles ON (roles.actor_id = actors.actor_id) WHERE roles.performance_id = " + performance_id;
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

        public List<Visitor> GetVisitors()
        {
            string sql = $"SELECT * FROM visitors JOIN tickets ON (visitors.visitor_id = tickets.visitor_id) WHERE tickets.performance_id = " + performance_id;
            DB.Select(sql, out DataSet dataSet);

            var visitors = new List<Visitor>();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                var visitor_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][0]);
                var username = Convert.ToString(dataSet.Tables[0].Rows[i][1]);
                var password = Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                var first_name = Convert.ToString(dataSet.Tables[0].Rows[i][3]);
                var second_name = Convert.ToString(dataSet.Tables[0].Rows[i][4]);
                var last_name = Convert.ToString(dataSet.Tables[0].Rows[i][5]);

                var visitor = new Visitor(visitor_id, username, password, first_name, second_name, last_name);

                visitors.Add(visitor);
            }

            return visitors;
        }


        public void Update(int producer_id, int genre_id, string title, string description, int price, DateTime date)
        {
            this.producer_id = producer_id;
            this.genre_id = genre_id;
            this.title = title;
            this.description = description;
            this.price = price;
            this.date = date;

            string sql = $@"UPDATE performances SET 
                producer_id = {producer_id},
                genre_id = {genre_id}, 
                title = '{title}', 
                description = '{description}',
                price = {price},
                date = '{date.ToString("yyyy-MM-dd HH:mm:ss")}'
                WHERE performance_id = {performance_id}";

            DB.Query(sql);
        }

        public void Cancel()
        {
            var sql = $"DELETE FROM performances WHERE performance_id = " + performance_id;
            DB.Query(sql);
        }

        public void AddActor(Actor actor)
        {
            var sql = $"INSERT INTO roles (performance_id, actor_id) VALUES ({performance_id}, {actor.GetId()})";
            DB.Query(sql);
        }

        public void DeleteActor(Actor actor)
        {
            var sql = $"DELETE FROM roles WHERE performance_id = {performance_id} AND actor_id = {actor.GetId()}";
            DB.Query(sql);
        }

        public int GetId() => performance_id;

        public string GetTheater() => Theater.GetTheaterById(theater_id).GetTitle();

        public string GetProducer() => Producer.GetProducerById(producer_id).GetFullName();

        public int GetProducerId() => producer_id;

        public string GetGenre() => Genre.GetGenreById(genre_id).GetTitle();

        public int GetGenreId() => genre_id;

        public string GetTitle() => title;

        public string GetDescription() => description;

        public int GetPrice() => price;

        public DateTime GetDate() => date;
    }
}
