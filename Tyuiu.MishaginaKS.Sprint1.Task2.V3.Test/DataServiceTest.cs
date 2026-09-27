namespace Tyuiu.MishaginaKS.Sprint1.Task2.V3.Test;
    using Tyuiu.MishaginaKS.Sprint1.Task2.V3.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()

        {
        DataService ds = new DataService();
        int hours = 2;
        var res = ds.ConvertHourToMin(hours);
        Assert.AreEqual(120, res);
        }
    }

