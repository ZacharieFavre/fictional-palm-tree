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
        private char testOpr;
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
            testOpr = '+';
            testExpectedResult = 9;
            //when
            testActualResult = testCalculator.Ope(testOp1, testOp2, testOpr);
            //then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }
        [TestMethod]
        public void Test_Sous_Success()
        {
            //given
            testOp1 = 6;
            testOp2 = 3;
            testOpr = '-';
            testExpectedResult = 3;
            //when
            testActualResult = testCalculator.Ope(testOp1, testOp2, testOpr);
            //then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }
        [TestMethod]
        public void Test_Mult_Success()
        {
            //given
            testOp1 = 6;
            testOp2 = 3;
            testOpr = '*';
            testExpectedResult = 18;
            //when
            testActualResult = testCalculator.Ope(testOp1, testOp2, testOpr);
            //then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }
        [TestMethod]
        public void Test_Divi_Success()
        {
            //given
            testOp1 = 6;
            testOp2 = 0;
            testOpr = '/';
            testExpectedResult = 0;
            //when
            testActualResult = testCalculator.Ope(testOp1, testOp2, testOpr); 
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

