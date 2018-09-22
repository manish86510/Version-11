using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCube
{
    class FlatButton : Control
    {
        private SolidBrush borderBrush, textBrush;
        Rectangle borderRectangle;
        private bool active = false;
        private StringFormat stringFormat = new StringFormat();
        public override Cursor Cursor { get; set; } = Cursors.Hand;
        public float BorderThickness { get; set; } = 0;

        public FlatButton()
        {
            borderBrush = new SolidBrush(ColorTranslator.FromHtml("#fff"));
            textBrush = new SolidBrush(ColorTranslator.FromHtml(""));
            base.BackgroundImage = Properties.Resources.unnamed2;
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            this.Paint += FlatButton_Paint;
        }

        private void FlatButton_Paint(object sender, PaintEventArgs e)
        {
            borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
            e.Graphics.DrawString(this.Text, this.Font, (active) ? textBrush : borderBrush, borderRectangle, stringFormat);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackgroundImage = Properties.Resources.unnamed1;
            textBrush = new SolidBrush(ColorTranslator.FromHtml("#00ccff"));
            active = true;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            base.BackgroundImage = Properties.Resources.unnamed1;
            textBrush = new SolidBrush(ColorTranslator.FromHtml("#00ccff"));
            active = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            base.BackgroundImage = Properties.Resources.unnamed2;
            textBrush = new SolidBrush(ColorTranslator.FromHtml("#fff"));
            active = false;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackgroundImage = Properties.Resources.unnamed2;
            textBrush = new SolidBrush(ColorTranslator.FromHtml("#fff"));
            active = false;
        }
    }
}