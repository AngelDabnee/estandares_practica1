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
    public partial class FromUsers : Form
    {
        CRUDs_BD bd;
        User user = new User();
        int identi;
        string nombre; 
        public FromUsers()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
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

        private void FromUsers_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        //------cargar datos. 
        public void cargarDatos()
        {
            try
            {
                dataGridUser.Rows.Clear();
                List<object[]> datos = user.selectAllUser();
                for (int i = 0; i < datos.Count; i++)
                {
                    dataGridUser.Rows.Add(datos[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ALGO SALIÓ MAL " + bd.mesError + ex.Message);
            }
        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                txtId.Text = dataGridUser.Rows[celdas].Cells[0].Value.ToString();
                this.identi = (int)dataGridUser.Rows[celdas].Cells[0].Value;
                this.nombre= dataGridUser.Rows[celdas].Cells[1].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show($"¿DESEAS ELIMINAR A {nombre}", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) 
                {
                    bool result = user.deleteUser(this.identi);
                    if (result == true)
                    {
                        MessageBox.Show("USUARIO ELIMINADO CON ÉXITO");
                        this.FromUsers_Load(sender, e);

                    }
                    else 
                    {
                        MessageBox.Show("SELECCIONA UN CAMPO" + bd.mesError);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message + "ó" + bd.mesError);
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {
            this.FromUsers_Load(sender, e);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form nuevo = new Form();
            nuevo = new FormInsertUsers();
            nuevo.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form nuevo = new Form();
            nuevo = new FromUpdateUser();
            nuevo.Show();
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                dataGridUser.Rows.Clear();
                List<object[]> datos = user.selectForName(txtBuscar.Text);
                for (int i = 0; i < datos.Count; i++)
                {
                    dataGridUser.Rows.Add(datos[i]);
                }
            }
            txtBuscar.Clear();
        }
    }
}
