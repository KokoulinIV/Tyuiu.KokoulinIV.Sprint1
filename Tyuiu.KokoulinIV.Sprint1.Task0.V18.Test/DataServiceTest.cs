using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KokoulinIV.Sprint1.Task0.V18.Lib;

namespace Tyuiu.KokoulinIV.Sprint1.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
