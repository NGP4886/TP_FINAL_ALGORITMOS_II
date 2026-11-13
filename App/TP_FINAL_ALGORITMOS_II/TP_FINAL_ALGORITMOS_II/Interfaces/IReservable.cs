using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FINAL_ALGORITMOS_II.Interfaces
{
    public interface IReservable
    {
        bool PuedeReservarse(DateTime fecha,TimeSpan horaInicio,TimeSpan horaFin,int cantidadPersonas);
    }
}
