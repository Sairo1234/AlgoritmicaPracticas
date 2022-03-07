using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            // Keep the console window open in debug mode.
            Console.WriteLine("¿Cuantos discos tienes en tu torre? :");
            n = Convert.ToInt32(Console.ReadLine());

            Pila ini = new Pila(n);
            Pila aux = new Pila();
            Pila fin = new Pila();
            Hanoi h = new Hanoi();

            int movimientos = h.iterativo(n, ini, aux, fin);

            Console.WriteLine("Se ha completado el puzle en " + movimientos + " movimientos");

        }
    }
}
