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
        int identi; 
        
        public FromSelect()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }
        private void FromSelect_Load(object sender, EventArgs e)
        {

            dataGridProduct.ReadOnly = true;
            this.cargarDatos();
            menu.Hide();
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            dataGridProduct.Rows.Clear();
            List<object[]> datos = products.selectForName(txtName.Text);//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridProduct.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]
            }

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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menu.Visible == false)
            {
                menu.Show();
            }
            else
            {
                menu.Hide();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("¿DESEAS CONTINUAR","ELIMINAR",MessageBoxButtons.YesNo);
            if(delete == DialogResult.Yes) 
            {
                bool res = products.delete(this.identi);
                if (res == false)
                {
                    MessageBox.Show("PRODUCTO ELIMINADO CON ÉXITO");
                    this.cargarDatos();
                }
                else
                {
                    MessageBox.Show("ERROR AL ELIMINAR PRODUCTO " + Products.msgError);
                }
            }
            this.cargarDatos();
        }
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                txtName.Enabled = true;
                txtName.Clear();

            }
            else
            {
                txtName.Enabled = false;
                txtName.Clear();
            }
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                txtId.Text = dataGridProduct.Rows[celdas].Cells[0].Value.ToString();
                this.identi = (int)dataGridProduct.Rows[celdas].Cells[0].Value;
            }
        }
    }
}
