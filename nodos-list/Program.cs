using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodos_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ListaNodo();
            list.ListaVacia();
            list.addNodo(1);
            list.addNodo(3);
            list.addNodo(2);
            list.addNodo(4);
            list.ListaVacia();
            list.Listar();
            list.DeletePrimero();
            Console.WriteLine();
            list.Listar();
            Console.ReadKey();

        }
    }
}
