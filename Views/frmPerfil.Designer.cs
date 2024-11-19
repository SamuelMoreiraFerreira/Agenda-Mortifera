namespace AgendaMortifera.Controllers
{
    partial class frmPerfil
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
            dgvCategorias = new DataGridView();
            btnRefreshCategorias = new Button();
            tbxAlterarSenha = new TextBox();
            gbxSeguranca = new GroupBox();
            btnConfirmarSenha = new Button();
            label1 = new Label();
            btnAdicionarCategoria = new Button();
            btnEditarCategoria = new Button();
            btnExcluirCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            gbxSeguranca.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeight = 25;
            dgvCategorias.Location = new Point(12, 57);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(281, 183);
            dgvCategorias.TabIndex = 2;
            // 
            // btnRefreshCategorias
            // 
            btnRefreshCategorias.Location = new Point(12, 12);
            btnRefreshCategorias.Name = "btnRefreshCategorias";
            btnRefreshCategorias.Size = new Size(281, 39);
            btnRefreshCategorias.TabIndex = 3;
            btnRefreshCategorias.Text = "Atualizar";
            btnRefreshCategorias.UseVisualStyleBackColor = true;
            btnRefreshCategorias.Click += AtualizarDgvCategorias;
            // 
            // tbxAlterarSenha
            // 
            tbxAlterarSenha.Location = new Point(17, 48);
            tbxAlterarSenha.Name = "tbxAlterarSenha";
            tbxAlterarSenha.Size = new Size(205, 23);
            tbxAlterarSenha.TabIndex = 6;
            tbxAlterarSenha.TextChanged += tbxAlterarSenha_TextChanged;
            // 
            // gbxSeguranca
            // 
            gbxSeguranca.Controls.Add(btnConfirmarSenha);
            gbxSeguranca.Controls.Add(label1);
            gbxSeguranca.Controls.Add(tbxAlterarSenha);
            gbxSeguranca.Location = new Point(550, 12);
            gbxSeguranca.Name = "gbxSeguranca";
            gbxSeguranca.Size = new Size(238, 116);
            gbxSeguranca.TabIndex = 7;
            gbxSeguranca.TabStop = false;
            gbxSeguranca.Text = "Privacidade e Segurança";
            // 
            // btnConfirmarSenha
            // 
            btnConfirmarSenha.Enabled = false;
            btnConfirmarSenha.Location = new Point(17, 78);
            btnConfirmarSenha.Name = "btnConfirmarSenha";
            btnConfirmarSenha.Size = new Size(205, 23);
            btnConfirmarSenha.TabIndex = 8;
            btnConfirmarSenha.Text = "Confirmar";
            btnConfirmarSenha.UseVisualStyleBackColor = true;
            btnConfirmarSenha.Click += btnConfirmarSenha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 7;
            label1.Text = "Alterar Senha";
            // 
            // btnAdicionarCategoria
            // 
            btnAdicionarCategoria.Location = new Point(12, 246);
            btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            btnAdicionarCategoria.Size = new Size(89, 89);
            btnAdicionarCategoria.TabIndex = 8;
            btnAdicionarCategoria.Text = "ADD";
            btnAdicionarCategoria.UseVisualStyleBackColor = true;
            btnAdicionarCategoria.Click += btnAdicionarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Location = new Point(107, 246);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(89, 89);
            btnEditarCategoria.TabIndex = 9;
            btnEditarCategoria.Text = "EDITAR";
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnExcluirCategoria
            // 
            btnExcluirCategoria.Location = new Point(204, 246);
            btnExcluirCategoria.Name = "btnExcluirCategoria";
            btnExcluirCategoria.Size = new Size(89, 89);
            btnExcluirCategoria.TabIndex = 10;
            btnExcluirCategoria.Text = "EXCLUIR";
            btnExcluirCategoria.UseVisualStyleBackColor = true;
            btnExcluirCategoria.Click += btnExcluirCategoria_Click;
            // 
            // frmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 349);
            Controls.Add(btnExcluirCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnAdicionarCategoria);
            Controls.Add(gbxSeguranca);
            Controls.Add(btnRefreshCategorias);
            Controls.Add(dgvCategorias);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            gbxSeguranca.ResumeLayout(false);
            gbxSeguranca.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCategorias;
        private Button btnRefreshCategorias;
        private TextBox tbxAlterarSenha;
        private GroupBox gbxSeguranca;
        private Label label1;
        private Button btnConfirmarSenha;
        private Button btnAdicionarCategoria;
        private Button btnEditarCategoria;
        private Button btnExcluirCategoria;
    }
}