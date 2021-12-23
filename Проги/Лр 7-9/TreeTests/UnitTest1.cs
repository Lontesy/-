using NUnit.Framework;
using System.IO;
using System.Collections.Generic;
using STLab07.Variant11;

namespace TreeTests
{
    public class Tests
    {
        [Test]
        public void TreeReadTest()
        {
            ReaderStub reader = new ReaderStub();
            WriterStub writer = new WriterStub();

            BinTree tree = new BinTree(reader, writer);

            tree.LoadFromFile(new StreamReader(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));

            Assert.AreEqual(8, tree.connections.Count);
        }

        [Test]
        public void TreeWriteTest()
        {
            ReaderStub reader = new ReaderStub();
            WriterStub writer = new WriterStub();

            BinTree tree = new BinTree(reader, writer);

            tree.LoadFromFile(new StreamReader(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));

            Assert.AreEqual(3, writer.SaveWasInvoked);
        }

        [Test]
        public void IncidenceMatrixMethodsTest()
        {
            ReaderStub reader = new ReaderStub();
            WriterStub writer = new WriterStub();

            BinTree tree = new BinTree(reader, writer);
            tree.LoadFromFile(new StreamReader(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));

            Assert.IsNotNull(tree.IncidenceMatrix);
            Assert.IsNotNull(tree.IncidenceMatrixList);
        }

        [Test]
        public void TraversePreordeTest()
        {
            ReaderStub reader = new ReaderStub();
            WriterStub writer = new WriterStub();

            BinTree tree = new BinTree(reader, writer);
            tree.LoadFromFile(new StreamReader(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));

            Assert.AreEqual(new List<int>() { 4, 2, 1, 3, 5, 7, 6, 8 }, tree.TraversePreordeList);
        }
    }
}