using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Theaters.UserControls
{
    public partial class DropdownMenuUC : UserControl
    {
        private string title;
        public EventHandler OnOptionClick;

        public DropdownMenuUC()
        {
            InitializeComponent();
        }

        public void Setup(List<DropdownOptionUC> options, EventHandler selectEvent = null, float fontSize = 14f)
        {
            options.ForEach(option => {
                panel.Controls.Add(option); 
            });

            openBtn.Font = new Font(openBtn.Font.FontFamily, fontSize);

            OnOptionClick = new EventHandler(ToggleOptionsList);
            OnOptionClick += selectEvent;
        }

        public void UpdateOptions(List<DropdownOptionUC> options)
        {
            panel.Controls.Clear();

            options.ForEach(option => {
                panel.Controls.Add(option);
            });
        }


        bool expand = false;

        public string Title { get => title; set { title = value; openBtn.Text = value; this.Invalidate(); } }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                this.Height += 15;

                if (this.Height >= this.MaximumSize.Height)
                {
                    timer.Stop();
                    expand = true;
                }
            }
            else
            {
                this.Height -= 15;

                if (this.Height <= this.MinimumSize.Height)
                {
                    timer.Stop();
                    expand = false;
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(this.MaximumSize.Width, (panel.Controls.Count + 1) * 50);
            this.MinimumSize = new Size(this.MinimumSize.Width, 50);

            ToggleOptionsList(sender, e);
        }

        public void ToggleOptionsList(object sender, EventArgs e)
        {
            timer.Start();
            // var path = Path.Combine(Application.StartupPath, "Resources", expand ? "expand-button.png" : "narrow-button.png");
            // openBtn.Image = Image.FromFile(path);

            var icon = expand ? Properties.Resources.expand_button : Properties.Resources.narrow_button;
            openBtn.Image = icon;
        }

        public void SetTitleFontSize(float fontSize)
        {
            openBtn.Font = new Font(openBtn.Font.FontFamily, fontSize);
        }

    }
}
