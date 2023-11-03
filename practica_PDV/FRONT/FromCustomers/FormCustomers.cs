using practica_PDV.CRUD_BACK;
using practica_PDV.FRONT.FromCustomers.FormNewCustomers;
using practica_PDV.FRONT.FromCustomers.FormUpdateCustomers;
using practica_PDV.FRONT.FromInsert;
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
using System.Xml.Linq;

namespace practica_PDV.FRONT.FromCustomers
{
    public partial class FormCustomers : Form
    {
        CRUDs_BD bd;
        Customers customers = new Customers();
        int identi;
        string nombre; 
        public FormCustomers()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            this.cargarDatos();

        }


        //----metodo para cargar datos al data. 
        public void cargarDatos()
        {
            dataGridCustomers.Rows.Clear();
            List<object[]> datos = customers.selectAllCustomers();
            for (int i = 0; i < datos.Count; i++)
            {
                dataGridCustomers.Rows.Add(datos[i]);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form nuevo = new Form();
            nuevo = new FormInsertCustomer();
            nuevo.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show($"¿DESEA ELIMINAR AL {this.nombre}", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                bool res = customers.deleteCustomers(this.identi);
                if (res == false)
                {
                    MessageBox.Show("CLIENTE ELIMINADO CON ÉXITO");
                    this.FormCustomers_Load(sender,e);
                }
                else
                {
                    MessageBox.Show("ERROR AL ELIMINAR CLIENTE" + Customers.mesError);
                }
            }
        }

        private void dataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                txtId.Text = dataGridCustomers.Rows[celdas].Cells[0].Value.ToString();
                this.identi = (int)dataGridCustomers.Rows[celdas].Cells[0].Value;
                this.nombre = dataGridCustomers.Rows[celdas].Cells[1].Value.ToString();

            }
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBuscar.Text)) 
            {
                dataGridCustomers.Rows.Clear();
                List<object[]> datos = customers.selectForNameCustomers(txtBuscar.Text);
                for (int i = 0; i < datos.Count; i++)
                {
                    dataGridCustomers.Rows.Add(datos[i]);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form nuevo = new Form();
            nuevo = new FromUpdateC();
            nuevo.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelAction.Visible == false)
            {
                panelAction.Show();
            }
            else
            {
                panelAction.Hide();
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {
            this.FormCustomers_Load(sender,e);
        }
    }
}
