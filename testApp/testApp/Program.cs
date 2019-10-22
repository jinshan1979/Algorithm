using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Reflection;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace testApp
{
    class Program
    {
        private const string Version = "haier";
        static int[] a = {1,2,3,4,5,6,7,8 };

        //static int Calc() {
        //    int i = 0;
        //    try
        //    {
        //        return i;
        //    }
        //    finally
        //    {
        //        Console.WriteLine("finally");
        //        ++i;
        //    }
        //}
        static void Main(string[] args)
        {

            //Sort testing
            SortingClass sort = new SortingClass();
            int[] a = { 6, 7, 3, 5, 19,9,8, 3, 3, 6, 2 };
            //sort.CountingSort(a); //Counting sort test
            sort.RadixSort(a);// Radix sort test
            sort.print();


            ////Heap Testing
            //Heap h = new Heap();
            //int[] a = {6,7,3,5,9 };
            ////h.BuildHeap(a, a.Length-1);
            //h.HeapSort(a, a.Length - 1);

            //foreach (var i in h.H)
            //{
            //    Console.WriteLine(i+" ");
            //}




            ////Dynamics Programming testing
            //int[] a = {-1,2,-3,3,-1,9,1,-9,1 };
            //int[] stock = {9,3,1,8,18,3,15 };

            //DP dp = new DP();
            //Console.WriteLine(dp.GetMaxValue_SubSeries(a));
            //Console.WriteLine(dp.Get_HighestProfit(stock));

            //Console.WriteLine(Calc());

            ////one test question
            //int s0, s1, s2;
            //s0 = s1 = s2 = 0;

            //for (int i = 0; i < 8; i++)
            //{
            //    switch (i % 3)
            //    {
            //        case 0: s0 += ++Program.a[i]; break;
            //        case 1: s1 += ++Program.a[i]; break;
            //        case 2: s2 += ++Program.a[i]; break;

            //    }
            //}

            //Console.WriteLine(string.Format("{0},{1},{2}", s0, s1, s2));
            //Console.WriteLine(Program.a[7]);

            //AClass instance = new AClass();

            //instance.message2();
            //instance.message3();

            //AClass.message1();

            //Console.WriteLine(string.Format("name is {0}, age is {1}, location is {2}", instance.name, instance.age, instance.location));

            //People p = new People();
            //p.message1();
            //p.message2("This is a method");

            //Test the diff of two arrays
            //ArrayDiff diff = new ArrayDiff();
            //diff.showDiff(diff.getDiffList3());

            ////Test static class
            //Console.WriteLine(string.Format("m1 value is:{0}, m2 value is {1}", StaticClass.m1, StaticClass.m2));
            //StaticClass.Method1();

            ////Test static member
            //Console.WriteLine(string.Format("m1 value is:{0}, m2 value is {1}", StaticMember.m1, StaticMember.m2));
            //StaticMember instance1 = new StaticMember();
            //Console.WriteLine(string.Format("m3 value is {0}", instance1.m3));

            ////Test virtual function
            //Base1 b = new Base1();
            //b.printMethod();

            //Derived1 d = new Derived1();
            //d.printMethod();

            //Base1 b2 = new Derived1();
            //b2.printMethod();

            //Test float type
            //float d1 = 194268.02f;
            //float d2 = 194268f;
            //float d4 = 0.02f;
            //Console.WriteLine(String.Format("{0}-{1}={2},d4={3}",d1,d2,d1-d2,d4));
            //Console.WriteLine(d1);

            //int value =(int) Color.black;
            //string result = string.Empty;

            //switch(value) {
            //    case 1: 
            //        result = "1";
            //        break;
            //    case 2:
            //        result = "2";
            //        break;
            //    //case "4":
            //    //    result = "4";
            //    //    break;
            //    default:
            //        result = "No value is selected";
            //        break;
            //}

            //Console.WriteLine(result);

            ////Lock Test
            //LockTest t1 = new LockTest();
            //t1.DeadLockTest(20);


            //int a = 0;
            //System.Threading.Tasks.Parallel.For(0, 1000000, (i) =>
            //{

            //    //a++; //error
            //    System.Threading.Interlocked.Add(ref a, 1);
            //});
            //Console.Write(a);

            //StructTest s1;
            //s1.author = "LiBai";
            //s1.id = 12;
            //s1.tile = "111";
            //s1.subject = "Hard";

            //Console.WriteLine(s1);

            //HashSet<int> h = new HashSet<int>();
            //h.Add(3);
            //h.Add(3);

            //foreach (int i in h) {
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(Program.Version);  //test const member
            //Singleton1 ins = Singleton1.GetInstance();

            //ins.PrintMe();

            ////Testing Clone
            //CloneTest test1 = new CloneTest();
            //test1.IntValue = 1;
            //test1.StrValue = "str1";
            //test1.TestValue = new Test();
            //test1.TestValue.IntVal = 5;

            //Console.WriteLine("TestValue:{0},IntValue:{1},StrValue:{2}", test1.TestValue.IntVal, test1.IntValue, test1.StrValue);

            //CloneTest test2 = (CloneTest)test1.GetCopy();
            ////test1 = new CloneTest();
            //test1.TestValue.IntVal = 7;
            //Console.WriteLine("TestValue:{0},IntValue:{1},StrValue:{2}", test2.TestValue.IntVal, test2.IntValue, test2.StrValue);

            //CloneTest test3 = (CloneTest)test1.Clone();
            //test1.TestValue.IntVal = 8;
            //Console.WriteLine("TestValue:{0},IntValue:{1},StrValue:{2}", test3.TestValue.IntVal, test3.IntValue, test3.StrValue);

            ////Serialization Testing
            //Book book1 = new Book() { ID = 101, Name = "C# Design", Price = 89.2f };
            //DataContractSerializer formatter = new DataContractSerializer(typeof(Book));
            //using (MemoryStream stream = new MemoryStream()) {
            //    formatter.WriteObject(stream, book1);
            //    string result = System.Text.Encoding.UTF8.GetString(stream.ToArray());
            //    Console.WriteLine(result);
            //}

            //XmlSerializer formatter1 = new XmlSerializer(typeof(Book));

            //using (FileStream stream = new FileStream(@"C:\jinshan\algorithm\testApp\testApp\test.xml", FileMode.Truncate))
            //{
            //    formatter1.Serialize(stream, book1);
            //    //string result = System.Text.Encoding.UTF8.GetString(stream.ToArray());
            //    //Console.WriteLine(result);
            //}

            ////XmlSerializer formatter1 = new XmlSerializer(typeof(Book));
            //using (FileStream stream = new FileStream(@"C:\jinshan\algorithm\testApp\testApp\test.xml", FileMode.Open))
            //{
            //    Book book = formatter1.Deserialize(stream) as Book ;

            //    Console.WriteLine(book.ID);
            //    Console.WriteLine(book.Name);
            //    Console.WriteLine(book.Price);
            //}

            //Book book2 = new Book() { ID = 102, Name = "C# Design", Price = 89.2f };
            //BinaryFormatter formatter2 = new BinaryFormatter();
            //using (FileStream stream = new FileStream(@"C:\jinshan\algorithm\testApp\testApp\test.txt", FileMode.OpenOrCreate))
            //{
            //    formatter2.Serialize(stream, book2); 
            //}


            Console.ReadKey();
        }

    }

    enum Color { blue, yellow, white, black };

    public class AClass : ABClass
    {
        public string location;

        public AClass() {
            location = "Beijing";
        }
        override public void message3()
        {
            Console.WriteLine("This is an override method from parent abstract class");
        }
    }

    public abstract class ABClass {
        public string name;
        public int age;

        public ABClass() {
            name = "John";
            age = 24;
        }

        public static void message1() {
            Console.WriteLine("This is a static method in abstract class!");
        }

        public void message2() {
            Console.WriteLine("This is an implemented method in abstract class!");
        }

        public abstract void message3();

    }


    public class People : IPeople,IJob
    {
        public void JobBase()
        {
            throw new NotImplementedException();
        }

        public void JobName()
        {
            throw new NotImplementedException();
        }

        public void JobTitle()
        {
            throw new NotImplementedException();
        }

        public void message1()
        {
            Console.WriteLine("This is a method from interface!");
        }

        public void message2(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    public interface IPeople {

         void message1();
        void message2(string msg);

    }

    public interface IJob
    {
        void JobName();
        void JobTitle();
        void JobBase();
    }
}
