﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Winform
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmGestion nuevaVentana = new FrmGestion();
            nuevaVentana.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmGestion nuevaVentana = new FrmGestion();
            nuevaVentana.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            FrmDetalles nuevaVentana = new FrmDetalles();
            nuevaVentana.ShowDialog();
        }
    }
}
