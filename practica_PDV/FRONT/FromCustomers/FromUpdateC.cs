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

namespace practica_PDV.FRONT.FromCustomers.FormUpdateCustomers
{
    public partial class FromUpdateC : Form
    {
        Customers customers = new Customers();
        CRUDs_BD bd;
        int identi;
        string nombre; 
        public FromUpdateC()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }
        private void FromUpdateC_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }
        public void cargarDatos() 
        {
            dataGridCustomers.Rows.Clear();
            List<object[]> datos = customers.selectAllCustomers();
            for (int i = 0; i < datos.Count; i++)
            {
                dataGridCustomers.Rows.Add(datos[i]);
            }
        }

        private void dataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                txtId.Text = dataGridCustomers.Rows[celdas].Cells[0].Value.ToString();
                txtName.Text = dataGridCustomers.Rows[celdas].Cells[1].Value.ToString();
                txtEmail.Text = dataGridCustomers.Rows[celdas].Cells[2].Value.ToString();
                txtPhone.Text = dataGridCustomers.Rows[celdas].Cells[3].Value.ToString();
                txtAddress.Text = dataGridCustomers.Rows[celdas].Cells[4].Value.ToString();
                this.identi = (int)dataGridCustomers.Rows[celdas].Cells[0].Value;
                this.nombre = dataGridCustomers.Rows[celdas].Cells[1].Value.ToString();

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"MODIFICARÁS A '{this.nombre}', ¿DESEAS CONTINUAR?","MODIFICAR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes) 
            {
                if (camposCompletos() == true)
                {
                    bool res = customers.updateCustomers(txtName.Text, txtEmail.Text, txtPhone.Text, txtAddress.Text, this.identi);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                txtName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
            }
            else
            {
                txtName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
            }
        }
        private bool camposCompletos()
        {
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtPhone.Text) && string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS");
                return false;
            }
            return true;
        }
    }
}
