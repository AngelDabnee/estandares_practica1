using practica_PDV.CRUD_BACK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_PDV.MIDDEL
{
    internal class Sell
    {
        DateTime fechaHora;
        public int client;
        public double monto = 0;
        public static string msgError = "";
        Customers customers = new Customers();
        CRUDs_BD bd;

        public Sell() 
        {
            bd = new CRUD_BACK.MySql();
        }
        public double registrarVenta(int id_client, double total_amount, List<ProductsToSell> productToSell)
        {
            double res = 0;
            this.fechaHora = new DateTime();
            fechaHora = fechaHora.ToUniversalTime();
            string newDate = fechaHora.ToString("yyyy-MM-dd HH:mm:ss");
            double pago = 0;
            try
            {
                List<string> campos = new List<string>()
                {
                    "customer_id","date","total_amount"
                };
                List<ValoresAInsertar> vals = new List<ValoresAInsertar>()
                {
                    new ValoresAInsertar(id_client.ToString(),false),
                    new ValoresAInsertar(DateTime.Now.ToString("yyyy,MM,dd HH:mm:ss"),true),
                    new ValoresAInsertar(total_amount.ToString(),true),
                };
                bool registerSale = bd.insert("sales", campos, vals);
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
