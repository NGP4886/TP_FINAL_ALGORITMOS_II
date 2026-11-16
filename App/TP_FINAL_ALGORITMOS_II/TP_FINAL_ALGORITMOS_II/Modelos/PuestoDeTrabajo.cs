using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public class PuestoDeTrabajo:Recurso
    {
        public bool TieneImpresora { get; set; }
        public bool TieneNotebook { get; set; }
        

        public PuestoDeTrabajo() : base() { }


        public override bool PuedeReservarse(DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin,int cantidadPersonas)
        {
            // regla del puesto de trabajo , se reserva solo para 1 peersona
            if (cantidadPersonas > 1) { return false; }

            return base.PuedeReservarse(fecha, horaInicio, horaFin,cantidadPersonas); // aca va la logica antes de llamar a la fn
        }

        public override decimal CalcularCostoTotal(TimeSpan horaInicio, TimeSpan horaFin)
        {
            return base.CalcularCostoTotal(horaInicio, horaFin);
        }
    }
}
