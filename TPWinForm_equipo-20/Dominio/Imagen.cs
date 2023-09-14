using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int ID { get; set; }
        public Articulo articulo { get; set; }
        public string ImagenURL { get; set; }

    }
}