using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using TelemetryLibrary.TelemetryStructure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace NewTelemetryManager.Forms
{
    public partial class Frm_Configuration : Form
    {
        private SerialPort serialPort = new SerialPort();
        public delegate void DelegateBoard(UpdateBoardEventArgs args);
        public DelegateBoard BoardUpdateDelegate;
        public bool processExecuted = false;
        List<string> dataSN = new List<string>();
        List<string> dataS = new List<string>();
        List<string> dataT = new List<string>();
        List<string> dataC = new List<string>();
        List<string> dataCC = new List<string>();
        List<string> dataI = new List<string>();
        List<string> data1 = new List<string>();
        List<string> data2 = new List<string>();
        List<string> data3 = new List<string>();
        //string preAm, identfPlaca, version, command, numVar, tamDados;
        public delegate void SetTextValueCallback1(string str);
        public delegate void SetTextValueCallback4(string str);
        public delegate void SetTextValueCallback7(string str);
        public delegate void SetTextValueCallback9(string str);
        public SetTextValueCallback1 SetTextValue1;
        public SetTextValueCallback4 SetTextValue4;
        public SetTextValueCallback7 SetTextValue7;
        private State estadoAtual = State.Desconectado;
        Thread tl;
        private bool istlRunning = false;

        //variáveis thread leitor
        List<byte> dadosB = new List<byte>();
        int nbytes, varN, dadoM;
        bool SN_check = false, SN_funciona = false;
        string serialN, varKey = "";

        public enum State
        {
            Desconectado,
            Conectando,
            ST_OK,
            SN_CHECK,
            Comunicando,
            Desconectando,
        }

        public Frm_Configuration()
        {

            InitializeComponent();

            PopulateTreeView("");
            PopulateTreeView1("");
            Trv_Variables.CheckBoxes = true;
            treeView1.CheckBoxes = true;
            SetTextValue1 = new SetTextValueCallback1(SetText1);
            SetTextValue4 = new SetTextValueCallback4(SetText4);
            SetTextValue7 = new SetTextValueCallback7(SetText7);

        }

        public void SetUserVisibility()
        {
            if (TelemetryController.Instance.isMaintenance)
            {
                Ccb_Type.Enabled = false;
                Msk_Type.Enabled = false;
                //txb_atualizar.Enabled = false;
                //txb_data.Enabled = false;
                txb_baudrate.Enabled = false;
                txb_slot.Enabled = false;
                txb_serialnumber.Enabled = false;
                Txb_FilterVariable.Enabled = false;
                button3.Enabled = false;
                btn_clear.Enabled = false;
                btn_update.Enabled = false;
                btn_queryVariables.Enabled = false;
                Btn_ClearVariables.Enabled = false;
            }
        }

        public void PopulateTreeView(string filterString)
        {
            Trv_Variables.Nodes.Clear();
            string varName;
            foreach (VARIABLES variable in Enum.GetValues(typeof(VARIABLES)))
            {
                varName = variable.ToString();
                if (filterString == "" || varName.Contains(filterString.ToUpper()))
                {
                    Trv_Variables.Nodes.Add(variable.ToString());
                    BoardUpdateDelegate = new DelegateBoard(DelegateBoardMethod);
                    processExecuted = true;
                }
            }
        }

        public void PopulateTreeView1(string filterString)
        {
            treeView1.Nodes.Clear();
            int varsize1 = 0, varsize2;
            foreach (VARIABLES variable in Enum.GetValues(typeof(VARIABLES)))
            {
                switch (Ccb_Type.Text)
                {
                    case "Byte":
                        varsize2 = 1;
                        break;

                    case "Short":
                        varsize2 = 2;
                        break;

                    case "IP":
                        varsize2 = 4;
                        break;

                    case "Serial Number":
                        varsize2 = 7;
                        break;

                    default:
                        varsize2 = 0;
                        break;
                }

                varsize1 = MessageController.Instance.GetVarSize(variable);

                if (filterString == "" || varsize1 == varsize2)
                {
                    treeView1.Nodes.Add(variable.ToString());
                    BoardUpdateDelegate = new DelegateBoard(DelegateBoardMethod);
                    processExecuted = true;
                }
            }
        }

        private void Msk_Type_TextChanged(object sende, EventArgs e)
        {
            switch (Ccb_Type.Text)
            {
                case "Byte":

                    if (IsValidByte(Msk_Type.Text))
                    {
                        Msk_Type.BackColor = Color.Green;
                    }
                    else
                    {
                        Msk_Type.BackColor = Color.Red;
                    }

                    break;

                case "Short":
                    if (IsValidShort(Msk_Type.Text))
                    {
                        Msk_Type.BackColor = Color.Green;
                    }
                    else
                    {
                        Msk_Type.BackColor = Color.Red;
                    }
                    break;

                case "IP":

                    if (IsValidIP(Msk_Type.Text))
                    {
                        Msk_Type.BackColor = Color.Green;
                    }
                    else
                    {
                        Msk_Type.BackColor = Color.Red;
                    }

                    break;

                case "Serial Number":

                    if (IsValidSN(Msk_Type.Text))
                    {
                        Msk_Type.BackColor = Color.Green;
                    }
                    else
                    {
                        Msk_Type.BackColor = Color.Red;
                    }

                    break;

                default:
                    Msk_Type.BackColor = Color.White;
                    break;
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

        public bool IsValidByte(string vByte)
        {
            bool conversion = byte.TryParse(vByte, out var valor);
            return conversion;
        }

        public bool IsValidSN(string vSerialNumber)
        {
            bool conversion = vSerialNumber.Length == 7 && Regex.IsMatch(vSerialNumber, @"^[a-zA-Z0-9]+$");
            return conversion;
        }

        public bool IsValidShort(string vShort)
        {
            bool conversion = ushort.TryParse(vShort, out var valor);
            return conversion;
        }

        public void DelegateBoardMethod(UpdateBoardEventArgs args)
        {
            var board = args.board;
            var dictonaryOfDevices = TelemetryController.Instance.GetDevices();
            TreeNode telemetryNode;
            TreeNode boardNode;
            TreeNode variablesNode;
            TreeNode valueNode;

            try
            {
                var dictionaryOfBoards = dictonaryOfDevices[board.SerialNumber].dictOfBoards;
                ushort boardKey = dictonaryOfDevices[board.SerialNumber].dictOfBoards.FirstOrDefault(x => x.Value == board).Key;
                string boardNodeName = SetupBoardNodeName(dictionaryOfBoards, boardKey);
                var dictionaryOfVariables = dictionaryOfBoards[boardKey].Variables;
            }
            catch (NullReferenceException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static string SetupBoardNodeName(Dictionary<ushort, Board> dictionaryOfBoards, ushort boardKey)
        {
            return "Slot " + boardKey + " - " + Enum.GetName(typeof(BOARDS), dictionaryOfBoards[boardKey].Type)
                                + " v" + dictionaryOfBoards[boardKey].Version.ToString("#\".\"#\".\"#");
        }

        private void Txb_FilterVariable_TextChanged(object sender, EventArgs e)
        {
            PopulateTreeView(Txb_FilterVariable.Text);
        }

        private void Btn_Query_Click(object sender, EventArgs e)
        {

            Dictionary<VARIABLES, List<byte>> varVar = new Dictionary<VARIABLES, List<byte>>();

            foreach (TreeNode tn in Trv_Variables.Nodes)
            {
                if (tn.Checked)
                {
                    if (Enum.TryParse(tn.Text, out VARIABLES myStatus))
                    {
                        varVar.Add(key: myStatus, new List<byte>() { 0x00 });
                    }
                }
            }

            MessageModel messageASKVAR = MessageController.Instance.CreateMessage(varVar, 0x00, MESSAGE_TYPE.QUERY);
            byte[] messageVAR = MessageController.Instance.EncodeMessage(messageASKVAR);

            try
            {
                serialPort.Write(messageVAR, 0, messageVAR.Length);
            }
            catch (Exception exe)
            {

            }

            foreach (TreeNode tn in Trv_Variables.Nodes)
            {
                if (tn.Checked)
                {
                    tn.Checked = false;
                }
            }
        }

        private void Btn_ClearVariables_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in Trv_Variables.Nodes)
            {
                if (tn.Checked)
                {
                    tn.Checked = false;
                }
            }
        }

        private void Btn3_Click(object sende, EventArgs e)
        {
            if (Msk_Type.Text != "" && Ccb_Type.Text != "" && Msk_Type.BackColor == Color.Green)

            {
                foreach (TreeNode tn in treeView1.Nodes)
                {
                    if (tn.Checked)
                    {
                        string dataCS = tn.Text;
                        string dataIS = Msk_Type.Text;
                        string dataTi = Ccb_Type.Text;

                        data3.Add(dataCS + " (" + dataTi + "): " + dataIS);

                        createTrv(data3);

                    }
                }
            }
        }

        private void createTrv(List<string> d3)
        {
            for (int i = 0; i < d3.Count; i++)
            {
                if (!dataC.Contains(d3[i]))
                {
                    treeView2.Nodes.Add(d3[i]);
                    dataC.Add(d3[i]);
                }
            }
        }

        private void Ccb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTreeView1(Ccb_Type.Text);

            switch (Ccb_Type.Text)
            {
                case "Byte":
                    Msk_Type.Text = "00";
                    break;
                case "Short":
                    Msk_Type.Text = "00";
                    break;
                case "IP":
                    Msk_Type.Text = "000-00-0-000";
                    break;
                case "Serial Number":
                    Msk_Type.Text = "aaaaaaa";
                    break;
                default:
                    Msk_Type.Text = "";
                    break;
            }
            Msk_Type.Focus();
        }

        private void Btn_Clear_Update(object sender, EventArgs e)
        {
            //txb_data.Text = "";
            //txb_atualizar.Text = "";
            Msk_Type.Text = "";

            foreach (TreeNode tn in treeView1.Nodes)
            {
                if (tn.Checked)
                {
                    tn.Checked = false;
                }
            }

            treeView2.Nodes.Clear();

        }

        private void comboBoxCOMPort_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            cb.DataSource = SerialPort.GetPortNames();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                tl.Suspend();
            }
            try
            {
                serialPort = new SerialPort(comboBoxCOMPort.Text, Convert.ToInt32(txb_baudrate.Text));
                serialPort.Open();
                estadoAtual = State.Conectando;
                tl = new Thread(threadLeitor);
                tl.Start();
            }
            catch (Exception exe)
            {


            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            List<string> dataVar = new List<string>();
            List<string> dataTipo = new List<string>();
            List<string> dataInfo = new List<string>();
            Dictionary<VARIABLES, List<byte>> upVar = new Dictionary<VARIABLES, List<byte>>();
            List<byte> datamaskedTextBox1 = new List<byte>();
            List<List<byte>> myList = new List<List<byte>>();

            foreach (TreeNode info in treeView2.Nodes)
            {
                if (info.Checked)
                {
                    dataVar.Add(info.Text.Substring(0, info.Text.IndexOf("(") - 1));
                    dataTipo.Add(info.Text.Substring(info.Text.IndexOf("(") + 1, info.Text.IndexOf(")") - info.Text.IndexOf("(") - 1));
                    dataInfo.Add(info.Text.Substring(info.Text.IndexOf(")") + 3));
                }
            }

            for (int i = 0; i < dataVar.Count; i++)
            {
                myList.Add(new List<byte> { });

                Enum.TryParse(dataVar[i], out VARIABLES variableCcbType);             //1

                foreach (byte dataByte in ValidateData(dataInfo[i], dataTipo[i]))
                {
                    myList[i].Add(dataByte);                                 //2
                }

                upVar.Add(variableCcbType, myList[i]);

            }

            AltVar(upVar);
        }

        private void AltVar(Dictionary<VARIABLES, List<byte>> altVar)
        {
            MessageModel messageALT = MessageController.Instance.CreateMessage(altVar, 0x00, MESSAGE_TYPE.UPDATE);
            byte[] messageAltVar = MessageController.Instance.EncodeMessage(messageALT);

            if (serialPort.IsOpen)
            {
                serialPort.Write(messageAltVar, 0, messageAltVar.Length);
            }
        }

        private List<byte> ValidateData(string tb, string tp)
        {
            List<byte> data = new List<byte>();

            if (tp == "Byte")
            {
                data.Add(Convert.ToByte(tb, 16));
            }

            else if (tp == "Short")
            {
                bool conversion = ushort.TryParse(tb, out ushort result);
                if (conversion)
                {
                    data.Add((byte)(result >> 8));
                    data.Add((byte)(result & 0xFF));
                }
            }


            else if (tp == "Serial Number")
            {
                foreach (char c in tb)
                {
                    data.Add((byte)c);
                }

            }

            else if (tp == "IP")
            {
                foreach (string addr in tb.Split('.'))
                {
                    data.Add(Convert.ToByte(addr, 10));
                }
            }


            return data;
        }

        public void SetText1(string str)
        {
            textBox1.Text += str + Environment.NewLine;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }

        public void SetText4(string str)
        {
            txb_serialnumber.Text = str;
            txb_slot.Text = "0";
        }

        public void SetText7(string str)
        {
            textBox2.Text += str + Environment.NewLine;
            textBox2.SelectionStart = textBox1.Text.Length;
            textBox2.ScrollToCaret();
        }


        private async void threadLeitor()
        {
            istlRunning = true;
            string sNumber = "";
            MessageModel messageUSB = new MessageModel();


            while (istlRunning)
            {
                if (serialPort.BytesToRead > 8)

                {
                    dadosB.Clear();
                    for (int i = 0; i < 8; i++)
                    {
                        dadosB.Add((byte)serialPort.ReadByte());
                    }

                    varN = (short)((dadosB[4] << 8) + dadosB[5]);
                    dadoM = (short)((dadosB[6] << 8) + dadosB[7]);
                    nbytes = 2 * varN + dadoM;

                    if (nbytes != 0)
                    {
                        while (nbytes > serialPort.BytesToRead)
                        {
                            Thread.Sleep(25);
                        }

                        for (int i = 0; i < nbytes; i++)
                        {
                            dadosB.Add((byte)serialPort.ReadByte());
                        }
                    }

                    messageUSB = MessageController.Instance.DecodeMessage(dadosB);

                    if (estadoAtual == State.Conectando)
                    {
                        //Implementar futuramente SET_CONFIG
                        estadoAtual = State.ST_OK;
                    }
                    else if (estadoAtual == State.ST_OK)
                    {
                        askSN();
                        sNumber = returnSN(messageUSB);
                    }
                    else if (estadoAtual == State.SN_CHECK)
                    {
                        libera(sNumber);
                    }
                    else if (estadoAtual == State.Comunicando)
                    {
                        if (messageUSB.message.Count != 0)
                        {
                            this.BeginInvoke(SetTextValue1, new object[] { BitConverter.ToString(dadosB.ToArray()) });
                            foreach (KeyValuePair<VARIABLES, List<byte>> message in messageUSB.message)
                            {
                                if (message.Key.ToString() == "SN")
                                {
                                    this.BeginInvoke(SetTextValue7, new object[] { message.Key.ToString() + ": " + ConvertHex(BitConverter.ToString(message.Value.ToArray())) });
                                }
                                else if (message.Key.ToString() == "IP_D" || message.Key.ToString() == "IP_G" || message.Key.ToString() == "IP_M" || message.Key.ToString() == "IP_S")
                                {
                                    byte[] var = message.Value.ToArray();
                                    this.BeginInvoke(SetTextValue7, new object[] { message.Key.ToString() + ": " + Convert.ToString(var[0]) + "." + Convert.ToString(var[1]) + "." + Convert.ToString(var[2]) + "." + Convert.ToString(var[3]) });
                                }
                                else
                                {
                                    byte[] var1 = message.Value.ToArray();
                                    string var2;

                                    if (var1.Length == 2)
                                    {
                                        if (BitConverter.IsLittleEndian)
                                        {
                                            var2 = BitConverter.ToUInt16(var1.Reverse().ToArray()).ToString();
                                        }
                                        else
                                        {
                                            var2 = BitConverter.ToUInt16(var1).ToString();
                                        }
                                    }
                                    else
                                    {
                                        var2 = Convert.ToString(var1[0]);
                                    }

                                    string VARvalue = var2.Replace("-", "");
                                    VARvalue.ToString();



                                    this.BeginInvoke(SetTextValue7, new object[] { message.Key.ToString() + ": " + VARvalue });
                                }
                            }
                        }
                    }
                }
            }
        }


        private string returnSN(MessageModel messageUSB)
        {
            string serialN = "";

            for (int j = 0; j < messageUSB.message.Keys.Count; j++)
            {
                if (messageUSB.message.ElementAt(j).Key.ToString() == "SN")
                {
                    serialN = ConvertHex((BitConverter.ToString(messageUSB.message.ElementAt(j).Value.ToArray())).Replace("-", ""));
                    //varKey = ConvertHex(((messageUSB.message.ElementAt(j).Key.ToString())).Replace("-", ""));                    
                    this.BeginInvoke(SetTextValue4, new object[] { serialN });
                }
            }

            if (serialN != "")
            {
                estadoAtual = State.SN_CHECK;
            }

            return serialN;
        }

        private void libera(string serialN)
        {
            if (serialN == "SNTESTE" || !IsValidSN(serialN))
            {
                if (TelemetryController.Instance.isAdmin)
                {
                    estadoAtual = State.Comunicando;
                }
                else
                {
                    SetUserVisibility();
                }
            }
            else
            {
                estadoAtual = State.Comunicando;
            }
        }

        private void askSN()
        {
            Dictionary<VARIABLES, List<byte>> varSN = new Dictionary<VARIABLES, List<byte>>();
            varSN.Add(VARIABLES.SN, new List<byte>() { 0x00 });
            MessageModel messageASKSN = MessageController.Instance.CreateMessage(varSN, 0x00, MESSAGE_TYPE.QUERY);
            byte[] messageSN = MessageController.Instance.EncodeMessage(messageASKSN);

            if (serialPort.IsOpen)
            {
                serialPort.Write(messageSN, 0, messageSN.Length);
            }
        }

        public static string ConvertHex(String hexString)
        {
            hexString = hexString.Replace("-", "");

            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }
    }
}