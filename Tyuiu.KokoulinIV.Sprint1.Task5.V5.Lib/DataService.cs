
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KokoulinIV.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            
            int b = (int)(Math.Floor((x- Math.Floor(x)) *10));
            return b;

        }
    }
}
