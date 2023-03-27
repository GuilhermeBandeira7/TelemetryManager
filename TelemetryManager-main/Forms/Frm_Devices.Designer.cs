using System.Drawing;
using System.Windows.Forms;

namespace NewTelemetryManager.Forms
{
    partial class Frm_Devices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Node0");
            TreeNode treeNode2 = new TreeNode("Node1");
            TreeNode treeNode3 = new TreeNode("SerialNumber", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Node0");
            TreeNode treeNode5 = new TreeNode("Node1");
            TreeNode treeNode6 = new TreeNode("SerialNumber", new TreeNode[] { treeNode4, treeNode5 });
            Pnl_ServerBackground = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Lbl_TitleQuery = new Label();
            Trv_Variables = new TreeView();
            Lbl_SerialNumber = new Label();
            Lbl_SearchForVariable = new Label();
            label2 = new Label();
            Btn_Query = new Button();
            Btn_ClearVariables = new Button();
            Lbl_Title = new Label();
            Pnl_ContainerVariables = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            Trv_Devices = new TreeView();
            Btn_ClearAllDevices = new Button();
            Btn_ExpandAllDevices = new Button();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            Lbl_Update = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            Ccb_SerialNumberUpdate = new ComboBox();
            label7 = new Label();
            treeView1 = new TreeView();
            tableLayoutPanel9 = new TableLayoutPanel();
            Ccb_SlotUpdate = new ComboBox();
            label1 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            Lbl_MsgValueType = new Label();
            Ccb_Type = new ComboBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            label3 = new Label();
            Msk_Type = new MaskedTextBox();
            Btn_ClearUpdate = new Button();
            Btn_Update = new Button();
            treeView2 = new TreeView();
            button3 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            button1 = new Button();
            label4 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            button2 = new Button();
            label5 = new Label();
            Btn_ClearVariables = new Button();
            Ccb_Slot = new ComboBox();
            Ccb_SerialNumber = new ComboBox();
            Txb_FilterVariable = new TextBox();
            Pnl_ServerBackground.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            Pnl_ContainerVariables.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_ServerBackground
            // 
            Pnl_ServerBackground.AutoScroll = true;
            Pnl_ServerBackground.BackColor = Color.FromArgb(8, 32, 50);
            Pnl_ServerBackground.Controls.Add(tableLayoutPanel2);
            Pnl_ServerBackground.Dock = DockStyle.Fill;
            Pnl_ServerBackground.Location = new Point(325, 23);
            Pnl_ServerBackground.Name = "Pnl_ServerBackground";
            Pnl_ServerBackground.Size = new Size(273, 584);
            Pnl_ServerBackground.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(Lbl_TitleQuery, 0, 0);
            tableLayoutPanel2.Controls.Add(Trv_Variables, 0, 4);
            tableLayoutPanel2.Controls.Add(Lbl_SerialNumber, 0, 1);
            tableLayoutPanel2.Controls.Add(Txb_FilterVariable, 1, 3);
            tableLayoutPanel2.Controls.Add(Ccb_SerialNumber, 1, 1);
            tableLayoutPanel2.Controls.Add(Lbl_SearchForVariable, 0, 3);
            tableLayoutPanel2.Controls.Add(Ccb_Slot, 1, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(Btn_Query, 0, 5);
            tableLayoutPanel2.Controls.Add(Btn_ClearVariables, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.Size = new Size(273, 584);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // Lbl_TitleQuery
            // 
            Lbl_TitleQuery.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(Lbl_TitleQuery, 2);
            Lbl_TitleQuery.Dock = DockStyle.Fill;
            Lbl_TitleQuery.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_TitleQuery.ForeColor = Color.Transparent;
            Lbl_TitleQuery.Location = new Point(3, 0);
            Lbl_TitleQuery.Name = "Lbl_TitleQuery";
            Lbl_TitleQuery.Size = new Size(267, 50);
            Lbl_TitleQuery.TabIndex = 3;
            Lbl_TitleQuery.Text = "Query";
            Lbl_TitleQuery.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Trv_Variables
            // 
            Trv_Variables.BackColor = Color.FromArgb(8, 32, 50);
            Trv_Variables.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(Trv_Variables, 2);
            Trv_Variables.Dock = DockStyle.Fill;
            Trv_Variables.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Trv_Variables.ForeColor = Color.Transparent;
            Trv_Variables.Location = new Point(3, 203);
            Trv_Variables.Name = "Trv_Variables";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Tvn_Node1";
            treeNode3.Text = "SerialNumber";
            Trv_Variables.Nodes.AddRange(new TreeNode[] { treeNode3 });
            Trv_Variables.Size = new Size(267, 328);
            Trv_Variables.TabIndex = 2;
            // 
            // Lbl_SerialNumber
            // 
            Lbl_SerialNumber.AutoSize = true;
            Lbl_SerialNumber.Dock = DockStyle.Fill;
            Lbl_SerialNumber.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_SerialNumber.ForeColor = Color.Transparent;
            Lbl_SerialNumber.Location = new Point(3, 50);
            Lbl_SerialNumber.Name = "Lbl_SerialNumber";
            Lbl_SerialNumber.Size = new Size(130, 50);
            Lbl_SerialNumber.TabIndex = 4;
            Lbl_SerialNumber.Text = "Serial Number";
            Lbl_SerialNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Txb_FilterVariable
            // 
            Txb_FilterVariable.Anchor = AnchorStyles.None;
            Txb_FilterVariable.Location = new Point(140, 163);
            Txb_FilterVariable.Name = "Txb_FilterVariable";
            Txb_FilterVariable.Size = new Size(128, 23);
            Txb_FilterVariable.TabIndex = 10;
            Txb_FilterVariable.TextChanged += Txb_FilterVariable_TextChanged;
            // 
            // Ccb_SerialNumber
            // 
            Ccb_SerialNumber.Anchor = AnchorStyles.None;
            Ccb_SerialNumber.FormattingEnabled = true;
            Ccb_SerialNumber.Location = new Point(140, 63);
            Ccb_SerialNumber.Name = "Ccb_SerialNumber";
            Ccb_SerialNumber.Size = new Size(128, 23);
            Ccb_SerialNumber.TabIndex = 5;
            Ccb_SerialNumber.SelectedIndexChanged += Ccb_SerialNumber_SelectedIndexChanged;
            Ccb_SerialNumber.Click += Ccb_SerialNumber_Click;
            // 
            // Lbl_SearchForVariable
            // 
            Lbl_SearchForVariable.AutoSize = true;
            Lbl_SearchForVariable.Dock = DockStyle.Fill;
            Lbl_SearchForVariable.Font = new Font("Microsoft New Tai Lue", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_SearchForVariable.ForeColor = Color.Transparent;
            Lbl_SearchForVariable.Location = new Point(3, 150);
            Lbl_SearchForVariable.Name = "Lbl_SearchForVariable";
            Lbl_SearchForVariable.Size = new Size(130, 50);
            Lbl_SearchForVariable.TabIndex = 11;
            Lbl_SearchForVariable.Text = "Search Variable";
            Lbl_SearchForVariable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Ccb_Slot
            // 
            Ccb_Slot.Anchor = AnchorStyles.None;
            Ccb_Slot.FormattingEnabled = true;
            Ccb_Slot.Location = new Point(140, 113);
            Ccb_Slot.Name = "Ccb_Slot";
            Ccb_Slot.Size = new Size(128, 23);
            Ccb_Slot.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(3, 100);
            label2.Name = "label2";
            label2.Size = new Size(130, 50);
            label2.TabIndex = 14;
            label2.Text = "Slot";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Btn_Query
            // 
            Btn_Query.Dock = DockStyle.Fill;
            Btn_Query.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Query.Location = new Point(3, 537);
            Btn_Query.Name = "Btn_Query";
            Btn_Query.Size = new Size(130, 44);
            Btn_Query.TabIndex = 16;
            Btn_Query.Text = "Query";
            Btn_Query.UseVisualStyleBackColor = true;
            Btn_Query.Click += Btn_Query_Click;
            // 
            // Btn_ClearVariables
            // 
            Btn_ClearVariables.Dock = DockStyle.Fill;
            Btn_ClearVariables.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_ClearVariables.Location = new Point(139, 537);
            Btn_ClearVariables.Name = "Btn_ClearVariables";
            Btn_ClearVariables.Size = new Size(131, 44);
            Btn_ClearVariables.TabIndex = 9;
            Btn_ClearVariables.Text = "Clear";
            Btn_ClearVariables.UseVisualStyleBackColor = true;
            // 
            // Lbl_Title
            // 
            Lbl_Title.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(Lbl_Title, 2);
            Lbl_Title.Dock = DockStyle.Fill;
            Lbl_Title.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Title.ForeColor = Color.Transparent;
            Lbl_Title.Location = new Point(3, 0);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new Size(547, 50);
            Lbl_Title.TabIndex = 1;
            Lbl_Title.Text = "Available Devices";
            Lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pnl_ContainerVariables
            // 
            Pnl_ContainerVariables.BackColor = Color.FromArgb(8, 32, 50);
            Pnl_ContainerVariables.Controls.Add(tableLayoutPanel3);
            Pnl_ContainerVariables.Dock = DockStyle.Fill;
            Pnl_ContainerVariables.Location = new Point(624, 23);
            Pnl_ContainerVariables.Name = "Pnl_ContainerVariables";
            Pnl_ContainerVariables.Size = new Size(553, 584);
            Pnl_ContainerVariables.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(Lbl_Title, 0, 0);
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 3);
            tableLayoutPanel3.Controls.Add(Trv_Devices, 0, 1);
            tableLayoutPanel3.Controls.Add(Btn_ClearAllDevices, 0, 2);
            tableLayoutPanel3.Controls.Add(Btn_ExpandAllDevices, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(553, 584);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel3.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(547, 244);
            dataGridView1.TabIndex = 3;
            // 
            // Trv_Devices
            // 
            Trv_Devices.BackColor = Color.FromArgb(8, 32, 50);
            Trv_Devices.BorderStyle = BorderStyle.None;
            tableLayoutPanel3.SetColumnSpan(Trv_Devices, 2);
            Trv_Devices.Dock = DockStyle.Fill;
            Trv_Devices.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Trv_Devices.ForeColor = Color.Transparent;
            Trv_Devices.Location = new Point(3, 53);
            Trv_Devices.Name = "Trv_Devices";
            Trv_Devices.Size = new Size(547, 243);
            Trv_Devices.TabIndex = 3;
            Trv_Devices.DoubleClick += Trv_Devices_DoubleClick;
            // 
            // Btn_ClearAllDevices
            // 
            Btn_ClearAllDevices.Dock = DockStyle.Fill;
            Btn_ClearAllDevices.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_ClearAllDevices.Location = new Point(3, 302);
            Btn_ClearAllDevices.Name = "Btn_ClearAllDevices";
            Btn_ClearAllDevices.Size = new Size(270, 29);
            Btn_ClearAllDevices.TabIndex = 10;
            Btn_ClearAllDevices.Text = "Colapse All";
            Btn_ClearAllDevices.UseVisualStyleBackColor = true;
            Btn_ClearAllDevices.Click += Btn_ClearAllDevices_Click;
            // 
            // Btn_ExpandAllDevices
            // 
            Btn_ExpandAllDevices.Dock = DockStyle.Fill;
            Btn_ExpandAllDevices.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_ExpandAllDevices.Location = new Point(279, 302);
            Btn_ExpandAllDevices.Name = "Btn_ExpandAllDevices";
            Btn_ExpandAllDevices.Size = new Size(271, 29);
            Btn_ExpandAllDevices.TabIndex = 11;
            Btn_ExpandAllDevices.Text = "Expand All";
            Btn_ExpandAllDevices.UseVisualStyleBackColor = true;
            Btn_ExpandAllDevices.Click += Btn_ExpandAllDevices_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 32, 50);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(23, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 584);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.7341F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.2659F));
            tableLayoutPanel4.Controls.Add(Lbl_Update, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel4.Controls.Add(treeView1, 0, 3);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel9, 1, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel10, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel11, 1, 2);
            tableLayoutPanel4.Controls.Add(Btn_ClearUpdate, 1, 6);
            tableLayoutPanel4.Controls.Add(Btn_Update, 0, 6);
            tableLayoutPanel4.Controls.Add(treeView2, 0, 5);
            tableLayoutPanel4.Controls.Add(button3, 0, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(273, 584);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // Lbl_Update
            // 
            Lbl_Update.AutoSize = true;
            tableLayoutPanel4.SetColumnSpan(Lbl_Update, 2);
            Lbl_Update.Dock = DockStyle.Fill;
            Lbl_Update.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Update.ForeColor = Color.Transparent;
            Lbl_Update.Location = new Point(3, 0);
            Lbl_Update.Name = "Lbl_Update";
            Lbl_Update.Size = new Size(267, 45);
            Lbl_Update.TabIndex = 5;
            Lbl_Update.Text = "Update";
            Lbl_Update.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(Ccb_SerialNumberUpdate, 0, 1);
            tableLayoutPanel8.Controls.Add(label7, 0, 0);
            tableLayoutPanel8.Location = new Point(3, 48);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 28.3783779F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 71.62162F));
            tableLayoutPanel8.Size = new Size(129, 67);
            tableLayoutPanel8.TabIndex = 28;
            // 
            // Ccb_SerialNumberUpdate
            // 
            Ccb_SerialNumberUpdate.Anchor = AnchorStyles.None;
            Ccb_SerialNumberUpdate.FormattingEnabled = true;
            Ccb_SerialNumberUpdate.Location = new Point(3, 31);
            Ccb_SerialNumberUpdate.Name = "Ccb_SerialNumberUpdate";
            Ccb_SerialNumberUpdate.Size = new Size(123, 23);
            Ccb_SerialNumberUpdate.TabIndex = 5;
            Ccb_SerialNumberUpdate.Click += Ccb_SerialNumberUpdate_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(4, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(120, 19);
            label7.TabIndex = 22;
            label7.Text = "Serial Number";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(8, 32, 50);
            treeView1.BorderStyle = BorderStyle.None;
            tableLayoutPanel4.SetColumnSpan(treeView1, 2);
            treeView1.Dock = DockStyle.Fill;
            treeView1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            treeView1.ForeColor = Color.Transparent;
            treeView1.Location = new Point(3, 192);
            treeView1.Name = "treeView1";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Node1";
            treeNode6.Name = "Tvn_Node1";
            treeNode6.Text = "SerialNumber";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode6 });
            treeView1.Size = new Size(267, 120);
            treeView1.TabIndex = 20;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(Ccb_SlotUpdate, 0, 1);
            tableLayoutPanel9.Controls.Add(label1, 0, 0);
            tableLayoutPanel9.Location = new Point(141, 48);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 31.08108F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 68.91892F));
            tableLayoutPanel9.Size = new Size(127, 67);
            tableLayoutPanel9.TabIndex = 29;
            // 
            // Ccb_SlotUpdate
            // 
            Ccb_SlotUpdate.Anchor = AnchorStyles.None;
            Ccb_SlotUpdate.FormattingEnabled = true;
            Ccb_SlotUpdate.Location = new Point(3, 32);
            Ccb_SlotUpdate.Name = "Ccb_SlotUpdate";
            Ccb_SlotUpdate.Size = new Size(121, 23);
            Ccb_SlotUpdate.TabIndex = 7;
            Ccb_SlotUpdate.Click += Ccb_Slot_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(40, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 6;
            label1.Text = "Slot";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(Lbl_MsgValueType, 0, 0);
            tableLayoutPanel10.Controls.Add(Ccb_Type, 0, 1);
            tableLayoutPanel10.Location = new Point(3, 121);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 33.783783F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 66.21622F));
            tableLayoutPanel10.Size = new Size(129, 65);
            tableLayoutPanel10.TabIndex = 30;
            // 
            // Lbl_MsgValueType
            // 
            Lbl_MsgValueType.Anchor = AnchorStyles.None;
            Lbl_MsgValueType.AutoSize = true;
            Lbl_MsgValueType.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_MsgValueType.ForeColor = Color.Transparent;
            Lbl_MsgValueType.Location = new Point(37, 0);
            Lbl_MsgValueType.Name = "Lbl_MsgValueType";
            Lbl_MsgValueType.Size = new Size(55, 21);
            Lbl_MsgValueType.TabIndex = 11;
            Lbl_MsgValueType.Text = "Type";
            Lbl_MsgValueType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Ccb_Type
            // 
            Ccb_Type.Anchor = AnchorStyles.None;
            Ccb_Type.FormattingEnabled = true;
            Ccb_Type.Items.AddRange(new object[] { "Byte", "Short", "IP", "Serial Number" });
            Ccb_Type.Location = new Point(3, 31);
            Ccb_Type.Name = "Ccb_Type";
            Ccb_Type.Size = new Size(123, 23);
            Ccb_Type.TabIndex = 12;
            Ccb_Type.SelectedIndexChanged += Ccb_Type_SelectedIndexChanged;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(label3, 0, 0);
            tableLayoutPanel11.Controls.Add(Msk_Type, 0, 1);
            tableLayoutPanel11.Location = new Point(141, 121);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 32.3076935F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 67.69231F));
            tableLayoutPanel11.Size = new Size(127, 65);
            tableLayoutPanel11.TabIndex = 31;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(37, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 21;
            label3.Text = "Data";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Msk_Type
            // 
            Msk_Type.Anchor = AnchorStyles.None;
            Msk_Type.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Msk_Type.Location = new Point(3, 30);
            Msk_Type.Name = "Msk_Type";
            Msk_Type.Size = new Size(121, 25);
            Msk_Type.TabIndex = 13;
            Msk_Type.TextChanged += Msk_Type_TextChanged;
            // 
            // Btn_ClearUpdate
            // 
            Btn_ClearUpdate.Anchor = AnchorStyles.Top;
            Btn_ClearUpdate.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_ClearUpdate.Location = new Point(142, 537);
            Btn_ClearUpdate.Name = "Btn_ClearUpdate";
            Btn_ClearUpdate.Size = new Size(127, 44);
            Btn_ClearUpdate.TabIndex = 18;
            Btn_ClearUpdate.Text = "Clear";
            Btn_ClearUpdate.UseVisualStyleBackColor = true;
            Btn_ClearUpdate.Click += Btn_ClearUpdate_Click;
            // 
            // Btn_Update
            // 
            Btn_Update.Anchor = AnchorStyles.Top;
            Btn_Update.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Update.Location = new Point(4, 537);
            Btn_Update.Name = "Btn_Update";
            Btn_Update.Size = new Size(129, 44);
            Btn_Update.TabIndex = 25;
            Btn_Update.Text = "Update";
            Btn_Update.UseVisualStyleBackColor = true;
            Btn_Update.Click += Btn_Update_Click;
            // 
            // treeView2
            // 
            treeView2.BackColor = Color.FromArgb(8, 32, 50);
            treeView2.CheckBoxes = true;
            tableLayoutPanel4.SetColumnSpan(treeView2, 2);
            treeView2.Dock = DockStyle.Fill;
            treeView2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            treeView2.ForeColor = Color.Transparent;
            treeView2.Location = new Point(3, 348);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(267, 183);
            treeView2.TabIndex = 32;
            // 
            // button3
            // 
            tableLayoutPanel4.SetColumnSpan(button3, 2);
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(3, 318);
            button3.Name = "button3";
            button3.Size = new Size(267, 24);
            button3.TabIndex = 33;
            button3.Text = "Adicionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Btn3_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.00031F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.00031F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.999382F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(Pnl_ContainerVariables, 5, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(Pnl_ServerBackground, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1202, 630);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(button1, 0, 4);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 83);
            button1.Name = "button1";
            button1.Size = new Size(194, 14);
            button1.TabIndex = 9;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(194, 28);
            label4.TabIndex = 1;
            label4.Text = "Variables";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(button2, 0, 4);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 5;
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(194, 94);
            button2.TabIndex = 9;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 28);
            label5.TabIndex = 1;
            label5.Text = "Variables";
            // 
            // Btn_ClearVariables
            // 
            Btn_ClearVariables.Dock = DockStyle.Fill;
            Btn_ClearVariables.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_ClearVariables.Location = new Point(137, 537);
            Btn_ClearVariables.Name = "Btn_ClearVariables";
            Btn_ClearVariables.Size = new Size(128, 44);
            Btn_ClearVariables.TabIndex = 9;
            Btn_ClearVariables.Text = "Clear";
            Btn_ClearVariables.UseVisualStyleBackColor = true;
            // 
            // Ccb_Slot
            // 
            Ccb_Slot.Anchor = AnchorStyles.None;
            Ccb_Slot.FormattingEnabled = true;
            Ccb_Slot.Location = new Point(137, 113);
            Ccb_Slot.Name = "Ccb_Slot";
            Ccb_Slot.Size = new Size(128, 23);
            Ccb_Slot.TabIndex = 15;
            // 
            // Ccb_SerialNumber
            // 
            Ccb_SerialNumber.Anchor = AnchorStyles.None;
            Ccb_SerialNumber.FormattingEnabled = true;
            Ccb_SerialNumber.Location = new Point(137, 63);
            Ccb_SerialNumber.Name = "Ccb_SerialNumber";
            Ccb_SerialNumber.Size = new Size(128, 23);
            Ccb_SerialNumber.TabIndex = 5;
            Ccb_SerialNumber.SelectedIndexChanged += Ccb_SerialNumber_SelectedIndexChanged;
            Ccb_SerialNumber.Click += Ccb_SerialNumber_Click;
            // 
            // Txb_FilterVariable
            // 
            Txb_FilterVariable.Anchor = AnchorStyles.None;
            Txb_FilterVariable.Location = new Point(137, 163);
            Txb_FilterVariable.Name = "Txb_FilterVariable";
            Txb_FilterVariable.Size = new Size(128, 23);
            Txb_FilterVariable.TabIndex = 10;
            Txb_FilterVariable.TextChanged += Txb_FilterVariable_TextChanged;
            // 
            // Frm_Devices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 106, 118);
            ClientSize = new Size(1202, 630);
            Controls.Add(tableLayoutPanel1);
            Name = "Frm_Devices";
            Text = "Devices";
            Pnl_ServerBackground.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            Pnl_ContainerVariables.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_ServerBackground;
        private TreeView Trv_Variables;
        private Label Lbl_Title;
        private Panel Pnl_ContainerVariables;
        private TreeView Trv_Devices;
        private Label Lbl_VariablesTitle;
        private Panel panel1;
        private Label Lbl_TitleQuery;
        private Label Lbl_MessageType;
        private Label Lbl_SerialNumber;
        private Button Btn_ExpandAllDevices;
        private Button Btn_ClearAllDevices;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label Lbl_SearchForVariable;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button1;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button2;
        private Label label5;
        private Button Btn_Query;
        private TableLayoutPanel tableLayoutPanel4;
        private Label Lbl_Update;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label7;
        private ComboBox Ccb_SerialNumberUpdate;
        private TreeView treeView1;
        private TableLayoutPanel tableLayoutPanel9;
        private ComboBox Ccb_SlotUpdate;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel10;
        private Label Lbl_MsgValueType;
        private ComboBox Ccb_Type;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label3;
        private MaskedTextBox Msk_Type;
        private Button Btn_ClearUpdate;
        private Button Btn_Update;
        private TreeView treeView2;
        private Button button3;
        private TextBox Txb_FilterVariable;
        private ComboBox Ccb_SerialNumber;
        private ComboBox Ccb_Slot;
        private Button Btn_ClearVariables;
    }
}