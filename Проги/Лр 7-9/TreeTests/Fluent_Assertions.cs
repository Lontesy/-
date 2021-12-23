using System;
using System.Collections.Generic;
using System.Text;
using STLab07.Variant11;
using NUnit.Framework;
using FluentAssertions;
using System.IO;

namespace TreeTests
{
    class Fluent_Assertions
    {
        [Test]
        public void Test1()
        {
            ReaderStub reader = new ReaderStub();
            WriterStub writer = new WriterStub();
            BinTree tree = new BinTree(reader, writer);
            tree.LoadFromFile(new StreamReader(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));
            tree.Should().NotBeNull();
        }
        [Test]
        public void Test2()
        {
            ReaderStub reader = new ReaderStub();
            WriterStub writer = new WriterStub();
            BinTree tree = new BinTree(reader, writer);
            tree.LoadFromFile(new StreamReader(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));
            var actual = tree.TraversePreordeList;
            actual.Should().HaveCount(8);
        }
        [Test]
        public void Test3()
        {
            ReaderStub reader = new ReaderStub();
            WriterStub writer = new WriterStub();
            BinTree tree = new BinTree(reader, writer);
            tree.LoadFromFile(new StreamReader(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));
            var actual = tree.TraversePreordeList;
            actual.Should().StartWith(4).And.EndWith(8);
        }
        [Test]
        public void Test4()
        {
            ReaderStub reader = new ReaderStub();
            WriterStub writer = new WriterStub();
            BinTree tree = new BinTree(reader, writer);
            tree.LoadFromFile(new StreamReader(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));
            var actual = tree.TraversePreordeList;
            actual.Should().OnlyHaveUniqueItems();
        }
        [Test]
        public void Test5()
        {
            ReaderStub reader = new ReaderStub();
            WriterStub writer = new WriterStub();
            BinTree tree = new BinTree(reader, writer);
            tree.LoadFromFile(new StreamReader(@"Example.txt"));
            tree.SaveToFile(new StreamWriter(@"Example.txt"));
            var actual = tree.TraversePreordeList;
            actual.Should().AllBeOfType<int>().And.ContainInOrder(new[] { 4, 2,5 });
        }
    }
}
