using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace STLab07.Variant11
{
    public interface ITreeReader
    {
        List<Connection> LoadTree(StreamReader reader);
    }
}
