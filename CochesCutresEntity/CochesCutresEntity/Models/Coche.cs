using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CochesCutresEntity.Models
{
    public class Coche
    {

        public int ID { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int npuertas { get; set; }
        public string color { get; set; }
        public int kilometros { get; set; }
        public string tipovehiculo { get; set; }
        public int garantia { get; set; }
        public Boolean estastock { get; set; }
        public string fotografia { get; set; }
        public virtual ICollection<Compraventa> Compraventas { get; set; }

    }
}