using practica_PDV.CRUD_BACK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practica_PDV.MIDDEL
{
    public class Customers
    {
        public int id;
        public string name;
        public string email;
        public string password;
        public static string mesError;
        CRUDs_BD bd;


        public Customers() 
        {
            bd = new CRUD_BACK.MySql();
        }


        public bool insertCustomers(string name, string email, string phone, string address) 
        {
            List<string> campos = new List<string>()
            {
                "name","email","phone","address"
            };
            List<ValoresAInsertar> valores = new List<ValoresAInsertar>();
            valores.Add(new ValoresAInsertar(name));
            valores.Add(new ValoresAInsertar(email));
            valores.Add(new ValoresAInsertar(phone));
            valores.Add(new ValoresAInsertar(address));

            bool results = this.bd.insert("customers",campos,valores);
            if (results) 
            {
                Customers.mesError = this.bd.mesError;
            }
            return results;
        }
        public bool deleteCustomers(int id) 
        {
            bool results = this.bd.delete("customers", id);
            if (results == false)
            {
                Customers.mesError = this.bd.mesError;
            }
            return results;
        }
        public bool updateCustomers(string name, string email, string phone, string address,int id) 
        {
            List<string> campos = new List<string>()
            {
                "name","email","phone","address"
            };
            List<ValoresAInsertar> valores = new List<ValoresAInsertar>();
            valores.Add(new ValoresAInsertar(name));
            valores.Add(new ValoresAInsertar(email));
            valores.Add(new ValoresAInsertar(phone));
            valores.Add(new ValoresAInsertar(address));

            bool results = this.bd.update("customers", campos, valores,id);
            if (results)
            {
                Customers.mesError = this.bd.mesError;
            }
            return results;
        }
        public List<object[]> selectAllCustomers() 
        {
            return this.bd.selectAll("customers");
        }
        public List<object[]> selectForNameCustomers(string name) 
        {
            return this.bd.selectAll("customers","name='" + name + "'");
        }

    }
}
