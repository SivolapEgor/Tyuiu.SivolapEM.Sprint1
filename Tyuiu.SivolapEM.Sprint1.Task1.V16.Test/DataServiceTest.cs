using Tyuiu.SivolapEM.Sprint1.Task1.V16.Lib;

namespace Tyuiu.SivolapEM.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            double a, x, y;
            a = 2;
            x = 2;
            y = 1;
            Assert.AreEqual(22, dataService.Calculate(a,x,y));
        }
    }
}
