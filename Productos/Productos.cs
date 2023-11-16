using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Concentraciones_de_Alcohol.Productos
{
    public partial class Productos : Form
    {
        
        private List<Producto> mProductos;
        private ProductosConsultas mProductosConsultas;
        private Producto mProducto;
        private bool datosSonValidos;
        private Arduino.ConexionArduino mArduino;
        public Productos()
        {
            InitializeComponent();
            mProductos = new List<Producto>();
            mProductosConsultas = new ProductosConsultas();
            mProducto = new Producto();
            mArduino = new Arduino.ConexionArduino();
            cargarProductos();
            datosSonValidos = false;
            

        }

        private void cargarProductos(string filtro = "")
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            mProductos.Clear();
            mProductos = mProductosConsultas.getProductos(filtro);

            for(int i = 0;i < mProductos.Count(); i++)
            {
                dgvProductos.RowTemplate.Height = 50;
                dgvProductos.Rows.Add(
                 mProductos[i].id_producto,
                 mProductos[i].TipoCama,
                 mProductos[i].Tamano,
                 mProductos[i].Color,
                 mProductos[i].Extras,
                 mProductos[i].Descripcion,
                 mProductos[i].Precio,
                 (mProductos[i].Imagen != null) ? Image.FromStream(new MemoryStream(mProductos[i].Imagen)) : null);
            }
        }

        public void CambiarPestaña(TabPage tabpage)
        {
            tabControlProductos.SelectedTab = tabpage;
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(tbBuscar.Text.Trim());
        }

        private bool datosCorrectos()
        {
            if (cbTipoCama.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de cama");
                return false;
            }

            if (cbColor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un color");
                return false;
            }

            if(!float.TryParse(tbPrecio.Text.Trim(), out float precio))
            {
                MessageBox.Show("Ingrese un precio válido");
                return false; 
            
            }
            
            return true;

        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número ni el punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                // Si no es un número ni el punto decimal ni la tecla de retroceso, ignorar la entrada
                e.Handled = true;
            }

            // Verificar si ya hay un punto decimal y la tecla presionada es otro punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                // Si ya hay un punto decimal, ignorar la entrada
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosProductos();

            if(mProductosConsultas.agregarProducto(mProducto))
            {
                MessageBox.Show("Producto agregado");
                cargarProductos();
                LimpiarCampos();
            }

            
        }

        private void LimpiarCampos()
        {
            cbTipoCama.SelectedItem = null;
            cbTamaño.SelectedItem = null;
            cbColor.SelectedItem = null;
            tbExtras.Text = "";
            tbDescripcion.Text = "";
            tbPrecio.Text = "";
            pbImagenProducto.Image = Proyecto___Concentraciones_de_Alcohol.Properties.Resources.AddImage;
        }

        private void cargarDatosProductos()
        {
            mProducto.TipoCama = cbTipoCama.SelectedItem.ToString();
            //Para Tipo de cama
            if (cbTamaño.SelectedItem.ToString() == "Individual")
            {
                mProducto.Tamano = "Individual";
            }
            mProducto.Color = cbColor.SelectedItem.ToString();
            mProducto.Extras = tbExtras.Text.Trim();
            mProducto.Descripcion = tbDescripcion.Text.Trim();
            mProducto.Precio = float.Parse(tbPrecio.Text.Trim());
            mProducto.Imagen = ImageToByteArray(pbImagenProducto.Image);
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }

        private void pbImagenProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                pbImagenProducto.ImageLocation = dlg.FileName;

            }
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                int idProducto = Convert.ToInt32(row.Cells["Idproducto"].Value);
                string tipoCama = Convert.ToString(row.Cells["TipoCamaProducto"].Value);
                string tamaño = Convert.ToString(row.Cells["TamañoProducto"].Value);
                string color = Convert.ToString(row.Cells["ColorProducto"].Value);
                string extras = Convert.ToString(row.Cells["ExtrasProducto"].Value);
                string descripcion = Convert.ToString(row.Cells["DescripcionProducto"].Value);
                float precio = Convert.ToSingle(row.Cells["PrecioProducto"].Value);

                mProductosConsultas.ActualizarProductoEnBaseDeDatos(idProducto, tipoCama, tamaño, color, extras, descripcion, precio);
            }

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                int idProducto = Convert.ToInt32(row.Cells["Idproducto"].Value); // Asegúrate de tener un nombre de columna adecuado para el ID
                Image imagen = (Image)row.Cells["ImagenProducto"].Value;
                byte[] imagenBytes = (imagen != null) ? ImageToByteArray(imagen) : null;

                // Actualizar la base de datos con idProducto e imagenBytes
                mProductosConsultas.ActualizarImagenEnBaseDeDatos(idProducto, imagenBytes);
            }

            // Limpiar el contenedor de celdas editadas en el DataGridView
            dgvProductos.EndEdit();
            dgvProductos.ClearSelection();
            MessageBox.Show("Datos actualizados con éxito");

        }
        private DataGridViewCellEventArgs cellEventArgs; // Declarar a nivel de clase para almacenar la información de la celda
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el doble clic ocurrió en la columna de la imagen
            if (e.ColumnIndex == dgvProductos.Columns["ImagenProducto"].Index && e.RowIndex >= 0)
            {
                cellEventArgs = e; // Almacenar la información de la celda
                AbrirDialogoImagen();
            }
        }

        private void AbrirDialogoImagen()
        {
            // Mostrar el cuadro de diálogo para seleccionar la imagen
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Obtener la imagen seleccionada y asignarla a la celda
                string imagePath = dlg.FileName;
                Image newImage = Image.FromFile(imagePath);

                // Asignar la nueva imagen a la celda en la vista (no en la base de datos aún)
                dgvProductos.Rows[cellEventArgs.RowIndex].Cells[cellEventArgs.ColumnIndex].Value = newImage;
            }
        }

        private void pbInfoImagen_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Click sobre la imágen para cargar imágen", pbInfoImagen, 0, pbInfoImagen.Height);
        }

        private void pbInfoImagen_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(pbInfoImagen);
        }

        private void pbInfoBuscar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Ingrese el valor de cualquier campo por el que desea filtrar\nlos resultados (ID, Tipo de cama, Tamaño, Color, Extras, Descripción o Precio).", pbInfoBuscar, 0, pbInfoBuscar.Height);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtener el id_cliente de la fila seleccionada
                int id_producto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Idproducto"].Value);

                // Pregunta al usuario para confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Llamar al método de borrado con el id_cliente
                    mProductosConsultas.BorrarRegistroEnBaseDeDatos(id_producto);

                    // Volver a cargar los datos en el DataGridView
                    cargarProductos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para borrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControlProductos.SelectedTab = tabPageAgregarProducto;

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

        private void Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            mArduino.ArduinoPort.Close();
        }

        private void Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            mArduino.ArduinoPort.Close();
        }
    }
}
