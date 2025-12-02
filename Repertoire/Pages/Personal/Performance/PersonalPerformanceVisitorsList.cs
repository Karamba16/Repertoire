using System.Collections.Generic;
using System.Windows.Forms;
using Theaters.UserControls;

namespace Theaters
{
    public partial class PersonalPerformanceVisitorsList : UserControl
    {
        Performance performance;

        public PersonalPerformanceVisitorsList(Performance performance)
        {
            InitializeComponent();
            this.performance = performance;
        }

        private void PersonalPerformanceVisitorsList_Load(object sender, System.EventArgs e)
        {
            var columns = new List<CustomDataGridViewColumn>() {
                new CustomDataGridViewColumn("fullName", "ФИО", 100),
            };

            dataGridViewUC.Setup(columns);

            FillDataGrid();
        }

        public void FillDataGrid()
        {
            dataGridViewUC.Clear();

            var visitors = performance.GetVisitors();

            for (int i = 0; i < visitors.Count; i++)
            {
                Visitor visitor = visitors[i];

                dataGridViewUC.AddRow(new object[] { i + 1, visitor.GetFullName()});
            }
        }

        private void buttonUC1_Click(object sender, System.EventArgs e)
        {
            var form = this.FindForm() as FormPersonal;
            var userControl = form.userControls.Pop();
            this.ReplaceWith(userControl);
        }
    }
}
