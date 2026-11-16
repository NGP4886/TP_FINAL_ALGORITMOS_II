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
            string jsonCliente = JsonSerializer.Serialize(this);
            File.WriteAllText("cliente.json", jsonCliente);
            return jsonCliente;
            //var opciones = new JsonSerializerOptions { WriteIndented = true };
            //return JsonSerializer.Serialize(this, opciones);
        }

        public string ImportarDJson()
        {
            string jsonLeido = File.ReadAllText("cliente.json");
            Cliente clienteLeido = JsonSerializer.Deserialize<Cliente>(jsonLeido);
            return jsonLeido;
        }
    }
}
