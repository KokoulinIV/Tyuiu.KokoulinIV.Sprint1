
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KokoulinIV.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int x1= Convert.ToInt32(x);
            double x2 = Convert.ToDouble(x1);
            double z = x - x2;
            double y = Math.Abs(z) * 10;
            int b = Convert.ToInt32(y);
            return b;

        }
    }
}
