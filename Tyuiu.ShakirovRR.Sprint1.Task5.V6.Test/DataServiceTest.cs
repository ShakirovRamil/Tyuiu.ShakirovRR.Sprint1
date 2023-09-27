using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint1.Task5.V6.Lib;

namespace Tyuiu.ShakirovRR.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 20;

            DataService ds = new DataService();
            double res = ds.Calculate(k);

            int result = Convert.ToInt32(res);

            int wait = 6;
                Assert.AreEqual(wait, result);
        }
    }
}
