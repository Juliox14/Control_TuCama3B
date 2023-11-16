using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Concentraciones_de_Alcohol.Productos
{
    internal class ProductosConsultas
    {
        private ConexionMySql conexionMySql;
        private List<Producto> mProductos;

        public ProductosConsultas()
        {
            conexionMySql = new ConexionMySql();
            mProductos = new List<Producto>();
            
        }

        public List<Producto> getProductos(string filtro)
        {
            string QUERY = "SELECT * FROM productos ";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += "WHERE " +
                        "id_producto LIKE '%" + filtro + "%' OR " +
                        "tipo_cama LIKE '%" + filtro + "%' OR " +
                        "tamaño LIKE '%" + filtro + "%' OR " +
                        "color LIKE '%" + filtro + "%' OR " +
                        "extras LIKE '%" + filtro + "%' OR " +
                        "descripcion LIKE '%" + filtro + "%' OR " +
                        "precio LIKE '%" + filtro + "%';";

                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.GetConnection();
                mReader = mComando.ExecuteReader();

                Producto mProducto = null;
                while (mReader.Read())
                {
                    mProducto = new Producto();
                    mProducto.id_producto = mReader.IsDBNull(mReader.GetOrdinal("id_producto")) ? 0 : mReader.GetInt16("id_producto");
                    mProducto.TipoCama = mReader.IsDBNull(mReader.GetOrdinal("tipo_cama")) ? string.Empty : mReader.GetString("tipo_cama");
                    mProducto.Tamano = mReader.IsDBNull(mReader.GetOrdinal("tamaño")) ? string.Empty : mReader.GetString("tamaño");
                    mProducto.Color = mReader.IsDBNull(mReader.GetOrdinal("color")) ? string.Empty : mReader.GetString("color");
                    mProducto.Extras = mReader.IsDBNull(mReader.GetOrdinal("extras")) ? string.Empty : mReader.GetString("extras");
                    mProducto.Descripcion = mReader.IsDBNull(mReader.GetOrdinal("descripcion")) ? string.Empty : mReader.GetString("descripcion");
                    mProducto.Precio = mReader.IsDBNull(mReader.GetOrdinal("precio")) ? 0.0f : mReader.GetFloat("precio");
                    mProducto.Imagen = mReader.IsDBNull(mReader.GetOrdinal("imagen")) ? null : (byte[])mReader.GetValue(7);
                    mProductos.Add(mProducto);

                }
                mReader.Close();
            }
            catch (Exception) 
            {
                throw;
            }
            return mProductos;
        }

        internal bool agregarProducto(Producto mProducto)
        {
            string INSERT = "INSERT INTO productos (tipo_cama, tamaño, color, extras, descripcion, precio, imagen) " +
                "VALUES (@tipo_cama, @tamaño, @color, @extras, @descripcion, @precio, @imagen)";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@tipo_cama", mProducto.TipoCama));
            mCommand.Parameters.Add(new MySqlParameter("@tamaño", mProducto.Tamano));
            mCommand.Parameters.Add(new MySqlParameter("@color", mProducto.Color));
            mCommand.Parameters.Add(new MySqlParameter("@extras", mProducto.Extras));
            mCommand.Parameters.Add(new MySqlParameter("@descripcion", mProducto.Descripcion));
            mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.Precio));
            mCommand.Parameters.Add(new MySqlParameter("@imagen", mProducto.Imagen));

            return mCommand.ExecuteNonQuery() > 0;
        }

        public void ActualizarProductoEnBaseDeDatos(int id_producto, string tipo_cama, string tamaño, string color, string extras, string descripcion, float precio)
        {
            string consulta = "UPDATE productos SET tipo_cama = @tipo_cama, tamaño = @tamaño, color = @color, extras = @extras, descripcion = @descripcion, precio = @precio WHERE id_producto = @id_producto";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexionMySql.GetConnection()))
            {
                comando.Parameters.AddWithValue("@tipo_cama", tipo_cama);
                comando.Parameters.AddWithValue("@tamaño", tamaño);
                comando.Parameters.AddWithValue("@color", color);
                comando.Parameters.AddWithValue("@extras", extras);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@id_producto", id_producto);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Si la excepción es específicamente por truncamiento de datos, ignorarla
                    if (ex.Number != 1265)  // 1265 es el código de error para "Data truncated for column"
                    {
                        MessageBox.Show("Error al actualizar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void ActualizarImagenEnBaseDeDatos(int id_producto, byte[] nuevaImagen)
        {
            string consulta = "UPDATE productos SET imagen = @imagen WHERE id_producto = @id_producto";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexionMySql.GetConnection()))
            {
                comando.Parameters.AddWithValue("@imagen", (nuevaImagen != null) ? (object)nuevaImagen : DBNull.Value);
                comando.Parameters.AddWithValue("@id_producto", id_producto);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la imagen en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void BorrarRegistroEnBaseDeDatos(int id_producto)
        {
            string consulta = "DELETE FROM productos WHERE id_producto = @id_producto";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexionMySql.GetConnection()))
            {
                comando.Parameters.AddWithValue("@id_producto", id_producto);

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
