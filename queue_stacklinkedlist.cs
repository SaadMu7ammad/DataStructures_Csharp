using System;

namespace queue_stack
{
    class stack_linkedlist
    {  class node
    {
        internal int data;
        internal node next;
        public node(int val)
        {
            data = val;
            next = null;
        }
    }
        node top;
        int len;
        public stack_linkedlist()
        {
            top = null;
            len = 0;
        }
       public bool isEmpty()
        {
            if (top == null)
                return true;
            return false;
        }
        public int count()
        {
            return len;
        }
        public void push(int val)
        {
            node temp = new node(val);//create the new node
            temp.next = top; //new node -> top ->top.next
            top = temp;// after updating the top : top ->top.next ->top.next.next
            len++;
        }
        public int pop()
        {
            if (!isEmpty())
            {
                int res = top.data;
                top = top.next;
                len--;
                return res;
            }
            else
                return -int.MaxValue;
        }
        public int peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
                return -int.MaxValue;
        }
        public void print()
        {
            for (node i = top; i != null; i = i.next)
            {
                Console.Write(i.data + " ");
            }
            Console.WriteLine();
        }
    }
    public class Queue
    {
         stack_linkedlist s1 = new stack_linkedlist();
         stack_linkedlist temp = new stack_linkedlist();
        public void enQueue(int x)//store the all content in s1(base) and swap with s2(temp) to make it as queue order
        {
            // Move all from s1 to s2
            while (s1.count() > 0)
            {
                temp.push(s1.pop());
            }
            // Push into s1
            s1.push(x);
            // Push everything back to s1
            while (temp.count() > 0)
            {
                s1.push(temp.pop());
            }
        }
        public int deQueue()
        {
            if (s1.count() == 0)
            {
                Console.WriteLine("Q is Empty");
            }
            int x = s1.peek();
            s1.pop();
            return x;
        }
        public void print()
        {
            s1.print();
        }
        public void front()
        {
            if (s1.count() > 0)
                Console.WriteLine(s1.peek());
        }
        public void Rear()
        {
            while (s1.count() > 0)
            {
                temp.push(s1.pop());
            }
            int val = temp.peek();
            // Push everything back to s1
            while (temp.count() > 0)
            {
                s1.push(temp.pop());
            }
            Console.WriteLine(val);
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.enQueue(3);
            q.enQueue(4);
            q.enQueue(5);
            q.print();// 3 4 5
            q.deQueue();// 4 5
            q.print();
           
            q.deQueue();//5
            q.enQueue(99);//the Rear   5 99
            q.print();
            q.front();// 5
            q.Rear();// 99
        }
    }
}
