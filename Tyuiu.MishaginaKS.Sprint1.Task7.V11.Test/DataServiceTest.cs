namespace Tyuiu.MishaginaKS.Sprint1.Task7.V11.Test;
using Tyuiu.MishaginaKS.Sprint1.Task7.V11.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
    public class DataServiceTest 

    {
        [TestMethod]
        public void ValidExpression()
    {
        DataService ds = new DataService();
        double x = 0.5;
        double y = 1.5;

        double res = ds.Calculate(x, y);
        Assert.IsNotNull(res);

    }

    }

