using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint1.Task3.V5.Lib;

namespace Tyuiu.ShakirovRR.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double mapScale = 2;
            double distanceBetweenPoints = 3;
            double distanceBetweenCitys = 6;
            var res = ds.DistanceLength(mapScale, distanceBetweenPoints, distanceBetweenCitys);
            Assert.AreEqual(distanceBetweenCitys, res);
        }
    }
}
