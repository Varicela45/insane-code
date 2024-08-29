using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_Desordenada
{
    class ClaseNodo<Tipo>
    {

        public PedimentoExportacion miPedimento = new PedimentoExportacion();
        Tipo _objetoConDatos;
        ClaseNodo<Tipo> _siguiente;

        public Tipo ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }

        public ClaseNodo<Tipo> Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        ~ClaseNodo()
        {

        }

    }
}
