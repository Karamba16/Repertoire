using System;
using System.Collections.Generic;
using System.Data;

namespace Theaters
{
    public class Genre
    {
        private int genre_id;

        private string title;

        public Genre(int genre_id, string title)
        {
            this.genre_id = genre_id;
            this.title = title;
        }

        public static Genre GetGenreById(int genre_id)
        {
            var sql = "SELECT * FROM genres WHERE genre_id = " + genre_id;
            DB.Select(sql, out DataSet dataSet);

            var title = Convert.ToString(dataSet.Tables[0].Rows[0][1]);

            var genre = new Genre(genre_id, title);

            return genre;
        }

        public static List<Genre> GetGenres()
        {
            string sql = "SELECT * FROM genres";
            DB.Select(sql, out DataSet dataSet);

            var genres = new List<Genre>();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                var genre_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][0]);
                var title = Convert.ToString(dataSet.Tables[0].Rows[i][1]);

                var genre = new Genre(genre_id, title);

                genres.Add(genre);
            }


            return genres;
        }

        public int GetId() => genre_id;

        public string GetTitle() => title;
    }
}
