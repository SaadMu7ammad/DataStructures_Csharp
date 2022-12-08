using System;

namespace stack_linkedlist
{
    class node
    {
       internal int data;
        internal node next;
        public node(int val)
        {
            data = val;
            next = null;
        }
    }
    class stack_linkedlist
    {
        node top;
        int len;
        public stack_linkedlist()
        {
            top = null;
            len = 0;
        }
        bool isEmpty()
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
                Console.Write(i.data+" ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            stack_linkedlist st = new stack_linkedlist();
            st.push(1);
            st.push(2);
            st.push(3);
            st.pop();
            st.pop();
            st.print();
            Console.WriteLine(st.count());
        }
    }
}
