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
    public class GestoraClientes
    {
        private ClienteDAO clienteDAO;

        public GestoraClientes()
        {
            clienteDAO = new ClienteDAO();
        }

        public bool AgregarCliente(Cliente nuevoCliente)
        {
            // aca van las validaciones de los datos para el nuevo cliente
            ValidarDatosCliente(nuevoCliente);
            return clienteDAO.AgregarCliente(nuevoCliente);
            
        }

        public bool ModificarCliente(Cliente clienteModificado)
        {
            if (clienteModificado.IdCliente <= 0)
            {
                throw new Exception("Error: no se ha seleccionado un cliente validdo para modificar");
            }
            ValidarDatosCliente(clienteModificado);
            return clienteDAO.ModificarCliente(clienteModificado);
        }
        public bool EliminarCliente(int idCliente)
        {
            if (idCliente <= 0)
                throw new Exception("Debe seleccionar un cliente para eliminar.");
            return clienteDAO.EliminarCliente(idCliente);
        }

        public DataTable ObtenerTodos()
        {
            return clienteDAO.ObtenerTodos();
        }

        private void ValidarDatosCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Dni) || cliente.Dni.Length < 7)
                throw new Exception("El DNI ingresado no es válido. Debe tener al menos 7 caracteres.");

            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new Exception("El nombre y el apellido son campos obligatorios.");

            if (!string.IsNullOrWhiteSpace(cliente.Email) && !cliente.Email.Contains("@"))
                throw new Exception("El formato del correo electrónico es incorrecto.");
        }
    }
}
