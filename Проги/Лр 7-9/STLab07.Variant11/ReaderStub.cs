using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace STLab07.Variant11
{
    public class ReaderStub : ITreeReader
    {
        public List<Connection> LoadTree(StreamReader reader)
        {
            reader.Close();
            return new List<Connection>()
            {
                new Connection(1,1,-1,-1,false),
                new Connection(2,2,1,3,false),
                new Connection(3,3,-1,-1,false),
                new Connection(4,4,2,5,true),
                new Connection(5,5,-1,7,false),
                new Connection(6,6,-1,-1,false),
                new Connection(7,7,6,8,false),
                new Connection(8,8,-1,-1,false)
            };
        }
    }
}
