using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace TP_FINAL_ALGORITMOS_II.Conexion_BDD
{
    // CLASE QUE REALIZA LA CONEXION CON LA BASE DE DATOS 

    public static class ConexionDAO
    {
        public static MySqlConnection CrearConexion()
        {
            string jsonConexion = File.ReadAllText("ConfigBDD.json");

            ConfigConexion config = JsonSerializer.Deserialize<ConfigConexion>(jsonConexion);

            string cadenaConexion =
                $"server={config.Servidor};" +
                $"port={config.Puerto};" +
                $"database={config.BaseDeDatos};" +
                $"uid={config.Usuario};" +
                $"pwd={config.Clave};";

            return new MySqlConnection(cadenaConexion);
        }
    }
}
