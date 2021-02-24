using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CochesCutresEntity.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        public string NIF { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public virtual ICollection<Compraventa> Compraventas { get; set; }
    }
}