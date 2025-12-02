using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Theaters.UserControls
{
    class DatePicker : DateTimePicker
    {
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;

        private bool droppedDown = false;
        public Image calenderIcon = Properties.Resources.calendar_white;
        private RectangleF iconButtonArea;
        private const int calenderIconWidth = 34;
        private const int arrowIconWidth = 17;

        public Color SkinColor 
        {
            get 
            {
                return skinColor; 
            } 
            set 
            { 
                skinColor = value; 
                /*
                if (skinColor.GetBrightness() >= 0.8f)
                {
                    calenderIcon = Properties.Resources.calendar_black;
                }
                else
                {
                    calenderIcon = Properties.Resources.calendar_white;
                }
                */
                this.Invalidate();
            }
        }

        public Color TextColor 
        {
            get
            {
                return textColor;
            }
            set
            {
                textColor = value;
                this.Invalidate();
            } 
        }

        public Color BorderColor
        {
            get
            {
                return borderColor; 
            }
            set 
            { 
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get 
            { 
                return borderSize; 
            }
            set 
            { 
                borderSize = value;
                this.Invalidate();
            }
        }

        public DatePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(new FontFamily("Segoe UI"), 12f);
        }

        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(borderColor, BorderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(TextColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5f, this.Height - 0.5f);
                RectangleF iconArea = new RectangleF(clientArea.Width - calenderIconWidth, 0, calenderIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;

                textFormat.LineAlignment = StringAlignment.Center;

                graphics.FillRectangle(skinBrush, clientArea);

                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);

                if (droppedDown == true)
                {
                    graphics.FillRectangle(openIconBrush, iconArea);
                }

                if (BorderSize >= 1)
                {
                    graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                }

                graphics.DrawImage(calenderIcon, this.Width - calenderIcon.Width - 9, (this.Height - calenderIcon.Height) / 2);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconButtonArea.Contains(e.Location))
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private int GetIconButtonWidth()
        {
            int textWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidth <= this.Width - (calenderIconWidth + 20))
            {
                return calenderIconWidth;
            }

            return arrowIconWidth;
        }
    }
}
