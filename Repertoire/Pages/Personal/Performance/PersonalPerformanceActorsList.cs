using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Theaters.UserControls;

namespace Theaters
{
    public partial class PersonalPerformanceActorsList : UserControl
    {
        Performance performance;

        List<Actor> actors;

        int actor_id;

        public PersonalPerformanceActorsList(Performance performance)
        {
            InitializeComponent();
            this.performance = performance;
        }

        public delegate void cellClick(int index);

        private void PersonalPerformanceAcrotsList_Load(object sender, EventArgs e)
        {
            var columns = new List<CustomDataGridViewColumn>() {
                new CustomDataGridViewColumn("fullName", "ФИО", 100),
                new CustomDataGridViewColumn("bdate", "Дата рождения", 100),
                new CustomDataGridViewColumn("institution", "Заведение", 150),
                new CustomDataGridViewColumn("delete", "", 100, new cellClick(DeleteActor)),
            };

            dataGridViewUC.Setup(columns);

            FillDataGrid();
        }

        public void FillDataGrid()
        {
            dataGridViewUC.Clear();

            actors = performance.GetActors();

            for (int i = 0; i < actors.Count; i++)
            {
                Actor actor = actors[i];

                dataGridViewUC.AddRow(new object[] { i + 1, actor.GetFullName(), actor.GetBirthdayDate(), actor.GetInstitution(), "Уволить" });
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormPersonal;
            var userControl = form.userControls.Pop();
            this.ReplaceWith(userControl);
        }

        public void DeleteActor(int index)
        {
            var actor = actors[index];
            performance.DeleteActor(actor);
            FillDataGrid();
            UpdateDropdown();
        }

        private void actorsDropdown_Load(object sender, EventArgs e)
        {
            var actors = new List<DropdownOptionUC>() { };

            Actor.GetActors().Select(actor => actor.GetId()).Except(performance.GetActors().Select(actor => actor.GetId())).ToList().ForEach(actor_id =>
            {
                var actor = Actor.GetActorById(actor_id);
                actors.Add(new DropdownOptionUC(actor.GetFullName(), actor_id));
            });

            actorsDropdown.Setup(actors, new EventHandler(OnActorsDropdownChanged));
        }

        public void OnActorsDropdownChanged(object sender, object e)
        {
            actor_id = Convert.ToInt32(sender);
            var actor = Actor.GetActorById(actor_id);
            performance.AddActor(actor);
            FillDataGrid(); 
            UpdateDropdown();
        }

        public void UpdateDropdown()
        {
            var actors = new List<DropdownOptionUC>() { };

            Actor.GetActors().Select(actor => actor.GetId()).Except(performance.GetActors().Select(actor => actor.GetId())).ToList().ForEach(actor_id =>
            {
                var actor = Actor.GetActorById(actor_id);
                actors.Add(new DropdownOptionUC(actor.GetFullName(), actor_id));
            });

            actorsDropdown.UpdateOptions(actors);
        }
    }
}
