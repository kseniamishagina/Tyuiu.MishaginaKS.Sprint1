using Tyuiu.MishaginaKS.Sprint1.Task1.V12.Lib;
namespace Tyuiu.MishaginaKS.Sprint1.Task1.V12.Test
{
    public class UnitTest1
    {
        [Fact]
        public void ValidExpression()

        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.Equal(-1, res);
        }
    }
}