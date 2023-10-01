using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaleevTS.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.GaleevTS.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 2;
            int z = 3;
            var res = ds.Calc(x, y, z);
            Assert.AreEqual(50, res);
        }
    }
}
