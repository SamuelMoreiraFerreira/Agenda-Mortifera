﻿namespace AgendaMortifera
{
    partial class frmCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrar));
            lblEmail = new Label();
            tbxEmail = new TextBox();
            lblName = new Label();
            tbxName = new TextBox();
            lblPecado = new Label();
            tbxPecado = new TextBox();
            lblPhone = new Label();
            tbxPhone = new TextBox();
            lblPassword = new Label();
            tbxPassword = new TextBox();
            btnCancel = new Button();
            btnSign = new Button();
            lblTitle = new Label();
            lblErebro = new Label();
            lblRPassword = new Label();
            tbxRPassword = new TextBox();
            gbxPessoal = new GroupBox();
            gbxSeguranca = new GroupBox();
            gbxPessoal.SuspendLayout();
            gbxSeguranca.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblEmail.Location = new Point(33, 169);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(87, 32);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "E-Mail";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEmail.Location = new Point(33, 219);
            tbxEmail.Margin = new Padding(3, 4, 3, 4);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "alma_penada@dominio.com";
            tbxEmail.Size = new Size(354, 42);
            tbxEmail.TabIndex = 15;
            tbxEmail.TextChanged += tbx_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblName.Location = new Point(33, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 32);
            lblName.TabIndex = 14;
            lblName.Text = "Nome";
            // 
            // tbxName
            // 
            tbxName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxName.Location = new Point(33, 105);
            tbxName.Margin = new Padding(3, 4, 3, 4);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(354, 42);
            tbxName.TabIndex = 13;
            tbxName.TextChanged += tbx_TextChanged;
            // 
            // lblPecado
            // 
            lblPecado.AutoSize = true;
            lblPecado.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPecado.ForeColor = Color.IndianRed;
            lblPecado.Location = new Point(435, 112);
            lblPecado.Name = "lblPecado";
            lblPecado.Size = new Size(112, 32);
            lblPecado.TabIndex = 20;
            lblPecado.Text = "PECADO";
            // 
            // tbxPecado
            // 
            tbxPecado.BackColor = Color.IndianRed;
            tbxPecado.BorderStyle = BorderStyle.FixedSingle;
            tbxPecado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPecado.ForeColor = Color.White;
            tbxPecado.Location = new Point(267, 163);
            tbxPecado.Margin = new Padding(3, 4, 3, 4);
            tbxPecado.Name = "tbxPecado";
            tbxPecado.Size = new Size(427, 42);
            tbxPecado.TabIndex = 19;
            tbxPecado.TextAlign = HorizontalAlignment.Center;
            tbxPecado.TextChanged += tbx_TextChanged;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblPhone.Location = new Point(33, 285);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(111, 32);
            lblPhone.TabIndex = 18;
            lblPhone.Text = "Telefone";
            // 
            // tbxPhone
            // 
            tbxPhone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPhone.Location = new Point(33, 335);
            tbxPhone.Margin = new Padding(3, 4, 3, 4);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.PlaceholderText = "(DDD) 777-666";
            tbxPhone.Size = new Size(354, 42);
            tbxPhone.TabIndex = 17;
            tbxPhone.TextChanged += tbx_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblPassword.Location = new Point(33, 61);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 32);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Senha";
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(33, 111);
            tbxPassword.Margin = new Padding(3, 4, 3, 4);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(354, 42);
            tbxPassword.TabIndex = 21;
            tbxPassword.TextChanged += tbx_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(763, 824);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 80);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.IndianRed;
            btnSign.Enabled = false;
            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSign.ForeColor = Color.White;
            btnSign.Location = new Point(53, 709);
            btnSign.Margin = new Padding(3, 4, 3, 4);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(881, 80);
            btnSign.TabIndex = 23;
            btnSign.Text = "CADASTRAR";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += btnSign_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(303, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(229, 46);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Bem-vindo ao";
            // 
            // lblErebro
            // 
            lblErebro.AutoSize = true;
            lblErebro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErebro.ForeColor = Color.IndianRed;
            lblErebro.Location = new Point(523, 32);
            lblErebro.Name = "lblErebro";
            lblErebro.Size = new Size(148, 46);
            lblErebro.TabIndex = 26;
            lblErebro.Text = "ÉREBRO";
            // 
            // lblRPassword
            // 
            lblRPassword.AutoSize = true;
            lblRPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblRPassword.Location = new Point(33, 177);
            lblRPassword.Name = "lblRPassword";
            lblRPassword.Size = new Size(259, 32);
            lblRPassword.TabIndex = 28;
            lblRPassword.Text = "Confirme a sua senha";
            // 
            // tbxRPassword
            // 
            tbxRPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxRPassword.Location = new Point(33, 227);
            tbxRPassword.Margin = new Padding(3, 4, 3, 4);
            tbxRPassword.Name = "tbxRPassword";
            tbxRPassword.PasswordChar = '*';
            tbxRPassword.Size = new Size(354, 42);
            tbxRPassword.TabIndex = 27;
            tbxRPassword.TextChanged += tbx_TextChanged;
            // 
            // gbxPessoal
            // 
            gbxPessoal.Controls.Add(tbxEmail);
            gbxPessoal.Controls.Add(tbxName);
            gbxPessoal.Controls.Add(lblName);
            gbxPessoal.Controls.Add(lblEmail);
            gbxPessoal.Controls.Add(tbxPhone);
            gbxPessoal.Controls.Add(lblPhone);
            gbxPessoal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxPessoal.Location = new Point(53, 247);
            gbxPessoal.Margin = new Padding(3, 4, 3, 4);
            gbxPessoal.Name = "gbxPessoal";
            gbxPessoal.Padding = new Padding(3, 4, 3, 4);
            gbxPessoal.Size = new Size(427, 437);
            gbxPessoal.TabIndex = 29;
            gbxPessoal.TabStop = false;
            gbxPessoal.Text = "Informações Pessoais";
            // 
            // gbxSeguranca
            // 
            gbxSeguranca.Controls.Add(tbxRPassword);
            gbxSeguranca.Controls.Add(tbxPassword);
            gbxSeguranca.Controls.Add(lblRPassword);
            gbxSeguranca.Controls.Add(lblPassword);
            gbxSeguranca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxSeguranca.Location = new Point(506, 247);
            gbxSeguranca.Margin = new Padding(3, 4, 3, 4);
            gbxSeguranca.Name = "gbxSeguranca";
            gbxSeguranca.Padding = new Padding(3, 4, 3, 4);
            gbxSeguranca.Size = new Size(427, 323);
            gbxSeguranca.TabIndex = 30;
            gbxSeguranca.TabStop = false;
            gbxSeguranca.Text = "Segurança";
            // 
            // frmCadastrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 957);
            Controls.Add(gbxSeguranca);
            Controls.Add(gbxPessoal);
            Controls.Add(lblErebro);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSign);
            Controls.Add(lblPecado);
            Controls.Add(tbxPecado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            gbxPessoal.ResumeLayout(false);
            gbxPessoal.PerformLayout();
            gbxSeguranca.ResumeLayout(false);
            gbxSeguranca.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox tbxEmail;
        private Label lblName;
        private TextBox tbxName;
        private Label lblPecado;
        private TextBox tbxPecado;
        private Label lblPhone;
        private TextBox tbxPhone;
        private Label lblPassword;
        private TextBox tbxPassword;
        private Button btnCancel;
        private Button btnSign;
        private Label lblTitle;
        private Label lblErebro;
        private Label lblRPassword;
        private TextBox tbxRPassword;
        private GroupBox gbxPessoal;
        private GroupBox gbxSeguranca;
    }
}