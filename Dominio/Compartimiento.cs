using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Compartimiento
    {
        public int ID { get; set; }
        public float Alto { get; set; }
        public float Ancho { get; set; }
        public float Largo { get; set; }
        public string Pasillo { get; set; }
        public string Lado { get; set; }
        public bool Climatizado { get; set; } // 0 no - 1 si
        public Deposito deposito { get; set; } // deposito en el que se encuentra
        public Producto producto { get; set; }
    }
}
