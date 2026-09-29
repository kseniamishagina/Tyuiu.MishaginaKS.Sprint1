using Tyuiu.MishaginaKS.Sprint1.Task6.V12.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.MishaginaKS.Sprint1.Task6.V12;

class Program

{
    static void Main(string[] sender)

    {
        DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите строку текста: ");
            string text = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckLastWordRepetiton(text);

            if (result)

            {
                Console.WriteLine("Да, последнее слово входит в строку еще раз.");
            }

            else

            {

            Console.WriteLine("Нет, последнее слово встречается в строке только один раз.");

            }

            Console.ReadKey();

    }
}