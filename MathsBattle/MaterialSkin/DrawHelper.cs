using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MaterialSkin
{
    namespace ControlRenderExtension
    {
        public static class ControlHelper
        {
            #region Redraw Suspend/Resume
            [DllImport("user32.dll", EntryPoint = "SendMessageA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
            private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
            private const int WM_SETREDRAW = 0xB;

            public static void SuspendDrawing(this Control target)
            {
                SendMessage(target.Handle, WM_SETREDRAW, 0, 0);
            }

            public static void ResumeDrawing(this Control target) { ResumeDrawing(target, true); }
            public static void ResumeDrawing(this Control target, bool redraw)
            {
                SendMessage(target.Handle, WM_SETREDRAW, 1, 0);

                if (redraw)
                {
                    target.Refresh();
                }
            }
            #endregion
        }

        public static class ShadowHelper
        {
            public static void DrawChildShadow(this IMaterialControl target, Graphics g)
            {
                Control panel = (Control)target;
                foreach (IMaterialControl p in panel.Controls.OfType<IMaterialControl>())
                {
                    Control p2 = (Control)p;
                    GraphicsPath GP = new GraphicsPath();
                    GP.AddRectangle(new Rectangle(p2.Left, p2.Top, p2.Width, p2.Height));
                    g.TranslateTransform(p.Depth, p.Depth);
                    for (int i = p.Depth; i >= 1; i--)
                    {
                        g.TranslateTransform(-1f, -1f);                // <== shadow vector!
                        using (Pen pen = new Pen(Color.FromArgb((int)((255-MaterialSkinManager.SHADOW_COLOR.A) * (1 - i / (float)p.Depth)), MaterialSkinManager.SHADOW_COLOR.RemoveAlpha()), 1.75f))
                        {
                            g.DrawPath(pen, GP);
                        }
                    }
                    g.ResetTransform();
                }
            }
        }
    }

    static class DrawHelper
    {
        public static GraphicsPath CreateRoundRect(float x, float y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(x + radius, y, x + width - (radius * 2), y);
            gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90);
            gp.AddLine(x + width, y + radius, x + width, y + height - (radius * 2));
            gp.AddArc(x + width - (radius * 2), y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddLine(x + width - (radius * 2), y + height, x + radius, y + height);
            gp.AddArc(x, y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            gp.AddLine(x, y + height - (radius * 2), x, y + radius);
            gp.AddArc(x, y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            return gp;
        }

        public static GraphicsPath CreateUpRoundRect(float x, float y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddLine(x + radius, y, x + width - (radius * 2), y);
            gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90);

            gp.AddLine(x + width, y + radius, x + width, y + height - (radius * 2) + 1);
            gp.AddArc(x + width - (radius * 2), y + height - (radius * 2), radius * 2, 2, 0, 90);

            gp.AddLine(x + width, y + height, x + radius, y + height);
            gp.AddArc(x, y + height - (radius * 2) + 1, radius * 2, 1, 90, 90);

            gp.AddLine(x, y + height, x, y + radius);
            gp.AddArc(x, y, radius * 2, radius * 2, 180, 90);

            gp.CloseFigure();
            return gp;
        }

        public static GraphicsPath CreateLeftRoundRect(float x, float y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(x + radius, y, x + width - (radius * 2), y);
            gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90);

            gp.AddLine(x + width, y + 0, x + width, y + height);
            gp.AddArc(x + width - (radius * 2), y + height - (1), radius * 2, 1, 0, 90);

            gp.AddLine(x + width - (radius * 2), y + height, x + radius, y + height);
            gp.AddArc(x, y + height - (radius * 2), radius * 2, radius * 2, 90, 90);

            gp.AddLine(x, y + height - (radius * 2), x, y + radius);
            gp.AddArc(x, y, radius * 2, radius * 2, 180, 90);

            gp.CloseFigure();
            return gp;
        }

        public static GraphicsPath CreateRoundRect(Rectangle rect, float radius)
        {
            return CreateRoundRect(rect.X, rect.Y, rect.Width, rect.Height, radius);
        }

        public static Color BlendColor(Color backgroundColor, Color frontColor, double blend)
        {
            double ratio = blend / 255d;
            double invRatio = 1d - ratio;
            int a = (int)((backgroundColor.A * invRatio) + (frontColor.A * ratio));
            int r = (int)((backgroundColor.R * invRatio) + (frontColor.R * ratio));
            int g = (int)((backgroundColor.G * invRatio) + (frontColor.G * ratio));
            int b = (int)((backgroundColor.B * invRatio) + (frontColor.B * ratio));
            return Color.FromArgb(a, r, g, b);
        }

        public static Color BlendColor(Color backgroundColor, Color frontColor)
        {
            return BlendColor(backgroundColor, frontColor, frontColor.A);
        }
    }
}
