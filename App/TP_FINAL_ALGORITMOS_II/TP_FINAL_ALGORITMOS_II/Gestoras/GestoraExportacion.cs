using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Interfaces;

namespace TP_FINAL_ALGORITMOS_II.Gestoras
{
    public class GestoraExportacion
    {
        public void GuardarArchivoJson(IExportable objetoAExportar,string rutaArchivo)
        {
            string json = objetoAExportar.ExportarAJson();

            File.WriteAllText(rutaArchivo, json);
        }


    }
}
