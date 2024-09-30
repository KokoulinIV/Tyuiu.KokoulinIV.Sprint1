
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KokoulinIV.Sprint1.Task4.V2.Lib
{
    public class DataService : ISprint1Task4V2
    {
        public double Calculate(double x, double y)
        {
            double z = x + 2 * y;
            var res = 1 / (Math.Pow(z, 0.5));
            return res;
        }
    }
}
