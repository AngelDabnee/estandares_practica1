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
using System.Xml.Linq;

namespace practica_PDV.FRONT.FromInsert
{
    public partial class FormInsert : Form
    {
        Products produc = new Products();
        CRUDs_BD bd;
        public FormInsert()
        {
            InitializeComponent();
            bd = new CRUD_BACK.MySql();
        }

        private void FormInsert_Load(object sender, EventArgs e)
        {
            if (textName.Enabled == true && textPrice.Enabled == true && textDescription.Enabled == true && textquantityInStock.Enabled == true && btnInsert.Enabled == true) 
            {
                this.limpiarForm(false);
            }
        }

        private void textPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) 
            {
                e.Handled = true;
            }
            if((e.KeyChar =='.') && ((sender as TextBox).Text.IndexOf('.')>-1)) 
            {
                e.Handled= true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Deseas Continuar?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (camposCompletos() == true) 
                {
                    bool result = produc.insert(textName.Text, textDescription.Text, double.Parse(textPrice.Text), int.Parse(textquantityInStock.Value.ToString()));
                    if (result == false)
                    {
                        MessageBox.Show($"ERROR AL CARGAR PRODUCTO{Products.msgError}");
                    }
                    else
                    {
                        MessageBox.Show("PRODUCTO CARGADO CON ÉXITO");
                        this.limpiarForm(false);
                        this.FormInsert_Load(sender, e);
                    }
                }
            }
            else 
            {
                this.Close();   
            }
        }
        //Metodos pa los txt
        public void limpiarForm(bool habilita) 
        {
            if (habilita)
            {
                textName.Enabled = true;
                textName.Clear();
                textPrice.Enabled = true;
                textPrice.Clear();
                textDescription.Enabled = true;
                textDescription.Clear();
                textquantityInStock.Enabled = true;
                textquantityInStock.Value = 0;
                btnInsert.Enabled = true; 
            }
            else 
            {
                textName.Enabled = false;
                textName.Clear();
                textPrice.Enabled = false;
                textPrice.Clear();
                textDescription.Enabled = false;
                textDescription.Clear();
                textquantityInStock.Enabled = false;
                textquantityInStock.Value = 0;
                btnInsert.Enabled= false;
            }
        }
        private bool camposCompletos()
        {
            if (string.IsNullOrEmpty(textName.Text) && !decimal.TryParse(textPrice.Text,out decimal price) && string.IsNullOrEmpty(textDescription.Text) && textquantityInStock.Value <=0 )
            {
                MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS");
                return false;
            }
            return true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (textName.Enabled == false && textPrice.Enabled == false && textDescription.Enabled == false && textquantityInStock.Enabled == false)
            {
                this.limpiarForm(true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
