using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;
using System.Text.RegularExpressions;

namespace CommonsTracker
{
	/// <summary>
	/// Summary description for PastData.
	/// </summary>
	public class PastData : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MonthCalendar theCalendar;
		private System.Windows.Forms.Button cmdDataBase;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.TextBox txtIssue;
		private System.Windows.Forms.Label lblLabel;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		//Connection string for MyODBC 3.51
		public const string MyConString = "DRIVER={MySQL ODBC 3.51 Driver};" +
			"SERVER=stretch.cs.mun.ca;" +
			"DATABASE=commons;" +
			"UID=shawncp;" +
			"PASSWORD=1;" +
			"OPTION=3";

		public PastData()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
				if(components != null)
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
			this.theCalendar = new System.Windows.Forms.MonthCalendar();
			this.cmdDataBase = new System.Windows.Forms.Button();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.txtIssue = new System.Windows.Forms.TextBox();
			this.lblLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// theCalendar
			// 
			this.theCalendar.Location = new System.Drawing.Point(160, 16);
			this.theCalendar.Name = "theCalendar";
			this.theCalendar.TabIndex = 2;
			// 
			// cmdDataBase
			// 
			this.cmdDataBase.Location = new System.Drawing.Point(8, 112);
			this.cmdDataBase.Name = "cmdDataBase";
			this.cmdDataBase.Size = new System.Drawing.Size(120, 56);
			this.cmdDataBase.TabIndex = 3;
			this.cmdDataBase.Text = "Add to Database";
			this.cmdDataBase.Click += new System.EventHandler(this.cmdDataBase_Click);
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(8, 80);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(120, 20);
			this.txtDesc.TabIndex = 4;
			this.txtDesc.Text = "";
			// 
			// txtIssue
			// 
			this.txtIssue.Location = new System.Drawing.Point(8, 24);
			this.txtIssue.Name = "txtIssue";
			this.txtIssue.Size = new System.Drawing.Size(120, 20);
			this.txtIssue.TabIndex = 5;
			this.txtIssue.Text = "";
			// 
			// lblLabel
			// 
			this.lblLabel.Location = new System.Drawing.Point(8, 8);
			this.lblLabel.Name = "lblLabel";
			this.lblLabel.Size = new System.Drawing.Size(96, 16);
			this.lblLabel.TabIndex = 7;
			this.lblLabel.Text = "Issue";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Description";
			// 
			// PastData
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(360, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.lblLabel,
																		  this.txtIssue,
																		  this.txtDesc,
																		  this.cmdDataBase,
																		  this.theCalendar});
			this.Name = "PastData";
			this.Text = "PastData";
			this.Load += new System.EventHandler(this.PastData_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void PastData_Load(object sender, System.EventArgs e)
		{
		
		}
		private void WriteTrackerData()
		{
			DateTime dtDate = this.theCalendar.SelectionStart;
			string strDBDate = dtDate.ToString("yyyy-MM-d 05:00:01");
			System.Windows.Forms.MessageBox.Show(dtDate.ToString("yyyy-MM-dd 05:00:01"));
			Regex objAlphaNumericPattern= new Regex("[^a-zA-Z0-9]");
			//Need to make sure there are no non alpha Numeric char (causes the MYSQL db to throw an error)
			
			string strDec = objAlphaNumericPattern.Replace(txtDesc.Text,"");
			string strIssue = objAlphaNumericPattern.Replace(txtIssue.Text,"");
			//Connect to MySQL using MyODBC
			OdbcConnection MyConnection = new OdbcConnection(MyConString);
			MyConnection.Open();

			Console.WriteLine("\n !!! success, connected successfully !!!\n");
			//Insert the record (note: Date/Time is include in the query using now and iID is a auto incremented number
			//OdbcCommand MyCommand = new OdbcCommand("INSERT INTO computingTracker (iID,vchProblem,blOther,dtDate) VALUES(3,'hhhasdafd','jjiekl',now())",MyConnection);
			OdbcCommand MyCommand = new OdbcCommand("INSERT INTO metric_computingTracker (vchProblem,blOther,dtDate) VALUES('" + strIssue + "','" + strDec + "','" + strDBDate + "')",MyConnection);
			MyCommand.ExecuteNonQuery();
			//need to put a try catch block here
			MyConnection.Close();
		}

		private void cmdDataBase_Click(object sender, System.EventArgs e)
		{
			WriteTrackerData();
		}
	}
}
