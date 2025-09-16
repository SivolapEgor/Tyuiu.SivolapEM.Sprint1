using Tyuiu.SivolapEM.Sprint1.Task6.V13.Lib;

namespace Tyuiu.SivolapEM.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresssion()
        {
            DataService ds = new DataService();
            string value = "abcd абвгд";
            bool res = ds.CheckWordsAlphabet(value);
            Assert.IsTrue(res);
        }
    }
}
