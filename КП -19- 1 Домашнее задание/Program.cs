using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1_Домашнее_задание
{
    interface IFigureInterface
    {
        /// <summary>
        /// нереализованный метод площадь
        /// </summary>
        void Square();
        /// <summary>
        /// нереализованный метод периметр 
        /// </summary>
        void Perimeter();
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            while (true)
            {
                Console.Write("Введите количество геометрических фигур: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Введите фигуру: ");
                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "Прямоугольник":
                            Rectangle rectangle = Rectangle.Show();
                            figures.Add(rectangle);
                            rectangle.Square();
                            rectangle.Perimeter();
                            break;
                        case "Треугольник":
                            Triangle triangle = Triangle.Show();
                            figures.Add(triangle);
                            triangle.Square();
                            triangle.Perimeter();
                            break;
                        case "Окружность":
                            Circle circle = Circle.Show();
                            circle.Square();
                            circle.Perimeter();
                            break;
                        default:
                            Console.WriteLine("Фигура введена некорректно");
                            break;
                    }

                    Console.ReadKey();
                }
            }
        }
    }
}
