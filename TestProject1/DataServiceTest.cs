using Tyuiu.MishaginaKS.Sprint1.Task0.V5.Lib;
namespace Tyuiu.MishaginaKS.Sprint1.Task0.V5.Test

{
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.Equal(12, res);
        }
    }
}
