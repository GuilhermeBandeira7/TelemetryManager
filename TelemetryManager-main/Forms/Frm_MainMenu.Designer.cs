namespace NewTelemetryManager
{
    partial class Frm_MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainMenu));
            Pnl_Menu = new Panel();
            Btn_Teste = new Button();
            Btn_LANDevices = new Button();
            Btn_Configuration = new Button();
            Btn_VariablesDevices = new Button();
            Btn_Server = new Button();
            Pnl_Logo = new Panel();
            Lbl_Logo = new Label();
            Pnl_Title = new Panel();
            Lbl_Home = new Label();
            Pnl_Background = new Panel();
            Pnl_Menu.SuspendLayout();
            Pnl_Logo.SuspendLayout();
            Pnl_Title.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Menu
            // 
            Pnl_Menu.BackColor = Color.FromArgb(8, 32, 50);
            Pnl_Menu.Controls.Add(Btn_Teste);
            Pnl_Menu.Controls.Add(Btn_LANDevices);
            Pnl_Menu.Controls.Add(Btn_Configuration);
            Pnl_Menu.Controls.Add(Btn_VariablesDevices);
            Pnl_Menu.Controls.Add(Btn_Server);
            Pnl_Menu.Controls.Add(Pnl_Logo);
            Pnl_Menu.Dock = DockStyle.Left;
            Pnl_Menu.Location = new Point(0, 0);
            Pnl_Menu.Name = "Pnl_Menu";
            Pnl_Menu.Size = new Size(162, 684);
            Pnl_Menu.TabIndex = 0;
            // 
            // Btn_Teste
            // 
            Btn_Teste.Dock = DockStyle.Top;
            Btn_Teste.FlatAppearance.BorderSize = 0;
            Btn_Teste.FlatStyle = FlatStyle.Flat;
            Btn_Teste.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Teste.ForeColor = Color.White;
            Btn_Teste.Image = (Image)resources.GetObject("Btn_Teste.Image");
            Btn_Teste.Location = new Point(0, 563);
            Btn_Teste.Name = "Btn_Teste";
            Btn_Teste.Size = new Size(162, 122);
            Btn_Teste.TabIndex = 5;
            Btn_Teste.Text = "Teste";
            Btn_Teste.TextAlign = ContentAlignment.BottomCenter;
            Btn_Teste.TextImageRelation = TextImageRelation.ImageAboveText;
            Btn_Teste.UseVisualStyleBackColor = true;
            Btn_Teste.Click += Btn_Teste_Click;
            // 
            // Btn_LANDevices
            // 
            Btn_LANDevices.Dock = DockStyle.Top;
            Btn_LANDevices.FlatAppearance.BorderSize = 0;
            Btn_LANDevices.FlatStyle = FlatStyle.Flat;
            Btn_LANDevices.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_LANDevices.ForeColor = Color.White;
            Btn_LANDevices.Image = (Image)resources.GetObject("Btn_LANDevices.Image");
            Btn_LANDevices.Location = new Point(0, 441);
            Btn_LANDevices.Name = "Btn_LANDevices";
            Btn_LANDevices.Size = new Size(162, 122);
            Btn_LANDevices.TabIndex = 4;
            Btn_LANDevices.Text = " LAN Devices";
            Btn_LANDevices.TextImageRelation = TextImageRelation.ImageAboveText;
            Btn_LANDevices.UseVisualStyleBackColor = true;
            Btn_LANDevices.Click += Btn_DevicesTCPIP_Click;
            // 
            // Btn_Configuration
            // 
            Btn_Configuration.Dock = DockStyle.Top;
            Btn_Configuration.FlatAppearance.BorderSize = 0;
            Btn_Configuration.FlatStyle = FlatStyle.Flat;
            Btn_Configuration.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Configuration.ForeColor = Color.White;
            Btn_Configuration.Image = (Image)resources.GetObject("Btn_Configuration.Image");
            Btn_Configuration.Location = new Point(0, 319);
            Btn_Configuration.Name = "Btn_Configuration";
            Btn_Configuration.Size = new Size(162, 122);
            Btn_Configuration.TabIndex = 3;
            Btn_Configuration.Text = "Config. USB";
            Btn_Configuration.TextImageRelation = TextImageRelation.ImageAboveText;
            Btn_Configuration.UseVisualStyleBackColor = true;
            Btn_Configuration.Click += Btn_Configuration_Click;
            // 
            // Btn_VariablesDevices
            // 
            Btn_VariablesDevices.Dock = DockStyle.Top;
            Btn_VariablesDevices.FlatAppearance.BorderSize = 0;
            Btn_VariablesDevices.FlatStyle = FlatStyle.Flat;
            Btn_VariablesDevices.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_VariablesDevices.ForeColor = Color.White;
            Btn_VariablesDevices.Image = (Image)resources.GetObject("Btn_VariablesDevices.Image");
            Btn_VariablesDevices.Location = new Point(0, 197);
            Btn_VariablesDevices.Name = "Btn_VariablesDevices";
            Btn_VariablesDevices.Size = new Size(162, 122);
            Btn_VariablesDevices.TabIndex = 2;
            Btn_VariablesDevices.Text = " Devices";
            Btn_VariablesDevices.TextImageRelation = TextImageRelation.ImageAboveText;
            Btn_VariablesDevices.UseVisualStyleBackColor = true;
            Btn_VariablesDevices.Click += Btn_VariablesDevices_Click;
            // 
            // Btn_Server
            // 
            Btn_Server.Dock = DockStyle.Top;
            Btn_Server.FlatAppearance.BorderSize = 0;
            Btn_Server.FlatStyle = FlatStyle.Flat;
            Btn_Server.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Server.ForeColor = Color.White;
            Btn_Server.Image = (Image)resources.GetObject("Btn_Server.Image");
            Btn_Server.Location = new Point(0, 75);
            Btn_Server.Name = "Btn_Server";
            Btn_Server.Size = new Size(162, 122);
            Btn_Server.TabIndex = 1;
            Btn_Server.Text = "Server";
            Btn_Server.TextImageRelation = TextImageRelation.ImageAboveText;
            Btn_Server.UseVisualStyleBackColor = true;
            Btn_Server.Click += Btn_Dashboard_Click;
            // 
            // Pnl_Logo
            // 
            Pnl_Logo.BackColor = Color.FromArgb(8, 32, 50);
            Pnl_Logo.BackgroundImageLayout = ImageLayout.Center;
            Pnl_Logo.Controls.Add(Lbl_Logo);
            Pnl_Logo.Dock = DockStyle.Top;
            Pnl_Logo.Location = new Point(0, 0);
            Pnl_Logo.Name = "Pnl_Logo";
            Pnl_Logo.Size = new Size(162, 75);
            Pnl_Logo.TabIndex = 0;
            // 
            // Lbl_Logo
            // 
            Lbl_Logo.AutoSize = true;
            Lbl_Logo.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Logo.ForeColor = Color.White;
            Lbl_Logo.Location = new Point(53, 26);
            Lbl_Logo.Name = "Lbl_Logo";
            Lbl_Logo.Size = new Size(65, 25);
            Lbl_Logo.TabIndex = 0;
            Lbl_Logo.Text = "MTW ";
            Lbl_Logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pnl_Title
            // 
            Pnl_Title.BackColor = Color.FromArgb(8, 32, 50);
            Pnl_Title.Controls.Add(Lbl_Home);
            Pnl_Title.Dock = DockStyle.Top;
            Pnl_Title.Location = new Point(162, 0);
            Pnl_Title.Name = "Pnl_Title";
            Pnl_Title.Size = new Size(1077, 75);
            Pnl_Title.TabIndex = 1;
            // 
            // Lbl_Home
            // 
            Lbl_Home.Anchor = AnchorStyles.None;
            Lbl_Home.AutoSize = true;
            Lbl_Home.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Home.ForeColor = Color.White;
            Lbl_Home.Location = new Point(486, 26);
            Lbl_Home.Name = "Lbl_Home";
            Lbl_Home.Size = new Size(69, 25);
            Lbl_Home.TabIndex = 0;
            Lbl_Home.Text = "HOME";
            // 
            // Pnl_Background
            // 
            Pnl_Background.Dock = DockStyle.Fill;
            Pnl_Background.Location = new Point(162, 75);
            Pnl_Background.Name = "Pnl_Background";
            Pnl_Background.Size = new Size(1077, 609);
            Pnl_Background.TabIndex = 2;
            // 
            // Frm_MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1239, 684);
            Controls.Add(Pnl_Background);
            Controls.Add(Pnl_Title);
            Controls.Add(Pnl_Menu);
            Name = "Frm_MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telemetry Manager";
            FormClosing += Frm_MainMenu_FormClosing;
            Pnl_Menu.ResumeLayout(false);
            Pnl_Logo.ResumeLayout(false);
            Pnl_Logo.PerformLayout();
            Pnl_Title.ResumeLayout(false);
            Pnl_Title.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Menu;
        private Panel Pnl_Logo;
        private Button Btn_VariablesDevices;
        private Button Btn_Server;
        private Panel Pnl_Title;
        private Label Lbl_Home;
        private Label Lbl_Logo;
        private Panel Pnl_Background;
        private Button Btn_LANDevices;
        private Button Btn_Configuration;
        private Button Btn_Teste;
    }
}