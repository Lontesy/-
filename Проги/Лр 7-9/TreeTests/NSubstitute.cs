using System;
using System.Collections.Generic;
using System.Text;
using STLab07.Variant11;
using NUnit.Framework;
using NSubstitute;
using System.IO;

namespace TreeTests
{
    class NSubstitute
    {
        [Test]
        public void ReaderTest()
        {
            ITreeReader moсkreader = Substitute.For<ITreeReader>();
            ITreeWriter moсkwriter = Substitute.For<ITreeWriter>();

            moсkreader
                .LoadTree(Arg.Any<StreamReader>())
                .Returns(new List<Connection>() { new Connection(1, 2, -1, -1, true) });

            var reader = new StreamReader(@"Example1.txt");
            reader.Close();

            var Tree = new BinTree(moсkreader, moсkwriter);
            Tree.LoadFromFile(reader);
            List<Connection> res = Tree.connections;

            Assert.AreEqual(1, res[0].Value);
            Assert.AreEqual(2, res[0].Index);
            Assert.AreEqual(-1, res[0].LeftConn_Index);
            Assert.AreEqual(-1, res[0].RightConn_Index);
            Assert.AreEqual(true, res[0].Root);
        }

        [Test]
        public void ReaderErrorTest()
        {
            ITreeReader moсkreader = Substitute.For<ITreeReader>();
            ITreeWriter moсkwriter = Substitute.For<ITreeWriter>();

            moсkreader
                .LoadTree(Arg.Any<StreamReader>())
                .Returns((x) => { throw new ArgumentException("Empty file"); });

            var Tree = new BinTree(moсkreader, moсkwriter);

            var reader = new StreamReader(@"Example1.txt");
            reader.Close();

            Assert.Throws<ArgumentException>(() => Tree.LoadFromFile(reader));


        }

        [Test]
        public void ReaderArgErrorTest()
        {
            ITreeReader moсkreader = Substitute.For<ITreeReader>();
            ITreeWriter moсkwriter = Substitute.For<ITreeWriter>();

            moсkreader
                .LoadTree(Arg.Any<StreamReader>())
                .Returns(new List<Connection>() { new Connection(1, 2, 3, 4, true) });

            var reader = new StreamReader(@"Example1.txt");
            reader.Close();
            var writer = new StreamWriter(@"Example1.txt");
            writer.Close();

            var Tree = new BinTree(moсkreader, moсkwriter);
            Tree.LoadFromFile(reader);

            Assert.Throws<ArgumentOutOfRangeException>(() => Tree.SaveToFile(writer));
        }
    }
}
