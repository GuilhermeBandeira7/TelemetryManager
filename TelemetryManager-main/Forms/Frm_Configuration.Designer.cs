using System.Drawing;
using System.Windows.Forms;

namespace NewTelemetryManager.Forms
{
    partial class Frm_Configuration
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            comboBoxCOMPort = new ComboBox();
            buttonConnect = new Button();
            txb_baudrate = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_queryVariables = new Button();
            Btn_ClearVariables = new Button();
            Trv_Variables = new TreeView();
            Txb_FilterVariable = new TextBox();
            Lbl_SearchForVariable = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            treeView1 = new TreeView();
            tableLayoutPanel6 = new TableLayoutPanel();
            Ccb_Type = new ComboBox();
            Lbl_MsgValueType = new Label();
            btn_clear = new Button();
            btn_update = new Button();
            button3 = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            Msk_Type = new MaskedTextBox();
            label3 = new Label();
            treeView2 = new TreeView();
            groupBox5 = new GroupBox();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox6 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            label2 = new Label();
            txb_serialnumber = new TextBox();
            txb_slot = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(90, 106, 118);
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 3, 3);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 3);
            tableLayoutPanel1.Controls.Add(groupBox5, 5, 4);
            tableLayoutPanel1.Controls.Add(groupBox4, 5, 1);
            tableLayoutPanel1.Controls.Add(groupBox6, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.24242F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.75758F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 290F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1202, 630);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.FromArgb(8, 32, 50);
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(23, 23);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 2);
            groupBox1.Size = new Size(368, 127);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "USB Settings";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(comboBoxCOMPort, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonConnect, 2, 0);
            tableLayoutPanel3.Controls.Add(txb_baudrate, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 2, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 28);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(362, 96);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // comboBoxCOMPort
            // 
            comboBoxCOMPort.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCOMPort.FormattingEnabled = true;
            comboBoxCOMPort.Location = new Point(3, 7);
            comboBoxCOMPort.Name = "comboBoxCOMPort";
            comboBoxCOMPort.Size = new Size(165, 33);
            comboBoxCOMPort.TabIndex = 0;
            comboBoxCOMPort.MouseClick += comboBoxCOMPort_MouseClick;
            // 
            // buttonConnect
            // 
            buttonConnect.Anchor = AnchorStyles.None;
            buttonConnect.AutoSize = true;
            buttonConnect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonConnect.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConnect.ForeColor = SystemColors.ControlText;
            buttonConnect.Location = new Point(240, 9);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(73, 30);
            buttonConnect.TabIndex = 2;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // txb_baudrate
            // 
            txb_baudrate.Anchor = AnchorStyles.None;
            txb_baudrate.Location = new Point(3, 56);
            txb_baudrate.Name = "txb_baudrate";
            txb_baudrate.ReadOnly = true;
            txb_baudrate.Size = new Size(165, 32);
            txb_baudrate.TabIndex = 3;
            txb_baudrate.Text = "38400";
            txb_baudrate.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(225, 59);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 4;
            label1.Text = "Baud Rate";
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.BackColor = Color.FromArgb(8, 32, 50);
            groupBox3.Controls.Add(tableLayoutPanel2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.HighlightText;
            groupBox3.Location = new Point(417, 156);
            groupBox3.Name = "groupBox3";
            tableLayoutPanel1.SetRowSpan(groupBox3, 2);
            groupBox3.Size = new Size(368, 450);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Query";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btn_queryVariables, 1, 2);
            tableLayoutPanel2.Controls.Add(Btn_ClearVariables, 0, 2);
            tableLayoutPanel2.Controls.Add(Trv_Variables, 0, 1);
            tableLayoutPanel2.Controls.Add(Txb_FilterVariable, 1, 0);
            tableLayoutPanel2.Controls.Add(Lbl_SearchForVariable, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.Size = new Size(362, 419);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // btn_queryVariables
            // 
            btn_queryVariables.Dock = DockStyle.Fill;
            btn_queryVariables.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_queryVariables.ForeColor = SystemColors.ControlText;
            btn_queryVariables.Location = new Point(184, 372);
            btn_queryVariables.Name = "btn_queryVariables";
            btn_queryVariables.Size = new Size(175, 44);
            btn_queryVariables.TabIndex = 12;
            btn_queryVariables.Text = "Query";
            btn_queryVariables.UseVisualStyleBackColor = true;
            btn_queryVariables.Click += Btn_Query_Click;
            // 
            // Btn_ClearVariables
            // 
            Btn_ClearVariables.Dock = DockStyle.Fill;
            Btn_ClearVariables.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_ClearVariables.ForeColor = SystemColors.ControlText;
            Btn_ClearVariables.Location = new Point(3, 372);
            Btn_ClearVariables.Name = "Btn_ClearVariables";
            Btn_ClearVariables.Size = new Size(175, 44);
            Btn_ClearVariables.TabIndex = 9;
            Btn_ClearVariables.Text = "Clear";
            Btn_ClearVariables.UseVisualStyleBackColor = true;
            Btn_ClearVariables.Click += Btn_ClearVariables_Click;
            // 
            // Trv_Variables
            // 
            Trv_Variables.BackColor = Color.FromArgb(8, 32, 50);
            Trv_Variables.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(Trv_Variables, 2);
            Trv_Variables.Dock = DockStyle.Fill;
            Trv_Variables.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Trv_Variables.ForeColor = Color.Transparent;
            Trv_Variables.Location = new Point(3, 43);
            Trv_Variables.Name = "Trv_Variables";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Tvn_Node1";
            treeNode3.Text = "SerialNumber";
            Trv_Variables.Nodes.AddRange(new TreeNode[] { treeNode3 });
            Trv_Variables.Size = new Size(356, 323);
            Trv_Variables.TabIndex = 2;
            // 
            // Txb_FilterVariable
            // 
            Txb_FilterVariable.Dock = DockStyle.Fill;
            Txb_FilterVariable.Location = new Point(184, 3);
            Txb_FilterVariable.Name = "Txb_FilterVariable";
            Txb_FilterVariable.Size = new Size(175, 32);
            Txb_FilterVariable.TabIndex = 10;
            Txb_FilterVariable.TextChanged += Txb_FilterVariable_TextChanged;
            // 
            // Lbl_SearchForVariable
            // 
            Lbl_SearchForVariable.AutoSize = true;
            Lbl_SearchForVariable.Dock = DockStyle.Fill;
            Lbl_SearchForVariable.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_SearchForVariable.ForeColor = Color.Transparent;
            Lbl_SearchForVariable.Location = new Point(3, 0);
            Lbl_SearchForVariable.Name = "Lbl_SearchForVariable";
            Lbl_SearchForVariable.Size = new Size(175, 40);
            Lbl_SearchForVariable.TabIndex = 11;
            Lbl_SearchForVariable.Text = "Search Variable";
            Lbl_SearchForVariable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.BackColor = Color.FromArgb(8, 32, 50);
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.HighlightText;
            groupBox2.Location = new Point(23, 156);
            groupBox2.Name = "groupBox2";
            tableLayoutPanel1.SetRowSpan(groupBox2, 2);
            groupBox2.Size = new Size(368, 450);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(treeView1, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Controls.Add(btn_clear, 1, 4);
            tableLayoutPanel4.Controls.Add(btn_update, 0, 4);
            tableLayoutPanel4.Controls.Add(button3, 1, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel4.Controls.Add(treeView2, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 28);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.Size = new Size(362, 419);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(8, 32, 50);
            treeView1.BorderStyle = BorderStyle.None;
            tableLayoutPanel4.SetColumnSpan(treeView1, 2);
            treeView1.Dock = DockStyle.Fill;
            treeView1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            treeView1.ForeColor = Color.Transparent;
            treeView1.Location = new Point(3, 48);
            treeView1.Name = "treeView1";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Node1";
            treeNode6.Name = "Tvn_Node1";
            treeNode6.Text = "SerialNumber";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode6 });
            treeView1.Size = new Size(356, 143);
            treeView1.TabIndex = 18;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.61202F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.38798F));
            tableLayoutPanel6.Controls.Add(Ccb_Type, 1, 0);
            tableLayoutPanel6.Controls.Add(Lbl_MsgValueType, 0, 0);
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(175, 39);
            tableLayoutPanel6.TabIndex = 17;
            // 
            // Ccb_Type
            // 
            Ccb_Type.Anchor = AnchorStyles.None;
            Ccb_Type.FormattingEnabled = true;
            Ccb_Type.Items.AddRange(new object[] { "Byte", "Short", "IP", "Serial Number" });
            Ccb_Type.Location = new Point(67, 3);
            Ccb_Type.Name = "Ccb_Type";
            Ccb_Type.Size = new Size(105, 33);
            Ccb_Type.TabIndex = 12;
            Ccb_Type.SelectedIndexChanged += Ccb_Type_SelectedIndexChanged;
            // 
            // Lbl_MsgValueType
            // 
            Lbl_MsgValueType.AutoSize = true;
            Lbl_MsgValueType.Dock = DockStyle.Fill;
            Lbl_MsgValueType.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_MsgValueType.ForeColor = Color.Transparent;
            Lbl_MsgValueType.Location = new Point(3, 0);
            Lbl_MsgValueType.Name = "Lbl_MsgValueType";
            Lbl_MsgValueType.Size = new Size(58, 39);
            Lbl_MsgValueType.TabIndex = 11;
            Lbl_MsgValueType.Text = "Type";
            Lbl_MsgValueType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clear.ForeColor = SystemColors.ControlText;
            btn_clear.Location = new Point(184, 376);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(175, 39);
            btn_clear.TabIndex = 19;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += Btn_Clear_Update;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update.ForeColor = SystemColors.ControlText;
            btn_update.Location = new Point(3, 376);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(175, 39);
            btn_update.TabIndex = 20;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += Btn_Update_Click;
            // 
            // button3
            // 
            tableLayoutPanel4.SetColumnSpan(button3, 2);
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(3, 197);
            button3.Name = "button3";
            button3.Size = new Size(356, 24);
            button3.TabIndex = 23;
            button3.Text = "Atualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Btn3_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.85714F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.14286F));
            tableLayoutPanel7.Controls.Add(Msk_Type, 1, 0);
            tableLayoutPanel7.Controls.Add(label3, 0, 0);
            tableLayoutPanel7.Location = new Point(184, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(175, 39);
            tableLayoutPanel7.TabIndex = 24;
            // 
            // Msk_Type
            // 
            Msk_Type.Anchor = AnchorStyles.None;
            Msk_Type.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Msk_Type.Location = new Point(63, 7);
            Msk_Type.Name = "Msk_Type";
            Msk_Type.Size = new Size(108, 25);
            Msk_Type.TabIndex = 13;
            Msk_Type.TextChanged += Msk_Type_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(3, 7);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 16;
            label3.Text = "Data";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // treeView2
            // 
            treeView2.BackColor = Color.FromArgb(8, 32, 50);
            treeView2.CheckBoxes = true;
            tableLayoutPanel4.SetColumnSpan(treeView2, 2);
            treeView2.Dock = DockStyle.Fill;
            treeView2.ForeColor = SystemColors.Info;
            treeView2.Location = new Point(3, 227);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(356, 143);
            treeView2.TabIndex = 25;
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox5.BackColor = Color.FromArgb(8, 32, 50);
            groupBox5.Controls.Add(textBox1);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.ForeColor = SystemColors.HighlightText;
            groupBox5.Location = new Point(811, 322);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(368, 284);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Communication";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(8, 32, 50);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Green;
            textBox1.Location = new Point(3, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(362, 253);
            textBox1.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox4.BackColor = Color.FromArgb(8, 32, 50);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.HighlightText;
            groupBox4.Location = new Point(811, 23);
            groupBox4.Name = "groupBox4";
            tableLayoutPanel1.SetRowSpan(groupBox4, 3);
            groupBox4.Size = new Size(368, 293);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Data";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(8, 32, 50);
            textBox2.ForeColor = SystemColors.MenuBar;
            textBox2.Location = new Point(5, 31);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(359, 258);
            textBox2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(8, 32, 50);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(8, 32, 50);
            dataGridView1.Location = new Point(3, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(362, 262);
            dataGridView1.TabIndex = 3;
            // 
            // groupBox6
            // 
            groupBox6.AutoSize = true;
            groupBox6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox6.BackColor = Color.FromArgb(8, 32, 50);
            groupBox6.Controls.Add(tableLayoutPanel5);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.ForeColor = SystemColors.HighlightText;
            groupBox6.Location = new Point(417, 23);
            groupBox6.Name = "groupBox6";
            tableLayoutPanel1.SetRowSpan(groupBox6, 2);
            groupBox6.Size = new Size(368, 127);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "Device";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label4, 1, 1);
            tableLayoutPanel5.Controls.Add(label2, 1, 0);
            tableLayoutPanel5.Controls.Add(txb_serialnumber, 0, 0);
            tableLayoutPanel5.Controls.Add(txb_slot, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 28);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(362, 96);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(248, 59);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 6;
            label4.Text = "Slot";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(201, 11);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 5;
            label2.Text = "Serial Number";
            // 
            // txb_serialnumber
            // 
            txb_serialnumber.Anchor = AnchorStyles.None;
            txb_serialnumber.Location = new Point(3, 8);
            txb_serialnumber.Name = "txb_serialnumber";
            txb_serialnumber.Size = new Size(175, 32);
            txb_serialnumber.TabIndex = 7;
            // 
            // txb_slot
            // 
            txb_slot.Anchor = AnchorStyles.None;
            txb_slot.Location = new Point(3, 56);
            txb_slot.Name = "txb_slot";
            txb_slot.Size = new Size(175, 32);
            txb_slot.TabIndex = 1;
            // 
            // Frm_Configuration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 32, 50);
            ClientSize = new Size(1202, 630);
            Controls.Add(tableLayoutPanel1);
            Name = "Frm_Configuration";
            Text = "Configuration";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox6.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox Ccb_Type;
        private Label Lbl_MsgValueType;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox comboBoxCOMPort;
        private Button buttonConnect;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_queryVariables;
        private Button Btn_ClearVariables;
        private TreeView Trv_Variables;
        private TextBox Txb_FilterVariable;
        private Label Lbl_SearchForVariable;
        private GroupBox groupBox5;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private TextBox txb_baudrate;
        private Label label1;
        private GroupBox groupBox6;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private Label label2;
        private TextBox txb_serialnumber;
        private TextBox txb_slot;
        private Label label3;
        private MaskedTextBox Msk_Type;
        private TableLayoutPanel tableLayoutPanel6;
        private TreeView treeView1;
        private Button btn_clear;
        private Button btn_update;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox textBox7;
        private TreeView treeView2;
        private TextBox textBox2;
    }
}