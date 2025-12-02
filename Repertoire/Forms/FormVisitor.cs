using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Theaters.UserControls;

namespace Theaters
{
    public partial class FormVisitor : Form
    {
        Visitor visitor;

        public Stack<UserControl> userControls = new Stack<UserControl>();

        public FormVisitor(Visitor visitor)
        {
            InitializeComponent();

            this.visitor = visitor;
        }

        private void FormVisitor_Load(object sender, EventArgs e)
        {
            navbarUC.OnClickEvent += (o, ee) =>
            {
                var item = Convert.ToString(o);

                if (item == "Главная")
                {
                    panelContainer.ReplaceWith(new VisitorHomePage(visitor));
                }
                else if (item == "Билеты")
                {
                    panelContainer.ReplaceWith(new VisitorTicketsList(visitor));
                }
                else if (item == "Расписание")
                {
                    panelContainer.ReplaceWith(new VisitorSchedule());
                }
                else if (item == "Театры")
                {
                    panelContainer.ReplaceWith(new VisitorTheatersList());
                }
            };

            navbarUC.AddItem("Главная", true);
            navbarUC.AddItem("Билеты", false);
            navbarUC.AddItem("Расписание", false);
            navbarUC.AddItem("Театры", false);
        }

        public Visitor GetVisitor() => visitor;

        public NavbarUC GetNavbar() => navbarUC;
    }
}
