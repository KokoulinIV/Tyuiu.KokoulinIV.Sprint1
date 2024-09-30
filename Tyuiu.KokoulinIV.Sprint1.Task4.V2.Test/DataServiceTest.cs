using Tyuiu.KokoulinIV.Sprint1.Task4.V2.Lib;
namespace Tyuiu.KokoulinIV.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 5;
            double wail = 0.25;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wail, res);
        }
    }
}