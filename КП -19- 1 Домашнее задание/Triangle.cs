using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1_Домашнее_задание
{
    /// <summary>
    /// класс треугольник, наследуемый от интерфейса и базового класса
    /// </summary>
    class Triangle : Figure, IFigureInterface
    {
        /// <summary>
        /// свойство высоты
        /// </summary>
        public double H { get; set; }
        /// <summary>
        /// свойство стороны С
        /// </summary>
        public int C { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="h"></param>
        public Triangle(int a, int b, int c, double h) : base(a,b)
        {
            this.C = c;
            this.H = h;
        }
        /// <summary>
        /// Реализованный метод площадь
        /// </summary>
        public void Square()
        {
            Console.WriteLine($"Площадь: {(A * H)/2}");
        }
        /// <summary>
        /// Реализованный метод периметр
        /// </summary>
        public void Perimeter()
        {
            Console.WriteLine($"Периметр: {A+B+C}");
        }
        /// <summary>
        /// Статический метод для ввода информации о треугольнике 
        /// </summary>
        /// <returns></returns>
        static public Triangle Show()
        {
            Console.Write("Введите сторону A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту: ");
            double h = Convert.ToDouble(Console.ReadLine());
            return new Triangle(a, b,c,h);
        }
    }
}
