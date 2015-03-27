using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Library.MathsFunctions mathsLib = new Library.MathsFunctions();
            //
            int ExpectedResult = 57;

            int ReturnResult = mathsLib.Add(12, 45);

            Assert.AreEqual(ExpectedResult, ReturnResult);

        }
    }
}
