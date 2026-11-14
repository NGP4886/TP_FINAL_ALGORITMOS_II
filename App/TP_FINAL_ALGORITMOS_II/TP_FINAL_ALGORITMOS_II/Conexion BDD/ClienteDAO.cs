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
        public bool EliminarCliente(int idCliente)
        {
            using (MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("sp_eliminar_cliente", conexion))
                {

                    try
                    {
                        conexion.Open();

                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@p_id_cliente", idCliente);

                        return comando.ExecuteNonQuery() > 0;

                    }
                    catch (MySqlException)
                    {
                        throw;
                    }
                }
            }
        }
        public bool ModificarCliente(Cliente modificarCliente)
        {
            using (MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("sp_modificar_cliente", conexion))
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    try
                    {
                        conexion.Open();

                        // ¡Faltaba este parámetro fundamental!
                        comando.Parameters.AddWithValue("@p_id_cliente", modificarCliente.IdCliente);

                        comando.Parameters.AddWithValue("@p_dni", modificarCliente.Dni);
                        comando.Parameters.AddWithValue("@p_nombre", modificarCliente.Nombre);
                        comando.Parameters.AddWithValue("@p_apellido", modificarCliente.Apellido);
                        comando.Parameters.AddWithValue("@p_telefono", modificarCliente.Telefono);
                        comando.Parameters.AddWithValue("@p_email", modificarCliente.Email);

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
            DataTable clientes = new DataTable();

            try
            {
                using (MySqlConnection conexion = ConexionDAO.CrearConexion())
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter("sp_listar_clientes", conexion))
                    {
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.Fill(clientes);
                    }
                    return clientes;
                }

            }
            catch (MySqlException)
            {
                throw;
            }
        }
    }
}
