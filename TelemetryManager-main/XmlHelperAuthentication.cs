
﻿using NewTelemetryManager;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

using NewTelemetryManager;
using TelemetryManager;

namespace TelemetryManager
{
    internal class XmlHelperAuthentication
    {
        XmlDocument xmlDocument;
        internal bool isAuthenticated = false;
        internal bool isAdminUser = false;

        public XmlHelperAuthentication(string username, string password)
        {
            xmlDocument = new XmlDocument();
            //username and password from Login Form.
            LoadXmlDocument(username, password);

        }

        private void LoadXmlDocument(string username, string password)
        {
            //xmlDocument.Load(@"C:\Users\MTW\Desktop\TelemetryManager\TelemetryManager\bin\Debug\net6.0-windows\login.xml");

            xmlDocument.Load(@"C:\Users\MTW\Desktop\TelemetryManager-main\TelemetryManager-main\bin\Debug\net6.0-windows\login.xml");
            //xmlDocument.Load(@"C:\Users\MTW\Desktop\TelemetryManager-main\bin\Debug\net6.0-windows\login.xml");

            XmlNodeList? nodeList = xmlDocument.SelectNodes("//users");

            foreach (XmlNode node in nodeList)
            {
                //Variables holding username and password from the xml file

                string nodeUsernameAdmin = node["usernameAdmin"].FirstChild.Value;
                string nodePasswordAdmin = node["passwordAdmin"].LastChild.Value;
                string nodeUsernameMaintenance = node["usernameMaintenance"].FirstChild.Value;
                string nodePasswordMaintenance = node["passwordMaintenance"].FirstChild.Value;


                List<string> cleanedStrings = new List<string>();

                List<string> cleanedAdminStrings = new List<string>();
                List<string> cleanedMaintStrings = new List<string>();
                cleanedAdminStrings = FormatAuthenticationStrings(nodeUsernameAdmin, nodePasswordAdmin);
                cleanedMaintStrings = FormatAuthenticationStrings(nodeUsernameMaintenance, nodePasswordMaintenance);

                foreach(string loginData in cleanedAdminStrings)
                {
                    cleanedStrings.Add(loginData);
                }

                foreach(string loginData in cleanedMaintStrings)
                {
                    cleanedStrings.Add(loginData);  
                }
               
                //Comparing the received values from login with values from xml file
                if(username == cleanedStrings.First() && password == cleanedStrings.ElementAt(1))
                {
                    //Authenticating the user and checking if is admin, case admin update the Controller 
                    isAuthenticated = true;
                    TelemetryController.Instance.isAdmin = true;
                    TelemetryController.Instance.isMaintenance = false;

                    break;
                }
                else if(username == cleanedStrings.ElementAt(2) && password == cleanedStrings.Last())
                {
                    isAuthenticated = true;
                    TelemetryController.Instance.isMaintenance = true;
                    TelemetryController.Instance.isAdmin = false;
                    break;


                }
                else
                {
                    isAuthenticated = false;
                    break;
                }
            }
        }

        private List<string> FormatAuthenticationStrings(string username, string password)
        {
            //first cleaning the string and then removing white spaces
            string cleanStringUsername = username.Replace("\r\n", string.Empty);
            string usernameNoWhiteSpace = cleanStringUsername.Trim();
            string cleanStringPassword = password.Replace("\r\n", string.Empty);

            string passwordNoWhiteSpace = cleanStringPassword.Trim();


            List<string> cleandedStrings = new List<string>();
            cleandedStrings.Add(usernameNoWhiteSpace);
            cleandedStrings.Add(passwordNoWhiteSpace);

            return cleandedStrings;
        }
    }
}
