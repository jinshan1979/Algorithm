using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class ArrayDiff
    {
        int[] array1;
        int[] array2;

        internal ArrayDiff() {
            //test data
            //array1 = new int[]{1,2,3,4,9,8 };
            //array2 = new int[] {1,2,4,9,10};

            array1 = new int[100];
            array2 = new int[100];
            for (int i = 0; i < 100; i++)
            {
                array1[i] = i+1;
                array2[i] = i + 2;
            }
            
        }

        //the time complexity is n*n
        internal int[] getDiffList1()
        {
            DateTime now = System.DateTime.Now;

            int[] arrayDiff = new int[array1.Length + array2.Length];
            //check the array1 element in array2
            int j = 0;
            foreach (int i in array1)
            {
                if (!array2.Contains(i))
                {
                    arrayDiff[j] = i;
                    j++;
                }
            }

            //check the array2 in array1
            foreach (int i in array2)
            {
                if (!array1.Contains(i))
                {
                    arrayDiff[j] = i;
                    j++;
                }
            }

            //time cost
            TimeSpan cost = System.DateTime.Now - now;
            Console.WriteLine(cost.Milliseconds);

            return arrayDiff;
        }

        //improve for the time complexity,using Dictionary
         internal int[] getDiffList2()
        {
            DateTime now = System.DateTime.Now;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in array1)
            {
                dict[i] = 1;
            }

            foreach (int j in array2)
            {
                if (dict.ContainsKey(j))
                {
                    dict[j] = 2;
                }
                else
                {
                    dict[j] = 1;
                }
            }

            //Time cost
            TimeSpan cost = System.DateTime.Now - now;
            Console.WriteLine(cost.Milliseconds);

            return (from kvp in dict where kvp.Value == 1 select kvp.Key).ToArray();
        }

        //Sort firstly, then compare.
        internal int[] getDiffList3()
        {
            DateTime now = System.DateTime.Now; //Start time

            int[] array3 = array1.Concat(array2).ToArray();

            int[] sortArray3 = array3.OrderBy(g => g).ToArray();

            List<int> list = new List<int>();



            for (int i = 0; i < sortArray3.Length-1; i++)
            {
                if (i==0 && (sortArray3[i] != sortArray3[i + 1]))
                {
                    list.Add(sortArray3[i]);
                }
                else
                {
                    if (sortArray3[i] != sortArray3[i + 1] && sortArray3[i] != sortArray3[i - 1])
                    {
                        list.Add(sortArray3[i]);
                    }

                    if (i == sortArray3.Length - 2 && sortArray3[i] != sortArray3[i + 1])
                    {
                        list.Add(sortArray3[i + 1]);
                    }
                }
            }

            //Time cost
            TimeSpan cost = System.DateTime.Now - now;
            Console.WriteLine(cost.Milliseconds);

            return list.ToArray();
        }

        public void showDiff(int[] array)
        {
            foreach (int i in array)
            {
                if (i != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
