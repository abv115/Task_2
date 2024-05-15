using Task_2;
namespace Task_2_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaOfTriangle_6_8_10_24returned()
        {
            //arrange
            double a = 6;
            double b = 8;
            double c = 10;
            double expected = 24;


            //act
            Triangle triangle = new Triangle();
            double actual = triangle.AreaOfTriangle(6, 8, 10);


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAreaOfCircle_10_314returned()
        {
            //arrange
            double r = 10;
            double expected = 314.1592653589793;


            //act
            Circle circle = new Circle();
            double actual=circle.AreaOfCircle(10);


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}