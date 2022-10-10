using ClassLibrary1;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Regex r = new Regex(@"(?<!\d)-?\d*[.,]?\d+");
        Match teg = r.Match(input);
        MatchCollection matchedAuthors = r.Matches(input);
        if (matchedAuthors.Count() == 3) //если заданы три числа, то расчитываем площадь треугольника
        {
            double sideA = double.Parse(matchedAuthors[0].Value);
            double sideB = double.Parse(matchedAuthors[1].Value);
            double sideC = double.Parse(matchedAuthors[2].Value);
            Figure figure1 = new Triangle(sideA, sideB, sideC);
            figure1.ShowInfo();
        }
        else if (matchedAuthors.Count() == 1) //если задано одно число, то расчитываем площадь круга
        {
            double radius = double.Parse(matchedAuthors[0].Value);
            Figure figure1 = new Сircle(radius);
            figure1.ShowInfo();
        }
        else //иначе фигура не определена
        {
            Console.WriteLine("Фигура не опознана");
        }
    }
}