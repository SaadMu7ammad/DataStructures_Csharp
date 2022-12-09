using System;

namespace Queue_linkedlist
{
    public class Queue_linkedlist
    {
        public class Node
        {
            public Node(int val)
            {
                Value = val;
            }
            public int Value;
            public Node Next;
            public Node Previous;
        }
       private Node rear, front;
        public Queue_linkedlist()
        {
            front = rear = null;
          
        }
        public bool isempty()
        {
            if (rear == front&&front==null)
                return true;
            return false;
        }
        public void Enqueue(int data)//  insert at rear
        {
            Node temp = new Node(data);
            if (isempty())
            {
                rear = front = temp;
                return;
            }
            else
            {
                rear.Next = temp;
                rear = temp;
                return;
            }
        }
        public void Dequeue()
        {
            // if queue is empty
            if (isempty())
            {
                return;
            }
            else
            {
                front = front.Next;
                if (front == null)
                {
                    rear = front = null;
                }
            }
        }
        public void print()
        {
            for ( Node i = front; i!=null; i=i.Next)
            {
                Console.Write(i.Value + " ");
            }
            Console.WriteLine();
        }
        public void Front()// print front of queue
        {
            if (isempty())
            {
                return;
            }
            Console.WriteLine(front.Value);
        }
        public void Rear()// print rear of queue
        {
            if (isempty())
            {
                return;
            }
            Console.WriteLine(rear.Value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue_linkedlist q = new Queue_linkedlist();
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.print();
            q.Dequeue();
            q.Dequeue();
            q.print();
            q.Front();
            q.Rear();
            q.Enqueue(99);
            q.Front();
            q.Rear();
        }
    }
}
