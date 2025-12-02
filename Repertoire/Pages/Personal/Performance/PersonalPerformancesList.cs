using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Theaters.UserControls;

namespace Theaters
{
    public partial class PersonalPerformancesList : UserControl
    {
        Theater theater;
        DateTime date;
        List<Performance> performances;

        public PersonalPerformancesList(Theater theater, DateTime date)
        {
            InitializeComponent();
            this.theater = theater;
            this.date = date;
            this.performances = theater.GetPerformancesByDate(date);
        }


        public delegate void cellClick(int index);

        private void PersonalPerformancesList_Load(object sender, EventArgs e)
        {
            var columns = new List<CustomDataGridViewColumn>() {
                new CustomDataGridViewColumn("date", "Время", 50),
                new CustomDataGridViewColumn("title", "Название", 200),
                new CustomDataGridViewColumn("genre", "Жанр", 100),
                new CustomDataGridViewColumn("producer", "Режиссер", 100),
                new CustomDataGridViewColumn("price", "Цена", 50),
                new CustomDataGridViewColumn("visitors", "", 100, new cellClick(OpenPerformanceVisitorsList)),
                new CustomDataGridViewColumn("edit", "", 100, new cellClick(OpenPerformanceEditPage)),
                new CustomDataGridViewColumn("cansel", "", 100, new cellClick(CancelPerformance))
            };

            dataGridViewUC.Setup(columns);

            FillDataGrid();

            searchTxtBox._TextChanged += (ss, ee) => { FillDataGrid(searchTxtBox.Text); };

            topLabel.Text = "Выступления на " + date.Localize();
        }

        public void FillDataGrid(string query = "")
        {
            dataGridViewUC.Clear();

            performances = theater.SearchPerformances(query, date);

            for (int i = 0; i < performances.Count; i++)
            {
                Performance performance = performances[i];

                dataGridViewUC.AddRow(new object[] { i + 1, performance.GetDate().ToString("HH:mm"), performance.GetTitle(), performance.GetGenre(), performance.GetProducer(), performance.GetPrice(), "Зрители", "Редактировать", "Отменить" });
            }
        }

        public void OpenPerformanceEditPage(int index)
        {
            var form = this.FindForm() as FormPersonal;
            form.userControls.Push(new PersonalPerformancesList(theater, date));

            var performance = performances[index];
            var page = new PersonalPerformanceEditPage(performance);
            this.ReplaceWith(page);
        }

        public void CancelPerformance(int index)
        {
            var performance = performances[index];
            performance.Cancel();
            FillDataGrid(searchTxtBox.Text);
        }


        public void OpenPerformanceVisitorsList(int index)
        {
            var form = this.FindForm() as FormPersonal;
            form.userControls.Push(new PersonalPerformancesList(theater, date));

            var performance = performances[index];
            var page = new PersonalPerformanceVisitorsList(performance);
            this.ReplaceWith(page);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormPersonal;
            var userControl = form.userControls.Pop();
            this.ReplaceWith(userControl);
        }

        private void addPerformanceBtn_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormPersonal;
            form.userControls.Push(new PersonalPerformancesList(theater, date));

            var page = new PersonalPerformanceAddPage(theater, date);
            this.ReplaceWith(page);
        }
    }
}
