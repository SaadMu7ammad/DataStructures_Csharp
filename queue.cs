using System;

namespace Queue
{
    public class Queue
    {
        private int front, rear, capacity;
        private int[] queue;
        public Queue(int c)
        {
            front = rear = 0;
            capacity = c;
            queue = new int[capacity];
        }
        public bool isfull()
        {
            if (rear < capacity)
                return false;
            return true;

        }
        public bool isempty()
        {
            if (rear ==front )
                return true;
            return false;
        }
        public void Enqueue(int data)//  insert at rear
        {
            if (isfull()) 
            {
                Console.Write("\nQueue is full\n");
                return;
            }
            else
            {
                queue[rear] = data;
                rear++;
            }
            return;
        }
        // delete front
        public void Dequeue()
        {
            // if queue is empty
            if (isempty())
            {
                return;
            }
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1]; // shift to left
                }
                if (rear < capacity)
                    queue[rear] = 0;
                rear--;
            }
            return;
        }
        public void print()
        {
            for ( int i = front; i < rear; i++)
            {
                Console.Write(queue[i]+" ");
            }
            Console.WriteLine();
        }
        public void Front()// print front of queue
        {
            if (isempty())
            {
                return;
            }
            Console.WriteLine(queue[front]);
        }
    }
        class Program
      {
        static void Main(string[] args)
        {
            Queue q = new Queue(5);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.print();
            q.Dequeue();
            q.Dequeue();          
            q.Dequeue();

            q.print();
        }
    }
}
