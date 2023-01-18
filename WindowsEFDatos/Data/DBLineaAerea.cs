using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Data
{
    public class DBLineaAerea : DbContext
    {
        public DBLineaAerea() : base("KeyDB") { }

        public DbSet<LineaAerea> LineaAereas { get; set; }
        public DbSet<Avion> Avion { get; set; }
    }
}
