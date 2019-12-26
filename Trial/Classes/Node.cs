using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    public class NodeItem
    {
        public bool IsEmpty { get; set; }
        public bool IsEvalReady { get; set; }
        public string ParamString { get; set; }
        public string ParamValue { get; set; }

        public NodeItem()
        {

        }

        public NodeItem(bool empty, bool ready, string str, string val)
        {
            IsEmpty = empty;
            IsEvalReady = ready;
            ParamString = str;
            ParamValue = val;
        }

        public bool CanBeEvaluted()
        {
            if (IsEmpty)
                return false;

            if (ParamString == "x" )
                return true;

            if (ParamString != "x" & decimal.TryParse(ParamString, out decimal val2))
                return true;

            return false;
        }

        public static NodeItem GetEmpty()
        {
            NodeItem nodeItem = new NodeItem();
            nodeItem.IsEmpty = true;
            return nodeItem;
        }

        public static NodeItem ReadString(string input)
        {
            NodeItem node = new NodeItem();

            if (string.IsNullOrEmpty(input))
                return GetEmpty();

            node.IsEmpty = false;

            node.IsEvalReady = int.TryParse(input, out int leftVal) | input == "x";

            node.ParamString = input;

            decimal val;
            if (node.IsEvalReady && decimal.TryParse(input, out val))
            {
                node.ParamValue = val.ToString();
            }
            else
            {
                node.ParamValue = "";
            }


            return node;
        }
    }   
}
