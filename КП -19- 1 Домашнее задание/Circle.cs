using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1_Домашнее_задание
{
    /// <summary>
    /// класс окружность, наследуемый от интерфейса  
    /// </summary>
    class Circle : IFigureInterface
    {
        /// <summary>
        /// Свойства радиус
        /// </summary>
        public double R { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Circle() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="r"></param>
        public Circle(double r)
        {
            this.R = r;
        }
        /// <summary>
        /// Реализованный метод площадь 
        /// </summary>
        public void Square()
        {
            Console.WriteLine($"Площадь: {Math.PI*Math.Pow(R,2)}");
        }
        /// <summary>
        /// Реализованный метод периметр 
        /// </summary>
        public void Perimeter()
        {
            Console.WriteLine($"Периметр: {2*Math.PI*R}");
        }
        /// <summary>
        /// Статический метод для ввода информации об окружности 
        /// </summary>
        /// <returns></returns>
        static public Circle Show()
        {
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            return new Circle(r);
        }
    }
}
