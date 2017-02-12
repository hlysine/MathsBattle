using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using MaterialSkin.Animations;
using System;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Collections.Generic;
using System.Linq;

namespace MaterialSkin.Controls
{
    using ControlRenderExtension;
    public partial class MaterialCardPanel : Panel, IMaterialControl
    {
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        private readonly AnimationManager animationManager;
        public bool Primary { get; set; }

        /// <summary>
        /// Switch the background color of the card panel with animation
        /// </summary>
        /// <param name="primary">New Primary value</param>
        /// <param name="location">Location to start animation</param>
        public void ChangePrimary(bool primary, Point location)
        {
            if (primary != Primary)
            {
                Primary = primary;
                animationManager.StartNewAnimation(primary ? AnimationDirection.In : AnimationDirection.Out, location);
            }
        }

        public MaterialCardPanel()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Width = 294; Height = 348; DoubleBuffered = true;
            BackColor = Color.Transparent;
            AutoSize = true;

            animationManager = new AnimationManager(false)
            {
                Increment = 0.08,
                AnimationType = AnimationType.EaseOut
            };
            animationManager.OnAnimationProgress += sender => Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.TextRenderingHint = TextRenderingHint.AntiAlias;

            Color NonColor = SkinManager.GetDisabledOrHintColor();

            var PicBG = DrawHelper.CreateRoundRect(1, 1, 292, 164, 1);
            var UpRoundedRec = DrawHelper.CreateRoundRect(1, 1, 291, 164, 1);
            var BG = DrawHelper.CreateRoundRect(1, 1, Width - 3, Height - 5, 1);
            var ShadowBG = DrawHelper.CreateRoundRect(1, 1, Width - 3, Height - 4, 2);

            G.FillPath(new SolidBrush(NonColor), ShadowBG);
            G.DrawPath(new Pen(NonColor), ShadowBG);
            if (animationManager.IsAnimating())
            {
                G.FillPath(new SolidBrush(SkinManager.GetApplicationBackgroundColor()), BG);
                G.SetClip(BG);
                G.SmoothingMode = SmoothingMode.AntiAlias;
                for (int i = 0; i < animationManager.GetAnimationCount(); i++)
                {
                    var animationValue = animationManager.GetProgress(i);
                    var animationSource = animationManager.GetSource(i);

                    using (Brush rippleBrush = new SolidBrush(SkinManager.ColorScheme.PrimaryColor))
                    {
                        var rippleSize = (int)(animationValue * Math.Max(Width,Height)*2.5);
                        G.FillEllipse(rippleBrush, new Rectangle(animationSource.X - rippleSize / 2, animationSource.Y - rippleSize / 2, rippleSize, rippleSize));
                    }
                }
                G.ResetClip();
                G.SmoothingMode = SmoothingMode.None;
            }
            else
            {
                G.FillPath(new SolidBrush(Primary ? SkinManager.ColorScheme.PrimaryColor : SkinManager.GetApplicationBackgroundColor()), BG);
            }
            G.DrawPath(new Pen(SkinManager.GetDividersColor()), BG);
            this.DrawChildShadow(G);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (DesignMode) return;

            MouseState = MouseState.OUT;
            MouseEnter += (sender, args) =>
            {
                MouseState = MouseState.HOVER;
                Invalidate();
            };
            MouseLeave += (sender, args) =>
            {
                MouseState = MouseState.OUT;
                Invalidate();
            };
            MouseDown += (sender, args) =>
            {
                if (args.Button == MouseButtons.Left)
                {
                    MouseState = MouseState.DOWN;
                    Invalidate();
                }
            };
            MouseUp += (sender, args) =>
            {
                MouseState = MouseState.HOVER;

                Invalidate();
            };
        }
    }
}
