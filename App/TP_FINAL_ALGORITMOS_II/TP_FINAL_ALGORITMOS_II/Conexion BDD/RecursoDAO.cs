using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Modelos;
using System.Data;

namespace TP_FINAL_ALGORITMOS_II.Conexion_BDD
{
    public class RecursoDAO
    {

        public bool AgregarRecurso(Recurso nuevoRecurso)
        {
            using (MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("sp_alta_recurso", conexion))
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    try
                    {
                        conexion.Open();

                        comando.Parameters.AddWithValue("@p_id_tipo", nuevoRecurso.TipoRecurso);
                        comando.Parameters.AddWithValue("@p_nombre", nuevoRecurso.Nombre);
                        comando.Parameters.AddWithValue("@p_ubicacion", nuevoRecurso.Ubicacion);
                        comando.Parameters.AddWithValue("@p_capacida", nuevoRecurso.Capacidad);
                        comando.Parameters.AddWithValue("@p_precio_por_hora", nuevoRecurso.PrecioPorHora);

                        return comando.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException)
                    {
                        throw;
                    }


                }
            }
        }

        public bool ModificarRecurso(Recurso modificarRecurso)
        {
            using (MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("sp_modificar_recurso", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        conexion.Open();

                        comando.Parameters.AddWithValue("@p_id_recurso", modificarRecurso.Id);
                        comando.Parameters.AddWithValue("@p_id_tipo", modificarRecurso.TipoRecurso.IdTipo);
                        comando.Parameters.AddWithValue("@p_nombre", modificarRecurso.Nombre);
                        comando.Parameters.AddWithValue("@p_ubicacion", modificarRecurso.Ubicacion);
                        comando.Parameters.AddWithValue("@p_capacidad", modificarRecurso.Capacidad);
                        comando.Parameters.AddWithValue("@p_precio_por_hora", modificarRecurso.PrecioPorHora);
                        comando.Parameters.AddWithValue("@p_estado", modificarRecurso.Estado.ToString());

                        return comando.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException)
                    {
                        throw;
                    }

                }


            }
        }

        public bool EliminarRecurso(int idRecurso)
        {
            using (MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("sp_modificar_recurso", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    try
                    {


                        conexion.Open();

                        comando.Parameters.AddWithValue("p_id_recurso", idRecurso);

                        return comando.ExecuteNonQuery() > 0;
                    }

                    catch (MySqlException)
                    {
                        throw;
                    }

                }
            }
        }

        public DataTable ObtenerTodos()
        {
            DataTable recursos = new DataTable();

            try
            {
                using(MySqlConnection conexion = ConexionDAO.CrearConexion())
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter("sp_listar_recursos", conexion))
                    {
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adaptador.Fill(recursos);
                    }
                    return recursos;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
        }
    }
}

        

