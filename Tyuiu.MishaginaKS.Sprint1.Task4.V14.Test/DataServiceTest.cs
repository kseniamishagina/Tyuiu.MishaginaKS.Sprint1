namespace Tyuiu.MishaginaKS.Sprint1.Task4.V14.Test;

using Tyuiu.MishaginaKS.Sprint1.Task4.V14.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()

    {
        DataService ds = new DataService();
        double x = 2;
        double y = 2;

        double wait = ds.Calculate(x, y);

        Assert.AreEqual(0.110, wait);
    }
}

