using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KulmametovZR.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KulmametovZR.Sprint0.TaskReview.V0.Test
    {
        [TestClass]


        public class DataServiceTest
        {
            [TestMethod]

            public void CheckCalc()
            { 
          
            
                int x = 2;
                int y = 3;
                int z = 4;
                int expectedResult = (x + y + z) * 5;

            
                DataService dataService = new DataService();

            
                int actualResult = dataService.Calc(x, y, z);

            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

