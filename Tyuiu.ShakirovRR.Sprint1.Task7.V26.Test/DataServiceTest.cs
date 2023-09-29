using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint1.Task7.V26.Lib;

namespace Tyuiu.ShakirovRR.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double wait = 0.832;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
