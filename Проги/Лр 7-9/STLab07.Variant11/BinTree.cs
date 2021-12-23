using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace STLab07.Variant11
{
    public class BinTree
    {
        public ITreeReader Reader;
        public ITreeWriter Writer;

        public List<Connection> connections;
        public List<int> TraversePreordeList;
        public List<Unit> IncidenceMatrixList;
        public int[,] IncidenceMatrix; //Матрица инцедентности

        public BinTree(ITreeReader reader, ITreeWriter writer)
        {
            this.Reader = reader;
            this.Writer = writer;
            connections = new List<Connection>();
        }

        public void LoadFromFile(StreamReader reader)
        {
            //Получения списка связности
            connections = Reader.LoadTree(reader);
        }

        public void SaveToFile(StreamWriter writer)
        {
            ConvertIncidenceMatrixFromListToArray();

            Writer.SaveTree(writer, IncidenceMatrix);
        }

        public void ConvertConnectionListToIncidenceMatrixList()
        {
            foreach (Connection c in connections)
            {
                if (c.Root == true)
                {
                    IncidenceMatrixList = new List<Unit>();
                    TraversePreordeList = new List<int>();
                    ConvertToIncidenceMatrixList(c.Index);
                    break;
                }
            }
        }
        public void ConvertToIncidenceMatrixList(int index)
        {
            if (index != -1)
            {
                var ID = SearchOfIndexInList(index, connections);
                TraversePreordeList.Add(connections[ID].Index);

                if (connections[ID].LeftConn_Index != -1)
                {
                    IncidenceMatrixList.Add(new Unit(index, connections[ID].LeftConn_Index));
                }
                ConvertToIncidenceMatrixList(connections[ID].LeftConn_Index);

                if (connections[ID].RightConn_Index != -1)
                {
                    IncidenceMatrixList.Add(new Unit(index, connections[ID].RightConn_Index));
                }
                ConvertToIncidenceMatrixList(connections[ID].RightConn_Index);
            }
        }

        public int SearchOfIndexInList(int index, List<Connection> connections)
        {
            for (int i = 0; i <= connections.Count; i++)
            {
                if (connections[i].Index == index) return i;
            }
            return -1;
        }

        public void ConvertIncidenceMatrixFromListToArray()
        {
            ConvertConnectionListToIncidenceMatrixList();

            int[,] array = new int[connections.Count, connections.Count];

            for (int i = 0; i < IncidenceMatrixList.Count; i++)
            {
                array[IncidenceMatrixList[i].First - 1, i] = 1;
                array[IncidenceMatrixList[i].Second - 1, i] = 1;
            }

            foreach (Unit u in IncidenceMatrixList)
            {
                Console.WriteLine("First - {0,2} , Second - {1,2}", u.First, u.Second);
            }//*/

            IncidenceMatrix = array;
        }
    }

    public struct Unit
    {
        public int First;
        public int Second;

        public Unit(int first, int second)
        {
            First = first;
            Second = second;
        }
    }
}
