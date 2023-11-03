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
    public partial class FormAddSuppiler : Form
    {
        CRUDs_BD bd; 
        Suppliers supplier = new Suppliers();

        public FormAddSuppiler()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("REGISTRAR NUEVO PROVEEDOR","REGISTRAR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (camposCompletos() == true) 
            {
                if (dialog == DialogResult.Yes)
                {
                    bool result = supplier.insertSuppler(txtName.Text, txtemail.Text);
                    if (result)
                    {
                        MessageBox.Show("PROVEEDOR REGISTRADO EXITOSAMENTE");
                        this.limpiarform(true);
                    }
                    else
                    {
                        MessageBox.Show("ERROR AL REGISTRAR EL PROVEEDOR" + bd.mesError);
                    }
                }
            }
        }

        //metodos para datos completos. 
        private bool camposCompletos()
        {
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS");
                return false;
            }
            return true;
        }
        //limpiar form
        private void limpiarform(bool habilitar) 
        {
            if (habilitar) 
            {
                txtName.Clear();
                txtemail.Clear();
            }
        }
    }
}
