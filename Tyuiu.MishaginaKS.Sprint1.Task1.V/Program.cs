namespace Tyuiu.MishaginaKS.Sprint1.Task1.V12;
    using Tyuiu.MishaginaKS.Sprint1.Task1.V12.Lib;

    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнила: Мишагина К. С. | АСОиУБ-26-1";

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #12                                                            *");
            Console.WriteLine("* Выполнила: Мишагина Ксения Сергеевна | АСОиУБ-26-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* вычисляет резльтат по формуле ( x+y )/6 и печатает результат на экране.*");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");


            Console.WriteLine(ds.Calculate(x, y));


            Console.ReadLine();
        }
    }

