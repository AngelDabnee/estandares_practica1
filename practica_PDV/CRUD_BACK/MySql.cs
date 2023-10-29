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
        public MySql(string host = "localhost", string us = "root", string pwd = "", string bd = "practica_PDV", string puerto = "3306") : base()
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
        public override bool delete(string tabla, int id)
        {
            bool result = false;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    command = new MySqlCommand($"DELETE FROM {tabla} WHERE product_id = {id}");
                    command.Connection = con;
                    int res = command.ExecuteNonQuery();
                    if (res == 1)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }

            }
            catch (MySqlException mex)
            {
                this.mesError = $"LA BASE DE DATOS NO PUDO ELIMINAR EL REGISTRO {mex.Message}";
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        public override bool update(string tabla, List<string> campos, List<ValoresAInsertar> valores, int id)
        {
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
                    command = new MySqlCommand($"UPDATE {tabla} SET {camposConcat} WHERE product_id = {id};");
                    command.Connection = con;
                    int res = command.ExecuteNonQuery();
                    if (res == 1)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        this.mesError = "ERROR AL ACTUALIZAR";
                    }
                }

            }
            catch (MySqlException mex)
            {
                this.mesError = $"NO SE PUDO ESTABLECER CONEXIÓN A DB {mex.Message}";

            }
            catch (Exception ex)
            {
                this.mesError = $"ERROR AL MODIFICAR {ex.Message}";
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
            List<object[]> result = new List<object[]>();
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    command = new MySqlCommand($"SELECT * FROM {tabla};");
                    command.Connection = con;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object[] row = new object[reader.FieldCount];
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.GetValue(i);
                            }
                            result.Add(row);
                        }

                    }
                    else
                    {
                        this.mesError = $"NO SE ENCONTRÓ NADA{tabla}";
                        result = new List<object[]>();
                    }
                }
            }
            catch (MySqlException mex)
            {
                this.mesError = $"ERROR EN LA CONSULTA {mex.Message}";
            }
            catch (Exception ex)
            {
                this.mesError = $"Error {ex.Message}";
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public override List<object[]> selectOne(string campo, string tabla, string criterioBusqueda)
        {
            List<object[]> result = new List<object[]>();
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    command = new MySqlCommand($"SELECT {campo} FROM {tabla} WHERE {criterioBusqueda};");
                    command.Connection = con;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object[] row = new object[reader.FieldCount];
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.GetValue(i);
                            }
                            result.Add(row);
                        }

                    }
                    else
                    {
                        this.mesError = $"NO SE ENCONTRÓ NADA{tabla}";
                        result = new List<object[]>();
                    }
                }
            }
            catch (MySqlException mex)
            {
                this.mesError = $"ERROR EN LA CONSULTA {mex.Message}";
            }
            catch (Exception ex)
            {
                this.mesError = $"Error {ex.Message}";
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public override object selectUser(string tabla, string criterioBusqueda)
        {
            List<object[]> result = new List<object[]>();
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    command = new MySqlCommand($"SELECT * FROM {tabla} WHERE {criterioBusqueda};");
                    command.Connection = con;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object[] row = new object[reader.FieldCount];
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.GetValue(i);
                            }
                            result.Add(row);
                        }

                    }
                    else
                    {
                        this.mesError = $"NO SE ENCONTRÓ NADA{tabla}";
                        result = new List<object[]>();
                    }
                }
            }
            catch (MySqlException mex)
            {
                this.mesError = $"ERROR EN LA CONSULTA {mex.Message}";
            }
            catch (Exception ex)
            {
                this.mesError = $"Error {ex.Message}";
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public override List<object[]> selectAll(string tabla, string criterioBusqueda)
        {
            List<object[]> resultado = new List<object[]>();
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    command = new MySqlCommand($"SELECT * FROM {tabla} WHERE {criterioBusqueda}");
                    command.Connection = con;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object[] registro = new object[reader.FieldCount];
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                registro[i] = reader.GetValue(i);
                            }
                            resultado.Add(registro);
                        }
                    }
                    else
                    {
                        this.mesError = $"ERROR AL ENCONTAR REGISTRO {tabla}.";
                        resultado = new List<object[]>();
                    }
                }
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return resultado; 
        }
    }
}
