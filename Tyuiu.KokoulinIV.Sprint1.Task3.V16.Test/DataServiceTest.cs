
using Tyuiu.KokoulinIV.Sprint1.Task3.V16.Lib;

namespace Tyuiu.KokoulinIV.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 5;
            double x2 = -6;
            var res = ds.CoeffOfQuadraticEquation(x1, x2);
            double xxx = 1;
            Assert.AreEqual(xxx, res);
        }
    }
}