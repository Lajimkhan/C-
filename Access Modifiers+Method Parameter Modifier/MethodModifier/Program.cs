using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodModifier
{
    class Program
    {
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a =5, b=10 ;

            //Console.WriteLine("Before: a = {0} and b = {1}",a,b);
            Swap(ref a, ref b);
            Console.WriteLine("After: a = {0} and b = {1}", a, b);
            Console.ReadKey();
        }
    }
}
