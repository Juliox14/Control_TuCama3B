namespace Proyecto___Concentraciones_de_Alcohol.Ventas
{
    partial class Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloPedidos = new System.Windows.Forms.Label();
            this.tabControlVentas = new System.Windows.Forms.TabControl();
            this.tabPageListaVentas = new System.Windows.Forms.TabPage();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstatusPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarcliente = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConfirmarCambios = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tabPageRegistrarVenta = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnValidar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtnPagado = new System.Windows.Forms.RadioButton();
            this.lblEstatusPago = new System.Windows.Forms.Label();
            this.rbtnPendiente = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnCredito = new System.Windows.Forms.RadioButton();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.rbtnContado = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControlVentas.SuspendLayout();
            this.tabPageListaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabPageRegistrarVenta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lblTituloPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 41);
            this.panel1.TabIndex = 2;
            // 
            // lblTituloPedidos
            // 
            this.lblTituloPedidos.AutoSize = true;
            this.lblTituloPedidos.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPedidos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTituloPedidos.Location = new System.Drawing.Point(30, 9);
            this.lblTituloPedidos.Name = "lblTituloPedidos";
            this.lblTituloPedidos.Size = new System.Drawing.Size(80, 22);
            this.lblTituloPedidos.TabIndex = 0;
            this.lblTituloPedidos.Text = "Pedidos";
            // 
            // tabControlVentas
            // 
            this.tabControlVentas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlVentas.Controls.Add(this.tabPageListaVentas);
            this.tabControlVentas.Controls.Add(this.tabPageRegistrarVenta);
            this.tabControlVentas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControlVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVentas.Location = new System.Drawing.Point(0, 41);
            this.tabControlVentas.Name = "tabControlVentas";
            this.tabControlVentas.SelectedIndex = 0;
            this.tabControlVentas.Size = new System.Drawing.Size(903, 519);
            this.tabControlVentas.TabIndex = 3;
            // 
            // tabPageListaVentas
            // 
            this.tabPageListaVentas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageListaVentas.Controls.Add(this.dgvPedidos);
            this.tabPageListaVentas.Controls.Add(this.tbBuscar);
            this.tabPageListaVentas.Controls.Add(this.lblBuscarcliente);
            this.tabPageListaVentas.Controls.Add(this.btnBorrar);
            this.tabPageListaVentas.Controls.Add(this.btnConfirmarCambios);
            this.tabPageListaVentas.Controls.Add(this.btnAgregar);
            this.tabPageListaVentas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageListaVentas.Location = new System.Drawing.Point(4, 25);
            this.tabPageListaVentas.Name = "tabPageListaVentas";
            this.tabPageListaVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListaVentas.Size = new System.Drawing.Size(895, 490);
            this.tabPageListaVentas.TabIndex = 0;
            this.tabPageListaVentas.Text = "Pedidos";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeight = 30;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.Idcliente,
            this.Idproducto,
            this.TipoPago,
            this.FechaPedido,
            this.FechaEntrega,
            this.EstatusPago,
            this.Observaciones});
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.Location = new System.Drawing.Point(8, 103);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.dgvPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidos.Size = new System.Drawing.Size(879, 293);
            this.dgvPedidos.TabIndex = 3;
            // 
            // IdPedido
            // 
            this.IdPedido.HeaderText = "id_pedido";
            this.IdPedido.MinimumWidth = 6;
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.ReadOnly = true;
            this.IdPedido.Width = 125;
            // 
            // Idcliente
            // 
            this.Idcliente.HeaderText = "id_cliente";
            this.Idcliente.MinimumWidth = 6;
            this.Idcliente.Name = "Idcliente";
            this.Idcliente.Width = 125;
            // 
            // Idproducto
            // 
            this.Idproducto.HeaderText = "id_productos";
            this.Idproducto.MinimumWidth = 6;
            this.Idproducto.Name = "Idproducto";
            this.Idproducto.Width = 125;
            // 
            // TipoPago
            // 
            this.TipoPago.HeaderText = "Tipo de pago";
            this.TipoPago.MinimumWidth = 6;
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.Width = 125;
            // 
            // FechaPedido
            // 
            this.FechaPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaPedido.HeaderText = "Fecha de pedido";
            this.FechaPedido.MinimumWidth = 6;
            this.FechaPedido.Name = "FechaPedido";
            this.FechaPedido.Width = 102;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "Fecha de entrega";
            this.FechaEntrega.MinimumWidth = 6;
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Width = 125;
            // 
            // EstatusPago
            // 
            this.EstatusPago.HeaderText = "Estatus de pago";
            this.EstatusPago.MinimumWidth = 6;
            this.EstatusPago.Name = "EstatusPago";
            this.EstatusPago.Width = 125;
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 6;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 102;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(39, 51);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(712, 20);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // lblBuscarcliente
            // 
            this.lblBuscarcliente.AutoSize = true;
            this.lblBuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarcliente.Location = new System.Drawing.Point(36, 28);
            this.lblBuscarcliente.Name = "lblBuscarcliente";
            this.lblBuscarcliente.Size = new System.Drawing.Size(89, 15);
            this.lblBuscarcliente.TabIndex = 0;
            this.lblBuscarcliente.Text = "Buscar pedido:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_basura_38;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.Location = new System.Drawing.Point(575, 417);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(161, 49);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar registro";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnConfirmarCambios
            // 
            this.btnConfirmarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarCambios.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCambios.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_pedido_completado_36;
            this.btnConfirmarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarCambios.Location = new System.Drawing.Point(365, 417);
            this.btnConfirmarCambios.Name = "btnConfirmarCambios";
            this.btnConfirmarCambios.Size = new System.Drawing.Size(161, 49);
            this.btnConfirmarCambios.TabIndex = 5;
            this.btnConfirmarCambios.Text = "Confirmar cambios\r\n         (al editar)";
            this.btnConfirmarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarCambios.UseVisualStyleBackColor = true;
            this.btnConfirmarCambios.Click += new System.EventHandler(this.btnConfirmarCambios_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.pedido__2_;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(153, 417);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 49);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar pedido";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tabPageRegistrarVenta
            // 
            this.tabPageRegistrarVenta.Controls.Add(this.panel2);
            this.tabPageRegistrarVenta.Location = new System.Drawing.Point(4, 25);
            this.tabPageRegistrarVenta.Name = "tabPageRegistrarVenta";
            this.tabPageRegistrarVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrarVenta.Size = new System.Drawing.Size(895, 490);
            this.tabPageRegistrarVenta.TabIndex = 1;
            this.tabPageRegistrarVenta.Text = "Registar pedido";
            this.tabPageRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnValidar);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.tbObservaciones);
            this.panel2.Controls.Add(this.lblObservaciones);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.dtpFechaEntrega);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.lblFechaEntrega);
            this.panel2.Controls.Add(this.dtpFechaPedido);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblFechaPedido);
            this.panel2.Controls.Add(this.tbIdProducto);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.tbIdCliente);
            this.panel2.Controls.Add(this.lblApellido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 484);
            this.panel2.TabIndex = 10;
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_checked_radio_button_601;
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidar.Location = new System.Drawing.Point(354, 433);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(162, 33);
            this.btnValidar.TabIndex = 41;
            this.btnValidar.Text = "Validar datos";
            this.btnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtnPagado);
            this.panel4.Controls.Add(this.lblEstatusPago);
            this.panel4.Controls.Add(this.rbtnPendiente);
            this.panel4.Location = new System.Drawing.Point(126, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 100);
            this.panel4.TabIndex = 40;
            // 
            // rbtnPagado
            // 
            this.rbtnPagado.AutoSize = true;
            this.rbtnPagado.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPagado.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnPagado.Location = new System.Drawing.Point(12, 43);
            this.rbtnPagado.Name = "rbtnPagado";
            this.rbtnPagado.Size = new System.Drawing.Size(63, 18);
            this.rbtnPagado.TabIndex = 0;
            this.rbtnPagado.TabStop = true;
            this.rbtnPagado.Text = "Pagado";
            this.rbtnPagado.UseVisualStyleBackColor = true;
            this.rbtnPagado.CheckedChanged += new System.EventHandler(this.rbtnPagado_CheckedChanged);
            // 
            // lblEstatusPago
            // 
            this.lblEstatusPago.AutoSize = true;
            this.lblEstatusPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblEstatusPago.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusPago.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstatusPago.Location = new System.Drawing.Point(8, 12);
            this.lblEstatusPago.Name = "lblEstatusPago";
            this.lblEstatusPago.Size = new System.Drawing.Size(118, 19);
            this.lblEstatusPago.TabIndex = 31;
            this.lblEstatusPago.Text = "Estatus de pago";
            // 
            // rbtnPendiente
            // 
            this.rbtnPendiente.AutoSize = true;
            this.rbtnPendiente.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPendiente.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnPendiente.Location = new System.Drawing.Point(109, 43);
            this.rbtnPendiente.Name = "rbtnPendiente";
            this.rbtnPendiente.Size = new System.Drawing.Size(78, 18);
            this.rbtnPendiente.TabIndex = 1;
            this.rbtnPendiente.TabStop = true;
            this.rbtnPendiente.Text = "Pendiente";
            this.rbtnPendiente.UseVisualStyleBackColor = true;
            this.rbtnPendiente.CheckedChanged += new System.EventHandler(this.rbtnPendiente_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnCredito);
            this.panel3.Controls.Add(this.lblTipoPago);
            this.panel3.Controls.Add(this.rbtnContado);
            this.panel3.Location = new System.Drawing.Point(126, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 100);
            this.panel3.TabIndex = 39;
            // 
            // rbtnCredito
            // 
            this.rbtnCredito.AutoSize = true;
            this.rbtnCredito.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCredito.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnCredito.Location = new System.Drawing.Point(116, 55);
            this.rbtnCredito.Name = "rbtnCredito";
            this.rbtnCredito.Size = new System.Drawing.Size(63, 18);
            this.rbtnCredito.TabIndex = 1;
            this.rbtnCredito.TabStop = true;
            this.rbtnCredito.Text = "Crédito";
            this.rbtnCredito.UseVisualStyleBackColor = true;
            this.rbtnCredito.CheckedChanged += new System.EventHandler(this.rbtnCredito_CheckedChanged);
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblTipoPago.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoPago.Location = new System.Drawing.Point(15, 13);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(103, 19);
            this.lblTipoPago.TabIndex = 5;
            this.lblTipoPago.Text = "Tipo de pago:";
            // 
            // rbtnContado
            // 
            this.rbtnContado.AutoSize = true;
            this.rbtnContado.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnContado.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnContado.Location = new System.Drawing.Point(19, 54);
            this.rbtnContado.Name = "rbtnContado";
            this.rbtnContado.Size = new System.Drawing.Size(68, 18);
            this.rbtnContado.TabIndex = 0;
            this.rbtnContado.TabStop = true;
            this.rbtnContado.Text = "Contado";
            this.rbtnContado.UseVisualStyleBackColor = true;
            this.rbtnContado.CheckedChanged += new System.EventHandler(this.rbtnContado_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_confirmar_25;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(281, 374);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 33);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_cancelar_25;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(459, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 33);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_description_64;
            this.pictureBox5.Location = new System.Drawing.Point(391, 278);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.BackColor = System.Drawing.SystemColors.Menu;
            this.tbObservaciones.Location = new System.Drawing.Point(459, 304);
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(140, 20);
            this.tbObservaciones.TabIndex = 34;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblObservaciones.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.lblObservaciones.Location = new System.Drawing.Point(455, 278);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(114, 19);
            this.lblObservaciones.TabIndex = 35;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_pedido_completado_60;
            this.pictureBox7.Location = new System.Drawing.Point(68, 248);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 44);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(459, 236);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(272, 20);
            this.dtpFechaEntrega.TabIndex = 30;
            this.dtpFechaEntrega.Value = new System.DateTime(2023, 11, 13, 0, 0, 0, 0);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_entrega_60;
            this.pictureBox8.Location = new System.Drawing.Point(391, 214);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(58, 42);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 29;
            this.pictureBox8.TabStop = false;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblFechaEntrega.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaEntrega.Location = new System.Drawing.Point(455, 206);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(131, 19);
            this.lblFechaEntrega.TabIndex = 28;
            this.lblFechaEntrega.Text = "Fecha de entrega:";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(459, 156);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(272, 20);
            this.dtpFechaPedido.TabIndex = 27;
            this.dtpFechaPedido.Value = new System.DateTime(2023, 11, 13, 0, 0, 0, 0);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_calendario_60;
            this.pictureBox4.Location = new System.Drawing.Point(391, 134);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_dinero_60;
            this.pictureBox3.Location = new System.Drawing.Point(68, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_bed_60__1_;
            this.pictureBox2.Location = new System.Drawing.Point(391, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_cliente_60;
            this.pictureBox1.Location = new System.Drawing.Point(78, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblFechaPedido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaPedido.Location = new System.Drawing.Point(455, 122);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(126, 19);
            this.lblFechaPedido.TabIndex = 7;
            this.lblFechaPedido.Text = "Fecha de pedido:";
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.BackColor = System.Drawing.SystemColors.Menu;
            this.tbIdProducto.Location = new System.Drawing.Point(459, 84);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(140, 20);
            this.tbIdProducto.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblNombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(136, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "id_cliente:";
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.tbIdCliente.Location = new System.Drawing.Point(140, 84);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(140, 20);
            this.tbIdCliente.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblApellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Location = new System.Drawing.Point(455, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(96, 19);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "id_producto:";
            // 
            // Pedidos
            // 
            this.ClientSize = new System.Drawing.Size(903, 560);
            this.Controls.Add(this.tabControlVentas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pedidos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pedidos_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlVentas.ResumeLayout(false);
            this.tabPageListaVentas.ResumeLayout(false);
            this.tabPageListaVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabPageRegistrarVenta.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloPedidos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConfirmarCambios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lblBuscarcliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTipoPago;
        public System.Windows.Forms.TabPage tabPageListaVentas;
        private System.Windows.Forms.RadioButton rbtnCredito;
        private System.Windows.Forms.RadioButton rbtnContado;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblEstatusPago;
        private System.Windows.Forms.RadioButton rbtnPendiente;
        private System.Windows.Forms.RadioButton rbtnPagado;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        public System.Windows.Forms.TabPage tabPageRegistrarVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstatusPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        public System.Windows.Forms.TabControl tabControlVentas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnValidar;
    }
}