using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace STLab07.Variant11
{
    public class WriterStub : ITreeWriter
    {
        public int SaveWasInvoked;

        public void SaveTree(StreamWriter writer, int[,] adjacencyMatrix)
        {
            SaveWasInvoked++;
            writer.Close();
        }
    }
}
