using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int iValue = 123;
            string sValue = "456";
            DateTime dtValue = DateTime.Now;

            Console.WriteLine("***********CommonMethod***************");
            CommonMethod.ShowInt(iValue);
            CommonMethod.ShowString(sValue);
            CommonMethod.ShowDateTime(dtValue);
            Console.WriteLine("***********Object***************");
            CommonMethod.ShowObject(iValue);
            CommonMethod.ShowObject(sValue);
            CommonMethod.ShowObject(dtValue);
            Console.WriteLine("***********Generic***************");
            GenericMethod.Show<int>(iValue);
            GenericMethod.Show<string>(sValue);
            GenericMethod.Show<DateTime>(dtValue);

            Console.WriteLine(typeof(List<>));
            Console.WriteLine(typeof(Dictionary<,>));
            Console.ReadKey();
        }
    }
}
