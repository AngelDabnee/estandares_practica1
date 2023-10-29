using practica_PDV.CRUD_BACK;
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


namespace practica_PDV.FromProductos
{
    public partial class FromSelect : Form
    {
        CRUDs_BD bd;
        Products products = new Products();
        
        public FromSelect()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }
        private void FromSelect_Load(object sender, EventArgs e)
        {

            dataGridProduct.ReadOnly = true;
            this.cargarDatos();
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            dataGridProduct.Rows.Clear();
            List<object[]>product = products.selectForName(txtName.Text);
            for(int i = 0;i < product.Count;i++) 
            {
                dataGridProduct.Rows.Add(product[i]);
            }
            this.cargarDatos();
        }
        public void cargarDatos() 
        {
            dataGridProduct.Rows.Clear();
            List<object[]> product = products.selectAll();
            for (int i = 0; i < product.Count; i++)
            {
                dataGridProduct.Rows.Add(product[i]);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form nuevo = new Form();
            nuevo = new FormInsert();
            nuevo.Show();
        }
    }
}
