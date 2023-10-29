using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Crypto.Digests;
using practica_PDV.CRUD_BACK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace practica_PDV.MIDDEL
{
    public class Products
    {
        public int id;
        public string name;
        public string description;
        public double price;
        public int quantity_in_stock;
        public static string msgError;
        CRUDs_BD bd; 

        public Products() 
        {
            bd = new CRUD_BACK.MySql();
        }
        public bool insert(string name, string description, double price, int quantity_in_stock)
        {
            List<string> listCampos = new List<string>()
            {
                "name","description","price","quantity_in_stock"
            };
            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(name));
            vals.Add(new ValoresAInsertar(description));
            vals.Add(new ValoresAInsertar(price.ToString(),false));
            vals.Add(new ValoresAInsertar(quantity_in_stock.ToString(),false));

            bool results = this.bd.insert("products",listCampos,vals);
            if (results == false) 
            {
                Products.msgError = this.bd.mesError;
            }
            return results;
        }
        public bool update(string name, string description, double price, int quantity_in_stock,int id) 
        {
            List<string> listCampos = new List<string>()
            {
                "name","description","price","quantity_in_stock"
            };
            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(name));
            vals.Add(new ValoresAInsertar(description));
            vals.Add(new ValoresAInsertar(price.ToString(), false));
            vals.Add(new ValoresAInsertar(quantity_in_stock.ToString(), false));

            bool results = this.bd.update("products", listCampos, vals,id);
            if (results == false)
            {
                Products.msgError = this.bd.mesError;
            }
            return results;
        }
        public bool delete(int id) 
        {
            bool result = this.bd.delete("products",id);
            if (result == false) 
            {
                Products.msgError= this.bd.mesError;
            }
            return result;
        }
        public List<object[]> selectAll() 
        {
            return this.bd.selectAll("products");
        }
        public double selectForPrice(int id) 
        {
            List<object[]> results = this.bd.selectOne("price","products","product_id=" + id);
            double price = 0;
            if (results.Count == 1)
            {
                object[] tempo = results[0];
                price = double.Parse(tempo[3].ToString());
            }
            else 
            {
                Products.msgError=(this.bd.mesError);
                price = -1;
            }
            return price;
        }
        public List<object[]> selectForName(string name) 
        {
            List<object[]> results = this.bd.selectOne("name","products","name=" + "'name'");
            return results;
        }
    }
}
