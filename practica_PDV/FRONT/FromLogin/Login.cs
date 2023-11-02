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

namespace practica_PDV.LOGIN
{
    public partial class Login : Form
    {
        CRUDs_BD bd; 
        User user = new User();
        public Login()
        {
            bd = new CRUD_BACK.MySql();
            InitializeComponent();
        }

        private void iconPictureShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void iconPictureHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar=true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            user = user.login(txtEmail.Text,txtPassword.Text);
            try
            {
                if (user == null)
                {
                    MessageBox.Show("LAS CREDENCIALES NO CONCUERDAN");
                }
                else
                {
                    this.Hide();
                    Form form1 = new Form1();
                    form1.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
        }
    }
}
