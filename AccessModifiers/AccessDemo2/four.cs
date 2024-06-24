using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    class four : AccessDemo.Program
    {
        static void Main(string[] args)
        {
            four f = new four();
            f.test1();
            //f.test2();    Can't call it. It's private method.
            f.test3();
            //f.test4();    Can't call it. It's internal method.
            f.test5();
            Console.ReadKey();
        }
    }
}
