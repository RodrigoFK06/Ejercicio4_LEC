using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_LEC
{
    internal class Nodo
    {
        public int Codigo;
        public string Nombres;
        public double Nota;
        public Nodo Siguiente;
        public Nodo Anterior;

        public Nodo(int codigo, string nombres, double nota)
        {
            Codigo = codigo;
            Nombres = nombres;
            Nota = nota;
            Siguiente = null;
            Anterior = null;
        }
    }
}
