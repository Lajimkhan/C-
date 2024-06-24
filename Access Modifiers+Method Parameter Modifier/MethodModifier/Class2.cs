using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodModifier
{
    class Class2
    {
        public static void SimpleMethod(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(", ");
            }
        }
        static void Main(string[] args)
        {
            int[] x = new int[4] { 10, 12, 15, 17 };
            int a = 20, b = 1988;
            SimpleMethod(x);
            SimpleMethod(a, b);
            Console.ReadKey();
        }
    }
}
