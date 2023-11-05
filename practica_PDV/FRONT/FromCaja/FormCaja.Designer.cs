namespace practica_PDV.FRONT.FromCaja
{
    partial class FormCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaja));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnAutos = new System.Windows.Forms.Button();
            this.lblProduc = new System.Windows.Forms.Label();
            this.panelbtnAcciones = new System.Windows.Forms.Panel();
            this.iconMas = new FontAwesome.Sharp.IconButton();
            this.iconMenos = new FontAwesome.Sharp.IconButton();
            this.numericMultiplicador = new System.Windows.Forms.NumericUpDown();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.panelDesCuenta = new System.Windows.Forms.Panel();
            this.labelCambio = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.labelTotalPagar = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelImpuesto = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.panelDataGridDetalle = new System.Windows.Forms.Panel();
            this.dataGridDesc = new System.Windows.Forms.DataGridView();
            this.id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.panelbtnAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMultiplicador)).BeginInit();
            this.panelDetalles.SuspendLayout();
            this.panelDesCuenta.SuspendLayout();
            this.panelDataGridDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 89);
            this.panel1.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(581, 32);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(51, 24);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Caja";
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.Transparent;
            this.panelProductos.Controls.Add(this.panelClientes);
            this.panelProductos.Controls.Add(this.dataGridProduct);
            this.panelProductos.Controls.Add(this.panelTitulo);
            this.panelProductos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelProductos.Location = new System.Drawing.Point(614, 89);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(635, 764);
            this.panelProductos.TabIndex = 1;
            // 
            // panelClientes
            // 
            this.panelClientes.Controls.Add(this.dataGridCustomers);
            this.panelClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientes.Location = new System.Drawing.Point(0, 470);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(635, 294);
            this.panelClientes.TabIndex = 2;
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.EMAIL,
            this.PHONE});
            this.dataGridCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersVisible = false;
            this.dataGridCustomers.RowHeadersWidth = 51;
            this.dataGridCustomers.RowTemplate.Height = 24;
            this.dataGridCustomers.Size = new System.Drawing.Size(635, 294);
            this.dataGridCustomers.TabIndex = 1;
            this.dataGridCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomers_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.HeaderText = "PHONE";
            this.PHONE.MinimumWidth = 6;
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.descProduc,
            this.price,
            this.stock});
            this.dataGridProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridProduct.Location = new System.Drawing.Point(0, 289);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersVisible = false;
            this.dataGridProduct.RowHeadersWidth = 51;
            this.dataGridProduct.RowTemplate.Height = 24;
            this.dataGridProduct.Size = new System.Drawing.Size(635, 181);
            this.dataGridProduct.TabIndex = 1;
            this.dataGridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "NOMBRE";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // descProduc
            // 
            this.descProduc.HeaderText = "DESCRIPCION";
            this.descProduc.MinimumWidth = 6;
            this.descProduc.Name = "descProduc";
            this.descProduc.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "PRECIO";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "STOCK";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.panelTitulo.Controls.Add(this.panelBtn);
            this.panelTitulo.Controls.Add(this.lblProduc);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(635, 289);
            this.panelTitulo.TabIndex = 0;
            // 
            // panelBtn
            // 
            this.panelBtn.BackColor = System.Drawing.Color.Transparent;
            this.panelBtn.Controls.Add(this.txtBuscar);
            this.panelBtn.Controls.Add(this.labelBuscar);
            this.panelBtn.Controls.Add(this.btnNuevoCliente);
            this.panelBtn.Controls.Add(this.btnClientes);
            this.panelBtn.Controls.Add(this.btnAutos);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtn.Location = new System.Drawing.Point(0, 56);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(635, 233);
            this.panelBtn.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(331, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 30);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.BackColor = System.Drawing.Color.Tomato;
            this.labelBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(31, 36);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(170, 24);
            this.labelBuscar.TabIndex = 4;
            this.labelBuscar.Text = "Buscar Producto";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(331, 90);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(241, 65);
            this.btnNuevoCliente.TabIndex = 3;
            this.btnNuevoCliente.Text = "Registrar Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(163, 90);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(143, 64);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnAutos
            // 
            this.btnAutos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutos.Location = new System.Drawing.Point(9, 90);
            this.btnAutos.Name = "btnAutos";
            this.btnAutos.Size = new System.Drawing.Size(148, 64);
            this.btnAutos.TabIndex = 1;
            this.btnAutos.Text = "Autos";
            this.btnAutos.UseVisualStyleBackColor = true;
            this.btnAutos.Click += new System.EventHandler(this.btnAutos_Click);
            // 
            // lblProduc
            // 
            this.lblProduc.AutoSize = true;
            this.lblProduc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduc.Location = new System.Drawing.Point(207, 15);
            this.lblProduc.Name = "lblProduc";
            this.lblProduc.Size = new System.Drawing.Size(227, 24);
            this.lblProduc.TabIndex = 2;
            this.lblProduc.Text = "Selecciona el Producto";
            this.lblProduc.Click += new System.EventHandler(this.lblProduc_Click);
            // 
            // panelbtnAcciones
            // 
            this.panelbtnAcciones.BackColor = System.Drawing.Color.Transparent;
            this.panelbtnAcciones.Controls.Add(this.iconMas);
            this.panelbtnAcciones.Controls.Add(this.iconMenos);
            this.panelbtnAcciones.Controls.Add(this.numericMultiplicador);
            this.panelbtnAcciones.Controls.Add(this.btnPagar);
            this.panelbtnAcciones.Controls.Add(this.btnLimpiar);
            this.panelbtnAcciones.Controls.Add(this.btnEliminar);
            this.panelbtnAcciones.Controls.Add(this.btnCaja);
            this.panelbtnAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbtnAcciones.Location = new System.Drawing.Point(0, 89);
            this.panelbtnAcciones.Name = "panelbtnAcciones";
            this.panelbtnAcciones.Size = new System.Drawing.Size(614, 211);
            this.panelbtnAcciones.TabIndex = 2;
            // 
            // iconMas
            // 
            this.iconMas.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconMas.IconColor = System.Drawing.Color.Black;
            this.iconMas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMas.IconSize = 30;
            this.iconMas.Location = new System.Drawing.Point(434, 83);
            this.iconMas.Name = "iconMas";
            this.iconMas.Size = new System.Drawing.Size(65, 46);
            this.iconMas.TabIndex = 9;
            this.iconMas.UseVisualStyleBackColor = true;
            this.iconMas.Click += new System.EventHandler(this.iconMas_Click);
            // 
            // iconMenos
            // 
            this.iconMenos.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconMenos.IconColor = System.Drawing.Color.Black;
            this.iconMenos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenos.IconSize = 30;
            this.iconMenos.Location = new System.Drawing.Point(354, 83);
            this.iconMenos.Name = "iconMenos";
            this.iconMenos.Size = new System.Drawing.Size(65, 46);
            this.iconMenos.TabIndex = 8;
            this.iconMenos.UseVisualStyleBackColor = true;
            this.iconMenos.Click += new System.EventHandler(this.iconMenos_Click);
            // 
            // numericMultiplicador
            // 
            this.numericMultiplicador.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMultiplicador.Location = new System.Drawing.Point(527, 83);
            this.numericMultiplicador.Name = "numericMultiplicador";
            this.numericMultiplicador.Size = new System.Drawing.Size(81, 42);
            this.numericMultiplicador.TabIndex = 7;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(173, 99);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(155, 93);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(173, 17);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 64);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(12, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 93);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.Location = new System.Drawing.Point(12, 17);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(155, 64);
            this.btnCaja.TabIndex = 3;
            this.btnCaja.Text = "Abrir Caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // panelDetalles
            // 
            this.panelDetalles.BackColor = System.Drawing.Color.Transparent;
            this.panelDetalles.Controls.Add(this.panelDesCuenta);
            this.panelDetalles.Controls.Add(this.panelDataGridDetalle);
            this.panelDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalles.Location = new System.Drawing.Point(0, 300);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(614, 553);
            this.panelDetalles.TabIndex = 3;
            // 
            // panelDesCuenta
            // 
            this.panelDesCuenta.BackColor = System.Drawing.Color.Transparent;
            this.panelDesCuenta.Controls.Add(this.labelCambio);
            this.panelDesCuenta.Controls.Add(this.txtCambio);
            this.panelDesCuenta.Controls.Add(this.txtId);
            this.panelDesCuenta.Controls.Add(this.labelid);
            this.panelDesCuenta.Controls.Add(this.txtMonto);
            this.panelDesCuenta.Controls.Add(this.labelTotalPagar);
            this.panelDesCuenta.Controls.Add(this.txtTotal);
            this.panelDesCuenta.Controls.Add(this.txtIva);
            this.panelDesCuenta.Controls.Add(this.txtSubtotal);
            this.panelDesCuenta.Controls.Add(this.labelTotal);
            this.panelDesCuenta.Controls.Add(this.labelImpuesto);
            this.panelDesCuenta.Controls.Add(this.labelSubtotal);
            this.panelDesCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesCuenta.Location = new System.Drawing.Point(0, 259);
            this.panelDesCuenta.Name = "panelDesCuenta";
            this.panelDesCuenta.Size = new System.Drawing.Size(614, 294);
            this.panelDesCuenta.TabIndex = 1;
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.BackColor = System.Drawing.Color.Tomato;
            this.labelCambio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(350, 101);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(81, 24);
            this.labelCambio.TabIndex = 17;
            this.labelCambio.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(461, 98);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(127, 30);
            this.txtCambio.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(508, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 30);
            this.txtId.TabIndex = 11;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Tomato;
            this.labelid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.White;
            this.labelid.Location = new System.Drawing.Point(360, 38);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(94, 24);
            this.labelid.TabIndex = 10;
            this.labelid.Text = "IDCliente";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(198, 217);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 30);
            this.txtMonto.TabIndex = 9;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // labelTotalPagar
            // 
            this.labelTotalPagar.AutoSize = true;
            this.labelTotalPagar.BackColor = System.Drawing.Color.Tomato;
            this.labelTotalPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPagar.ForeColor = System.Drawing.Color.White;
            this.labelTotalPagar.Location = new System.Drawing.Point(33, 217);
            this.labelTotalPagar.Name = "labelTotalPagar";
            this.labelTotalPagar.Size = new System.Drawing.Size(86, 24);
            this.labelTotalPagar.TabIndex = 8;
            this.labelTotalPagar.Text = "MONTO";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(198, 158);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 30);
            this.txtTotal.TabIndex = 7;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(198, 101);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 30);
            this.txtIva.TabIndex = 6;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(198, 38);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 30);
            this.txtSubtotal.TabIndex = 5;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Tomato;
            this.labelTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(33, 158);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(76, 24);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "TOTAL";
            // 
            // labelImpuesto
            // 
            this.labelImpuesto.AutoSize = true;
            this.labelImpuesto.BackColor = System.Drawing.Color.Tomato;
            this.labelImpuesto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImpuesto.ForeColor = System.Drawing.Color.White;
            this.labelImpuesto.Location = new System.Drawing.Point(33, 101);
            this.labelImpuesto.Name = "labelImpuesto";
            this.labelImpuesto.Size = new System.Drawing.Size(40, 24);
            this.labelImpuesto.TabIndex = 3;
            this.labelImpuesto.Text = "IVA";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.BackColor = System.Drawing.Color.Tomato;
            this.labelSubtotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.ForeColor = System.Drawing.Color.White;
            this.labelSubtotal.Location = new System.Drawing.Point(33, 38);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(117, 24);
            this.labelSubtotal.TabIndex = 2;
            this.labelSubtotal.Text = "SUBTOTAL";
            // 
            // panelDataGridDetalle
            // 
            this.panelDataGridDetalle.Controls.Add(this.dataGridDesc);
            this.panelDataGridDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataGridDetalle.Location = new System.Drawing.Point(0, 0);
            this.panelDataGridDetalle.Name = "panelDataGridDetalle";
            this.panelDataGridDetalle.Size = new System.Drawing.Size(614, 259);
            this.panelDataGridDetalle.TabIndex = 0;
            // 
            // dataGridDesc
            // 
            this.dataGridDesc.AllowUserToAddRows = false;
            this.dataGridDesc.AllowUserToDeleteRows = false;
            this.dataGridDesc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDesc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDesc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_detalle,
            this.cantidad_detalle,
            this.nameDetalle,
            this.importe_detalle});
            this.dataGridDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDesc.Location = new System.Drawing.Point(0, 0);
            this.dataGridDesc.Name = "dataGridDesc";
            this.dataGridDesc.ReadOnly = true;
            this.dataGridDesc.RowHeadersVisible = false;
            this.dataGridDesc.RowHeadersWidth = 51;
            this.dataGridDesc.RowTemplate.Height = 24;
            this.dataGridDesc.Size = new System.Drawing.Size(614, 259);
            this.dataGridDesc.TabIndex = 0;
            // 
            // id_detalle
            // 
            this.id_detalle.HeaderText = "ID";
            this.id_detalle.MinimumWidth = 6;
            this.id_detalle.Name = "id_detalle";
            this.id_detalle.ReadOnly = true;
            // 
            // cantidad_detalle
            // 
            this.cantidad_detalle.HeaderText = "CANTIDAD";
            this.cantidad_detalle.MinimumWidth = 6;
            this.cantidad_detalle.Name = "cantidad_detalle";
            this.cantidad_detalle.ReadOnly = true;
            // 
            // nameDetalle
            // 
            this.nameDetalle.HeaderText = "NOMBRE";
            this.nameDetalle.MinimumWidth = 6;
            this.nameDetalle.Name = "nameDetalle";
            this.nameDetalle.ReadOnly = true;
            // 
            // importe_detalle
            // 
            this.importe_detalle.HeaderText = "IMPORTE";
            this.importe_detalle.MinimumWidth = 6;
            this.importe_detalle.Name = "importe_detalle";
            this.importe_detalle.ReadOnly = true;
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 853);
            this.Controls.Add(this.panelDetalles);
            this.Controls.Add(this.panelbtnAcciones);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panel1);
            this.Name = "FormCaja";
            this.Text = "FormCaja";
            this.Load += new System.EventHandler(this.FormCaja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelProductos.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            this.panelbtnAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericMultiplicador)).EndInit();
            this.panelDetalles.ResumeLayout(false);
            this.panelDesCuenta.ResumeLayout(false);
            this.panelDesCuenta.PerformLayout();
            this.panelDataGridDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDesc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Label lblProduc;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAutos;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Panel panelbtnAcciones;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.NumericUpDown numericMultiplicador;
        private FontAwesome.Sharp.IconButton iconMenos;
        private FontAwesome.Sharp.IconButton iconMas;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Panel panelDesCuenta;
        private System.Windows.Forms.Panel panelDataGridDetalle;
        private System.Windows.Forms.DataGridView dataGridDesc;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelImpuesto;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_detalle;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label labelTotalPagar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.TextBox txtCambio;
    }
}