using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Concentraciones_de_Alcohol
{
    internal class ClientesConsultas
    {
        private ConexionMySql conexionMySql;
        private List<Cliente> mClientes;

        public ClientesConsultas()
        {
            conexionMySql = new ConexionMySql();
            mClientes = new List<Cliente>();
        }

        public List<Cliente> getClientes(string filtro)
        {
            string QUERY = "SELECT * FROM clientes ";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += "WHERE " +
                        "id_cliente LIKE '%" + filtro + "%' OR " +
                        "nombre LIKE '%" + filtro + "%' OR " +
                        "apellido LIKE '%" + filtro + "%' OR " +
                        "telefono LIKE '%" + filtro + "%' OR " +
                        "direccion LIKE '%" + filtro + "%';";

                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.GetConnection();
                mReader = mComando.ExecuteReader();

                Cliente mCliente = null;
                while (mReader.Read())
                {
                    mCliente = new Cliente();
                    mCliente.id_cliente = mReader.GetInt16("id_cliente");
                    mCliente.nombre = mReader.GetString("nombre");
                    mCliente.apellido = mReader.GetString("apellido");
                    mCliente.telefono = mReader.GetInt64("telefono");
                    mCliente.direccion = mReader.GetString("direccion");
                    mClientes.Add(mCliente);

                }

                mReader.Close();
            }
            catch (Exception )
            {
                throw;
            }
            return mClientes;
        }

        internal bool agregarClientes(Cliente mCliente)
        {
            string INSERT = "INSERT INTO clientes (nombre, apellido, telefono, direccion) VALUES (@nombre, @apellido, @telefono, @direccion)";

            MySqlCommand mCommand= new MySqlCommand(INSERT, conexionMySql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@nombre", mCliente.nombre));
            mCommand.Parameters.Add(new MySqlParameter("@apellido", mCliente.apellido));
            mCommand.Parameters.Add(new MySqlParameter("@telefono", mCliente.telefono));
            mCommand.Parameters.Add(new MySqlParameter("@direccion", mCliente.direccion));

            return mCommand.ExecuteNonQuery() > 0;
        }

        internal void ActualizarRegistroEnBaseDeDatos(int id_cliente, string nombre, string apellido, string telefono, string direccion)
        {
            string consulta = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, telefono = @telefono, direccion = @direccion WHERE id_cliente = @id_cliente";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexionMySql.GetConnection()))
            {
                
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);

                try
                {
                    
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción, como problemas de conexión, aquí
                    MessageBox.Show("Error al actualizar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        internal void BorrarRegistroEnBaseDeDatos(int id_cliente)
        {
            string consulta = "DELETE FROM clientes WHERE id_cliente = @id_cliente";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexionMySql.GetConnection()))
            {
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);

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
