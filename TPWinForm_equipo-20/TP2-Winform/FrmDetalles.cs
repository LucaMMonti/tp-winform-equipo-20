using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Winform
{
    public partial class FrmDetalles : Form
    {
        private Articulo articulo = null;
        public FrmDetalles()
        {
            InitializeComponent();
        }
        public FrmDetalles(Articulo articulo)
        {
            this.InitializeComponent();
            this.articulo=articulo;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Frm_Detalles_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriasNegocio = new CategoriaNegocio();
            MarcaNegocio marcasNegocio = new MarcaNegocio();
            try
            {

                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtMarca.Text = articulo.Marca.Descripcion;
                txtCategoria.Text = articulo.Categoria.Descripcion;
                txtPrecio.Text = articulo.Precio.ToString();
                pbxArticulo.Load(articulo.Imagen);


            }
            catch (System.Net.WebException ex)
            {

                pbxArticulo.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png?w=640");
            }
            catch (FileNotFoundException ex)
            {
                pbxArticulo.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png?w=640");
            }
        }
    }
}

