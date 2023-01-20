using System;

namespace section_5
{
    public class CArray
    {
        int[] arr;
        int numelemnts;
        public CArray()
        {
            arr = new int[10];
            numelemnts = 0;
        }
        public CArray(int size)
        {
            arr = new int[size];
            numelemnts = 0;
        }
        public int[] get_arr()
        {
            return arr;
        }
        public void insert(int element)
        {
            if (numelemnts > arr.Length)
            {
                //arr is full
                Array.Resize(ref arr, (int)(numelemnts * 1.25));
            }
            arr[numelemnts] = element;
            numelemnts++;
        }
        public void showArray()
        {
            for (int i = 0; i < numelemnts; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public void showALLArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public void BubbleSort()//move the largest to the most right
        {
            int temp;
            for (int j = numelemnts - 1; j >= 1; j--)//start from the most right
            {
                for (int i = 0; i <= j - 1; i++)//start from 0 till most right j-1
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                       // showArray();
                    }
                }
            }
        }
      public  void SelectionSort()
        {
            int temp, min;
            for (int i = 0; i < numelemnts; i++)
            {
                min = i;
                for (int j = i + 1; j < numelemnts; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
               // showArray();
            }
        }
       public void InsertionSort()
        {
            for (int i = 1; i < numelemnts; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                    //showArray();
                }
                arr[j + 1] = key;
               // showArray();
            }
        }
        public void InsertionSort2()
        {
            for (int i = 1; i < numelemnts; i++) {

                int key = arr[i];
                int j = i;

                while (j > 0 && arr[j-1] > key) {
                    arr[j] = arr[j-1];
                    j--;
                }
                arr[j] = key;
               // showArray();
            }
        }
        public int BinarySearch(int[] arr, int target)
        {
            InsertionSort();// to do the bs the arr must be sorted
            int R = numelemnts;
            int L = 0;
            while (L <= R)
            {  
                int mid = (R + L) / 2;
                
                 if (arr[mid] ==target)
                {
                    return mid;
                }
                else if (arr[mid] > target)
                {
                    R = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    L = mid + 1;
                }
            }
            return -1;
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            CArray obj = new CArray();
            Random rndm = new Random();
            for (int i = 0; i < 5; i++)
            {
               obj.insert(rndm.Next(100));//100 is max fro random
            }
            obj.showArray();//before
            Console.WriteLine(obj.BinarySearch(obj.get_arr(),5));

            obj.showArray();
            obj.InsertionSort();
            obj.showArray();
        }
    }
}
        
    

