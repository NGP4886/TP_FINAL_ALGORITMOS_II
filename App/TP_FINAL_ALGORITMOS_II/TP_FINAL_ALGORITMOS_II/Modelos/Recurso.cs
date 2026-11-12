using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Enums;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public abstract class Recurso
    {
        public int Id { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int Capacidad { get; set; }
        public EstadoRecurso Estado { get; set; }

        public Recurso(){}
    }
}
