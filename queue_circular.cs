using System;
using System.Collections.Generic;
namespace CircularQueue
{
    public class CircularQueue
    {
        private int size, front, rear;
        private List<int> queue = new List<int>();
      public  CircularQueue(int size)
        {
            this.size = size;
            this.front = this.rear = -1;
        }
        public void enQueue(int data)
        {
            // Condition if queue is full.
            if ((front == 0 && rear == size - 1) || (rear == (front - 1) % (size - 1)))//second or>> if rear is before the front
            {
                Console.Write("Queue is Full");
            }
            else if (front == -1)//empty
            {
                front = 0;
                rear = 0;
                queue.Add(data);
            }
            else if (rear == size - 1 && front != 0)//not full but rear at the end so make rear go the the first indx 0
            {
                rear = 0;
                queue[rear] = data;
            }
            else
            {
                rear = (rear + 1);
                if (front <= rear)
                {
                    queue.Add(data);
                }
                else//rear is before the front but its not full
                {
                    queue[rear] = data;
                }
            }
        }
        // Function to dequeue an element
        public int deQueue()
        {
            if (front == -1)
            {
                Console.Write("Queue is Empty");
                return -1;
            }
            int temp = queue[front];
            if (front == rear)//contain only one element
            {
                front = -1;
                rear = -1;
            }
            else if (front == size - 1)//circulate it to indx 0
            {
                front = 0;
            }
            else
            {
                front = front + 1;
            }
            return temp;
        }
        public void print()
        {
            if (front == -1)
            {
                Console.Write("Queue is Empty");
                return;
            }
            if (rear >= front)
            {
                for (int i = front; i <= rear; i++) // front to rear
                {
                    Console.Write(queue[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = front; i < size; i++) // front to last index
                {
                    Console.Write(queue[i]);
                    Console.Write(" ");
                }
                for (int i = 0; i <= rear; i++)//from  0th index till rear position
                {
                    Console.Write(queue[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

    }
        class Program
    {
        static void Main(string[] args)
        {
            CircularQueue cq = new CircularQueue(5);
            cq.enQueue(4);
            cq.enQueue(5);
            cq.enQueue(6);
            cq.deQueue();
            cq.enQueue(9);
            cq.print();
        }
    }
}
