using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo
{
    class two : Program
    {
        static void Main(string[] args)
        {
            two t = new two();
            t.test1();
            //t.test2(); can't call it. It's private method.
            t.test3();
            t.test4();
            t.test5();
            Console.ReadKey();
        }
    }
}
