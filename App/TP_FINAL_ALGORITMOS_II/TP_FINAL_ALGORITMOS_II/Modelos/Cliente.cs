using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Interfaces;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public class Cliente:IExportable
    {
        public int IdCliente { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        public Cliente() { }

        public string ExportarAJson()
        {
           
            return JsonSerializer.Serialize(this);
            

        }

        public string ImportarDJson(string jsonLeido)
        {
            Cliente clienteLeido = JsonSerializer.Deserialize<Cliente>(jsonLeido);
            return jsonLeido;
        }
    }
}
