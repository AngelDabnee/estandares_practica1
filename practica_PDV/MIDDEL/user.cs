using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica_PDV.CRUD_BACK;


namespace practica_PDV.MIDDEL
{
    public class User
    {
        public int id;
        public string name;
        public string email;
        public string password;
        public static string mesError;
        CRUDs_BD bd;

        public User()
        {
            bd = new CRUD_BACK.MySql();
        }
        public bool insertUser(string name, string email, string password)
        {
            List<string> campos = new List<string>()
            {
                "name","email","password"
            };
            List<ValoresAInsertar> valores = new List<ValoresAInsertar>();
            valores.Add(new ValoresAInsertar(name));
            valores.Add(new ValoresAInsertar(email));
            valores.Add(new ValoresAInsertar(password));

            bool results = this.bd.insert("users",campos,valores);
            if (results == false) 
            {
                User.mesError = this.bd.mesError;
            }
            return results;
        }
        public bool deleteUser(int id) 
        {
            bool results = this.bd.delete("users",id);
            if (results == false) 
            {
                User.mesError = this.bd.mesError;
            }
            return results;
        }
        public bool updateUser(string name, string email, string password,int id) 
        {
            List<string> campos = new List<string> 
            {
                "name","email","password" 
            };
            List<ValoresAInsertar> valores = new List<ValoresAInsertar>();
            valores.Add(new ValoresAInsertar(name));
            valores.Add(new ValoresAInsertar(email));
            valores.Add(new ValoresAInsertar(password));

            bool results = this.bd.update("users", campos, valores,id);
            if (results == false)
            {
                User.mesError = this.bd.mesError;
            }
            return results;
        }
        public List<object[]> selectAllUser() 
        {
            return this.bd.selectAll("users");
        }
        public List<object[]> selectForName(string name) 
        {
            List<object[]> result = this.bd.selectOne("users", name);
            return result;
        }
        public User login(string email, string password) 
        {
            User user = new User();
            List<object[]> result = this.bd.selectOne("users", "email='" + email + "' AND password = '" + password + "'");
            if (result.Count == 1)
            {
                object[] tempo = result[0];
                user.id = int.Parse(tempo[0].ToString());
                user.name = tempo[1].ToString();
                user.email = tempo[2].ToString();
                user.password = tempo[3].ToString();
            }
            else 
            {
                User.mesError = "ERROR,NO EXISTE " + this.bd.mesError;
                user = null;
            }
            return user;
        }

    }
}
