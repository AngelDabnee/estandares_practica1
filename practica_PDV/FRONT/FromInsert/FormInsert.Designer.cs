﻿namespace practica_PDV.FRONT.FromInsert
{
    partial class FormInsert
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textquantityInStock = new System.Windows.Forms.NumericUpDown();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelObjetos = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textquantityInStock)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panelObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(157, 44);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 22);
            this.textName.TabIndex = 0;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(479, 44);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(250, 22);
            this.textDescription.TabIndex = 1;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(157, 131);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 22);
            this.textPrice.TabIndex = 2;
            this.textPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrice_KeyPress);
            // 
            // textquantityInStock
            // 
            this.textquantityInStock.Location = new System.Drawing.Point(479, 129);
            this.textquantityInStock.Name = "textquantityInStock";
            this.textquantityInStock.Size = new System.Drawing.Size(120, 22);
            this.textquantityInStock.TabIndex = 3;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(749, 100);
            this.panelTitulo.TabIndex = 4;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(300, 7);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(123, 16);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Añadir Un Producto";
            // 
            // panelObjetos
            // 
            this.panelObjetos.Controls.Add(this.btnNew);
            this.panelObjetos.Controls.Add(this.btnCancel);
            this.panelObjetos.Controls.Add(this.btnInsert);
            this.panelObjetos.Controls.Add(this.Stock);
            this.panelObjetos.Controls.Add(this.labelPrice);
            this.panelObjetos.Controls.Add(this.labelDescription);
            this.panelObjetos.Controls.Add(this.labelName);
            this.panelObjetos.Controls.Add(this.textquantityInStock);
            this.panelObjetos.Controls.Add(this.textDescription);
            this.panelObjetos.Controls.Add(this.textName);
            this.panelObjetos.Controls.Add(this.textPrice);
            this.panelObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjetos.Location = new System.Drawing.Point(0, 100);
            this.panelObjetos.Name = "panelObjetos";
            this.panelObjetos.Size = new System.Drawing.Size(749, 335);
            this.panelObjetos.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(507, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(303, 216);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 41);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Confirmar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(391, 131);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(41, 16);
            this.Stock.TabIndex = 7;
            this.Stock.Text = "Stock";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(72, 134);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(46, 16);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Precio";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(391, 44);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 16);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Descripcion";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(62, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 16);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nombre";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(102, 216);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 41);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 435);
            this.Controls.Add(this.panelObjetos);
            this.Controls.Add(this.panelTitulo);
            this.MaximizeBox = false;
            this.Name = "FormInsert";
            this.Text = "FormInsert";
            this.Load += new System.EventHandler(this.FormInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textquantityInStock)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelObjetos.ResumeLayout(false);
            this.panelObjetos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.NumericUpDown textquantityInStock;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelObjetos;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnNew;
    }
}