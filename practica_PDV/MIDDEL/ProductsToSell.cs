using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_PDV.MIDDEL
{
    public class ProductsToSell
    {
        public int productoId;
        public int cantidad;
        public ProductsToSell(int prodId, int cant)
        {
            this.productoId = prodId;
            this.cantidad = cant;
        }
    }
}
