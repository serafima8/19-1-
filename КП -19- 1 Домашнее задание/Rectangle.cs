using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1_Домашнее_задание
{
    /// <summary>
    /// класс прямоугольник, наследуемый от интерфейса и базового класса
    /// </summary>
    class Rectangle : Figure, IFigureInterface
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Rectangle() { }
        /// <summary>
        /// Конструктор с параментрами 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Rectangle(int a, int b) : base(a, b) { }
        /// <summary>
        /// Реализованный метод площадь
        /// </summary>
        public void Square()
        {
            Console.WriteLine($"Площадь: {A * B}");
        }
        /// <summary>
        /// Реализованный метод периметр 
        /// </summary>
        public void Perimeter()
        {
            Console.WriteLine($"Периметр: {(A+B)*2}");
        }
        /// <summary>
        /// Статический метод для ввода информации о прямоугольнике 
        /// </summary>
        /// <returns></returns>
        static public Rectangle Show()
        {
            Console.Write("Введите сторону A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите сторону B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            return new Rectangle(a, b);
        }
    }
}
