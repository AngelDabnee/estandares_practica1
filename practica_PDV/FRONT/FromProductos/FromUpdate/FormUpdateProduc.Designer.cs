namespace practica_PDV.FRONT.FromProductos.FromUpdate
{
    partial class FormUpdateProduc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateProduc));
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.labeId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtquantityInStock = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantityInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.dataGridProducts);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDataGrid.Location = new System.Drawing.Point(647, 0);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(656, 1020);
            this.panelDataGrid.TabIndex = 0;
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AllowUserToDeleteRows = false;
            this.dataGridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.price,
            this.stock});
            this.dataGridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.ReadOnly = true;
            this.dataGridProducts.RowHeadersVisible = false;
            this.dataGridProducts.RowHeadersWidth = 51;
            this.dataGridProducts.RowTemplate.Height = 24;
            this.dataGridProducts.Size = new System.Drawing.Size(656, 1020);
            this.dataGridProducts.TabIndex = 0;
            this.dataGridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProducts_CellContentClick);
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
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelStock);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.txtquantityInStock);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.labeId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 1020);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(343, 722);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 45);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(164, 722);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(160, 45);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // labeId
            // 
            this.labeId.AutoSize = true;
            this.labeId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeId.ForeColor = System.Drawing.Color.White;
            this.labeId.Location = new System.Drawing.Point(115, 253);
            this.labeId.Name = "labeId";
            this.labeId.Size = new System.Drawing.Size(29, 24);
            this.labeId.TabIndex = 17;
            this.labeId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(275, 253);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(252, 30);
            this.txtId.TabIndex = 12;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStock.Location = new System.Drawing.Point(114, 618);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(89, 28);
            this.labelStock.TabIndex = 31;
            this.labelStock.Text = "STOCK";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPrice.Location = new System.Drawing.Point(114, 413);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(81, 28);
            this.labelPrice.TabIndex = 30;
            this.labelPrice.Text = "Precio";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDescription.Location = new System.Drawing.Point(114, 525);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(141, 28);
            this.labelDescription.TabIndex = 29;
            this.labelDescription.Text = "Descripcion";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelName.Location = new System.Drawing.Point(114, 329);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(97, 28);
            this.labelName.TabIndex = 28;
            this.labelName.Text = "Nombre";
            // 
            // txtquantityInStock
            // 
            this.txtquantityInStock.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantityInStock.Location = new System.Drawing.Point(256, 610);
            this.txtquantityInStock.Name = "txtquantityInStock";
            this.txtquantityInStock.Size = new System.Drawing.Size(120, 36);
            this.txtquantityInStock.TabIndex = 27;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(268, 522);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 36);
            this.txtDescription.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(277, 329);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 36);
            this.txtName.TabIndex = 24;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(277, 413);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(252, 36);
            this.txtPrice.TabIndex = 26;
            // 
            // FormUpdateProduc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1303, 1020);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDataGrid);
            this.Name = "FormUpdateProduc";
            this.Text = "FormUpdateProduc";
            this.Load += new System.EventHandler(this.FormUpdateProduc_Load);
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantityInStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label labeId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.NumericUpDown txtquantityInStock;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
    }
}