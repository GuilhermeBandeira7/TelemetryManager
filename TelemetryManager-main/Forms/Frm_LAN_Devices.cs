using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NewTelemetryManager.TelemetryManager;
using static System.Windows.Forms.ListViewItem;

namespace NewTelemetryManager.Forms
{
    public partial class Frm_LAN_Devices : Form
    {
        public delegate void UpdateDataGridDelegate(List<byte> data);
        public UpdateDataGridDelegate updateDataGrid;
        bool validSN;
        bool validIPD;
        bool validIPG;
        bool validIPM;
        bool validIPS;
        Task currentTask;
        bool taskStatus = false;
        string targetSN;
        string targetIPD;
        string targetIPS;

        public Frm_LAN_Devices()
        {
            InitializeComponent();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
            updateDataGrid = new UpdateDataGridDelegate(AddListToListView);

            Thread cicloThread = new Thread(TelemetryManager.Instance.GetDataFromListener);
            cicloThread.IsBackground = true;
            cicloThread.Start();
        }

        public void AddListToListView(List<byte> listOfBoards)
        {
            try
            {
                string message = Encoding.ASCII.GetString(listOfBoards.ToArray(), 0, listOfBoards.Count);

                string[] splitMessage = message.Split('-');



                string sn = splitMessage[0];
                string ipd = splitMessage[1];
                string ips = splitMessage[2];
                string ipg = "";
                string ipm = "";

                if (splitMessage.Length == 5)
                {
                    ipg = splitMessage[3];
                    ipm = splitMessage[4];
                }

                if (!CheckForRepeatedValues(sn, ipd, ips, ipg, ipm))
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] { sn, ipd, ipg, ipm, ips, DateTime.Now.ToString() });
                    listView1.Items.Add(listViewItem);
                    foreach (ColumnHeader col in listView1.Columns)
                        col.Width = -2;
                }
                if (targetSN == sn && targetIPD == ipd && targetIPS == ips && taskStatus)
                {

                    taskStatus = false;
                    textBoxSN.Enabled = true;
                    textBoxIPD.Enabled = true;
                    textBoxIPG.Enabled = true;
                    textBoxIPM.Enabled = true;
                    textBoxIPS.Enabled = true;
                    buttonUDP.Text = "Set Config";

                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private bool CheckForRepeatedValues(string sn, string ipd, string ips, string ipg, string ipm)
        {
            foreach (ListViewItem listViewItem in listView1.Items)
            {
                if (listViewItem.Text.Contains(sn))
                {
                    ListViewSubItemCollection sub = listViewItem.SubItems;
                    if (sub[0].Text.Contains(sn))
                    {
                        if (sub[1].Text != ipd)
                        {
                            sub[1].Text = ipd;
                        }
                        if (sub[2].Text != ipg)
                        {
                            sub[2].Text = ipg;
                        }
                        if (sub[3].Text != ipm)
                        {
                            sub[3].Text = ipm;
                        }
                        if (sub[4].Text != ips)
                        {
                            sub[4].Text = ips;
                        }

                        sub[5].Text = DateTime.Now.ToString();
                        return true;

                    }
                }
            }
            return false;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (textBoxSN.Enabled)
            {
                textBoxSN.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBoxIPD.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBoxIPG.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBoxIPM.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBoxIPS.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void buttonUDP_Click(object sender, EventArgs e)
        {
            if (textBoxSN.Enabled && validSN && validIPD && validIPG && validIPM && validIPS)
            {
                textBoxSN.Enabled = false;
                textBoxIPD.Enabled = false;
                textBoxIPG.Enabled = false;
                textBoxIPM.Enabled = false;
                textBoxIPS.Enabled = false;

                string s = "{\"SN\":\"" + textBoxSN.Text + "\",\"IP01\":[" + textBoxIPD.Text.Replace('.', ',') + "],\"IP02\":[" + textBoxIPG.Text.Replace('.', ',') + "],\"IP03\":[" + textBoxIPM.Text.Replace('.', ',') + "],\"IP04\":[" + textBoxIPS.Text.Replace('.', ',') + "]}";
                byte[] msg = Encoding.ASCII.GetBytes(s);
                targetSN = textBoxSN.Text;
                targetIPD = textBoxIPD.Text;
                targetIPS = textBoxIPS.Text;

                string currentIPD = "";
                string currentIPS = "";
                foreach (ListViewItem listViewItem in listView1.Items)
                {
                    if (listViewItem.Text == textBoxSN.Text)
                    {
                        currentIPD = listView1.SelectedItems[0].SubItems[1].Text;
                        currentIPS = listView1.SelectedItems[0].SubItems[4].Text;
                    }
                }
                taskStatus = true;
                buttonUDP.Text = "Cancel";
                currentTask = Task.Run(() =>
                {
                    while (taskStatus && TelemetryManager.Instance.updListening)
                    {
                        int sendvalue = TelemetryManager.Instance.listener.Send(msg, msg.Length, "255.255.255.255", 8888);
                        Thread.Sleep(100);
                        if (TelemetryManager.Instance.IsValidIP(currentIPD))
                        {
                            sendvalue = TelemetryManager.Instance.listener.Send(msg, msg.Length, currentIPD, 8888);
                            Thread.Sleep(100);
                        }
                    }
                });

            }
            else
            {
                taskStatus = false;
                textBoxSN.Enabled = true;
                textBoxIPD.Enabled = true;
                textBoxIPG.Enabled = true;
                textBoxIPM.Enabled = true;
                textBoxIPS.Enabled = true;
                buttonUDP.Text = "Set Config";
            }
        }



        private void validIP_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            bool valid = TelemetryManager.Instance.IsValidIP(textBox.Text);
            textBox.BackColor = valid ? Color.LimeGreen : Color.Red;
            switch (textBox.Name)
            {
                case "textBoxIPD":
                    validIPD = valid;
                    break;
                case "textBoxIPG":
                    validIPG = valid;
                    break;
                case "textBoxIPM":
                    validIPM = valid;
                    break;
                case "textBoxIPS":
                    validIPS = valid;
                    break;
            }
        }

        private void validSN_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            validSN = textBox.Text.Length == 7 && Regex.IsMatch(textBox.Text, @"^[a-zA-Z0-9]+$");
            textBox.BackColor = validSN ? Color.LimeGreen : Color.Red;
        }
        private ListViewColumnSorter lvwColumnSorter=new ListViewColumnSorter();
   

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }
    }
}
