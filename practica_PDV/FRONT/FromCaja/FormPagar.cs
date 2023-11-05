using practica_PDV.CRUD_BACK;
using practica_PDV.FRONT.FromCustomers.FormNewCustomers;
using practica_PDV.MIDDEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_PDV.FRONT.FromCaja
{
    public partial class FormPagar : Form
    {
        CRUDs_BD bd;
        Sels sell;
        Customers customers;
        Products productsToSell;

        string nombre;
        int identifi;
        private List<int> idProductos;
        private double totalAPagar;
        private List<int> cantidadProductosComprados;
        double pago; 
        public FormPagar(List<int> ids, double totalPagar, List<int> cantidadComprada)
        {
            InitializeComponent();
            productsToSell = new Products();
            sell = new Sels();
            customers = new Customers();
            idProductos = ids;
            totalAPagar = totalPagar;
            cantidadProductosComprados = cantidadComprada;

            bd = new CRUD_BACK.MySql();


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form nuevo = new Form();
            nuevo = new FormInsertCustomer();
            nuevo.Show();
        }


        //Metodo para cargar datos, otra vez 
        public void cargarDatos()
        {
            dataGridCustomers.Rows.Clear();
            List<object[]> datos = customers.selectAllCustomers();
            for (int i = 0; i < datos.Count; i++)
            {
                dataGridCustomers.Rows.Add(datos[i]);


            }
        }

        private void FormPagar_Load(object sender, EventArgs e)
        {
            txtTotalAPagar.Text = totalAPagar.ToString();
            //string idTexto = string.Join(", ", cantidadProductosComprados.Select(cantidad => cantidad.ToString()));
            //MessageBox.Show("Recibimos: " + idTexto,totalAPagar.ToString());
            this.cargarDatos();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    if (!string.IsNullOrEmpty(txtBuscar.Text))
                    {
                        dataGridCustomers.Rows.Clear();
                        List<object[]> datos = customers.selectForNameCustomers(txtBuscar.Text);
                        for (int i = 0; i < datos.Count; i++)
                        {
                            dataGridCustomers.Rows.Add(datos[i]);
                        }
                    }
                    txtBuscar.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ALGO OCURRIO", "ERROR" + bd.mesError);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {
            this.FormPagar_Load(sender, e);
        }

        private void dataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                this.identifi = (int)dataGridCustomers.Rows[celdas].Cells[0].Value;
                this.nombre = dataGridCustomers.Rows[celdas].Cells[1].Value.ToString();

                txtIdCliente.Text = this.identifi.ToString();

            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double total = double.Parse(txtTotalAPagar.Text);
            double cantidadRecibida = double.Parse(txtCantidadRecibida.Text);
            double cambio = cantidadRecibida - total;
            txtCambio.Text = cambio.ToString();

            List<ProductsToSell> productosVendidos = new List<ProductsToSell>();
            for (int i = 0; i < idProductos.Count; i++)
            {
                int idProducto = idProductos[i];
                int cantidadVendida = cantidadProductosComprados[i];
                ProductsToSell producto = new ProductsToSell(idProducto, cantidadVendida);
                productosVendidos.Add(producto);
            }
            double registrarVenta = sell.registrarVenta(int.Parse(txtIdCliente.Text), totalAPagar, productosVendidos);

        }
    }
}
