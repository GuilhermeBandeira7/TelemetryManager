using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTelemetryManager.Forms
{
    public partial class Frm_Server : Form
    {
        public Frm_Server()
        {
            InitializeComponent();
            Txb_ServerAddress.Text = "172.16.2.170";
            if (TelemetryController.Instance.IsConnected()) { Btn_Connect.Text = "Disconnect"; }
            else { Btn_Connect.Text = "Connect"; }
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (TelemetryController.Instance.IsConnected())
            {
                TelemetryController.Instance.DisconnectMqtt();
                Txb_ServerAddress.Enabled = true;
                Btn_Connect.Text = "Connect";
                TelemetryManager.Instance.SetButtonsVisibility(false);

            }
            else
            {
                if (TelemetryManager.Instance.IsValidIP(Txb_ServerAddress.Text))
                {
                    if (TelemetryController.Instance.ConnectMqtt(Txb_ServerAddress.Text))
                    {
                        TelemetryController.Instance.SubscribeToTopic("#");
                        Txb_ServerAddress.Enabled = false;
                        Btn_Connect.Text = "Disconnect";
                        TelemetryManager.Instance.SetButtonsVisibility(true);
                        this.Close();
                    }
                }
            }
        }

        private void Txb_ServerAddress_Leave(object sender, EventArgs e)
        {
            if (TelemetryManager.Instance.IsValidIP(Txb_ServerAddress.Text))
            {
                Txb_ServerAddress.BackColor = Color.LightGreen;
            }
            else
            {
                Txb_ServerAddress.BackColor = Color.IndianRed;
            }
        }
    }
}
