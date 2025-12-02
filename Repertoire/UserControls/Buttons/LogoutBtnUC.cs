using System.Windows.Forms;

namespace Theaters.UserControls
{
    class LogoutBtnUC : ButtonUC
    {
        public LogoutBtnUC()
        {
            this.Text = "Выйти";
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            this.Parent.FindForm().Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.ShowDialog();
        }
    }
}
