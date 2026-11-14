using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Modelos;

namespace TP_FINAL_ALGORITMOS_II.Conexion_BDD
{
    public class ReservaDAO
    {
        public bool AgregarReserva(Reserva nuevaReserva)
        {
            using(MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    int idReservaGenerado = 0;

                    using(MySqlCommand comando = new MySqlCommand("sp_alta_reserva", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@p_id_cliente", nuevaReserva.Cliente.IdCliente);
                        comando.Parameters.AddWithValue("@p_id_recurso", nuevaReserva.Recurso.Id);
                        comando.Parameters.AddWithValue("@p_fecha", nuevaReserva.FechaReserva.Date);
                        comando.Parameters.AddWithValue("@p_hora_inicio", nuevaReserva.HoraInicio);
                        comando.Parameters.AddWithValue("@p_hora_fin", nuevaReserva.HoraFin);
                        comando.Parameters.AddWithValue("@p_cantidad_personas", nuevaReserva.CantidadPersonas);

                        // ExecuteScalar ejecuta el SP y captura el SELECT LAST_INSERT_ID() que pusimos al final
                        idReservaGenerado = Convert.ToInt32(comando.ExecuteScalar());
                    }

                    if (nuevaReserva.Adicionales!=null && nuevaReserva.Adicionales.Count > 0)
                    {
                        foreach(var adicional in nuevaReserva.Adicionales)
                        {
                            using (MySqlCommand comando2 = new MySqlCommand("sp_agregar_adicional_reserva", conexion))
                            {
                                comando2.CommandType = CommandType.StoredProcedure;

                                comando2.Parameters.AddWithValue("@p_id_reserva", idReservaGenerado);
                                comando2.Parameters.AddWithValue("@p_id_adicional", adicional.IdAdicional);

                                comando2.ExecuteNonQuery();
                            }
                        }
                    }
                    return true;
                }
                catch (MySqlException)
                {
                    throw;
                }

                
            }
            
        }

        public bool CancelarReserva(int idReserva)
        {
            using (MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("sp_cancelar_reserva", conexion))
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    try
                    {
                        conexion.Open();
                        comando.Parameters.AddWithValue("@p_id_reserva", idReserva);
                        return comando.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException)
                    {
                        throw;
                    }

                }
            }
        }

        public DataTable ObtenerDetalleReservas()
        {
            DataTable reservas = new DataTable();
            try
            {
                using (MySqlConnection conexion = ConexionDAO.CrearConexion())
                {
                    string query = "SELECT * FROM vw_detalle_reservas ORDER BY fecha_reserva DESC, hora_inicio DESC;";
                    using(MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                    {
                        adaptador.Fill(reservas);
                    }
                    return reservas;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
        }
    }
}
