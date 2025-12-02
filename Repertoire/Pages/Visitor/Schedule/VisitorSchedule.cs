using System;
using Theaters.UserControls;

namespace Theaters
{
    public partial class VisitorSchedule : ScheduleUC
    {
        public VisitorSchedule()
        {
            InitializeComponent();
        }

        public override void DisplayDays()
        {
            SetTopLabel("Расписание выступлений");

            base.DisplayDays();

            int days = DateTime.DaysInMonth(CurrentYear, CurrentMonth);

            for (int i = 1; i <= days; i++)
            {
                VisitorScheduleItem item = new VisitorScheduleItem(new DateTime(CurrentYear, CurrentMonth, i));
                AddItem(item);
            }
        }
    }
}
