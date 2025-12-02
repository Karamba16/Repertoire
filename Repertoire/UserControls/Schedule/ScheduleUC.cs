using System;
using System.Globalization;
using System.Windows.Forms;

namespace Theaters.UserControls
{
    public partial class ScheduleUC : UserControl
    {
        static DateTime currentDT = DateTime.Now;
        static int currentYear = CurrentDT.Year;
        static int currentMonth = CurrentDT.Month;

        public static DateTime CurrentDT { get => currentDT; set => currentDT = value; }
        public static int CurrentYear { get => currentYear; set => currentYear = value; }
        public static int CurrentMonth { get => currentMonth; set => currentMonth = value; }

        public ScheduleUC()
        {
            InitializeComponent();

            this.Load += new EventHandler(OnLoad);
        }

        public virtual void OnLoad(object sender, EventArgs e)
        {
            btnprev.Click += new EventHandler(btnprev_Click);
            btnnext.Click += new EventHandler(btnnext_Click);
            DisplayDays();
        }

        public virtual void DisplayDays()
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(CurrentMonth);
            lbdate.Text = monthName + " " + CurrentYear;

            DateTime startOfTheMonth = new DateTime(CurrentYear, CurrentMonth, 1);

            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                ScheduleItemBlankUC blankItem = new ScheduleItemBlankUC();
                AddItem(blankItem);
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            if (currentMonth == 1)
            {
                currentMonth = 13;
                currentYear--;
            }

            currentMonth -= 1;

            DisplayDays();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            if (currentMonth == 12)
            {
                currentMonth = 0;
                currentYear++;
            }

            currentMonth += 1;

            DisplayDays();
        }

        public void AddItem(UserControl uc)
        {
            flowLayoutPanel.Controls.Add(uc);
        }

        public void SetTopLabel(string text)
        {
            topLabel.Text = text;
        }
    }
}
