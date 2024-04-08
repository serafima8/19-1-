using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1
{
    /// <summary>
    /// Класс, в котором реализуется интерфейс 
    /// </summary>
    class MyClass : IMyInterface
    {
        /// <summary>
        /// MyClass.Show() реализован
        /// </summary>
        public void Show()
        {
            Console.WriteLine("MyClass.Show() реализован");
        }
    }
}
