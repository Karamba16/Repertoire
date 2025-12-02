using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Theaters.UserControls;

namespace Theaters
{
    public partial class PersonalPerformanceAddPage : UserControl
    {
        Theater theater;

        int producer_id;

        int genre_id;

        DateTime date;

        public PersonalPerformanceAddPage(Theater theater, DateTime date)
        {
            InitializeComponent();
            this.theater = theater;
            this.date = date;
        }

        private void PersonalPerformanceAddPage_Load(object sender, EventArgs e)
        {
            var genres = new List<DropdownOptionUC>() { };

            Genre.GetGenres().ForEach(genre =>
            {
                genres.Add(new DropdownOptionUC(genre.GetTitle(), genre.GetId()));
            });

            genreDropdown.Setup(genres, new EventHandler(OnGenreDropDownMenuChanged));



            var producers = new List<DropdownOptionUC>() { };

            Producer.GetProducers().ForEach(producer =>
            {
                producers.Add(new DropdownOptionUC(producer.GetFullName(), producer.GetId()));
            });

            producerDropdown.Setup(producers, new EventHandler(OnProducersDropDownMenuChanged));


            datePicker.Value = date;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormPersonal;
            var uc = form.userControls.Pop();
            this.ReplaceWith(uc);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var title = titleTxtBox.Text;
            var description = descriptionTxtBox.Text;
            var price = Convert.ToInt32(priceTxtBox.Text);

            var hours = Convert.ToInt32(timeTxtBox.Text.Split(':')[0]);
            var minutes = Convert.ToInt32(timeTxtBox.Text.Split(':')[1]);
            var dateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, hours, minutes, 0);

            theater.AddPerformance(producer_id, genre_id, title, description, price, dateTime);

            var form = this.FindForm() as FormPersonal;
            var uc = form.userControls.Pop();
            this.ReplaceWith(uc);
        }

        public void OnGenreDropDownMenuChanged(object sender, object e)
        {
            genre_id = Convert.ToInt32(sender);
            var genre = Genre.GetGenreById(genre_id);
            genreDropdown.Title = genre.GetTitle();
        }

        public void OnProducersDropDownMenuChanged(object sender, object e)
        {
            producer_id = Convert.ToInt32(sender);
            var producer = Producer.GetProducerById(producer_id);
            producerDropdown.Title = producer.GetFullName();
        }
    }
}
