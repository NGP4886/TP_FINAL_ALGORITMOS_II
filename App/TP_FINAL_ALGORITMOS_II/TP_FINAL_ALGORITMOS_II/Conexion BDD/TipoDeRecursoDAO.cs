using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Modelos;

namespace TP_FINAL_ALGORITMOS_II.Conexion_BDD
{
    public class TipoDeRecursoDAO
    {
        public List<TipoRecurso> ObtenerTodosParaCombo()
        {
            List<TipoRecurso> tiposDeRecurso = new List<TipoRecurso>();

            try
            {
                using (MySqlConnection conexion = ConexionDAO.CrearConexion())
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter("sp_listar_tipos_recurso", conexion))
                    {
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.Fill(tiposDeRecurso);
                        while(adapta)
                    }
                    return clientes;
                }
               



                using (MySqlConnection conexion = ConexionDAO.CrearConexion())
                {
                    
                    using (MySqlCommand comando = new MySqlCommand("sp_listar_tipos_recurso", conexion))
                    {
                        conexion.Open();

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                TipoRecurso tipo = new TipoRecurso();

                                tipo.Descripcion = Convert.ToString(lector["descripcion"]);
                                tipo.IdTipo = Convert.ToInt32(lector["id_tipo"]);

                                tiposDeRecurso.Add(tipo);

                            }
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            return tiposDeRecurso;
        }
    }
}
