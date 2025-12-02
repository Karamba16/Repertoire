using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Theaters
{
    public partial class FormPersonal : Form
    {
        Personal personal;
        Theater theater;

        public Stack<UserControl> userControls = new Stack<UserControl>();

        public FormPersonal(Personal personal)
        {
            InitializeComponent();

            this.personal = personal;
            this.theater = personal.GetTheater();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            navbarUC.OnClickEvent += (o, ee) =>
            {
                var item = Convert.ToString(o);

                if (item == "Главная")
                {
                    panelContainer.ReplaceWith(new PersonalHomePage(personal));
                }
                else if (item == "Выступления")
                {
                    panelContainer.ReplaceWith(new PersonalSchedule(theater));
                }
            };

            navbarUC.AddItem("Главная", true);
            navbarUC.AddItem("Выступления", false);
        }
    }
}
