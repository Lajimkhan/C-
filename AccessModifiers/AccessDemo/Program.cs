using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo
{
        public class Program
    {
        public void test1()
        {
            Console.WriteLine("Public Method");
        }
        private void test2()
        {
            Console.WriteLine("Private Method");
        }
        protected void test3()
        {
            Console.WriteLine("Protected Method");
        }
        internal void test4()
        {
            Console.WriteLine("Internal Method");
        }
        protected internal void test5()
        {
            Console.WriteLine("Protected Internal Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.test1();
            p.test2();
            p.test3();
            p.test4();
            p.test5();
            Console.ReadKey();
        }
    }
}
