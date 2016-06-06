using System;
using System.Net;
using System.Data;
using System.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections;


namespace CommonsTracker
{
	/// <summary>
	/// Summary description for ConfigData.
	/// </summary>
	public class ConfigData
	{
		public string strDataFile;
		public string strBtn1;
		public string strBtn2;
		public string strBtn3;
		public string strBtn4;
		public string strBtn5;
		public string strBtn6;
		public string strBtnValue1; // There are the values that the buttons will have
		public string strBtnValue2;
		public string strBtnValue3;
		public string strBtnValue4;
		public string strBtnValue5;
		public Hashtable  issueLookupHash; //Holds all the potential issues that will be selected
        public Hashtable DeptLookupHash; //Holds all the departments, each department will have its own config file
		public string  strErrMsgTitle;
		public string strRoundsFile;
        public string strDept; //The Department that is currently selected.  This really only changes on install
        public string strDeptUrl; //the link to the main file
        public string strCompLocationURL; //the link the page where the graphic location of the page shows up - (e.g. One Page)
        public string strHostName;
        public string strIPAddress;
        public bool boolRoundsOn; //determines if the rounds part of the program will be visiable
        public bool boolClosingOn; //determines if the closing procedures should be on of off
		
        public ConfigData()
        
		{
			//first we want to know which group/department is using tracker.
            //for this we use the setting properties under the project properties
            //Note: We are using the "user" properties and not the application (easier at this point
            //and each computer will only have one user, for now)
            strDept = Properties.Settings.Default.Dept;
            readConfigfile();

			//this will be the title show up on the error window that pops up
			strErrMsgTitle = "Issues Tracker";
            strHostName = Dns.GetHostName();

            //we need to find out the IP address of the host computer so we can group during reporting (doesn't apply to this application)
            IPAddress[] localIPs = Dns.GetHostAddresses(strHostName);
            strIPAddress = localIPs[0].ToString();
      

		}



        private void readDeptConfig()
        {
            //this function go to the department config file and get a list of all the departments that use
            //tracker.  It also checks to see if the application is associated with a dept.  If not then the program 
            //will not be able to load the correct setting (which depend on the appropriate xml file
            try
            {
                DeptLookupHash = new Hashtable();

                XmlDocument doc = new XmlDocument();
                doc.Load("http://www.cs.mun.ca/~thecommons/configfiles/TrackerDeptConfig.xml");
                
                System.Xml.XmlNodeList ttt = doc.SelectNodes("tracker/dept-options/dept");

                //now we want to get all the issues and populate the list box
                for (int i = 0; i < ttt.Count; i++)
                {
                    System.Xml.XmlNode theNode = ttt.Item(i);
                    DeptLookupHash.Add(i, theNode.SelectSingleNode("@name").Value);
                }
                //Now get file the correct url for the department
                string xpathDept = "tracker/dept-options/dept[@name='" + strDept + "']";
                System.Xml.XmlNode theElement = doc.SelectSingleNode(xpathDept);
                strDeptUrl = theElement.SelectSingleNode("@url").Value;



            }
            catch
            {
                MessageBox.Show("There was a problem detecting which department you belong to -please make sure your department setting are correct and Dept xml file is formatted properly", "Tracker");
            }
        }
        
        
        
        private void readConfigfile()
		{ 
			try
			{
                readDeptConfig();
				// Declare a Hashtable object:
				issueLookupHash = new Hashtable();
			
				XmlDocument doc  = new XmlDocument();
                doc.Load(strDeptUrl);
                //note: Should look something like: http://www.cs.mun.ca/~thecommons/configfiles/TrackerConfig.xml
				System.Xml.XmlNodeList ttt = doc.SelectNodes("tracker/issue-options/issue");
			
				//now we want to get all the issues and populate the list box
				for (int i=0; i<ttt.Count;i++)
				{
					System.Xml.XmlNode theNode = ttt.Item(i);
					issueLookupHash.Add (i,theNode.SelectSingleNode("@name").Value);
					//lbIssues.Items.Add (theNode.SelectSingleNode("@name").Value);
				}
				strDataFile = doc.SelectSingleNode("tracker/datafile/@name").Value;
				strRoundsFile = doc.SelectSingleNode("tracker/roundsfile/@name").Value;
				//Now get the data for the buttons (note: this should be turned into a enum at some point
				System.Xml.XmlNode theElement  = doc.SelectSingleNode("tracker/appslist/app[@btn='btnApp1']");
				strBtn1 = theElement.SelectSingleNode("@name").Value;
				strBtnValue1 = theElement.SelectSingleNode("@location").Value;
		
				System.Xml.XmlNode theElement2  = doc.SelectSingleNode("tracker/appslist/app[@btn='btnApp2']");
				strBtn2 = theElement2.SelectSingleNode("@name").Value;
				strBtnValue2 = theElement2.SelectSingleNode("@location").Value;

				System.Xml.XmlNode theElement3  = doc.SelectSingleNode("tracker/appslist/app[@btn='btnApp3']");
				strBtn3 = theElement3.SelectSingleNode("@name").Value;
				strBtnValue3 = theElement3.SelectSingleNode("@location").Value;

				System.Xml.XmlNode theElement4  = doc.SelectSingleNode("tracker/appslist/app[@btn='btnApp4']");
				strBtn4 = theElement4.SelectSingleNode("@name").Value;
				strBtnValue4 = theElement4.SelectSingleNode("@location").Value;

				System.Xml.XmlNode theElement5  = doc.SelectSingleNode("tracker/appslist/app[@btn='btnApp5']");
				strBtn5 = theElement5.SelectSingleNode("@name").Value;
				strBtnValue5 = theElement5.SelectSingleNode("@location").Value;

                System.Xml.XmlNode theElement6 = doc.SelectSingleNode("tracker/helpbutton/complocation");
                strCompLocationURL = theElement6.SelectSingleNode("@url").Value;

                 System.Xml.XmlNode helpButtonElement = doc.SelectSingleNode("tracker/helpbutton/complocation");
                strCompLocationURL = helpButtonElement.SelectSingleNode("@url").Value;

                 System.Xml.XmlNode roundsElement = doc.SelectSingleNode("tracker/config/rounds-on");
                 boolRoundsOn = Convert.ToBoolean(roundsElement.SelectSingleNode("@truefalse").Value);

                System.Xml.XmlNode closingElement = doc.SelectSingleNode("tracker/config/closing-on");
                boolClosingOn = Convert.ToBoolean(roundsElement.SelectSingleNode("@truefalse").Value); 
            
            }
			catch
			{
				MessageBox.Show("There was a problem loading-- " + strDataFile + " --please make sure it exists and is formatted properly" ,"Tracker");
			}
		}

       
         
        
        public string tmCheckRoundTime()
		{
			//reads the rounds xml file and returns the Date/Time
			try
			{
				XmlDocument doc  = new XmlDocument();
				doc.Load(strRoundsFile);
				System.Xml.XmlNodeList ttt = doc.SelectNodes("tracker/issue-options/issue");
				//Now get the data for the buttons (note: this should be turned into a enum at some point
				System.Xml.XmlNode theElement  = doc.SelectSingleNode("commonsrounds").LastChild;
				return theElement.SelectSingleNode("@date").Value;
			}
			catch
			{
				MessageBox.Show("There was a problem loading-- " + strRoundsFile + " --please make sure it exists and is formatted properly" ,strErrMsgTitle);
				return "0";
			}

		}
	}

}
