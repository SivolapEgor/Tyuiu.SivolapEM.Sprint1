using Tyuiu.SivolapEM.Sprint1.Task2.V10.Lib;

namespace Tyuiu.SivolapEM.Sprint1.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 10;
            double res = ds.ConvertMetreToInchs(value);
            Assert.AreEqual(393.701, res);
        }
    }
}
