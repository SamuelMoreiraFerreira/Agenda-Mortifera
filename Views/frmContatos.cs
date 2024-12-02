﻿using AgendaMortifera.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMortifera.Views
{
    public partial class frmContatos : Form
    {
        public frmContatos()
        {
            InitializeComponent();
        }

        private void AtualizarDgvContatos()
        {
            dgvContatos.DataSource = new UserController().GetContatos();
        }

        private void frmContatos_Load(object sender, EventArgs e)
        {
            this.AtualizarDgvContatos();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.AtualizarDgvContatos();
        }
    }
}
