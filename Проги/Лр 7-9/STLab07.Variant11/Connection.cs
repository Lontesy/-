using System;
using System.Collections.Generic;
using System.Text;

namespace STLab07.Variant11
{
    public class Connection
    {
        public int Value;
        public int Index;
        public int LeftConn_Index;
        public int RightConn_Index;
        public bool Root;

        public Connection(int value, int index, int leftconn_index, int rightconn_index, bool root = false)
        {
            Value = value;
            Index = index;
            LeftConn_Index = leftconn_index;
            RightConn_Index = rightconn_index;
            Root = root;
        }
    }
}
