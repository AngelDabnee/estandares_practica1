﻿namespace practica_PDV.FromProductos
{
    partial class FromSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromSelect));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_in_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.menu.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1249, 63);
            this.panelTitulo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(362, 21);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(121, 28);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Productos";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(298, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 36);
            this.txtName.TabIndex = 0;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.panelBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBusqueda.Controls.Add(this.labelId);
            this.panelBusqueda.Controls.Add(this.txtId);
            this.panelBusqueda.Controls.Add(this.panelMenu);
            this.panelBusqueda.Controls.Add(this.iconBuscar);
            this.panelBusqueda.Controls.Add(this.txtName);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 63);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1249, 790);
            this.panelBusqueda.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.Transparent;
            this.labelId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.Location = new System.Drawing.Point(263, 192);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(128, 24);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "ID a Eliminar";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(483, 192);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 30);
            this.txtId.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.menu);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(1006, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(243, 790);
            this.panelMenu.TabIndex = 6;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.btnEdit);
            this.menu.Controls.Add(this.btnInsert);
            this.menu.Controls.Add(this.btnEliminar);
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Location = new System.Drawing.Point(0, 64);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(243, 726);
            this.menu.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(0, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(243, 64);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(0, 64);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(243, 64);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Nuevo";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(0, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(243, 64);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(243, 64);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Herramientas";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // iconBuscar
            // 
            this.iconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBuscar.IconSize = 40;
            this.iconBuscar.Location = new System.Drawing.Point(561, 122);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(66, 53);
            this.iconBuscar.TabIndex = 1;
            this.iconBuscar.UseVisualStyleBackColor = true;
            this.iconBuscar.Click += new System.EventHandler(this.iconBuscar_Click);
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelDataGrid.Controls.Add(this.dataGridProduct);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 568);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(1249, 285);
            this.panelDataGrid.TabIndex = 3;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToOrderColumns = true;
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProduct.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.name,
            this.Description,
            this.Price,
            this.quantity_in_stock});
            this.dataGridProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersWidth = 51;
            this.dataGridProduct.RowTemplate.Height = 24;
            this.dataGridProduct.Size = new System.Drawing.Size(1249, 285);
            this.dataGridProduct.TabIndex = 0;
            this.dataGridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellContentClick);
            // 
            // product_id
            // 
            this.product_id.HeaderText = "id";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // quantity_in_stock
            // 
            this.quantity_in_stock.HeaderText = "Sock";
            this.quantity_in_stock.MinimumWidth = 6;
            this.quantity_in_stock.Name = "quantity_in_stock";
            this.quantity_in_stock.ReadOnly = true;
            // 
            // FromSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 853);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelTitulo);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromSelect";
            this.Text = "FromSelect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FromSelect_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txtName;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_in_stock;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelId;
    }
}