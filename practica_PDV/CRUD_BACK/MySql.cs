using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace practica_PDV.CRUD_BACK
{
    public class MySql : CRUDs_BD
    {
        //Conexión a la BD: 
        MySqlConnection con; 
        MySqlCommand command;
        MySqlDataReader reader;
        public MySql(string host, string us, string pwd, string bd, string puerto = "3306") : base()
        {
            //vamos a inicializar los valores de conexión en el connectionString
            this.connectionStrgin = $"Server={host};Port={puerto};Database={bd};Uid={us};Pwd={pwd};";
            //creamos la conexion con el connnectioString
            con = new MySqlConnection(connectionStrgin);

        }
        public override bool insert(string tabla, List<string> campos, List<ValoresAInsertar> valores)
        {
            //valorar el insert 
            bool result = false;
            try
            {
                if(con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    string camposConcat = "";
                    foreach (var campo in campos)
                    {
                        camposConcat += campo + ",";//A cada campo lo separamos por una coma. 
                    }
                    camposConcat = camposConcat.Remove(camposConcat.Length-1);//quitamos la ultima coma
                    string valoresInsert = "";
                    for (int i = 0; i < valores.Count; i++)
                    {
                        valoresInsert += (valores[i].llevaApostrofes ? "'" + valores[i].valor + "'," : valores[i].valor + ",");

                    }
                    valoresInsert = valoresInsert.Remove(valoresInsert.Length - 1);//removemos la ultima coma. 
                    command = new MySqlCommand($"INSERT INTO {tabla} ({camposConcat}) VALUES ({valoresInsert});");
                    command.Connection = con;
                    int res = command.ExecuteNonQuery();
                    if (res == 1)
                    {
                        result = true;
                    }
                    else {
                        result = false;
                        this.mesError = "No se registro algo";
                    }
                }

            }
            catch (MySqlException mex)
            {
                this.mesError = $"NO SE PUDO ESTABLECER CONEXIÓN A DB {mex.Message}";

            }
            catch (Exception ex)
            {
                this.mesError = $"ERROR AL REGISTRAR {ex.Message}";
            }
            finally 
            {
                //cerramos la conexión. 
                if (con.State == System.Data.ConnectionState.Open) { 
                    con.Close();
                }
               
            }
            return result;


        }
        public override bool delete(string tabla, int id)
        {
            bool result = false;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed) {
                    con.Open();
                    command = new MySqlCommand($"DELETE FROM {tabla} WHERE id = {id}"); 
                    command.Connection = con;
                    int res = command.ExecuteNonQuery();
                    if (res == 1)
                    {
                        result = true;
                    }
                    else { 
                        result = false;
                    }
                }

            }
            catch (MySqlException mex)
            {
                this.mesError = $"LA BASE DE DATOS NO PUDO ELIMINAR EL REGISTRO {mex.Message}";
            }
            finally {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        public override bool update(string tabla, List<string> campos, List<ValoresAInsertar> valores, int id)
        {
            //valorar el insert 
            bool result = false;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    string camposConcat = "";
                    foreach (var campo in campos)
                    {
                        camposConcat += campo + ",";//A cada campo lo separamos por una coma. 
                    }
                    camposConcat = camposConcat.Remove(camposConcat.Length - 1);//quitamos la ultima coma
                    string valoresInsert = "";
                    for (int i = 0; i < valores.Count; i++)
                    {
                        valoresInsert += (valores[i].llevaApostrofes ? "'" + valores[i].valor + "'," : valores[i].valor + ",");

                    }
                    valoresInsert = valoresInsert.Remove(valoresInsert.Length - 1);//removemos la ultima coma. 
                    command = new MySqlCommand($"INSERT INTO {tabla} ({camposConcat}) VALUES ({valoresInsert});");
                    command.Connection = con;
                    int res = command.ExecuteNonQuery();
                    if (res == 1)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        this.mesError = "No se registro algo";
                    }
                }

            }
            catch (MySqlException mex)
            {
                this.mesError = $"NO SE PUDO ESTABLECER CONEXIÓN A DB {mex.Message}";

            }
            catch (Exception ex)
            {
                this.mesError = $"ERROR AL REGISTRAR {ex.Message}";
            }
            finally
            {
                //cerramos la conexión. 
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }

            }
            return result;

        }

        public override List<object[]> selectAll(string tabla)
        {
            throw new NotImplementedException();
        }

        public override List<object[]> selectOne(string tabla, string criterioBusqueda)
        {
            throw new NotImplementedException();
        }
    }
}
