using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{

    class Test
    {
        public int IntVal { get; set; }

    }
    class CloneTest:ICloneable
    {
        public Test TestValue { get; set; }
        public int IntValue { get; set; }

        public string StrValue { get; set; }

        //public CloneTest(int i)
        //{
        //    this.TestValue.IntVal = i;
        //}

        public object GetCopy()
        {
            return this.MemberwiseClone();
        }

        public object Clone()
        {
            CloneTest test1 = (CloneTest)this.MemberwiseClone();

            Test t1 = new Test();
            t1.IntVal = this.TestValue.IntVal;
            test1.TestValue = t1;
            

            return test1;
        }
    }
}
