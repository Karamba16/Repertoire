using System;
using Theaters.UserControls;

namespace Theaters
{
    class PersonalSchedule : ScheduleUC
    {
        Theater theater;

        public PersonalSchedule(Theater theater)
        {
            this.theater = theater;
        }

        public override void DisplayDays()
        {
            SetTopLabel("Расписание выступлений");

            base.DisplayDays();

            int days = DateTime.DaysInMonth(CurrentYear, CurrentMonth);

            for (int i = 1; i <= days; i++)
            {
                PersonalScheduleItem item = new PersonalScheduleItem(theater, new DateTime(CurrentYear, CurrentMonth, i));
                AddItem(item);
            }
        }
    }
}
