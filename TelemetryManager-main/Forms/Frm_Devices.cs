using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TelemetryLibrary.TelemetryStructure;
using TelemetryManager.Model;

namespace NewTelemetryManager.Forms
{
    public partial class Frm_Devices : Form
    {
        public delegate void DelegateBoard(UpdateBoardEventArgs args);
        public DelegateBoard BoardUpdateDelegate;

        public bool processExecuted = false;
        List<string> dataSN = new List<string>();
        List<string> dataS = new List<string>();
        List<string> dataC = new List<string>();
        List<string> dataI = new List<string>();
        List<string> data1 = new List<string>();
        List<string> data2 = new List<string>();
        List<string> data3 = new List<string>();

        int numChecked = 0;

        public Frm_Devices()
        {
            InitializeComponent();
            Trv_Variables.CheckBoxes = true;
            treeView1.CheckBoxes = true;
            PopulateTreeView("");
            PopulateTreeView1("");
            if (TelemetryController.Instance.isMaintenance)
            {
                SetVisibility();
            }

            System.Threading.Thread.Sleep(500);

            getdevices();
        }

        private void SetVisibility()
        {
            Ccb_SerialNumberUpdate.Enabled = false;
            Ccb_SlotUpdate.Enabled = false;
            Ccb_Type.Enabled = false;
            treeView1.Enabled = false;
            button3.Enabled = false;
            treeView2.Enabled = false;
            Btn_Update.Enabled = false;
            Btn_ClearUpdate.Enabled = false;
        }

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

        private void Ccb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTreeView1(Ccb_Type.Text);

            switch (Ccb_Type.Text)
            {
                case "Byte":
                    Msk_Type.Text = "0";
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
                telemetryNode = AddToTelemetryNode(board);

                var dictionaryOfBoards = dictonaryOfDevices[board.SerialNumber].dictOfBoards;

                ushort boardKey = dictonaryOfDevices[board.SerialNumber].dictOfBoards.FirstOrDefault(x => x.Value == board).Key;

                string boardNodeName = SetupBoardNodeName(dictionaryOfBoards, boardKey);

                boardNode = AddToBoardNode(telemetryNode, boardKey, boardNodeName);

                var dictionaryOfVariables = dictionaryOfBoards[boardKey].Variables;

                if (Trv_Devices.SelectedNode != null)
                {
                    if (Trv_Devices.SelectedNode.Name == boardKey.ToString() && Trv_Devices.SelectedNode.Parent.Text == board.SerialNumber)
                    {
                        SetActiveDictionary(board);
                    }
                }


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

        private TreeNode AddToBoardNode(TreeNode telemetryNode, ushort boardKey, string boardNodeName)
        {
            TreeNode boardNode;
            if (telemetryNode.Nodes.ContainsKey(boardKey.ToString()))
            {
                boardNode = telemetryNode.Nodes[boardKey.ToString()];
                if (boardNode.Text != boardNodeName)
                    boardNode.Text = boardNodeName;
            }
            else
            {
                //adding boards to TreeView Device node 
                boardNode = telemetryNode.Nodes.Add(boardKey.ToString(), boardNodeName);
                Trv_Devices.Sort();
            }

            return boardNode;
        }

        private static string SetupBoardNodeName(Dictionary<ushort, Board> dictionaryOfBoards, ushort boardKey)
        {
            return "Slot " + boardKey + " - " + Enum.GetName(typeof(BOARDS), dictionaryOfBoards[boardKey].Type)
                                + " v" + dictionaryOfBoards[boardKey].Version.ToString("#\".\"#\".\"#");
        }

        private TreeNode AddToTelemetryNode(Board board)
        {
            TreeNode telemetryNode;
            if (Trv_Devices.Nodes.ContainsKey(board.SerialNumber))
            {
                telemetryNode = Trv_Devices.Nodes[board.SerialNumber];
            }
            else
            {
                telemetryNode = Trv_Devices.Nodes.Add(board.SerialNumber, board.SerialNumber);
            }

            return telemetryNode;
        }

        private void SetActiveDictionary(Board board)
        {
            var boardVariables =
                    from row in board.Variables
                    select new
                    {
                        Variable = row.Key,
                        DataArray = BitConverter.ToString(row.Value.ToArray()),
                        DataInt =
                        row.Value.Count == 2 ?
                        BitConverter.IsLittleEndian ?
                        BitConverter.ToUInt16(row.Value.ToArray().Reverse().ToArray()).ToString() :
                        BitConverter.ToUInt16(row.Value.ToArray()).ToString() :
                        row.Value.Count == 1 ?
                        row.Value[0].ToString() :
                        "",
                        DataIP =
                        row.Value.Count == 4 ?
                        String.Format("{0}.{1}.{2}.{3}", row.Value[0], row.Value[1], row.Value[2], row.Value[3]) :
                        "",
                        DataText = Encoding.UTF8.GetString(row.Value.ToArray())
                    };
            dataGridView1.DataSource = boardVariables.ToArray();
        }

        private static TreeNode AddToValueNode(TreeNode variablesNode, byte[] bytes, byte[] invertedBytes)
        {
            TreeNode valueNode;
            if (variablesNode.Nodes.Count > 0)
            {
                Array.Reverse(invertedBytes, 0, invertedBytes.Length);
                string variableText = String.Format("{0}", BitConverter.ToString(bytes) + String.Format(" ({0})", BitConverter.ToUInt16(invertedBytes).ToString()));

                valueNode = variablesNode.Nodes[0];
                if (valueNode.Text != variableText)
                {
                    valueNode.Text = variableText;
                }
            }
            else
            {
                valueNode = variablesNode.Nodes.Add(String.Format("{0}", BitConverter.ToString(bytes)));

                valueNode.Text += String.Format(" ({0})", BitConverter.ToUInt16(invertedBytes).ToString());

            }

            return valueNode;
        }

        private static void ByteOperation(Dictionary<VARIABLES, List<byte>> dictionaryOfVariables, VARIABLES variableKey, out byte[] bytes, out byte[] invertedBytes)
        {
            bytes = dictionaryOfVariables[variableKey].ToArray();
            invertedBytes = new byte[bytes.Length];
            Array.Copy(bytes, invertedBytes, bytes.Length);
            invertedBytes.Reverse();
        }

        private static TreeNode AddToVariableNode(TreeNode boardNode, VARIABLES variableKey)
        {
            TreeNode variablesNode;
            if (boardNode.Nodes.ContainsKey(variableKey.ToString()))
            {
                variablesNode = boardNode.Nodes[Enum.GetName(typeof(VARIABLES), variableKey)];
            }
            else
            {
                //Adding all variables in the board to the variables Node
                variablesNode = boardNode.Nodes.Add(variableKey.ToString(), Enum.GetName(typeof(VARIABLES), variableKey));
            }

            return variablesNode;
        }


        private void Ccb_SerialNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ccb_Slot.Items.Clear();
            foreach (ushort board in TelemetryController.Instance.GetDevices()[(string)Ccb_SerialNumber.SelectedItem].dictOfBoards.Keys)
            {
                Ccb_Slot.Items.Add(board);
            }
        }

