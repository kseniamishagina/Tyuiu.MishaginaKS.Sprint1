namespace Tyuiu.MishaginaKS.Sprint1.Task4.V14;

using System.Globalization;
using Tyuiu.MishaginaKS.Sprint1.Task4.V14.Lib;

class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        Console.Write("Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine().Replace('.', ','), CultureInfo.GetCultureInfo("ru-RU"));

        Console.Write("Введите значение Y: ");
        double y = Convert.ToDouble(Console.ReadLine().Replace('.', ','), CultureInfo.GetCultureInfo("ru-RU"));

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.Calculate(x, y);

        Console.WriteLine($"Результат выражения = {result.ToString("G", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

}
