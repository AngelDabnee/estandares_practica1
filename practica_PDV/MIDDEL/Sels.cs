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
                bool registerSale = bd.insert("sales",campos,vals);
                if (registerSale) 
                {
                    object lastSaleObj = bd.selectOne("id", "sales", "1 ORDER BY id DESC LIMIT 1");
                    int lastSale = 0; // Valor predeterminado en caso de que no haya resultados válidos

                    if (lastSaleObj != null && int.TryParse(lastSaleObj.ToString(), out lastSale))
                    {
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

                            bool resDetalle = bd.insert("details_sales", camposDetalle, valoresDetalle);

                            if (resDetalle)
                            {
                                pago = total_amount;
                                res = pago - total_amount;
                            }
                            else
                            {
                                Sels.msgError = bd.mesError;
                                return -1;
                            }
                        }
                    }
                    else
                    {
                        // Manejo de error o mensaje de registro no encontrado
                        Sels.msgError = "No se encontró un registro válido en la tabla 'sales'";
                        return -1;
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
