using Org.BouncyCastle.Crypto.Digests;
using practica_PDV.CRUD_BACK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_PDV.MIDDEL
{
    public class Sels
    {
        DateTime fechaHora;
        public int client;
        public double monto = 0;
        public static string msgError = ""; 
        Customers customers = new Customers();
        CRUDs_BD bd; 
        public Sels() 
        {
            bd = new CRUD_BACK.MySql();
        }
        public double registrarVenta(int id_client, int total_amount,double pago, List<ProductsToSell> productToSell) 
        {
            double res = 0;
            this.fechaHora = new DateTime();
            fechaHora = fechaHora.ToUniversalTime();
            string newDate = fechaHora.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                List<string> campos = new List<string>()
                {
                    "customer_id","date","total_amount"
                };
                List<ValoresAInsertar> vals = new List<ValoresAInsertar>()
                {
                    new ValoresAInsertar(customers.id.ToString(),false),
                    new ValoresAInsertar(DateTime.Now.ToString("yyyy,MM,dd HH:mm:ss"),true),
                    new ValoresAInsertar(monto.ToString(),false),
                };
                bool registerSale = bd.insert("sales",campos,vals);
                if (registerSale) 
                {
                    int lastSale = int.Parse(bd.selectOne("id","sales","1 ORDER BY id DESC LIMIT 1").ToString());
                    List<string> camposDetalle = new List<string>()
                    {
                        "sales_id","product_id","quantity"
                    };
                    for (int i = 0; i < productToSell.Count; i++) 
                    {
                        List<ValoresAInsertar> valoresDetalle = new List<ValoresAInsertar>() 
                        {
                            new ValoresAInsertar(lastSale.ToString(),false),
                            new ValoresAInsertar(productToSell[i].ToString(),false),
                            new ValoresAInsertar(productToSell[i].ToString(),false)
                        };
                        bool resDetalle = bd.insert("details_sales",camposDetalle,valoresDetalle);
                        if (resDetalle == true)
                        {
                            res = pago - total_amount;
                        }
                        else 
                        {
                            Sels.msgError = bd.mesError;
                            return -1;
                        }
                    }
                }
            }
            catch (Exception)
            {
                res = -1;
                Sels.msgError = bd.mesError; 
            }
            return res; 
        }
    }
}
