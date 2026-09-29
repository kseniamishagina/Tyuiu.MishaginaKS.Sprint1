namespace Tyuiu.MishaginaKS.Sprint1.Task6.V12.Test;
using Tyuiu.MishaginaKS.Sprint1.Task6.V12.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()

    {
        DataService ds = new DataService();

        string text1 = "мой код это отличный код.";
        bool res1 = ds.CheckLastWordRepetiton(text1);
        Assert.IsTrue(res1);

        string text2 = "сегодня идет интересный урок";
        bool res2 = ds.CheckLastWordRepetiton(text2);
        Assert.IsFalse(res2);
    }

}
