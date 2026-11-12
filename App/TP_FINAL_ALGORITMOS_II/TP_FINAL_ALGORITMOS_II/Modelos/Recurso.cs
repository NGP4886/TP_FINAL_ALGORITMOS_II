using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Enums;
using TP_FINAL_ALGORITMOS_II.Interfaces;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public abstract class Recurso:IReservable
    {
        public int Id { get; set; }
        public TipoRecurso TipoRecurso { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int Capacidad { get; set; }
        public EstadoRecurso Estado { get; set; }

        public Recurso(){}

        public virtual bool PuedeReservarse(DateTime fecha,TimeSpan horaInicio, TimeSpan horaFin)
        {
            return true; // aca va la logica antes de llamar a la fn
        }


    }
}
