using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public class AdmAvion
    {
        private static DBLineaAerea context = new DBLineaAerea();

        public static List<Avion> Listar()
        {
            return context.Avion.ToList();

        }

        public static int Insertar(Avion avion)
        {
            context.Avion.Add(avion);
            return context.SaveChanges();

        }
    }
}
