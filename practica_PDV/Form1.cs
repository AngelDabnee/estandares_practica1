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
using MySqlX.XDevAPI.Relational;
using practica_PDV.FromProductos;

namespace practica_PDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openHijoFrom(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelFrom.Controls.Add(form);
            panelFrom.Tag = form;
            form.Show();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FromSelect());
            panelControls.Hide();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            panelControls.Show();
        }
    }
}
