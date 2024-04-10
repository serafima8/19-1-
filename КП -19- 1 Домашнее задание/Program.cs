using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1_Домашнее_задание
{
    interface FigureInterface
    {
        void Square();
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
                            Rectangle rectangle = new Rectangle(a,b);
                            Rectangle.ToString();
                            rectangle.Square();
                            rectangle.Perimeter();
                            break;
                        case "Треугольник":
                            commoditys.Add(Consignment.Show());
                            break;
                        case "Окружность":
                            commoditys.Add(Set.Show());
                            break;
                        default:
                            Console.WriteLine("Товар введен некорректно");
                            break;
                    }

                    //foreach (var elem in commoditys)
                    //{
                    //    elem.Print();
                    //    //  Console.WriteLine("Просроченные продукты: ");
                    //    //  elem.DeadLineExpirationDate();
                    //}

                    Console.ReadKey();
                }
            }
        }
    }
}
