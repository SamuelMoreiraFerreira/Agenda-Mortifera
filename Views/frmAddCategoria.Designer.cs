﻿namespace AgendaMortifera.Views
{
    partial class frmAddCategoria
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
            tbxNomeCategoria = new TextBox();
            btnAddCategoria = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // tbxNomeCategoria
            // 
            tbxNomeCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNomeCategoria.Location = new Point(12, 21);
            tbxNomeCategoria.Name = "tbxNomeCategoria";
            tbxNomeCategoria.PlaceholderText = " Nome da Categoria";
            tbxNomeCategoria.Size = new Size(403, 33);
            tbxNomeCategoria.TabIndex = 1;
            // 
            // btnAddCategoria
            // 
            btnAddCategoria.BackColor = Color.IndianRed;
            btnAddCategoria.FlatStyle = FlatStyle.Popup;
            btnAddCategoria.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategoria.ForeColor = Color.White;
            btnAddCategoria.Location = new Point(12, 72);
            btnAddCategoria.Name = "btnAddCategoria";
            btnAddCategoria.Size = new Size(403, 48);
            btnAddCategoria.TabIndex = 2;
            btnAddCategoria.Text = "ADICIONAR CATEGORIA";
            btnAddCategoria.UseVisualStyleBackColor = false;
            btnAddCategoria.Click += btnAddCategoria_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Control;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(12, 126);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(403, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmAddCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(427, 173);
            Controls.Add(btnCancelar);
            Controls.Add(btnAddCategoria);
            Controls.Add(tbxNomeCategoria);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAddCategoria";
            Text = "Adicionar Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbxNomeCategoria;
        private Button btnAddCategoria;
        private Button btnCancelar;
    }
}