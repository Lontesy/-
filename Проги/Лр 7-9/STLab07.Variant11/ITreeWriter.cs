using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace STLab07.Variant11
{
    public interface ITreeWriter
    {
        void SaveTree(StreamWriter writer, int[,] adjacencyMatrix);
    }
}
