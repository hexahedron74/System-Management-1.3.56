
namespace Task_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formControlPanel = new System.Windows.Forms.Panel();
            this.exit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.navBarPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.uiLb_CDrive = new System.Windows.Forms.Label();
            this.programMainTitle = new System.Windows.Forms.Label();
            this.statiticsPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.cpuClockLabel = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel6 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.statistics_betteryLeft_subtitle = new System.Windows.Forms.Label();
            this.statistics_battery_subtitle = new System.Windows.Forms.Label();
            this.statistics_battery = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.statitics_batterySize = new System.Windows.Forms.Label();
            this.statisticsTabMainTitle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.cpuClockTimer = new System.Windows.Forms.Timer(this.components);
            this.dashboard1 = new Task_Manager.dashboard();
            this.cpu1 = new Task_Manager.CPU();
            this.gpu1 = new Task_Manager.GPU();
            this.formControlPanel.SuspendLayout();
            this.navBarPanel.SuspendLayout();
            this.statiticsPanel.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CircleProgressBar1.SuspendLayout();
            this.guna2CustomGradientPanel6.SuspendLayout();
            this.statistics_battery.SuspendLayout();
            this.SuspendLayout();
            // 
            // formControlPanel
            // 
            this.formControlPanel.BackColor = System.Drawing.Color.White;
            this.formControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formControlPanel.BackgroundImage")));
            this.formControlPanel.Controls.Add(this.exit);
            this.formControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formControlPanel.Location = new System.Drawing.Point(0, 0);
            this.formControlPanel.Name = "formControlPanel";
            this.formControlPanel.Size = new System.Drawing.Size(1234, 32);
            this.formControlPanel.TabIndex = 0;
            this.formControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.formControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.formControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // exit
            // 
            this.exit.CheckedState.Parent = this.exit;
            this.exit.CustomImages.Parent = this.exit;
            this.exit.FillColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.HoverState.Parent = this.exit;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1201, 2);
            this.exit.Name = "exit";
            this.exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exit.ShadowDecoration.Parent = this.exit;
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.TabIndex = 16;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // navBarPanel
            // 
            this.navBarPanel.BackColor = System.Drawing.Color.White;
            this.navBarPanel.Controls.Add(this.label3);
            this.navBarPanel.Controls.Add(this.guna2Button4);
            this.navBarPanel.Controls.Add(this.guna2Button3);
            this.navBarPanel.Controls.Add(this.guna2Button2);
            this.navBarPanel.Controls.Add(this.guna2Button1);
            this.navBarPanel.Controls.Add(this.uiLb_CDrive);
            this.navBarPanel.Controls.Add(this.programMainTitle);
            this.navBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarPanel.Location = new System.Drawing.Point(0, 32);
            this.navBarPanel.Name = "navBarPanel";
            this.navBarPanel.ShadowDecoration.Parent = this.navBarPanel;
            this.navBarPanel.Size = new System.Drawing.Size(179, 679);
            this.navBarPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(32, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "PROGRAM MANAGE";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 15;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2Button4.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.Location = new System.Drawing.Point(35, 274);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(141, 32);
            this.guna2Button4.TabIndex = 20;
            this.guna2Button4.Text = "Memory";
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2Button3.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(35, 236);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(141, 32);
            this.guna2Button3.TabIndex = 19;
            this.guna2Button3.Text = "GPU";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(35, 198);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(141, 32);
            this.guna2Button2.TabIndex = 18;
            this.guna2Button2.Text = "CPU";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.Checked = true;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(35, 160);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(141, 32);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Text = "Dashboard";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // uiLb_CDrive
            // 
            this.uiLb_CDrive.AutoSize = true;
            this.uiLb_CDrive.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLb_CDrive.ForeColor = System.Drawing.Color.DimGray;
            this.uiLb_CDrive.Location = new System.Drawing.Point(32, 129);
            this.uiLb_CDrive.Name = "uiLb_CDrive";
            this.uiLb_CDrive.Size = new System.Drawing.Size(48, 15);
            this.uiLb_CDrive.TabIndex = 13;
            this.uiLb_CDrive.Text = "SYSTEM";
            // 
            // programMainTitle
            // 
            this.programMainTitle.AutoSize = true;
            this.programMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.programMainTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(124)))), ((int)(((byte)(206)))));
            this.programMainTitle.Location = new System.Drawing.Point(30, 22);
            this.programMainTitle.Name = "programMainTitle";
            this.programMainTitle.Size = new System.Drawing.Size(113, 26);
            this.programMainTitle.TabIndex = 12;
            this.programMainTitle.Text = "system.info";
            this.programMainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statiticsPanel
            // 
            this.statiticsPanel.BackColor = System.Drawing.Color.White;
            this.statiticsPanel.Controls.Add(this.guna2CustomGradientPanel1);
            this.statiticsPanel.Controls.Add(this.guna2CustomGradientPanel6);
            this.statiticsPanel.Controls.Add(this.statisticsTabMainTitle);
            this.statiticsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.statiticsPanel.Location = new System.Drawing.Point(968, 32);
            this.statiticsPanel.Name = "statiticsPanel";
            this.statiticsPanel.ShadowDecoration.Parent = this.statiticsPanel;
            this.statiticsPanel.Size = new System.Drawing.Size(266, 679);
            this.statiticsPanel.TabIndex = 2;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CircleProgressBar1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(15, 160);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(239, 62);
            this.guna2CustomGradientPanel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(197, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "CPU\r\nTemperature";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.AnimationSpeed = 0.1F;
            this.guna2CircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.Controls.Add(this.cpuClockLabel);
            this.guna2CircleProgressBar1.FillThickness = 5;
            this.guna2CircleProgressBar1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(108, 1);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.RoyalBlue;
            this.guna2CircleProgressBar1.ProgressThickness = 5;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(60, 60);
            this.guna2CircleProgressBar1.TabIndex = 0;
            // 
            // cpuClockLabel
            // 
            this.cpuClockLabel.AutoSize = true;
            this.cpuClockLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuClockLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuClockLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cpuClockLabel.Location = new System.Drawing.Point(16, 23);
            this.cpuClockLabel.Name = "cpuClockLabel";
            this.cpuClockLabel.Size = new System.Drawing.Size(28, 15);
            this.cpuClockLabel.TabIndex = 11;
            this.cpuClockLabel.Text = "000";
            // 
            // guna2CustomGradientPanel6
            // 
            this.guna2CustomGradientPanel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel6.BorderRadius = 20;
            this.guna2CustomGradientPanel6.Controls.Add(this.statistics_betteryLeft_subtitle);
            this.guna2CustomGradientPanel6.Controls.Add(this.statistics_battery_subtitle);
            this.guna2CustomGradientPanel6.Controls.Add(this.statistics_battery);
            this.guna2CustomGradientPanel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2CustomGradientPanel6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2CustomGradientPanel6.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2CustomGradientPanel6.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2CustomGradientPanel6.Location = new System.Drawing.Point(15, 82);
            this.guna2CustomGradientPanel6.Name = "guna2CustomGradientPanel6";
            this.guna2CustomGradientPanel6.ShadowDecoration.Parent = this.guna2CustomGradientPanel6;
            this.guna2CustomGradientPanel6.Size = new System.Drawing.Size(239, 62);
            this.guna2CustomGradientPanel6.TabIndex = 14;
            // 
            // statistics_betteryLeft_subtitle
            // 
            this.statistics_betteryLeft_subtitle.AutoSize = true;
            this.statistics_betteryLeft_subtitle.BackColor = System.Drawing.Color.Transparent;
            this.statistics_betteryLeft_subtitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics_betteryLeft_subtitle.ForeColor = System.Drawing.Color.DimGray;
            this.statistics_betteryLeft_subtitle.Location = new System.Drawing.Point(167, 25);
            this.statistics_betteryLeft_subtitle.Name = "statistics_betteryLeft_subtitle";
            this.statistics_betteryLeft_subtitle.Size = new System.Drawing.Size(67, 15);
            this.statistics_betteryLeft_subtitle.TabIndex = 11;
            this.statistics_betteryLeft_subtitle.Text = "battery left";
            // 
            // statistics_battery_subtitle
            // 
            this.statistics_battery_subtitle.AutoSize = true;
            this.statistics_battery_subtitle.BackColor = System.Drawing.Color.Transparent;
            this.statistics_battery_subtitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics_battery_subtitle.Location = new System.Drawing.Point(5, 21);
            this.statistics_battery_subtitle.Name = "statistics_battery_subtitle";
            this.statistics_battery_subtitle.Size = new System.Drawing.Size(59, 19);
            this.statistics_battery_subtitle.TabIndex = 11;
            this.statistics_battery_subtitle.Text = "Battery";
            // 
            // statistics_battery
            // 
            this.statistics_battery.Animated = true;
            this.statistics_battery.AnimationSpeed = 0.1F;
            this.statistics_battery.BackColor = System.Drawing.Color.Transparent;
            this.statistics_battery.Controls.Add(this.statitics_batterySize);
            this.statistics_battery.FillThickness = 5;
            this.statistics_battery.ImageSize = new System.Drawing.Size(50, 50);
            this.statistics_battery.Location = new System.Drawing.Point(106, 1);
            this.statistics_battery.Name = "statistics_battery";
            this.statistics_battery.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.statistics_battery.ProgressColor2 = System.Drawing.Color.RoyalBlue;
            this.statistics_battery.ProgressThickness = 5;
            this.statistics_battery.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.statistics_battery.ShadowDecoration.Parent = this.statistics_battery;
            this.statistics_battery.Size = new System.Drawing.Size(60, 60);
            this.statistics_battery.TabIndex = 0;
            // 
            // statitics_batterySize
            // 
            this.statitics_batterySize.AutoSize = true;
            this.statitics_batterySize.BackColor = System.Drawing.Color.Transparent;
            this.statitics_batterySize.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statitics_batterySize.ForeColor = System.Drawing.Color.RoyalBlue;
            this.statitics_batterySize.Location = new System.Drawing.Point(12, 23);
            this.statitics_batterySize.Name = "statitics_batterySize";
            this.statitics_batterySize.Size = new System.Drawing.Size(37, 15);
            this.statitics_batterySize.TabIndex = 11;
            this.statitics_batterySize.Text = "000%";
            // 
            // statisticsTabMainTitle
            // 
            this.statisticsTabMainTitle.AutoSize = true;
            this.statisticsTabMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.statisticsTabMainTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsTabMainTitle.Location = new System.Drawing.Point(13, 43);
            this.statisticsTabMainTitle.Name = "statisticsTabMainTitle";
            this.statisticsTabMainTitle.Size = new System.Drawing.Size(88, 26);
            this.statisticsTabMainTitle.TabIndex = 12;
            this.statisticsTabMainTitle.Text = "Statistics";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // mainFormTimer
            // 
            this.mainFormTimer.Interval = 1000;
            this.mainFormTimer.Tick += new System.EventHandler(this.mainFormTimer_Tick);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(179, 32);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(789, 679);
            this.dashboard1.TabIndex = 3;
            // 
            // cpu1
            // 
            this.cpu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.cpu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpu1.Location = new System.Drawing.Point(0, 0);
            this.cpu1.Name = "cpu1";
            this.cpu1.Size = new System.Drawing.Size(1234, 711);
            this.cpu1.TabIndex = 4;
            // 
            // gpu1
            // 
            this.gpu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.gpu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpu1.Location = new System.Drawing.Point(0, 0);
            this.gpu1.Name = "gpu1";
            this.gpu1.Size = new System.Drawing.Size(1234, 711);
            this.gpu1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.statiticsPanel);
            this.Controls.Add(this.navBarPanel);
            this.Controls.Add(this.formControlPanel);
            this.Controls.Add(this.cpu1);
            this.Controls.Add(this.gpu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "system.info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formControlPanel.ResumeLayout(false);
            this.navBarPanel.ResumeLayout(false);
            this.navBarPanel.PerformLayout();
            this.statiticsPanel.ResumeLayout(false);
            this.statiticsPanel.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CircleProgressBar1.ResumeLayout(false);
            this.guna2CircleProgressBar1.PerformLayout();
            this.guna2CustomGradientPanel6.ResumeLayout(false);
            this.guna2CustomGradientPanel6.PerformLayout();
            this.statistics_battery.ResumeLayout(false);
            this.statistics_battery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel statiticsPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel navBarPanel;
        private System.Windows.Forms.Panel formControlPanel;
        private System.Windows.Forms.Label statisticsTabMainTitle;
        private System.Windows.Forms.Label programMainTitle;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel6;
        private System.Windows.Forms.Label statistics_betteryLeft_subtitle;
        private System.Windows.Forms.Label statistics_battery_subtitle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar statistics_battery;
        private System.Windows.Forms.Label statitics_batterySize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer mainFormTimer;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.Label cpuClockLabel;
        private System.Windows.Forms.Label uiLb_CDrive;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CircleButton exit;
        private dashboard dashboard1;
        private CPU cpu1;
        private GPU gpu1;
        private System.Windows.Forms.Timer cpuClockTimer;
    }
}

