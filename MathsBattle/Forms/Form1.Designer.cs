namespace MathsBattle
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Screens = new MaterialSkin.Controls.MaterialTabControl();
            this.screenStart = new MaterialSkin.Controls.MaterialTabPage();
            this.panelRightDock = new MaterialSkin.Controls.MaterialPanel();
            this.btnStartBattle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExercise = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelTips = new MaterialSkin.Controls.MaterialPanel();
            this.btnNextTip = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPrevTip = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblTips = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.screenGameSettings = new MaterialSkin.Controls.MaterialTabPage();
            this.materialCardPanel1 = new MaterialSkin.Controls.MaterialCardPanel();
            this.btnStartGame = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rb15Minute = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb10Minute = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb5Minute = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb2Minute = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.panelOppFooter = new MaterialSkin.Controls.MaterialPanel();
            this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.screenBattle = new MaterialSkin.Controls.MaterialTabPage();
            this.panelQuestionAlign = new MaterialSkin.Controls.MaterialPanel();
            this.panelBattle = new MaterialSkin.Controls.MaterialPanel();
            this.lblKillBanner = new MaterialSkin.Controls.MaterialLabel();
            this.lblOppMP = new MaterialSkin.Controls.MaterialLabel();
            this.lblMeMP = new MaterialSkin.Controls.MaterialLabel();
            this.lblOppHP = new MaterialSkin.Controls.MaterialLabel();
            this.lblMeHP = new MaterialSkin.Controls.MaterialLabel();
            this.oppCard = new MaterialSkin.Controls.MaterialSmallCard();
            this.meCard = new MaterialSkin.Controls.MaterialSmallCard();
            this.panelCardInfo = new MaterialSkin.Controls.MaterialCardPanel();
            this.lblCardInfo = new MaterialSkin.Controls.MaterialLabel();
            this.lblTimeLeft = new MaterialSkin.Controls.MaterialLabel();
            this.panelOppEffect = new MaterialSkin.Controls.MaterialPanel();
            this.card4 = new MaterialSkin.Controls.MaterialSmallCard();
            this.card3 = new MaterialSkin.Controls.MaterialSmallCard();
            this.card2 = new MaterialSkin.Controls.MaterialSmallCard();
            this.card1 = new MaterialSkin.Controls.MaterialSmallCard();
            this.panelMeEffect = new MaterialSkin.Controls.MaterialPanel();
            this.oppMP = new MaterialSkin.Controls.MaterialProgressBar();
            this.meMP = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.oppHP = new MaterialSkin.Controls.MaterialProgressBar();
            this.meHP = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblOppName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.avatarOpp = new MaterialSkin.Controls.MaterialAvatar();
            this.avatarMe = new MaterialSkin.Controls.MaterialAvatar();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.screenGameOver = new MaterialSkin.Controls.MaterialTabPage();
            this.panelGameOverFooter = new MaterialSkin.Controls.MaterialPanel();
            this.btnGameOverBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblGameResult = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.screenExercise = new MaterialSkin.Controls.MaterialTabPage();
            this.lblExMark = new MaterialSkin.Controls.MaterialLabel();
            this.panelExQuestionAlign = new MaterialSkin.Controls.MaterialPanel();
            this.lblExTime = new MaterialSkin.Controls.MaterialLabel();
            this.ExCountdown = new MaterialSkin.Controls.MaterialProgressBar();
            this.lblExScore = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.timerBattle = new System.Windows.Forms.Timer(this.components);
            this.timerMeRecentCard = new System.Windows.Forms.Timer(this.components);
            this.timerOppRecentCard = new System.Windows.Forms.Timer(this.components);
            this.timerKillBanner = new System.Windows.Forms.Timer(this.components);
            this.timerExercise = new System.Windows.Forms.Timer(this.components);
            this.Screens.SuspendLayout();
            this.screenStart.SuspendLayout();
            this.panelRightDock.SuspendLayout();
            this.panelTips.SuspendLayout();
            this.screenGameSettings.SuspendLayout();
            this.materialCardPanel1.SuspendLayout();
            this.panelOppFooter.SuspendLayout();
            this.screenBattle.SuspendLayout();
            this.panelBattle.SuspendLayout();
            this.panelCardInfo.SuspendLayout();
            this.screenGameOver.SuspendLayout();
            this.panelGameOverFooter.SuspendLayout();
            this.screenExercise.SuspendLayout();
            this.SuspendLayout();
            // 
            // Screens
            // 
            this.Screens.Controls.Add(this.screenStart);
            this.Screens.Controls.Add(this.screenGameSettings);
            this.Screens.Controls.Add(this.screenBattle);
            this.Screens.Controls.Add(this.screenGameOver);
            this.Screens.Controls.Add(this.screenExercise);
            this.Screens.Depth = 0;
            this.Screens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Screens.Location = new System.Drawing.Point(0, 24);
            this.Screens.MouseState = MaterialSkin.MouseState.HOVER;
            this.Screens.Name = "Screens";
            this.Screens.SelectedIndex = 0;
            this.Screens.Size = new System.Drawing.Size(871, 538);
            this.Screens.TabIndex = 0;
            // 
            // screenStart
            // 
            this.screenStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("screenStart.BackgroundImage")));
            this.screenStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenStart.Controls.Add(this.panelRightDock);
            this.screenStart.Controls.Add(this.panelTips);
            this.screenStart.Controls.Add(this.materialLabel1);
            this.screenStart.Depth = 0;
            this.screenStart.Location = new System.Drawing.Point(4, 22);
            this.screenStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenStart.Name = "screenStart";
            this.screenStart.Padding = new System.Windows.Forms.Padding(8);
            this.screenStart.Size = new System.Drawing.Size(863, 512);
            this.screenStart.TabIndex = 0;
            this.screenStart.Text = "Start Screen";
            this.screenStart.UseVisualStyleBackColor = true;
            // 
            // panelRightDock
            // 
            this.panelRightDock.Controls.Add(this.btnStartBattle);
            this.panelRightDock.Controls.Add(this.btnExercise);
            this.panelRightDock.Depth = 5;
            this.panelRightDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightDock.Location = new System.Drawing.Point(665, 8);
            this.panelRightDock.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelRightDock.Name = "panelRightDock";
            this.panelRightDock.Size = new System.Drawing.Size(190, 496);
            this.panelRightDock.TabIndex = 5;
            // 
            // btnStartBattle
            // 
            this.btnStartBattle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartBattle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartBattle.Depth = 0;
            this.btnStartBattle.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnStartBattle.FontSize = 12;
            this.btnStartBattle.Icon = null;
            this.btnStartBattle.Location = new System.Drawing.Point(21, 442);
            this.btnStartBattle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Primary = true;
            this.btnStartBattle.Size = new System.Drawing.Size(161, 45);
            this.btnStartBattle.TabIndex = 4;
            this.btnStartBattle.Text = "Start Battle";
            this.btnStartBattle.ClickAnimationFinished += new MaterialSkin.Controls.MaterialRaisedButton.ClickAnimationFinishedEventHandler(this.btnStartBattle_ClickAnimationFinished);
            // 
            // btnExercise
            // 
            this.btnExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExercise.Depth = 0;
            this.btnExercise.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnExercise.FontSize = 9;
            this.btnExercise.Icon = null;
            this.btnExercise.Location = new System.Drawing.Point(30, 398);
            this.btnExercise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExercise.Name = "btnExercise";
            this.btnExercise.Primary = false;
            this.btnExercise.Size = new System.Drawing.Size(152, 35);
            this.btnExercise.TabIndex = 3;
            this.btnExercise.Text = "Drilling Exercise";
            this.btnExercise.ClickAnimationFinished += new MaterialSkin.Controls.MaterialFlatButton.ClickAnimationFinishedEventHandler(this.btnExercise_ClickAnimationFinished);
            // 
            // panelTips
            // 
            this.panelTips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTips.BackColor = System.Drawing.Color.Transparent;
            this.panelTips.Controls.Add(this.btnNextTip);
            this.panelTips.Controls.Add(this.btnPrevTip);
            this.panelTips.Controls.Add(this.lblTips);
            this.panelTips.Controls.Add(this.materialLabel2);
            this.panelTips.Depth = 5;
            this.panelTips.Location = new System.Drawing.Point(6, 341);
            this.panelTips.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelTips.Name = "panelTips";
            this.panelTips.Size = new System.Drawing.Size(299, 146);
            this.panelTips.TabIndex = 1;
            // 
            // btnNextTip
            // 
            this.btnNextTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextTip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextTip.Depth = 0;
            this.btnNextTip.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnNextTip.FontSize = 9;
            this.btnNextTip.Icon = global::MathsBattle.Properties.Resources.navRightDark;
            this.btnNextTip.Location = new System.Drawing.Point(267, 1);
            this.btnNextTip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextTip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextTip.Name = "btnNextTip";
            this.btnNextTip.Primary = false;
            this.btnNextTip.Size = new System.Drawing.Size(31, 31);
            this.btnNextTip.TabIndex = 3;
            this.btnNextTip.Click += new System.EventHandler(this.btnNextTip_Click);
            // 
            // btnPrevTip
            // 
            this.btnPrevTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevTip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevTip.Depth = 0;
            this.btnPrevTip.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnPrevTip.FontSize = 9;
            this.btnPrevTip.Icon = global::MathsBattle.Properties.Resources.navLeftDark;
            this.btnPrevTip.Location = new System.Drawing.Point(236, 1);
            this.btnPrevTip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrevTip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrevTip.Name = "btnPrevTip";
            this.btnPrevTip.Primary = false;
            this.btnPrevTip.Size = new System.Drawing.Size(31, 31);
            this.btnPrevTip.TabIndex = 2;
            this.btnPrevTip.Click += new System.EventHandler(this.btnPrevTip_Click);
            // 
            // lblTips
            // 
            this.lblTips.BackColor = System.Drawing.Color.Transparent;
            this.lblTips.Depth = 0;
            this.lblTips.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTips.FontSize = 11;
            this.lblTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTips.Location = new System.Drawing.Point(13, 38);
            this.lblTips.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTips.Name = "lblTips";
            this.lblTips.Primary = false;
            this.lblTips.Size = new System.Drawing.Size(272, 97);
            this.lblTips.TabIndex = 1;
            this.lblTips.Text = "No tips yet...";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 13F);
            this.materialLabel2.FontSize = 13;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 9);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Primary = false;
            this.materialLabel2.Size = new System.Drawing.Size(54, 22);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Tips :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 50F);
            this.materialLabel1.FontSize = 50;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 8);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Primary = true;
            this.materialLabel1.Size = new System.Drawing.Size(274, 162);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "MATHS\r\nBATTLE";
            // 
            // screenGameSettings
            // 
            this.screenGameSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("screenGameSettings.BackgroundImage")));
            this.screenGameSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenGameSettings.Controls.Add(this.materialCardPanel1);
            this.screenGameSettings.Controls.Add(this.panelOppFooter);
            this.screenGameSettings.Depth = 0;
            this.screenGameSettings.Location = new System.Drawing.Point(4, 22);
            this.screenGameSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenGameSettings.Name = "screenGameSettings";
            this.screenGameSettings.Padding = new System.Windows.Forms.Padding(8);
            this.screenGameSettings.Size = new System.Drawing.Size(863, 512);
            this.screenGameSettings.TabIndex = 1;
            this.screenGameSettings.Text = "Game Settings";
            this.screenGameSettings.UseVisualStyleBackColor = true;
            // 
            // materialCardPanel1
            // 
            this.materialCardPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCardPanel1.AutoSize = true;
            this.materialCardPanel1.BackColor = System.Drawing.Color.Transparent;
            this.materialCardPanel1.Controls.Add(this.btnStartGame);
            this.materialCardPanel1.Controls.Add(this.rb15Minute);
            this.materialCardPanel1.Controls.Add(this.rb10Minute);
            this.materialCardPanel1.Controls.Add(this.rb5Minute);
            this.materialCardPanel1.Controls.Add(this.rb2Minute);
            this.materialCardPanel1.Controls.Add(this.materialLabel12);
            this.materialCardPanel1.Controls.Add(this.materialLabel9);
            this.materialCardPanel1.Depth = 0;
            this.materialCardPanel1.Location = new System.Drawing.Point(285, 20);
            this.materialCardPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardPanel1.Name = "materialCardPanel1";
            this.materialCardPanel1.Primary = false;
            this.materialCardPanel1.Size = new System.Drawing.Size(330, 421);
            this.materialCardPanel1.TabIndex = 1;
            // 
            // btnStartGame
            // 
            this.btnStartGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartGame.Depth = 0;
            this.btnStartGame.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnStartGame.FontSize = 12;
            this.btnStartGame.Icon = null;
            this.btnStartGame.Location = new System.Drawing.Point(205, 375);
            this.btnStartGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Primary = true;
            this.btnStartGame.Size = new System.Drawing.Size(119, 37);
            this.btnStartGame.TabIndex = 9;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.ClickAnimationFinished += new MaterialSkin.Controls.MaterialRaisedButton.ClickAnimationFinishedEventHandler(this.btnStartGame_ClickAnimationFinished);
            // 
            // rb15Minute
            // 
            this.rb15Minute.Checked = false;
            this.rb15Minute.Depth = 0;
            this.rb15Minute.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb15Minute.Location = new System.Drawing.Point(79, 241);
            this.rb15Minute.Margin = new System.Windows.Forms.Padding(0);
            this.rb15Minute.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb15Minute.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb15Minute.Name = "rb15Minute";
            this.rb15Minute.Ripple = true;
            this.rb15Minute.Size = new System.Drawing.Size(174, 36);
            this.rb15Minute.TabIndex = 8;
            this.rb15Minute.Text = "15 Minutes";
            // 
            // rb10Minute
            // 
            this.rb10Minute.Checked = false;
            this.rb10Minute.Depth = 0;
            this.rb10Minute.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb10Minute.Location = new System.Drawing.Point(79, 205);
            this.rb10Minute.Margin = new System.Windows.Forms.Padding(0);
            this.rb10Minute.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb10Minute.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb10Minute.Name = "rb10Minute";
            this.rb10Minute.Ripple = true;
            this.rb10Minute.Size = new System.Drawing.Size(174, 36);
            this.rb10Minute.TabIndex = 7;
            this.rb10Minute.Text = "10 Minutes";
            // 
            // rb5Minute
            // 
            this.rb5Minute.Checked = false;
            this.rb5Minute.Depth = 0;
            this.rb5Minute.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb5Minute.Location = new System.Drawing.Point(79, 169);
            this.rb5Minute.Margin = new System.Windows.Forms.Padding(0);
            this.rb5Minute.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb5Minute.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb5Minute.Name = "rb5Minute";
            this.rb5Minute.Ripple = true;
            this.rb5Minute.Size = new System.Drawing.Size(174, 36);
            this.rb5Minute.TabIndex = 6;
            this.rb5Minute.Text = "5 Minutes";
            // 
            // rb2Minute
            // 
            this.rb2Minute.Checked = false;
            this.rb2Minute.Depth = 0;
            this.rb2Minute.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb2Minute.Location = new System.Drawing.Point(79, 133);
            this.rb2Minute.Margin = new System.Windows.Forms.Padding(0);
            this.rb2Minute.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb2Minute.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb2Minute.Name = "rb2Minute";
            this.rb2Minute.Ripple = true;
            this.rb2Minute.Size = new System.Drawing.Size(174, 36);
            this.rb2Minute.TabIndex = 5;
            this.rb2Minute.Text = "2 Minutes";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 15F);
            this.materialLabel12.FontSize = 15;
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(48, 73);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Primary = false;
            this.materialLabel12.Size = new System.Drawing.Size(128, 24);
            this.materialLabel12.TabIndex = 3;
            this.materialLabel12.Text = "Game Length";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 20F);
            this.materialLabel9.FontSize = 20;
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(13, 12);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Primary = true;
            this.materialLabel9.Size = new System.Drawing.Size(193, 33);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = "Game Settings";
            // 
            // panelOppFooter
            // 
            this.panelOppFooter.Controls.Add(this.btnBack);
            this.panelOppFooter.Depth = 5;
            this.panelOppFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOppFooter.Location = new System.Drawing.Point(8, 456);
            this.panelOppFooter.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelOppFooter.Name = "panelOppFooter";
            this.panelOppFooter.Padding = new System.Windows.Forms.Padding(8);
            this.panelOppFooter.Size = new System.Drawing.Size(847, 48);
            this.panelOppFooter.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Depth = 0;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnBack.FontSize = 9;
            this.btnBack.Icon = global::MathsBattle.Properties.Resources.backArrow;
            this.btnBack.Location = new System.Drawing.Point(8, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = false;
            this.btnBack.Size = new System.Drawing.Size(92, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.ClickAnimationFinished += new MaterialSkin.Controls.MaterialFlatButton.ClickAnimationFinishedEventHandler(this.btnBack_ClickAnimationFinished);
            // 
            // screenBattle
            // 
            this.screenBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenBattle.Controls.Add(this.panelQuestionAlign);
            this.screenBattle.Controls.Add(this.panelBattle);
            this.screenBattle.Depth = 0;
            this.screenBattle.Location = new System.Drawing.Point(4, 22);
            this.screenBattle.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenBattle.Name = "screenBattle";
            this.screenBattle.Padding = new System.Windows.Forms.Padding(8);
            this.screenBattle.Size = new System.Drawing.Size(863, 512);
            this.screenBattle.TabIndex = 2;
            this.screenBattle.Text = "In Battle";
            this.screenBattle.UseVisualStyleBackColor = true;
            // 
            // panelQuestionAlign
            // 
            this.panelQuestionAlign.Depth = 0;
            this.panelQuestionAlign.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelQuestionAlign.Location = new System.Drawing.Point(614, 8);
            this.panelQuestionAlign.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelQuestionAlign.Name = "panelQuestionAlign";
            this.panelQuestionAlign.Size = new System.Drawing.Size(241, 496);
            this.panelQuestionAlign.TabIndex = 1;
            // 
            // panelBattle
            // 
            this.panelBattle.Controls.Add(this.lblKillBanner);
            this.panelBattle.Controls.Add(this.lblOppMP);
            this.panelBattle.Controls.Add(this.lblMeMP);
            this.panelBattle.Controls.Add(this.lblOppHP);
            this.panelBattle.Controls.Add(this.lblMeHP);
            this.panelBattle.Controls.Add(this.oppCard);
            this.panelBattle.Controls.Add(this.meCard);
            this.panelBattle.Controls.Add(this.panelCardInfo);
            this.panelBattle.Controls.Add(this.lblTimeLeft);
            this.panelBattle.Controls.Add(this.panelOppEffect);
            this.panelBattle.Controls.Add(this.card4);
            this.panelBattle.Controls.Add(this.card3);
            this.panelBattle.Controls.Add(this.card2);
            this.panelBattle.Controls.Add(this.card1);
            this.panelBattle.Controls.Add(this.panelMeEffect);
            this.panelBattle.Controls.Add(this.oppMP);
            this.panelBattle.Controls.Add(this.meMP);
            this.panelBattle.Controls.Add(this.materialLabel7);
            this.panelBattle.Controls.Add(this.materialLabel8);
            this.panelBattle.Controls.Add(this.oppHP);
            this.panelBattle.Controls.Add(this.meHP);
            this.panelBattle.Controls.Add(this.materialLabel6);
            this.panelBattle.Controls.Add(this.materialLabel5);
            this.panelBattle.Controls.Add(this.lblOppName);
            this.panelBattle.Controls.Add(this.materialLabel3);
            this.panelBattle.Controls.Add(this.avatarOpp);
            this.panelBattle.Controls.Add(this.avatarMe);
            this.panelBattle.Controls.Add(this.materialDivider1);
            this.panelBattle.Depth = 5;
            this.panelBattle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBattle.Location = new System.Drawing.Point(8, 8);
            this.panelBattle.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelBattle.Name = "panelBattle";
            this.panelBattle.Padding = new System.Windows.Forms.Padding(8);
            this.panelBattle.Size = new System.Drawing.Size(600, 496);
            this.panelBattle.TabIndex = 0;
            // 
            // lblKillBanner
            // 
            this.lblKillBanner.BackColor = System.Drawing.Color.Transparent;
            this.lblKillBanner.Depth = 0;
            this.lblKillBanner.Font = new System.Drawing.Font("Roboto", 25F);
            this.lblKillBanner.FontSize = 25;
            this.lblKillBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKillBanner.Location = new System.Drawing.Point(-50, 68);
            this.lblKillBanner.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKillBanner.Name = "lblKillBanner";
            this.lblKillBanner.Primary = false;
            this.lblKillBanner.Size = new System.Drawing.Size(700, 52);
            this.lblKillBanner.TabIndex = 28;
            this.lblKillBanner.Text = "Game Start!";
            this.lblKillBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKillBanner.Visible = false;
            this.lblKillBanner.VisibleChanged += new System.EventHandler(this.lblKillBanner_VisibleChanged);
            // 
            // lblOppMP
            // 
            this.lblOppMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOppMP.BackColor = System.Drawing.Color.Transparent;
            this.lblOppMP.Depth = 0;
            this.lblOppMP.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblOppMP.FontSize = 8;
            this.lblOppMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOppMP.Location = new System.Drawing.Point(307, 44);
            this.lblOppMP.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOppMP.Name = "lblOppMP";
            this.lblOppMP.Primary = false;
            this.lblOppMP.Size = new System.Drawing.Size(54, 13);
            this.lblOppMP.TabIndex = 27;
            this.lblOppMP.Text = "0/100";
            this.lblOppMP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMeMP
            // 
            this.lblMeMP.BackColor = System.Drawing.Color.Transparent;
            this.lblMeMP.Depth = 0;
            this.lblMeMP.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblMeMP.FontSize = 8;
            this.lblMeMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMeMP.Location = new System.Drawing.Point(237, 44);
            this.lblMeMP.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMeMP.Name = "lblMeMP";
            this.lblMeMP.Primary = false;
            this.lblMeMP.Size = new System.Drawing.Size(56, 13);
            this.lblMeMP.TabIndex = 26;
            this.lblMeMP.Text = "0/100";
            this.lblMeMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOppHP
            // 
            this.lblOppHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOppHP.BackColor = System.Drawing.Color.Transparent;
            this.lblOppHP.Depth = 0;
            this.lblOppHP.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblOppHP.FontSize = 8;
            this.lblOppHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOppHP.Location = new System.Drawing.Point(333, 15);
            this.lblOppHP.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOppHP.Name = "lblOppHP";
            this.lblOppHP.Primary = false;
            this.lblOppHP.Size = new System.Drawing.Size(56, 13);
            this.lblOppHP.TabIndex = 25;
            this.lblOppHP.Text = "0/100";
            this.lblOppHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMeHP
            // 
            this.lblMeHP.BackColor = System.Drawing.Color.Transparent;
            this.lblMeHP.Depth = 0;
            this.lblMeHP.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblMeHP.FontSize = 8;
            this.lblMeHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMeHP.Location = new System.Drawing.Point(208, 16);
            this.lblMeHP.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMeHP.Name = "lblMeHP";
            this.lblMeHP.Primary = false;
            this.lblMeHP.Size = new System.Drawing.Size(56, 12);
            this.lblMeHP.TabIndex = 24;
            this.lblMeHP.Text = "0/100";
            this.lblMeHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // oppCard
            // 
            this.oppCard.AutoExpand = true;
            this.oppCard.BackColor = System.Drawing.Color.Transparent;
            this.oppCard.Depth = 0;
            this.oppCard.Image = null;
            this.oppCard.Info = null;
            this.oppCard.Location = new System.Drawing.Point(306, 68);
            this.oppCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.oppCard.Name = "oppCard";
            this.oppCard.Primary = false;
            this.oppCard.Size = new System.Drawing.Size(52, 52);
            this.oppCard.TabIndex = 23;
            this.oppCard.Text = "Recent Card";
            // 
            // meCard
            // 
            this.meCard.AutoExpand = true;
            this.meCard.BackColor = System.Drawing.Color.Transparent;
            this.meCard.Depth = 0;
            this.meCard.Image = null;
            this.meCard.Info = null;
            this.meCard.Location = new System.Drawing.Point(110, 68);
            this.meCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.meCard.Name = "meCard";
            this.meCard.Primary = false;
            this.meCard.Size = new System.Drawing.Size(52, 52);
            this.meCard.TabIndex = 22;
            this.meCard.Text = "Recent Card";
            // 
            // panelCardInfo
            // 
            this.panelCardInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCardInfo.AutoSize = true;
            this.panelCardInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelCardInfo.Controls.Add(this.lblCardInfo);
            this.panelCardInfo.Depth = 0;
            this.panelCardInfo.Location = new System.Drawing.Point(11, 376);
            this.panelCardInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelCardInfo.Name = "panelCardInfo";
            this.panelCardInfo.Primary = false;
            this.panelCardInfo.Size = new System.Drawing.Size(182, 111);
            this.panelCardInfo.TabIndex = 21;
            this.panelCardInfo.Visible = false;
            // 
            // lblCardInfo
            // 
            this.lblCardInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardInfo.Depth = 0;
            this.lblCardInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCardInfo.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblCardInfo.FontSize = 9;
            this.lblCardInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCardInfo.Location = new System.Drawing.Point(0, 0);
            this.lblCardInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCardInfo.Name = "lblCardInfo";
            this.lblCardInfo.Primary = false;
            this.lblCardInfo.Size = new System.Drawing.Size(182, 111);
            this.lblCardInfo.TabIndex = 0;
            this.lblCardInfo.Text = "Long Card Info";
            this.lblCardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeLeft.Depth = 0;
            this.lblTimeLeft.Font = new System.Drawing.Font("Roboto", 15F);
            this.lblTimeLeft.FontSize = 15;
            this.lblTimeLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimeLeft.Location = new System.Drawing.Point(247, 0);
            this.lblTimeLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Primary = false;
            this.lblTimeLeft.Size = new System.Drawing.Size(102, 29);
            this.lblTimeLeft.TabIndex = 20;
            this.lblTimeLeft.Text = "00:00";
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOppEffect
            // 
            this.panelOppEffect.Depth = 0;
            this.panelOppEffect.Location = new System.Drawing.Point(306, 126);
            this.panelOppEffect.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelOppEffect.Name = "panelOppEffect";
            this.panelOppEffect.Padding = new System.Windows.Forms.Padding(8);
            this.panelOppEffect.Size = new System.Drawing.Size(198, 343);
            this.panelOppEffect.TabIndex = 19;
            // 
            // card4
            // 
            this.card4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.card4.AutoExpand = true;
            this.card4.BackColor = System.Drawing.Color.Transparent;
            this.card4.Depth = 0;
            this.card4.Image = ((System.Drawing.Image)(resources.GetObject("card4.Image")));
            this.card4.Info = "Card Info";
            this.card4.Location = new System.Drawing.Point(11, 318);
            this.card4.MouseState = MaterialSkin.MouseState.HOVER;
            this.card4.Name = "card4";
            this.card4.Primary = false;
            this.card4.Size = new System.Drawing.Size(52, 52);
            this.card4.TabIndex = 16;
            this.card4.Text = "Card";
            this.card4.Click += new System.EventHandler(this.GameCard_Click);
            this.card4.MouseEnter += new System.EventHandler(this.GameCard_MouseEnter);
            this.card4.MouseLeave += new System.EventHandler(this.GameCard_MouseLeave);
            // 
            // card3
            // 
            this.card3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.card3.AutoExpand = true;
            this.card3.BackColor = System.Drawing.Color.Transparent;
            this.card3.Depth = 0;
            this.card3.Image = ((System.Drawing.Image)(resources.GetObject("card3.Image")));
            this.card3.Info = "Card Info";
            this.card3.Location = new System.Drawing.Point(11, 260);
            this.card3.MouseState = MaterialSkin.MouseState.HOVER;
            this.card3.Name = "card3";
            this.card3.Primary = false;
            this.card3.Size = new System.Drawing.Size(52, 52);
            this.card3.TabIndex = 15;
            this.card3.Text = "Card";
            this.card3.Click += new System.EventHandler(this.GameCard_Click);
            this.card3.MouseEnter += new System.EventHandler(this.GameCard_MouseEnter);
            this.card3.MouseLeave += new System.EventHandler(this.GameCard_MouseLeave);
            // 
            // card2
            // 
            this.card2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.card2.AutoExpand = true;
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.Depth = 0;
            this.card2.Image = ((System.Drawing.Image)(resources.GetObject("card2.Image")));
            this.card2.Info = "Card Info";
            this.card2.Location = new System.Drawing.Point(11, 202);
            this.card2.MouseState = MaterialSkin.MouseState.HOVER;
            this.card2.Name = "card2";
            this.card2.Primary = false;
            this.card2.Size = new System.Drawing.Size(52, 52);
            this.card2.TabIndex = 14;
            this.card2.Text = "Card";
            this.card2.Click += new System.EventHandler(this.GameCard_Click);
            this.card2.MouseEnter += new System.EventHandler(this.GameCard_MouseEnter);
            this.card2.MouseLeave += new System.EventHandler(this.GameCard_MouseLeave);
            // 
            // card1
            // 
            this.card1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.card1.AutoExpand = true;
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.Depth = 0;
            this.card1.Image = ((System.Drawing.Image)(resources.GetObject("card1.Image")));
            this.card1.Info = "Card Info";
            this.card1.Location = new System.Drawing.Point(11, 144);
            this.card1.MouseState = MaterialSkin.MouseState.HOVER;
            this.card1.Name = "card1";
            this.card1.Primary = false;
            this.card1.Size = new System.Drawing.Size(52, 52);
            this.card1.TabIndex = 13;
            this.card1.Text = "Card";
            this.card1.Click += new System.EventHandler(this.GameCard_Click);
            this.card1.MouseEnter += new System.EventHandler(this.GameCard_MouseEnter);
            this.card1.MouseLeave += new System.EventHandler(this.GameCard_MouseLeave);
            // 
            // panelMeEffect
            // 
            this.panelMeEffect.Depth = 0;
            this.panelMeEffect.Location = new System.Drawing.Point(94, 126);
            this.panelMeEffect.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelMeEffect.Name = "panelMeEffect";
            this.panelMeEffect.Padding = new System.Windows.Forms.Padding(8);
            this.panelMeEffect.Size = new System.Drawing.Size(198, 343);
            this.panelMeEffect.TabIndex = 18;
            // 
            // oppMP
            // 
            this.oppMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oppMP.DecreaseHighlight = true;
            this.oppMP.Depth = 0;
            this.oppMP.Location = new System.Drawing.Point(367, 47);
            this.oppMP.MouseState = MaterialSkin.MouseState.HOVER;
            this.oppMP.Name = "oppMP";
            this.oppMP.OnRight = true;
            this.oppMP.Size = new System.Drawing.Size(138, 5);
            this.oppMP.TabIndex = 12;
            // 
            // meMP
            // 
            this.meMP.DecreaseHighlight = true;
            this.meMP.Depth = 0;
            this.meMP.Location = new System.Drawing.Point(94, 47);
            this.meMP.MouseState = MaterialSkin.MouseState.HOVER;
            this.meMP.Name = "meMP";
            this.meMP.OnRight = false;
            this.meMP.Size = new System.Drawing.Size(137, 5);
            this.meMP.TabIndex = 11;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 9F);
            this.materialLabel7.FontSize = 9;
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(512, 43);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Primary = false;
            this.materialLabel7.Size = new System.Drawing.Size(23, 14);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "CD";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 9F);
            this.materialLabel8.FontSize = 9;
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(512, 29);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Primary = false;
            this.materialLabel8.Size = new System.Drawing.Size(23, 14);
            this.materialLabel8.TabIndex = 9;
            this.materialLabel8.Text = "HP";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // oppHP
            // 
            this.oppHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oppHP.DecreaseHighlight = true;
            this.oppHP.Depth = 0;
            this.oppHP.Location = new System.Drawing.Point(306, 33);
            this.oppHP.MouseState = MaterialSkin.MouseState.HOVER;
            this.oppHP.Name = "oppHP";
            this.oppHP.OnRight = true;
            this.oppHP.Size = new System.Drawing.Size(199, 5);
            this.oppHP.TabIndex = 8;
            // 
            // meHP
            // 
            this.meHP.DecreaseHighlight = true;
            this.meHP.Depth = 0;
            this.meHP.Location = new System.Drawing.Point(94, 33);
            this.meHP.MouseState = MaterialSkin.MouseState.HOVER;
            this.meHP.Name = "meHP";
            this.meHP.OnRight = false;
            this.meHP.Size = new System.Drawing.Size(198, 5);
            this.meHP.TabIndex = 7;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 9F);
            this.materialLabel6.FontSize = 9;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(65, 43);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Primary = false;
            this.materialLabel6.Size = new System.Drawing.Size(25, 14);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "MP";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 9F);
            this.materialLabel5.FontSize = 9;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(65, 29);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Primary = false;
            this.materialLabel5.Size = new System.Drawing.Size(23, 14);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "HP";
            // 
            // lblOppName
            // 
            this.lblOppName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOppName.AutoSize = true;
            this.lblOppName.BackColor = System.Drawing.Color.Transparent;
            this.lblOppName.Depth = 0;
            this.lblOppName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOppName.FontSize = 11;
            this.lblOppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOppName.Location = new System.Drawing.Point(417, 12);
            this.lblOppName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOppName.Name = "lblOppName";
            this.lblOppName.Primary = false;
            this.lblOppName.Size = new System.Drawing.Size(88, 18);
            this.lblOppName.TabIndex = 4;
            this.lblOppName.Text = "Opponent 1";
            this.lblOppName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.FontSize = 11;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(91, 12);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Primary = false;
            this.materialLabel3.Size = new System.Drawing.Size(35, 18);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "You";
            // 
            // avatarOpp
            // 
            this.avatarOpp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarOpp.Depth = 0;
            this.avatarOpp.IconSize = 48;
            this.avatarOpp.Image = null;
            this.avatarOpp.Location = new System.Drawing.Point(541, 11);
            this.avatarOpp.MouseState = MaterialSkin.MouseState.HOVER;
            this.avatarOpp.Name = "avatarOpp";
            this.avatarOpp.Primary = false;
            this.avatarOpp.Size = new System.Drawing.Size(48, 48);
            this.avatarOpp.TabIndex = 2;
            this.avatarOpp.Text = "CPU";
            // 
            // avatarMe
            // 
            this.avatarMe.Depth = 0;
            this.avatarMe.IconSize = 48;
            this.avatarMe.Image = null;
            this.avatarMe.Location = new System.Drawing.Point(11, 11);
            this.avatarMe.MouseState = MaterialSkin.MouseState.HOVER;
            this.avatarMe.Name = "avatarMe";
            this.avatarMe.Primary = true;
            this.avatarMe.Size = new System.Drawing.Size(48, 48);
            this.avatarMe.TabIndex = 1;
            this.avatarMe.Text = "You";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 2;
            this.materialDivider1.Location = new System.Drawing.Point(299, 39);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 400);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // screenGameOver
            // 
            this.screenGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenGameOver.Controls.Add(this.panelGameOverFooter);
            this.screenGameOver.Controls.Add(this.lblGameResult);
            this.screenGameOver.Controls.Add(this.materialLabel13);
            this.screenGameOver.Depth = 0;
            this.screenGameOver.Location = new System.Drawing.Point(4, 22);
            this.screenGameOver.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenGameOver.Name = "screenGameOver";
            this.screenGameOver.Padding = new System.Windows.Forms.Padding(8);
            this.screenGameOver.Size = new System.Drawing.Size(863, 512);
            this.screenGameOver.TabIndex = 3;
            this.screenGameOver.Text = "Game Over";
            this.screenGameOver.UseVisualStyleBackColor = true;
            // 
            // panelGameOverFooter
            // 
            this.panelGameOverFooter.Controls.Add(this.btnGameOverBack);
            this.panelGameOverFooter.Depth = 5;
            this.panelGameOverFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGameOverFooter.Location = new System.Drawing.Point(8, 456);
            this.panelGameOverFooter.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelGameOverFooter.Name = "panelGameOverFooter";
            this.panelGameOverFooter.Padding = new System.Windows.Forms.Padding(8);
            this.panelGameOverFooter.Size = new System.Drawing.Size(847, 48);
            this.panelGameOverFooter.TabIndex = 2;
            // 
            // btnGameOverBack
            // 
            this.btnGameOverBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGameOverBack.Depth = 0;
            this.btnGameOverBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGameOverBack.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnGameOverBack.FontSize = 9;
            this.btnGameOverBack.Icon = global::MathsBattle.Properties.Resources.backArrow;
            this.btnGameOverBack.Location = new System.Drawing.Point(8, 8);
            this.btnGameOverBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGameOverBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGameOverBack.Name = "btnGameOverBack";
            this.btnGameOverBack.Primary = false;
            this.btnGameOverBack.Size = new System.Drawing.Size(92, 32);
            this.btnGameOverBack.TabIndex = 0;
            this.btnGameOverBack.Text = "Back";
            this.btnGameOverBack.ClickAnimationFinished += new MaterialSkin.Controls.MaterialFlatButton.ClickAnimationFinishedEventHandler(this.btnGameOverBack_ClickAnimationFinished);
            // 
            // lblGameResult
            // 
            this.lblGameResult.BackColor = System.Drawing.Color.Transparent;
            this.lblGameResult.Depth = 0;
            this.lblGameResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGameResult.Font = new System.Drawing.Font("Roboto", 25F);
            this.lblGameResult.FontSize = 25;
            this.lblGameResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGameResult.Location = new System.Drawing.Point(8, 57);
            this.lblGameResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Primary = true;
            this.lblGameResult.Size = new System.Drawing.Size(847, 72);
            this.lblGameResult.TabIndex = 1;
            this.lblGameResult.Text = "You Lose";
            this.lblGameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel13
            // 
            this.materialLabel13.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 15F);
            this.materialLabel13.FontSize = 15;
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(8, 8);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Primary = false;
            this.materialLabel13.Size = new System.Drawing.Size(847, 49);
            this.materialLabel13.TabIndex = 0;
            this.materialLabel13.Text = "Game Over";
            this.materialLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // screenExercise
            // 
            this.screenExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenExercise.Controls.Add(this.lblExMark);
            this.screenExercise.Controls.Add(this.panelExQuestionAlign);
            this.screenExercise.Controls.Add(this.lblExTime);
            this.screenExercise.Controls.Add(this.ExCountdown);
            this.screenExercise.Controls.Add(this.lblExScore);
            this.screenExercise.Controls.Add(this.materialLabel15);
            this.screenExercise.Controls.Add(this.materialLabel14);
            this.screenExercise.Controls.Add(this.materialLabel4);
            this.screenExercise.Depth = 0;
            this.screenExercise.Location = new System.Drawing.Point(4, 22);
            this.screenExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenExercise.Name = "screenExercise";
            this.screenExercise.Padding = new System.Windows.Forms.Padding(8);
            this.screenExercise.Size = new System.Drawing.Size(863, 512);
            this.screenExercise.TabIndex = 4;
            this.screenExercise.Text = "Drilling Exercise";
            this.screenExercise.UseVisualStyleBackColor = true;
            // 
            // lblExMark
            // 
            this.lblExMark.BackColor = System.Drawing.Color.Transparent;
            this.lblExMark.Depth = 0;
            this.lblExMark.Font = new System.Drawing.Font("Roboto", 35F);
            this.lblExMark.FontSize = 35;
            this.lblExMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExMark.Location = new System.Drawing.Point(608, 21);
            this.lblExMark.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblExMark.Name = "lblExMark";
            this.lblExMark.Primary = false;
            this.lblExMark.Size = new System.Drawing.Size(227, 60);
            this.lblExMark.TabIndex = 8;
            this.lblExMark.Text = "0%";
            this.lblExMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelExQuestionAlign
            // 
            this.panelExQuestionAlign.Depth = 0;
            this.panelExQuestionAlign.Location = new System.Drawing.Point(63, 169);
            this.panelExQuestionAlign.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelExQuestionAlign.Name = "panelExQuestionAlign";
            this.panelExQuestionAlign.Size = new System.Drawing.Size(723, 236);
            this.panelExQuestionAlign.TabIndex = 7;
            // 
            // lblExTime
            // 
            this.lblExTime.AutoSize = true;
            this.lblExTime.BackColor = System.Drawing.Color.Transparent;
            this.lblExTime.Depth = 0;
            this.lblExTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblExTime.FontSize = 11;
            this.lblExTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExTime.Location = new System.Drawing.Point(791, 95);
            this.lblExTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblExTime.Name = "lblExTime";
            this.lblExTime.Primary = false;
            this.lblExTime.Size = new System.Drawing.Size(44, 18);
            this.lblExTime.TabIndex = 5;
            this.lblExTime.Text = "00:00";
            // 
            // ExCountdown
            // 
            this.ExCountdown.DecreaseHighlight = false;
            this.ExCountdown.Depth = 0;
            this.ExCountdown.Location = new System.Drawing.Point(90, 101);
            this.ExCountdown.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExCountdown.Name = "ExCountdown";
            this.ExCountdown.OnRight = false;
            this.ExCountdown.Size = new System.Drawing.Size(689, 5);
            this.ExCountdown.TabIndex = 4;
            // 
            // lblExScore
            // 
            this.lblExScore.AutoSize = true;
            this.lblExScore.BackColor = System.Drawing.Color.Transparent;
            this.lblExScore.Depth = 0;
            this.lblExScore.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblExScore.FontSize = 11;
            this.lblExScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExScore.Location = new System.Drawing.Point(95, 63);
            this.lblExScore.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblExScore.Name = "lblExScore";
            this.lblExScore.Primary = false;
            this.lblExScore.Size = new System.Drawing.Size(38, 18);
            this.lblExScore.TabIndex = 3;
            this.lblExScore.Text = "0 / 0";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 13F);
            this.materialLabel15.FontSize = 13;
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(25, 93);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Primary = false;
            this.materialLabel15.Size = new System.Drawing.Size(60, 22);
            this.materialLabel15.TabIndex = 2;
            this.materialLabel15.Text = "Time: ";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 13F);
            this.materialLabel14.FontSize = 13;
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(25, 61);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Primary = false;
            this.materialLabel14.Size = new System.Drawing.Size(64, 22);
            this.materialLabel14.TabIndex = 1;
            this.materialLabel14.Text = "Score: ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 20F);
            this.materialLabel4.FontSize = 20;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(22, 21);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Primary = false;
            this.materialLabel4.Size = new System.Drawing.Size(208, 33);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Drilling Exercise";
            // 
            // timerBattle
            // 
            this.timerBattle.Interval = 1000;
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // timerMeRecentCard
            // 
            this.timerMeRecentCard.Interval = 3000;
            this.timerMeRecentCard.Tick += new System.EventHandler(this.timerMeRecentCard_Tick);
            // 
            // timerOppRecentCard
            // 
            this.timerOppRecentCard.Interval = 3000;
            this.timerOppRecentCard.Tick += new System.EventHandler(this.timerOppRecentCard_Tick);
            // 
            // timerKillBanner
            // 
            this.timerKillBanner.Interval = 3000;
            this.timerKillBanner.Tick += new System.EventHandler(this.timerKillBanner_Tick);
            // 
            // timerExercise
            // 
            this.timerExercise.Interval = 1000;
            this.timerExercise.Tick += new System.EventHandler(this.timerExercise_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 562);
            this.Controls.Add(this.Screens);
            this.Depth = 2;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Maths Battle";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Screens.ResumeLayout(false);
            this.screenStart.ResumeLayout(false);
            this.screenStart.PerformLayout();
            this.panelRightDock.ResumeLayout(false);
            this.panelTips.ResumeLayout(false);
            this.panelTips.PerformLayout();
            this.screenGameSettings.ResumeLayout(false);
            this.screenGameSettings.PerformLayout();
            this.materialCardPanel1.ResumeLayout(false);
            this.materialCardPanel1.PerformLayout();
            this.panelOppFooter.ResumeLayout(false);
            this.screenBattle.ResumeLayout(false);
            this.panelBattle.ResumeLayout(false);
            this.panelBattle.PerformLayout();
            this.panelCardInfo.ResumeLayout(false);
            this.screenGameOver.ResumeLayout(false);
            this.panelGameOverFooter.ResumeLayout(false);
            this.screenExercise.ResumeLayout(false);
            this.screenExercise.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl Screens;
        private MaterialSkin.Controls.MaterialTabPage screenStart;
        private MaterialSkin.Controls.MaterialTabPage screenGameSettings;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialPanel panelTips;
        private MaterialSkin.Controls.MaterialFlatButton btnExercise;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartBattle;
        private MaterialSkin.Controls.MaterialPanel panelRightDock;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialPanel panelOppFooter;
        private MaterialSkin.Controls.MaterialFlatButton btnBack;
        private MaterialSkin.Controls.MaterialTabPage screenBattle;
        private MaterialSkin.Controls.MaterialPanel panelBattle;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialProgressBar meHP;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblOppName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialAvatar avatarOpp;
        private MaterialSkin.Controls.MaterialAvatar avatarMe;
        private MaterialSkin.Controls.MaterialProgressBar oppMP;
        private MaterialSkin.Controls.MaterialProgressBar meMP;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialProgressBar oppHP;
        private MaterialSkin.Controls.MaterialSmallCard card4;
        private MaterialSkin.Controls.MaterialSmallCard card3;
        private MaterialSkin.Controls.MaterialSmallCard card2;
        private MaterialSkin.Controls.MaterialSmallCard card1;
        private MaterialSkin.Controls.MaterialPanel panelMeEffect;
        private MaterialSkin.Controls.MaterialPanel panelOppEffect;
        private MaterialSkin.Controls.MaterialPanel panelQuestionAlign;
        private MaterialSkin.Controls.MaterialCardPanel materialCardPanel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartGame;
        private MaterialSkin.Controls.MaterialRadioButton rb15Minute;
        private MaterialSkin.Controls.MaterialRadioButton rb10Minute;
        private MaterialSkin.Controls.MaterialRadioButton rb5Minute;
        private MaterialSkin.Controls.MaterialRadioButton rb2Minute;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.Timer timerBattle;
        private MaterialSkin.Controls.MaterialLabel lblTimeLeft;
        private MaterialSkin.Controls.MaterialCardPanel panelCardInfo;
        private MaterialSkin.Controls.MaterialLabel lblCardInfo;
        private MaterialSkin.Controls.MaterialSmallCard oppCard;
        private MaterialSkin.Controls.MaterialSmallCard meCard;
        private System.Windows.Forms.Timer timerMeRecentCard;
        private System.Windows.Forms.Timer timerOppRecentCard;
        private MaterialSkin.Controls.MaterialLabel lblOppMP;
        private MaterialSkin.Controls.MaterialLabel lblMeMP;
        private MaterialSkin.Controls.MaterialLabel lblOppHP;
        private MaterialSkin.Controls.MaterialLabel lblMeHP;
        private MaterialSkin.Controls.MaterialTabPage screenGameOver;
        private MaterialSkin.Controls.MaterialLabel lblGameResult;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialPanel panelGameOverFooter;
        private MaterialSkin.Controls.MaterialFlatButton btnGameOverBack;
        private MaterialSkin.Controls.MaterialLabel lblKillBanner;
        private System.Windows.Forms.Timer timerKillBanner;
        private MaterialSkin.Controls.MaterialTabPage screenExercise;
        private MaterialSkin.Controls.MaterialLabel lblExTime;
        private MaterialSkin.Controls.MaterialProgressBar ExCountdown;
        private MaterialSkin.Controls.MaterialLabel lblExScore;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialPanel panelExQuestionAlign;
        private System.Windows.Forms.Timer timerExercise;
        private MaterialSkin.Controls.MaterialFlatButton btnPrevTip;
        private MaterialSkin.Controls.MaterialLabel lblTips;
        private MaterialSkin.Controls.MaterialFlatButton btnNextTip;
        private MaterialSkin.Controls.MaterialLabel lblExMark;
    }
}

