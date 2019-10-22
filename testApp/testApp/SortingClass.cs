using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class SortingClass
    {
        int[] array;

        public void print()
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
        public void CountingSort(int[] a)
        {
            int minV = a[0];
            int maxV = a[0];

            //get the min/max value
            foreach (int i in a)
            {
                if (minV > i)
                    minV = i;
                if (maxV < i)
                    maxV = i;
            }

            int[] temp = new int[maxV - minV+1]; //定义一整数数组

            //元素计数
            foreach (int i in a)
            {
                temp[i - minV]++;
            }

            //获取排序数列
            int index = 0;
            for(int i=0;i<temp.Length;i++)
            {
                int value = temp[i];

                while (value-- > 0)
                {
                    a[index++] = i+minV;
                }
            }

            array = a;
        }

        public void RadixSort(int[] a)
        {
            //获取数组最大值
            int maxV = Int32.MinValue;
            foreach (int i in a)
            {
                if (maxV < i)
                    maxV = i;
            }

            //最大值长度
            int iMaxLength = maxV.ToString().Length;

            List<int> list = new List<int>();//存放每次排序后的元素
            List<int>[] listArr = new List<int>[10];//十个桶
            for (int i = 0; i < listArr.Length; i++) //给十个桶分配内存初始化。
                listArr[i] = new List<int>();

            for (int i = 0; i < iMaxLength; i++)//一共执行iMaxLength次，iMaxLength是元素的最大位数。
            {
                foreach (int num in a)
                {
                    int mod = (num % (int)(Math.Pow(10, i + 1)))/(int)Math.Pow(10,i);//通过mod的值，确定它压人哪个桶中。
                    listArr[mod].Add(num);
                }

                for (int j = 0; j < 10; j++)//将十个桶里的数据重新排列，压入list
                {
                    list.AddRange(listArr[j]);
                    listArr[j].Clear();//清空每个桶
                }

                a = list.ToArray<int>();//a指向重新排列的元素
                list.Clear();//清空list
            }

            array = a;
        }

    }
}
