using Tyuiu.SivolapEM.Sprint1.Task3.V2.Lib;

namespace Tyuiu.SivolapEM.Sprint1.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressoin()
        {
            DataService dataService = new DataService();
            double res = dataService.PurchaseAmount(30.99, 2, 9.99, 10);
            Assert.AreEqual(161.88, res);
        }
    }
}
