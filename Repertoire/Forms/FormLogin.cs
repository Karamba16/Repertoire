using System.Windows.Forms;

namespace Theaters
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, System.EventArgs e)
        {
            // TryLoginAsVisitor("anatolymakar5135", "1MuV1LKDpbdm32b1");
            // TryLoginAsPersonal("andreymed43312", "9Pp6LKIGZaqD5cmH");
            // this.Close();
        }

        private void logBtn_Click(object sender, System.EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Пожалуйста заполните все поля", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TryLoginAsVisitor(username, password))
            {
                if (!TryLoginAsPersonal(username, password))
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public bool TryLoginAsVisitor(string username, string password)
        {
            if (Visitor.IsUsernameCorrect(username))
            {
                if (Visitor.IsPasswordCorrect(username, password))
                {
                    var visitor = Visitor.GetVisitorByUsername(username);

                    this.Hide();

                    FormVisitor homePage = new FormVisitor(visitor);
                    homePage.ShowDialog();

                    return true;
                }
            }

            return false;
        }



        public bool TryLoginAsPersonal(string username, string password)
        {
            if (Personal.IsUsernameCorrect(username))
            {
                if (Personal.IsPasswordCorrect(username, password))
                {
                    var personal = Personal.GetPersonalByUsername(username);

                    this.Hide();

                    FormPersonal homePage = new FormPersonal(personal);
                    homePage.ShowDialog();

                    return true;
                }
            }

            return false;
        }
    }
}
