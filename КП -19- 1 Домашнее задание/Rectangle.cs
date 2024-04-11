using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1_Домашнее_задание
{
    /// <summary>
    /// прямоугольник 
    /// </summary>
    class Rectangle : Figure, IFigureInterface
    {
        public Rectangle(int a, int b) : base(a, b) { }
        public void Square()
        {
            Console.WriteLine($"Площадь: {A * B}");
        }
        public void Perimeter()
        {
            Console.WriteLine($"Периметр: {(A+B)*2}");
        }
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
