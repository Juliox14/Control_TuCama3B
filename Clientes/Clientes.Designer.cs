namespace Proyecto___Concentraciones_de_Alcohol
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListaClientes = new System.Windows.Forms.TabPage();
            this.pbInfoBuscar = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConfirmarCambios = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidocliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonocliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccioncliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarcliente = new System.Windows.Forms.Label();
            this.tabPageAgregarCliente = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnValidar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPageAgregarCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTituloClientes.Location = new System.Drawing.Point(40, 11);
            this.lblTituloClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(101, 28);
            this.lblTituloClientes.TabIndex = 0;
            this.lblTituloClientes.Text = "Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lblTituloClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 50);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPageListaClientes);
            this.tabControl1.Controls.Add(this.tabPageAgregarCliente);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1204, 639);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageListaClientes
            // 
            this.tabPageListaClientes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageListaClientes.Controls.Add(this.pbInfoBuscar);
            this.tabPageListaClientes.Controls.Add(this.btnBorrar);
            this.tabPageListaClientes.Controls.Add(this.btnConfirmarCambios);
            this.tabPageListaClientes.Controls.Add(this.btnAgregar);
            this.tabPageListaClientes.Controls.Add(this.dgvClientes);
            this.tabPageListaClientes.Controls.Add(this.tbBuscar);
            this.tabPageListaClientes.Controls.Add(this.lblBuscarcliente);
            this.tabPageListaClientes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageListaClientes.Location = new System.Drawing.Point(4, 28);
            this.tabPageListaClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageListaClientes.Name = "tabPageListaClientes";
            this.tabPageListaClientes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageListaClientes.Size = new System.Drawing.Size(1196, 607);
            this.tabPageListaClientes.TabIndex = 0;
            this.tabPageListaClientes.Text = "Lista de clientes";
            // 
            // pbInfoBuscar
            // 
            this.pbInfoBuscar.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_información_40;
            this.pbInfoBuscar.Location = new System.Drawing.Point(741, 54);
            this.pbInfoBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbInfoBuscar.Name = "pbInfoBuscar";
            this.pbInfoBuscar.Size = new System.Drawing.Size(32, 39);
            this.pbInfoBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfoBuscar.TabIndex = 7;
            this.pbInfoBuscar.TabStop = false;
            this.pbInfoBuscar.MouseLeave += new System.EventHandler(this.pbInfoBuscar_MouseLeave);
            this.pbInfoBuscar.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_retire_hombre_usuario_25;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.Location = new System.Drawing.Point(948, 356);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(191, 49);
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
            this.btnConfirmarCambios.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_editar_usuario_masculino_25;
            this.btnConfirmarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarCambios.Location = new System.Drawing.Point(948, 267);
            this.btnConfirmarCambios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmarCambios.Name = "btnConfirmarCambios";
            this.btnConfirmarCambios.Size = new System.Drawing.Size(191, 49);
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
            this.btnAgregar.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_agregar_usuario_25;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(948, 182);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(191, 49);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar cliente";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClientes.ColumnHeadersHeight = 30;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idcliente,
            this.nombrecliente,
            this.apellidocliente,
            this.telefonocliente,
            this.direccioncliente});
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(40, 117);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvClientes.Size = new System.Drawing.Size(857, 458);
            this.dgvClientes.TabIndex = 3;
            // 
            // Idcliente
            // 
            this.Idcliente.HeaderText = "id_cliente";
            this.Idcliente.MinimumWidth = 6;
            this.Idcliente.Name = "Idcliente";
            this.Idcliente.ReadOnly = true;
            this.Idcliente.Width = 125;
            // 
            // nombrecliente
            // 
            this.nombrecliente.HeaderText = "Nombre";
            this.nombrecliente.MinimumWidth = 6;
            this.nombrecliente.Name = "nombrecliente";
            this.nombrecliente.Width = 125;
            // 
            // apellidocliente
            // 
            this.apellidocliente.HeaderText = "Apellido";
            this.apellidocliente.MinimumWidth = 6;
            this.apellidocliente.Name = "apellidocliente";
            this.apellidocliente.Width = 125;
            // 
            // telefonocliente
            // 
            this.telefonocliente.HeaderText = "Telefono";
            this.telefonocliente.MinimumWidth = 6;
            this.telefonocliente.Name = "telefonocliente";
            this.telefonocliente.Width = 125;
            // 
            // direccioncliente
            // 
            this.direccioncliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.direccioncliente.HeaderText = "Direccion";
            this.direccioncliente.MinimumWidth = 6;
            this.direccioncliente.Name = "direccioncliente";
            this.direccioncliente.Width = 107;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(52, 63);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(680, 22);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // lblBuscarcliente
            // 
            this.lblBuscarcliente.AutoSize = true;
            this.lblBuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarcliente.Location = new System.Drawing.Point(48, 34);
            this.lblBuscarcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarcliente.Name = "lblBuscarcliente";
            this.lblBuscarcliente.Size = new System.Drawing.Size(105, 18);
            this.lblBuscarcliente.TabIndex = 0;
            this.lblBuscarcliente.Text = "Buscar cliente:";
            // 
            // tabPageAgregarCliente
            // 
            this.tabPageAgregarCliente.Controls.Add(this.panel2);
            this.tabPageAgregarCliente.Location = new System.Drawing.Point(4, 28);
            this.tabPageAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAgregarCliente.Name = "tabPageAgregarCliente";
            this.tabPageAgregarCliente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAgregarCliente.Size = new System.Drawing.Size(1196, 607);
            this.tabPageAgregarCliente.TabIndex = 1;
            this.tabPageAgregarCliente.Text = "   Agregar cliente";
            this.tabPageAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnValidar);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.tbDireccion);
            this.panel2.Controls.Add(this.tbTelefono);
            this.panel2.Controls.Add(this.lblDireccion);
            this.panel2.Controls.Add(this.tbApellido);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.tbNombre);
            this.panel2.Controls.Add(this.lblApellido);
            this.panel2.Controls.Add(this.lblnumero);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 599);
            this.panel2.TabIndex = 10;
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_checked_radio_button_601;
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidar.Location = new System.Drawing.Point(453, 448);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(216, 41);
            this.btnValidar.TabIndex = 14;
            this.btnValidar.Text = "Validar datos";
            this.btnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_mapa_40;
            this.pictureBox4.Location = new System.Drawing.Point(611, 220);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 49);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_teléfono_celular_40;
            this.pictureBox3.Location = new System.Drawing.Point(249, 220);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 52);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_verificación_de_identificación_móvil_40;
            this.pictureBox2.Location = new System.Drawing.Point(593, 132);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_nombre_40__1_;
            this.pictureBox1.Location = new System.Drawing.Point(249, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 52);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Proyecto___Concentraciones_de_Alcohol.Properties.Resources.icons8_confirmar_25;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(339, 350);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(177, 36);
            this.btnGuardar.TabIndex = 8;
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
            this.btnCancelar.Location = new System.Drawing.Point(595, 350);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.BackColor = System.Drawing.SystemColors.Menu;
            this.tbDireccion.Location = new System.Drawing.Point(680, 247);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(185, 22);
            this.tbDireccion.TabIndex = 6;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.SystemColors.Menu;
            this.tbTelefono.Location = new System.Drawing.Point(332, 247);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(185, 22);
            this.tbTelefono.TabIndex = 4;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblDireccion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDireccion.Location = new System.Drawing.Point(675, 220);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(98, 23);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección:";
            // 
            // tbApellido
            // 
            this.tbApellido.BackColor = System.Drawing.SystemColors.Menu;
            this.tbApellido.Location = new System.Drawing.Point(680, 159);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(185, 22);
            this.tbApellido.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblNombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(327, 132);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.tbNombre.Location = new System.Drawing.Point(332, 159);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(185, 22);
            this.tbNombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblApellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Location = new System.Drawing.Point(675, 132);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(86, 23);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.lblnumero.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnumero.Location = new System.Drawing.Point(327, 220);
            this.lblnumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(89, 23);
            this.lblnumero.TabIndex = 5;
            this.lblnumero.Text = "Teléfono:";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1204, 689);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clientes_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clientes_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageListaClientes.ResumeLayout(false);
            this.tabPageListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPageAgregarCliente.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListaClientes;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConfirmarCambios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lblBuscarcliente;
        private System.Windows.Forms.TabPage tabPageAgregarCliente;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbInfoBuscar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidocliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonocliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccioncliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnValidar;
    }
}