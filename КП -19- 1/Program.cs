using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1
{
    /// <summary>
    /// интерфейс 
    /// </summary>
    interface IMyInterface
    {
        /// <summary>
        /// нереализованный метод вывода информации об объекте
        /// </summary>
        void Show();
    }
    interface IMyInterface1
    {
        void Show1();
        void Show2();
    }
    interface IMyInterfaceA
    {
        void ShowA();
    }
    interface IMyInterfaceB
    {
        void ShowB();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Изучение интерфейсов пример 1");
            MyClass myClass = new MyClass();
            myClass.Show();
            Console.WriteLine("Изучение интерфейсов пример 2");
            MyClass1 myClass1 = new ChildClass();
            myClass1.Show1();
            myClass1.Show2();
            Console.WriteLine("Изучение интерфейсов пример 3");
            MyClass3 myClass3 = new MyClass3();
            myClass3.ShowA();
            myClass3.ShowB();
            Console.ReadKey();
        }
    }
}
