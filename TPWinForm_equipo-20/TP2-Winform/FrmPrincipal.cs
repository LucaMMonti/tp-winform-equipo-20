using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using System.IO;

namespace TP2_Winform
{
    public partial class FrmPrincipal : Form
    {   
        private List<Articulo> listaArt;
        public FrmPrincipal()
        {
            InitializeComponent();
            Cargar();
        }
        public void Cargar() {
            
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArt = negocio.listar();
                dgvArticulos.DataSource = listaArt;
                dgvArticulos.Columns[0].Visible = false;
                dgvArticulos.Columns[7].Visible = false;
                pbxArticulos.Load(listaArt[0].Imagen);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void Cargar(object sender, EventArgs e)
        {

            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArt = negocio.listar();
                dgvArticulos.DataSource = listaArt;
                dgvArticulos.Columns[0].Visible = false;
                dgvArticulos.Columns[7].Visible = false;
                pbxArticulos.Load(listaArt[0].Imagen);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmGestion nuevaVentana = new FrmGestion();
            nuevaVentana.ShowDialog();       
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FrmGestion nuevaVentana = new FrmGestion(seleccionado);
 
            nuevaVentana.ShowDialog();
            Cargar(sender, e);
        }

        private void BtnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FrmDetalles nuevoVentana = new FrmDetalles(seleccionado);
            nuevoVentana.ShowDialog();
        }

        
        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.SelectedRows.Count != 0)
                {
                    Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    pbxArticulos.Load(articulo.Imagen);
                }
            }
            catch (System.Net.WebException ex)
            {

                pbxArticulos.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png?w=640");
            }
            catch (FileNotFoundException ex)
            {
                pbxArticulos.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png?w=640");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            try
            {
                if (MessageBox.Show("¿Está seguro que quiere eliminar este artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.ID);
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo eliminar" + ex.ToString());
            }
        }


    }
}
