using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace STLab07.Variant11
{
    class OdtTreeFile : ITreeReader, ITreeWriter
    {
        public List<Connection> LoadTree(StreamReader reader)
        {
            List<Connection> res = new List<Connection>();
            string[] data = reader.ReadToEnd().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string d in data)
            {
                var c = d.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                res.Add(new Connection(Convert.ToInt32(c[0]), Convert.ToInt32(c[1]),
                    Convert.ToInt32(c[2]), Convert.ToInt32(c[3]), Convert.ToBoolean(c[4])));
            }

            reader.Close();

            return res;
        }

        public void SaveTree(StreamWriter writer, int[,] adjacencyMatrix)
        {
            string text = "";
            for (int i = 0; i < Math.Pow(adjacencyMatrix.Length, 0.5); i++)
            {
                string res = "";

                for (int j = 0; j < Math.Pow(adjacencyMatrix.Length, 0.5); j++)
                {
                    res += String.Format("  {0,2}  ", adjacencyMatrix[i, j]);
                }

                text += res + "\n";
            }
            writer.WriteLine(text);

            writer.Close();
        }
    }
}
