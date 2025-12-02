using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Theaters.UserControls;

namespace Theaters
{
    public partial class VisitorHomePage : UserControl
    {
        Visitor visitor;

        public VisitorHomePage(Visitor visitor)
        {
            InitializeComponent();
            this.visitor = visitor;
        }

        private void VisitorHomePage_Load(object sender, System.EventArgs e)
        {
            fullnameLabel.Text = visitor.GetName();
        }
    }
}
