using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___Concentraciones_de_Alcohol.Pedidos
{
    internal class Pedido
    {
        public int id_pedido { get; set; }

        public int clientes_id_cliente { get; set; }

        public int productos_id_producto { get; set; }

        public string TipoPago { get; set; }

        public string FechaPedido { get; set; }

        public string FechaEntrega { get; set; }

        public string EstatusPago {  get; set; }

        public string Observaciones {  get; set; }

    }
}
