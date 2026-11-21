using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_ALGORITMOS_II.Conexion_BDD;
using TP_FINAL_ALGORITMOS_II.Modelos;

namespace TP_FINAL_ALGORITMOS_II.Gestoras
{
    public class GestoraRecursos
    {
        private RecursoDAO recursoDAO;

        public GestoraRecursos()
        {
            recursoDAO = new RecursoDAO();
        }

        public bool AgregarRecurso(Recurso nuevoRecurso)
        {
            ValidarDatosRecurso(nuevoRecurso);
            return recursoDAO.AgregarRecurso(nuevoRecurso);
        }

        public bool ModificarRecurso(Recurso recursoModificado)
        {
            if (recursoModificado.Id <= 0)
                throw new Exception("Error: No se ha seleccionado un recurso válido para modificar.");

            ValidarDatosRecurso(recursoModificado);
            return recursoDAO.ModificarRecurso(recursoModificado);
        }

        public bool EliminarRecurso(int idRecurso)
        {
            if (idRecurso <= 0)
                throw new Exception("Debe seleccionar un recurso para eliminar.");

            return recursoDAO.EliminarRecurso(idRecurso);
        }

        public DataTable ObtenerTodos()
        {
            return recursoDAO.ObtenerTodos();
        }

        private void ValidarDatosRecurso(Recurso recurso)
        {
            if (recurso.TipoRecurso == null || recurso.TipoRecurso.IdTipo <= 0)
                throw new Exception("Debe seleccionar el tipo de recurso (Sala, Puesto, Oficina).");

            if (string.IsNullOrWhiteSpace(recurso.Nombre))
                throw new Exception("El nombre del recurso es obligatorio.");

            if (recurso.Capacidad <= 0)
                throw new Exception("La capacidad del recurso debe ser mayor a 0.");

            if (recurso.PrecioPorHora < 0)
                throw new Exception("El precio por hora no puede ser negativo.");
        }

       
    }
}
