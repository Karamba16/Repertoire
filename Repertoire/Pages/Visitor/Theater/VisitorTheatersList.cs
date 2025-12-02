using System.Collections.Generic;
using System.Windows.Forms;
using Theaters.UserControls;

namespace Theaters
{
    public partial class VisitorTheatersList : UserControl
    {
        public VisitorTheatersList()
        {
            InitializeComponent();
        }

        public delegate void cellClick(int index);

        private void VisitorTheatersList_Load(object sender, System.EventArgs e)
        {
            var columns = new List<CustomDataGridViewColumn>() {
                new CustomDataGridViewColumn("", "Название", 150),
                new CustomDataGridViewColumn("", "Адрес", 150),
            };

            dataGridViewUC.Setup(columns);

            FillDataGrid();

            searchTxtBox._TextChanged += (ss, ee) => { FillDataGrid(searchTxtBox.Text); };
        }

        public void FillDataGrid(string query = "")
        {
            dataGridViewUC.Clear();

            var theaters = Theater.SearchTheaters(query);

            for (int i = 0; i < theaters.Count; i++)
            {
                Theater theater = theaters[i];

                dataGridViewUC.AddRow(new object[] { i + 1, theater.GetTitle(), theater.GetAddress() });
            }
        }
    }
}
