using practica_PDV.CRUD_BACK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_PDV.MIDDEL
{
    public class Suppliers
    {
        public int id;
        public string name;
        public string email;
        public static string mesError;
        CRUDs_BD bd;

        public Suppliers() 
        {
            bd = new CRUD_BACK.MySql();
        }

        public bool insertSuppler(string name, string email) 
        {
            List<string> campos = new List<string>()
            {
                "name","email"
            };
            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(name));
            vals.Add(new ValoresAInsertar(email));
            bool results = this.bd.insert("suppliers",campos,vals);
            
            return results;
        }
        public bool deleteSupplier(int id) 
        {
            bool results = this.bd.delete("suppliers",id);
            if (results == false)
            {
                Suppliers.mesError = this.bd.mesError;
            }
            return results; 
        }
        public bool updateSuppliers(string name, string email,int id) 
        {
            List<string> campos = new List<string> 
            { 
                "name","email" 
            };
            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(name));
            vals.Add(new ValoresAInsertar(email));

            bool results = this.bd.update("suppliers", campos, vals, id);
            if (results == false) 
            {
                Suppliers.mesError = this.bd.mesError;
            }
            return results;
        }
        public List<object[]> selectAllSuppliers() 
        {
            return this.bd.selectAll("suppliers");
        }
        public List<object[]> selectAllSuppliers(string name) 
        {
            return this.bd.selectAll("suppliers","name='"+name+"'");
        }
    }
}
