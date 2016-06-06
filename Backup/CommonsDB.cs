using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace CommonsTracker
{
	/// <summary>
	/// Summary description for CommonsDB.
	/// </summary>
	public class CommonsDB
	{
		//Connection string for MyODBC 3.51
		public const string MyConString = "DRIVER={MySQL ODBC 3.51 Driver};" +
			"SERVER=stretch.cs.mun.ca;" +
			"DATABASE=commons;" +
			"UID=shawncp;" +
			"PASSWORD=1;" +
			"OPTION=3";
		public CommonsDB()
		{
			
			//
			// TODO: Add constructor logic here
			//
		}
	
		public void WriteTrackerData(string other, string problem, string txtDeptName, string txtHostName,string txtCompIP)
		{
            
            //opens a connection to the Commons DB and then writes the 
			//associated record

			//Connect to MySQL using MyODBC
			OdbcConnection MyConnection = new OdbcConnection(MyConString);
			MyConnection.Open();

			Console.WriteLine("\n !!! success, connected successfully !!!\n");
			//Insert the record (note: Date/Time is include in the query using now and iID is a auto incremented number
			//OdbcCommand MyCommand = new OdbcCommand("INSERT INTO computingTracker (iID,vchProblem,blOther,dtDate) VALUES(3,'hhhasdafd','jjiekl',now())",MyConnection);
            OdbcCommand MyCommand = new OdbcCommand("INSERT INTO metric_computingTracker (vchProblem,blOther,dtDate,txtHostName, txtDeptName,txtIPAddress) VALUES('" + problem + "','" + other + "',now(),'" + txtHostName + "','" + txtDeptName + "','" + txtCompIP + "')", MyConnection);
			MyCommand.ExecuteNonQuery();
			//need to put a try catch block here
			MyConnection.Close();
		}

		public void WriteRoundsData(int theQueue, int theLapTop)
		{

			//opens a connection to the Commons DB and then writes the 
			//associated record

			//Connect to MySQL using MyODBC
			OdbcConnection MyConnection = new OdbcConnection(MyConString);
			MyConnection.Open();

			Console.WriteLine("\n !!! success, connected successfully !!!\n");
			//Insert the record (note: Date/Time is include in the query using now and iID is a auto incremented number
			//OdbcCommand MyCommand = new OdbcCommand("INSERT INTO computingTracker (iID,vchProblem,blOther,dtDate) VALUES(3,'hhhasdafd','jjiekl',now())",MyConnection);
			OdbcCommand MyCommand = new OdbcCommand("INSERT INTO metric_rounds (iQueue,iLapTop,dtDate) VALUES(" + theQueue + "," + theLapTop + ",now())",MyConnection);
			MyCommand.ExecuteNonQuery();
			//need to put a try catch block here
			MyConnection.Close();

		}

        public SortedDictionary<int, string> readClientHelp(string strDept)
        {
            //this connectes to the Commons DB and looks for any clients that have requested help via the help button
            //depending on what Dept you belong to (e.g. comp-support).  It also sorts depending on when the call came in
            //Connect to MySQL using MyODBC
            OdbcConnection MyConnection = new OdbcConnection(MyConString);
            MyConnection.Open();
            //at some point we should make Properties.Settings.Default.Dept not a gol
            OdbcCommand MyCommand = new OdbcCommand("select distinct id,txtCompName from commons.commons_help where txtDept = '" + strDept + "' and dtAnswer is null group by txtCompName order by id ASC", MyConnection);
            OdbcDataReader myReader;
            myReader = MyCommand.ExecuteReader();
            Hashtable htHelp = new Hashtable();
            SortedDictionary<int,string> sdHelp = new SortedDictionary<int,string>();
            
         
            try
            {
                while (myReader.Read())
                {
                    htHelp.Add(myReader.GetInt32(0), myReader.GetString(1));
                    sdHelp.Add(myReader.GetInt32(0), myReader.GetString(1));
                }
            }
            finally
            {
                myReader.Close();
                MyConnection.Close();
                
            }

            return sdHelp;

        }
        
        
        
        
        public string tmCheckRoundTime()
		{
			//reads the rounds xml file and returns the Date/Time
			string theValue = "failed";
			string strSQL = "select max(dtDate) maxDate from metric_rounds";
			OdbcConnection MyConnection = new OdbcConnection(MyConString);
			
			try
			{
				//Connect to MySQL using MyODBC
			    MyConnection = new OdbcConnection(MyConString);
				MyConnection.Open();
				Console.WriteLine("\n !!! success, connected successfully !!!\n");
				//Insert the record (note: Date/Time is include in the query using now and iID is a auto incremented number
				//OdbcCommand MyCommand = new OdbcCommand("INSERT INTO computingTracker (iID,vchProblem,blOther,dtDate) VALUES(3,'hhhasdafd','jjiekl',now())",MyConnection);
				
				OdbcCommand MyCommand = new OdbcCommand(strSQL,MyConnection);
				OdbcDataReader MyDataReader;
				MyDataReader =  MyCommand.ExecuteReader();
				while (MyDataReader.Read())
				{
					 theValue = MyDataReader["maxDate"].ToString();
				}
				
				//need to put a try catch block here
				//DateTime theResults = MyDataReader.GetDateTime(0);
				MyDataReader.Close();
				MyConnection.Close();
				return  theValue;
				
			}
			catch
			{
				//if this failes we want to make sure the db connection is closed and 
				//an error message is displayed
				
				MessageBox.Show("There was a problem loading with the following SQL statement----  " + strSQL,"test");
				MyConnection.Close();
				return theValue;
			}
		}
		private string RunSQLStatement(string strSQL)
		{
			//reads the rounds xml file and returns the Date/Time
			try
			{
				//Connect to MySQL using MyODBC
				OdbcConnection MyConnection = new OdbcConnection(MyConString);
				MyConnection.Open();

				Console.WriteLine("\n !!! success, connected successfully !!!\n");
				//Insert the record (note: Date/Time is include in the query using now and iID is a auto incremented number
				//string strSQL = "select max(dtDate) from Rounds";
				OdbcCommand MyCommand = new OdbcCommand(strSQL,MyConnection);
				MyCommand.ExecuteNonQuery();
				//need to put a try catch block here
				MyConnection.Close();
				return "working";
			}
			catch
			{
				//MyConnection.Close();
				MessageBox.Show("There was a problem loading with the following SQL statement----  " + strSQL,"test");
				return "0";
			}
		}

        public void WriteClientHelp(int theID, string theProblem)
        {


            //Update the commons_help table with the problem that was solved and when the problem was solved

            //Connect to MySQL using MyODBC
            OdbcConnection MyConnection = new OdbcConnection(MyConString);
            MyConnection.Open();
            Console.WriteLine("\n !!! success, connected successfully !!!\n");
            //Insert the record (note: Date/Time is include in the query using now and iID is a auto incremented number
           string thequery = "Update commons.commons_help set dtAnswer = Now(), txtAnswer = '" + theProblem + "' where id = " + theID;
           OdbcCommand MyCommand = new OdbcCommand(thequery, MyConnection);
            MyCommand.ExecuteNonQuery();
            //need to put a try catch block here
            MyConnection.Close();
        }

        public string FindClientHelpProblem(string theCompName)
        {


            //Takes the name of the computer and finds out which problem the computer is associated with 

            //to test this go to http://thecommons.mun.ca/portal/Desktop/
            //Connect to MySQL using MyODBC
            OdbcConnection MyConnection = new OdbcConnection(MyConString);
            MyConnection.Open();
            Console.WriteLine("\n !!! success, connected successfully !!!\n");
            //Insert the record (note: Date/Time is include in the query using now and iID is a auto incremented number
            string thequery = "Select txtRequest from commons_help where txtAnswer is null and txtCompName = '" + theCompName + "'"; 
            OdbcCommand MyCommand = new OdbcCommand(thequery, MyConnection);
            string problem = (string)MyCommand.ExecuteScalar();
            //need to put a try catch block here
            MyConnection.Close();
            return problem;
        }
        
        public Hashtable readClosingProcedures()
        {
            //Connect to MySQL using MyODBC
            OdbcConnection MyConnection = new OdbcConnection(MyConString);
            MyConnection.Open();
            OdbcCommand MyCommand = new OdbcCommand("select id,varProcedure from commons.closing_procedures", MyConnection);
            OdbcDataReader myReader;
            myReader = MyCommand.ExecuteReader();
            Hashtable htHelp = new Hashtable();

            try
            {
                while (myReader.Read())
                {
                    htHelp.Add(myReader.GetInt32(0), myReader.GetString(1));
                }
            }
            finally
            {
                myReader.Close();
                MyConnection.Close();

            }

            return htHelp;

        }
        public void WriteCommonsClosing(string staffName)
        {

            //opens a connection to the Commons DB and then writes the 
            //associated record

            //Connect to MySQL using MyODBC
            OdbcConnection MyConnection = new OdbcConnection(MyConString);
            MyConnection.Open();

            Console.WriteLine("\n !!! success, connected successfully !!!\n");
            string sqlString = "INSERT INTO tracker_ClosingLog(varSubmittedBy) VALUES('" + staffName + "')";
            OdbcCommand MyCommand = new OdbcCommand(sqlString ,MyConnection);
            MyCommand.ExecuteNonQuery();
            //need to put a try catch block here
            MyConnection.Close();

        }

	}
}

