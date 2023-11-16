using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___Concentraciones_de_Alcohol.Productos
{
    internal class Producto
    {
        public int id_producto { get; set; }
        public string TipoCama { get; set; }
        public string Tamano { get; set; }
        public string Color { get; set; }
        public string Extras { get; set;}
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public byte[] Imagen { get; set; }



    }
}
