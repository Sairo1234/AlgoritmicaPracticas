using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }

        public int Top { get; set; }

        public List<Disco> Elementos { get; set; }


        /* TODO: Implementar métodos */
        public Pila()
        {
            Size = 0;

            Top = 0;

            Elementos = new List<Disco>();
        }
        public Pila(int n)
        {
            Size =  n;

            Top = n;

            for (int i = n; i < 0; i++)
            {
                Disco nuevo = new Disco();
                nuevo.Valor = i;
                Elementos.Add(nuevo);
            }
            
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Size++;
            Top = d.Valor;
        }

        public Disco pop()
        {
            Disco d = Elementos.Last();
            Elementos.RemoveAt(Elementos.Count-1);
            Size = Elementos.Count;
            Top = Elementos.Last().Valor;
            return d;

        }

        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            return false;
        }

    }
}
