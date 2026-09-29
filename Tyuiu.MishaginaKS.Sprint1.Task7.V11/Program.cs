using Tyuiu.MishaginaKS.Sprint1.Task7.V11.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.MishaginaKS.Sprint1.Task7.V11;
using System.Globalization;

class Program

{
    static void Main(string[] sender)

    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine().Replace('.', ','), CultureInfo.GetCultureInfo("ru-RU"));

        Console.Write("Введите значение Y: ");
        double y = Convert.ToDouble(Console.ReadLine().Replace('.', ','), CultureInfo.GetCultureInfo("ru-RU"));

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.Calculate(x, y);

        Console.WriteLine($"Значение Z = {result.ToString("G", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }
}

