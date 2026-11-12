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

        public Sala():base()
        {
            IdTipo = 1;
        }
    }
}
