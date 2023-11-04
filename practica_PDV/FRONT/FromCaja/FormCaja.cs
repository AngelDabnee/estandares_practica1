using practica_PDV.CRUD_BACK;
using practica_PDV.MIDDEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_PDV.FRONT.FromCaja
{
    public partial class FormCaja : Form
    {
        CRUDs_BD bd;
        Products products; 
        Customers customers;
        Sels venta;
        double cantidad;
        string nombre;
        double total;
        double subtotal; 

        public FormCaja()
        {
            InitializeComponent();
            products = new Products();
            venta = new Sels();
            bd = new CRUD_BACK.MySql();
        }

        private void btnAutos_Click(object sender, EventArgs e)
        {
            if (dataGridProduct.Visible == false)
            {
                dataGridProduct.Show();
                this.cargarDatos();
            }
            else
            {
                dataGridProduct.Hide();
                this.cargarDatos();
            }
        }

        private void btnRefacciones_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("NO CONTAMOS CON PIEZAS DISPONIBLES","FAVOR DE CONTINUAR",MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
        }

        private void btnAccesorios_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("NO CONTAMOS CON PIEZAS DISPONIBLES", "FAVOR DE CONTINUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
        }
        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (numericMultiplicador.Value > 0) 
                {
                    int celdas = e.RowIndex;
                    this.nombre = dataGridProduct.Rows[celdas].Cells[1].Value.ToString();
                    this.total = double.Parse(dataGridProduct.Rows[celdas].Cells[3].Value.ToString());

                    int fila = dataGridDesc.Rows.Add();
                    cantidad = double.Parse(numericMultiplicador.Value.ToString());
                    dataGridDesc.Rows[fila].Cells["cantidad_detalle"].Value = double.Parse(numericMultiplicador.Value.ToString());
                    dataGridDesc.Rows[fila].Cells["nameDetalle"].Value = dataGridProduct.Rows[celdas].Cells[1].Value;

                    double importe = double.Parse(dataGridProduct.Rows[celdas].Cells[3].Value.ToString());
                    dataGridDesc.Rows[fila].Cells["importe_detalle"].Value = importe * cantidad;
                    numericMultiplicador.Value = 1;
                    this.calcularSubtotal();
                }
                numericMultiplicador.Value = 1;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridDesc.Rows.Clear();
            txtSubtotal.Clear();
            txtIva.Clear();
            txtTotal.Clear();
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {
            numericMultiplicador.Value = 1;
            numericMultiplicador.Enabled = false;
            this.cargarDatos();
            
        }

        private void iconMas_Click(object sender, EventArgs e)
        {
            numericMultiplicador.Value = numericMultiplicador.Value +1;
        }

        private void iconMenos_Click(object sender, EventArgs e)
        {
            if (numericMultiplicador.Value >0) 
            {
                numericMultiplicador.Value = numericMultiplicador.Value - 1;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridDesc.Rows.Count > 0) 
            {
                dataGridDesc.Rows.RemoveAt(this.dataGridDesc.CurrentRow.Index);
                this.calcularSubtotal() ;
            }
            if (dataGridDesc.Rows.Count == 0) 
            {
                txtSubtotal.Clear();
                txtIva.Clear();
                txtTotal.Clear();
            }
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SI TUVIESEMOS UNA CAJITA :'C");
        }




        //Metodootods
        public void cargarDatos()
        {
            dataGridProduct.Rows.Clear();
            List<object[]> datos = products.selectAll();
            for (int i = 0; i < datos.Count; i++)
            {
                dataGridProduct.Rows.Add(datos[i]);


            }
        }
        public void calcularSubtotal()
        {
            double nuevoSubtotal = 0;
            foreach (DataGridViewRow rowImportes in dataGridDesc.Rows)
            {
                if (rowImportes.Cells["importe_detalle"].Value != null)
                {
                    double importeTotal = 0;
                    if (double.TryParse(rowImportes.Cells["importe_detalle"].Value.ToString(), out importeTotal))
                    {
                        nuevoSubtotal += importeTotal;
                    }
                }
                txtTotal.Text = nuevoSubtotal.ToString();
                txtSubtotal.Text = (nuevoSubtotal / 1.16).ToString();

                double totalSinIva = 0;
                double totalConIva = double.Parse(txtTotal.Text);
                double subtotalNuevo= double.Parse(txtSubtotal.Text);
                
                totalSinIva = totalConIva-subtotalNuevo;
                txtIva.Text = totalSinIva.ToString();

            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
            {
                try
                {
                    if (!string.IsNullOrEmpty(txtBuscar.Text))
                    {
                        dataGridProduct.Rows.Clear();
                        List<object[]> datos = products.selectForName(txtBuscar.Text);
                        for (int i = 0; i < datos.Count; i++)
                        {
                            dataGridProduct.Rows.Add(datos[i]);
                        }
                    }
                    txtBuscar.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ALGO OCURRIO","ERROR" + bd.mesError);
                }
            }
        }

        private void lblProduc_Click(object sender, EventArgs e)
        {
            this.FormCaja_Load(sender, e);
        }
    }
}
