using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.Id, Codigo, Nombre, A.Descripcion, Precio, C.Descripcion CATEGORIA , M.Descripcion Marca, A.IdMarca, A.IdCategoria  From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria AND M.id = A.idMarca");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.ID = (int)datos.Lector["Id"];

                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];

                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["CATEGORIA"] is DBNull))
                        aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["CATEGORIA"];
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    if (!(datos.Lector["IdMarca"] is DBNull))
                        aux.Marca.ID = (int)datos.Lector["IdMarca"];
                    if (!(datos.Lector["IdCategoria"] is DBNull))
                        aux.Categoria.ID = (int)datos.Lector["IdCategoria"];
                    //if (!(datos.Lector["Imagen"] is DBNull))
                    //    aux.Imagen = new Imagen();
                    //aux.Imagen.ImagenUrl = (string)datos.Lector["Imagen"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
