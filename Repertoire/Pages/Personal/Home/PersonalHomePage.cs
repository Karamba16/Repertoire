using System.Windows.Forms;

namespace Theaters
{
    public partial class PersonalHomePage : UserControl
    {
        Personal personal;

        public PersonalHomePage(Personal personal)
        {
            InitializeComponent();
            this.personal = personal;
        }

        private void PersonalHomePage_Load(object sender, System.EventArgs e)
        {
            fullnameLabel.Text = personal.GetFullName();

            var theater = personal.GetTheater();
            theaterLabel.Text = theater.GetTitle();
            addressLabel.Text = theater.GetAddress();
        }
    }
}
