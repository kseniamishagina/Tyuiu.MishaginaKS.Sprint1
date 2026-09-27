namespace Tyuiu.MishaginaKS.Sprint1.Task3.V10;

using System.Globalization;

using Tyuiu.MishaginaKS.Sprint1.Task3.V10.Lib;

class Program

{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        Console.Write("Введите дробное число -> ");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string resultMoney = ds.NumberToMoney(number);

        Console.WriteLine($"{number:F3} руб. — это {resultMoney}");

        Console.ReadKey();
    }
}
