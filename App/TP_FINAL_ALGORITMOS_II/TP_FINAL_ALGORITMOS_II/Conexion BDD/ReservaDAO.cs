using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Modelos;

namespace TP_FINAL_ALGORITMOS_II.Conexion_BDD
{
    public class ReservaDAO
    {
        public bool Reservar(Reserva reserva)
        {
            using (MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("sp_alta_reserva", conexion))
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    try
                    {
                        conexion.Open();

                        comando.Parameters.AddWithValue("@p_id_cliente", reserva.Cliente);
                        comando.Parameters.AddWithValue("@p_id_recurso", reserva.Recurso.Id);
                        comando.Parameters.AddWithValue("@p_fecha", reserva.FechaReserva);
                        comando.Parameters.AddWithValue("@p_hora_inicio", reserva.HoraInicio);
                        comando.Parameters.AddWithValue("@p_hora_fin", reserva.HoraFin);

                        return comando.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException)
                    {
                        throw;
                    }


                }
            }
        }

        public bool Cancelar(Reserva reserva)
        {
            using (MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("sp_cancelar_reserva", conexion))
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    try
                    {
                        conexion.Open();

                        comando.Parameters.AddWithValue("@p_id_reserva", reserva.IdReserva);

                        return comando.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException)
                    {
                        throw;
                    }

                }
            }
        }
    }
}
