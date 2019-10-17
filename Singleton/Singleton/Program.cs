using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //SingletonDemo instance1 = SingletonDemo.getInstance();
            //instance1.showMessage();

            //-------------Testing for sort------------
            //int[] array = { 1, 7, 4, 5, 3 };
            //Program p = new Program();

            //p.sort_pubble(array);

            //-----------testing for algorithm--------------
            //StackCase case1 = new StackCase();

            //case1.push(1);
            //case1.push(2);
            //case1.push(3);
            //Console.WriteLine(case1.pop());
            //case1.push(4);
            //Console.WriteLine(case1.pop());
            //Console.WriteLine(case1.pop());
            //Console.WriteLine(case1.pop());
            //Console.WriteLine(case1.pop());

            //-------------testing for quickSort--------------
            int[] array = { 4, 5, 6, 9, 1, 2, 3 };
            p.sort_quick(array, 0, array.Length - 1);
            p.print(array);


            Console.ReadKey();

        }


        public void sort_pubble(int[] array)
        {
            int size = array.Length;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i]+" ");
            }
        }

        public void sort_quick(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int index = getIndex(arr, low, high);

                sort_quick(arr, low, index - 1);
                sort_quick(arr, index + 1, high);
            }
        }

        public int getIndex(int[] arr, int low, int high)
        {
            int temp = arr[low];

            while (low < high)
            {
                while (low < high && arr[high] >= temp)
                {
                    high--;
                }
                arr[low] = arr[high];

                while (low < high && arr[low] <= temp)
                {
                    low++;
                }

                arr[high] = arr[low];
            }

            arr[low] = temp;

            return low;       

        }

        public void print(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }

    public class SingletonDemo
    {
        private static SingletonDemo instance = new SingletonDemo();

        //私有化构造函数，这样该类就不会被私有化
        private SingletonDemo() { }

        public static SingletonDemo getInstance() {
            return instance;
        }

        public void showMessage() {
            Console.WriteLine("Hello World!");
        }
    }

    public class StackCase
    {

        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();

        public int length;

        public void push(int item)
        {
            if (q2.Count == 0)
            {
                q1.Enqueue(item);
            }
            else
            {
                q2.Enqueue(item);
            }
        }

        public int? pop()
        {
            if (q1.Count != 0)
            {
                while (q1.Count > 1)
                {
                    q2.Enqueue(q1.Dequeue());
                }

                return q1.Dequeue();
            }
            else if (q2.Count != 0)
            {
                while (q2.Count > 1)
                {
                    q1.Enqueue(q2.Dequeue());
                }

                return q2.Dequeue();

            }
            else
            {
                return null;
            }
        }


    }
}
