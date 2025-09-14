using Tyuiu.SivolapEM.Sprint1.Task4.V19.Lib;

namespace Tyuiu.SivolapEM.Sprint1.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;

            Assert.AreEqual(3, ds.Calculate(x,y));
        }
    }
}
