using Tyuiu.MishaginaKS.Sprint1.Task5.V5.Lib;
namespace Tyuiu.MishaginaKS.Sprint1.Task5.V5;
using System.Globalization;

class Program

{
    static void Main(string[] sender)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите положительное вещественное число X: ");
        double x = Convert.ToDouble(Console.ReadLine().Replace('.', ','), CultureInfo.GetCultureInfo("ru-RU"));

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int d = ds.Calculate(x);
        Console.WriteLine($"Первая цифра дробной части (d) = {d}");

        Console.ReadKey();
    }
}