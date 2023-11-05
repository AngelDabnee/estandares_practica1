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

namespace practica_PDV.FRONT.FromUsers
{
    public partial class FromUpdateUser : Form
    {
        User user = new User();
        CRUDs_BD bd;
        int identi;
        string nombre; 
        public FromUpdateUser()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FromUpdateUser_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }
        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                txtId.Text = dataGridUser.Rows[celdas].Cells[0].Value.ToString();
                txtName.Text = dataGridUser.Rows[celdas].Cells[1].Value.ToString();
                txtemail.Text = dataGridUser.Rows[celdas].Cells[2].Value.ToString();
                txtPassword.Text = dataGridUser.Rows[celdas].Cells[3].Value.ToString();
                this.identi = (int)dataGridUser.Rows[celdas].Cells[0].Value;
                this.nombre = dataGridUser.Rows[celdas].Cells[1].Value.ToString();

            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"MODIFICARÁS A '{this.nombre}', ¿DESEAS CONTINUAR?", "MODIFICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (camposCompletos() == true)
                {
                    bool res = user.updateUser(txtName.Text, txtemail.Text, txtPassword.Text, this.identi);
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
        //Metodos cool
        public void cargarDatos()
        {
            dataGridUser.Rows.Clear();
            List<object[]> datos = user.selectAllUser();
            for (int i = 0; i < datos.Count; i++)
            {
                dataGridUser.Rows.Add(datos[i]);
            }
        }
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                txtName.Clear();
                txtemail.Clear();
                txtId.Clear();
                txtPassword.Clear();
            }
            else
            {
                txtName.Clear();
                txtemail.Clear();
                txtId.Clear();
                txtPassword.Clear();
            }
        }
        private bool camposCompletos()
        {
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtemail.Text) && string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS");
                return false;
            }
            return true;
        }
    }
}
