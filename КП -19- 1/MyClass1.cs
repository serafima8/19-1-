using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1
{
    abstract class MyClass1 : IMyInterface1
    {
        public void Show1()
        {
            Console.WriteLine("MyClass.Show1() реализован");
        }
        public abstract void Show2();
    }
}
