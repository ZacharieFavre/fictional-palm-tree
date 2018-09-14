using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Maths
{
    [TestClass]
    public class TestCalculator
    {
        #region private attributes
        private int testOp1;
        private int testOp2;
        private int testExpectedResult;
        private int testActualResult;
        private Calculator testCalculator = null;
        #endregion private attributes
        [TestInitialize]
        public void Init()
        {
            testCalculator = new Calculator();
            testActualResult=0;
        }
        [TestMethod]
        public void Test_Add_Success()
        {
            //given
            testOp1 = 6;
            testOp2 = 3;
            testExpectedResult = 9;
            //when
            testActualResult = testCalculator.add(testOp1, testOp2);
            //then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }
        [TestMethod]
        public void Test_Sous_Success()
        {
            //given
            testOp1 = 6;
            testOp2 = 3;
            testExpectedResult = 3;
            //when
            testActualResult = testCalculator.sub(testOp1, testOp2);
            //then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }
        [TestMethod]
        public void Test_Mult_Success()
        {
            //given
            testOp1 = 6;
            testOp2 = 3;
            testExpectedResult = 18;
            //when
            testActualResult = testCalculator.mul(testOp1, testOp2);
            //then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }
        [TestMethod]
        public void Test_Divi_Success()
        {
            //given
            testOp1 = 6;
            testOp2 = 0;
            testExpectedResult = 0;
            //when
            testActualResult = testCalculator.div(testOp1, testOp2);
            //then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }
        [TestCleanup]
        public void Cleanup()
        {
            testActualResult = 0;
        }
    }
}

