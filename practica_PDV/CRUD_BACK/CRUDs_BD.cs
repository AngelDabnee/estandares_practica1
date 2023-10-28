using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practica_PDV.CRUD_BACK
{
    public abstract class CRUDs_BD
    {
        protected string connectionStrgin;
        protected string host;
        protected string us;
        protected string pwd;
        protected string puerto;
        protected string nombreBD;

        protected string tabla;
        protected List<string> campos = new List<string>();
        protected List<ValoresAInsertar> valores = new List<ValoresAInsertar>();

        //Mensajes de error. 
        public string mesError; 


        //----Métodos-----

        public abstract bool insert(string tabla, List<string> campos, List<ValoresAInsertar> valores);
        public abstract bool update(string tabla, List<string> campos, List<ValoresAInsertar> valores, int id);
        public abstract bool delete(string tabla, int id);
        public abstract List<object[]> selectAll(string tabla);
        public abstract List<object[]> selectOne(string campo, string tabla, string criterioBusqueda);
        public abstract object selectUser(string campo, string tabla, string criterioBusqueda);
    }
}
