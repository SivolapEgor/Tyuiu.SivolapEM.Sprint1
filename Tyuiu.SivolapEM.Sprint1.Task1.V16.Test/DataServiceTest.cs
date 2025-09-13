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
            double a, b, c;
            a = b = c = 2;
            Assert.AreEqual(24, dataService.Calculate(a,b,c));
        }
    }
}
