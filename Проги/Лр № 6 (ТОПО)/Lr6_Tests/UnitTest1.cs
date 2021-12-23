using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lr6_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckPrintElements()
        {
            кП___6__рнон_.NodeStack<int> stack = new кП___6__рнон_.NodeStack<int>();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            string expect = "8 7 6 5 ";
            Assert.AreEqual(expect, stack.PrintElements());
        }
        [TestMethod]
        public void CheckGetFirstElements()
        {
            кП___6__рнон_.NodeStack<int> stack = new кП___6__рнон_.NodeStack<int>();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            int expect = 8;
            Assert.AreEqual(expect, stack.Peek());
        }
        [TestMethod]
        public void CheckIsEmpty()
        {
            кП___6__рнон_.NodeStack<int> stack = new кП___6__рнон_.NodeStack<int>();
            bool expect = true;
            Assert.AreEqual(expect, stack.IsEmpty);
        }
        [TestMethod]
        public void CheckPop()
        {
            кП___6__рнон_.NodeStack<int> stack = new кП___6__рнон_.NodeStack<int>();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Pop();
            string expect = "7 6 5 ";
            Assert.AreEqual(expect, stack.PrintElements());
        }
        [TestMethod]
        public void CheckCount()
        {
            кП___6__рнон_.NodeStack<int> stack = new кП___6__рнон_.NodeStack<int>();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            int expect = 4;
            Assert.AreEqual(expect, stack.Count);
        }
    }
}
