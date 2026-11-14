using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_FINAL_ALGORITMOS_II.Conexion_BDD;
using TP_FINAL_ALGORITMOS_II.Gestoras;
using TP_FINAL_ALGORITMOS_II.Modelos;

namespace TP_FINAL_ALGORITMOS_II
{
    public partial class Form1 : Form
    {

        private readonly GestoraRecursos gestoraRecursos = new GestoraRecursos();
        private readonly GestoraClientes gestoraClientes = new GestoraClientes();
        private readonly GestoraReservas gestoraReservas = new GestoraReservas();



        public Form1()
        {
            InitializeComponent();
            
        }

        public void AgregarCliente(Cliente nuevoCliente)
        {
            try
            {
                ClienteDAO.AgregarCliente(nuevoCliente);

            }catch(MySqlException ex)
            {
                if (ex.SqlState == "45000")
                {
                    MessageBox.Show(ex.Message, "Error en la base de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
