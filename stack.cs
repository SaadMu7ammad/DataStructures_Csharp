using System;

namespace stack
{
    class stack
    {
        static readonly int max = 1000;
        int top;
        int[] st = new int[max];
        bool isEmpty()
        {
            if (top >= 0)
                return false;
            return true;
        }
        public bool isFull()
        {
            if (top ==max)
                return true;
            return false;
        }
        public int count()
        {
            return top + 1;
        }
        public stack()
        {
            top = -1;
        }
        public void push(int val)
        {
            if (top >= max)
            {
                Console.WriteLine("stack is full");
                return;
            }
            else
                 st[++top] = val;
        }
        public int pop()
        {
            if (!isEmpty())
            {
                int val = st[top];
                top--;
                return  val;
            }
            else
                return 0;
        }
        public int peek()
        {
            if (!isEmpty())
            {
                return st[top];
            }
            else
                return -int.MaxValue;
        }
        public void print()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.Write(st[i]+" ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            stack st = new stack();
            st.push(1);
            st.push(2);
            st.push(3);
            st.pop();
            st.pop();
            st.pop();
            st.pop();
            st.pop();
            st.push(88);
            st.print();
            Console.WriteLine(st.count());
        }
    }
}
