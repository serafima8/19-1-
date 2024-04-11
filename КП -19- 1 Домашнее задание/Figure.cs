using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19__1_Домашнее_задание
{
    /// <summary>
    /// создание базового класса
    /// </summary>
    class Figure
    {
        /// <summary>
        /// Свойства стороны A
        /// </summary>
        public int A { get; set; }
        /// <summary>
        /// Свойства стороны В
        /// </summary>
        public int B { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Figure() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Figure(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
    }
}
