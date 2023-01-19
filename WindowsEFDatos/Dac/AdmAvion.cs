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

        public static int Update(Avion avion)
        {
            Avion avionOrigen = context.Avion.Find(avion.IdAvion);
            avionOrigen.Denominacion = avion.Denominacion;
            return context.SaveChanges();
        }

        public static int Insertar(Avion avion)
        {
            context.Avion.Add(avion);
            return context.SaveChanges();

        }

        public static int Eliminar(Avion avion)
        {
            Avion avionOrigen = context.Avion.Find(avion.IdAvion);
            if (avionOrigen != null)
            {
                context.Avion.Remove(avionOrigen);
                return context.SaveChanges();

            }
            return  0;
        }

        public static Avion TraerUno(int id)
        {
            return context.Avion.Find(id);
        }
    }
}
