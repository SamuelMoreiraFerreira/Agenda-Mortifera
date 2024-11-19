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
            menuStrip1 = new MenuStrip();
            editarToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            lblUsuario = new Label();
            dgvCategorias = new DataGridView();
            btnRefreshCategorias = new Button();
            dgvUsuarios = new DataGridView();
            btnRefreshUsers = new Button();
            tbxAlterarSenha = new TextBox();
            gbxSeguranca = new GroupBox();
            btnConfirmarSenha = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            gbxSeguranca.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, removerToolStripMenuItem });
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(130, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(125, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += AdicionarCategoria;
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(125, 22);
            removerToolStripMenuItem.Text = "Remover";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(82, 100);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(165, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "ESQUECI AQUI... NÃO MEXER!";
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(419, 186);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(281, 183);
            dgvCategorias.TabIndex = 2;
            dgvCategorias.UserDeletingRow += dgvCategorias_UserDeletingRow;
            // 
            // btnRefreshCategorias
            // 
            btnRefreshCategorias.Location = new Point(419, 375);
            btnRefreshCategorias.Name = "btnRefreshCategorias";
            btnRefreshCategorias.Size = new Size(281, 39);
            btnRefreshCategorias.TabIndex = 3;
            btnRefreshCategorias.Text = "Atualizar";
            btnRefreshCategorias.UseVisualStyleBackColor = true;
            btnRefreshCategorias.Click += btnRefreshCategorias_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(31, 131);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(281, 183);
            dgvUsuarios.TabIndex = 4;
            dgvUsuarios.UserDeletingRow += dgvUsuarios_UserDeletingRow;
            // 
            // btnRefreshUsers
            // 
            btnRefreshUsers.Location = new Point(31, 320);
            btnRefreshUsers.Name = "btnRefreshUsers";
            btnRefreshUsers.Size = new Size(281, 39);
            btnRefreshUsers.TabIndex = 5;
            btnRefreshUsers.Text = "Atualizar";
            btnRefreshUsers.UseVisualStyleBackColor = true;
            btnRefreshUsers.Click += btnRefreshUsers_Click;
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
            gbxSeguranca.Location = new Point(419, 53);
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
            // frmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxSeguranca);
            Controls.Add(btnRefreshUsers);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnRefreshCategorias);
            Controls.Add(dgvCategorias);
            Controls.Add(lblUsuario);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += frmPerfil_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            gbxSeguranca.ResumeLayout(false);
            gbxSeguranca.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
        private Label lblUsuario;
        private DataGridView dgvCategorias;
        private Button btnRefreshCategorias;
        private DataGridView dgvUsuarios;
        private Button btnRefreshUsers;
        private TextBox tbxAlterarSenha;
        private GroupBox gbxSeguranca;
        private Label label1;
        private Button btnConfirmarSenha;
    }
}