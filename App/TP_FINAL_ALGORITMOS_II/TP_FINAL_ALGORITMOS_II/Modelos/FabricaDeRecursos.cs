using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FINAL_ALGORITMOS_II.Modelos
{
    public static class FabricaDeRecursos
    {
        public static Recurso Crear(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return new Sala();
                case 2:
                    return new PuestoDeTrabajo();
                case 3:
                    return new OficinaPrivada();

                default:
                    throw new ArgumentException("Tipo de recurso no valido.");
            }
        }
    }
}
