using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo
{
    class three
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.test1();
            //p.test2();   Can't call it. It's private method.
            //p.test3();   Can't call it. It's protected method.
            p.test4();
            p.test5();
            Console.ReadKey();
        }
    }
}
