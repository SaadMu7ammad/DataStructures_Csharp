using System;

namespace BinaryHeap
{
    class BinaryHeap
    {
                //INSERT >> HEAPIFY UP
                //DELETE >> HEAPIFY DOWN
        const int capacity =1000;
        int[] arr=new int[capacity];
        int size;
        public BinaryHeap()
        {
            size = 0;
        }
        public void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
        int minimum(int a,int b)
        {
            if (a >= b) return b;
            return a;
        }
        void heapify_up(int child_indx)
        {
            if (child_indx == 0 || arr[child_indx] > arr[parent(child_indx)]){//ordered correctly or contain one element
                return;
            }
            swap(ref arr[child_indx], ref arr[parent(child_indx)]);
            heapify_up(parent(child_indx));
            
        }
        void heapify_down(int parentindx)
        {
            if (left(parentindx) == -1) return;
            //***notice this commented code
            //if (array[parentindx] < min(array[left(parentindx)], array[right(parentindx)]))return;
            //choose the smaller children of parent
            int smallerindx;
            if (right(parentindx) != -1 && arr[left(parentindx)] > arr[right(parentindx)])
            {
                smallerindx = right(parentindx);
            }
            else
            {
                smallerindx = left(parentindx);
            }

            if (arr[smallerindx] < arr[parentindx])
            {
                swap(ref arr[parentindx],ref arr[smallerindx]);
                heapify_down(smallerindx);
            }
        }
        bool isEmpty()
        {
            return size== 0;
        }
        int left(int nodepos)
        {

            int pos = (2 * nodepos) + 1;
            return pos >= size ? -1 : pos;
        }
        int right(int nodepos)
        {

            int pos = (2 * nodepos) + 2;
            return pos >= size ? -1 : pos;
        }
        int parent(int nodepos)
        {

            int pos = ((nodepos - 1) / 2);
            return pos >= size || nodepos == 0 ? -1 : pos;
        }
        public void push(int num)
        {
            if (size < capacity)
            {
                arr[size++] = num;
                heapify_up(size - 1);
            }
        }
        public void pop()//remove the parent element
        {
            if (!isEmpty())
            {
                arr[0] = arr[--size];
               heapify_down(0);//we swap the parent and remove it 
            }
        }
        public void print()
        {
            for(int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        public int search(int val)
        {
            for(int i = 0; i < size; i++)
            {
                if (arr[i] == val) return 1;
            }
            return 0;
        }

    }
    class Program
    {
     
        static void Main(string[] args)
        {
            BinaryHeap bheap = new BinaryHeap();

            bheap.push(30);
            bheap.push(7);

            bheap.push(12);
            bheap.push(22);
            bheap.push(17);
            bheap.pop();
            bheap.push(2);
            bheap.push(6);
            bheap.pop();
            bheap.push(8);
            bheap.push(14);
            bheap.pop();
            bheap.push(10);
            bheap.push(19);
            bheap.push(37);
            bheap.push(25);
            bheap.pop();
            bheap.print();
            Console.WriteLine(bheap.search(4));
            Console.WriteLine(bheap.search(37));

        }
    }
}
