﻿using practica_PDV.CRUD_BACK;
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

namespace practica_PDV.FRONT.FromCustomers.FormNewCustomers
{
    public partial class FormInsertCustomer : Form
    {
        Customers customers = new Customers();
        CRUDs_BD bd; 
        public FormInsertCustomer()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Deseas Continuar","Añadir",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (camposCompletos() == true)
                {
                    bool results = customers.insertCustomers(txtName.Text, txtemail.Text, txtphone.Text, txtaddress.Text);
                    if (results == true)
                    {
                        MessageBox.Show("CLIENTE REGISTRADO EXITOSAMENTE");
                        this.limpiarForm(true);
                    }
                    else
                    {
                        MessageBox.Show($"ERROR AL REGISRAR {bd.mesError}");
                    }
                }
            }
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
                txtaddress.Clear();
                txtemail.Clear();
                txtphone.Clear();
            }
            else
            {
                txtName.Clear();
                txtaddress.Clear();
                txtemail.Clear();
                txtphone.Clear();
            }
        }
        private bool camposCompletos()
        {
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtemail.Text) && string.IsNullOrEmpty(txtphone.Text) && string.IsNullOrEmpty(txtaddress.Text))
            {
                MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS");
                return false;
            }
            return true;
        }
    }
}
