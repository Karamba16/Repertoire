using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Theaters.UserControls;

namespace Theaters
{
    public partial class VisitorPerformancesList : UserControl
    {
        DateTime date;
        List<Performance> performances;

        int genre_id;

        public VisitorPerformancesList(DateTime date, List<Performance> performances)
        {
            InitializeComponent();
            this.date = date;
            this.performances = performances;
        }

        public delegate void cellClick(int index);

        private void VisitorPerformancesList_Load(object sender, EventArgs e)
        {
            var columns = new List<CustomDataGridViewColumn>() {
                new CustomDataGridViewColumn("date", "Время", 50),
                new CustomDataGridViewColumn("title", "Название", 200),
                new CustomDataGridViewColumn("theatre", "Театр", 150),
                new CustomDataGridViewColumn("genre", "Жанр", 100),
                new CustomDataGridViewColumn("producer", "Режиссер", 150),
                new CustomDataGridViewColumn("price", "Цена", 50),
                new CustomDataGridViewColumn("openPerformancePage", "", 100, new cellClick(OpenPermormancePage)),
            };

            dataGridViewUC.Setup(columns);

            FillDataGrid();

            searchTxtBox._TextChanged += (ss, ee) => { FillDataGrid(searchTxtBox.Text); };

            
            topLabel.Text = "Выступления на " + date.Localize();


            var genres = new List<DropdownOptionUC>()
            {
                new DropdownOptionUC("Все жанры", 0)
            };

            Genre.GetGenres().ForEach(genre =>
            {
                genres.Add(new DropdownOptionUC(genre.GetTitle(), genre.GetId()));
            });

            genreDropDown.Setup(genres, new EventHandler(OnGroupDropDownMenuChanged));
        }

        public void FillDataGrid(string query = "")
        {
            dataGridViewUC.Clear();

            performances = Performance.SearchPerformances(query, date, genre_id);

            for (int i = 0; i < performances.Count; i++)
            {
                Performance performance = performances[i];

                dataGridViewUC.AddRow(new object[] { i + 1, performance.GetDate().ToString("HH:mm"), performance.GetTitle(), performance.GetTheater(), performance.GetGenre(), performance.GetProducer(), performance.GetPrice(), "Подробнее" });
            }
        }

        public void OpenPermormancePage(int index)
        {
            var form = this.FindForm() as FormVisitor;
            form.userControls.Push(new VisitorPerformancesList(date, performances));

            var performance = performances[index];
            var page = new VisitorPerformancePage(performance);
            this.ReplaceWith(page);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormVisitor;
            var userControl = form.userControls.Pop();
            this.ReplaceWith(userControl);
        }

        public void OnGroupDropDownMenuChanged(object sender, object e)
        {
            genre_id = Convert.ToInt32(sender);

            if (genre_id == 0)
            {
                genreDropDown.Title = "Группа";
                FillDataGrid(searchTxtBox.Text);
            }
            else
            {
                var genre = Genre.GetGenreById(genre_id);
                genreDropDown.Title = genre.GetTitle();
                FillDataGrid(searchTxtBox.Text);
            }
        }
    }
}
