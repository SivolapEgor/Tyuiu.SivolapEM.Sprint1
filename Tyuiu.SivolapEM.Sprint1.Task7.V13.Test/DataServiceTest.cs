using Tyuiu.SivolapEM.Sprint1.Task7.V13.Lib;

namespace Tyuiu.SivolapEM.Sprint1.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidException()
        {
            DataService ds = new DataService();
            double x, y;
            x = y = 0.4;
            Assert.AreEqual(0.764, ds.Calculate(x, y));
        }
    }
}
