using Tyuiu.SivolapEM.Sprint1.Task5.V2.Lib;

namespace Tyuiu.SivolapEM.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 50;
            int res = ds.FahrenheitToСelsius(f);
            Assert.AreEqual(10, res);
        }
    }
}
