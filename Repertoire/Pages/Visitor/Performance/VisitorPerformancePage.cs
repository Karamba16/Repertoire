using System;
using System.Windows.Forms;

namespace Theaters
{
    public partial class VisitorPerformancePage : UserControl
    {
        Performance performance;

        public VisitorPerformancePage(Performance performance)
        {
            InitializeComponent();
            this.performance = performance;
        }

        private void VisitorPerformancePage_Load(object sender, EventArgs e)
        {
            titleLabel.Text = performance.GetTitle();
            genreLabel.Text = performance.GetGenre();
            producerLabel.Text = performance.GetProducer();
            descriptionLabel.Text = performance.GetDescription();
            datePicker.Value = performance.GetDate();
            timePicker.Value = performance.GetDate();
            priceLabel.Text = $"{performance.GetPrice()} руб.";
            actorsLabel.Text = "";
            var actors = performance.GetActors();

            actors.ForEach(actor => {
                actorsLabel.Text += actor.GetFullName() + "\n";
            });
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormVisitor;
            var uc = form.userControls.Pop();
            this.ReplaceWith(uc);
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormVisitor;
            var visitor = form.GetVisitor();

            if (!visitor.HasAlreadyOrdered(performance.GetId()))
            {
                visitor.MakeOrder(performance.GetId());
                form.GetNavbar().Select("Билеты");
            }
            else
            {
                MessageBox.Show("Вы уже заказали билет на это выступление");
            }
        }
    }
}
