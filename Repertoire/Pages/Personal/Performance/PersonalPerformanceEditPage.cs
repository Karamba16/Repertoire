using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Theaters.UserControls;

namespace Theaters
{
    public partial class PersonalPerformanceEditPage : UserControl
    {
        Performance performance;

        int genre_id;

        int producer_id;


        public PersonalPerformanceEditPage(Performance performance)
        {
            InitializeComponent();
            this.performance = performance;
            this.genre_id = performance.GetGenreId();
            this.producer_id = performance.GetProducerId();
        }

        private void PersonalPerformanceEditPage_Load(object sender, EventArgs e)
        {
            titleTxtBox.Text = performance.GetTitle();
            priceTxtBox.Text = performance.GetPrice().ToString();
            descriptionTxtBox.Text = performance.GetDescription();
            datePicker.Value = performance.GetDate();
            timeTxtBox.Text = performance.GetDate().ToString("HH:mm");



            var genres = new List<DropdownOptionUC>(){};

            Genre.GetGenres().ForEach(genre =>
            {
                genres.Add(new DropdownOptionUC(genre.GetTitle(), genre.GetId()));
            });

            genreDropdown.Setup(genres, new EventHandler(OnGenreDropDownMenuChanged));
            genreDropdown.Title = Convert.ToString(performance.GetGenre());



            var producers = new List<DropdownOptionUC>() { };

            Producer.GetProducers().ForEach(producer =>
            {
                producers.Add(new DropdownOptionUC(producer.GetFullName(), producer.GetId()));
            });

            producerDropdown.Setup(producers, new EventHandler(OnProducersDropDownMenuChanged));
            producerDropdown.Title = Convert.ToString(performance.GetProducer());
        }

        private void showActorsPageBtn_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormPersonal;
            form.userControls.Push(new PersonalPerformanceEditPage(performance));

            var page = new PersonalPerformanceActorsList(performance);
            this.ReplaceWith(page);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormPersonal;
            var uc = form.userControls.Pop();
            this.ReplaceWith(uc);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var newTitle = titleTxtBox.Text;
            var newDescription = descriptionTxtBox.Text;
            var newPrice = Convert.ToInt32(priceTxtBox.Text);

            var hours = Convert.ToInt32(timeTxtBox.Text.Split(':')[0]);
            var minutes = Convert.ToInt32(timeTxtBox.Text.Split(':')[1]);
            var dateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, hours, minutes, 0);

            performance.Update(producer_id, genre_id, newTitle, newDescription, newPrice, dateTime);
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
