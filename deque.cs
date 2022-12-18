using System;

namespace deque
{
    class deque
    {
        static readonly int MAX = 1000;
        int []arr;
        int front;//moves by indx-1 (backwards) from n-1
        int rear;//moves by indx+1 (forwards) from 0 
        int size;
        int len;
        public deque(int size)
        {
            this.size = size;
            arr = new int[MAX];
            front = 0;
            rear = 0;
            len = 0;
        }
        public bool isFull()
        {
            return len == size;//((abs(rear-front==1)));
        }
        public bool isEmpty()
        {
            return len==0; //(front == 0 && rear == 0);
        }
        public void insertFront(int val)
        {
            if (isFull())
            {
                Console.WriteLine("Overflow");
                return;
            }
            else 
            {
                ++len;
                //front start storing at indx= size-1 then goes to left
                if (front == 0) front = size - 1;
                else front--;
                arr[front] = val;
            }
        }

        public void deleteFront()
        {
            if (isEmpty())
            {
                Console.WriteLine("Underflow");
                return;
            }
            --len;
            if (front == size - 1)
            {
                front = 0;
            }
            else
            front++;
        }
        public void insertRear(int val)
        {
            if (isFull())
            {
                Console.WriteLine("Overflow");
                return;
            }
             ++len;
            if (rear == size - 1)
            { 
              arr[rear] = val;
              rear =0;
            }
            else
            {
                arr[rear] = val;
                rear = rear+1;
            }
             
        }
        public void deleteRear()
        {
            if (isEmpty())
            {
                Console.WriteLine("Underflow");
                return;
            }
            --len;
             if (rear ==0 )
             {
                rear = size - 1;
             }
            else
            {
                rear = rear - 1;
            }
        }
        public void print()
        {
            if (!isEmpty())
            {
                for (int i = front; i < size; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                for (int i = 0; i < rear; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            deque dq = new deque(10);
            dq.insertRear(4);
            dq.insertFront(2);
            dq.insertFront(5);
            dq.insertFront(6);
            dq.insertFront(7);

            dq.insertRear(100);
            dq.insertFront(44);
            dq.deleteRear();
            dq.deleteFront();
            dq.insertFront(22);
            dq.insertRear(77);
            dq.print();
        }
    }
}
