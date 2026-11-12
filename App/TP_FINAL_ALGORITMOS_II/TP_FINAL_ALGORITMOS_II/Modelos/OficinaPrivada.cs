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

        public OficinaPrivada() : base()
        {
            IdTipo = 3;
        }
    }
}
