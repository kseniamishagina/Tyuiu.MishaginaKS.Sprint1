namespace Tyuiu.MishaginaKS.Sprint1.Task5.V5.Lib;

using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task5V5 

{
    public int Calculate(double x)
    {
        int integralPart = (int)Math.Truncate(x * 10);
        return Math.Abs(integralPart % 10);
    }

}
