using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Theaters.UserControls;

namespace Theaters
{
    public partial class VisitorTicketsList : UserControl
    {
        Visitor visitor;

        public VisitorTicketsList(Visitor visitor)
        {
            InitializeComponent();
            this.visitor = visitor;
        }

        public delegate void cellClick(int index);

        private void VisitorTicketsList_Load(object sender, EventArgs e)
        {
            var columns = new List<CustomDataGridViewColumn>() {
                new CustomDataGridViewColumn("date", "Дата", 75),
                new CustomDataGridViewColumn("time", "Время", 75),
                new CustomDataGridViewColumn("teatre", "Театр", 150),
                new CustomDataGridViewColumn("performance", "Выступление", 100),
                new CustomDataGridViewColumn("returTicket", "", 100, new cellClick(ReturnTicket)),
            };

            dataGridViewUC.Setup(columns);

            FillDataGrid();
        }

        public void FillDataGrid()
        {
            dataGridViewUC.Clear();

            var performances = visitor.GetPerformances();

            for (int i = 0; i < performances.Count; i++)
            {
                Performance performance = performances[i];

                dataGridViewUC.AddRow(new object[] { i + 1, performance.GetDate().Localize(), performance.GetDate().ToString("HH:mm"), performance.GetTheater(), performance.GetTitle(), "Вернуть билет" });
            }
        }

        public void ReturnTicket(int index)
        {
            var performances = visitor.GetPerformances();

            var performance = performances[index];

            visitor.ReturnTicket(performance);

            FillDataGrid();
        }
    }
}
