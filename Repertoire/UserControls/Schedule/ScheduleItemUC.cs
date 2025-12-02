using System;
using System.Drawing;
using System.Windows.Forms;

namespace Theaters.UserControls
{
    public partial class ScheduleItemUC : UserControl
    {
        public DateTime dateTime;
        public Color HoverColor = Color.LightSteelBlue;

        public ScheduleItemUC()
        {
            InitializeComponent();

            this.Load += new EventHandler(OnLoad);
        }


        public virtual void OnLoad(object sender, EventArgs e)
        {           
            lbdays.Text = dateTime.Day.ToString();

            panel.MouseEnter += new EventHandler(OnMouseEnter);
            lbdays.MouseEnter += new EventHandler(OnMouseEnter);
            label.MouseEnter += new EventHandler(OnMouseEnter);

            panel.MouseLeave += new EventHandler(OnMouseLeave);
            lbdays.MouseLeave += new EventHandler(OnMouseLeave);
            label.MouseLeave += new EventHandler(OnMouseLeave);

            panel.Click += new EventHandler(OnClick);
            lbdays.Click += new EventHandler(OnClick);
            label.Click += new EventHandler(OnClick);
        }
        public virtual void OnClick(object sender, EventArgs e)
        {

        }

        public void OnMouseEnter(object sender, EventArgs e)
        {
            panel.BackColor = HoverColor;
        }

        public void OnMouseLeave(object sender, EventArgs e)
        {
            panel.BackColor = Color.White;
        }

        public void SetLabel(string value)
        {
            label.Text = value;
        }

        public void SetFont(int value)
        {
            label.Font = new Font(label.Font.FontFamily, value);
        }
    }
}
