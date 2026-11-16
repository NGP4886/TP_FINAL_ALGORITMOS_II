using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Enums;
using TP_FINAL_ALGORITMOS_II.Interfaces;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public class Reserva:IExportable
    {
        public int IdReserva { get; set; }
        public Cliente Cliente { get; set; }
        public Recurso Recurso { get; set; }
        public DateTime FechaReserva { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int CantidadPersonas { get; set; }
        public EstadoReserva EstadoReserva { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal CostoTotal { get; set; }
        public List<Adicional> Adicionales { get; set; } = new List<Adicional>();

        public Reserva() { }

        public void CalcularCostoTotal()
        {
            if (Recurso == null) return;

            decimal costoBase = Recurso.CalcularCostoTotal(HoraInicio, HoraFin);

            decimal costoExtras = 0;
            foreach(var adicional in Adicionales)
            {
                costoExtras += adicional.CostoExtra;
            }
            this.CostoTotal = costoBase + costoExtras;
        }

        public string ExportarAJson()
        {
            string jsonReserva = JsonSerializer.Serialize(this);
            File.WriteAllText("reserva.json", jsonReserva);
            return jsonReserva;
        }
    }
}
