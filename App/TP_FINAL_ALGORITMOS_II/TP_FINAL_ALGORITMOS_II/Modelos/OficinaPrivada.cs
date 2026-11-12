using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public class OficinaPrivada:Recurso
    {
        public bool TieneAireAcondicionado { get; set; }
        public bool ConLlave { get; set; }
        public bool ServicioLunch { get; set; }

        public OficinaPrivada() : base()
        {
            
        }

        public override bool PuedeReservarse(DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin)
        {
            return base.PuedeReservarse(fecha, horaInicio, horaFin); // aca va la logica antes de llamar a la fn
        }

    }
}
