using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FINAL_ALGORITMOS_II.Conexion_BDD
{
    // CLASE QUE CONTIENE LAS PROPIEDADES DE LA BASE DE DATOS

    public class ConfigConexion
    {
        public string Servidor { get; set; }
        public int Puerto { get; set; }
        public string BaseDeDatos { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }


    }
}


