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
    public partial class FormSupplier : Form
    {
        CRUDs_BD bd;
        Suppliers supplier = new Suppliers();
        int identi;
        string nombre;
        public FormSupplier()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
            panelBotones.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelBotones.Visible == false)
            {
                panelBotones.Show();
            }
            else
            {
                panelBotones.Hide();
            }
        }
        //--Cargar datos 
        public void cargarDatos() 
        {
            try
            {
                dataGridSupplier.Rows.Clear();
                List<object[]> datos = supplier.selectAllSuppliers();
                for (int i = 0; i < datos.Count; i++)
                {
                    dataGridSupplier.Rows.Add(datos[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message + bd.mesError);
            }
        }

        private void dataGridSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                int celdas = e.RowIndex;
                txtId.Text = dataGridSupplier.Rows[celdas].Cells[0].Value.ToString();
                this.identi = (int)dataGridSupplier.Rows[celdas].Cells[0].Value;
                this.nombre = dataGridSupplier.Rows[celdas].Cells[1].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show($"¿DESEAS ELIMINAR A {nombre}", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) 
                {
                    bool results = supplier.deleteSupplier(this.identi);
                    if (results == true)
                    {
                        MessageBox.Show("PROVEEDOR ELIMINADO CON ÉXITO");
                    }
                    else 
                    {
                        MessageBox.Show("ERROR AL ELIMINAR PROVEEDOR " + bd.mesError);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message + bd.mesError);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form nuevo = new Form();
            nuevo = new FormAddSuppiler();
            nuevo.Show();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {
            FormSupplier_Load(sender,e);
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                dataGridSupplier.Rows.Clear();
                List<object[]> datos = supplier.selectAllSuppliers(txtBuscar.Text);
                for (int i = 0; i < datos.Count; i++)
                {
                    dataGridSupplier.Rows.Add(datos[i]);
                }
            }
            txtBuscar.Clear();
        }
    }
}
