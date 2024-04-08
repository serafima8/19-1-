using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1
{
    class ChildClass : MyClass1
    {
        public override void Show2()
        {
            Console.WriteLine("Производный класс завершает Show2()");
        }
    }
}
