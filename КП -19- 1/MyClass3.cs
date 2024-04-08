using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1
{
    class MyClass3 : IMyInterfaceA, IMyInterfaceB
    {
        public void ShowA()
        {
            Console.WriteLine("MyClass3.ShowA is completed");
        }
        public void ShowB()
        {
            Console.WriteLine("MyClass3.ShowB is completed");
        }
    }
}
