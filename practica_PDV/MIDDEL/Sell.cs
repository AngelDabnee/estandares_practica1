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
        DateTime dataTime;
        public int userid;
        public double amount;
        public static string mesError = "";
        User sesion = new User();
        CRUDs_BD bd;


        public Sell() 
        {
            bd = new CRUD_BACK.MySql();
        }
        public double registerSell(int userid, double amount, double pay, List<ProductsToSell> productsToSells) 
        {
            double result = 0;
            this.dataTime = new DateTime();
            dataTime = dataTime.ToUniversalTime();
            string newDateTime = dataTime.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                List<string> campos = new List<string>()
                {
                    "customer_id","date","total_amount"
                };
                List<ValoresAInsertar> vals = new List<ValoresAInsertar>()
                {
                    new ValoresAInsertar(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),true),
                    new ValoresAInsertar(sesion.id.ToString(),false),
                    new ValoresAInsertar(amount.ToString(),true)
                };
                bool registerSell = bd.insert("sales",campos, vals);
                if (registerSell) 
                {
                    int lastIdSell = int.Parse(bd.selectOne("sales_id","sales","1 ORDER BY sales_id DESC LIMIT 1").ToString());
                    List<string> listDetailsSales = new List<string>()
                    {
                        "sales_id","product_id","quantity"
                    };
                    for (int i = 0; i < productsToSells.Count; i++) 
                    {
                        List<ValoresAInsertar> listValoresDetalle = new List<ValoresAInsertar>()
                        {
                            new ValoresAInsertar(lastIdSell.ToString(),false),
                            new ValoresAInsertar(productsToSells[i].productoId.ToString(),false),
                            new ValoresAInsertar(productsToSells[i].cantidad.ToString(),false),
                        };
                        bool resultDetails = bd.insert("details_sales", listDetailsSales, listValoresDetalle);
                        if (resultDetails)
                        {
                            result = pay - amount;
                        }
                        else 
                        {
                            Sell.mesError = bd.mesError;
                            return -1;
                        }
                    }

                }
            }
            catch (Exception)
            {
                result = -1; 
                Sell.mesError = bd.mesError;

            }
            return result;
        }

    }
}
