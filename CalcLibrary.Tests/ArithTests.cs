using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibrary.Tests
{
    [TestClass]
    public class ArithTests
    {
        [TestMethod]
        public void Add_AcceptsTwoIntegers_ReturnsSum()
        {
            //Arrage
            int Expected = 10;

            //Act
            IArith calc = new Arith();
            int ActualResult = calc.Add(5, 5);

            //Assert
            Assert.AreEqual(Expected, ActualResult);
        }
    }
}
