using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class MultiThreadingDemo
    {
        public void f()
        {
            ThreadStart T1 = new ThreadStart(f1);
            ThreadStart T2 = new ThreadStart(f2);
            Thread t1 = new Thread(T1);
            Thread t2 = new Thread(T2);
        }

        public void f1()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside f1{0}", i);

            }
        }

        public void f2()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside f2{0}", i, i);
            }
        }

        static void Main(string[] args)
        {

            MultiThreadingDemo demoThreading = new MultiThreadingDemo();
            demoThreading.f();
            //Console.ReadKey();
        }


    }
}
