using NUnit.Framework;

namespace Tests
{
    class UnitTest2
    {
        static object[] PointsOutArea = {
            new object[] { -3, 2, 4 },
            new object[] { 10, 2, 3 },
            new object[] { 1, -10, 6 }
        };

        static object[] CriticalPointsLeftTopArea = {
            new object[] { -5, 0, 5 },
            new object[] { 0, 5, 5 }
        };

        static object[] CrticalPointsRightBotArea = {
            new object[] { 5, 0, 5 },
            new object[] { 0, -5, 5 }
        };

        [TestCase(-1, 1, 10)]
        [TestCase(-2, 2, 10)]
        [TestCase(-5, 5, 20)]
        public void CheckLeftTopAreaTest(int x, int y, int r)
        {
            int actually = ConsoleApp5.Point.CheckPoint(x, y, r);
            int expect = 1;
            Assert.AreEqual(expect, actually);
        }

        [TestCase(1, -1 , 10)]
        [TestCase(2, -2, 10)]
        [TestCase(5, -5, 20)]
        public void CheckRightBotAreaTest(int x, int y, int r)
        {
            int actually = ConsoleApp5.Point.CheckPoint(x, y, r);
            int expect = 2;
            Assert.AreEqual(expect, actually);
        }

        [TestCaseSource("PointsOutArea")]
        public void CheckOuterAreaTest(int x, int y, int r)
        {
            int actually = ConsoleApp5.Point.CheckPoint(x, y, r);
            int expect = 3;
            Assert.AreEqual(expect, actually);
        }


        [TestCaseSource("CriticalPointsLeftTopArea")]
        public void CheckCriticalPointLeftTopAreaTest(int x, int y, int r)
        {
            int actually = ConsoleApp5.Point.CheckPoint(x, y, r);
            int expect = 1;
            Assert.AreEqual(expect, actually);
        }

        [TestCaseSource("CrticalPointsRightBotArea")]
        public void CheckCriticalPointRightBotAreaTest(int x, int y, int r)
        {
            int actually = ConsoleApp5.Point.CheckPoint(x, y, r);
            int expect = 2;
            Assert.AreEqual(expect, actually);
        }
    }
}
