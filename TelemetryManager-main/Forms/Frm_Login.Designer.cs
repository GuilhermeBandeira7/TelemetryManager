namespace TelemetryManager.Forms
{
    partial class Frm_Login
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Lbl_LoginTitulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbl_senha = new Label();
            lbl_usuario = new Label();
            txb_usuario = new TextBox();
            Btn_login = new Button();
            txb_senha = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Lbl_LoginTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(117, 92);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.59702F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.40298F));
            tableLayoutPanel1.Size = new Size(340, 274);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Lbl_LoginTitulo
            // 
            Lbl_LoginTitulo.Anchor = AnchorStyles.None;
            Lbl_LoginTitulo.AutoSize = true;
            Lbl_LoginTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_LoginTitulo.ForeColor = SystemColors.HighlightText;
            Lbl_LoginTitulo.Location = new Point(51, 26);
            Lbl_LoginTitulo.Name = "Lbl_LoginTitulo";
            Lbl_LoginTitulo.Size = new Size(237, 30);
            Lbl_LoginTitulo.TabIndex = 6;
            Lbl_LoginTitulo.Text = "TMDev Manager Login";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.07888F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.92112F));
            tableLayoutPanel2.Controls.Add(lbl_senha, 0, 1);
            tableLayoutPanel2.Controls.Add(lbl_usuario, 0, 0);
            tableLayoutPanel2.Controls.Add(txb_usuario, 1, 0);
            tableLayoutPanel2.Controls.Add(Btn_login, 1, 2);
            tableLayoutPanel2.Controls.Add(txb_senha, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 86);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(334, 185);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // lbl_senha
            // 
            lbl_senha.Anchor = AnchorStyles.None;
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.ForeColor = SystemColors.HighlightText;
            lbl_senha.Location = new Point(26, 100);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(57, 21);
            lbl_senha.TabIndex = 8;
            lbl_senha.Text = "Senha";
            // 
            // lbl_usuario
            // 
            lbl_usuario.Anchor = AnchorStyles.None;
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usuario.ForeColor = SystemColors.HighlightText;
            lbl_usuario.Location = new Point(20, 26);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(69, 21);
            lbl_usuario.TabIndex = 7;
            lbl_usuario.Text = "Usuário";
            // 
            // txb_usuario
            // 
            txb_usuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txb_usuario.Location = new Point(113, 25);
            txb_usuario.Name = "txb_usuario";
            txb_usuario.Size = new Size(218, 23);
            txb_usuario.TabIndex = 9;
            // 
            // Btn_login
            // 
            Btn_login.Anchor = AnchorStyles.None;
            Btn_login.Location = new Point(184, 151);
            Btn_login.Name = "Btn_login";
            Btn_login.Size = new Size(75, 30);
            Btn_login.TabIndex = 11;
            Btn_login.Text = "Login";
            Btn_login.UseVisualStyleBackColor = true;
            Btn_login.Click += Btn_login_Click;
            Btn_login.Enter += Btn_login_Click;
            // 
            // txb_senha
            // 
            txb_senha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txb_senha.Location = new Point(113, 99);
            txb_senha.Name = "txb_senha";
            txb_senha.Size = new Size(218, 23);
            txb_senha.TabIndex = 10;
            txb_senha.UseSystemPasswordChar = true;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 32, 50);
            ClientSize = new Size(569, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Lbl_LoginTitulo;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbl_senha;
        private Label lbl_usuario;
        private TextBox txb_usuario;
        private TextBox txb_senha;
        private Button Btn_login;
    }
}