using Google.Protobuf;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Tsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

using TP_FINAL_ALGORITMOS_II.Conexion_BDD;
using TP_FINAL_ALGORITMOS_II.Enums;
using TP_FINAL_ALGORITMOS_II.Gestoras;
using TP_FINAL_ALGORITMOS_II.Interfaces;
using TP_FINAL_ALGORITMOS_II.Modelos;

namespace TP_FINAL_ALGORITMOS_II
{
    public partial class Form1 : Form
    {
        private readonly GestoraRecursos gestoraRecursos;
        private readonly GestoraClientes gestoraClientes;
        private readonly GestoraReservas gestoraReservas;




        public Form1()
        {
            InitializeComponent();
            gestoraClientes = new GestoraClientes();
            gestoraReservas = new GestoraReservas();
            gestoraRecursos = new GestoraRecursos();


        }
        public void EliminarCliente(int idCliente)
        {
            try
            {
                gestoraClientes.EliminarCliente(idCliente);
                MessageBox.Show("Cliente eliminado correctamente.",
                    "Cliente Eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ActualizarGrilla(tabClientes);
                LimpiarFormularios(tabClientes);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModificarCliente(Cliente clienteModificado)
        {
            try
                
            {
                bool exito = gestoraClientes.ModificarCliente(clienteModificado);
                if (exito)
                {
                    LimpiarFormularios(tabClientes);
                    MessageBox.Show("Datos del cliente modificados con exito.", 
                        "Operacion exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ActualizarGrilla(tabClientes);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el cliente. Verifique que el ID exista.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }


            }
            catch(MySqlException ex)
            {
                if (ex.SqlState == "45000")
                {
                    MessageBox.Show(ex.Message, 
                        "Error de validacion SQL.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Error en la base de datos: " +
                        ex.Message, 
                        "Error SQL",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        public void AgregarCliente(Cliente nuevoCliente)
        {
            try
            {
                gestoraClientes.ValidarDatosCliente(nuevoCliente);
                gestoraClientes.AgregarCliente(nuevoCliente);
                LimpiarFormularios(tabClientes);
                MessageBox.Show("El cliente a sido guardado con exito.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // PODRIA HACER UN METODO PARA CADA GRID INDEPENDIENTE Y NO TENER QUE CARGAR LOS 3
            }
            catch (MySqlException ex)
            {
                if (ex.SqlState == "45000")
                {
                    MessageBox.Show(ex.Message, "Error al agregar cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido en la BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PruebasIniciales()
        {
            Console.WriteLine("--- INICIANDO PRUEBAS DEL BACKEND DEL COWORKING ---");

            GestoraClientes gestoraClientes = new GestoraClientes();
            GestoraRecursos gestoraRecursos = new GestoraRecursos();
            GestoraReservas gestoraReservas = new GestoraReservas();

            try
            {
                // 1. PRUEBA DE CLIENTE
                Console.WriteLine("\n1. Configurando Cliente...");
                Cliente nuevoCliente = new Cliente
                {
                    IdCliente = 1, // Simulamos que ya vino de la BD o se lo asignamos para la prueba
                    Dni = "12345678",
                    Nombre = "Juan",
                    Apellido = "Pérez",
                    Telefono = "2231112222",
                    Email = "juan@email.com",
                    Activo = true
                };
                // gestoraClientes.AgregarCliente(nuevoCliente); // Descomentar para insertar realmente en MySQL
                Console.WriteLine($"Cliente {nuevoCliente.Nombre} {nuevoCliente.Apellido} configurado.");

                // 2. PRUEBA DE RECURSO (Con Polimorfismo)
                Console.WriteLine("\n2. Configurando Recurso (Sala de Reuniones)...");
                Sala nuevaSala = new Sala
                {
                    Id = 1,
                    TipoRecurso = new TipoRecurso { IdTipo = 1, Descripcion = "Sala de Reuniones" },
                    Nombre = "Sala A - Directorio",
                    Ubicacion = "Planta Baja",
                    Capacidad = 10,
                    PrecioPorHora = 5000.00m,
                    Estado = EstadoRecurso.Disponible
                };
                Console.WriteLine($"Recurso '{nuevaSala.Nombre}' instanciado correctamente.");

                // 3. PRUEBA DE RESERVA Y VALIDACIONES DE NEGOCIO
                Console.WriteLine("\n3. Armando la Reserva...");
                Reserva nuevaReserva = new Reserva
                {
                    Cliente = nuevoCliente,
                    Recurso = nuevaSala,
                    FechaReserva = DateTime.Now.AddDays(2), // Reserva a futuro para pasar la validación
                    HoraInicio = new TimeSpan(10, 0, 0),    // 10:00 AM
                    HoraFin = new TimeSpan(12, 0, 0),       // 12:00 PM (2 horas de duración)
                    CantidadPersonas = 5,                   // Válido: Mínimo 2, Máximo 10
                    EstadoReserva = EstadoReserva.Activa
                };

                // Agregamos un servicio adicional
                Adicional proyector = new Adicional
                {
                    IdAdicional = 1,
                    Descripcion = "Proyector 4K",
                    CostoExtra = 2500.00m,
                    TipoRecurso = nuevaSala.TipoRecurso
                };
                nuevaReserva.Adicionales.Add(proyector);

                // Validamos reglas lógicas y calculamos total (Llama a PuedeReservarse de la clase Sala)
                Console.WriteLine("Validando reglas de negocio...");
                nuevaReserva.CalcularCostoTotal();

                // gestoraReservas.AgregarReserva(nuevaReserva); // Descomentar para insertar en MySQL y disparar el DAO

                Console.WriteLine($"¡Reserva validada con éxito! Costo Total Calculado: ${nuevaReserva.CostoTotal}");
                Console.WriteLine("(Desglose: 2 horas a $5000 + $2500 del Proyector = $12500)");

                // 4. PRUEBA DE LA INTERFAZ IExportable (JSON)
                Console.WriteLine("\n4. Probando Exportación JSON (Comprobante)...");
                string comprobanteJson = nuevaReserva.ExportarAJson();
                Console.WriteLine(comprobanteJson);

                Console.WriteLine("\n--- TODAS LAS PRUEBAS FINALIZARON CORRECTAMENTE ---");
            }
            catch (Exception ex)
            {
                // Si el polimorfismo falla (ej. ponemos 1 persona en la Sala) caerá directamente acá
                Console.WriteLine("\n[ERROR DE NEGOCIO CAPTURADO]: " + ex.Message);
            }

            Console.ReadLine(); // Pausa la consola para que puedas leer el resultado
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrillasPrincipales();
            CargarComboTipoRecurso();

            LlenarCamposClientes(dgvClientes.Rows[0]);
            LlenarCamposRecursos(dgvRecursos.Rows[0]);

        }

        private void CargarComboTipoRecurso()
        {
            TipoDeRecursoDAO dao = new TipoDeRecursoDAO();

            
            cboTipoRecurso.DisplayMember = "tipo_recurso";
            cboTipoRecurso.ValueMember = "id_tipo";
            cboTipoRecurso.DataSource = dao.ObtenerTodosParaCombo();


        }
        private void CargarGrillasPrincipales()
        {
            dgvClientes.DataSource = gestoraClientes.ObtenerTodos();
            dgvRecursos.DataSource = gestoraRecursos.ObtenerTodos();
            dgvReservas.DataSource = gestoraReservas.ObtenerDetalleReservas();
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void PruebasBackEnd(object sender, EventArgs e)
        {
            {
                // Usamos StringBuilder para ir acumulando los mensajes como si fuera una consola
                StringBuilder log = new StringBuilder();
                log.AppendLine("--- INICIANDO PRUEBAS DEL BACKEND ---");

                GestoraClientes gestoraClientes = new GestoraClientes();
                GestoraRecursos gestoraRecursos = new GestoraRecursos();
                GestoraReservas gestoraReservas = new GestoraReservas();

                try
                {
                    // 1. PRUEBA DE CLIENTE
                    Cliente nuevoCliente = new Cliente
                    {
                        IdCliente = 1,
                        Dni = "12345678",
                        Nombre = "Juan",
                        Apellido = "Pérez",
                        Telefono = "2231112222",
                        Email = "juan@email.com",
                        Activo = true
                    };
                    log.AppendLine($"1. Cliente {nuevoCliente.Nombre} {nuevoCliente.Apellido} configurado.");

                    // 2. PRUEBA DE RECURSO (Con Polimorfismo)
                    Sala nuevaSala = new Sala
                    {
                        Id = 1,
                        TipoRecurso = new TipoRecurso { IdTipo = 1, Descripcion = "Sala de Reuniones" },
                        Nombre = "Sala A - Directorio",
                        Ubicacion = "Planta Baja",
                        Capacidad = 10,
                        PrecioPorHora = 5000.00m,
                        Estado = EstadoRecurso.Disponible
                    };
                    log.AppendLine($"2. Recurso '{nuevaSala.Nombre}' instanciado correctamente.");

                    // 3. PRUEBA DE RESERVA Y VALIDACIONES DE NEGOCIO
                    Reserva nuevaReserva = new Reserva
                    {
                        Cliente = nuevoCliente,
                        Recurso = nuevaSala,
                        FechaReserva = DateTime.Now.AddDays(2),
                        HoraInicio = new TimeSpan(10, 0, 0),
                        HoraFin = new TimeSpan(12, 0, 0),
                        CantidadPersonas = 5,
                        EstadoReserva = EstadoReserva.Activa
                    };

                    Adicional proyector = new Adicional
                    {
                        IdAdicional = 1,
                        Descripcion = "Proyector 4K",
                        CostoExtra = 2500.00m,
                        TipoRecurso = nuevaSala.TipoRecurso
                    };
                    nuevaReserva.Adicionales.Add(proyector);

                    log.AppendLine("3. Validando reglas de negocio...");

                    // Llamada clave que dispara el polimorfismo y el cálculo de interfaz
                    nuevaReserva.CalcularCostoTotal();

                    log.AppendLine($"¡Reserva validada con éxito! Costo Total Calculado: ${nuevaReserva.CostoTotal}");

                    // 4. PRUEBA DE JSON
                    log.AppendLine("\n4. Comprobante JSON generado:");
                    log.AppendLine(nuevaReserva.ExportarAJson());

                    // Mostramos todo el resultado exitoso en un cuadro de diálogo grande
                    MessageBox.Show(log.ToString(), "Prueba Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Si falla alguna regla (ej. exceso de capacidad), el MessageBox mostrará el error exacto y un ícono de advertencia
                    MessageBox.Show("ERROR DE NEGOCIO:\n\n" + ex.Message, "Validación Rechazada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void PruebasBDD(object sender, EventArgs e)
        {
            StringBuilder log = new StringBuilder();
            log.AppendLine("--- INICIANDO PRUEBAS DE BASE DE DATOS ---");

            try
            {
                GestoraClientes gestoraClientes = new GestoraClientes();
                GestoraRecursos gestoraRecursos = new GestoraRecursos();
                GestoraReservas gestoraReservas = new GestoraReservas();

                // 1. Prueba de conexión y lectura de Clientes
                log.AppendLine("\n1. Conectando a MySQL y leyendo Clientes...");
                DataTable tablaClientes = gestoraClientes.ObtenerTodos();
                log.AppendLine($"¡Éxito! Se trajeron {tablaClientes.Rows.Count} clientes activos desde la base de datos.");

                // 2. Prueba de lectura de Recursos (Verifica el JOIN interno con TiposRecurso)
                log.AppendLine("\n2. Leyendo el catálogo de Recursos...");
                DataTable tablaRecursos = gestoraRecursos.ObtenerTodos();
                log.AppendLine($"¡Éxito! Se encontraron {tablaRecursos.Rows.Count} recursos disponibles.");

                // 3. Prueba de Vistas y Reservas
                log.AppendLine("\n3. Consultando la Vista de Reservas Históricas...");
                DataTable tablaReservas = gestoraReservas.ObtenerDetalleReservas();
                log.AppendLine($"¡Éxito! Se cargaron {tablaReservas.Rows.Count} reservas (con sus cruces de datos).");

                // Si llegó hasta acá sin saltar al catch, la conexión es perfecta
                log.AppendLine("\n--- LA CONEXIÓN CON MYSQL ESTÁ 100% OPERATIVA ---");
                MessageBox.Show(log.ToString(), "Prueba de BD Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                // Si hay error en la cadena de conexión o en algún Stored Procedure, salta acá
                MessageBox.Show("ERROR AL COMUNICARSE CON MYSQL:\n\n" + ex.Message,
                                "Fallo de Base de Datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void PruebasJSon(object sender, EventArgs e)
        {
            using(MySqlConnection conexion = ConexionDAO.CrearConexion())
            {
                try
                {
                    // 1. Armamos un Cliente de prueba
                    Cliente clientePrueba = new Cliente
                    {
                        IdCliente = 1,
                        Dni = "30111222",
                        Nombre = "Ana",
                        Apellido = "Gómez",
                        Email = "ana@email.com",
                        Telefono = "2234445555",
                        Activo = true
                    };

                    // 2. Armamos un Recurso de prueba (Sala)
                    Sala salaPrueba = new Sala
                    {
                        Id = 10,
                        TipoRecurso = new TipoRecurso { IdTipo = 1, Descripcion = "Sala de Reuniones" },
                        Nombre = "Sala Premium B",
                        Ubicacion = "Piso 2",
                        Capacidad = 8,
                        PrecioPorHora = 4500.00m,
                        Estado = EstadoRecurso.Disponible
                    };

                    // 3. Armamos la Reserva y le agregamos un Adicional
                    Reserva reservaPrueba = new Reserva
                    {
                        Cliente = clientePrueba,
                        Recurso = salaPrueba,
                        FechaReserva = DateTime.Now.AddDays(3),
                        HoraInicio = new TimeSpan(14, 0, 0), // 14:00 hs
                        HoraFin = new TimeSpan(18, 0, 0),    // 18:00 hs (4 horas)
                        CantidadPersonas = 5,
                        EstadoReserva = EstadoReserva.Activa
                    };

                    Adicional catering = new Adicional
                    {
                        IdAdicional = 5,
                        TipoRecurso = salaPrueba.TipoRecurso,
                        Descripcion = "Catering y Café",
                        CostoExtra = 15000.00m
                    };
                    reservaPrueba.Adicionales.Add(catering);

                    // Calculamos el total (4 horas x 4500 + 15000 = 33000)
                    reservaPrueba.CalcularCostoTotal();

                    // ========================================================
                    // 4. MAGIA DEL JSON (Usando la interfaz IExportable)
                    // ========================================================
                    string jsonGenerado = reservaPrueba.ExportarAJson();

                    // 5. Lo mostramos en un cuadro de diálogo
                    MessageBox.Show(jsonGenerado, "Comprobante JSON Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 6. Lo guardamos como un archivo físico en el Escritorio de tu PC
                    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string rutaArchivo = Path.Combine(rutaEscritorio, "Comprobante_Reserva_AnaGomez.json");

                    File.WriteAllText(rutaArchivo, jsonGenerado);

                    MessageBox.Show($"¡El archivo físico se guardó exitosamente en:\n{rutaArchivo}", "Backup Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la prueba: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                LlenarCamposClientes(fila);
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TabPage tabSeleccionado = tabPrincipal.SelectedTab;
            if (tabSeleccionado == tabClientes)
            {
                if (!ValidarDatosFormulario(tabClientes))
                {
                    MessageBox.Show("Faltan completar algunos datos.", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cliente nuevoCliente = new Cliente();
                nuevoCliente.Apellido = txtApellido.Text;
                nuevoCliente.Dni = txtDni.Text;
                nuevoCliente.Email = txtEmail.Text;
                nuevoCliente.Nombre = txtNombre.Text;

                AgregarCliente(nuevoCliente);
                
            }
            
        }


        private void LimpiarFormularios(TabPage tabSeleccionado)
        {
            if (tabSeleccionado == tabClientes)
            {
                txtIdCliente.Text = string.Empty;
                txtDni.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtEmail.Text = string.Empty;
                clbEstado.Checked = false;
            }else if (tabSeleccionado == tabRecursos)
            {

            }
            else
            {
                // reservas
            }
        }

        private bool ValidarDatosFormulario(TabPage tabSeleccionado)
        {
            bool valido = true;
            if (tabSeleccionado == tabClientes)
            {
              if (dgvClientes.SelectedRows.Count > 0 && string.IsNullOrEmpty(txtIdCliente.Text))// sdi entra aca es porque tengo 
                    //una seleccion en la grilla que aun no se reflejo en las cajas de texto
                {
                    
                }
                // hacer las validaciones de las cajas 
                
            }else if(tabSeleccionado == tabRecursos)
            {

            }
            else
            {

            }
            return valido;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TabPage tabSeleccionado = tabPrincipal.SelectedTab;
            if (tabSeleccionado == tabClientes)
            {

                if (!ValidarDatosFormulario(tabClientes))
                {
                    MessageBox.Show("Faltan completar algunos datos.", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cliente clienteModificado = new Cliente();
                clienteModificado.Apellido = txtApellido.Text;
                clienteModificado.Dni = txtDni.Text;
                clienteModificado.Email = txtEmail.Text;
                clienteModificado.Nombre = txtNombre.Text;
                clienteModificado.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                clienteModificado.Telefono = txtTelefono.Text;
                clienteModificado.Activo = clbEstado.Checked;

                ModificarCliente(clienteModificado);
               
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TabPage tabSeleccionado = tabPrincipal.SelectedTab;

            LimpiarFormularios(tabSeleccionado);
            ActualizarGrilla(tabSeleccionado);
            
        }
        
        private void ActualizarGrilla(TabPage tabSeleccionado)
        {
            if (tabSeleccionado == tabClientes)
            {
                dgvClientes.DataSource = gestoraClientes.ObtenerTodos();
            }else if(tabSeleccionado == tabRecursos)
            {
                dgvRecursos.DataSource = gestoraRecursos.ObtenerTodos();
            }
            else
            {
                dgvReservas.DataSource = gestoraReservas.ObtenerDetalleReservas();
            }
        }

        private void LlenarCamposRecursos(DataGridViewRow fila)
        {
            txtIdRecurso.Text = Convert.ToString(fila.Cells["id_recurso"].Value);
            txtNombreRecurso.Text = Convert.ToString(fila.Cells["nombre"].Value);
            txtUbicacionRecurso.Text = Convert.ToString(fila.Cells["ubicacion"].Value);
            txtCapacadidadRecurso.Text= Convert.ToString(fila.Cells["capacidad"].Value);
            txtPrecioPorHr.Text= Convert.ToString(fila.Cells["precio_por_hora"].Value);

            if (fila.Cells["id_tipo"].Value != DBNull.Value)
            {
                cboTipoRecurso.SelectedValue = Convert.ToString(fila.Cells["tipo_recurso"].Value);
            }
            


        }
        private void LlenarCamposReservas(DataGridViewRow fila)
        {

        }
        private void LlenarCamposClientes(DataGridViewRow fila)
        {
            txtApellido.Text = Convert.ToString(fila.Cells["apellido"].Value);
            txtDni.Text = Convert.ToString(fila.Cells["dni"].Value);
            txtEmail.Text = Convert.ToString(fila.Cells["email"].Value);
            txtIdCliente.Text = Convert.ToString(fila.Cells["id_cliente"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["nombre"].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells["telefono"].Value);
            clbEstado.Checked = Convert.ToString(fila.Cells["activo"].Value).ToLower() == "true" ? true : false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TabPage tabSeleccionado = tabPrincipal.SelectedTab;

            if (tabSeleccionado == tabClientes)
            {
                DialogResult rsta = MessageBox.Show("Seguro de eliminar el cliente?", 
                    "Atencion: va a eliminar un cliente",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);

                if (rsta == DialogResult.No)
                {
                    MessageBox.Show("Se cancelo la operacion",
                        "Operacion cancelada.",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    LimpiarFormularios(tabSeleccionado);
                    return;
                }

                int idCliente = Convert.ToInt32(txtIdCliente.Text);

                EliminarCliente(idCliente);
                
            }else if(tabSeleccionado == tabRecursos)
            {

            }
            else
            {

            }
        }

        private void ExportarAJson()
        {

        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            GestoraExportacion gestoraJSON = new GestoraExportacion();
            TabPage tabSeleccionado = new TabPage();
             

            // EXPORTAR CLIENTES
            if (tabSeleccionado == tabClientes)
            {
                try
                {
                    if (dgvClientes.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos en la grilla para exportar.",
                            "Atención",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    GestoraExportacion exportador = new GestoraExportacion();


                    exportador.GuardarArchivoJson(gestoraClientes, "ListadoCompleto_clientes.json");
                    string jsonListado = gestoraClientes.ExportarAJson();
                    File.WriteAllText("ListadoCompleto_Clientes.json", jsonListado);
                }catch(Exception ex)
                {
                    MessageBox.Show("Error al exportar: " +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                  
            }
            if (tabSeleccionado == tabRecursos)
            {

            }
            if (tabSeleccionado == tabReservas)
            {

            }
            
        }

        private void dgvRecursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRecursos.Rows[e.RowIndex];

                LlenarCamposRecursos(fila);
            }
        }

        private void dgvRecursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPrincipal_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
        }

        private void tabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage tabSeleccionado = new TabPage();

            string nombreJson = string.Empty;

            if (tabSeleccionado == tabClientes)
            {
                nombreJson = "Clientes";    
            }else if(tabSeleccionado == tabRecursos)
            {
                nombreJson = "Recursos";

            }else
            {
                nombreJson = "Reservas";

            }

            gbJson.Text = gbJson.Text  + nombreJson;
        }
    }
}
