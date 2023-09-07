using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStatic
{
    class QueueExample
    {
        private int maxSize; // Maximum size of the queue
        private int front;    // Index of the front element
        private int rear;     // Index of the rear element
        private int[] queue;  // Array to store elements

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
                Console.WriteLine("The queue is full. Cannot add more elements.");
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
                Console.WriteLine("The queue is empty. Cannot dequeue any element.");
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
                Console.WriteLine("The queue is empty. Cannot peek at the front element.");
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
                Console.WriteLine("The queue is empty.");
            }
        }
    }
}
