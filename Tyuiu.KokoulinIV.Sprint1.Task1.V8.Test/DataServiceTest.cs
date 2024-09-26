
using Tyuiu.KokoulinIV.Sprint1.Task1.V8.Lib;

namespace Tyuiu.KokoulinIV.Sprint1.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var DataService = new DataService();
            double a = 1;
            double x = 2;
            var res = DataService.Calculate(a, x);
            Assert.AreEqual(6.28, res);
        }
    }
}