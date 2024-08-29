using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_Desordenada
{
    class ClasePilaDesordenada<Tipo> where Tipo : IEquatable<Tipo>
    {

        public ClaseNodo<Tipo> miNodo = new ClaseNodo<Tipo>();

        ClaseNodo<Tipo> _top;

        ClaseNodo<Tipo> Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public ClasePilaDesordenada()
        {
            Top = null;
        }

        public bool EstaVacia()
        {
            if (Top == null)
            {
                return (true);
            }
            return (false);
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (EstaVacia())
            {
                yield break;
            }
            ClaseNodo<Tipo> NodoActual = new ClaseNodo<Tipo>();
            NodoActual = Top;

            do
            {
                yield return (NodoActual.ObjetoConDatos);
                NodoActual = NodoActual.Siguiente;
            } while (NodoActual != null);
            {
                yield break;
            }
        }

        public void Push(Tipo objeto)
        {
            if (BuscarNodo(objeto) != null)
            {
                throw new Exception("Duplicado");
            }
            else
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = Top;
                Top = nodoNuevo;
            }

        }

        public Tipo Pop()
        {

            if (EstaVacia())
            {
                throw new Exception("Esta vacia");
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
            nodoActual = Top;
            Top = nodoActual.Siguiente;
            nodoEliminado = nodoActual;
            nodoActual.ObjetoConDatos = default(Tipo);

            return (nodoEliminado.ObjetoConDatos);

        }

        public Tipo Pop(Tipo objeto)
        {

            if (EstaVacia())
            {
                throw new Exception("Esta vacia");
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoPrevio = Top;

            do
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {

                    ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                    nodoEliminado = nodoActual;

                    if (objeto.Equals(Top.ObjetoConDatos))
                    {
                        Top = nodoActual.Siguiente;
                        nodoActual.ObjetoConDatos = default(Tipo);
                        return (nodoEliminado.ObjetoConDatos);
                    }

                    nodoPrevio.Siguiente = nodoActual.Siguiente;
                    nodoActual.ObjetoConDatos = default(Tipo);
                    return (nodoEliminado.ObjetoConDatos);

                }

                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;

            } while (nodoActual != null);
            {
                throw new Exception("No existe");
            }

        }

        public Tipo BuscarNodo(Tipo objeto)
        {

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;

            while(nodoActual != null)
            {
                if(objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    return (nodoActual.ObjetoConDatos);
                }
                nodoActual = nodoActual.Siguiente;
            }
            return default(Tipo);

        }

        public void Vaciar()
        {

            if (EstaVacia())
            {
                throw new Exception("Esta vacia");
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoPrevio = Top;

            do
            {
                Top = nodoActual.Siguiente;
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
                nodoPrevio.ObjetoConDatos = default(Tipo);
            } while (nodoActual == null);
            {
                Top = null;
                return;
            }

        }
        ~ClasePilaDesordenada()
        {
            Vaciar();
        }

    }
}
