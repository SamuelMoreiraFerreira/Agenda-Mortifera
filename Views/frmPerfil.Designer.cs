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
            btnRefresh = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
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
            lblUsuario.Location = new Point(212, 203);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(75, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "HAHAHAHA";
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(418, 131);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(281, 183);
            dgvCategorias.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(418, 320);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(281, 39);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Atualizar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // frmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(dgvCategorias);
            Controls.Add(lblUsuario);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPerfil";
            Text = "Dashboard";
            Load += frmPerfil_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
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
        private Button btnRefresh;
    }
}