        private void Ccb_SerialNumber_Click(object sender, EventArgs e)
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
                telemetryComboBox = Ccb_SerialNumber;
            }
            else
            {
                telemetryComboBox = Ccb_SerialNumberUpdate;
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

        private void Ccb_SerialNumberUpdate_Click(object sender, EventArgs e)
        {
            ComboBox serialNumberUpdate = (ComboBox)sender;
            serialNumberUpdate.Items.Clear();
            foreach (string key in TelemetryController.Instance.GetDevices().Keys)
            {
                serialNumberUpdate.Items.Add(key);
            }

            for (int c = 0; c < serialNumberUpdate.Items.Count; c++)
            {
                Ccb_SlotUpdate.Items.Add(serialNumberUpdate.Items[c]);
            }
        }

        private void Txb_FilterVariable_TextChanged(object sender, EventArgs e)
        {
            PopulateTreeView(Txb_FilterVariable.Text);
        }



        private void Btn_ClearUpdate_Click(object sender, EventArgs e)
        {

            dataC.Clear();
            dataS.Clear();
            dataI.Clear();
            data1.Clear();
            data2.Clear();
            data3.Clear();

            treeView2.Nodes.Clear();

            foreach (TreeNode tn in treeView1.Nodes)
            {
                if (tn.Checked)
                {
                    tn.Checked = false;
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (variables != null && msgNotRepeated != null)
            {
                variables.Clear();
                msgNotRepeated.Clear();
            }

            List<String> treeNodeList = new List<String>();
            UpdateMessageModel updateMessage;

            List<string> dataSNU = new List<string>();
            List<string> dataSlot = new List<string>();
            List<string> dataVar = new List<string>();
            List<string> dataTipo = new List<string>();
            List<string> dataInfo = new List<string>();

            foreach (TreeNode SN in treeView2.Nodes)
            {
                foreach (TreeNode slot in SN.Nodes)
                {
                    foreach (TreeNode info in slot.Nodes)
                    {
                        if (info.Checked)
                        {
                            dataSNU.Add(SN.Text);
                            dataSlot.Add(slot.Text);
                            dataVar.Add(info.Text.Substring(0, info.Text.IndexOf("(") - 1));
                            dataTipo.Add(info.Text.Substring(info.Text.IndexOf("(") + 1, info.Text.IndexOf(")") - info.Text.IndexOf("(") - 1));
                            dataInfo.Add(info.Text.Substring(info.Text.IndexOf(")") + 3));
                        }
                    }
                }
            }

            SepareteMessages(dataSNU, dataSlot, dataVar, dataTipo, dataInfo);

            Dictionary<VARIABLES, List<byte>> variableCcbType = new Dictionary<VARIABLES, List<byte>>();

            for (int i = 0; i < msgNotRepeated.Count; i++)
            {
                string strCcb_SerialNumberUpdate = msgNotRepeated.ElementAt(i).SerialNumber;                       //1

                ushort boardSlotUpdate = Convert.ToUInt16(msgNotRepeated.ElementAt(i).Slot);              //2

                List<byte>[] datamaskedTextBox2 = new List<byte>[msgNotRepeated.ElementAt(i).VarList.Count];

                for (int k = 0; k < msgNotRepeated.ElementAt(i).VarList.Count; k++)
                {
                    datamaskedTextBox2[k] = new List<byte>();
                    foreach (byte dataByte in ValidateData(msgNotRepeated.ElementAt(i).InfoList[k], msgNotRepeated.ElementAt(i).TypeList[k]))
                    {
                        datamaskedTextBox2[k].Add(dataByte);                                //4
                    }

                    Enum.TryParse(msgNotRepeated.ElementAt(i).VarList[k], out VARIABLES myStatus);

                    variableCcbType.Add(key: myStatus, datamaskedTextBox2[k]);       //3
                }

                System.Threading.Thread.Sleep(200);
                TelemetryController.Instance.Update(strCcb_SerialNumberUpdate, boardSlotUpdate, variableCcbType);

                variableCcbType.Clear();
            }
        }

        List<UpdateMessageModel> variables = new List<UpdateMessageModel>();
        List<UpdateMessageModel> msgNotRepeated = new List<UpdateMessageModel>();

        private List<UpdateMessageModel> SepareteMessages(List<string> dataSNU, List<string> dataSlot, List<string> dataVar, List<string> dataTipo, List<string> dataInfo)
        {
            List<string> equalValues = new List<string>();
            List<UpdateMessageModel> updateMessages = new List<UpdateMessageModel>();

            for (int counter = 0; counter < dataSNU.Count; counter++)
            {
                equalValues.Add(dataSNU.ElementAt(counter));
                equalValues.Add(dataSlot.ElementAt(counter));
                equalValues.Add(dataVar.ElementAt(counter));
                equalValues.Add(dataTipo.ElementAt(counter));
                equalValues.Add(dataInfo.ElementAt(counter));
                AddPropertiesToMessage(equalValues);
                updateMessages.Add(new UpdateMessageModel(equalValues.First(), equalValues.ElementAt(1),
                    equalValues.ElementAt(2), equalValues.ElementAt(3), equalValues.ElementAt(4)));
                equalValues.RemoveRange(0, 5);
            }

            RearrengeMessage();
            //int collectionLength = updateMessages.Count;
            //CheckDuplicatesInsideCollections(updateMessages, collectionLength);
            return msgNotRepeated;
        }

        private void RearrengeMessage()
        {
            if (msgNotRepeated != null)
            {
                msgNotRepeated.Clear();
            }

            for (int count = 0; count < variables.Count; count++)
            {
                int vizinho = count + 1;
                int atual = 0;
                if (variables.Count == 1)
                {
                    msgNotRepeated.Add(variables.ElementAt(0));
                }
                else
                {

                    while (vizinho < variables.Count)
                    {
                        //Check if actual and subsequent elements are equals
                        if ((variables.ElementAt(atual).SerialNumber == variables.ElementAt(vizinho).SerialNumber)
                            && (variables.ElementAt(atual).Slot == variables.ElementAt(vizinho).Slot))
                        {
                            if (msgNotRepeated.Count == 0)
                            {
                                msgNotRepeated.Add(variables.ElementAt(atual));
                                msgNotRepeated.ElementAt(atual).VarList.Add(variables.ElementAt(vizinho).Var);
                                msgNotRepeated.ElementAt(atual).TypeList.Add(variables.ElementAt(vizinho).Type);
                                msgNotRepeated.ElementAt(atual).InfoList.Add(variables.ElementAt(vizinho).Info);
                            }
                            else if (IsElementRepeated(msgNotRepeated, variables.ElementAt(vizinho))) { }

                        }
                        else
                        {
                            msgNotRepeated.Add(variables.ElementAt(vizinho));
                        }
                        vizinho++;
                        atual++;
                    }
                }
                break;
            }
        }

        private void AddPropertiesToMessage(List<string> equalValues)
        {

            variables.Add(new UpdateMessageModel(equalValues.First(),
                equalValues[1], equalValues[2], equalValues[3], equalValues[4]));
        }

        bool IsElementRepeated(List<UpdateMessageModel> collection, UpdateMessageModel element)
        {
            foreach (UpdateMessageModel item in collection)
            {
                if (item.SerialNumber == element.SerialNumber && item.Slot == element.Slot)
                {
                    item.VarList.Add(element.Var);
                    item.TypeList.Add(element.Type);
                    item.InfoList.Add(element.Info);
                    return true;
                }
            }
            msgNotRepeated.Add(element);
            return false;
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

        private void Btn_Query_Click(object sender, EventArgs e)
        {
            getdevices();

            string serialN = Ccb_SerialNumber.Text;
            ushort boardS = Convert.ToUInt16(Ccb_Slot.Text);
            List<VARIABLES> listQ = new List<VARIABLES>();
            foreach (TreeNode tn in Trv_Variables.Nodes)
            {
                if (tn.Checked)
                {
                    if (Enum.TryParse(tn.Text, out VARIABLES myStatus))
                    {
                        listQ.Add(myStatus);
                    }
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

        private void Btn_ExpandAllDevices_Click(object sender, EventArgs e)
        {
            Trv_Devices.ExpandAll();
        }

        private void Btn_ClearAllDevices_Click(object sender, EventArgs e)
        {
            Trv_Devices.CollapseAll();
        }

        private void Btn3_Click(object sende, EventArgs e)
        {
            if (Msk_Type.Text != "" && Ccb_Type.Text != "" && Ccb_SlotUpdate.Text != "" && Ccb_SerialNumberUpdate.Text != "" && Msk_Type.BackColor == Color.Green)

            {
                foreach (TreeNode tn in treeView1.Nodes)
                {
                    if (tn.Checked)
                    {
                        string dataSN = Ccb_SerialNumberUpdate.Text;
                        string dataSS = Ccb_SlotUpdate.Text;
                        string dataCS = tn.Text;
                        string dataIS = Msk_Type.Text;

                        string dataTi = Ccb_Type.Text;

                        data1.Add(dataSN);
                        data2.Add(dataSS);
                        data3.Add(dataCS + " (" + dataTi + "): " + dataIS);

                        createTrv(data1, data2, data3);

                    }
                }
            }
        }


        private void createTrv(List<string> d1, List<string> d2, List<string> d3)
        {
            List<string> data = new List<string>();



            for (int i = 0; i < d1.Count; i++)
            {
                data.Add(d1[i] + d2[i] + d3[i]);
            }

            data.Sort();

            for (int i = 0; i < data.Count; i++)
            {
                d1[i] = data[i].Substring(0, 7);
                d2[i] = data[i].Substring(7, 1);
                d3[i] = data[i].Substring(8);
            }

            for (int i = 0; i < d1.Count; i++)
            {
                if (!dataC.Contains(d1[i]))
                {
                    treeView2.Nodes.Add(d1[i]);
                    dataC.Add(d1[i]);
                }
            }

            for (int i = 0; i < d2.Count; i++)
            {
                for (int j = 0; j < treeView2.Nodes.Count; j++)
                {
                    if (d1[i] == treeView2.Nodes[j].Text && !dataS.Contains(d1[i] + d2[i]))
                    {
                        treeView2.Nodes[j].Nodes.Add(d2[i]);
                        dataS.Add(d1[i] + d2[i]);
                    }
                }
            }

            for (int i = 0; i < d3.Count; i++)
            {
                for (int j = 0; j < treeView2.Nodes.Count; j++)
                {
                    for (int k = 0; k < treeView2.Nodes[j].Nodes.Count; k++)
                    {
                        if (d1[i] == treeView2.Nodes[j].Text && d2[i] == treeView2.Nodes[j].Nodes[k].Text && !dataI.Contains(d1[i] + d2[i] + d3[i]))
                        {
                            treeView2.Nodes[j].Nodes[k].Nodes.Add(d3[i]);
                            dataI.Add(d1[i] + d2[i] + d3[i]);
                        }
                    }
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


        private void Trv_Devices_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}