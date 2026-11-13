using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Modelos;

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

                        return comando.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException)
                    {
                        throw;
                    }


                }
            }
        }

        public bool ModificarRecurso(Recurso recursoModificado)
        {
            using (MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("sp_modificar_recurso", conexion))
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    try
                    {
                        conexion.Open();

                        comando.Parameters.AddWithValue("@p_id_recurso", recursoModificado.TipoRecurso);
                        comando.Parameters.AddWithValue("@p_nombre", recursoModificado.Nombre);
                        comando.Parameters.AddWithValue("@p_ubicacion", recursoModificado.Ubicacion);
                        comando.Parameters.AddWithValue("@p_estado", recursoModificado.Capacidad);

                        return comando.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException)
                    {
                        throw;
                    }

                }


            }
}
