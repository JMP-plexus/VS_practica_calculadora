using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CochesCutresEntity.Models
{
    public class Compraventa
    {
        public int ID { get; set; }
        public DateTime fecha { get; set; }
        public Char tipo { get; set; }
        public virtual Empleado empleado { get; set; }
        public virtual Cliente cliente { get; set; }
        public virtual Coche coche { get; set; }
        public float precio { get; set; }
    }
}