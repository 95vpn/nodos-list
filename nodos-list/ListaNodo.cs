using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodos_list
{
    public class ListaNodo
    {
        private Nodo primero;
        private int size;

        public ListaNodo()
        {
            primero = null;
            size = 0;
        }

        public void addNodo(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            Nodo valor1, valor2;
            if (primero == null)
            {
                primero = nuevo;
                nuevo.siguiente = null;
            }
        }
    }
}
