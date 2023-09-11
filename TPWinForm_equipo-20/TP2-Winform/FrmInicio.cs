using System;
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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FrmInfo nuevaVentana = new FrmInfo();
            nuevaVentana.ShowDialog();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            FrmPrincipal nuevaVentana = new FrmPrincipal();
            nuevaVentana.ShowDialog();  
        }
    }
}
