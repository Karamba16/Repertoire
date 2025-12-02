using System;
using System.Drawing;
using System.Windows.Forms;

namespace Theaters.UserControls
{
    public partial class NavbarItemUC : UserControl
    {
        public string title;
        public bool active;

        public EventHandler OnClickEvent;

        public NavbarUC navbar;

        public Color EnabledColor = Color.RoyalBlue;

        public Color DisabledColor = Color.Black;


        public NavbarItemUC(string title, bool active)
        {
            InitializeComponent();

            this.title = title;
            this.active = active;
        }

        private void TopMenuBtnUC_Load(object sender, EventArgs e)
        {
            btn.Text = title;

            if (active)
            {
                SetEnabled();
            }

            navbar = this.Parent as NavbarUC;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
        }


        public void SetEnabled()
        {
            btn.ForeColor = EnabledColor;
        }

        public void SetDisabled()
        {
            btn.ForeColor = DisabledColor;
        }

        public void OnClick(object sender, EventArgs e)
        {
            OnClickEvent.Invoke(title, e);

            foreach (NavbarItemUC item in this.Parent.Controls)
            {
                item.SetDisabled();
            }

            SetEnabled();

            navbar.SetActiveItem(this);
        }
    }
}
