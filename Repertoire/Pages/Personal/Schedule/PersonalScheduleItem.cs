using System;
using System.Collections.Generic;
using Theaters.UserControls;

namespace Theaters
{
    class PersonalScheduleItem : ScheduleItemUC
    {
        Theater theater;

        List<Performance> performances;

        public PersonalScheduleItem(Theater theater, DateTime dateTime)
        {
            this.theater = theater;
            this.dateTime = dateTime;
        }

        public override void OnLoad(object sender, EventArgs e)
        {
            performances = theater.GetPerformancesByDate(dateTime);

            var count = performances.Count;

            if (count > 0)
            {
                SetLabel("Выступлений: " + count);
            }

            base.OnLoad(sender, e);
        }

        public override void OnClick(object sender, EventArgs e)
        {
            
            var page = new PersonalPerformancesList(theater, dateTime);

            var form = this.FindForm() as FormPersonal;
            form.userControls.Push(new PersonalSchedule(theater));

            this.ReplaceWith(page);
            
        }
    }
}
