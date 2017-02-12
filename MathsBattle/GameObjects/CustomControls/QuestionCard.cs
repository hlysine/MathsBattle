using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;

namespace MathsBattle.GameObjects.CustomControls
{
    public partial class QuestionCard : UserControl, IMaterialControl
    {
        public QuestionCard()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitializeComponent();
            BackColor = Color.Transparent;
            animationManager = new AnimationManager(false)
            {
                Increment = 0.08,
                AnimationType = AnimationType.EaseOut
            };
            animationManager.OnAnimationProgress += sender => Invalidate();
        }

        private bool Primary = false;
        private readonly AnimationManager animationManager;

        private Question.Question question;
        public Question.Question Question
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
                lblQuestionText.Text = question.QuestionStr;
                btnCheck.Visible = true;
                Primary = false;
                Random rnd = new Random(Environment.TickCount);
                foreach (Control c in Controls)
                {
                    MaterialRadioButton r = c as MaterialRadioButton;
                    if (r != null)
                    {
                        r.Text = null;
                    }
                }
                foreach (string str in question.AnsStr)
                {
                    bool done = false;
                    while (!done)
                    {
                        MaterialRadioButton rb = (MaterialRadioButton)Controls["rbAnswer" + rnd.Next(1, 5).ToString()];
                        if (rb.Text == null)
                        {
                            rb.Text = str;
                            rb.Checked = false;
                            rb.Enabled = true;
                            done = true;
                        }
                    }
                }
                Invalidate();
            }
        }

        public int QuestionNo
        {
            get
            {
                return int.Parse(lblQuestionNo.Text);
            }
            set
            {
                lblQuestionNo.Text = value.ToString();
            }
        }

        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }

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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 238; Width = 240;
        }

        private void ChangePrimary(bool primary, Point loc)
        {
            if (primary != Primary)
            {
                Primary = primary;
                animationManager.StartNewAnimation(primary ? AnimationDirection.In : AnimationDirection.Out, loc);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics G = e.Graphics;
            var BG = DrawHelper.CreateRoundRect(1, 1, Width - 3, Height - 5, 1);
            if (animationManager.IsAnimating())
            {
                G.SetClip(BG);
                G.SmoothingMode = SmoothingMode.AntiAlias;
                for (int i = 0; i < animationManager.GetAnimationCount(); i++)
                {
                    var animationValue = animationManager.GetProgress(i);
                    var animationSource = animationManager.GetSource(i);

                    using (Brush rippleBrush = new SolidBrush(SkinManager.Theme == MaterialSkinManager.Themes.LIGHT ? SkinManager.ColorScheme.LightPrimaryColor : SkinManager.ColorScheme.DarkPrimaryColor))
                    {
                        var rippleSize = (int)(animationValue * Math.Max(Width, Height) * 2.5);
                        G.FillEllipse(rippleBrush, new Rectangle(animationSource.X - rippleSize / 2, animationSource.Y - rippleSize / 2, rippleSize, rippleSize));
                    }
                }
                G.ResetClip();
                G.SmoothingMode = SmoothingMode.None;
            }
            else
            {
                if (Primary) G.FillPath(new SolidBrush(SkinManager.Theme == MaterialSkinManager.Themes.LIGHT ? SkinManager.ColorScheme.LightPrimaryColor : SkinManager.ColorScheme.DarkPrimaryColor), BG);
            }
        }

        public delegate void OnClosedEventHandler(QuestionCard sender);
        public event OnClosedEventHandler OnClosed;

        public delegate void OnAnsweredEventHandler(QuestionCard sender, bool isCorrect);
        public event OnAnsweredEventHandler OnAnswered;

        private void btnCheck_ClickAnimationFinished(object sender)
        {
            if (btnCheck.Text == "Check")
            {
                MaterialRadioButton rb = null;
                foreach (Control c in Controls)
                {
                    MaterialRadioButton r = c as MaterialRadioButton;
                    if (r != null)
                    {
                        if (r.Checked == true) rb = r;
                    }
                }
                if (rb == null) return;
                if (rb.Text == question.CorrectAns)
                {
                    lblAnsResult.Text = "Correct";
                    int boxOffset = rb.Height / 2;
                    ChangePrimary(true, rb.Location + new Size(boxOffset, boxOffset));
                    OnAnswered?.Invoke(this, true);
                }
                else
                {
                    lblAnsResult.Text = "Wrong";
                    foreach (Control c in Controls)
                    {
                        MaterialRadioButton r = c as MaterialRadioButton;
                        if (r != null)
                        {
                            if (r.Text == question.CorrectAns)
                            {
                                r.Enabled = true;
                            }
                            else
                            {
                                r.Enabled = false;
                            }
                        }
                    }
                    OnAnswered?.Invoke(this, false);
                }
                btnCheck.Text = "Close";
            }
            else
            {
                Height = 0;
                OnClosed(this);
            }
        }
    }
}
