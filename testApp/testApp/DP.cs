using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class DP
    {
        /// <summary>
        /// 给定一个由整数组成的序列，从该数组中找出一个具有最大和的连续子数组(子数组最少包含一个元素),并返回其最大和。
        /// </summary>
        /// <param name="a">int array</param>
        /// <returns></returns>
        public int GetMaxValue_SubSeries(int[] a)
        {
            int i = 0;
            int cur_max_sum = a[0];
            int pre_max_sum = a[0];

            for (i = 1; i < a.Length; i++)
            {
                int currentValue = pre_max_sum + a[i];
                pre_max_sum = currentValue > a[i] ? currentValue : a[i];

                cur_max_sum = pre_max_sum > cur_max_sum ? pre_max_sum : cur_max_sum;
            }

            return cur_max_sum;
        }

        /// <summary>
        /// 如何买卖股票可以获得最大收益。一个数组标示买卖股票的时间和价格，其中第i个元素是一只给定的股票第i天的价格
        /// </summary>
        /// <param name="a">int[] a = {9,3,1,8,18,3,15,1}</param>
        /// <returns>最大利润</returns>
        public int Get_HighestProfit(int[] a)
        {
            int i = 0;
            int buy_point = a[0];
            //int pre_max_profit = a[1] - a[0];
            int cur_max_profit = a[1] - a[0];

            for (i = 1; i < a.Length; i++)
            {
                int tmp_profit = a[i] - buy_point;
                buy_point = buy_point > a[i] ? a[i] : buy_point;
                cur_max_profit = cur_max_profit >= tmp_profit ? cur_max_profit : tmp_profit;
            }

            return cur_max_profit;
        }
    }
}
