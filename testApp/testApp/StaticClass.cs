using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    static class StaticClass
    {
        internal static int m1=3;
        internal static string m2 ="Hello";

        static StaticClass()
        {
            m1 = 4;
            m2 = "Hello World";
        }
        internal static void Method1() {
            Console.WriteLine("This is a static method!");
        }

    }

    class StaticMember {

        internal static int m1 =4;
        internal static string m2 = "hello123";
        internal string m3 = "world";
    }

    class Base1
    {
        public virtual void printMethod()
        {
            Console.WriteLine("base1");
        }
    }

    class Derived1 : Base1
    {
        public override void printMethod()
        {
            Console.WriteLine("derived1");
        }
    }
}
