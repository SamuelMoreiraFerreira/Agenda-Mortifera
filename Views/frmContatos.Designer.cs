namespace AgendaMortifera.Views
{
    partial class frmContatos
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
            dgvContatos = new DataGridView();
            dgvTelefonesContatos = new DataGridView();
            lblTitleDgvContatos = new Label();
            lblTitleDgvTelefonesContato = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTelefonesContatos).BeginInit();
            SuspendLayout();
            // 
            // dgvContatos
            // 
            dgvContatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContatos.ColumnHeadersHeight = 25;
            dgvContatos.Location = new Point(12, 42);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.ReadOnly = true;
            dgvContatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.Size = new Size(368, 265);
            dgvContatos.TabIndex = 3;
            // 
            // dgvTelefonesContatos
            // 
            dgvTelefonesContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTelefonesContatos.Location = new Point(12, 343);
            dgvTelefonesContatos.Name = "dgvTelefonesContatos";
            dgvTelefonesContatos.Size = new Size(368, 152);
            dgvTelefonesContatos.TabIndex = 5;
            // 
            // lblTitleDgvContatos
            // 
            lblTitleDgvContatos.AutoSize = true;
            lblTitleDgvContatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleDgvContatos.ForeColor = Color.White;
            lblTitleDgvContatos.Location = new Point(140, 9);
            lblTitleDgvContatos.Name = "lblTitleDgvContatos";
            lblTitleDgvContatos.Size = new Size(101, 30);
            lblTitleDgvContatos.TabIndex = 6;
            lblTitleDgvContatos.Text = "Contatos";
            // 
            // lblTitleDgvTelefonesContato
            // 
            lblTitleDgvTelefonesContato.AutoSize = true;
            lblTitleDgvTelefonesContato.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleDgvTelefonesContato.ForeColor = Color.White;
            lblTitleDgvTelefonesContato.Location = new Point(86, 310);
            lblTitleDgvTelefonesContato.Name = "lblTitleDgvTelefonesContato";
            lblTitleDgvTelefonesContato.Size = new Size(222, 30);
            lblTitleDgvTelefonesContato.TabIndex = 7;
            lblTitleDgvTelefonesContato.Text = "Telefones do Contato";
            // 
            // frmContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 507);
            Controls.Add(lblTitleDgvTelefonesContato);
            Controls.Add(lblTitleDgvContatos);
            Controls.Add(dgvTelefonesContatos);
            Controls.Add(dgvContatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmContatos";
            Text = "frmContatos";
            Load += frmContatos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTelefonesContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContatos;
        private DataGridView dgvTelefonesContatos;
        private Label lblTitleDgvContatos;
        private Label lblTitleDgvTelefonesContato;
    }
}