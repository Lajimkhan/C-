using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodModifier
{
    class Class1
    {
        public static void Calculation(int num1, int num2, out int total1, out int product1)
        {
             total1 = num1 + num2;
             product1 = num1 * num2;
        }
        static void Main(string[] args)
        {
            int total=10, product=5;
            int a = 10, b = 20;
            Calculation(a, b, out total, out product);

            Console.WriteLine("Addition: "+total);
            Console.WriteLine("Multiplication: " + product);

            Console.ReadKey();
        }

    }
}
