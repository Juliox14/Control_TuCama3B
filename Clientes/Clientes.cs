using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using Proyecto___Concentraciones_de_Alcohol.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Concentraciones_de_Alcohol
{
    public partial class Clientes : Form
    {
        private bool datosSonValidos;
        private List<Cliente> mClientes;
        private ClientesConsultas mClientesConsultas;
        private Cliente mCliente;
        private Arduino.ConexionArduino mArduino;
        private Form1 mForm1;
        public Clientes()
        {
            InitializeComponent();
            
            mClientes = new List<Cliente>();
            mClientesConsultas = new ClientesConsultas();
            mCliente = new Cliente();   
            mArduino = new Arduino.ConexionArduino();
            mForm1 = new Form1();
            cargarClientes();
            datosSonValidos = false;
        }

        private void cargarClientes(string filtro = "")
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Refresh();
            mClientes.Clear();
            mClientes = mClientesConsultas.getClientes(filtro);

            for (int i = 0; i < mClientes.Count(); i++)
            {
                dgvClientes.RowTemplate.Height = 50;
                dgvClientes.Rows.Add(
                 mClientes[i].id_cliente,
                 mClientes[i].nombre,
                 mClientes[i].apellido,
                 mClientes[i].telefono,
                 mClientes[i].direccion);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageAgregarCliente;
            
        }

        private void LimpiarCampos()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbTelefono.Text = "";
            tbDireccion.Text = "";

        }

        private void cargarDatosClientes()
        {
                mCliente.nombre = tbNombre.Text.Trim();
                mCliente.apellido = tbApellido.Text.Trim();
                mCliente.telefono = Int64.Parse(tbTelefono.Text.Trim());
                mCliente.direccion = tbDireccion.Text.Trim();

        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarClientes(tbBuscar.Text.Trim());
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Ingrese el valor de cualquier campo por el que desea filtrar\nlos resultados (ID, Nombre, Apellido, Telefono o Direccion).", pbInfoBuscar, 0, pbInfoBuscar.Height);
        }

        private void pbInfoBuscar_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(pbInfoBuscar);
        }

        private bool datosCorrectos()
        {
            if (tbNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese un nombre");
                return false;
            }

            if (tbApellido.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese un apellido");
                return false;
            }
            
            return true;
            
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(tbTelefono.Text != null)
            {

            
                // Permitir la tecla de retroceso sin texto
                if (e.KeyChar == 8 && tbTelefono.Text.Length == 0)
                {
                    return;
                }

                // Verifica si la tecla presionada no es un número o la tecla de retroceso
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    // Si no es un número ni la tecla de retroceso, ignora la entrada
                    e.Handled = true;
                }

                // Verifica la longitud total del texto en el TextBox
                if (tbTelefono.Text.Length >= 10 && e.KeyChar != 8)
                {
                    // Si ya hay 10 dígitos y la tecla presionada no es una tecla de retroceso, ignora la entrada
                    e.Handled = true;
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si los datos son válidos antes de intentar guardar
            if (datosSonValidos)
            {
                cargarDatosClientes();

                if (mClientesConsultas.agregarClientes(mCliente))
                {
                    MessageBox.Show("Cliente añadido con éxito");
                    cargarClientes();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Los datos aún no han sido validados. Presiona el botón 'Validar' primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Obtener el id_cliente de la fila seleccionada
                int id_cliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Idcliente"].Value);
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar a este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Llamar al método de borrado con el id_cliente
                    mClientesConsultas.BorrarRegistroEnBaseDeDatos(id_cliente);

                    // Volver a cargar los datos en el DataGridView
                    cargarClientes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para borrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                if (row.Cells["Idcliente"].Value != null) // Asegurarse de que la celda de ID no sea nula
                {
                    int id_cliente = Convert.ToInt32(row.Cells["Idcliente"].Value);
                    string nombre = Convert.ToString(row.Cells["nombrecliente"].Value);
                    string apellido = Convert.ToString(row.Cells["apellidocliente"].Value);
                    string telefono = Convert.ToString(row.Cells["telefonocliente"].Value);
                    string direccion = Convert.ToString(row.Cells["direccioncliente"].Value);

                    mClientesConsultas.ActualizarRegistroEnBaseDeDatos(id_cliente, nombre, apellido, telefono, direccion);
                }
            }

            MessageBox.Show("Cambios confirmados", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        
        }
        private void EnviarMensajeArduino(string mensaje)
        {
            if (!mArduino.ArduinoPort.IsOpen)
            {
                mArduino.ArduinoPort.Open();
            }

            if (mArduino != null && mArduino.ArduinoPort.IsOpen)
            {
                mArduino.ArduinoPort.Write(mensaje);
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Realizar todas las validaciones necesarias
            if (datosCorrectos())
            {
                // Cambiar el estado del booleano a verdadero
                datosSonValidos = true;

                // Habilitar el botón de guardar
                btnGuardar.Enabled = true;

                // Enviar mensaje "1" a Arduino
                EnviarMensajeArduino("1");
               
            }
            else
            {
                // Cambiar el estado del booleano a falso
                datosSonValidos = false;

                // Deshabilitar el botón de guardar
                btnGuardar.Enabled = false;
                
                // Enviar mensaje "0" a Arduino
                EnviarMensajeArduino("0");
            }
        }

        private void Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            mArduino.ArduinoPort.Close();
        }

        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            mArduino.ArduinoPort.Close();
        }
    }
}
