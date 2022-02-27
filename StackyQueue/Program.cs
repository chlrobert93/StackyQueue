using System;
using System.Collections;

namespace StackyQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implementación de la clase Queue

            Queue q = new Queue();

            //Agregar elementos a nuestra cola
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            

            Console.WriteLine("Los elementos de la cola son: ");
            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }

            Console.WriteLine("Ahora el contenido de nuestra cola son: " + q.Count);

            //Implementación de la Clase Stack

            Stack s = new Stack();

            s.Push("1");
            s.Push("2");
            s.Push("3");

            /*while (s.Count > 0)
            {
                //devuelve y quita el ultimo que se inserto
                Console.WriteLine(s.Pop());
            }*/

            foreach (string numero in s)
            {
                Console.WriteLine(numero);
            }

            s.Clear();

            Console.WriteLine("Los Elementos que hay ahora en la Pila son: " + s.Count);

            foreach (string numero in s)
            {
                Console.WriteLine(numero);
            }


            Console.ReadKey();

        }
    }
}
