using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    //Case 3: Non-Child class from the same assembly
    class Three
    {
        static void Main(string[] args)
        {
            One.Test1(); One.Test4(); One.Test5();
            Console.ReadKey();
        }
    }
}
