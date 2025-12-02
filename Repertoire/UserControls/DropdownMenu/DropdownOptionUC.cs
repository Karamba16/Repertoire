using System;
using System.Drawing;
using System.Windows.Forms;

namespace Theaters.UserControls
{
    public partial class DropdownOptionUC : UserControl
    {
        int id;

        public DropdownOptionUC(string title, int id, float font_size = 14f)
        {
            InitializeComponent();

            this.id = id;

            button.Text = title;
            button.Font = new Font(button.Font.FontFamily, font_size);

            this.Dock = DockStyle.Bottom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = this.Parent.Parent as DropdownMenuUC;
            menu.OnOptionClick.Invoke(id, e);
        }
    }
}
