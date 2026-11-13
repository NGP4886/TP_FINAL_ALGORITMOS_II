using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public class Sala:Recurso
    {

        public Sala() : base() { }


        public override bool PuedeReservarse(DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, int cantidadPersonas)
        {
            return base.PuedeReservarse(fecha, horaInicio, horaFin,cantidadPersonas); // aca va la logica antes de llamar a la fn
        }

        public override decimal CalcularCostoTotal(TimeSpan horaInicio, TimeSpan horaFin)
        {
            decimal costoBase = base.CalcularCostoTotal(horaInicio, horaFin);
            decimal costosAdicionales = 0;

            return costoBase + costosAdicionales;

        }
    }
}
