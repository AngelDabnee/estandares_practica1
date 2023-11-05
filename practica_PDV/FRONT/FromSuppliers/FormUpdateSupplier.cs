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

namespace practica_PDV.FRONT.FromSuppliers
{
    public partial class FormUpdateSupplier : Form
    {
        Suppliers Suppliers = new Suppliers();
        CRUDs_BD bd;
        int identi;
        string nombre; 

        public FormUpdateSupplier()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }

        private void FormUpdateSupplier_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                txtId.Text = dataGridView1.Rows[celdas].Cells[0].Value.ToString();
                this.identi = (int)dataGridView1.Rows[celdas].Cells[0].Value;
                this.nombre = dataGridView1.Rows[celdas].Cells[1].Value.ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"MODIFICARÁS A '{this.nombre}', ¿DESEAS CONTINUAR?", "MODIFICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (camposCompletos() == true)
                {
                    bool res = Suppliers.updateSuppliers(txtName.Text, txtemail.Text, this.identi);
                    if (res == true)
                    {
                        MessageBox.Show("CLIENTE MODIFICADO CON ÉXITO");
                        this.cargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("ERROR AL MODIFICAR CLIENTE" + Customers.mesError);
                    }
                }
            }
            this.cargarDatos();
        }

        //metodos chidos como siempre
        public void cargarDatos()
        {
            dataGridView1.Rows.Clear();
            List<object[]> datos = Suppliers.selectAllSuppliers();
            for (int i = 0; i < datos.Count; i++)
            {
                dataGridView1.Rows.Add(datos[i]);
            }
        }
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                txtName.Clear();
                txtemail.Clear();


            }
            else
            {
                txtName.Clear();
                txtemail.Clear();

            }
        }
        private bool camposCompletos()
        {
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS");
                return false;
            }
            return true;
        }
    }
}
