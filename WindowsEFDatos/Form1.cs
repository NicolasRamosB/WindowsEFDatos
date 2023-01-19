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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LineaAerea lineaAerea = new LineaAerea()
            {
                
                Nombre = "Aeorparque Ezeiza",
                FechaInicioActividades = new DateTime(2020, 4, 10)
            };

            Avion avion = new Avion()
            {
                IdAvion = Convert.ToInt32(textID.Text),
                Capacidad = Convert.ToInt32(textCapacidad.Text),
                Denominacion = textDenominacion.Text
            };

            int filasAfectadas = AdmAvion.Update(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Avion Editado");
                MostrarTodosLosAviones();
            }

        }

        private void btnId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            Avion avion = AdmAvion.TraerUno(id);
            MessageBox.Show(avion.Denominacion + " " + avion.Capacidad);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Avion avion = new Avion()
            {
                IdAvion = Convert.ToInt32(textID.Text),
                
            };

            int filasAfectadas = AdmAvion.Eliminar(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Avion Eliminado");
                MostrarTodosLosAviones();
            }
        }
    }
}
