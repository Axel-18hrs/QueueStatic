using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStatic
{
    class QueueExample
    {
        private int maxSize; // Tamaño máximo de la cola
        private int front;    // Índice del elemento frontal
        private int rear;     // Índice del elemento posterior
        private int[] queue;  // Arreglo para almacenar elementos

        public QueueExample(int size)
        {
            maxSize = size;
            front = 0;
            rear = -1;
            queue = new int[maxSize];
        }

        public void Enqueue(int item)
        {
            if (rear < maxSize - 1)
            {
                queue[++rear] = item;
            }
            else
            {
                Console.WriteLine("La cola está llena. No se puede agregar más elementos.");
            }
        }

        public int Dequeue()
        {
            if (front <= rear)
            {
                return queue[front++];
            }
            else
            {
                Console.WriteLine("La cola está vacía. No se puede sacar ningún elemento.");
                return -1;
            }
        }

        public bool IsEmpty()
        {
            return front > rear;
        }

        public int Peek()
        {
            if (!IsEmpty())
            {
                return queue[front];
            }
            else
            {
                Console.WriteLine("La cola está vacía. No se puede consultar el elemento frontal.");
                return -1;
            }
        }
        public void DisplayQueue()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Queue elements:");
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(queue[i]);
                }
            }
            else
            {
                Console.WriteLine("The Queue is empty");
            }
        }
    }
}
