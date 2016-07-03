using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifNewOverride
{
    class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
    }
    class DerivedClass : BaseClass
    {
        public void Method2()
        {
            Console.WriteLine("Dirived - Method2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            bc.Method1();
            dc.Method1();
            dc.Method2();
            bcdc.Method1();

            Console.Read();
        }
    }
}
