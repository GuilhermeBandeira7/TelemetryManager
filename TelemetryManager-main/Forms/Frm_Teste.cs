using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using NewTelemetryManager;
using NewTelemetryManager.Forms;
using TelemetryLibrary.TelemetryStructure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static NewTelemetryManager.Forms.Frm_Configuration;
using ComboBox = System.Windows.Forms.ComboBox;

namespace TelemetryManager.Forms
{
    public partial class Frm_Teste : Form
    {
        private SerialPort serialPort = new SerialPort();
        public SetTextValueCallback9 SetTextValue9;
        public SetTextValueCallback7 SetTextValue7;
        public SetTextValueCallback4 SetTextValue4;
        public SetTextValueCallback1 SetTextValue1;
        Thread tl;

        //variáveis thread leitor
        List<byte> dadosB = new List<byte>();
        int nbytes, varN, dadoM;

        public Frm_Teste()
        {
            InitializeComponent();
            SetTextValue9 = new SetTextValueCallback9(SetText9);
            SetTextValue7 = new SetTextValueCallback7(SetText7);
            SetTextValue4 = new SetTextValueCallback4(SetText4);
            SetTextValue1 = new SetTextValueCallback1(SetText1);
        }

        //////////////
        ////  SN  ////
        //////////////


        private void Query_btn(object sender, EventArgs e)
        {
            Dictionary<VARIABLES, List<byte>> varVar = new Dictionary<VARIABLES, List<byte>>();

            string[] varCPU = { "DC01", "DC02", "DO01", "DI01" };

            for (int i = 0; i < varCPU.Length; i++)
            {
                if (Enum.TryParse(varCPU[i], out VARIABLES myStatus))
                {
                    varVar.Add(key: myStatus, new List<byte>() { 0x00 });
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

                tl = new Thread(threadLeitor);
                tl.Start();

            }

            catch (Exception exe)
            {


            }
        }

        string scal = "";

        private void btn_DC01Cal(object sender, EventArgs e)
        {
            askCAL1();
            Thread.Sleep(150);
            string[] v1 = txb_dc1SN.Text.Split(" ");
            string[] v2 = tb_calibDc1.Text.Split(" ");
            double valor1 = Convert.ToDouble(v1[0]);
            double valor2 = Convert.ToDouble(v2[0]);
            double CAL;

            if (valor1 >= 0 && valor2 > 0)
            {
                CAL = Convert.ToDouble(scal) * (valor2 / valor1);
                string[] v3 = CAL.ToString().Split(",");

                Dictionary<VARIABLES, List<byte>> upVar = new Dictionary<VARIABLES, List<byte>>();
                List<string> Cal = new List<string>();
                Cal.Add("CAL_DC01");
                List<byte> datamaskedTextBox1 = new List<byte>();


                Enum.TryParse(Cal[0], out VARIABLES variableCcbType);             //1

                foreach (byte dataByte in ValidateData(v3[0], "Short"))
                {
                    datamaskedTextBox1.Add(dataByte);                               //2
                }

                upVar.Add(variableCcbType, datamaskedTextBox1);
                AltVar(upVar);

                Thread.Sleep(150);
                Query_btn(null, null);

                Calibrado();
            }
        }

        private void btn_DC02Cal(object sender, EventArgs e)
        {
            askCAL2();
            Thread.Sleep(150);
            string[] v1 = txb_dc2SN.Text.Split(" ");
            string[] v2 = tb_calibDc2SN.Text.Split(" ");
            double valor1 = Convert.ToDouble(v1[0]);
            double valor2 = Convert.ToDouble(v2[0]);
            double CAL;

            if (valor1 >= 0 && valor2 > 0)
            {
                CAL = Convert.ToDouble(scal) * (valor2 / valor1);
                string[] v3 = CAL.ToString().Split(",");

                Dictionary<VARIABLES, List<byte>> upVar = new Dictionary<VARIABLES, List<byte>>();
                List<string> Cal = new List<string>();
                Cal.Add("CAL_DC02");
                List<byte> datamaskedTextBox1 = new List<byte>();


                Enum.TryParse(Cal[0], out VARIABLES variableCcbType);             //1

                foreach (byte dataByte in ValidateData(v3[0], "Short"))
                {
                    datamaskedTextBox1.Add(dataByte);                               //2
                }

                upVar.Add(variableCcbType, datamaskedTextBox1);
                AltVar(upVar);
                Thread.Sleep(150);

                Query_btn(null, null);

                Calibrado2();
            }
        }

        private void btn_DO01_Click(object sender, EventArgs e)
        {
            Dictionary<VARIABLES, List<byte>> upVar = new Dictionary<VARIABLES, List<byte>>();
            List<string> Var = new List<string>();

            string t = txb_do01SN.Text;

            if (t == "1") { t = "0"; }
            else { t = "1"; }


            string[] v3 = t.Split(" ");
            Var.Add("DO01");
            List<byte> datamaskedTextBox1 = new List<byte>();

            Enum.TryParse(Var[0], out VARIABLES variableCcbType);             //1

            foreach (byte dataByte in ValidateData(v3[0], "Byte"))
            {
                datamaskedTextBox1.Add(dataByte);                               //2
            }

            upVar.Add(variableCcbType, datamaskedTextBox1);

            tb_calibDo01SN.Text = txb_do01SN.Text;
            tb_calibDi01SN.Text = txb_di01SN.Text;

            AltVar(upVar);

            Thread.Sleep(150);

            Query_btn(null, null);

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

            Enum.TryParse("DEVICE_RESET", out VARIABLES myStatus);

            variableCcbType.Add(key: myStatus, new List<byte>() { 1 });

            AltVar(variableCcbType);
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

        private void AltVar(Dictionary<VARIABLES, List<byte>> altVar)
        {
            MessageModel messageALT = MessageController.Instance.CreateMessage(altVar, 0x00, MESSAGE_TYPE.UPDATE);
            byte[] messageAltVar = MessageController.Instance.EncodeMessage(messageALT);

            if (serialPort.IsOpen)
            {
                serialPort.Write(messageAltVar, 0, messageAltVar.Length);
            }
        }

        public void SetText1(string str)
        {
            string[] strs = str.Split(",");
            strs[0] = Convert.ToString(Convert.ToDecimal((string)strs[0]) / 1000) + " V";
            strs[1] = Convert.ToString(Convert.ToDecimal((string)strs[1]) / 1000) + " V";
            txb_dc1SN.Text = strs[0];
            txb_dc2SN.Text = strs[1];
            txb_do01SN.Text = strs[2];
            txb_di01SN.Text = strs[3];

        }

        public void SetText4(string str)
        {
            textBox3.Text += str + Environment.NewLine;
            textBox3.SelectionStart = textBox3.Text.Length;
            textBox3.ScrollToCaret();
        }

        public void SetText7(string str)
        {
            textBox2.Text = str;
        }


        public void SetText9(string str)
        {
            string[] strs = str.Split(",");
            textBox7.Text = strs[0];
            textBox6.Text = strs[1];
            textBox5.Text = strs[2];
            textBox4.Text = strs[3];
        }

        MessageModel messageUSB = new MessageModel();

        private async void threadLeitor()
        {
            bool once1 = true;
            bool once2 = true;

            while (true)
            {
                string sNumber = "";
                string IPNumber = "";


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


                    if (once1)
                    {
                        askSN();
                    }

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

                        this.BeginInvoke(SetTextValue4, new object[] { BitConverter.ToString(dadosB.ToArray()) });

                        messageUSB = MessageController.Instance.DecodeMessage(dadosB);

                        for (int j = 0; j < messageUSB.message.Keys.Count; j++)
                        {
                            if (messageUSB.message.ElementAt(j).Key.ToString() == "CAL_DC01")
                            {
                                scal = returnVAR(messageUSB, "CAL_DC01");
                            }

                            if (messageUSB.message.ElementAt(j).Key.ToString() == "CAL_DC02")
                            {
                                scal = returnVAR(messageUSB, "CAL_DC02");
                            }
                        }

                        if (once1)
                        {
                            sNumber = returnSN(messageUSB);

                            if (IsValidSN(sNumber))
                            {
                                this.BeginInvoke(SetTextValue7, new object[] { sNumber });
                                once1 = false;
                            }
                        }

                        if (once2)
                        {
                            askIP();

                            if (varN >= 4)
                            {

                                string IPvalue = returnVAR(messageUSB, "IP_D") + "," + returnVAR(messageUSB, "IP_G") + "," +
                                    returnVAR(messageUSB, "IP_M") + "," + returnVAR(messageUSB, "IP_S");
                                this.BeginInvoke(SetTextValue9, new object[] { IPvalue });


                                string[] ip = IPvalue.Split(",");
                                string IP = ip[0];

                                if (IsValidIP(IP))
                                {
                                    once2 = false;
                                }

                            }
                        }

                        if (varN >= 4)
                        {
                            string vvalue = returnVAR(messageUSB, lbl_dc1SN.Text) + "," + returnVAR(messageUSB, lbl_dc2SN.Text) + "," +
                                returnVAR(messageUSB, lbl_do01SN.Text) + "," + returnVAR(messageUSB, lbl_di01SN.Text);
                            if (vvalue != null && !vvalue.Contains(",,")) { this.BeginInvoke(SetTextValue1, new object[] { vvalue }); }

                        }
                    }

                }
            }
        }

