using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lr_5_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            string number = "513";
            int fromNotation = 16;
            int toNotation = 12;
            string actually = Ëð___5__.Notation.Convertation(number, fromNotation, toNotation);
            string expect = "903";
            Assert.AreEqual(expect, actually);
        }
        [TestMethod]
        public void Test2()
        {
            string number = "26";
            int fromNotation = 16;
            int toNotation = 12;
            string actually = Ëð___5__.Notation.Convertation(number, fromNotation, toNotation);
            string expect = "32";
            Assert.AreEqual(expect, actually);
        }
    }
}
