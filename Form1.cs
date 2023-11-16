using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Proyecto___Concentraciones_de_Alcohol.Ventas;
using Proyecto___Concentraciones_de_Alcohol.Pedidos;
using System.IO.Ports;




namespace Proyecto___Concentraciones_de_Alcohol
{
    public partial class Form1 : Form
    {
        private Form formActual;

        public Form1()
        {
            InitializeComponent();
            
            
        }
       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirformhije(new Productos.Productos());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
            abrirformhije(new Inicio());
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        Productos.Productos productos = new Productos.Productos();
        

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirformhije(new Ventas.Pedidos());

        }
        private void abrirformhije(object formhije)
        {
            // Cerrar el formulario hijo actual si existe
            if (formActual != null)
            {
                formActual.Close();
            }

            // Remover el formulario hijo actual del contenedor
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            // Mostrar el nuevo formulario hijo
            Form fh = formhije as Form;
            if (fh != null)
            {
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(fh);
                this.PanelContenedor.Tag = fh;
                fh.Show();

                // Almacenar una referencia al nuevo formulario actual
                formActual = fh;
            }
        }
        
        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirformhije(new Clientes());
        }

        Ventas.Pedidos ventas = new Ventas.Pedidos();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirformhije(new Inicio());
        }
    }
}
