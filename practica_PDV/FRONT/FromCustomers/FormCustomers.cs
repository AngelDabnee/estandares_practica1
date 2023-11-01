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

namespace practica_PDV.FRONT.FromCustomers
{
    public partial class FormCustomers : Form
    {
        CRUDs_BD bd;
        Customers customers = new Customers();
        int identi;
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

    }
}
