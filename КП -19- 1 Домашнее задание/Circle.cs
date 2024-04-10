using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1_Домашнее_задание
{
    /// <summary>
    /// окружность 
    /// </summary>
    class Circle : FigureInterface
    {
        public double R { get; set; }
        public Circle(double r)
        {
            this.R = r;
        }
        public void Square()
        {
            Console.WriteLine($"Площадь: {Math.PI*Math.Pow(R,2)}");
        }
        public void Perimeter()
        {
            Console.WriteLine($"Периметр: {2*Math.PI*R}");
        }

        static public Circle ToString()
        {
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
         
            return new Circle(r);
        }
    }
}
