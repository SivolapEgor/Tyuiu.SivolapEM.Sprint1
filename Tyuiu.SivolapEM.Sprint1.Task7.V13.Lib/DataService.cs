using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SivolapEM.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint1Task7V13
    {
        public double Calculate(double x, double y)
        {
            double y2 = Math.Pow(y, 2);
            double x2 = Math.Pow(x, 2);

            double cosx2 = Math.Cos(x2);
            double siny2 = Math.Sin(y2);

            double z = (y2 - cosx2 + 10) / (x2 - siny2 + 12);
            return Math.Round(z, 3);
        }
    }
}
