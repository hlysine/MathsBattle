using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using MaterialSkin.Animations;
using System.Collections.Generic;
using System.Linq;

namespace MaterialSkin.Controls
{
    using ControlRenderExtension;
    public class MaterialAvatar : Panel, IMaterialControl
    {
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        public int IconSize { get; set; } = 48;

        Image image;
        [Category("Appearance")]
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                Invalidate();
            }
        }

        [Category("Appearance"), Browsable(true)]
        public override string Text { get; set; }

        [Category("Appearance"), Browsable(true)]
        public bool Primary { get; set; }


        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Refresh();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Refresh();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Width = IconSize;
            Height = IconSize;
        }

        public MaterialAvatar()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Height = 48; Width = 48; DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.CompositingQuality = CompositingQuality.HighQuality;

            if (image != null)
            {
                GraphicsPath IGP = new GraphicsPath();
                IGP.AddEllipse(0, 0, IconSize - 1, IconSize - 1);
                G.SetClip(IGP);
                G.DrawImage(image, 0, 0, IconSize - 1, IconSize - 1);
                G.ResetClip();
            }
            else
            {
                G.FillEllipse(Primary ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetRaisedButtonBackgroundBrush(), 0, 0, IconSize - 1, IconSize - 1);
                G.DrawString(Text, SkinManager.ROBOTO_MEDIUM_15, SkinManager.GetRaisedButtonTextBrush(Primary), new RectangleF(0, 0, IconSize - 1, IconSize - 1), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
            this.DrawChildShadow(G);
        }
    }
}
