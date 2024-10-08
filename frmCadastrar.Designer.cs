namespace AgendaMortifera
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblEmail.Location = new Point(38, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(68, 25);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "E-Mail";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEmail.Location = new Point(38, 217);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(310, 35);
            tbxEmail.TabIndex = 15;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblName.Location = new Point(38, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 25);
            lblName.TabIndex = 14;
            lblName.Text = "Nome";
            // 
            // tbxName
            // 
            tbxName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxName.Location = new Point(38, 132);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(310, 35);
            tbxName.TabIndex = 13;
            // 
            // lblPecado
            // 
            lblPecado.AutoSize = true;
            lblPecado.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPecado.ForeColor = Color.IndianRed;
            lblPecado.Location = new Point(38, 352);
            lblPecado.Name = "lblPecado";
            lblPecado.Size = new Size(89, 25);
            lblPecado.TabIndex = 20;
            lblPecado.Text = "PECADO";
            // 
            // tbxPecado
            // 
            tbxPecado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPecado.Location = new Point(38, 389);
            tbxPecado.Name = "tbxPecado";
            tbxPecado.Size = new Size(310, 35);
            tbxPecado.TabIndex = 19;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblPhone.Location = new Point(38, 267);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(87, 25);
            lblPhone.TabIndex = 18;
            lblPhone.Text = "Telefone";
            // 
            // tbxPhone
            // 
            tbxPhone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPhone.Location = new Point(38, 304);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(310, 35);
            tbxPhone.TabIndex = 17;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblPassword.Location = new Point(38, 442);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 25);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Senha";
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(38, 479);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(310, 35);
            tbxPassword.TabIndex = 21;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(199, 637);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 60);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.IndianRed;
            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSign.ForeColor = Color.White;
            btnSign.Location = new Point(38, 637);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(149, 60);
            btnSign.TabIndex = 23;
            btnSign.Text = "CADASTRAR";
            btnSign.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(164, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(184, 37);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Bem-vindo ao";
            // 
            // lblErebro
            // 
            lblErebro.AutoSize = true;
            lblErebro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErebro.ForeColor = Color.IndianRed;
            lblErebro.Location = new Point(337, 24);
            lblErebro.Name = "lblErebro";
            lblErebro.Size = new Size(118, 37);
            lblErebro.TabIndex = 26;
            lblErebro.Text = "ÉREBRO";
            // 
            // lblRPassword
            // 
            lblRPassword.AutoSize = true;
            lblRPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblRPassword.Location = new Point(38, 529);
            lblRPassword.Name = "lblRPassword";
            lblRPassword.Size = new Size(201, 25);
            lblRPassword.TabIndex = 28;
            lblRPassword.Text = "Confirme a sua senha";
            // 
            // tbxRPassword
            // 
            tbxRPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxRPassword.Location = new Point(38, 566);
            tbxRPassword.Name = "tbxRPassword";
            tbxRPassword.PasswordChar = '*';
            tbxRPassword.Size = new Size(310, 35);
            tbxRPassword.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.diabo;
            pictureBox1.Location = new Point(370, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 673);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // frmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 717);
            Controls.Add(lblRPassword);
            Controls.Add(tbxRPassword);
            Controls.Add(lblErebro);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSign);
            Controls.Add(lblPassword);
            Controls.Add(tbxPassword);
            Controls.Add(lblPecado);
            Controls.Add(tbxPecado);
            Controls.Add(lblPhone);
            Controls.Add(tbxPhone);
            Controls.Add(lblEmail);
            Controls.Add(tbxEmail);
            Controls.Add(lblName);
            Controls.Add(tbxName);
            Controls.Add(pictureBox1);
            Name = "frmCadastrar";
            Text = "frmCadastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}