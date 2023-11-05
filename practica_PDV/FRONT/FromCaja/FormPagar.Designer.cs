namespace practica_PDV.FRONT.FromCaja
{
    partial class FormPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagar));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelSubTitulo = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.labelIDCustomer = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.labelCambio = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.labelCantidadRecibida = new System.Windows.Forms.Label();
            this.txtCantidadRecibida = new System.Windows.Forms.TextBox();
            this.labelTotalAPagar = new System.Windows.Forms.Label();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.panelSubTitulo.SuspendLayout();
            this.panelResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1000, 78);
            this.panelTitulo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(435, 24);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(65, 24);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Pagar";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.Transparent;
            this.panelBase.Controls.Add(this.panelDataGrid);
            this.panelBase.Controls.Add(this.panelBtn);
            this.panelBase.Controls.Add(this.panelSubTitulo);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBase.Location = new System.Drawing.Point(497, 78);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(503, 530);
            this.panelBase.TabIndex = 1;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.dataGridCustomers);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 200);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(503, 330);
            this.panelDataGrid.TabIndex = 2;
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.EMAIL,
            this.PHONE});
            this.dataGridCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersVisible = false;
            this.dataGridCustomers.RowHeadersWidth = 51;
            this.dataGridCustomers.RowTemplate.Height = 24;
            this.dataGridCustomers.Size = new System.Drawing.Size(503, 330);
            this.dataGridCustomers.TabIndex = 0;
            this.dataGridCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomers_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NOMBRE";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
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
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnCancel);
            this.panelBtn.Controls.Add(this.btnNuevo);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBtn.Location = new System.Drawing.Point(0, 100);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(503, 100);
            this.panelBtn.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(260, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 64);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar Compra";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(29, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(200, 64);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Registrar Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panelSubTitulo
            // 
            this.panelSubTitulo.Controls.Add(this.txtBuscar);
            this.panelSubTitulo.Controls.Add(this.label1);
            this.panelSubTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelSubTitulo.Name = "panelSubTitulo";
            this.panelSubTitulo.Size = new System.Drawing.Size(503, 100);
            this.panelSubTitulo.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(315, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 30);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar Cliente";
            // 
            // panelResumen
            // 
            this.panelResumen.BackColor = System.Drawing.Color.Transparent;
            this.panelResumen.Controls.Add(this.labelIDCustomer);
            this.panelResumen.Controls.Add(this.txtIdCliente);
            this.panelResumen.Controls.Add(this.labelCambio);
            this.panelResumen.Controls.Add(this.txtCambio);
            this.panelResumen.Controls.Add(this.labelCantidadRecibida);
            this.panelResumen.Controls.Add(this.txtCantidadRecibida);
            this.panelResumen.Controls.Add(this.labelTotalAPagar);
            this.panelResumen.Controls.Add(this.txtTotalAPagar);
            this.panelResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResumen.Location = new System.Drawing.Point(0, 78);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(497, 280);
            this.panelResumen.TabIndex = 2;
            // 
            // labelIDCustomer
            // 
            this.labelIDCustomer.AutoSize = true;
            this.labelIDCustomer.BackColor = System.Drawing.Color.Tomato;
            this.labelIDCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDCustomer.Location = new System.Drawing.Point(40, 250);
            this.labelIDCustomer.Name = "labelIDCustomer";
            this.labelIDCustomer.Size = new System.Drawing.Size(100, 24);
            this.labelIDCustomer.TabIndex = 16;
            this.labelIDCustomer.Text = "ID Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(306, 250);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(185, 30);
            this.txtIdCliente.TabIndex = 15;
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.BackColor = System.Drawing.Color.Tomato;
            this.labelCambio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(40, 185);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(81, 24);
            this.labelCambio.TabIndex = 15;
            this.labelCambio.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(306, 185);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(185, 30);
            this.txtCambio.TabIndex = 14;
            // 
            // labelCantidadRecibida
            // 
            this.labelCantidadRecibida.AutoSize = true;
            this.labelCantidadRecibida.BackColor = System.Drawing.Color.Tomato;
            this.labelCantidadRecibida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadRecibida.Location = new System.Drawing.Point(40, 113);
            this.labelCantidadRecibida.Name = "labelCantidadRecibida";
            this.labelCantidadRecibida.Size = new System.Drawing.Size(181, 24);
            this.labelCantidadRecibida.TabIndex = 13;
            this.labelCantidadRecibida.Text = "Cantidad Recibida";
            // 
            // txtCantidadRecibida
            // 
            this.txtCantidadRecibida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadRecibida.Location = new System.Drawing.Point(306, 113);
            this.txtCantidadRecibida.Name = "txtCantidadRecibida";
            this.txtCantidadRecibida.Size = new System.Drawing.Size(185, 30);
            this.txtCantidadRecibida.TabIndex = 12;
            // 
            // labelTotalAPagar
            // 
            this.labelTotalAPagar.AutoSize = true;
            this.labelTotalAPagar.BackColor = System.Drawing.Color.Tomato;
            this.labelTotalAPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAPagar.Location = new System.Drawing.Point(40, 33);
            this.labelTotalAPagar.Name = "labelTotalAPagar";
            this.labelTotalAPagar.Size = new System.Drawing.Size(135, 24);
            this.labelTotalAPagar.TabIndex = 11;
            this.labelTotalAPagar.Text = "Total a Pagar";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Enabled = false;
            this.txtTotalAPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAPagar.Location = new System.Drawing.Point(306, 33);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(185, 30);
            this.txtTotalAPagar.TabIndex = 10;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(31, 427);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(200, 64);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // FormPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 608);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.panelResumen);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FormPagar";
            this.Text = "FormPagar";
            this.Load += new System.EventHandler(this.FormPagar_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.panelSubTitulo.ResumeLayout(false);
            this.panelSubTitulo.PerformLayout();
            this.panelResumen.ResumeLayout(false);
            this.panelResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel panelSubTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label labelCantidadRecibida;
        private System.Windows.Forms.TextBox txtCantidadRecibida;
        private System.Windows.Forms.Label labelTotalAPagar;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Label labelIDCustomer;
        private System.Windows.Forms.TextBox txtIdCliente;
    }
}