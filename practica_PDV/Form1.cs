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


namespace practica_PDV
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=practica_pdv;uid=root;pwd=;");
        MySqlCommand comando;
        MySqlDataReader leer;
        String comandoSelect = "";
        String cantidad = "";
        double sumaTotal = 0;
        double descuento = 0;
        int rows = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            
            try
            {
                string email = txt_email.Text;
                if(con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    comando = new MySqlCommand($"SELECT name FROM customers WHERE email = '{email}';");
                    comando.Connection = con;
                    leer = comando.ExecuteReader();
                    if (leer.HasRows) {
                        MessageBox.Show("encontramos algo");
                    }
                }


            }
            catch (MySqlException mes)
            {
                MessageBox.Show($"Error de db{mes}");
                
            }catch (Exception ex) {
                MessageBox.Show($"Error General de algo{ex}");
            }

        }
    }
}
