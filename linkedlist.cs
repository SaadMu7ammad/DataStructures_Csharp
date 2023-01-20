using System;
using System.Collections.Generic;
namespace linkedlist
{
    public class DoublyLinkedList
    {
        public class Node
    {
        public int Value;
        public Node Next;
        public Node Previous;
    }
        public Node Head;
        public Node Tail;
        int addedelemnts ;
        public DoublyLinkedList()
        {
            Head = Tail = null;
            addedelemnts = 0;
        }
        public void InsertAtHead(int element)
        {
            if (Head == null)
            {
                Head = new Node();
                Head.Value = element;
                Tail = Head;
                addedelemnts++;
            }
            else
            {
                Node newNode = new Node();
                newNode.Value = element;
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
                addedelemnts++;
            }
        }
        public void InsertAtTail(int element)
        {
            if (Head == null)
            {
                Head = new Node();
                Head.Value = element;
                Tail = Head;
                addedelemnts++;
            }
            else
            {
                Node newNode = new Node();
                newNode.Value = element;
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
                addedelemnts++;
            }
        }
        public void InsertAtPosition(int element, int position)
        {
            if (Head == null)
            {
                Head = new Node();
                Head.Value = element;
                Tail = Head;
                addedelemnts++;
            }
            else 
            {
                Node newNode = new Node();
                newNode.Value = element;
                if (position == 0)
                {
                    InsertAtHead(element);
                    return;
                }
                //Node temp = Head;
                //while (temp != null && position > 1)
                //{
                //    temp = temp.Next;
                //    position--;
                //}
                int tracer = 0;
                for(Node node = Head; node != null; node = node.Next,tracer++)
                {
                    if (tracer == position)
                    { 
                        Node tempPre = node.Previous;
                        tempPre.Next = newNode;
                        newNode.Previous = tempPre;
                        newNode.Next = node;
                        node.Previous = newNode;
                        addedelemnts++;
                        return;
                    }
                   else if(node.Next==null && tracer == addedelemnts - 1)
                    {
                        InsertAtTail(element);
                        return;
                    }
                }
                Console.WriteLine("cant insert in that index");
            }
        }

        public bool Delete(int value)
        {
            Node node = Head;
            while (node != null)
            {
                if (node.Value == value)
                {
                    node.Previous.Next = node.Next;
                    node.Next.Previous = node.Previous;
                    --addedelemnts;
                    return true;
                }
                else
                    node = node.Next;
            }
            return false;
        }
        public void delAtIndx(int indx,int c=0)
        {
            if (indx < addedelemnts)
            {
                for (Node i = Head; i != null; i = i.Next, c++)
                {
                    if (c == indx)
                    {
                        if (indx == 0)//first position
                        {
                            Head = i.Next;
                            i.Previous = null;
                            Head.Previous = null;
                          //  return true;
                        }
                        else if (indx == addedelemnts - 1)//last position
                        {
                            Tail = i.Previous;
                            Tail.Next = null;
                            
                        }
                        else//middle
                        {
                            Node tempprev = i.Previous;
                            tempprev.Next = i.Next;
                            i.Next.Previous = tempprev;
                        }
                        --addedelemnts;
                        return;
                       // return true;
                    }


                }
            }
            else
            {
                return;
              //  return false;
            }
        }

        public Node Search(int value)
        {
            Node node = Head;
            while (node != null)
            {
                if (node.Value == value)
                    return node;
                else
                    node = node.Next;
            }
            return null;
        }
        public void print()
        {
            for(Node node = Head; node!=null; node = node.Next)
            {
                Console.Write(node.Value+" ");
            }
            Console.WriteLine();
        }
        public void print_reverse()
        {
            for (Node node = Tail; node != null; node = node.Previous)
            {
                Console.Write(node.Value + " ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            DoublyLinkedList list = new DoublyLinkedList();
            list.InsertAtHead(5);
            list.InsertAtHead(15);
            list.InsertAtTail(20);
            list.InsertAtTail(25);
            list.InsertAtPosition(4, 3);
            list.InsertAtPosition(9, 2);
            list.InsertAtPosition(7, 5);
            list.InsertAtPosition(99,7);
            list.InsertAtPosition(999,7);
            list.InsertAtPosition(1000,10);
            list.InsertAtPosition(0,0);
            list.print();
            list.print_reverse();

            Console.WriteLine();
            list.delAtIndx(3);
            list.print();

            Console.WriteLine();
            list.delAtIndx(0);
            list.print();


            Console.WriteLine();
            list.delAtIndx(8);
            list.print();

            Console.WriteLine();
            list.delAtIndx(6);
            list.print();
        }
    }
}
