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
                dgvArticulos.Columns["ID"].Visible = false;
                pbxArticulos.Load(listaArt[0].Imagenes[0].ImagenURL);
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
                dgvArticulos.Columns["ID"].Visible = false;
                pbxArticulos.Load(listaArt[0].Imagenes[0].ImagenURL);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmInicio.inicioAcceso = false;
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

        private int indiceImagenActual = 0;
        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            indiceImagenActual = 0;
            try
            {
                if (dgvArticulos.SelectedRows.Count != 0)
                {
                    Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    if (articulo.Imagenes.Count > 0)
                    {
                        pbxArticulos.Load(articulo.Imagenes[indiceImagenActual].ImagenURL);
                    }
                }
            }
            catch (System.Net.WebException ex)
            {

                pbxArticulos.Load("https://www.pillar.com.mx/img/categorias/no-disponible.jpg");
            }
            catch (FileNotFoundException ex)
            {
                pbxArticulos.Load("https://www.pillar.com.mx/img/categorias/no-disponible.jpg");
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnImgR_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            if (articulo.Imagenes.Count > 1)
            {
                try
                {
                    indiceImagenActual = (indiceImagenActual + 1) % articulo.Imagenes.Count;
                    pbxArticulos.Load(articulo.Imagenes[indiceImagenActual].ImagenURL);
                    
                }
                catch (Exception ex)
                {
                    indiceImagenActual = (indiceImagenActual - 1) % articulo.Imagenes.Count;
                    pbxArticulos.Load(articulo.Imagenes[indiceImagenActual].ImagenURL);
                }
                
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;

            if (filtro == "" || filtro.Length <= 2)
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaArt;
            }
            else
            {
                List<Articulo> listaFiltrada = listaArt.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Nombre.ToUpper().Contains(filtro.ToUpper()));
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
            }
        }
    }
}
