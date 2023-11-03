using Org.BouncyCastle.Bcpg;
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
    public partial class FormInsertUsers : Form
    {
        CRUDs_BD bd; 
        User user = new User();
        public FormInsertUsers()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("REGISTRA NUEVO USUARIO", "CREAR UN REGISTRO", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) 
                {
                    if (camposCompletos() == true) 
                    {
                        if (txtPassword.Text == txtConfirmar.Text)
                        {
                            bool result = user.insertUser(txtName.Text, txtemail.Text, txtPassword.Text);
                            if (result == true)
                            {
                                MessageBox.Show("USUARIO CREADO EXITOSAMENTE");
                                this.limpiarForm(true);
                            }
                            else
                            {
                                MessageBox.Show("ERROR AL CREAR USUARIO " + bd.mesError);
                            }
                        }
                        else
                        {
                            MessageBox.Show("LAS CONTRASEÑAS NO CONCUERDAN");
                            txtPassword.Clear();
                            txtConfirmar.Clear();
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }
        //metodos para validar que los campos estén llenos 
        private bool camposCompletos() 
        {
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtemail.Text) && string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtConfirmar.Text)) 
            {
                MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS");
                return false; 
            }
            return true; 
        }
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                txtName.Clear();
                txtemail.Clear();
                txtPassword.Clear();
                txtConfirmar.Clear();
            }
            else
            {
                txtName.Clear();
                txtemail.Clear();
                txtPassword.Clear();
                txtConfirmar.Clear();
            }
        }
    }
}
