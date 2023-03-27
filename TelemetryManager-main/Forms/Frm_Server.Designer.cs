using System.Windows.Forms;

namespace NewTelemetryManager.Forms
{
    partial class Frm_Server
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
            this.Tlp_BackgroundDashboard = new System.Windows.Forms.Panel();
            this.Pnl_ServerBackground = new System.Windows.Forms.Panel();
            this.Tlp_Container = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Server = new System.Windows.Forms.Label();
            this.Tlp_Container2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.Txb_ServerAddress = new System.Windows.Forms.TextBox();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Tlp_BackgroundDashboard.SuspendLayout();
            this.Pnl_ServerBackground.SuspendLayout();
            this.Tlp_Container.SuspendLayout();
            this.Tlp_Container2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_BackgroundDashboard
            // 
            this.Tlp_BackgroundDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            this.Tlp_BackgroundDashboard.Controls.Add(this.Pnl_ServerBackground);
            this.Tlp_BackgroundDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_BackgroundDashboard.Location = new System.Drawing.Point(0, 0);
            this.Tlp_BackgroundDashboard.Name = "Tlp_BackgroundDashboard";
            this.Tlp_BackgroundDashboard.Size = new System.Drawing.Size(510, 361);
            this.Tlp_BackgroundDashboard.TabIndex = 0;
            // 
            // Pnl_ServerBackground
            // 
            this.Pnl_ServerBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.Pnl_ServerBackground.Controls.Add(this.Tlp_Container);
            this.Pnl_ServerBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_ServerBackground.Location = new System.Drawing.Point(0, 0);
            this.Pnl_ServerBackground.Name = "Pnl_ServerBackground";
            this.Pnl_ServerBackground.Size = new System.Drawing.Size(510, 361);
            this.Pnl_ServerBackground.TabIndex = 2;
            // 
            // Tlp_Container
            // 
            this.Tlp_Container.ColumnCount = 1;
            this.Tlp_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_Container.Controls.Add(this.Lbl_Server, 0, 0);
            this.Tlp_Container.Controls.Add(this.Tlp_Container2, 0, 1);
            this.Tlp_Container.Location = new System.Drawing.Point(161, 65);
            this.Tlp_Container.Name = "Tlp_Container";
            this.Tlp_Container.RowCount = 2;
            this.Tlp_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.54545F));
            this.Tlp_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.45454F));
            this.Tlp_Container.Size = new System.Drawing.Size(228, 211);
            this.Tlp_Container.TabIndex = 2;
            // 
            // Lbl_Server
            // 
            this.Lbl_Server.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Server.AutoSize = true;
            this.Lbl_Server.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Server.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Server.Location = new System.Drawing.Point(4, 17);
            this.Lbl_Server.Name = "Lbl_Server";
            this.Lbl_Server.Size = new System.Drawing.Size(219, 28);
            this.Lbl_Server.TabIndex = 0;
            this.Lbl_Server.Text = "Conectar no Servidor";
            // 
            // Tlp_Container2
            // 
            this.Tlp_Container2.ColumnCount = 3;
            this.Tlp_Container2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Tlp_Container2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.Tlp_Container2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Tlp_Container2.Controls.Add(this.lbl_usuario, 0, 0);
            this.Tlp_Container2.Controls.Add(this.Txb_ServerAddress, 1, 0);
            this.Tlp_Container2.Controls.Add(this.Btn_Connect, 1, 1);
            this.Tlp_Container2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Container2.Location = new System.Drawing.Point(3, 65);
            this.Tlp_Container2.Name = "Tlp_Container2";
            this.Tlp_Container2.RowCount = 2;
            this.Tlp_Container2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.65035F));
            this.Tlp_Container2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.34965F));
            this.Tlp_Container2.Size = new System.Drawing.Size(222, 143);
            this.Tlp_Container2.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_usuario.Location = new System.Drawing.Point(3, 25);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(29, 21);
            this.lbl_usuario.TabIndex = 8;
            this.lbl_usuario.Text = "IP ";
            // 
            // Txb_ServerAddress
            // 
            this.Txb_ServerAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Txb_ServerAddress.Location = new System.Drawing.Point(38, 24);
            this.Txb_ServerAddress.Name = "Txb_ServerAddress";
            this.Txb_ServerAddress.Size = new System.Drawing.Size(148, 23);
            this.Txb_ServerAddress.TabIndex = 0;
            this.Txb_ServerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Connect.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Connect.Location = new System.Drawing.Point(38, 92);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(148, 30);
            this.Btn_Connect.TabIndex = 1;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Frm_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 361);
            this.Controls.Add(this.Tlp_BackgroundDashboard);
            this.Name = "Frm_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Tlp_BackgroundDashboard.ResumeLayout(false);
            this.Pnl_ServerBackground.ResumeLayout(false);
            this.Tlp_Container.ResumeLayout(false);
            this.Tlp_Container.PerformLayout();
            this.Tlp_Container2.ResumeLayout(false);
            this.Tlp_Container2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Tlp_BackgroundDashboard;
        private Label Lbl_Server;
        private Button Btn_Connect;
        private TextBox Txb_ServerAddress;
        private Panel Pnl_ServerBackground;
        private TableLayoutPanel Tlp_Container;
        private TableLayoutPanel Tlp_Container2;
        private Label lbl_usuario;
    }
}