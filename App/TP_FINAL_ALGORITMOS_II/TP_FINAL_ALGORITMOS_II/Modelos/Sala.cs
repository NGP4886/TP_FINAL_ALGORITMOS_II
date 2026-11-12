using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public class Sala:Recurso
    {
        public bool TieneProyector { get; set; }
        public bool TienePizarra { get; set; }
        public bool IncluyeCatering { get; set; }

        public Sala():base()
        {
            
        }

        public override bool PuedeReservarse(DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin)
        {
            return base.PuedeReservarse(fecha, horaInicio, horaFin); // aca va la logica antes de llamar a la fn
        }
    }
}
