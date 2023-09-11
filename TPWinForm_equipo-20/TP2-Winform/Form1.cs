using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;


namespace TP2_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                // Establecer la consulta SQL antes de ejecutar la lectura
                accesoDatos.setearConsulta("SELECT 1");

                // Ejecutar la lectura para verificar la conexión
                accesoDatos.ejecutarLectura();

                // Si la conexión es exitosa, establecer el texto en "Conexión exitosa"
                txtconex.Text = "Conexión exitosa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
