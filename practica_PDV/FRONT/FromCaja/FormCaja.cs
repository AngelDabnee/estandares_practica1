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
        int cantidad;
        string nombre;
        int descuento = 0;
        double total;

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

        //Metodo Cargar Productos
        public void cargarDatos() 
        {
            dataGridProduct.Rows.Clear();
            List<object[]>datos = products.selectAll();
            for(int i = 0; i < datos.Count; i++) 
            {
                dataGridProduct.Rows.Add(datos[i]);


            }
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                this.nombre = dataGridProduct.Rows[celdas].Cells[1].Value.ToString();
                this.total = double.Parse(dataGridProduct.Rows[celdas].Cells[3].Value.ToString());

                int fila = dataGridDesc.Rows.Add();
                cantidad = int.Parse(numericMultiplicador.Value.ToString());
                dataGridDesc.Rows[fila].Cells["cantidad_detalle"].Value = double.Parse(numericMultiplicador.Value.ToString());
                dataGridDesc.Rows[fila].Cells["nameDetalle"].Value = dataGridProduct.Rows[celdas].Cells[1].Value;
                dataGridDesc.Rows[fila].Cells["importe_detalle"].Value = dataGridProduct.Rows[celdas].Cells[3].Value;


            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridDesc.Rows.Clear();
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {
            numericMultiplicador.Value = 1;
            numericMultiplicador.Enabled = false;
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

            }
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SI TUVIESEMOS UNA CAJITA :'C");
        }
    }
}
