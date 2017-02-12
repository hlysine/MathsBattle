using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialLabel : Label, IMaterialControl
    {
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        [Category("Appearance")]
        public bool Primary { get; set; }
        private int _fSize = 11;
        [Category("Appearance")]
        public int FontSize {
            get {
                return _fSize;
            }
            set
            {
                _fSize = value;
                Font = new Font(SkinManager.ROBOTO_REGULAR_11.FontFamily, _fSize);
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            BackColor = Color.Transparent;
            if (Primary)
            {
                ForeColor = SkinManager.GetPrimaryTextColor();
            }
            else
            {
                ForeColor = SkinManager.GetSecondaryTextColor();
            }
            Font = new Font(SkinManager.ROBOTO_REGULAR_11.FontFamily, FontSize);

            BackColorChanged += (sender, args) =>
            {
                if (Primary)
                {
                    ForeColor = SkinManager.GetPrimaryTextColor();
                }
                else
                {
                    ForeColor = SkinManager.GetSecondaryTextColor();
                }
            };
        }
    }
}
