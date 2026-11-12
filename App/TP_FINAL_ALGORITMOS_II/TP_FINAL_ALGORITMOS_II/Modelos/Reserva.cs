using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Enums;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public Cliente Cliente { get; set; }
        public Recurso Recurso { get; set; }
        public DateTime FechaReserva { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public EstadoReserva EstadoReserva { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Reserva() { }
    }
}
