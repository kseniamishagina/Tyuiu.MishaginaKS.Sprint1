using Tyuiu.MishaginaKS.Sprint1.Task2.V3.Lib;
namespace Tyuiu.MishaginaKS.Sprint1.Task2.V3;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        int hours;

        Console.WriteLine("Введите количество часов (целое число):");
        hours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        int minutes = ds.ConvertHourToMin(hours);

        Console.WriteLine($"{hours} час(а/ов) в минутах = {minutes}");
        Console.ReadLine();



    }
}