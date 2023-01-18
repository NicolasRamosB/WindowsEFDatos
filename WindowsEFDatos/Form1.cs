using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarTodosLosAviones();

        }

        private void MostrarTodosLosAviones()
        {
            dataGridAviones.DataSource = AdmAvion.Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LineaAerea lineaAerea = new LineaAerea()
            {
                Nombre = "Aeorparque Ezeiza",
                FechaInicioActividades = new DateTime(2020, 4, 10)
            };

            Avion avion = new Avion() 
            { 
                Capacidad = Convert.ToInt32(textCapacidad.Text),
                Denominacion = textDenominacion.Text,
                LineaAerea = lineaAerea
            };

            int filasAfectadas = AdmAvion.Insertar(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Avion Creado");
                MostrarTodosLosAviones();
            }
        }

    }
}
