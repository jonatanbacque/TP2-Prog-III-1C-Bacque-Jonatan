using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Autoelevador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public float Capacidad { get; set; } // peso que soporta
        public int Deposito { get; set; } // deposito en el que se encuentra
    }
}
