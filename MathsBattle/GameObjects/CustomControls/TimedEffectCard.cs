using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace MathsBattle.GameObjects.CustomControls
{
    public class TimedEffectCard : MaterialPanel
    {
        #region From Designer
        private void InitializeComponent()
        {
            this.TEcountdown = new MaterialSkin.Controls.MaterialLabel();
            this.TEtitle = new MaterialSkin.Controls.MaterialLabel();
            this.TEcountdownBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.SuspendLayout();
            // 
            // TEcountdown
            // 
            this.TEcountdown.BackColor = System.Drawing.Color.Transparent;
            this.TEcountdown.Depth = 0;
            this.TEcountdown.Dock = System.Windows.Forms.DockStyle.Left;
            this.TEcountdown.Font = new System.Drawing.Font("Roboto", 15F);
            this.TEcountdown.FontSize = 11;
            this.TEcountdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TEcountdown.Location = new System.Drawing.Point(0, 0);
            this.TEcountdown.Name = "TEcountdown";
            this.TEcountdown.Primary = false;
            this.TEcountdown.Size = new System.Drawing.Size(52, 42);
            this.TEcountdown.TabIndex = 0;
            this.TEcountdown.Text = "0:30";
            this.TEcountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TEtitle
            // 
            this.TEtitle.AutoSize = true;
            this.TEtitle.BackColor = System.Drawing.Color.Transparent;
            this.TEtitle.Depth = 0;
            this.TEtitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.TEtitle.FontSize = 9;
            this.TEtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TEtitle.Location = new System.Drawing.Point(58, 6);
            this.TEtitle.Name = "TEtitle";
            this.TEtitle.Primary = true;
            this.TEtitle.Size = new System.Drawing.Size(119, 18);
            this.TEtitle.TabIndex = 1;
            this.TEtitle.Text = "Time Effect Title";
            // 
            // TEcountdownBar
            // 
            this.TEcountdownBar.DecreaseHighlight = false;
            this.TEcountdownBar.Depth = 0;
            this.TEcountdownBar.Location = new System.Drawing.Point(61, 29);
            this.TEcountdownBar.Name = "TEcountdownBar";
            this.TEcountdownBar.OnRight = false;
            this.TEcountdownBar.Size = new System.Drawing.Size(113, 5);
            this.TEcountdownBar.TabIndex = 2;
            // 
            // TimedEffectCard
            // 
            this.Controls.Add(this.TEcountdownBar);
            this.Controls.Add(this.TEtitle);
            this.Controls.Add(this.TEcountdown);
            this.Name = "TimedEffectCard";
            this.Size = new System.Drawing.Size(182, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MaterialSkin.Controls.MaterialLabel TEcountdown;
        private MaterialSkin.Controls.MaterialLabel TEtitle;
        private MaterialSkin.Controls.MaterialProgressBar TEcountdownBar;
        #endregion

        public delegate void OnClosedEventHandler(TimedEffectCard sender);
        public event OnClosedEventHandler OnClosed;

        AnimationManager am = new AnimationManager()
        {
            Increment = 0.08,
            AnimationType = AnimationType.Linear
        };
        public TimedEffectCard()
        {

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);

            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitializeComponent();
            am.OnAnimationProgress += Am_OnAnimationProgress;
            am.OnAnimationFinished += Am_OnAnimationFinished;
        }

        private void Am_OnAnimationFinished(object sender)
        {
            Height = 0;
            BindedTimedEvent = null;
            Invalidate();
            OnClosed?.Invoke(this);
        }

        private void Am_OnAnimationProgress(object sender)
        {
            Height = (int)(42 - 42 * am.GetProgress());
            Invalidate();
        }

        public override string Text
        {
            get
            {
                if (BindedTimedEvent != null) return BindedTimedEvent.Name;
                return TEtitle.Text;
            }
            set
            {
                TEtitle.Text = value;
            }
        }
        private TimedEvent TE;
        public TimedEvent BindedTimedEvent
        {
            get
            {
                return TE;
            }
            set
            {
                TE = value;
                if (TE != null)
                {
                    TEcountdownBar.Maximum = TE.LoopCount;
                    TEcountdownBar.Value = TE.LoopCount - TE.LoopNo;
                    TEcountdown.Text = new DateTime((TE.LoopCount - TE.LoopNo) * TE.Interval * 10000L).ToString("mm:ss");
                    TEtitle.Text = TE.Name;
                    TE.OnTick += TE_OnTick;
                    TE.OnFinished += TE_OnFinished;
                }
            }
        }

        private void TE_OnFinished(object sender)
        {
            am.StartNewAnimation(AnimationDirection.In);
        }

        private void TE_OnTick(object sender)
        {
            TEcountdown.Text = new DateTime((TE.LoopCount - TE.LoopNo) * TE.Interval * 10000L).ToString("mm:ss");
            TEcountdownBar.Value = TE.LoopCount - TE.LoopNo;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            if (!am.IsAnimating()) Size = new Size(182, 42);
        }
    }
}