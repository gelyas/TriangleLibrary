//using Microsoft.VisualStudio.TestTools.UnitTesting;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleLibrary.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleType_sideA10_sideB10_sideB10returned()
        {
            //arange
            float sideA = 10;
            float sideB = 10;
            float sideC = 10;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            //act 
            TriangleType type = triangle.GetTriangleType();

            //assert
            Assert.AreEqual(TriangleType.Right, type);
        }
    }
}