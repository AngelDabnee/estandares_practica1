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
using practica_PDV.FRONT;
using practica_PDV.FRONT.FromCustomers.FormNewCustomers;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace practica_PDV.FRONT.FromCaja
{
    public partial class FormCaja : Form
    {
        CRUDs_BD bd;
        Products products; 
        Customers customers;
        Sell sell;
        double cantidad;
        string nombre;
        double total;
        double subtotal;
        List<int> idProductos;
        List<int> cantidadProductos;
        int identifi;
        private List<int> cantidadProductosComprados;

        //como no salió hicimos algo cochi 
        MySqlConnection con = new MySqlConnection("server=localhost;database=practica_pdv;uid=root;pwd=;");
        MySqlCommand comando;
        MySqlDataReader leer;
        String comandoSelect = "";

        public FormCaja()
        {
            InitializeComponent();
            products = new Products();
            sell = new Sell();
            idProductos = new List<int>();
            cantidadProductos = new List<int>();  
            customers = new Customers();
            cantidadProductosComprados = new List<int>();
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
        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (numericMultiplicador.Value > 0) 
                {
                    int celdas = e.RowIndex;
                    this.nombre = dataGridProduct.Rows[celdas].Cells[1].Value.ToString();
                    this.total = double.Parse(dataGridProduct.Rows[celdas].Cells[3].Value.ToString());
                    //int idProductoSeleccionado = Convert.ToInt32(dataGridProduct.Rows[celdas].Cells["id"].Value);
                    //idProductos.Add(idProductoSeleccionado);

                    int fila = dataGridDesc.Rows.Add();
                    cantidad = double.Parse(numericMultiplicador.Value.ToString());
                    dataGridDesc.Rows[fila].Cells["cantidad_detalle"].Value = double.Parse(numericMultiplicador.Value.ToString());
                    dataGridDesc.Rows[fila].Cells["nameDetalle"].Value = dataGridProduct.Rows[celdas].Cells[1].Value;
                    dataGridDesc.Rows[fila].Cells["id_detalle"].Value = dataGridProduct.Rows[celdas].Cells[0].Value;
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
            dataGridCustomers.Rows.Clear();
            List<object[]> datos2 = customers.selectAllCustomers();
            for (int i = 0; i < datos2.Count; i++) 
            {
                dataGridCustomers.Rows.Add(datos2[i]);
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
                total = double.Parse(txtTotal.Text);
                double subtotalNuevo= double.Parse(txtSubtotal.Text);
                
                totalSinIva = total-subtotalNuevo;
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
                catch (Exception )
                {
                    MessageBox.Show("ALGO OCURRIO","ERROR" + bd.mesError);
                }
            }
        }

        private void lblProduc_Click(object sender, EventArgs e)
        {
            this.FormCaja_Load(sender, e);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                double total = double.Parse(txtTotal.Text);
                double cantidadRecibida = double.Parse(txtMonto.Text);
                //double cambio = 0;
                double res = (cantidadRecibida - total); 
                txtCambio.Text = res.ToString(); 

                //se armó
                //preparamos las vars para registra la venta
                List<ProductsToSell> prodsAVender = new List<ProductsToSell>();

                //cambio
                int idCliente = int.Parse(txtId.Text.ToString());
                comandoSelect = $"INSERT INTO sales (customer_id,date,total_amount) VALUES('{idCliente}',CURDATE(),'{total}');";
                con.Open();
                comando = new MySqlCommand(comandoSelect, con);
                comando.ExecuteNonQuery();

                comandoSelect = "SELECT LAST_INSERT_ID() FROM sales";
                double feria = 0;
                comando = new MySqlCommand(comandoSelect,con);
                string id = (comando.ExecuteScalar().ToString());
                foreach (DataGridViewRow datos in dataGridDesc.Rows) 
                {
                    comandoSelect = $"INSERT INTO details_sales(sales_id, product_id, quantity) VALUES ('{id}', '{datos.Cells[0].Value}', '{datos.Cells[1].Value}')";
                    comando = new MySqlCommand(comandoSelect, con);
                    comando.ExecuteNonQuery();
                }

                if (feria == -1)
                {
                    MessageBox.Show("ERROR AL REGISTRAR LA VENTA" + Sels.msgError);
                }
                else
                {
                    double numRedon = Math.Round(feria, 2);//CON ESTO REDONDEAMOS. 
                    MessageBox.Show($"VENTA REGISTRADA CON ÉXITO");
                    MessageBox.Show($"SU CAMBIO ES {numRedon}");
                    this.cargarDatos();
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Algo salió mal");
            }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (dataGridCustomers.Visible == false)
            {
                dataGridCustomers.Show();
                this.cargarDatos();
            }
            else
            {
                dataGridCustomers.Hide();
                this.cargarDatos();
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Form nuevo = new Form();
            nuevo = new FormInsertCustomer();
            nuevo.Show();
        }

        private void dataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                this.identifi = (int)dataGridCustomers.Rows[celdas].Cells[0].Value;
                this.nombre = dataGridCustomers.Rows[celdas].Cells[1].Value.ToString();

                txtId.Text = this.identifi.ToString();

            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
