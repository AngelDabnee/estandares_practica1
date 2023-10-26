using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace practica_PDV.mysqlback
{
    public class mysqlconn
    {
        string host = "localhost";
        string port = "3306";
        string database = "practica_pdv";
        string user = "root";
        string password = "";

        public mysqlconn(string host, string port, string database, string user, string password)
        {
            this.host = host;
            this.port = port;
            this.database = database;
            this.user = user;
            this.password = password;


        }

    }
}
