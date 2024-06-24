using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    //Case 5: Non-Child class from the different assembly
    class Five
    {
        static void Main(string[] args)
        {
            AccessDemo1.One.Test1();
            Console.ReadKey();
        }
    }
}