        private void askIP()
        {
            Dictionary<VARIABLES, List<byte>> varVar = new Dictionary<VARIABLES, List<byte>>();

            string[] varCPU = { "IP_D", "IP_G", "IP_M", "IP_S" };

            for (int i = 0; i < varCPU.Length; i++)
            {
                if (Enum.TryParse(varCPU[i], out VARIABLES myStatus))
                {
                    varVar.Add(key: myStatus, new List<byte>() { 0x00 });
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

        private void askCAL1()
        {
            Dictionary<VARIABLES, List<byte>> varSN = new Dictionary<VARIABLES, List<byte>>();
            varSN.Add(VARIABLES.CAL_DC01, new List<byte>() { 0x00 });
            MessageModel messageASKSN = MessageController.Instance.CreateMessage(varSN, 0x00, MESSAGE_TYPE.QUERY);
            byte[] messageSN = MessageController.Instance.EncodeMessage(messageASKSN);

            if (serialPort.IsOpen)
            {
                serialPort.Write(messageSN, 0, messageSN.Length);
            }
        }

        private void askCAL2()
        {
            Dictionary<VARIABLES, List<byte>> varSN = new Dictionary<VARIABLES, List<byte>>();
            varSN.Add(VARIABLES.CAL_DC02, new List<byte>() { 0x00 });
            MessageModel messageASKSN = MessageController.Instance.CreateMessage(varSN, 0x00, MESSAGE_TYPE.QUERY);
            byte[] messageSN = MessageController.Instance.EncodeMessage(messageASKSN);

            if (serialPort.IsOpen)
            {
                serialPort.Write(messageSN, 0, messageSN.Length);
            }
        }

        private string returnSN(MessageModel messageUSB)
        {
            string serialN = "";
            string VARvalue = "";
            List<byte> var = new List<byte>();
            byte[] var1;
            string var2;

            for (int j = 0; j < messageUSB.message.Keys.Count; j++)
            {
                if (messageUSB.message.ElementAt(j).Key.ToString() == "SN")
                {
                    var = messageUSB.message.ElementAt(j).Value;
                    var1 = var.ToArray();
                    //var1.Reverse();
                    var2 = (BitConverter.ToString(var1));
                    var2 = var2.Replace("-", "");
                    VARvalue = ConvertHex(var2);
                    serialN = ConvertHex((BitConverter.ToString(messageUSB.message.ElementAt(j).Value.ToArray())).Replace("-", ""));
                    //varKey = ConvertHex(((messageUSB.message.ElementAt(j).Key.ToString())).Replace("-", ""));                    
                    this.BeginInvoke(SetTextValue4, new object[] { serialN });
                }
            }

            return serialN;
        }

        private string returnVAR(MessageModel messageUSB, string VAR)
        {
            string VARvalue = "";
            List<byte> var = new List<byte>();
            byte[] var1;
            string var2;

            for (int j = 0; j < messageUSB.message.Keys.Count; j++)
            {
                if (messageUSB.message.ElementAt(j).Key.ToString() == VAR)
                {
                    var = messageUSB.message.ElementAt(j).Value;
                    var1 = var.ToArray();

                    if (VAR == "IP_D" || VAR == "IP_G" || VAR == "IP_M" || VAR == "IP_S")
                    {
                        var2 = Convert.ToString(var1[0]) + "." + Convert.ToString(var1[1]) + "." + Convert.ToString(var1[2]) + "." + Convert.ToString(var1[3]);

                    }
                    else
                    {

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
                    }

                    VARvalue = var2.Replace("-", "");
                    VARvalue.ToString();

                    return VARvalue;
                }
            }

            return null;
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

        public static string ConvertHex(String hexString)
        {
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

        public void Calibrado()
        {
            Thread.Sleep(100);
            textBox22.Text = string.Empty;
            string[] v1 = txb_dc1SN.Text.Split(" ");
            string[] v2 = tb_calibDc1.Text.Split(" ");
            double a = Convert.ToDouble(v1[0]);
            double b = Convert.ToDouble(v2[0]);

            double calibrado = Math.Abs(a - b);
            calibrado /= b;
            calibrado *= 100;

            if (calibrado < 5)
            {
                textBox22.Text = "Calibrado";
            }
            else
            {
                textBox22.Text = "Não Calibrado";
            }
        }

        public void Calibrado2()
        {
            Thread.Sleep(100);
            textBox23.Text = string.Empty;
            string[] v1 = txb_dc2SN.Text.Split(" ");
            string[] v2 = tb_calibDc2SN.Text.Split(" ");
            double a = Convert.ToDouble(v1[0]);
            double b = Convert.ToDouble(v2[0]);

            double calibrado = Math.Abs(a - b);
            calibrado /= b;
            calibrado *= 100;

            if (calibrado < 5)
            {
                textBox23.Text = "Calibrado";
            }
            else
            {
                textBox23.Text = "Não Calibrado";
            }
        }


        //////////////
        //// MQTT ////
        //////////////

        private void getdevices()
        {
            foreach (var device in TelemetryController.Instance.GetDevices().Values)
            {
                foreach (var boards in device.dictOfBoards.Values)
                {
                    DelegateBoardMethod(new UpdateBoardEventArgs() { board = boards });
                }
            }
        }

        public void DelegateBoardMethod(UpdateBoardEventArgs args)
        {
            var board = args.board;
            var dictonaryOfDevices = TelemetryController.Instance.GetDevices();
            string vslot = "";

            foreach (KeyValuePair<string, TelemetryDevice> serialN in dictonaryOfDevices)
            {
                if (serialN.Key == cb_serialnumber.Text)
                {
                    foreach (KeyValuePair<ushort, Board> slot in serialN.Value.dictOfBoards)
                    {
                        if (Convert.ToUInt16(slot.Key) == Convert.ToUInt16(Ccb_Slot.Text))
                        {
                            vslot = slot.Value.Type.ToString();

                            switch (Convert.ToInt16(Ccb_Slot.Text))

                            {
                                case 0:
                                    lbl_Slot.Text = "Slot (0): " + vslot;
                                    break;

                                case 2:
                                    lbl_Slot.Text = "Slot (2): " + vslot;
                                    break;

                                case 3:
                                    lbl_Slot.Text = "Slot (3): " + vslot;
                                    break;

                                case 4:
                                    lbl_Slot.Text = "Slot (3): " + vslot;
                                    break;
                            }
                        }

                        if (slot.Key == Convert.ToUInt16(0))
                        {
                            foreach (KeyValuePair<VARIABLES, List<byte>> variaveis in slot.Value.Variables)
                            {
                                if (variaveis.Key.ToString() == "IP_D")
                                {
                                    List<byte> bytes = new List<byte>();
                                    bytes = variaveis.Value;
                                    textBox11.Text = Convert.ToString(bytes[0]) + "." + Convert.ToString(bytes[1]) + "." + Convert.ToString(bytes[2]) + "." + Convert.ToString(bytes[3]);
                                }

                                if (variaveis.Key.ToString() == "IP_G")
                                {
                                    List<byte> bytes = new List<byte>();
                                    bytes = variaveis.Value;
                                    textBox10.Text = Convert.ToString(bytes[0]) + "." + Convert.ToString(bytes[1]) + "." + Convert.ToString(bytes[2]) + "." + Convert.ToString(bytes[3]);
                                }

                                if (variaveis.Key.ToString() == "IP_M")
                                {
                                    List<byte> bytes = new List<byte>();
                                    bytes = variaveis.Value;
                                    textBox9.Text = Convert.ToString(bytes[0]) + "." + Convert.ToString(bytes[1]) + "." + Convert.ToString(bytes[2]) + "." + Convert.ToString(bytes[3]);
                                }

                                if (variaveis.Key.ToString() == "IP_S")
                                {
                                    List<byte> bytes = new List<byte>();
                                    bytes = variaveis.Value;
                                    textBox8.Text = Convert.ToString(bytes[0]) + "." + Convert.ToString(bytes[1]) + "." + Convert.ToString(bytes[2]) + "." + Convert.ToString(bytes[3]);
                                }
                            }
                        }
                    }
                }
            }


            try
            {
                var dictionaryOfBoards = dictonaryOfDevices[board.SerialNumber].dictOfBoards;
                ushort v = Convert.ToUInt16(dictionaryOfBoards.ElementAt(0).Key);
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

        private void Ccb_SerialNumberUpdate_Click(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            cb.Items.Clear();
            foreach (string key in TelemetryController.Instance.GetDevices().Keys)
            {
                cb.Items.Add(key);
            }
        }

        private void Ccb_Slot_Click(object sender, EventArgs e)
        {
            ComboBox senderCb = (ComboBox)sender;
            ComboBox telemetryComboBox;
            if (senderCb == Ccb_Slot)
            {
                telemetryComboBox = cb_serialnumber;
            }
            else
            {
                telemetryComboBox = cb_serialnumber;
            }

            senderCb.Items.Clear();
            try
            {
                foreach (ushort board in TelemetryController.Instance.GetDevices()[(string)telemetryComboBox.SelectedItem].dictOfBoards.Keys)
                {
                    senderCb.Items.Add(board);
                }
            }
            catch { }
        }

        private void Ccb_Slot_TextChanged(object sender, EventArgs e)
        {

            getdevices();

            string board;

            board = lbl_Slot.Text.Substring(lbl_Slot.Text.Length - 3).Replace(" ", "");

            SetTextnVisibility(board);
            LimpaTexto();

        }

        private void cb_serialnumber_TextChanged(object sender, EventArgs e)
        {
            Ccb_Slot.Text = "0";

            string serialN = cb_serialnumber.Text;
            ushort boardS = Convert.ToUInt16(0);
            List<VARIABLES> listQ = new List<VARIABLES>();
            List<string> myList = new List<string>() { "IP_D", "IP_G", "IP_M", "IP_S" };

            foreach (string tn in myList)
            {
                if (Enum.TryParse(tn, out VARIABLES myStatus))
                {
                    listQ.Add(myStatus);
                }

            }

            try
            {
                var queryY = TelemetryController.Instance.Query(serialN, boardS, listQ);
            }
            catch (Exception exe)
            {

            }

        }

        List<string> cals = new List<string>();

        private void Query_Click(object sender, EventArgs e)
        {
            getdevices();
            string SB = lbl_Slot.Text.Substring(lbl_Slot.Text.Length - 3).Replace(" ", "");

            string serialNum = cb_serialnumber.Text;
            ushort boardS = Convert.ToUInt16(Ccb_Slot.Text);
            List<VARIABLES> listQ = new List<VARIABLES>();
            List<string> myList = new List<string>();

            if (SB == "AC")
            {
                List<string> myList1 = new List<string>() { "AC01", "AC02", "AC03" };
                List<string> myList4 = new List<string>() { "CAL50_AC01", "CAL127_AC01", "CAL220_AC01", "CAL50_AC02", "CAL127_AC02", "CAL220_AC02", "CAL50_AC03", "CAL127_AC03", "CAL220_AC03" };
                myList.AddRange(myList1);
                myList.AddRange(myList4);
            }
            else if (SB == "EB")
            {
                List<string> myList2 = new List<string>() { "DC01", "DC02", "DO01", "DI01", "DO02", "DI02", "DO03", "DI03" };
                List<string> myList5 = new List<string>() { "CAL_DC01", "CAL_DC02" };
                myList.AddRange(myList2);
                myList.AddRange(myList5);
            }
            else //CPU
            {
                List<string> myList3 = new List<string>() { "DC01", "DC02", "DO01", "DI01" };
                List<string> myList6 = new List<string>() { "CAL_DC01", "CAL_DC02" };
                myList.AddRange(myList3);
                myList.AddRange(myList6);
            }

            foreach (string tn in myList)
            {
                if (Enum.TryParse(tn, out VARIABLES myStatus))
                {
                    listQ.Add(myStatus);
                }

            }

            try
            {
                var queryY = TelemetryController.Instance.Query(serialNum, boardS, listQ);
            }
            catch (Exception exe)
            {

            }

            Thread.Sleep(2000);

            var dictonaryOfDevices = TelemetryController.Instance.GetDevices();

            foreach (KeyValuePair<string, TelemetryDevice> serialN in dictonaryOfDevices)
            {
                if (serialN.Key.ToString() == cb_serialnumber.Text)
                {
                    foreach (KeyValuePair<ushort, Board> slot in serialN.Value.dictOfBoards)
                    {
                        if (slot.Key == Convert.ToUInt16(Ccb_Slot.Text))
                        {
                            cals.Clear();
                            foreach (KeyValuePair<VARIABLES, List<byte>> variaveis in slot.Value.Variables)
                            {
                                if (SB == "AC")
                                {
                                    List<byte> bytes = new List<byte>();
                                    bytes = variaveis.Value;
                                    byte[] var1;
                                    var1 = bytes.ToArray();
                                    string var2;

                                    if (BitConverter.IsLittleEndian)
                                    {
                                        var2 = BitConverter.ToUInt16(var1.Reverse().ToArray()).ToString();
                                    }
                                    else
                                    {
                                        var2 = BitConverter.ToUInt16(var1).ToString();
                                    }

                                    if (variaveis.Key.ToString() == "AC01")
                                    {
                                        txb_dc1.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "AC02")
                                    {
                                        txb_dc2.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "AC03")
                                    {
                                        txb_do01.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "CAL50_AC01")
                                    {
                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "CAL127_AC01")
                                    {
                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "CAL220_AC01")
                                    {
                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "CAL50_AC02")
                                    {
                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "CAL127_AC02")
                                    {
                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "CAL220_AC02")
                                    {
                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "CAL50_AC03")
                                    {
                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "CAL127_AC03")
                                    {
                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "CAL220_AC03")
                                    {
                                        cals.Add(var2);
                                    }

                                }

                                else if (SB == "EB")
                                {
                                    List<byte> bytes = new List<byte>();
                                    bytes = variaveis.Value;
                                    byte[] var1;
                                    var1 = bytes.ToArray();
                                    string var2;

                                    if (variaveis.Key.ToString() == "DC01")
                                    {
                                        if (BitConverter.IsLittleEndian)
                                        {
                                            var2 = BitConverter.ToUInt16(var1.Reverse().ToArray()).ToString();
                                        }
                                        else
                                        {
                                            var2 = BitConverter.ToUInt16(var1).ToString();
                                        }

                                        txb_dc1.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "DC02")
                                    {
                                        if (BitConverter.IsLittleEndian)
                                        {
                                            var2 = BitConverter.ToUInt16(var1.Reverse().ToArray()).ToString();
                                        }
                                        else
                                        {
                                            var2 = BitConverter.ToUInt16(var1).ToString();
                                        }

                                        txb_dc2.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "CAL_DC01")
                                    {
                                        if (BitConverter.IsLittleEndian)
                                        {
                                            var2 = BitConverter.ToUInt16(var1.Reverse().ToArray()).ToString();
                                        }
                                        else
                                        {
                                            var2 = BitConverter.ToUInt16(var1).ToString();
                                        }

                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "CAL_DC02")
                                    {
                                        if (BitConverter.IsLittleEndian)
                                        {
                                            var2 = BitConverter.ToUInt16(var1.Reverse().ToArray()).ToString();
                                        }
                                        else
                                        {
                                            var2 = BitConverter.ToUInt16(var1).ToString();
                                        }

                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "DO01")
                                    {
                                        var2 = Convert.ToString(var1[0]);

                                        txb_do01.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "DI01")
                                    {
                                        var2 = Convert.ToString(var1[0]);

                                        txb_di01.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "DO02")
                                    {
                                        var2 = Convert.ToString(var1[0]);

                                        textBox12.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "DI02")
                                    {
                                        var2 = Convert.ToString(var1[0]);

                                        textBox13.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "DO03")
                                    {
                                        var2 = Convert.ToString(var1[0]);

                                        textBox14.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "DI03")
                                    {
                                        var2 = Convert.ToString(var1[0]);

                                        textBox15.Text = var2;
                                    }

                                }

                                else //SB == CPU
                                {
                                    List<byte> bytes = new List<byte>();
                                    bytes = variaveis.Value;
                                    byte[] var1;
                                    var1 = bytes.ToArray();
                                    string var2;

                                    if (variaveis.Key.ToString() == "DC01")
                                    {
                                        if (BitConverter.IsLittleEndian)
                                        {
                                            var2 = BitConverter.ToUInt16(var1.Reverse().ToArray()).ToString();
                                        }
                                        else
                                        {
                                            var2 = BitConverter.ToUInt16(var1).ToString();
                                        }

                                        txb_dc1.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "DC02")
                                    {
                                        if (BitConverter.IsLittleEndian)
                                        {
                                            var2 = BitConverter.ToUInt16(var1.Reverse().ToArray()).ToString();
                                        }
                                        else
                                        {
                                            var2 = BitConverter.ToUInt16(var1).ToString();
                                        }

                                        txb_dc2.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "CAL_DC01")
                                    {
                                        if (BitConverter.IsLittleEndian)
                                        {
                                            var2 = BitConverter.ToUInt16(var1.Reverse().ToArray()).ToString();
                                        }
                                        else
                                        {
                                            var2 = BitConverter.ToUInt16(var1).ToString();
                                        }

                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "CAL_DC02")
                                    {
                                        if (BitConverter.IsLittleEndian)
                                        {
                                            var2 = BitConverter.ToUInt16(var1.Reverse().ToArray()).ToString();
                                        }
                                        else
                                        {
                                            var2 = BitConverter.ToUInt16(var1).ToString();
                                        }

                                        cals.Add(var2);
                                    }

                                    if (variaveis.Key.ToString() == "DO01")
                                    {
                                        var2 = Convert.ToString(var1[0]);

                                        txb_do01.Text = var2;
                                    }

                                    if (variaveis.Key.ToString() == "DI01")
                                    {
                                        var2 = Convert.ToString(var1[0]);

                                        txb_di01.Text = var2;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void DO3_Click(object sender, EventArgs e)
        {
            Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

            Enum.TryParse("DO03", out VARIABLES myStatus);

            if (textBox14.Text == "1")
            {
                variableCcbType.Add(key: myStatus, new List<byte>() { 0x00 });
            }
            else
            {
                variableCcbType.Add(key: myStatus, new List<byte>() { 0x01 });
            }

            TelemetryController.Instance.Update(cb_serialnumber.Text, Convert.ToUInt16(Ccb_Slot.Text), variableCcbType);
        }

        private void DO2_Click(object sender, EventArgs e)
        {
            Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

            Enum.TryParse("DO02", out VARIABLES myStatus);

            if (textBox12.Text == "1")
            {
                variableCcbType.Add(key: myStatus, new List<byte>() { 0x00 });
            }
            else
            {
                variableCcbType.Add(key: myStatus, new List<byte>() { 0x01 });
            }

            TelemetryController.Instance.Update(cb_serialnumber.Text, Convert.ToUInt16(Ccb_Slot.Text), variableCcbType);
        }

        private void DO1_Click(object sender, EventArgs e)
        {
            if (lbl_d01.Text == "DO01")
            {
                Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

                Enum.TryParse("DO01", out VARIABLES myStatus);

                if (txb_do01.Text == "1")
                {
                    variableCcbType.Add(key: myStatus, new List<byte>() { 0x00 });
                }
                else
                {
                    variableCcbType.Add(key: myStatus, new List<byte>() { 0x01 });
                }

                TelemetryController.Instance.Update(cb_serialnumber.Text, Convert.ToUInt16(Ccb_Slot.Text), variableCcbType);
            }

            if (lbl_d01.Text == "AC03")
            {
                string[] v1 = txb_do01.Text.Split(" ");
                string[] v2 = lbl_do01Calibrar.Text.Split(" ");
                double valor1 = Convert.ToDouble(v1[0]);
                double valor2 = Convert.ToDouble(v2[0]);

                double CAL = 0;
                string volt = null;

                if (valor1 >= 0 && valor2 > 0)
                {
                    if (valor2 <= 7680)
                    {
                        CAL = Convert.ToDouble(cals[6]) * (valor2 / valor1);
                        volt = "CAL50_AC03";
                    }
                    else if (valor2 > 7680 && valor2 <= 19456)
                    {
                        CAL = Convert.ToDouble(cals[7]) * (valor2 / valor1);
                        volt = "CAL127_AC03";
                    }
                    else if (valor2 > 19456)
                    {
                        CAL = Convert.ToDouble(cals[8]) * (valor2 / valor1);
                        volt = "CAL220_AC03";
                    }

                    if (CAL > 0 && volt != null)
                    {

                        string[] v3 = CAL.ToString().Split(",");

                        Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

                        List<byte> datamaskedTextBox1 = new List<byte>();

                        Enum.TryParse(volt, out VARIABLES myStatus);

                        foreach (byte dataByte in ValidateData(v3[0], "Short"))
                        {
                            datamaskedTextBox1.Add(dataByte);                               //2
                        }

                        variableCcbType.Add(key: myStatus, datamaskedTextBox1);

                        TelemetryController.Instance.Update(cb_serialnumber.Text, Convert.ToUInt16(Ccb_Slot.Text), variableCcbType);
                    }
                }
            }
        }

        private void btn_cal2_click(object sender, EventArgs e)
        {
            if (lbl_dc2.Text == "AC02")
            {
                string[] v1 = txb_dc2.Text.Split(" ");
                string[] v2 = lbl_dc2Calibrar.Text.Split(" ");
                double valor1 = Convert.ToDouble(v1[0]);
                double valor2 = Convert.ToDouble(v2[0]);
                double CAL = 0;
                string volt = null;

                if (valor1 >= 0 && valor2 > 0)
                {
                    if (valor2 <= 7680)
                    {
                        CAL = Convert.ToDouble(cals[3]) * (valor2 / valor1);
                        volt = "CAL50_AC02";
                    }
                    else if (valor2 > 7680 && valor2 <= 19456)
                    {
                        CAL = Convert.ToDouble(cals[4]) * (valor2 / valor1);
                        volt = "CAL127_AC02";
                    }
                    else if (valor2 > 19456)
                    {
                        CAL = Convert.ToDouble(cals[5]) * (valor2 / valor1);
                        volt = "CAL220_AC02";
                    }

                    if (CAL > 0 && volt != null)
                    {

                        string[] v3 = CAL.ToString().Split(",");

                        Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

                        List<byte> datamaskedTextBox1 = new List<byte>();

                        Enum.TryParse(volt, out VARIABLES myStatus);

                        foreach (byte dataByte in ValidateData(v3[0], "Short"))
                        {
                            datamaskedTextBox1.Add(dataByte);                               //2
                        }

                        variableCcbType.Add(key: myStatus, datamaskedTextBox1);

                        TelemetryController.Instance.Update(cb_serialnumber.Text, Convert.ToUInt16(Ccb_Slot.Text), variableCcbType);
                    }
                }
            }

            if (lbl_dc2.Text == "DC02")
            {
                double valor1 = Convert.ToDouble(txb_dc2.Text);
                double valor2 = Convert.ToDouble(lbl_dc2Calibrar.Text);
                double CAL;

                if (valor1 >= 0 && valor2 > 0)
                {
                    CAL = Convert.ToDouble(cals[1]) * (valor2 / valor1);
                    string[] v3 = CAL.ToString().Split(",");


                    Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

                    List<byte> datamaskedTextBox1 = new List<byte>();

                    Enum.TryParse("CAL_DC02", out VARIABLES myStatus);

                    foreach (byte dataByte in ValidateData(v3[0], "Short"))
                    {
                        datamaskedTextBox1.Add(dataByte);                               //2
                    }

                    variableCcbType.Add(key: myStatus, datamaskedTextBox1);

                    TelemetryController.Instance.Update(cb_serialnumber.Text, Convert.ToUInt16(Ccb_Slot.Text), variableCcbType);
                }
            }
        }

        private void btn_cal1_click(object sender, EventArgs e)
        {
            if (lbl_dc1.Text == "AC01")
            {
                string[] v1 = txb_dc1.Text.Split(" ");
                string[] v2 = txb_dc1Calibrar.Text.Split(" ");
                double valor1 = Convert.ToDouble(v1[0]);
                double valor2 = Convert.ToDouble(v2[0]);
                double CAL = 0;
                string volt = null;

                if (valor1 >= 0 && valor2 > 0)
                {
                    if (valor2 <= 7680)
                    {
                        CAL = Convert.ToDouble(cals[0]) * (valor2 / valor1);
                        volt = "CAL50_AC01";
                    }
                    else if (valor2 > 7680 && valor2 <= 19456)
                    {
                        CAL = Convert.ToDouble(cals[1]) * (valor2 / valor1);
                        volt = "CAL127_AC01";
                    }
                    else if (valor2 > 19456)
                    {
                        CAL = Convert.ToDouble(cals[2]) * (valor2 / valor1);
                        volt = "CAL220_AC01";
                    }

                    if (CAL > 0 && volt != null)
                    {

                        string[] v3 = CAL.ToString().Split(",");

                        Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

                        List<byte> datamaskedTextBox1 = new List<byte>();

                        Enum.TryParse(volt, out VARIABLES myStatus);

                        foreach (byte dataByte in ValidateData(v3[0], "Short"))
                        {
                            datamaskedTextBox1.Add(dataByte);                               //2
                        }

                        variableCcbType.Add(key: myStatus, datamaskedTextBox1);

                        TelemetryController.Instance.Update(cb_serialnumber.Text, Convert.ToUInt16(Ccb_Slot.Text), variableCcbType);
                    }
                }
            }

            if (lbl_dc1.Text == "DC01")
            {
                double valor1 = Convert.ToDouble(txb_dc1.Text);
                double valor2 = Convert.ToDouble(txb_dc1Calibrar.Text);
                double CAL;

                if (valor1 >= 0 && valor2 > 0)
                {
                    CAL = Convert.ToDouble(cals[0]) * (valor2 / valor1);
                    string[] v3 = CAL.ToString().Split(",");


                    Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

                    List<byte> datamaskedTextBox1 = new List<byte>();

                    Enum.TryParse("CAL_DC01", out VARIABLES myStatus);

                    foreach (byte dataByte in ValidateData(v3[0], "Short"))
                    {
                        datamaskedTextBox1.Add(dataByte);                               //2
                    }

                    variableCcbType.Add(key: myStatus, datamaskedTextBox1);

                    TelemetryController.Instance.Update(cb_serialnumber.Text, Convert.ToUInt16(Ccb_Slot.Text), variableCcbType);
                }
            }
        }

        public void LimpaTexto()
        {
            txb_dc1.Text = "";
            txb_dc2.Text = "";
            txb_do01.Text = "";
            txb_di01.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            txb_dc1Calibrar.Text = "";
            lbl_dc2Calibrar.Text = "";
            lbl_do01Calibrar.Text = "";
        }

        public void SetTextnVisibility(string board)
        {
            switch (board)
            {
                case "CPU":
                    lbl_dc1.Text = "DC01";
                    lbl_dc2.Text = "DC02";
                    lbl_d01.Text = "DO01";
                    lbl_di01.Text = "DI01";
                    label12.Text = "";
                    label13.Text = "";
                    label14.Text = "";
                    label15.Text = "";
                    //1
                    lbl_dc1.Visible = true;
                    txb_dc1.Visible = true;
                    btn_dc1.Visible = true;
                    txb_dc1Calibrar.Visible = true;
                    //2
                    lbl_dc2.Visible = true;
                    txb_dc2.Visible = true;
                    btn_dc2.Visible = true;
                    lbl_dc2Calibrar.Visible = true;
                    //3
                    lbl_d01.Visible = true;
                    txb_do01.Visible = true;
                    btn_do01.Visible = true;
                    lbl_do01Calibrar.Visible = true;
                    //4
                    lbl_di01.Visible = true;
                    txb_di01.Visible = true;
                    btn_di01.Visible = true;
                    //5
                    label12.Visible = false;
                    textBox12.Visible = false;
                    button1.Visible = false;
                    //6
                    label13.Visible = false;
                    textBox13.Visible = false;
                    button2.Visible = false;
                    //7
                    label14.Visible = false;
                    textBox14.Visible = false;
                    button3.Visible = false;
                    //8
                    label15.Visible = false;
                    textBox15.Visible = false;
                    button4.Visible = false;
                    break;

                case "AC":
                    lbl_dc1.Text = "AC01";
                    lbl_dc2.Text = "AC02";
                    lbl_d01.Text = "AC03";
                    btn_do01.Text = "Calibrar";
                    lbl_di01.Text = "";
                    label12.Text = "";
                    label13.Text = "";
                    label14.Text = "";
                    label15.Text = "";
                    //1
                    lbl_dc1.Visible = true;
                    txb_dc1.Visible = true;
                    btn_dc1.Visible = true;
                    txb_dc1Calibrar.Visible = true;
                    //2
                    lbl_dc2.Visible = true;
                    txb_dc2.Visible = true;
                    btn_dc2.Visible = true;
                    lbl_dc2Calibrar.Visible = true;
                    //3
                    lbl_d01.Visible = true;
                    txb_do01.Visible = true;
                    btn_do01.Visible = true;
                    lbl_do01Calibrar.Visible = true;
                    //4
                    lbl_di01.Visible = false;
                    txb_di01.Visible = false;
                    btn_di01.Visible = false;
                    //5
                    label12.Visible = false;
                    textBox12.Visible = false;
                    button1.Visible = false;
                    //6
                    label13.Visible = false;
                    textBox13.Visible = false;
                    button2.Visible = false;
                    //7
                    label14.Visible = false;
                    textBox14.Visible = false;
                    button3.Visible = false;
                    //8
                    label15.Visible = false;
                    textBox15.Visible = false;
                    button4.Visible = false;
                    break;

                case "EB":
                    lbl_dc1.Text = "DC01";
                    lbl_dc2.Text = "DC02";
                    lbl_d01.Text = "DO01";
                    lbl_di01.Text = "DI01";
                    label12.Text = "DO02";
                    label13.Text = "DI02";
                    label14.Text = "DO03";
                    label15.Text = "DI03";
                    //1
                    lbl_dc1.Visible = true;
                    txb_dc1.Visible = true;
                    btn_dc1.Visible = true;
                    txb_dc1Calibrar.Visible = true;
                    //2
                    lbl_dc2.Visible = true;
                    txb_dc2.Visible = true;
                    btn_dc2.Visible = true;
                    lbl_dc2Calibrar.Visible = true;
                    //3
                    lbl_d01.Visible = true;
                    txb_do01.Visible = true;
                    btn_do01.Visible = true;
                    lbl_do01Calibrar.Visible = true;
                    //4
                    lbl_di01.Visible = true;
                    txb_di01.Visible = true;
                    btn_di01.Visible = true;
                    //5
                    label12.Visible = true;
                    textBox12.Visible = true;
                    button1.Visible = true;
                    //6
                    label13.Visible = true;
                    textBox13.Visible = true;
                    button2.Visible = true;
                    //7
                    label14.Visible = true;
                    textBox14.Visible = true;
                    button3.Visible = true;
                    //8
                    label15.Visible = true;
                    textBox15.Visible = true;
                    button4.Visible = true;
                    break;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

            Enum.TryParse("DEVICE_RESET", out VARIABLES myStatus);

            variableCcbType.Add(key: myStatus, new List<byte>() { 1 });

            TelemetryController.Instance.Update(cb_serialnumber.Text, Convert.ToUInt16(0), variableCcbType);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string corrente1 = txb_medCorrenteSN.Text;
            ushort current1 = Convert.ToUInt16(corrente1);
            double porcent;

            if (current1 > 20)
            {
                current1 = 20;
            }

            if (current1 < 4)
            {
                current1 = 4;
            }

            porcent = 2.55 * (current1 - 4) / 0.16;

            textBox20.Text = Convert.ToString(Convert.ToInt16(porcent));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string corrente1 = textBox1.Text;
            ushort current1 = Convert.ToUInt16(corrente1);
            double porcent;

            if (current1 > 20)
            {
                current1 = 20;
            }

            if (current1 < 4)
            {
                current1 = 4;
            }

            porcent = 2.55 * (current1 - 4) / 0.16;

            textBox21.Text = Convert.ToString(Convert.ToInt16(porcent));
        }
    }
}
