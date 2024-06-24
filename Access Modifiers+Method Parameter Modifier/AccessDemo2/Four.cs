using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AccessDemo1;

namespace AccessDemo2
{
    //Case 4: Child class from the different assembly
    class Four : AccessDemo1.One
    {
        static void Main(string[] args)
        {
            Four.Test1(); Test3(); Test5();
            Console.ReadKey();
        }
    }
}
