namespace practica_PDV.FRONT.FromSuppliers
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridSupplier = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelId = new System.Windows.Forms.Label();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelAction = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelHerramienta = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplier)).BeginInit();
            this.panelBuscar.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelHerramienta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.dataGridSupplier);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelData.Location = new System.Drawing.Point(760, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(489, 804);
            this.panelData.TabIndex = 0;
            // 
            // dataGridSupplier
            // 
            this.dataGridSupplier.AllowUserToDeleteRows = false;
            this.dataGridSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.email});
            this.dataGridSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSupplier.Location = new System.Drawing.Point(0, 0);
            this.dataGridSupplier.Name = "dataGridSupplier";
            this.dataGridSupplier.ReadOnly = true;
            this.dataGridSupplier.RowHeadersVisible = false;
            this.dataGridSupplier.RowHeadersWidth = 51;
            this.dataGridSupplier.RowTemplate.Height = 24;
            this.dataGridSupplier.Size = new System.Drawing.Size(489, 804);
            this.dataGridSupplier.TabIndex = 0;
            this.dataGridSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSupplier_CellContentClick);
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
            // email
            // 
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.Transparent;
            this.labelId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.Location = new System.Drawing.Point(54, 230);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(128, 24);
            this.labelId.TabIndex = 13;
            this.labelId.Text = "ID a Eliminar";
            // 
            // iconBuscar
            // 
            this.iconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBuscar.IconSize = 40;
            this.iconBuscar.Location = new System.Drawing.Point(58, 127);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(66, 53);
            this.iconBuscar.TabIndex = 12;
            this.iconBuscar.UseVisualStyleBackColor = true;
            this.iconBuscar.Click += new System.EventHandler(this.iconBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(224, 228);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 30);
            this.txtId.TabIndex = 11;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(130, 136);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(256, 30);
            this.txtBuscar.TabIndex = 10;
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscar.Controls.Add(this.panelTitulo);
            this.panelBuscar.Controls.Add(this.iconBuscar);
            this.panelBuscar.Controls.Add(this.txtId);
            this.panelBuscar.Controls.Add(this.labelId);
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscar.Location = new System.Drawing.Point(0, 0);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(760, 318);
            this.panelBuscar.TabIndex = 14;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(760, 100);
            this.panelTitulo.TabIndex = 14;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(196, 38);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(130, 24);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Proveedores";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.Transparent;
            this.panelAction.Controls.Add(this.panelBotones);
            this.panelAction.Controls.Add(this.panelHerramienta);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAction.Location = new System.Drawing.Point(0, 318);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(760, 486);
            this.panelAction.TabIndex = 15;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnInsert);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Controls.Add(this.btnDelete);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Location = new System.Drawing.Point(193, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(567, 486);
            this.panelBotones.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(311, 64);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Nuevo";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(0, 77);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(311, 64);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(0, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(311, 64);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelHerramienta
            // 
            this.panelHerramienta.Controls.Add(this.btnMenu);
            this.panelHerramienta.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHerramienta.Location = new System.Drawing.Point(0, 0);
            this.panelHerramienta.Name = "panelHerramienta";
            this.panelHerramienta.Size = new System.Drawing.Size(193, 486);
            this.panelHerramienta.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(193, 91);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Herramientas";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 804);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.panelData);
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplier)).EndInit();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelAction.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelHerramienta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label labelId;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelHerramienta;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelTitulo;
    }
}