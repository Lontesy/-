using System;
using System.IO;

namespace STLab07.Variant11
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathinput = @"C:\Users\olegw\Desktop\LR7TestsOleg\Input.odt";
            StreamReader streamreader = new StreamReader(pathinput);

            string pathoutput = @"C:\Users\olegw\Desktop\LR7TestsOleg\Output.txt";
            StreamWriter streamwriter = new StreamWriter(pathoutput);

            TxtTreeFile reader = new TxtTreeFile();
            TxtTreeFile writer = new TxtTreeFile();


            BinTree Tree = new BinTree(reader, writer);

            Tree.LoadFromFile(streamreader);

            Tree.SaveToFile(streamwriter);
        }
    }
}
