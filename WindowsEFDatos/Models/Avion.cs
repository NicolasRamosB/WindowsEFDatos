using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFDatos.Models
{
    [Table("Avion")]
    public class Avion
    {
        [Key]
        public int IdAvion { get; set; }

        public int Capacidad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Denominacion { get; set; }

        public int IdLinea { get; set; }

        [ForeignKey("IdLinea")]
        public LineaAerea LineaAerea { get; set; }
    }
    
}
