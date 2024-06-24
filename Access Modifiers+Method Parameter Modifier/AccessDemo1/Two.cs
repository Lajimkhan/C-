using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    //Case 2: Child class from the same assembly
    class Two:One
    {
        static void Main(string[] args)
        {
            Two.Test1(); Test3(); Test4(); Test5();
            Console.ReadKey();
        }
    }
}
