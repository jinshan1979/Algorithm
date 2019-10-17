using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    public sealed class Singleton
    {
        
        private static readonly Singleton instance = new Singleton();
        private Singleton() { }
        public static Singleton GetInstance() {
            return instance;
        }

        public void PrintMe() {
            Console.WriteLine("This is a singleton method!");
        }
    }

    public sealed class Singleton1
    {
        private static readonly Singleton1 instance = null;
        private Singleton1() { }
        static Singleton1() {
            instance = new Singleton1();
        }
        public static Singleton1 GetInstance() {
            return instance;
        }
        public void PrintMe()
        {
            Console.WriteLine("This is a singleton method!");
        }
    }

    public sealed class Singleton2
    {
        private static Singleton2 instance = null;
        private static readonly object myLock = new object();
        private Singleton2() { }
        public Singleton2 GetInstance() {
            if (instance == null) {      //第一次判断省去加锁的过程消耗 
                lock (myLock){//多线程中保证只有一个线程能够创建实例
                    if (instance == null){//加锁过程也是多线程，所以需要再次判断
                        instance = new Singleton2();
                    }
                }
            }
            return instance;
        }
        public void PrintMe()
        {
            Console.WriteLine("This is a singleton method!");
        }
    }
}
