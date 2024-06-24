using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    //Case 1: Inside the same class
    public class One
    {
        public static void Test1()
        {
            Console.WriteLine("Public Method!");
        }
        private static void Test2()
        {
            Console.WriteLine("private Method!");
        }
        protected static void Test3()
        {
            Console.WriteLine("protected Method!");
        }
        internal static void Test4()
        {
            Console.WriteLine("internal Method!");
        }
        protected internal static void Test5()
        {
            Console.WriteLine("protected internal Method!");
        }
        static void Main(string[] args)
        {
            One.Test1(); Test2(); Test3(); Test4(); Test5();

            Console.ReadKey();
        }
    }
}
