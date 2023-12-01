using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLibrary.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetTriangleTypeTest()
        {
            //arange
            float sideA = 3;
            float sideB = 4;
            float sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            //act 
            TriangleType type = triangle.GetTriangleType();

            //assert
            Assert.AreEqual(TriangleType.Acute, type);
        }
    }
}