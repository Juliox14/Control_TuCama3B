using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Proyecto___Concentraciones_de_Alcohol.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Concentraciones_de_Alcohol.Pedidos
{

    internal class PedidosConsultas
    {
        private ConexionMySql conexionMySql;
        private List<Pedido> mPedidos;


        public PedidosConsultas()
        {
            conexionMySql = new ConexionMySql();
            mPedidos = new List<Pedido>();
        }

        public List<Pedido> getPedidos(string filtro)
        {
            string QUERY = "SELECT * FROM pedidos ";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += "WHERE " +
                        "id_pedido LIKE '%" + filtro + "%' OR " +
                        "clientes_id_cliente LIKE '%" + filtro + "%' OR " +
                        "productos_id_producto LIKE '%" + filtro + "%' OR " +
                        "tipo_pago LIKE '%" + filtro + "%' OR " +
                        "fecha_pedido LIKE '%" + filtro + "%' OR " +
                        "fecha_entrega LIKE '%" + filtro + "%' OR " +
                        "estatus_pago LIKE '%" + filtro + "%' OR " +
                        "observaciones LIKE '%" + filtro + "%';";

                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.GetConnection();
                mReader = mComando.ExecuteReader();

                Pedido mPedido = null;
                while (mReader.Read())
                {
                    mPedido = new Pedido();
                    mPedido.id_pedido = mReader.GetInt16("id_pedido");
                    mPedido.clientes_id_cliente = mReader.GetInt16("clientes_id_cliente");
                    mPedido.productos_id_producto = mReader.GetInt16("productos_id_producto");
                    mPedido.TipoPago = mReader.IsDBNull(mReader.GetOrdinal("tipo_pago")) ? string.Empty : mReader.GetString("tipo_pago");
                    mPedido.FechaPedido = mReader.IsDBNull(mReader.GetOrdinal("fecha_pedido")) ? string.Empty : mReader.GetString("fecha_pedido");
                    mPedido.FechaEntrega = mReader.IsDBNull(mReader.GetOrdinal("fecha_entrega")) ? string.Empty : mReader.GetString("fecha_entrega");
                    mPedido.EstatusPago = mReader.IsDBNull(mReader.GetOrdinal("estatus_pago")) ? string.Empty : mReader.GetString("estatus_pago");
                    mPedido.Observaciones = mReader.IsDBNull(mReader.GetOrdinal("observaciones")) ? string.Empty : mReader.GetString("observaciones");
                    mPedidos.Add(mPedido);

                }

                mReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return mPedidos;
        }


        internal bool agregarPedido(Pedido mPedido)
        {
            string INSERT = "INSERT INTO pedidos (clientes_id_cliente, productos_id_producto, tipo_pago, fecha_pedido, fecha_entrega, estatus_pago, observaciones) " +
                "VALUES (@clientes_id_cliente, @productos_id_producto, @tipo_pago, @fecha_pedido, @fecha_entrega, @estatus_pago, @observaciones)";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@clientes_id_cliente", mPedido.clientes_id_cliente));
            mCommand.Parameters.Add(new MySqlParameter("@productos_id_producto", mPedido.productos_id_producto));
            mCommand.Parameters.Add(new MySqlParameter("@tipo_pago", mPedido.TipoPago));
            mCommand.Parameters.Add(new MySqlParameter("@fecha_pedido", mPedido.FechaPedido));
            mCommand.Parameters.Add(new MySqlParameter("@fecha_entrega", mPedido.FechaEntrega));
            mCommand.Parameters.Add(new MySqlParameter("@estatus_pago", mPedido.EstatusPago));
            mCommand.Parameters.Add(new MySqlParameter("@observaciones", mPedido.Observaciones));

            return mCommand.ExecuteNonQuery() > 0;
        }

        public void ActualizarPedidoEnBaseDeDatos(int id_pedido, int clientes_id_cliente, int productos_id_producto, string tipo_pago, DateTime fecha_pedido, DateTime? fecha_entrega, string estatus_pago, string observaciones)
        {
            string consulta = "UPDATE pedidos SET clientes_id_cliente = @clientes_id_cliente, productos_id_producto = @productos_id_producto, tipo_pago = @tipo_pago, fecha_pedido = @fecha_pedido, fecha_entrega = @fecha_entrega, estatus_pago = @estatus_pago, observaciones = @observaciones WHERE id_pedido = @id_pedido";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexionMySql.GetConnection()))
            {
                comando.Parameters.AddWithValue("@clientes_id_cliente", clientes_id_cliente);
                comando.Parameters.AddWithValue("@productos_id_producto", productos_id_producto);
                comando.Parameters.AddWithValue("@tipo_pago", tipo_pago);
                comando.Parameters.AddWithValue("@fecha_pedido", fecha_pedido);
                comando.Parameters.AddWithValue("@fecha_entrega", (object)fecha_entrega ?? DBNull.Value); // Si fecha_entrega es null, usar DBNull.Value
                comando.Parameters.AddWithValue("@estatus_pago", estatus_pago);
                comando.Parameters.AddWithValue("@observaciones", observaciones);
                comando.Parameters.AddWithValue("@id_pedido", id_pedido);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        internal void BorrarRegistroEnBaseDeDatos(int id_pedido)
        {
            string consulta = "DELETE FROM pedidos WHERE id_pedido = @id_pedido";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexionMySql.GetConnection()))
            {
                comando.Parameters.AddWithValue("@id_pedido", id_pedido);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
