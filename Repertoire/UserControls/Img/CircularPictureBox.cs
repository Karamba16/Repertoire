using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Theaters.UserControls
{
    class CircularPictureBox : PictureBox
    {
        private int borderSize = 2;
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderColor2 = Color.White;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50f;

        public CircularPictureBox()
        {
            this.Size = new Size(200, 200);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public Color BorderColor2 { get => borderColor2; set { borderColor2 = value; this.Invalidate(); } }
        public DashStyle BorderLineStyle { get => borderLineStyle; set { borderLineStyle = value; this.Invalidate(); } }
        public DashCap BorderCapStyle { get => borderCapStyle; set { borderCapStyle = value; this.Invalidate(); } }
        public float GradientAngle { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Height);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSmize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSmize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                this.Region = new Region(pathRegion);
                graph.SmoothingMode = SmoothingMode.AntiAlias;

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                {
                    graph.DrawEllipse(penBorder, rectBorder);
                }
            }
        }
    }
}
