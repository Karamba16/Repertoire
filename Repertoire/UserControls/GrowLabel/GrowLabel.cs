using System;
using System.Drawing;
using System.Windows.Forms;

namespace Theaters.UserControls
{
    class GrowLabel : Label
    {
        private bool mGrowing;

        public GrowLabel()
        {
            this.AutoSize = false;
            this.Font = new Font("Segoe UI", 12f);
        }

        private void resizeLabel()
        {
            if (mGrowing) return;

            try
            {
                mGrowing = true;
                Size sz = new Size(this.Width, Int32.MaxValue);
                sz = TextRenderer.MeasureText(this.Text, this.Font, sz, TextFormatFlags.WordBreak);
                this.Height = sz.Height;
            }
            finally
            {
                mGrowing = false;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            resizeLabel();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            resizeLabel();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            resizeLabel();
        }
    }
}
