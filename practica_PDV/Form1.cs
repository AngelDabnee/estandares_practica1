﻿using System;
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
using practica_PDV.FRONT.FromCustomers;
using practica_PDV.FRONT.FromSuppliers;
using practica_PDV.FRONT.FromUsers;
using practica_PDV.FRONT.FromCaja;

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
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
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

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FormCustomers());
            panelControls.Hide();
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FromUsers());
            panelControls.Hide();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FormSupplier());
            panelControls.Hide();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FormCaja());
            panelControls.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
