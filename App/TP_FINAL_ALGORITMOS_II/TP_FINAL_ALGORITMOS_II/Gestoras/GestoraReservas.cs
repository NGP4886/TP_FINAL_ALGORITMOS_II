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
    public class GestoraReservas
    {
        private ReservaDAO _reservaDAO;

        public GestoraReservas()
        {
            _reservaDAO = new ReservaDAO();
        }

        public bool AgregarReserva(Reserva nuevaReserva)
        {
            // 1. Validaciones básicas de interfaz
            if (nuevaReserva.Cliente == null || nuevaReserva.Cliente.IdCliente <= 0)
                throw new Exception("Debe seleccionar un cliente para la reserva.");

            if (nuevaReserva.Recurso == null || nuevaReserva.Recurso.Id <= 0)
                throw new Exception("Debe seleccionar un recurso para reservar.");

            if (nuevaReserva.HoraInicio >= nuevaReserva.HoraFin)
                throw new Exception("La hora de inicio de la reserva debe ser anterior a la hora de fin.");

            if (nuevaReserva.FechaReserva.Date < DateTime.Now.Date)
                throw new Exception("No se pueden registrar reservas para fechas pasadas.");

            if (nuevaReserva.CantidadPersonas <= 0)
                throw new Exception("La cantidad de personas debe ser mayor a 0.");

            // 2. Validación de regla de negocio polimórfica (Llama al PuedeReservarse de la clase C#)
            if (!nuevaReserva.Recurso.PuedeReservarse(nuevaReserva.FechaReserva, nuevaReserva.HoraInicio, nuevaReserva.HoraFin, nuevaReserva.CantidadPersonas))
            {
                throw new Exception("La reserva no cumple con las reglas del recurso (ej. Excede la capacidad máxima).");
            }

            // 3. Calculamos el costo total en memoria antes de mandarlo a la base
            nuevaReserva.CalcularCostoTotal();

            // 4. Si todo está perfecto, le pasamos la pelota al DAO
            return _reservaDAO.AgregarReserva(nuevaReserva);
        }

        public bool CancelarReserva(int idReserva)
        {
            if (idReserva <= 0)
                throw new Exception("Debe seleccionar una reserva para cancelar.");

            return _reservaDAO.CancelarReserva(idReserva);
        }

        public DataTable ObtenerDetalleReservas()
        {
            return _reservaDAO.ObtenerDetalleReservas();
        }
    }
}


