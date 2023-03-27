using System.Windows.Forms;

namespace TelemetryManager.Forms
{
    partial class Frm_Teste
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
            tc_teste = new TabControl();
            tp_mqtt = new TabPage();
            button6 = new Button();
            tlp_contaier3 = new TableLayoutPanel();
            button1 = new Button();
            textBox12 = new TextBox();
            label12 = new Label();
            lbl_mediCorrente = new Label();
            label14 = new Label();
            label13 = new Label();
            label15 = new Label();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            lbl_medidor = new Label();
            button8 = new Button();
            textBox1 = new TextBox();
            textBox21 = new TextBox();
            tlp_container2 = new TableLayoutPanel();
            gb_ip = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            gb_rst = new GroupBox();
            button5 = new Button();
            Tlp_Container = new TableLayoutPanel();
            lbl_Slot = new Label();
            lbl_dc2Calibrar = new TextBox();
            lbl_SerialNumber = new Label();
            lbl_di01 = new Label();
            txb_di01 = new TextBox();
            btn_di01 = new Button();
            lbl_d01 = new Label();
            txb_do01 = new TextBox();
            btn_do01 = new Button();
            lbl_dc2 = new Label();
            txb_dc2 = new TextBox();
            btn_dc2 = new Button();
            txb_dc1 = new TextBox();
            btn_dc1 = new Button();
            lbl_dc1 = new Label();
            cb_serialnumber = new ComboBox();
            txb_dc1Calibrar = new TextBox();
            lbl_do01Calibrar = new TextBox();
            Ccb_Slot = new ComboBox();
            tp_serialNumber = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            textBox3 = new TextBox();
            tlp_containerSN = new TableLayoutPanel();
            btn_Query = new Button();
            tb_calibDi01SN = new TextBox();
            tb_calibDo01SN = new TextBox();
            tb_calibDc2SN = new TextBox();
            tb_calibDc1 = new TextBox();
            lbl_dc2SN = new Label();
            lbl_dc1SN = new Label();
            lbl_do01SN = new Label();
            lbl_di01SN = new Label();
            txb_dc1SN = new TextBox();
            txb_dc2SN = new TextBox();
            txb_do01SN = new TextBox();
            btn_dc1Cal = new Button();
            btn_dc2SN = new Button();
            btn_do01SN = new Button();
            btn_di01SN = new Button();
            txb_di01SN = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            tlp_container3SN = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            label2 = new Label();
            textBox2 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            txb_baudrate = new TextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBoxCOMPort = new ComboBox();
            buttonConnect = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            lbl_medCorrenteSN = new Label();
            lbl_medCorrentSN = new Label();
            textBox20 = new TextBox();
            txb_medCorrenteSN = new TextBox();
            button7 = new Button();
            tlp_containerSN2 = new TableLayoutPanel();
            btn_reset = new Button();
            tableLayoutPanel12 = new TableLayoutPanel();
            label4 = new Label();
            textBox7 = new TextBox();
            tableLayoutPanel13 = new TableLayoutPanel();
            label5 = new Label();
            textBox6 = new TextBox();
            tableLayoutPanel14 = new TableLayoutPanel();
            label6 = new Label();
            textBox5 = new TextBox();
            tableLayoutPanel15 = new TableLayoutPanel();
            textBox4 = new TextBox();
            label7 = new Label();
            tc_teste.SuspendLayout();
            tp_mqtt.SuspendLayout();
            tlp_contaier3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tlp_container2.SuspendLayout();
            gb_ip.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            gb_rst.SuspendLayout();
            Tlp_Container.SuspendLayout();
            tp_serialNumber.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tlp_containerSN.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tlp_container3SN.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tlp_containerSN2.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            SuspendLayout();
            // 
            // tc_teste
            // 
            tc_teste.Controls.Add(tp_mqtt);
            tc_teste.Controls.Add(tp_serialNumber);
            tc_teste.Location = new Point(0, 0);
            tc_teste.Name = "tc_teste";
            tc_teste.SelectedIndex = 0;
            tc_teste.Size = new Size(1202, 630);
            tc_teste.TabIndex = 0;
            // 
            // tp_mqtt
            // 
            tp_mqtt.BackColor = Color.FromArgb(90, 106, 118);
            tp_mqtt.Controls.Add(button6);
            tp_mqtt.Controls.Add(tlp_contaier3);
            tp_mqtt.Controls.Add(tlp_container2);
            tp_mqtt.Controls.Add(Tlp_Container);
            tp_mqtt.Location = new Point(4, 24);
            tp_mqtt.Name = "tp_mqtt";
            tp_mqtt.Padding = new Padding(3);
            tp_mqtt.Size = new Size(1194, 602);
            tp_mqtt.TabIndex = 0;
            tp_mqtt.Text = "MQTT";
            // 
            // button6
            // 
            button6.Location = new Point(524, 402);
            button6.Name = "button6";
            button6.Size = new Size(149, 40);
            button6.TabIndex = 3;
            button6.Text = "Query";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Query_Click;
            // 
            // tlp_contaier3
            // 
            tlp_contaier3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tlp_contaier3.BackColor = Color.FromArgb(8, 32, 50);
            tlp_contaier3.ColumnCount = 3;
            tlp_contaier3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_contaier3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_contaier3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_contaier3.Controls.Add(button1, 2, 1);
            tlp_contaier3.Controls.Add(textBox12, 1, 1);
            tlp_contaier3.Controls.Add(label12, 0, 1);
            tlp_contaier3.Controls.Add(lbl_mediCorrente, 0, 0);
            tlp_contaier3.Controls.Add(label14, 0, 3);
            tlp_contaier3.Controls.Add(label13, 0, 2);
            tlp_contaier3.Controls.Add(label15, 0, 4);
            tlp_contaier3.Controls.Add(textBox15, 1, 4);
            tlp_contaier3.Controls.Add(textBox14, 1, 3);
            tlp_contaier3.Controls.Add(textBox13, 1, 2);
            tlp_contaier3.Controls.Add(button4, 2, 4);
            tlp_contaier3.Controls.Add(button3, 2, 3);
            tlp_contaier3.Controls.Add(button2, 2, 2);
            tlp_contaier3.Controls.Add(tableLayoutPanel4, 1, 0);
            tlp_contaier3.Location = new Point(733, 6);
            tlp_contaier3.Name = "tlp_contaier3";
            tlp_contaier3.RowCount = 5;
            tlp_contaier3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_contaier3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_contaier3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_contaier3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_contaier3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_contaier3.Size = new Size(450, 360);
            tlp_contaier3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(335, 96);
            button1.Name = "button1";
            button1.Size = new Size(79, 24);
            button1.TabIndex = 34;
            button1.Text = "Teste";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DO2_Click;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox12.Location = new Point(153, 96);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(144, 23);
            textBox12.TabIndex = 30;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.HighlightText;
            label12.Location = new Point(44, 95);
            label12.Name = "label12";
            label12.Size = new Size(62, 25);
            label12.TabIndex = 26;
            label12.Text = "DO02";
            // 
            // lbl_mediCorrente
            // 
            lbl_mediCorrente.Anchor = AnchorStyles.None;
            lbl_mediCorrente.AutoSize = true;
            lbl_mediCorrente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_mediCorrente.ForeColor = SystemColors.HighlightText;
            lbl_mediCorrente.Location = new Point(24, 11);
            lbl_mediCorrente.Name = "lbl_mediCorrente";
            lbl_mediCorrente.Size = new Size(101, 50);
            lbl_mediCorrente.TabIndex = 23;
            lbl_mediCorrente.Text = "Fonte de Corrente :";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.HighlightText;
            label14.Location = new Point(44, 239);
            label14.Name = "label14";
            label14.Size = new Size(62, 25);
            label14.TabIndex = 28;
            label14.Text = "DO03";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.HighlightText;
            label13.Location = new Point(48, 167);
            label13.Name = "label13";
            label13.Size = new Size(54, 25);
            label13.TabIndex = 27;
            label13.Text = "DI02";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.HighlightText;
            label15.Location = new Point(48, 311);
            label15.Name = "label15";
            label15.Size = new Size(54, 25);
            label15.TabIndex = 29;
            label15.Text = "DI03";
            // 
            // textBox15
            // 
            textBox15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox15.Location = new Point(153, 312);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(144, 23);
            textBox15.TabIndex = 33;
            // 
            // textBox14
            // 
            textBox14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox14.Location = new Point(153, 240);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(144, 23);
            textBox14.TabIndex = 32;
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox13.Location = new Point(153, 168);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(144, 23);
            textBox13.TabIndex = 31;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(335, 312);
            button4.Name = "button4";
            button4.Size = new Size(79, 24);
            button4.TabIndex = 37;
            button4.Text = "Teste";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DO3_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(335, 240);
            button3.Name = "button3";
            button3.Size = new Size(79, 24);
            button3.TabIndex = 36;
            button3.Text = "Teste";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DO3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(335, 168);
            button2.Name = "button2";
            button2.Size = new Size(79, 24);
            button2.TabIndex = 35;
            button2.Text = "Teste";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DO2_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tlp_contaier3.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lbl_medidor, 1, 0);
            tableLayoutPanel4.Controls.Add(button8, 1, 1);
            tableLayoutPanel4.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel4.Controls.Add(textBox21, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(153, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(294, 66);
            tableLayoutPanel4.TabIndex = 25;
            // 
            // lbl_medidor
            // 
            lbl_medidor.Anchor = AnchorStyles.None;
            lbl_medidor.AutoSize = true;
            lbl_medidor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_medidor.ForeColor = SystemColors.HighlightText;
            lbl_medidor.Location = new Point(173, 8);
            lbl_medidor.Name = "lbl_medidor";
            lbl_medidor.Size = new Size(94, 17);
            lbl_medidor.TabIndex = 15;
            lbl_medidor.Text = "(4mA - 20mA)";
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(150, 36);
            button8.Name = "button8";
            button8.Size = new Size(141, 27);
            button8.TabIndex = 16;
            button8.Text = "Ligar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox21
            // 
            textBox21.Dock = DockStyle.Fill;
            textBox21.Location = new Point(3, 36);
            textBox21.Name = "textBox21";
            textBox21.ReadOnly = true;
            textBox21.Size = new Size(141, 23);
            textBox21.TabIndex = 17;
            // 
            // tlp_container2
            // 
            tlp_container2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_container2.BackColor = Color.FromArgb(8, 32, 50);
            tlp_container2.ColumnCount = 1;
            tlp_container2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_container2.Controls.Add(gb_ip, 0, 0);
            tlp_container2.Controls.Add(gb_rst, 0, 1);
            tlp_container2.Location = new Point(8, 448);
            tlp_container2.Name = "tlp_container2";
            tlp_container2.RowCount = 2;
            tlp_container2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_container2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_container2.Size = new Size(1178, 146);
            tlp_container2.TabIndex = 1;
            // 
            // gb_ip
            // 
            gb_ip.Controls.Add(tableLayoutPanel6);
            gb_ip.Dock = DockStyle.Fill;
            gb_ip.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gb_ip.ForeColor = SystemColors.ButtonHighlight;
            gb_ip.Location = new Point(3, 3);
            gb_ip.Name = "gb_ip";
            gb_ip.Size = new Size(1172, 67);
            gb_ip.TabIndex = 11;
            gb_ip.TabStop = false;
            gb_ip.Text = "IP";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Controls.Add(textBox8, 3, 1);
            tableLayoutPanel6.Controls.Add(textBox9, 2, 1);
            tableLayoutPanel6.Controls.Add(textBox10, 1, 1);
            tableLayoutPanel6.Controls.Add(textBox11, 0, 1);
            tableLayoutPanel6.Controls.Add(label8, 0, 0);
            tableLayoutPanel6.Controls.Add(label9, 1, 0);
            tableLayoutPanel6.Controls.Add(label10, 2, 0);
            tableLayoutPanel6.Controls.Add(label11, 3, 0);
            tableLayoutPanel6.Location = new Point(25, 9);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(1126, 55);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // textBox8
            // 
            textBox8.Dock = DockStyle.Fill;
            textBox8.Location = new Point(853, 30);
            textBox8.Margin = new Padding(10, 3, 3, 3);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(270, 25);
            textBox8.TabIndex = 0;
            // 
            // textBox9
            // 
            textBox9.Dock = DockStyle.Fill;
            textBox9.Location = new Point(572, 30);
            textBox9.Margin = new Padding(10, 3, 10, 3);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(261, 25);
            textBox9.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.Dock = DockStyle.Fill;
            textBox10.Location = new Point(291, 30);
            textBox10.Margin = new Padding(10, 3, 10, 3);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(261, 25);
            textBox10.TabIndex = 2;
            // 
            // textBox11
            // 
            textBox11.Dock = DockStyle.Fill;
            textBox11.Location = new Point(3, 30);
            textBox11.Margin = new Padding(3, 3, 10, 3);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(268, 25);
            textBox11.TabIndex = 3;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(100, 3);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 4;
            label8.Text = "IP Device";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(374, 3);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 5;
            label9.Text = "IP Gateway";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(668, 3);
            label10.Name = "label10";
            label10.Size = new Size(69, 21);
            label10.TabIndex = 6;
            label10.Text = "IP Mask";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(945, 3);
            label11.Name = "label11";
            label11.Size = new Size(78, 21);
            label11.TabIndex = 7;
            label11.Text = "IP Server";
            // 
            // gb_rst
            // 
            gb_rst.Controls.Add(button5);
            gb_rst.Dock = DockStyle.Fill;
            gb_rst.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gb_rst.ForeColor = SystemColors.ButtonHighlight;
            gb_rst.Location = new Point(3, 76);
            gb_rst.Name = "gb_rst";
            gb_rst.Size = new Size(1172, 67);
            gb_rst.TabIndex = 12;
            gb_rst.TabStop = false;
            gb_rst.Text = "RST";
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(25, 20);
            button5.Name = "button5";
            button5.Size = new Size(1123, 37);
            button5.TabIndex = 1;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Reset_Click;
            // 
            // Tlp_Container
            // 
            Tlp_Container.BackColor = Color.FromArgb(8, 32, 50);
            Tlp_Container.ColumnCount = 4;
            Tlp_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            Tlp_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            Tlp_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            Tlp_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tlp_Container.Controls.Add(lbl_Slot, 2, 0);
            Tlp_Container.Controls.Add(lbl_dc2Calibrar, 3, 2);
            Tlp_Container.Controls.Add(lbl_SerialNumber, 0, 0);
            Tlp_Container.Controls.Add(lbl_di01, 0, 4);
            Tlp_Container.Controls.Add(txb_di01, 1, 4);
            Tlp_Container.Controls.Add(btn_di01, 2, 4);
            Tlp_Container.Controls.Add(lbl_d01, 0, 3);
            Tlp_Container.Controls.Add(txb_do01, 1, 3);
            Tlp_Container.Controls.Add(btn_do01, 2, 3);
            Tlp_Container.Controls.Add(lbl_dc2, 0, 2);
            Tlp_Container.Controls.Add(txb_dc2, 1, 2);
            Tlp_Container.Controls.Add(btn_dc2, 2, 2);
            Tlp_Container.Controls.Add(txb_dc1, 1, 1);
            Tlp_Container.Controls.Add(btn_dc1, 2, 1);
            Tlp_Container.Controls.Add(lbl_dc1, 0, 1);
            Tlp_Container.Controls.Add(cb_serialnumber, 1, 0);
            Tlp_Container.Controls.Add(txb_dc1Calibrar, 3, 1);
            Tlp_Container.Controls.Add(lbl_do01Calibrar, 3, 3);
            Tlp_Container.Controls.Add(Ccb_Slot, 3, 0);
            Tlp_Container.Location = new Point(8, 6);
            Tlp_Container.Name = "Tlp_Container";
            Tlp_Container.RowCount = 5;
            Tlp_Container.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            Tlp_Container.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            Tlp_Container.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            Tlp_Container.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            Tlp_Container.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            Tlp_Container.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Container.Size = new Size(455, 360);
            Tlp_Container.TabIndex = 0;
            // 
            // lbl_Slot
            // 
            lbl_Slot.Anchor = AnchorStyles.None;
            lbl_Slot.AutoSize = true;
            lbl_Slot.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Slot.ForeColor = SystemColors.HighlightText;
            lbl_Slot.Location = new Point(292, 26);
            lbl_Slot.Name = "lbl_Slot";
            lbl_Slot.Size = new Size(35, 19);
            lbl_Slot.TabIndex = 30;
            lbl_Slot.Text = "Slot";
            // 
            // lbl_dc2Calibrar
            // 
            lbl_dc2Calibrar.Anchor = AnchorStyles.None;
            lbl_dc2Calibrar.Location = new Point(372, 168);
            lbl_dc2Calibrar.Name = "lbl_dc2Calibrar";
            lbl_dc2Calibrar.Size = new Size(72, 23);
            lbl_dc2Calibrar.TabIndex = 28;
            // 
            // lbl_SerialNumber
            // 
            lbl_SerialNumber.Anchor = AnchorStyles.None;
            lbl_SerialNumber.AutoSize = true;
            lbl_SerialNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SerialNumber.ForeColor = SystemColors.HighlightText;
            lbl_SerialNumber.Location = new Point(3, 25);
            lbl_SerialNumber.Name = "lbl_SerialNumber";
            lbl_SerialNumber.Size = new Size(120, 21);
            lbl_SerialNumber.TabIndex = 25;
            lbl_SerialNumber.Text = "Serial Number";
            // 
            // lbl_di01
            // 
            lbl_di01.Anchor = AnchorStyles.None;
            lbl_di01.AutoSize = true;
            lbl_di01.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_di01.ForeColor = SystemColors.HighlightText;
            lbl_di01.Location = new Point(36, 311);
            lbl_di01.Name = "lbl_di01";
            lbl_di01.Size = new Size(54, 25);
            lbl_di01.TabIndex = 9;
            lbl_di01.Text = "DI01";
            // 
            // txb_di01
            // 
            txb_di01.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txb_di01.Location = new Point(130, 312);
            txb_di01.Name = "txb_di01";
            txb_di01.Size = new Size(126, 23);
            txb_di01.TabIndex = 16;
            // 
            // btn_di01
            // 
            btn_di01.Anchor = AnchorStyles.None;
            btn_di01.Location = new Point(270, 312);
            btn_di01.Name = "btn_di01";
            btn_di01.Size = new Size(79, 24);
            btn_di01.TabIndex = 21;
            btn_di01.Text = "Teste";
            btn_di01.UseVisualStyleBackColor = true;
            btn_di01.Click += DO1_Click;
            // 
            // lbl_d01
            // 
            lbl_d01.Anchor = AnchorStyles.None;
            lbl_d01.AutoSize = true;
            lbl_d01.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_d01.ForeColor = SystemColors.HighlightText;
            lbl_d01.Location = new Point(32, 239);
            lbl_d01.Name = "lbl_d01";
            lbl_d01.Size = new Size(62, 25);
            lbl_d01.TabIndex = 11;
            lbl_d01.Text = "DO01";
            // 
            // txb_do01
            // 
            txb_do01.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txb_do01.Location = new Point(130, 240);
            txb_do01.Name = "txb_do01";
            txb_do01.Size = new Size(126, 23);
            txb_do01.TabIndex = 15;
            // 
            // btn_do01
            // 
            btn_do01.Anchor = AnchorStyles.None;
            btn_do01.Location = new Point(270, 240);
            btn_do01.Name = "btn_do01";
            btn_do01.Size = new Size(79, 24);
            btn_do01.TabIndex = 20;
            btn_do01.Text = "Teste";
            btn_do01.UseVisualStyleBackColor = true;
            btn_do01.Click += DO1_Click;
            // 
            // lbl_dc2
            // 
            lbl_dc2.Anchor = AnchorStyles.None;
            lbl_dc2.AutoSize = true;
            lbl_dc2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dc2.ForeColor = SystemColors.HighlightText;
            lbl_dc2.Location = new Point(33, 167);
            lbl_dc2.Name = "lbl_dc2";
            lbl_dc2.Size = new Size(60, 25);
            lbl_dc2.TabIndex = 10;
            lbl_dc2.Text = "DC02";
            // 
            // txb_dc2
            // 
            txb_dc2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txb_dc2.Location = new Point(130, 168);
            txb_dc2.Name = "txb_dc2";
            txb_dc2.Size = new Size(126, 23);
            txb_dc2.TabIndex = 14;
            // 
            // btn_dc2
            // 
            btn_dc2.Anchor = AnchorStyles.None;
            btn_dc2.Location = new Point(270, 168);
            btn_dc2.Name = "btn_dc2";
            btn_dc2.Size = new Size(79, 24);
            btn_dc2.TabIndex = 19;
            btn_dc2.Text = "Calibrar";
            btn_dc2.UseVisualStyleBackColor = true;
            btn_dc2.Click += btn_cal2_click;
            // 
            // txb_dc1
            // 
            txb_dc1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txb_dc1.Location = new Point(130, 96);
            txb_dc1.Name = "txb_dc1";
            txb_dc1.Size = new Size(126, 23);
            txb_dc1.TabIndex = 13;
            // 
            // btn_dc1
            // 
            btn_dc1.Anchor = AnchorStyles.None;
            btn_dc1.Location = new Point(270, 96);
            btn_dc1.Name = "btn_dc1";
            btn_dc1.Size = new Size(79, 24);
            btn_dc1.TabIndex = 18;
            btn_dc1.Text = "Calibrar";
            btn_dc1.UseVisualStyleBackColor = true;
            btn_dc1.Click += btn_cal1_click;
            // 
            // lbl_dc1
            // 
            lbl_dc1.Anchor = AnchorStyles.None;
            lbl_dc1.AutoSize = true;
            lbl_dc1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dc1.ForeColor = SystemColors.HighlightText;
            lbl_dc1.Location = new Point(33, 95);
            lbl_dc1.Name = "lbl_dc1";
            lbl_dc1.Size = new Size(60, 25);
            lbl_dc1.TabIndex = 8;
            lbl_dc1.Text = "DC01";
            // 
            // cb_serialnumber
            // 
            cb_serialnumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_serialnumber.FormattingEnabled = true;
            cb_serialnumber.Location = new Point(130, 24);
            cb_serialnumber.Name = "cb_serialnumber";
            cb_serialnumber.Size = new Size(126, 23);
            cb_serialnumber.TabIndex = 26;
            cb_serialnumber.TextChanged += cb_serialnumber_TextChanged;
            cb_serialnumber.Click += Ccb_SerialNumberUpdate_Click;
            // 
            // txb_dc1Calibrar
            // 
            txb_dc1Calibrar.Anchor = AnchorStyles.None;
            txb_dc1Calibrar.Location = new Point(372, 96);
            txb_dc1Calibrar.Name = "txb_dc1Calibrar";
            txb_dc1Calibrar.Size = new Size(72, 23);
            txb_dc1Calibrar.TabIndex = 27;
            // 
            // lbl_do01Calibrar
            // 
            lbl_do01Calibrar.Anchor = AnchorStyles.None;
            lbl_do01Calibrar.Location = new Point(372, 240);
            lbl_do01Calibrar.Name = "lbl_do01Calibrar";
            lbl_do01Calibrar.Size = new Size(72, 23);
            lbl_do01Calibrar.TabIndex = 28;
            // 
            // Ccb_Slot
            // 
            Ccb_Slot.Anchor = AnchorStyles.None;
            Ccb_Slot.FormattingEnabled = true;
            Ccb_Slot.Location = new Point(364, 24);
            Ccb_Slot.Name = "Ccb_Slot";
            Ccb_Slot.Size = new Size(88, 23);
            Ccb_Slot.TabIndex = 29;
            Ccb_Slot.SelectedIndexChanged += Ccb_Slot_TextChanged;
            Ccb_Slot.Click += Ccb_Slot_Click;
            // 
            // tp_serialNumber
            // 
            tp_serialNumber.BackColor = Color.FromArgb(90, 106, 118);
            tp_serialNumber.Controls.Add(tableLayoutPanel7);
            tp_serialNumber.Location = new Point(4, 24);
            tp_serialNumber.Name = "tp_serialNumber";
            tp_serialNumber.Padding = new Padding(3);
            tp_serialNumber.Size = new Size(1194, 602);
            tp_serialNumber.TabIndex = 1;
            tp_serialNumber.Text = "USB";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.Controls.Add(textBox3, 2, 0);
            tableLayoutPanel7.Controls.Add(tlp_containerSN, 1, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel7.Location = new Point(8, 8);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(1177, 575);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.Location = new Point(787, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(387, 379);
            textBox3.TabIndex = 4;
            // 
            // tlp_containerSN
            // 
            tlp_containerSN.Anchor = AnchorStyles.Top;
            tlp_containerSN.BackColor = Color.FromArgb(8, 32, 50);
            tlp_containerSN.ColumnCount = 5;
            tlp_containerSN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_containerSN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_containerSN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_containerSN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_containerSN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_containerSN.Controls.Add(btn_Query, 2, 6);
            tlp_containerSN.Controls.Add(tb_calibDi01SN, 3, 5);
            tlp_containerSN.Controls.Add(tb_calibDo01SN, 3, 4);
            tlp_containerSN.Controls.Add(tb_calibDc2SN, 3, 2);
            tlp_containerSN.Controls.Add(tb_calibDc1, 3, 1);
            tlp_containerSN.Controls.Add(lbl_dc2SN, 0, 2);
            tlp_containerSN.Controls.Add(lbl_dc1SN, 0, 1);
            tlp_containerSN.Controls.Add(lbl_do01SN, 0, 4);
            tlp_containerSN.Controls.Add(lbl_di01SN, 0, 5);
            tlp_containerSN.Controls.Add(txb_dc1SN, 1, 1);
            tlp_containerSN.Controls.Add(txb_dc2SN, 1, 2);
            tlp_containerSN.Controls.Add(txb_do01SN, 1, 4);
            tlp_containerSN.Controls.Add(btn_dc1Cal, 2, 1);
            tlp_containerSN.Controls.Add(btn_dc2SN, 2, 2);
            tlp_containerSN.Controls.Add(btn_do01SN, 2, 4);
            tlp_containerSN.Controls.Add(btn_di01SN, 2, 5);
            tlp_containerSN.Controls.Add(txb_di01SN, 1, 5);
            tlp_containerSN.Controls.Add(label16, 1, 0);
            tlp_containerSN.Controls.Add(label17, 3, 0);
            tlp_containerSN.Controls.Add(label18, 3, 3);
            tlp_containerSN.Controls.Add(label19, 1, 3);
            tlp_containerSN.Controls.Add(textBox22, 4, 1);
            tlp_containerSN.Controls.Add(textBox23, 4, 2);
            tlp_containerSN.Location = new Point(395, 3);
            tlp_containerSN.Name = "tlp_containerSN";
            tlp_containerSN.RowCount = 7;
            tlp_containerSN.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
            tlp_containerSN.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp_containerSN.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp_containerSN.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp_containerSN.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp_containerSN.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp_containerSN.RowStyles.Add(new RowStyle());
            tlp_containerSN.Size = new Size(386, 385);
            tlp_containerSN.TabIndex = 1;
            // 
            // btn_Query
            // 
            btn_Query.Anchor = AnchorStyles.None;
            btn_Query.AutoSize = true;
            btn_Query.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Query.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Query.ForeColor = SystemColors.ControlText;
            btn_Query.Location = new Point(163, 351);
            btn_Query.Name = "btn_Query";
            btn_Query.Size = new Size(58, 30);
            btn_Query.TabIndex = 8;
            btn_Query.Text = "Query";
            btn_Query.UseVisualStyleBackColor = true;
            btn_Query.Click += Query_btn;
            // 
            // tb_calibDi01SN
            // 
            tb_calibDi01SN.Anchor = AnchorStyles.None;
            tb_calibDi01SN.Location = new Point(234, 307);
            tb_calibDi01SN.Name = "tb_calibDi01SN";
            tb_calibDi01SN.ReadOnly = true;
            tb_calibDi01SN.Size = new Size(71, 23);
            tb_calibDi01SN.TabIndex = 28;
            // 
            // tb_calibDo01SN
            // 
            tb_calibDo01SN.Anchor = AnchorStyles.None;
            tb_calibDo01SN.Location = new Point(234, 249);
            tb_calibDo01SN.Name = "tb_calibDo01SN";
            tb_calibDo01SN.ReadOnly = true;
            tb_calibDo01SN.Size = new Size(71, 23);
            tb_calibDo01SN.TabIndex = 28;
            // 
            // tb_calibDc2SN
            // 
            tb_calibDc2SN.Anchor = AnchorStyles.None;
            tb_calibDc2SN.Location = new Point(234, 133);
            tb_calibDc2SN.Name = "tb_calibDc2SN";
            tb_calibDc2SN.Size = new Size(71, 23);
            tb_calibDc2SN.TabIndex = 28;
            // 
            // tb_calibDc1
            // 
            tb_calibDc1.Anchor = AnchorStyles.None;
            tb_calibDc1.Location = new Point(234, 75);
            tb_calibDc1.Name = "tb_calibDc1";
            tb_calibDc1.Size = new Size(71, 23);
            tb_calibDc1.TabIndex = 28;
            // 
            // lbl_dc2SN
            // 
            lbl_dc2SN.Anchor = AnchorStyles.None;
            lbl_dc2SN.AutoSize = true;
            lbl_dc2SN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dc2SN.ForeColor = SystemColors.HighlightText;
            lbl_dc2SN.Location = new Point(8, 132);
            lbl_dc2SN.Name = "lbl_dc2SN";
            lbl_dc2SN.Size = new Size(60, 25);
            lbl_dc2SN.TabIndex = 10;
            lbl_dc2SN.Text = "DC02";
            // 
            // lbl_dc1SN
            // 
            lbl_dc1SN.Anchor = AnchorStyles.None;
            lbl_dc1SN.AutoSize = true;
            lbl_dc1SN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dc1SN.ForeColor = SystemColors.HighlightText;
            lbl_dc1SN.Location = new Point(8, 74);
            lbl_dc1SN.Name = "lbl_dc1SN";
            lbl_dc1SN.Size = new Size(60, 25);
            lbl_dc1SN.TabIndex = 8;
            lbl_dc1SN.Text = "DC01";
            // 
            // lbl_do01SN
            // 
            lbl_do01SN.Anchor = AnchorStyles.None;
            lbl_do01SN.AutoSize = true;
            lbl_do01SN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_do01SN.ForeColor = SystemColors.HighlightText;
            lbl_do01SN.Location = new Point(7, 248);
            lbl_do01SN.Name = "lbl_do01SN";
            lbl_do01SN.Size = new Size(62, 25);
            lbl_do01SN.TabIndex = 11;
            lbl_do01SN.Text = "DO01";
            // 
            // lbl_di01SN
            // 
            lbl_di01SN.Anchor = AnchorStyles.None;
            lbl_di01SN.AutoSize = true;
            lbl_di01SN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_di01SN.ForeColor = SystemColors.HighlightText;
            lbl_di01SN.Location = new Point(11, 306);
            lbl_di01SN.Name = "lbl_di01SN";
            lbl_di01SN.Size = new Size(54, 25);
            lbl_di01SN.TabIndex = 9;
            lbl_di01SN.Text = "DI01";
            // 
            // txb_dc1SN
            // 
            txb_dc1SN.Anchor = AnchorStyles.Left;
            txb_dc1SN.Location = new Point(80, 75);
            txb_dc1SN.Name = "txb_dc1SN";
            txb_dc1SN.ReadOnly = true;
            txb_dc1SN.Size = new Size(71, 23);
            txb_dc1SN.TabIndex = 13;
            // 
            // txb_dc2SN
            // 
            txb_dc2SN.Anchor = AnchorStyles.Left;
            txb_dc2SN.Location = new Point(80, 133);
            txb_dc2SN.Name = "txb_dc2SN";
            txb_dc2SN.Size = new Size(71, 23);
            txb_dc2SN.TabIndex = 14;
            // 
            // txb_do01SN
            // 
            txb_do01SN.Anchor = AnchorStyles.Left;
            txb_do01SN.Location = new Point(80, 249);
            txb_do01SN.Name = "txb_do01SN";
            txb_do01SN.ReadOnly = true;
            txb_do01SN.Size = new Size(71, 23);
            txb_do01SN.TabIndex = 15;
            // 
            // btn_dc1Cal
            // 
            btn_dc1Cal.Anchor = AnchorStyles.Left;
            btn_dc1Cal.Location = new Point(157, 75);
            btn_dc1Cal.Name = "btn_dc1Cal";
            btn_dc1Cal.Size = new Size(71, 24);
            btn_dc1Cal.TabIndex = 18;
            btn_dc1Cal.Text = "Calibrar";
            btn_dc1Cal.UseVisualStyleBackColor = true;
            btn_dc1Cal.Click += btn_DC01Cal;
            // 
            // btn_dc2SN
            // 
            btn_dc2SN.Anchor = AnchorStyles.Left;
            btn_dc2SN.Location = new Point(157, 133);
            btn_dc2SN.Name = "btn_dc2SN";
            btn_dc2SN.Size = new Size(71, 24);
            btn_dc2SN.TabIndex = 19;
            btn_dc2SN.Text = "Calibrar";
            btn_dc2SN.UseVisualStyleBackColor = true;
            btn_dc2SN.Click += btn_DC02Cal;
            // 
            // btn_do01SN
            // 
            btn_do01SN.Anchor = AnchorStyles.Left;
            btn_do01SN.Location = new Point(157, 249);
            btn_do01SN.Name = "btn_do01SN";
            btn_do01SN.Size = new Size(71, 24);
            btn_do01SN.TabIndex = 20;
            btn_do01SN.Text = "Teste";
            btn_do01SN.UseVisualStyleBackColor = true;
            btn_do01SN.Click += btn_DO01_Click;
            // 
            // btn_di01SN
            // 
            btn_di01SN.Anchor = AnchorStyles.Left;
            btn_di01SN.Location = new Point(157, 307);
            btn_di01SN.Name = "btn_di01SN";
            btn_di01SN.Size = new Size(71, 24);
            btn_di01SN.TabIndex = 21;
            btn_di01SN.Text = "Teste";
            btn_di01SN.UseVisualStyleBackColor = true;
            btn_di01SN.Click += btn_DO01_Click;
            // 
            // txb_di01SN
            // 
            txb_di01SN.Anchor = AnchorStyles.Left;
            txb_di01SN.Location = new Point(80, 307);
            txb_di01SN.Name = "txb_di01SN";
            txb_di01SN.ReadOnly = true;
            txb_di01SN.Size = new Size(71, 23);
            txb_di01SN.TabIndex = 16;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom;
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(91, 28);
            label16.Name = "label16";
            label16.Size = new Size(48, 30);
            label16.TabIndex = 29;
            label16.Text = "Valor Medido";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom;
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(242, 28);
            label17.Name = "label17";
            label17.Size = new Size(55, 30);
            label17.TabIndex = 30;
            label17.Text = "Valor Esperado";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Bottom;
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.ButtonFace;
            label18.Location = new Point(244, 202);
            label18.Name = "label18";
            label18.Size = new Size(50, 30);
            label18.TabIndex = 31;
            label18.Text = "Estado Anterior";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom;
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.ButtonFace;
            label19.Location = new Point(93, 202);
            label19.Name = "label19";
            label19.Size = new Size(45, 30);
            label19.TabIndex = 32;
            label19.Text = "Estado Atual";
            // 
            // textBox22
            // 
            textBox22.Anchor = AnchorStyles.None;
            textBox22.Location = new Point(311, 75);
            textBox22.Name = "textBox22";
            textBox22.ReadOnly = true;
            textBox22.Size = new Size(72, 23);
            textBox22.TabIndex = 33;
            // 
            // textBox23
            // 
            textBox23.Anchor = AnchorStyles.None;
            textBox23.Location = new Point(311, 133);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(72, 23);
            textBox23.TabIndex = 34;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(tlp_container3SN, 0, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel9.Controls.Add(tlp_containerSN2, 0, 2);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle());
            tableLayoutPanel9.RowStyles.Add(new RowStyle());
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(386, 569);
            tableLayoutPanel9.TabIndex = 9;
            // 
            // tlp_container3SN
            // 
            tlp_container3SN.Anchor = AnchorStyles.Top;
            tlp_container3SN.BackColor = Color.FromArgb(8, 32, 50);
            tlp_container3SN.ColumnCount = 3;
            tlp_container3SN.ColumnStyles.Add(new ColumnStyle());
            tlp_container3SN.ColumnStyles.Add(new ColumnStyle());
            tlp_container3SN.ColumnStyles.Add(new ColumnStyle());
            tlp_container3SN.Controls.Add(tableLayoutPanel8, 2, 0);
            tlp_container3SN.Controls.Add(tableLayoutPanel3, 1, 0);
            tlp_container3SN.Controls.Add(tableLayoutPanel2, 0, 0);
            tlp_container3SN.Location = new Point(3, 0);
            tlp_container3SN.Margin = new Padding(3, 0, 3, 3);
            tlp_container3SN.Name = "tlp_container3SN";
            tlp_container3SN.RowCount = 1;
            tlp_container3SN.RowStyles.Add(new RowStyle());
            tlp_container3SN.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_container3SN.Size = new Size(380, 104);
            tlp_container3SN.TabIndex = 3;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label2, 0, 0);
            tableLayoutPanel8.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel8.Location = new Point(259, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(122, 100);
            tableLayoutPanel8.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(8, 15);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 5;
            label2.Text = "Serial Number";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(11, 63);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(99, 23);
            textBox2.TabIndex = 6;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(txb_baudrate, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Location = new Point(131, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(122, 100);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // txb_baudrate
            // 
            txb_baudrate.Anchor = AnchorStyles.None;
            txb_baudrate.Location = new Point(11, 63);
            txb_baudrate.Name = "txb_baudrate";
            txb_baudrate.ReadOnly = true;
            txb_baudrate.Size = new Size(99, 23);
            txb_baudrate.TabIndex = 3;
            txb_baudrate.Text = "38400";
            txb_baudrate.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 4;
            label1.Text = "Baud Rate";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(comboBoxCOMPort, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonConnect, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(122, 100);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // comboBoxCOMPort
            // 
            comboBoxCOMPort.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCOMPort.FormattingEnabled = true;
            comboBoxCOMPort.Location = new Point(3, 63);
            comboBoxCOMPort.Name = "comboBoxCOMPort";
            comboBoxCOMPort.Size = new Size(116, 23);
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
            buttonConnect.Location = new Point(24, 10);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(73, 30);
            buttonConnect.TabIndex = 2;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 110);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(380, 114);
            tableLayoutPanel10.TabIndex = 5;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Top;
            tableLayoutPanel11.BackColor = Color.FromArgb(8, 32, 50);
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.Controls.Add(lbl_medCorrenteSN, 0, 0);
            tableLayoutPanel11.Controls.Add(lbl_medCorrentSN, 0, 1);
            tableLayoutPanel11.Controls.Add(textBox20, 1, 2);
            tableLayoutPanel11.Controls.Add(txb_medCorrenteSN, 0, 2);
            tableLayoutPanel11.Controls.Add(button7, 1, 1);
            tableLayoutPanel11.Location = new Point(3, 0);
            tableLayoutPanel11.Margin = new Padding(3, 0, 3, 0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 3;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.Size = new Size(374, 104);
            tableLayoutPanel11.TabIndex = 24;
            // 
            // lbl_medCorrenteSN
            // 
            lbl_medCorrenteSN.Anchor = AnchorStyles.None;
            lbl_medCorrenteSN.AutoSize = true;
            tableLayoutPanel11.SetColumnSpan(lbl_medCorrenteSN, 2);
            lbl_medCorrenteSN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_medCorrenteSN.ForeColor = SystemColors.HighlightText;
            lbl_medCorrenteSN.Location = new Point(100, 4);
            lbl_medCorrenteSN.Name = "lbl_medCorrenteSN";
            lbl_medCorrenteSN.Size = new Size(174, 25);
            lbl_medCorrenteSN.TabIndex = 23;
            lbl_medCorrenteSN.Text = "Fonte de Corrente";
            // 
            // lbl_medCorrentSN
            // 
            lbl_medCorrentSN.Anchor = AnchorStyles.None;
            lbl_medCorrentSN.AutoSize = true;
            lbl_medCorrentSN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_medCorrentSN.ForeColor = SystemColors.HighlightText;
            lbl_medCorrentSN.Location = new Point(46, 42);
            lbl_medCorrentSN.Name = "lbl_medCorrentSN";
            lbl_medCorrentSN.Size = new Size(94, 17);
            lbl_medCorrentSN.TabIndex = 15;
            lbl_medCorrentSN.Text = "(4mA - 20mA)";
            // 
            // textBox20
            // 
            textBox20.Anchor = AnchorStyles.None;
            textBox20.Location = new Point(230, 74);
            textBox20.Name = "textBox20";
            textBox20.ReadOnly = true;
            textBox20.Size = new Size(100, 23);
            textBox20.TabIndex = 16;
            // 
            // txb_medCorrenteSN
            // 
            txb_medCorrenteSN.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txb_medCorrenteSN.Location = new Point(3, 74);
            txb_medCorrenteSN.Name = "txb_medCorrenteSN";
            txb_medCorrenteSN.Size = new Size(181, 23);
            txb_medCorrenteSN.TabIndex = 14;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.Location = new Point(243, 39);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 17;
            button7.Text = "Calcular";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // tlp_containerSN2
            // 
            tlp_containerSN2.BackColor = Color.FromArgb(8, 32, 50);
            tlp_containerSN2.ColumnCount = 1;
            tlp_containerSN2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_containerSN2.Controls.Add(btn_reset, 0, 4);
            tlp_containerSN2.Controls.Add(tableLayoutPanel12, 0, 0);
            tlp_containerSN2.Controls.Add(tableLayoutPanel13, 0, 1);
            tlp_containerSN2.Controls.Add(tableLayoutPanel14, 0, 2);
            tlp_containerSN2.Controls.Add(tableLayoutPanel15, 0, 3);
            tlp_containerSN2.Dock = DockStyle.Fill;
            tlp_containerSN2.Location = new Point(3, 230);
            tlp_containerSN2.Name = "tlp_containerSN2";
            tlp_containerSN2.RowCount = 5;
            tlp_containerSN2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp_containerSN2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp_containerSN2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp_containerSN2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp_containerSN2.RowStyles.Add(new RowStyle());
            tlp_containerSN2.Size = new Size(380, 336);
            tlp_containerSN2.TabIndex = 2;
            // 
            // btn_reset
            // 
            btn_reset.Anchor = AnchorStyles.Bottom;
            btn_reset.ForeColor = SystemColors.ActiveCaptionText;
            btn_reset.Location = new Point(150, 308);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(79, 25);
            btn_reset.TabIndex = 0;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_Reset_Click;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(label4, 0, 0);
            tableLayoutPanel12.Controls.Add(textBox7, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.Size = new Size(374, 70);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(146, 10);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 4;
            label4.Text = "IP Device";
            // 
            // textBox7
            // 
            textBox7.Dock = DockStyle.Fill;
            textBox7.Location = new Point(3, 44);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(368, 23);
            textBox7.TabIndex = 3;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(label5, 0, 0);
            tableLayoutPanel13.Controls.Add(textBox6, 0, 1);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 79);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(374, 70);
            tableLayoutPanel13.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(139, 7);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 5;
            label5.Text = "IP Gateway";
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Location = new Point(3, 38);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(368, 23);
            textBox6.TabIndex = 2;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(label6, 0, 0);
            tableLayoutPanel14.Controls.Add(textBox5, 0, 1);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 155);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(374, 70);
            tableLayoutPanel14.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(152, 7);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 6;
            label6.Text = "IP Mask";
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(3, 38);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(368, 23);
            textBox5.TabIndex = 1;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 1;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Controls.Add(textBox4, 0, 1);
            tableLayoutPanel15.Controls.Add(label7, 0, 0);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 231);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 2;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Size = new Size(374, 70);
            tableLayoutPanel15.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(3, 38);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(368, 23);
            textBox4.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(148, 7);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 7;
            label7.Text = "IP Server";
            // 
            // Frm_Teste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1202, 630);
            Controls.Add(tc_teste);
            Name = "Frm_Teste";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teste";
            tc_teste.ResumeLayout(false);
            tp_mqtt.ResumeLayout(false);
            tlp_contaier3.ResumeLayout(false);
            tlp_contaier3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tlp_container2.ResumeLayout(false);
            gb_ip.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            gb_rst.ResumeLayout(false);
            Tlp_Container.ResumeLayout(false);
            Tlp_Container.PerformLayout();
            tp_serialNumber.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tlp_containerSN.ResumeLayout(false);
            tlp_containerSN.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tlp_container3SN.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tlp_containerSN2.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tc_teste;
        private TabPage tp_mqtt;
        private TabPage tp_serialNumber;

        private TableLayoutPanel Tlp_Container;
        private Label lbl_dc2;
        private Label lbl_dc1;
        private Label lbl_d01;
        private Label lbl_di01;
        private TableLayoutPanel tlp_container2;
        private TextBox txb_dc1;
        private TextBox txb_dc2;
        private TextBox txb_do01;
        private TextBox txb_di01;
        private Button btn_dc1;
        private Button btn_dc2;
        private Button btn_do01;
        private Button btn_di01;
        private TableLayoutPanel tlp_containerSN2;
        private TableLayoutPanel tlp_containerSN;
        private Label lbl_dc2SN;
        private Label lbl_dc1SN;
        private Label lbl_do01SN;
        private TextBox txb_dc1SN;
        private TextBox txb_dc2SN;
        private TextBox txb_do01SN;
        private Button btn_dc1Cal;
        private Button btn_dc2SN;
        private Button btn_do01SN;
        private Label lbl_mediCorrente;
        private TableLayoutPanel tlp_contaier3;
        private TextBox textBox1;
        private Label lbl_medidor;
        private GroupBox gb_rst;
        private GroupBox gb_ip;
        private Label lbl_SerialNumber;
        private ComboBox cb_serialnumber;
        private TableLayoutPanel tlp_container3SN;
        private Label lbl_medCorrenteSN;
        private TextBox txb_medCorrenteSN;
        private Label lbl_medCorrentSN;
        private TextBox lbl_di01Calibrar;
        private TextBox lbl_dc2Calibrar;
        private TextBox txb_dc1Calibrar;
        private TextBox lbl_do01Calibrar;
        private TextBox tb_calibDo01SN;
        private TextBox tb_calibDc2SN;
        private TextBox tb_calibDc1;
        private ComboBox Ccb_Slot;
        private Label lbl_Slot;
        private ComboBox comboBoxCOMPort;
        private Button buttonConnect;
        private TextBox txb_baudrate;
        private Label label1;
        private TextBox textBox3;
        private Button btn_reset;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox19;
        private Button button1;
        private TextBox textBox12;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label14;
        private Label label13;
        private Label label15;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private TextBox textBox20;
        private Button button7;
        private Button button8;
        private TextBox textBox21;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label2;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox textBox22;
        private TextBox textBox23;
        private Button btn_Query;
        private TextBox tb_calibDi01SN;
        private Label lbl_di01SN;
        private Button btn_di01SN;
        private TextBox txb_di01SN;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel15;
    }
}