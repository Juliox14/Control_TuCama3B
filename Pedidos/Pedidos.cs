using Proyecto___Concentraciones_de_Alcohol.Pedidos;
using Proyecto___Concentraciones_de_Alcohol.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Concentraciones_de_Alcohol.Ventas
{
    public partial class Pedidos : Form
    {
        private bool datosSonValidos;
        private List<Pedido> mPedidos;
        private PedidosConsultas mPedidosConsultas;
        private Pedido mPedido;
        private Arduino.ConexionArduino mArduino;
        
        public Pedidos()
        {
            InitializeComponent();
            dtpFechaPedido.Format = DateTimePickerFormat.Custom;
            dtpFechaPedido.CustomFormat = "yyyy-MM-dd";
            dtpFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpFechaEntrega.CustomFormat = "yyyy-MM-dd";

            mPedidos = new List<Pedido>();
            mPedidosConsultas = new PedidosConsultas();
            mPedido = new Pedido();
            mArduino = new Arduino.ConexionArduino();
            datosSonValidos = false;
            cargarPedidos();
            
        }

        private void cargarPedidos(string filtro = "")
        {
            dgvPedidos.Rows.Clear();
            dgvPedidos.Refresh();
            mPedidos.Clear();
            mPedidos = mPedidosConsultas.getPedidos(filtro);

            for (int i = 0; i < mPedidos.Count(); i++)
            {
                dgvPedidos.RowTemplate.Height = 50;
                dgvPedidos.Rows.Add(
                 mPedidos[i].id_pedido,
                 mPedidos[i].clientes_id_cliente,
                 mPedidos[i].productos_id_producto,
                 mPedidos[i].TipoPago,
                 DateTime.Parse(mPedidos[i].FechaPedido).ToString("yyyy-MM-dd"),
                 DateTime.Parse(mPedidos[i].FechaEntrega).ToString("yyyy-MM-dd"),
                 mPedidos[i].EstatusPago,
                 mPedidos[i].Observaciones);
            }
        }

        private bool datosCorrectos()
        {
            if (tbIdProducto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese un Id producto");
                return false;
            }

            if (tbIdCliente.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese un Id cliente");
                return false;
            }
            
            if (!rbtnContado.Checked && !rbtnCredito.Checked)
            {
                MessageBox.Show("Seleccione un tipo de pago");
                return false;
            }

            if (dtpFechaPedido.ToString() == "")
            {
                MessageBox.Show("Ingrese la fecha del pedido");
                return false;
            }

            if (!rbtnPendiente.Checked && !rbtnPagado.Checked)
            {
                MessageBox.Show("Seleccione un estado de pago");
                return false;
            }
            return true;
        }

        
        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            cargarPedidos(tbBuscar.Text.Trim());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!datosCorrectos())
            {
                return;
            }

            cargarPedidosDatos();

            if(mPedidosConsultas.agregarPedido(mPedido))
            {
                MessageBox.Show("Pedido añadido con éxito");
                cargarPedidos();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            tbIdCliente.Text = string.Empty;
            tbIdProducto.Text = string.Empty;

            rbtnContado.Checked = false;
            rbtnCredito.Checked = false;

            // Asigna la fecha actual o una fecha predeterminada si es necesario
            dtpFechaPedido.Value = DateTime.Now;
            dtpFechaEntrega.Value = DateTime.Now;

            rbtnPagado.Checked = false;
            rbtnPendiente.Checked = false;

            tbObservaciones.Text = string.Empty;
        }

        private string tipopagostring;
        private string estatuspagostring;
        private void cargarPedidosDatos()
        {
            mPedido.clientes_id_cliente = int.Parse(tbIdCliente.Text.Trim());
            mPedido.productos_id_producto = int.Parse(tbIdProducto.Text.Trim());

            if (rbtnContado.Checked)
            {
                tipopagostring = "Contado";
            }
            if (rbtnCredito.Checked)
            {
                tipopagostring = "Crédito";
            }

            mPedido.TipoPago = tipopagostring;

            // Formatear las fechas aquí
            mPedido.FechaPedido = dtpFechaPedido.Value.ToString("yyyy-MM-dd");
            mPedido.FechaEntrega = dtpFechaEntrega.Value.ToString("yyyy-MM-dd");

            if (rbtnPagado.Checked)
            {
                estatuspagostring = "Pagado";
            }
            if (rbtnPendiente.Checked)
            {
                estatuspagostring = "Pendiente";
            }
            mPedido.EstatusPago = estatuspagostring;
            mPedido.Observaciones = tbObservaciones.Text.Trim();

        }

        private void rbtnContado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnContado.Checked)
            {
                rbtnCredito.Checked = false; 
            }
        }

        private void rbtnCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCredito.Checked)
            {
                rbtnContado.Checked = false; // Desmarca rbtnContado si rbtnCredito está seleccionado
            }
        }

        private void rbtnPagado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPagado.Checked)
            {
                rbtnPendiente.Checked = false; // Desmarca rbtnContado si rbtnCredito está seleccionado
            }
        }

        private void rbtnPendiente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPendiente.Checked)
            {
                rbtnPagado.Checked = false; // Desmarca rbtnContado si rbtnCredito está seleccionado
            }
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPedidos.Rows)
            {
                int id_pedido = Convert.ToInt32(row.Cells["IdPedido"].Value);
                int clientes_id_cliente = Convert.ToInt32(row.Cells["ClientesIdCliente"].Value);
                int productos_id_producto = Convert.ToInt32(row.Cells["ProductosIdProducto"].Value);
                string tipo_pago = Convert.ToString(row.Cells["TipoPago"].Value);
                DateTime fecha_pedido = Convert.ToDateTime(row.Cells["FechaPedido"].Value);
                DateTime? fecha_entrega = (row.Cells["FechaEntrega"].Value != DBNull.Value) ? Convert.ToDateTime(row.Cells["FechaEntrega"].Value) : (DateTime?)null;
                string estatus_pago = Convert.ToString(row.Cells["EstatusPago"].Value);
                string observaciones = Convert.ToString(row.Cells["Observaciones"].Value);

                mPedidosConsultas.ActualizarPedidoEnBaseDeDatos(id_pedido, clientes_id_cliente, productos_id_producto, tipo_pago, fecha_pedido, fecha_entrega, estatus_pago, observaciones);
            }

            // Limpiar el contenedor de celdas editadas en el DataGridView
            dgvPedidos.EndEdit();
            dgvPedidos.ClearSelection();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPedidos.SelectedRows[0];
                int id_pedido = Convert.ToInt32(selectedRow.Cells["IdPedido"].Value);

                // Pregunta al usuario para confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este pedido?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Llama al método para borrar el registro en la base de datos
                    mPedidosConsultas.BorrarRegistroEnBaseDeDatos(id_pedido);

                    // Elimina la fila seleccionada del DataGridView
                    dgvPedidos.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un pedido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControlVentas.SelectedTab = tabPageRegistrarVenta;
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

        private void Pedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            mArduino.ArduinoPort.Close();
        }

        private void Pedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            mArduino.ArduinoPort.Close();
        }
    }
}

