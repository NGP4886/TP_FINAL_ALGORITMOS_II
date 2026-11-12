using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Modelos;

namespace TP_FINAL_ALGORITMOS_II.Conexion_BDD
{
    public class ClienteDAO
    {
        public bool AgregarCliente(Cliente nuevoCliente)
        {
            // sp_alta_cliente
            using (MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("sp_alta_cliente", conexion))
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    try
                    {
                        conexion.Open();

                        comando.Parameters.AddWithValue("@p_dni", nuevoCliente.Dni);
                        comando.Parameters.AddWithValue("@p_nombre", nuevoCliente.Nombre);
                        comando.Parameters.AddWithValue("@p_apellido", nuevoCliente.Apellido);
                        comando.Parameters.AddWithValue("@p_telefono", nuevoCliente.Telefono);
                        comando.Parameters.AddWithValue("@p_email", nuevoCliente.Email);

                        return comando.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException ex)
                    {
                        throw;
                    }
                   


                }
            }
           
        }
    }
}
