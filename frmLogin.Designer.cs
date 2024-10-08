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
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            tbxUser = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            btnSign = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(194, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Agenda Telefônica";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(422, 40);
            label1.Name = "label1";
            label1.Size = new Size(170, 37);
            label1.TabIndex = 1;
            label1.Text = "MORTÍFERA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(303, 420);
            label2.Name = "label2";
            label2.Size = new Size(190, 21);
            label2.TabIndex = 4;
            label2.Text = "Desenvolvido por Belzebu";
            // 
            // tbxUser
            // 
            tbxUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUser.Location = new Point(246, 173);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(310, 35);
            tbxUser.TabIndex = 5;
            tbxUser.TextChanged += tbx_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(246, 136);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 10;
            label4.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(246, 221);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 12;
            label3.Text = "Senha";
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(246, 258);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(310, 35);
            tbxPassword.TabIndex = 11;
            tbxPassword.TextChanged += tbx_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.IndianRed;
            btnLogin.Enabled = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(246, 325);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(149, 60);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.Transparent;
            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSign.ForeColor = Color.Black;
            btnSign.Location = new Point(407, 325);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(149, 60);
            btnSign.TabIndex = 14;
            btnSign.Text = "CADASTRAR";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += button2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.fire2;
            pictureBox4.Location = new Point(422, 80);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(170, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(btnSign);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(tbxPassword);
            Controls.Add(label4);
            Controls.Add(tbxUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label label2;
        private TextBox tbxUser;
        private Label label4;
        private Label label3;
        private TextBox tbxPassword;
        private Button btnLogin;
        private Button btnSign;
        private PictureBox pictureBox4;
    }
}
