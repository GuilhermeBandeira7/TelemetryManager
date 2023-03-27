using Microsoft.VisualBasic.ApplicationServices;
using NewTelemetryManager.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelemetryManager.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TreeView = System.Windows.Forms.TreeView;

namespace NewTelemetryManager
{
    public sealed class TelemetryManager
    {
        #region SINGLETON
        static private TelemetryManager? instance = null;

        private TelemetryManager()
        {
        }

        public static TelemetryManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TelemetryManager();
                }
                return instance;
            }
        }
        #endregion

       
        

        public delegate void DelegateStatus(bool status);
        public DelegateStatus statusDelegate;

        public bool updListening;

        public const int listenPort = 8888;

        private Frm_Devices devicesForm;
        private Frm_Server serverForm;
        private Frm_MainMenu mainMenuForm;
        private Frm_LAN_Devices lanDevicesForm ;
        private Frm_Configuration configurationForm ;
        private Frm_Teste testeForm;

        private Frm_Login loginForm;

        public Frm_Login LoginForm
        {
            get { return loginForm; }
            set { loginForm = value; }
        }


        public Frm_Server ServerForm
        {
            get { return serverForm; }
            set { serverForm = value; } 
        }
        public Frm_MainMenu MainMenuForm
        {
            get { return mainMenuForm; }   
            set { mainMenuForm = value; }
        }
        public Frm_Devices DevicesForm
        {
            get { return devicesForm; }
            set { devicesForm = value; }
        }
        public Frm_LAN_Devices LANDevicesForm
        {
            get { return lanDevicesForm; }
            set { lanDevicesForm = value; }   
        }

        public Frm_Configuration ConfigurationForm
        {
            get { return configurationForm; }
            set { configurationForm = value; }
        }

        public Frm_Teste TesteForm
        {
            get { return testeForm; }
            set { testeForm = value; }
        }


        public UdpClient listener = new UdpClient(listenPort);

        /// <summary>
        /// Gets the input from a listening port and update a datagridview
        /// </summary>
        /// <param name="listOfBoards">list of byte from the listener(connected port)</param>

        public void GetDataFromListener()
        {
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
            updListening = true;
            while (updListening)
            {
                try
                {
                    byte[] dataFromListener = listener.Receive(ref groupEP);
                    LANDevicesForm.BeginInvoke(LANDevicesForm.updateDataGrid, new object[] { dataFromListener.ToList() });
                  
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        public bool IsValidIP(string addr)
        {
            string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            Regex check = new Regex(pattern);
            bool valid = false;
            if (addr == "")
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(addr, 0);
            }
            return valid;
        }

        public void SetButtonsVisibility(bool visibility)
        {
            mainMenuForm.SetButtonsVisibility(visibility);
        }


    }
}
