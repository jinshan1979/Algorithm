using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class Heap
    {

        public int Count { get; set; }   //Count 为元素个数
        public int[] H { get; set; }    //H为Heap数组

        /// <summary>
        /// 当某个节点（H[i]）的值大于他的父亲节点的值时，
        /// 需要通过SITF-UP将这个节点 沿着从H[i]到H[1]这条唯一的路径上移到合适的位置以形成一个合格的堆
        /// </summary>
        /// <param name="H">堆</param>
        /// <param name="i">第i个元素</param>
        public void SiftUp(int[] H, int i)
        {
            while (true)
            {
                if (i == 0)
                    break;//说明当前i是根节点

                if (H[i] < H[(i-1) / 2]) //如果当前节点比父亲节点大
                {
                    int temp = H[i];
                    H[i] = H[(i - 1) / 2];
                    H[(i - 1) / 2] = H[i];

                    i = (i - 1) / 2;
                }
                else
                {
                    break;
                }
                
            }

            this.Count = H.Length;
            this.H = H;
        }

        /// <summary>
        /// 当某个节点（H[i]，n/2即 非叶子节点）的值小于它的两个子节点H[2i+1]和H[2i+2]（如果存在的话）的最大值时，
        /// 需要将SIFT-DOWN将渗到合适的位置
        /// </summary>
        /// <param name="H">堆</param>
        /// <param name="i">第i个元素</param>
        /// <param name="n">堆元素个数</param>
        public void SiftDown(int[] H, int i, int n)
        {
            while (true)
            {
                i = i * 2 + 1;
                if (i >= n)  //n为元素个数，数组base为0，若i=n，则越界
                {
                    break;
                }

                if ((i + 1) < n) //右子节点存在
                {
                    if (H[i] < H[i + 1]) //比较两个子节点哪个最大，取大者
                    {
                        i++;
                    }
                }

                if (H[i] > H[(i-1)/2])
                {
                    int temp = H[i];
                    H[i] = H[(i-1)/2];
                    H[(i-1)/2] = temp;
                }
            }

            //this.Count = n;
            //this.H = H;
        }


        /// <summary>
        /// 将元素x插入到已有的堆H中
        /// </summary>
        /// <param name="H"></param>
        /// <param name="x"></param>
        /// <param name="n"></param>
        public void Insert(int[] H, int x, int n)
        {
            n++;
            //这里默认H开的空间够用
            H[n] = x;
            SiftUp(H, n);//将x根据需要上移

            this.Count = n;
            this.H = H;
        }

        /// <summary>
        /// 将堆H中的元素x=H[i]删除
        /// </summary>
        /// <param name="H"></param>
        /// <param name="i"></param>
        /// <param name="n"></param>
        public void Delete(int[] H, int i, int n)
        {
            if (i == n-1)//如果需要删除的是最后一个元素
            {
                n--;
                return;
            }

            H[i] = H[n-1];
            n--;

            if (H[i] > H[(i-1)/2])//如果当前节点比父亲节点大则需要上移
            {
                SiftUp(H, i);
            }
            else
            {
                SiftDown(H, i, n);
            }

            this.Count = n;
            this.H = H;
        }

        /// <summary>
        /// 将堆H中的最大元素x删除
        /// </summary>
        /// <param name="H"></param>
        /// <param name="n"></param>
        public void DeleteMax(int[] H, int n)
        {
            Delete(H, 0, n);

            this.Count = n;
            this.H = H;
        }

        /// <summary>
        /// 给出一个有n个元素的数组H[0….n]，创建一个包含这些元素的堆。
        /// </summary>
        /// <param name="H"></param>
        /// <param name="n"></param>
        public void BuildHeap(int[] H, int n)
        {
            for (int i = (n - 1) / 2; i >= 0; i--)//从倒数第二层到第一层
            {
                SiftDown(H, i, n);
            }

            this.Count = n;
            this.H = H;
        }

        /// <summary>
        /// 利用堆对数组H[n]进行排序。
        /// </summary>
        /// <param name="H"></param>
        /// <param name="n"></param>
        public void HeapSort(int[] H, int n)
        {
            BuildHeap(H, n);

            int t;
            for (int i = n - 1; i > 0; i--)
            {
                t = H[0];
                H[0] = H[i];
                H[i] = t;

                SiftDown(H, 0, i);
            }

            this.Count = n;
            this.H = H;
        }
    }
}
