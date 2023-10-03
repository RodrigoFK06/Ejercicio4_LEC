using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_LEC
{
    internal class ListaEnlazadaDoble
    {
        public Nodo Primero;
        public Nodo Ultimo;
        public int Aprobados { get; private set; }
        public int Desaprobados { get; private set; }

        public ListaEnlazadaDoble()
        {
            Primero = null;
            Ultimo = null;
            Aprobados = 0;
            Desaprobados = 0;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Nodo nuevoNodo = new Nodo(estudiante.Codigo, estudiante.Nombres, estudiante.Nota);

            if (Primero == null)
            {
                Primero = nuevoNodo;
                Ultimo = nuevoNodo;
            }
            else if (estudiante.Nota >= 6.0)
            {
                nuevoNodo.Siguiente = Primero;
                Primero.Anterior = nuevoNodo;
                Primero = nuevoNodo;
            }
            else
            {
                nuevoNodo.Anterior = Ultimo;
                Ultimo.Siguiente = nuevoNodo;
                Ultimo = nuevoNodo;
            }
            if (estudiante.Nota >= 12.0)
                Aprobados++;
            else
                Desaprobados++;
        }

        public void EliminarEstudiante(int codigo)
        {
            Nodo actual = Primero;

            while (actual != null)
            {
                if (actual.Codigo == codigo)
                {
                    if (actual.Anterior != null)
                        actual.Anterior.Siguiente = actual.Siguiente;
                    else
                        Primero = actual.Siguiente;

                    if (actual.Siguiente != null)
                        actual.Siguiente.Anterior = actual.Anterior;
                    else
                        Ultimo = actual.Anterior;

                    if (actual.Nota >= 12.0)
                        Aprobados--;
                    else
                        Desaprobados--;

                    break;
                }

                actual = actual.Siguiente;
            }
        }
    }
}
