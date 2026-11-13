using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public class Adicional
    {
        public int IdAdicional { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoExtra { get; set; }
        public TipoRecurso TipoRecurso { get; set; }

        public Adicional() { }
    }
}
