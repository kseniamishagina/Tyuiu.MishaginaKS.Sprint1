namespace Tyuiu.MishaginaKS.Sprint1.Task3.V10.Lib;
    using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task3V10
{
    public string NumberToMoney(double number)

    {
        number = Math.Round(number, 3);

        int rubles = (int)Math.Truncate(number);

        int kopecks = (int)Math.Round((number - rubles) * 100);

        return $"{rubles} руб. {kopecks} коп.";

    }
}

