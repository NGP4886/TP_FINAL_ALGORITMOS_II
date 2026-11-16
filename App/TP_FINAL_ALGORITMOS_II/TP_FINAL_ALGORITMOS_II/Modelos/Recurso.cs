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
    public abstract class Recurso:IReservable,IExportable
    {
        public int Id { get; set; }
        public TipoRecurso TipoRecurso { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int Capacidad { get; set; }
        public EstadoRecurso Estado { get; set; }
        public decimal PrecioPorHora { get; set; }

        public Recurso(){}

        public virtual bool PuedeReservarse(DateTime fecha,TimeSpan horaInicio, TimeSpan horaFin,int cantidadPersonas)
        {
            // para todos los recursos la misma regla .. si cantidad de personas supera la capacidad
            if (cantidadPersonas > this.Capacidad)
            {
                throw new Exception($"La cantidad de personas ({cantidadPersonas}) supera la capacidad máxima ({this.Capacidad}).");
            }
            return true; // aca va la logica antes de llamar a la fn
        }
        public virtual decimal CalcularCostoTotal(TimeSpan horaInicio,TimeSpan horaFin)
        {
            decimal horasReservadas = (decimal)(horaFin - horaInicio).TotalHours;
            return PrecioPorHora * horasReservadas;
        }
        public string ExportarAJson()
        {
            string jsonRecurso = JsonSerializer.Serialize(this);
            File.WriteAllText("recurso.json", jsonRecurso);
            return jsonRecurso;
        }
    }
}
