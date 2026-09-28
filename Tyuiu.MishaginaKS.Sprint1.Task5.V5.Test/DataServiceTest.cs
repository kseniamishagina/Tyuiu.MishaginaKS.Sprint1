namespace Tyuiu.MishaginaKS.Sprint1.Task5.V5.Test;
    using Tyuiu.MishaginaKS.Sprint1.Task5.V5.Lib;

[TestClass]
public sealed class DataServiceTest

{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        double x = 32.597;

        int res = ds.Calculate(x);

        Assert.AreEqual(5, res);
    }
}

