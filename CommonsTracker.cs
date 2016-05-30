using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

namespace CommonsTracker
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components;
		//the configdata.cs will be used to get all xml data
        ConfigData clsConfig;
        CommonsDB clsCommonsDB;
        private GroupBox groupBox2;
        private CheckBox ckBackHall;
        private CheckBox ckClients;
        private CheckBox ckTidy;
        private CheckBox ckComputers;
        private CheckBox ckPaper;
        private CheckBox ckQueue;
        private Label label2;
        private Label lblLastTime;
        private Button button2;
        private Label lblLaptop;
        private Label lblQueue;
        private TextBox txtLaptop;
        private TextBox txtQueue;
        private TextBox txtOther;
        private Button btnSubmitt;
        private ListBox lbIssues;
        private Button btnApp1;
        private Button btnApp2;
        private Button btnApp3;
        private Button btnApp4;
        private Button btnApp5;
        private Button btnApp6;
        private GroupBox groupBox1;
        private Label label1;
        private Button cbSnooze;
        private Label lblStatus;
        private CheckBox cbTopWin;
        private Button btnClientHelp;
        private GroupBox groupBox3;
        private CheckedListBox clbxHelp;
        private Timer tmFlashClientHelp;
        private PictureBox pbAlert;
        private Timer timer_clientHelp;
        private Timer tmMaxWindow;
        private Timer tmFlash;
        private Timer tmCheckRounds;
        private TabControl tabPage;
        private TabPage tabMain;
        private TabPage tabConfig;
        private ListBox lstDept;
        private Label label3;
        private Button btnDeptChange;
        private Button button1;
        private Label lblDeptName;
        private Label label4;
        private Button btnSelect;
        private Label lblDisplayProblem;
        private Label lable5;
        SortedDictionary<int, string> clientHelpIssues;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			clsConfig =  new ConfigData();
			clsCommonsDB = new CommonsDB();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckBackHall = new System.Windows.Forms.CheckBox();
            this.ckClients = new System.Windows.Forms.CheckBox();
            this.ckTidy = new System.Windows.Forms.CheckBox();
            this.ckComputers = new System.Windows.Forms.CheckBox();
            this.ckPaper = new System.Windows.Forms.CheckBox();
            this.ckQueue = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLastTime = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblLaptop = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.txtLaptop = new System.Windows.Forms.TextBox();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.btnSubmitt = new System.Windows.Forms.Button();
            this.lbIssues = new System.Windows.Forms.ListBox();
            this.btnApp1 = new System.Windows.Forms.Button();
            this.btnApp2 = new System.Windows.Forms.Button();
            this.btnApp3 = new System.Windows.Forms.Button();
            this.btnApp4 = new System.Windows.Forms.Button();
            this.btnApp5 = new System.Windows.Forms.Button();
            this.btnApp6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSnooze = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbTopWin = new System.Windows.Forms.CheckBox();
            this.btnClientHelp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDisplayProblem = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.clbxHelp = new System.Windows.Forms.CheckedListBox();
            this.tmFlashClientHelp = new System.Windows.Forms.Timer(this.components);
            this.pbAlert = new System.Windows.Forms.PictureBox();
            this.timer_clientHelp = new System.Windows.Forms.Timer(this.components);
            this.tmMaxWindow = new System.Windows.Forms.Timer(this.components);
            this.tmFlash = new System.Windows.Forms.Timer(this.components);
            this.tmCheckRounds = new System.Windows.Forms.Timer(this.components);
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeptChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDept = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlert)).BeginInit();
            this.tabPage.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ckBackHall);
            this.groupBox2.Controls.Add(this.ckClients);
            this.groupBox2.Controls.Add(this.ckTidy);
            this.groupBox2.Controls.Add(this.ckComputers);
            this.groupBox2.Controls.Add(this.ckPaper);
            this.groupBox2.Controls.Add(this.ckQueue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblLastTime);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.lblLaptop);
            this.groupBox2.Controls.Add(this.lblQueue);
            this.groupBox2.Controls.Add(this.txtLaptop);
            this.groupBox2.Controls.Add(this.txtQueue);
            this.groupBox2.Location = new System.Drawing.Point(397, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 296);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hourly Rounds";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ckBackHall
            // 
            this.ckBackHall.Location = new System.Drawing.Point(6, 138);
            this.ckBackHall.Name = "ckBackHall";
            this.ckBackHall.Size = new System.Drawing.Size(128, 16);
            this.ckBackHall.TabIndex = 14;
            this.ckBackHall.Text = "Check Backhall";
            // 
            // ckClients
            // 
            this.ckClients.Location = new System.Drawing.Point(6, 116);
            this.ckClients.Name = "ckClients";
            this.ckClients.Size = new System.Drawing.Size(128, 16);
            this.ckClients.TabIndex = 13;
            this.ckClients.Text = "Talk with Clients";
            // 
            // ckTidy
            // 
            this.ckTidy.Location = new System.Drawing.Point(6, 92);
            this.ckTidy.Name = "ckTidy";
            this.ckTidy.Size = new System.Drawing.Size(128, 16);
            this.ckTidy.TabIndex = 12;
            this.ckTidy.Text = "Tidy Commons Area";
            // 
            // ckComputers
            // 
            this.ckComputers.AccessibleDescription = "Test";
            this.ckComputers.AccessibleName = "Test";
            this.ckComputers.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.ckComputers.Location = new System.Drawing.Point(6, 68);
            this.ckComputers.Name = "ckComputers";
            this.ckComputers.Size = new System.Drawing.Size(120, 16);
            this.ckComputers.TabIndex = 11;
            this.ckComputers.Text = "Check Computers";
            // 
            // ckPaper
            // 
            this.ckPaper.Location = new System.Drawing.Point(6, 44);
            this.ckPaper.Name = "ckPaper";
            this.ckPaper.Size = new System.Drawing.Size(144, 16);
            this.ckPaper.TabIndex = 10;
            this.ckPaper.Text = "Refill Paper in Printers";
            // 
            // ckQueue
            // 
            this.ckQueue.Location = new System.Drawing.Point(6, 20);
            this.ckQueue.Name = "ckQueue";
            this.ckQueue.Size = new System.Drawing.Size(120, 16);
            this.ckQueue.TabIndex = 9;
            this.ckQueue.Text = "Check Queue";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(50, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Time Entered:";
            // 
            // lblLastTime
            // 
            this.lblLastTime.Location = new System.Drawing.Point(111, 254);
            this.lblLastTime.Name = "lblLastTime";
            this.lblLastTime.Size = new System.Drawing.Size(72, 32);
            this.lblLastTime.TabIndex = 7;
            this.lblLastTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastTime.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(2, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 32);
            this.button2.TabIndex = 6;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblLaptop
            // 
            this.lblLaptop.Location = new System.Drawing.Point(2, 216);
            this.lblLaptop.Name = "lblLaptop";
            this.lblLaptop.Size = new System.Drawing.Size(56, 16);
            this.lblLaptop.TabIndex = 5;
            this.lblLaptop.Text = "Laptops";
            // 
            // lblQueue
            // 
            this.lblQueue.Location = new System.Drawing.Point(2, 191);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(56, 16);
            this.lblQueue.TabIndex = 3;
            this.lblQueue.Text = "Queue";
            // 
            // txtLaptop
            // 
            this.txtLaptop.Location = new System.Drawing.Point(82, 216);
            this.txtLaptop.Name = "txtLaptop";
            this.txtLaptop.Size = new System.Drawing.Size(80, 20);
            this.txtLaptop.TabIndex = 2;
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(82, 191);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(80, 20);
            this.txtQueue.TabIndex = 0;
            this.txtQueue.TextChanged += new System.EventHandler(this.txtQueue_TextChanged);
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(5, 33);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(176, 20);
            this.txtOther.TabIndex = 8;
            this.txtOther.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOther_KeyUp);
            this.txtOther.TextChanged += new System.EventHandler(this.txtOther_TextChanged);
            // 
            // btnSubmitt
            // 
            this.btnSubmitt.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmitt.BackgroundImage")));
            this.btnSubmitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitt.ForeColor = System.Drawing.Color.White;
            this.btnSubmitt.Location = new System.Drawing.Point(5, 335);
            this.btnSubmitt.Name = "btnSubmitt";
            this.btnSubmitt.Size = new System.Drawing.Size(176, 32);
            this.btnSubmitt.TabIndex = 10;
            this.btnSubmitt.Text = "Enter";
            this.btnSubmitt.UseVisualStyleBackColor = false;
            this.btnSubmitt.Click += new System.EventHandler(this.btnSubmitt_Click);
            // 
            // lbIssues
            // 
            this.lbIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssues.ForeColor = System.Drawing.Color.Black;
            this.lbIssues.ItemHeight = 16;
            this.lbIssues.Location = new System.Drawing.Point(5, 61);
            this.lbIssues.Name = "lbIssues";
            this.lbIssues.Size = new System.Drawing.Size(176, 276);
            this.lbIssues.TabIndex = 12;
            this.lbIssues.SelectedIndexChanged += new System.EventHandler(this.lbIssues_SelectedIndexChanged);
            this.lbIssues.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbIssues_KeyUp);
            // 
            // btnApp1
            // 
            this.btnApp1.Image = ((System.Drawing.Image)(resources.GetObject("btnApp1.Image")));
            this.btnApp1.Location = new System.Drawing.Point(13, 20);
            this.btnApp1.Name = "btnApp1";
            this.btnApp1.Size = new System.Drawing.Size(169, 32);
            this.btnApp1.TabIndex = 0;
            this.btnApp1.Text = "xx";
            this.btnApp1.Click += new System.EventHandler(this.btnApp1_Click);
            // 
            // btnApp2
            // 
            this.btnApp2.Image = ((System.Drawing.Image)(resources.GetObject("btnApp2.Image")));
            this.btnApp2.Location = new System.Drawing.Point(13, 64);
            this.btnApp2.Name = "btnApp2";
            this.btnApp2.Size = new System.Drawing.Size(169, 32);
            this.btnApp2.TabIndex = 1;
            this.btnApp2.Text = "xx";
            this.btnApp2.Click += new System.EventHandler(this.btnApp2_Click);
            // 
            // btnApp3
            // 
            this.btnApp3.Image = ((System.Drawing.Image)(resources.GetObject("btnApp3.Image")));
            this.btnApp3.Location = new System.Drawing.Point(13, 110);
            this.btnApp3.Name = "btnApp3";
            this.btnApp3.Size = new System.Drawing.Size(169, 32);
            this.btnApp3.TabIndex = 2;
            this.btnApp3.Text = "xx";
            this.btnApp3.Click += new System.EventHandler(this.btnApp3_Click);
            // 
            // btnApp4
            // 
            this.btnApp4.Image = ((System.Drawing.Image)(resources.GetObject("btnApp4.Image")));
            this.btnApp4.Location = new System.Drawing.Point(13, 156);
            this.btnApp4.Name = "btnApp4";
            this.btnApp4.Size = new System.Drawing.Size(169, 32);
            this.btnApp4.TabIndex = 3;
            this.btnApp4.Text = "xx";
            this.btnApp4.Click += new System.EventHandler(this.btnApp4_Click);
            // 
            // btnApp5
            // 
            this.btnApp5.Image = ((System.Drawing.Image)(resources.GetObject("btnApp5.Image")));
            this.btnApp5.Location = new System.Drawing.Point(13, 202);
            this.btnApp5.Name = "btnApp5";
            this.btnApp5.Size = new System.Drawing.Size(169, 32);
            this.btnApp5.TabIndex = 4;
            this.btnApp5.Text = "xx";
            this.btnApp5.Click += new System.EventHandler(this.btnApp5_Click);
            // 
            // btnApp6
            // 
            this.btnApp6.Image = ((System.Drawing.Image)(resources.GetObject("btnApp6.Image")));
            this.btnApp6.Location = new System.Drawing.Point(13, 250);
            this.btnApp6.Name = "btnApp6";
            this.btnApp6.Size = new System.Drawing.Size(169, 32);
            this.btnApp6.TabIndex = 5;
            this.btnApp6.Text = "Closing Procedures";
            this.btnApp6.Click += new System.EventHandler(this.btnApp6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnApp1);
            this.groupBox1.Controls.Add(this.btnApp6);
            this.groupBox1.Controls.Add(this.btnApp5);
            this.groupBox1.Controls.Add(this.btnApp4);
            this.groupBox1.Controls.Add(this.btnApp3);
            this.groupBox1.Controls.Add(this.btnApp2);
            this.groupBox1.Location = new System.Drawing.Point(181, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 296);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Links";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "If \"other\" please enter the issue";
            // 
            // cbSnooze
            // 
            this.cbSnooze.BackColor = System.Drawing.Color.Transparent;
            this.cbSnooze.Location = new System.Drawing.Point(30, 384);
            this.cbSnooze.Name = "cbSnooze";
            this.cbSnooze.Size = new System.Drawing.Size(75, 23);
            this.cbSnooze.TabIndex = 20;
            this.cbSnooze.Text = "Snooze";
            this.cbSnooze.UseVisualStyleBackColor = false;
            this.cbSnooze.Visible = false;
            this.cbSnooze.Click += new System.EventHandler(this.cbSnooze_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(109, 367);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(671, 56);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Hourly Rounds (Check Queue, Laptops, & Back Hallway)";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // cbTopWin
            // 
            this.cbTopWin.BackColor = System.Drawing.Color.Transparent;
            this.cbTopWin.Checked = true;
            this.cbTopWin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTopWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTopWin.ForeColor = System.Drawing.Color.White;
            this.cbTopWin.Location = new System.Drawing.Point(3, 418);
            this.cbTopWin.Name = "cbTopWin";
            this.cbTopWin.Size = new System.Drawing.Size(104, 16);
            this.cbTopWin.TabIndex = 19;
            this.cbTopWin.Text = "Top Window";
            this.cbTopWin.UseVisualStyleBackColor = false;
            this.cbTopWin.CheckedChanged += new System.EventHandler(this.cbTopWin_CheckedChanged);
            // 
            // btnClientHelp
            // 
            this.btnClientHelp.Location = new System.Drawing.Point(12, 242);
            this.btnClientHelp.Name = "btnClientHelp";
            this.btnClientHelp.Size = new System.Drawing.Size(92, 32);
            this.btnClientHelp.TabIndex = 23;
            this.btnClientHelp.Text = "Client Helped";
            this.btnClientHelp.UseVisualStyleBackColor = true;
            this.btnClientHelp.Click += new System.EventHandler(this.btnClientHelp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblDisplayProblem);
            this.groupBox3.Controls.Add(this.lable5);
            this.groupBox3.Controls.Add(this.btnSelect);
            this.groupBox3.Controls.Add(this.clbxHelp);
            this.groupBox3.Controls.Add(this.btnClientHelp);
            this.groupBox3.Location = new System.Drawing.Point(606, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 296);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client Assistance";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblDisplayProblem
            // 
            this.lblDisplayProblem.AutoSize = true;
            this.lblDisplayProblem.Location = new System.Drawing.Point(69, 280);
            this.lblDisplayProblem.Name = "lblDisplayProblem";
            this.lblDisplayProblem.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayProblem.TabIndex = 26;
            this.lblDisplayProblem.Text = "label5";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Location = new System.Drawing.Point(9, 280);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(48, 13);
            this.lable5.TabIndex = 25;
            this.lable5.Text = "Problem:";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(106, 242);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(59, 19);
            this.btnSelect.TabIndex = 24;
            this.btnSelect.Text = "Select All";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // clbxHelp
            // 
            this.clbxHelp.CheckOnClick = true;
            this.clbxHelp.FormattingEnabled = true;
            this.clbxHelp.Location = new System.Drawing.Point(12, 14);
            this.clbxHelp.Name = "clbxHelp";
            this.clbxHelp.Size = new System.Drawing.Size(152, 229);
            this.clbxHelp.TabIndex = 21;
            this.clbxHelp.MouseHover += new System.EventHandler(this.clbxHelp_MouseHover);
            this.clbxHelp.DoubleClick += new System.EventHandler(this.clbxHelp_DoubleClick);
            this.clbxHelp.SelectedIndexChanged += new System.EventHandler(this.clbxHelp_SelectedIndexChanged);
            this.clbxHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clbxHelp_MouseMove);
            this.clbxHelp.MouseLeave += new System.EventHandler(this.clbxHelp_MouseLeave);
            this.clbxHelp.Click += new System.EventHandler(this.clbxHelp_Click);
            // 
            // tmFlashClientHelp
            // 
            this.tmFlashClientHelp.Interval = 1500;
            this.tmFlashClientHelp.Tick += new System.EventHandler(this.tmFlashClientHelp_Tick);
            // 
            // pbAlert
            // 
            this.pbAlert.Image = ((System.Drawing.Image)(resources.GetObject("pbAlert.Image")));
            this.pbAlert.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbAlert.InitialImage")));
            this.pbAlert.Location = new System.Drawing.Point(717, 266);
            this.pbAlert.Name = "pbAlert";
            this.pbAlert.Size = new System.Drawing.Size(52, 39);
            this.pbAlert.TabIndex = 26;
            this.pbAlert.TabStop = false;
            this.pbAlert.Visible = false;
            this.pbAlert.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer_clientHelp
            // 
            this.timer_clientHelp.Enabled = true;
            this.timer_clientHelp.Interval = 15000;
            this.timer_clientHelp.Tick += new System.EventHandler(this.timer_clientHelp_Tick);
            // 
            // tmMaxWindow
            // 
            this.tmMaxWindow.Interval = 100000;
            this.tmMaxWindow.Tick += new System.EventHandler(this.tmMaxWindow_Tick);
            // 
            // tmFlash
            // 
            this.tmFlash.Interval = 1000;
            this.tmFlash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmCheckRounds
            // 
            this.tmCheckRounds.Enabled = true;
            this.tmCheckRounds.Interval = 3000;
            this.tmCheckRounds.Tick += new System.EventHandler(this.tmCheckRounds_Tick);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabMain);
            this.tabPage.Controls.Add(this.tabConfig);
            this.tabPage.Location = new System.Drawing.Point(-4, 1);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(848, 478);
            this.tabPage.TabIndex = 27;
            // 
            // tabMain
            // 
            this.tabMain.BackgroundImage = global::CommonsTracker.Properties.Resources.trackerBackground;
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.pbAlert);
            this.tabMain.Controls.Add(this.groupBox2);
            this.tabMain.Controls.Add(this.groupBox3);
            this.tabMain.Controls.Add(this.txtOther);
            this.tabMain.Controls.Add(this.cbSnooze);
            this.tabMain.Controls.Add(this.btnSubmitt);
            this.tabMain.Controls.Add(this.cbTopWin);
            this.tabMain.Controls.Add(this.lbIssues);
            this.tabMain.Controls.Add(this.lblStatus);
            this.tabMain.Controls.Add(this.groupBox1);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(840, 452);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            this.tabMain.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.lblDeptName);
            this.tabConfig.Controls.Add(this.label4);
            this.tabConfig.Controls.Add(this.button1);
            this.tabConfig.Controls.Add(this.btnDeptChange);
            this.tabConfig.Controls.Add(this.label3);
            this.tabConfig.Controls.Add(this.lstDept);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(840, 452);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Config";
            this.tabConfig.UseVisualStyleBackColor = true;
            this.tabConfig.Click += new System.EventHandler(this.tabConfig_Click);
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(134, 10);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(35, 13);
            this.lblDeptName.TabIndex = 5;
            this.lblDeptName.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Your Current Group is:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Activate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDeptChange
            // 
            this.btnDeptChange.Enabled = false;
            this.btnDeptChange.Location = new System.Drawing.Point(10, 215);
            this.btnDeptChange.Name = "btnDeptChange";
            this.btnDeptChange.Size = new System.Drawing.Size(122, 42);
            this.btnDeptChange.TabIndex = 2;
            this.btnDeptChange.Text = "Submit";
            this.btnDeptChange.UseVisualStyleBackColor = true;
            this.btnDeptChange.Click += new System.EventHandler(this.btnDeptChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select the group that you are working with.  You must do this in order for this a" +
                "pplication to work";
            // 
            // lstDept
            // 
            this.lstDept.AllowDrop = true;
            this.lstDept.Enabled = false;
            this.lstDept.FormattingEnabled = true;
            this.lstDept.Location = new System.Drawing.Point(10, 98);
            this.lstDept.Name = "lstDept";
            this.lstDept.Size = new System.Drawing.Size(122, 108);
            this.lstDept.TabIndex = 0;
            this.lstDept.SelectedIndexChanged += new System.EventHandler(this.lstDept_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(842, 468);
            this.Controls.Add(this.tabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Commons Tracker 3003 V2.0";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlert)).EndInit();
            this.tabPage.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
		Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            
            //populate the client help checkedlist box
            checkClientHelp();
			System.Console.Write(clsCommonsDB.tmCheckRoundTime());
			loadButtonInfo();
			//populate the issues list box
			foreach(string test in clsConfig.issueLookupHash.Values)
			{
				lbIssues.Items.Add(test);
	
			}
			addToolTips();

            foreach (string test in clsConfig.DeptLookupHash.Values)
            {
                lstDept.Items.Add(test);

            }
            //now config the system depending on the department that is using it.
            if (clsConfig.boolClosingOn == false)  groupBox2.Visible = false;
            if (clsConfig.boolClosingOn == false) tmCheckRounds.Enabled = false;
            if (clsConfig.boolClosingOn == false) btnApp6.Visible = false;

            //populate the department that is selected
            lblDeptName.Text = Properties.Settings.Default.Dept.ToString();


		}
		private void addToolTips()

		{
			//Create a Tooltip Object
			ToolTip toolTip1 = new  System.Windows.Forms.ToolTip (this.components);
			//Attach tooltip to the control
			toolTip1.AutomaticDelay = 1500;
			toolTip1.SetToolTip (ckQueue, "Clients are moved to the front of line. Computers available in back and at other labs.");
			toolTip1.SetToolTip (ckPaper, "Top up all printer’s paper,  make sure all excess print jobs are removed from printer area.");
			toolTip1.SetToolTip (ckComputers, "Logged-off abandoned computers, restart computers that are shutdown or frozen.");
			toolTip1.SetToolTip (ckTidy, "Push in chairs, remove any clutter, and check for hazards");
			toolTip1.SetToolTip (ckClients, "Patrol for gamming, checkup on clients that requested help");
            toolTip1.SetToolTip(ckBackHall, "Check computers, assist clients, and tidy area"); 
			toolTip1.SetToolTip (lblQueue, "How many people are waiting for computers");
			toolTip1.SetToolTip (lblLaptop, "How many people are using laptops around the Commons");
			toolTip1.Active = true; 
			
		}
		public void InsertXML(string theValue)
		{
			try
			{
				XmlDocument doc  = new XmlDocument();
				doc.Load(clsConfig.strDataFile);
				// II. Addition
				// 1. Create a new Book element.
				XmlElement newElem = doc.CreateElement("HelpItem");
			
			
			// Add the Id attribute.
			XmlAttribute newAttr = doc.CreateAttribute("Date");
			newAttr.Value = System.DateTime.Now.ToString();
			XmlAttribute attrProblem = doc.CreateAttribute("Problem");
			attrProblem.Value = theValue;
			newElem.Attributes.Append(newAttr);
			newElem.Attributes.Append(attrProblem);

			// 2a.  Add the new element to the end of the book list.
			doc.DocumentElement.AppendChild(newElem);

			// 2b. Save the modified XML to a file
			doc.PreserveWhitespace = false;
			//XmlTextWriter wrtr = new XmlTextWriter(strDataFile, Encoding.Default);
			//doc.WriteTo(wrtr);
			doc.Save(clsConfig.strDataFile);
			//wrtr.Close();
			}
			catch
			{
				MessageBox.Show("There was a problem saving to -- " + clsConfig.strDataFile + " --please make sure it exists and is formatted properly.  If you want to change the location please edit the TrackerConfig.xml file" ,clsConfig.strErrMsgTitle);
			}
		}

        private Boolean submittForm()
        {
            if (lbIssues.Text.Length != 0)
            {
                if (String.Equals("Other", lbIssues.Text) && (txtOther.Text.Length == 0))
                {
                    MessageBox.Show("You must first state the problem", clsConfig.strErrMsgTitle);
                    txtOther.BackColor = Color.FromName("Highlight");
                    txtOther.Focus();
                    return false;

                }
                else
                {
                    // SCP Delete this July, 2005 InsertXML(lbIssues.Text + " **" + txtOther.Text);
                    //now insert the values in the database  (to replace xml)
                    //note at some point we need to remove the xml from this project
                    //System.Text.RegularExpressions.Regex re = new;

                    Regex objAlphaNumericPattern = new Regex("[^a-zA-Z0-9]+[/s]");
                    //Need to make sure there are no non alpha Numeric char (causes the MYSQL db to throw an error)
                    string strCleanedOther = objAlphaNumericPattern.Replace(txtOther.Text, "");
                    clsCommonsDB.WriteTrackerData(strCleanedOther, lbIssues.Text, clsConfig.strDept, clsConfig.strHostName, clsConfig.strIPAddress);
                   
                    return true;



                }

            }
            else
                MessageBox.Show("Please select an item", clsConfig.strErrMsgTitle);
            return false;

            //InsertXML(CheckRadioValue());

        }
		
        
        private void btnSubmitt_Click(object sender, System.EventArgs e)
		{
            if (submittForm() == true)
            {
                lbIssues.ClearSelected();
                txtOther.Text = null;
            }
		}
		private void gbChoice_Enter(object sender, System.EventArgs e)
		{
		}


		private void panel1_Paint()
		{
		
		}

		private void lbIssues_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtOther.BackColor = Color.FromName("Window");
			
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
		
		private void loadButtonInfo()
		{//take the info from the xml file and then uses this to name the buttons
			btnApp1.Text = clsConfig.strBtn1;
			btnApp2.Text = clsConfig.strBtn2;  
			btnApp3.Text = clsConfig.strBtn3;  
			btnApp4.Text = clsConfig.strBtn4;  
			btnApp5.Text = clsConfig.strBtn5;
		}

		private void txtOther_TextChanged(object sender, System.EventArgs e)
		{
			txtOther.BackColor = Color.FromName("Window");
	
		}

		private void btnApp4_Click(object sender, System.EventArgs e)
		{
			 launchApp(clsConfig.strBtnValue4);
		}

		private void btnApp1_Click(object sender, System.EventArgs e)
		{
			 launchApp(clsConfig.strBtnValue1);
		}

		private void btnApp2_Click(object sender, System.EventArgs e)
		{
			launchApp(clsConfig.strBtnValue2);
		}

		private void btnApp3_Click(object sender, System.EventArgs e)
		{
			launchApp(clsConfig.strBtnValue3);
		}
		private void btnApp5_Click(object sender, System.EventArgs e)
		{
			launchApp(clsConfig.strBtnValue5);
		}
		private void btnApp6_Click(object sender, System.EventArgs e)
		{
            CloseProcedure closing;
            closing = new CloseProcedure();
            closing.ShowDialog();
            //we want the new window to pop up
		}


		
		
		private void launchApp(string theApp)
		{
			try
			{
				System.Diagnostics.Process.Start(@theApp);
			}
			catch
			{
				MessageBox.Show("Could not find--- " + theApp + " ---Please make sure it is in the specified location or change it in the TrackerConfig.xml file" ,clsConfig.strErrMsgTitle);
			}
		}


		private void txtQueue_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void groupBox2_Enter(object sender, System.EventArgs e)
		{
		
		}
		public void InsertRoundsData()
		{
			try
			{
				XmlDocument doc  = new XmlDocument();
				doc.Load(clsConfig.strRoundsFile);
				// II. Addition
				// 1. Create a new Book element.
				XmlElement newElem = doc.CreateElement("round");

				// Add the Id attribute.
				XmlAttribute dateAttr = doc.CreateAttribute("date");
				dateAttr.Value = System.DateTime.Now.ToString("MM/d/yyy HH:mm");
 


				newElem.Attributes.Append(dateAttr);

				XmlAttribute timeAttr = doc.CreateAttribute("time");
				timeAttr.Value = System.DateTime.Now.ToString("HH:mm");
				newElem.Attributes.Append(timeAttr);

				XmlAttribute attrQueue = doc.CreateAttribute("queue");
				attrQueue.Value = txtQueue.Text;
				newElem.Attributes.Append(attrQueue);
			
				XmlAttribute attrlaptop = doc.CreateAttribute("laptop");
				attrlaptop.Value = txtLaptop.Text;
				newElem.Attributes.Append(attrlaptop);

				XmlAttribute attrbackroom = doc.CreateAttribute("backroom");
				newElem.Attributes.Append(attrbackroom);


				// 2a.  Add the new element to the end of the book list.
				doc.DocumentElement.AppendChild(newElem);

				// 2b. Save the modified XML to a file
				doc.PreserveWhitespace = false;
				//XmlTextWriter wrtr = new XmlTextWriter(strDataFile, Encoding.Default);
				//doc.WriteTo(wrtr);
				doc.Save(clsConfig.strRoundsFile);
				//wrtr.Close();
				//add the data to the Commons db

			}
			catch
			{
				MessageBox.Show("There was a problem loading-- " + clsConfig.strRoundsFile + " --please make sure it exists and is formatted properly" ,clsConfig.strErrMsgTitle);
			}

		}
		private void ClearRounds()
		{//clears all the data in the Hourly Rounds group box
			txtQueue.Clear();
			txtLaptop.Clear();
			ckClients.Checked = false;
			ckComputers.Checked = false;
			ckPaper.Checked = false;
			ckQueue.Checked = false;
			ckTidy.Checked = false;
            ckBackHall.Checked = false;
			this.tmCheckRounds.Interval = 3000;

		}
		private void addAttributetoRounds()
		{
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			

			//we want to make sure that everything has been completed before the rounds data can be entered 
			//right now I am not going to include any "check box" data into the xml file.  I do not think we need it
			if ((txtLaptop.Text.Length != 0) && (txtQueue.Text.Length !=  0)
				&& (this.ckClients.Checked == true) && (ckQueue.Checked == true)&& (ckComputers.Checked == true)&& (ckPaper.Checked == true)
				&& (ckTidy.Checked == true) && (ckBackHall.Checked == true))
			
			{
				if (IsInteger(txtLaptop.Text + txtQueue.Text) == true)
				{
					// SCP Delete this July, 2005
					//InsertRoundsData();
					clsCommonsDB.WriteRoundsData(int.Parse(txtQueue.Text),int.Parse(txtLaptop.Text));
					//now clear the data
					ClearRounds();

				}
				else
				{
					MessageBox.Show("All entries must be intergers (Queue, laptop, back corridor)",clsConfig.strErrMsgTitle);
				}
				
				
			}
			else
			
				MessageBox.Show("You must enter values for all three textboxes (Queue, laptop, back corridor)" + 
					" And you must make sure all items listed in the checkboxes have been completed" ,clsConfig.strErrMsgTitle);
				
			
		}
		

		public static bool IsInteger(string theValue)
			//looks to see if the text box values are really intergers if not
			//we should not entered them into the xml file
		{
			try
			{
				Convert.ToInt32(theValue);
				return true;
			} 
			catch 
			{
				return false;
			}
		} //IsInteger

		private void label2_Click(object sender, System.EventArgs e)
		{
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void pbFlash_Click(object sender, System.EventArgs e)
		{
		
		}
		

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			
				if (lblStatus.BackColor.Name == System.Drawing.Color.Red.Name)
					lblStatus.BackColor = System.Drawing.Color.Green;
				else
					lblStatus.BackColor = System.Drawing.Color.Red;


		}

		private void lblStatus_Click(object sender, System.EventArgs e)
		{
		
		}
		
		private void tmCheckRounds_Tick(object sender, System.EventArgs e)
		{
			//I want to check and make sure that data for the rounds is being
			//entered once every hour
			int theCHour = System.DateTime.Now.Hour;
			double theCDay = System.DateTime.Now.Day;
			double theCMinute = System.DateTime.Now.Minute;
			double CurrentTime = (theCMinute/60) + theCHour + theCDay;
			DateTime dtlastRoundTime = DateTime.Parse(clsCommonsDB.tmCheckRoundTime());
			int theRTHour = dtlastRoundTime.Hour;
			double theRTDay = dtlastRoundTime.Day;
			double theRTMinute = dtlastRoundTime.Minute;
			double lastRoundTime = (theRTMinute/60) + theRTHour + theRTDay;
			//if it is less than -1 or if it is greater than 0 then it is time to 
			//launch the reminder.  (e.g. 9:15 - 10:16 = -1 or 9:15 - 19:00 (form the day before)
			if ((lastRoundTime - CurrentTime < -1.00) || (lastRoundTime - CurrentTime > 0))
			{
				tmFlash.Enabled = true;
				lblStatus.Visible = true;
				tmMaxWindow.Enabled = true;
				this.tmCheckRounds.Interval = 3000;
				this.cbSnooze.Visible = true;
				
			}
			else
			{
				tmFlash.Enabled = false;
				lblStatus.Visible = false;
				tmMaxWindow.Enabled = false;
				this.tmCheckRounds.Interval = 3000;
				this.cbSnooze.Visible = false;
				
			}
				
			//want to also post this info on the form
			lblLastTime.Text = dtlastRoundTime.ToLongTimeString();



		}

		private void tmMaxWindow_Tick(object sender, System.EventArgs e)
		{
			//maximizes windows when there is an alert....
			this.WindowState = FormWindowState.Normal;
            tmMaxWindow.Interval = 100000;
            
		}

		private void cbTopWin_CheckedChanged(object sender, System.EventArgs e)
		{
			if (cbTopWin.Checked == false)
				this.TopMost = false;
			else
				this.TopMost = true;

		}

		private void cbSnooze_Click(object sender, System.EventArgs e)
		{
			//shuts off the time for a few minutes
            tmCheckRounds.Interval = 1200000;
            tmMaxWindow.Interval = 1200000;
			tmFlash.Enabled = false;
			lblStatus.Visible = false;
			this.cbSnooze.Visible = false;
            
			
		}

		

		private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			  if(e.KeyCode==Keys.F12)  
			{
				//ConfigData clsConfig
				PastData clsPast;
				clsPast = new PastData();
				clsPast.Show();
			}
		}

        private void lbIssues_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                //if someone hits enter we want to automatically submitted the form.  But first we want 
                //to check to make sure the combo list box help (clbxHelp) does not have anything checked
                //if they do then it maybe for that listbox.  So to be on the safe side the "enter" feature will
                //not work
                if (clbxHelp.Items.Count != 0)
                {
                    string strWarning = "Warning: There are items in the client assistance listbox that have not been checked do you want to continue? ";
                    DialogResult result = MessageBox.Show(strWarning, clsConfig.strErrMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                        if (submittForm() == true)
                        {
                            lbIssues.ClearSelected();
                            txtOther.Text = null;
                        }
                        

                }
                
        }

      

        private void txtOther_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (submittForm() == true)
                {
                    lbIssues.ClearSelected();
                    txtOther.Text = null;
                }
            }
        }

        private void clbxHelp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkClientHelp()
        {
            clientHelpIssues = clsCommonsDB.readClientHelp(Properties.Settings.Default.Dept);
            //now clear the list checkbox
            clbxHelp.Items.Clear();
            IDictionaryEnumerator en = clientHelpIssues.GetEnumerator();
            while(en.MoveNext())
            {
                clbxHelp.Items.Add(en.Value.ToString());
               
             
                
            }
            //and turn off the alarm
            pbAlert.Visible = false;
            tmFlashClientHelp.Enabled = false;
            clbxHelp.BackColor = SystemColors.Window;
        }


        private void btnClientHelp_Click(object sender, EventArgs e)
            //looks at the checkbox list, if something is checked then we need to add that to the
            //db with the problem, the date/time.  To do this it must first get the row unique id from
            //the hash table.
        {
            if (clbxHelp.CheckedIndices.Count > 0)
            {   
                
                foreach (int indexChecked in clbxHelp.CheckedIndices)

                //now get the index and value from the checked box.  Note only the first one will
                //be taken
                {
                    int itemIndex = Convert.ToInt32(indexChecked.ToString());
                    //theComputer comes from 
                    string theComputer = clbxHelp.Items[Convert.ToInt32(indexChecked.ToString())].ToString();
                    string theProblem = lbIssues.Text; //we need to add the issue to the client help entry
                    if (submittForm() == true)
                    {
                        //once we have the first entry in the list checkbox then we need to compare it to the
                        //hash table and match the computer name.  We do this to get the unique id so we can 
                        //add the information into the DB
                        IDictionaryEnumerator en = clientHelpIssues.GetEnumerator();
                        while (en.MoveNext())
                        {
                            //if the value in the list boxed matched the computer name in the datbase then 
                            //we should mark the associate row in the db as done and insert the problem
                            if (en.Value.ToString() == theComputer)
                            {
                                clsCommonsDB.WriteClientHelp(Convert.ToInt32(en.Key.ToString()), theProblem);
                              
                            }

                        }

                        
                    }
                   
                }
                //now clean up the Issues and Other boxes, could not do this
                //before because of the "select all" being select.  The select
                //all needs that information so it could not be erased right away
                //only until the last checkboxed has been done
                lbIssues.ClearSelected();
                txtOther.Text = null;
                
                //and then repopulate the list checkbox
                checkClientHelp();
            }
            else if (clbxHelp.CheckedIndices.Count == 0)
            {MessageBox.Show("You must select at least one computer", clsConfig.strErrMsgTitle);
            //checkClientHelp();
            }
            
            else
            {
                MessageBox.Show("You can only select one computer", clsConfig.strErrMsgTitle);
                checkClientHelp();
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            CloseProcedure closing; 
            closing  = new CloseProcedure();
            closing.ShowDialog();
            //we want the new window to pop up
        }

        private void timer_clientHelp_Tick(object sender, EventArgs e)
        {
            //we need to check to see if anything has changed in the DB (e.g. any clients that need help
            //were added to the list or were helped

             int intervalValue = timer_clientHelp.Interval;
            //reseting timer back to the original value.  We need this to verify that the intervalValue was
            //set to 60000
            timer_clientHelp.Interval = 30000;
            SortedDictionary<int, string> newData = clsCommonsDB.readClientHelp(Properties.Settings.Default.Dept);
            IDictionaryEnumerator en = newData.GetEnumerator();
            Boolean foundValue = false;
            //if the count in the DB does not match the count in the listbox then we know something is diffrent
            if (newData.Count != clientHelpIssues.Count && clbxHelp.CheckedIndices.Count == 0)
            {
                checkClientHelp();
            }
            else if (clbxHelp.CheckedIndices.Count == 0) //if nothing is checked then refresh
            {
                checkClientHelp();
            }   
             else //check the database agiant the checklistbox and see if it needs to be refreshed
            {
                while (en.MoveNext())
                {
                    
                    
                    //if (clientHelpIssues.ContainsValue(en.Value) == false && foundValue == false)
                    //{
                        foundValue = true; //once we have found one we do not need to look any more.

                        //now that we know the checklistbox needs to be update then we check to see
                        //if anything is currently checked, if so then we wait 2 minutes if not then we
                        //update the checklistbox right away

                        if (clbxHelp.CheckedIndices.Count == 0 || intervalValue == 60000)
                        //if they if nothing checked and the intervalValue was already set or
                        //1 minute (60000 milli seconds) we already given
                        {
                            checkClientHelp();

                        }
                        else //set the timer to wait an extra minute until the checked value
                        //is submitted by staff
                        {
                            timer_clientHelp.Interval = 60000;

                        }

                    //}
                }
            }
             //If a there is someone in the queue and they are not checked then we want to alert the staff
            //that someone needs help.  We do this by bringing up the application to the front and displaying the
            //alert images
            if (clbxHelp.CheckedIndices.Count == 0 && clbxHelp.Items.Count != 0)
            {
                tmFlashClientHelp.Enabled = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pbAlert.Visible = false;
            tmFlashClientHelp.Enabled = false;
        }

        private void tmFlashClientHelp_Tick(object sender, EventArgs e)
        {
            if (pbAlert.Visible == true)
            {
                pbAlert.Visible = false;
                clbxHelp.BackColor = Color.Red;
            }
            else if (pbAlert.Visible == false)
            {
                pbAlert.Visible = true;
                clbxHelp.BackColor = SystemColors.Window;
            }

        }

        private void clbxHelp_DoubleClick(object sender, EventArgs e)
        {
            //when there is a double click this will open the default Internet Browser to a list of computers
            //where the appropriate computered is highlighted.  Note you need to pass the name of the computer for
            //this to work (e.g. bear04)
            //http://thecommons.mun.ca/portal/Desktop/helpscreen_webcat.php?hostnames=webcat22:printing 
            //should look something like this: "http://thecommons.mun.ca/portal/ONEPAGE_test/help/helpscreen.php?hostnames=bear01"

            string compName = clbxHelp.Text;
            //compName = "cc-shawn"; //for testing purposes, delete at some point
            string txtProblem = clsCommonsDB.FindClientHelpProblem(compName);
            string compPageUrl = clsConfig.strCompLocationURL;
            launchApp(compPageUrl + compName + ":" + txtProblem);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeptChange_Click(object sender, EventArgs e)
        {
           
            //first we want to know which group/department is using tracker.
            //for this we use the setting properties under the project properties
            //Note: We are using the "user" properties and not the application (easier at this point
            //and each computer will only have one user, for now)
            Properties.Settings.Default.Dept = lstDept.Text;
            Properties.Settings.Default.Save();
            lstDept.Enabled = false;
            btnDeptChange.Enabled = false;
            // now change the label to reflect the new department
            lblDeptName.Text = Properties.Settings.Default.Dept.ToString();
            button1.Enabled = true;
            MessageBox.Show("You must restart the application for this change to take effect");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmPassword theForm = new frmPassword();
            theForm.ShowDialog();
            if (theForm.strPassword.ToString() == "commons")
            {
                lstDept.Enabled = true;
                btnDeptChange.Enabled = true;
                button1.Enabled = false;
                
               
            }
        }

        private void tabConfig_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //selects all the items in the checkbox
            for (int c = 0; c < clbxHelp.Items.Count; c++)
            {
                clbxHelp.SetItemChecked(c, true);
            }
        }

        private void lstDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbxHelp_Click(object sender, EventArgs e)
        {
            string compName = clbxHelp.Text;
            //compName = "cc-shawn"; //for testing purposes, delete at some point
            lblDisplayProblem.Text  = clsCommonsDB.FindClientHelpProblem(compName);
            
        }

        private void clbxHelp_MouseHover(object sender, EventArgs e)
        {

          
            
           
        }

        private void clbxHelp_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            Point MousePositionInClientCoords = clbxHelp.PointToClient(Cursor.Position);
            int indexUnderTheMouse = clbxHelp.IndexFromPoint(MousePositionInClientCoords);
            Point sc = Cursor.Position;
            Point cc = clbxHelp.PointToClient(sc);
            ////string s = Convert.ToString(clbxHelp.Items(indexUnderTheMouse));
            //Graphics g = clbxHelp.CreateGraphics();
            //string theProblem = "Printing";
            if (indexUnderTheMouse > -1)
            {

                //ToolTip1.SetToolTip(clbxHelp, "Problem" + theProblem);
                string compName = clbxHelp.Items[clbxHelp.IndexFromPoint(cc)].ToString();
                lblDisplayProblem.Text = clsCommonsDB.FindClientHelpProblem(compName);

            }
            else
            {
                lblDisplayProblem.Text = "";
                //ToolTip1.SetToolTip(clbxHelp, "");
            }
            //g.Dispose();
        }

        private void clbxHelp_MouseLeave(object sender, EventArgs e)
        {
            lblDisplayProblem.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }







    }
}
