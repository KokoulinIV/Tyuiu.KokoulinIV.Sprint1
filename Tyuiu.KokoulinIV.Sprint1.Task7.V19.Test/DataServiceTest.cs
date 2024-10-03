using Tyuiu.KokoulinIV.Sprint1.Task7.V0.Lib;
namespace Tyuiu.KokoulinIV.Sprint1.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = -6;
            double res = ds.Calculate(x);
            Assert.AreEqual(y,res);
        }
    }
}