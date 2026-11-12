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

        public PuestoDeTrabajo() : base()
        {
            IdTipo = 2;
        }
        
    }
}
