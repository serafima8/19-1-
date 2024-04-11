using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1_Домашнее_задание
{
    /// <summary>
    /// треугольник
    /// </summary>
    class Triangle : Figure, IFigureInterface
    {
        public double H { get; set; }
        public int C { get; set; }
        public Triangle(int a, int b, int c, double h) : base(a,b)
        {
            this.C = c;
            this.H = h;
        }
        public void Square()
        {
            Console.WriteLine($"Площадь: {(A * H)/2}");
        }
        public void Perimeter()
        {
            Console.WriteLine($"Периметр: {A+B+C}");
        }
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
