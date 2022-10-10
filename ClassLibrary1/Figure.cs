using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Figure
    {
        public abstract string Area();
        public abstract string Title();
        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {Title()}\n" +
                $"Площадь: {Area()}"
                );
            Console.WriteLine();
        }
    }
}
