using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja
{
    public class Persona
    {
        private int _intEdad;
        private string _nombre;
        public int _telefono;

        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public Persona() { }
    }
}
