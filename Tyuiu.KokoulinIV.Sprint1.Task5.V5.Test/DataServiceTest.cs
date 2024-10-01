using Tyuiu.KokoulinIV.Sprint1.Task5.V5.Lib;
namespace Tyuiu.KokoulinIV.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression ()
        {
            DataService ds = new DataService ();
            int b = 3;
            double x = 212.323;
            var res = ds.Calculate(x);
            Assert.AreEqual(b, res);
        }
    }
}