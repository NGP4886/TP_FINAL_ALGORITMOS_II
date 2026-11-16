using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public class OficinaPrivada:Recurso
    {
        public OficinaPrivada() : base() { }

        public override bool PuedeReservarse(DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, int cantidadPersonas)
        {
            double horasReservadas = (horaFin - horaInicio).Hours;

            if (horasReservadas < 2.0)
            {
                throw new Exception("La oficina privada se reserva minimo 2 horas");
            }
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
