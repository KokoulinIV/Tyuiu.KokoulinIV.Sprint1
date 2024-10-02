using Tyuiu.KokoulinIV.Sprint1.Task6.V3.Lib;
namespace Tyuiu.KokoulinIV.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "a";
            string b = "rea";
            string res = ds.LastLetterWord(b);
            Assert.AreEqual(a, res);

        }
    }
}