using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using practica_PDV.CRUD_BACK;
using practica_PDV.FRONT.FromInsert;
using practica_PDV.MIDDEL;


namespace practica_PDV.FRONT.FromProductos.FromUpdate
{
    public partial class FormUpdateProduc : Form
    {
        Products products = new Products();
        CRUDs_BD bd;
        int identifi;
        string nombre; 
        public FormUpdateProduc()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }
        //--cargar dato
        public void cargarDatos() 
        {
            dataGridProducts.Rows.Clear();
            List<object[]> datos = products.selectAll();
            for (int i = 0; i < datos.Count; i++)
            {
                dataGridProducts.Rows.Add(datos[i]);
            }
        }
        private void FormUpdateProduc_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void dataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                txtId.Text = dataGridProducts.Rows[celdas].Cells[0].Value.ToString();
                txtName.Text = dataGridProducts.Rows[celdas].Cells[1].Value.ToString();
                txtDescription.Text = dataGridProducts.Rows[celdas].Cells[2].Value.ToString();
                txtPrice.Text = dataGridProducts.Rows[celdas].Cells[3].Value.ToString();
                txtquantityInStock.Value = (int)dataGridProducts.Rows[celdas].Cells[4].Value;
                this.identifi= (int)dataGridProducts.Rows[celdas].Cells[0].Value;
                this.nombre = dataGridProducts.Rows[celdas].Cells[1].Value.ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show($"MODIFICARÁS A '{this.nombre}', ¿DESEAS CONTINUAR?", "MODIFICAR", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    bool result = products.update(txtName.Text, txtDescription.Text, double.Parse(txtPrice.Text), int.Parse(txtquantityInStock.Value.ToString()), identifi);
                    if (result == true)
                    {
                        MessageBox.Show("PRODUCTO MODIFICADO CON ÉXITO");
                    }
                    else
                    {
                        MessageBox.Show("ERROR AL MODIFICAR EL PRODICTO " + bd.mesError);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR GENERAL DE WINDOWS");
                }
                this.cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR GENERAL" + ex.Message);
            }
        }
    }
}
