﻿using System;
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

        public void push(Disco d)
        {
            Elementos.Add(d);
            Size++;
            Top = d.Valor;
        }

        public Disco pop()
        {
            Disco d = Elementos.ElementAt(Top);
            Elementos.RemoveAt(Top);
            Size--;
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
