using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Concentraciones_de_Alcohol
{
    internal class ConexionMySql: Conexion
    {
        private MySqlConnection connection;
        private string cadenaConexion;
        



        public ConexionMySql() 
        {
            cadenaConexion = ("Server=" + server +"; Port=" + "3306; Database=" + database + "; Uid=" + user + ";Pwd=" + password + ";");

            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection GetConnection() 
        {
            try
            {
                if(connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return connection;
        }
    }
}
