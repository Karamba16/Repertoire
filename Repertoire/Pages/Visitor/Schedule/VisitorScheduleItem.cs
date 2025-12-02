using System;
using System.Collections.Generic;
using Theaters.UserControls;

namespace Theaters
{
    public partial class VisitorScheduleItem : ScheduleItemUC
    {
        List<Performance> performances;

        public VisitorScheduleItem(DateTime dateTime)
        {
            InitializeComponent();
            this.dateTime = dateTime;
        }

        public override void OnLoad(object sender, EventArgs e)
        {
            performances = Performance.GetPerformancesByDate(dateTime);

            var count = performances.Count;

            if (count > 0)
            {
                SetLabel("Выступлений: " + count);
            } 

            base.OnLoad(sender, e);
        }

        public override void OnClick(object sender, EventArgs e)
        {
            if (performances.Count > 0)
            {
                var page = new VisitorPerformancesList(dateTime, performances);

                var form = this.FindForm() as FormVisitor;
                form.userControls.Push(new VisitorSchedule());

                this.ReplaceWith(page);
            }
        }
    }
}
