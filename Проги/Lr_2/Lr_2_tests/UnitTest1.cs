using NUnit.Framework;

namespace Lb_2_tests
{
    public class Tests
    {
        [Test]
        public void CheckLeftTopAreaTest()
        {
            int X = -1;
            int Y = 1;
            int R = 10;
            int actually = ConsoleApp5.Point.CheckPoint(X, Y, R);
            int expect = 1;
            Assert.AreEqual(expect, actually);
        }
        [Test]
        public void CheckRightBotAreaTest()
        {
            int X = 1;
            int Y = -1;
            int R = 10;
            int actually = ConsoleApp5.Point.CheckPoint(X, Y, R);
            int expect = 2;
            Assert.AreEqual(expect, actually);
        }
        [Test]
        public void CheckOuterAreaTest()
        {
            int X = -3;
            int Y = 2;
            int R = 4;
            int actually = ConsoleApp5.Point.CheckPoint(X, Y, R);
            int expect = 3;
            Assert.AreEqual(expect, actually);
        }
        [Test]
        public void CheckCriticalPointLeftTopAreaTest()
        {
            int X = -5;
            int Y = 0;
            int R = 5;
            int actually = ConsoleApp5.Point.CheckPoint(X, Y, R);
            int expect = 1;
            Assert.AreEqual(expect, actually);
        }
        [Test]
        public void CheckCriticalPointLeftTopAreaTest2()
        {
            int X = 0;
            int Y = 5;
            int R = 5;
            int actually = ConsoleApp5.Point.CheckPoint(X, Y, R);
            int expect = 1;
            Assert.AreEqual(expect, actually);
        }
        [Test]
        public void CheckCriticalPointRightBotAreaTest()
        {
            int X = 5;
            int Y = 0;
            int R = 5;
            int actually = ConsoleApp5.Point.CheckPoint(X, Y, R);
            int expect = 2;
            Assert.AreEqual(expect, actually);
        }
        [Test]
        public void CheckCriticalPointRightBotAreaTest2()
        {
            int X = 0;
            int Y = -5;
            int R = 5;
            int actually = ConsoleApp5.Point.CheckPoint(X, Y, R);
            int expect = 2;
            Assert.AreEqual(expect, actually);
        }
    }
}
