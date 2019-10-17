using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class LockTest
    {
        object o1 = new object();
        public void DeadLockTest(int i)
        {

            lock (this)   //或者lock一个静态object变量
            {
                if (i > 10)
                {
                    i--;
                    DeadLockTest(i);
                    Console.WriteLine(i);
                    //DeadLockTest(i);
                }
            }
        }
    }
}
