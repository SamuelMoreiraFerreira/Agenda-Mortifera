namespace AgendaMortifera
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblTitle = new Label();
            lblMortifera = new Label();
            label2 = new Label();
            tbxUser = new TextBox();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            btnSign = new Button();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(172, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Agenda Telefônica";
            // 
            // lblMortifera
            // 
            lblMortifera.AutoSize = true;
            lblMortifera.BackColor = Color.Transparent;
            lblMortifera.Font = new Font("Yu Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMortifera.ForeColor = Color.White;
            lblMortifera.Location = new Point(399, 46);
            lblMortifera.Name = "lblMortifera";
            lblMortifera.Size = new Size(264, 52);
            lblMortifera.TabIndex = 1;
            lblMortifera.Text = "MORTÍFERA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(262, 12);
            label2.Name = "label2";
            label2.Size = new Size(298, 21);
            label2.TabIndex = 4;
            label2.Text = "Desenvolvido por Samuel Moreira Ferreira";
            // 
            // tbxUser
            // 
            tbxUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUser.Location = new Point(252, 148);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(310, 35);
            tbxUser.TabIndex = 5;
            tbxUser.TextChanged += tbx_TextChanged;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(252, 224);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(310, 35);
            tbxPassword.TabIndex = 11;
            tbxPassword.TextChanged += tbx_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Enabled = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.IndianRed;
            btnLogin.Location = new Point(336, 273);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(149, 47);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.Transparent;
            btnSign.Cursor = Cursors.Hand;
            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSign.ForeColor = Color.LightGray;
            btnSign.Location = new Point(317, 376);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(192, 40);
            btnSign.TabIndex = 14;
            btnSign.Text = "CADASTRAR";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += btnSign_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.fire2;
            pictureBox4.Location = new Point(-3, 376);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(804, 119);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(294, 338);
            label1.Name = "label1";
            label1.Size = new Size(231, 25);
            label1.TabIndex = 18;
            label1.Text = "Ainda está no purgatório?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(252, 124);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 19;
            label3.Text = "Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(252, 200);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 20;
            label4.Text = "Senha";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 483);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnSign);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUser);
            Controls.Add(label2);
            Controls.Add(lblMortifera);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefônica MORTÍFERA";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMortifera;
        private Label label2;
        private TextBox tbxUser;
        private TextBox tbxPassword;
        private Button btnLogin;
        private Button btnSign;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}
