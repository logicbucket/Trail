﻿using System.Collections.Generic;

namespace Trial
{
    public class EquationItem
    {
        public int Id { get; set; }
        public bool IsEmpty { get; set; }
        public int Level { get; set; }
        public int Parent { get; set; }
        public bool IsFromParentRightNode { get; set; }
        public NodeItem LeftNode { get; set; }
        public NodeItem RightNode { get; set; }
        public string VariableValue { get; set; }
        public string Operation { get; set; }


        public EquationItem()
        {

        }

        //public EquationItem(int id, bool empty, int level, int parent, NodeItem left, NodeItem right, decimal val, string op)
        //{
        //    Id = id;
        //    IsEmpty = empty;
        //    Parent = parent;
        //    Level = level;
        //    LeftNode = left;
        //    RightNode = right;
        //    //VariableValue = val;
        //    Operation = op;
        //}

        public bool IsReadyForEval()
        {

            if ((LeftNode != null && LeftNode.IsEvalReady) &&
                (RightNode !=null && RightNode.IsEvalReady))
                return true;
            return false;
        }

        public static EquationItem GetEmpty()
        {
            EquationItem equationItem = new EquationItem();
            equationItem.IsEmpty = true;
            return equationItem;
        }

        public static EquationItem GetRoot(string input, string variableValue)
        {
            EquationItem root =  GetItem(input, variableValue, 0, 0, 0);
            root.IsFromParentRightNode = false;
            return root;
        }

        public static EquationItem GetItem(string input, string variableValue, int parent, int level, int lastLevelId)
        {
            try
            {
                //Find First + sign
                int plusIndex = input.IndexOf('+');
                int minusIndex = input.IndexOf('-');
                int timesIndex = input.IndexOf('*');
                int cosineIndex = input.IndexOf("cos[");
                int sinIndex = input.IndexOf("sin[");

                //Resolve addition first
                if (plusIndex != -1)
                {
                    string[] arr = input.Split(new char[] { '+' }, 2);
                    if (arr.Length == 2)
                    {
                        EquationItem equationItem = new EquationItem();
                        equationItem.IsEmpty = false;
                        equationItem.Id = level * 10 + lastLevelId;
                        equationItem.Parent = parent;
                        equationItem.Level = level;
                        equationItem.Operation = "+";
                        equationItem.LeftNode = NodeItem.ReadString(arr[0]);
                        equationItem.RightNode = NodeItem.ReadString(arr[1]);
                        equationItem.VariableValue = variableValue;
                        return equationItem;
                    }
                }

                //Resolve subtraction
                if (minusIndex != -1)
                {
                    string[] arr = input.Split(new char[] { '-' }, 2);
                    if (arr.Length == 2)
                    {
                        EquationItem equationItem = new EquationItem();
                        equationItem.IsEmpty = false;
                        equationItem.Id = level * 10 + lastLevelId;
                        equationItem.Parent = parent;
                        equationItem.Level = level;
                        equationItem.Operation = "-";
                        equationItem.LeftNode = NodeItem.ReadString(arr[0]);
                        equationItem.RightNode = NodeItem.ReadString(arr[1]);
                        equationItem.VariableValue = variableValue;
                        return equationItem;
                    }
                }

                //Resolve multiplication
                if (timesIndex != -1)
                {
                    string[] arr = input.Split(new char[] { '*' }, 2);
                    if (arr.Length == 2)
                    {
                        EquationItem equationItem = new EquationItem();
                        equationItem.IsEmpty = false;
                        equationItem.Id = level * 10 + lastLevelId;
                        equationItem.Parent = parent;
                        equationItem.Level = level;
                        equationItem.Operation = "*";
                        equationItem.LeftNode = NodeItem.ReadString(arr[0]);
                        equationItem.RightNode = NodeItem.ReadString(arr[1]);
                        equationItem.VariableValue = variableValue;
                        return equationItem;
                    }
                }

                //Resolve Cosine
                if(cosineIndex != -1)
                {
                    string cosParam = input?.Substring(cosineIndex).Split('[', ']')[1];

                    EquationItem equationItem = new EquationItem();
                    equationItem.IsEmpty = false;
                    equationItem.Id = level * 10 + lastLevelId;
                    equationItem.Parent = parent;
                    equationItem.Level = level;
                    equationItem.Operation = "cos";
                    equationItem.LeftNode = NodeItem.ReadString(cosParam);
                    equationItem.RightNode = NodeItem.ReadString(cosParam);
                    equationItem.VariableValue = variableValue;
                    return equationItem;
                }

                //Resolve Sin
                if (sinIndex != -1)
                {
                    string sinParam = input?.Substring(sinIndex).Split('[', ']')[1];

                    EquationItem equationItem = new EquationItem();
                    equationItem.IsEmpty = false;
                    equationItem.Id = level * 10 + lastLevelId;
                    equationItem.Parent = parent;
                    equationItem.Level = level;
                    equationItem.Operation = "sin";
                    equationItem.LeftNode = NodeItem.ReadString(sinParam);
                    equationItem.RightNode = NodeItem.ReadString(sinParam);
                    equationItem.VariableValue = variableValue;
                    return equationItem;
                }

                return GetEmpty();

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public static void Resolve(List<EquationItem> accumlator, List<EquationItem> unresolved, EquationItem equationItem, int lastLevelId)
        {
            if (equationItem.LeftNode != null && equationItem.RightNode != null)
            {
                if (equationItem.LeftNode.IsEvalReady == false ||
                    equationItem.RightNode.IsEvalReady == false)
                {
                    if (equationItem.LeftNode.CanBeEvaluted() == false)
                    {
                        int leftId = lastLevelId + 1;
                        lastLevelId = leftId;

                        EquationItem leftEquationItem = GetItem(equationItem.LeftNode.ParamString,
                            equationItem.VariableValue,
                            equationItem.Id,
                            equationItem.Level + 1,
                           leftId);
                        leftEquationItem.IsFromParentRightNode = false;

                        if (leftEquationItem.IsReadyForEval())
                        {
                            accumlator.Add(leftEquationItem);
                        }
                        else
                        {
                            unresolved.Add(leftEquationItem);
                        }
                    }
                    else if(equationItem.Level != 0 ) //If not root, add to accumulator
                    {
                        accumlator.Add(equationItem);
                    }

                    if (equationItem.RightNode.CanBeEvaluted() == false)
                    {
                        int rightId = lastLevelId + 1;
                        lastLevelId = rightId;

                        EquationItem rightEquationItem = GetItem(equationItem.RightNode.ParamString,
                            equationItem.VariableValue,
                            equationItem.Id,
                            equationItem.Level + 1,
                           rightId);

                        rightEquationItem.IsFromParentRightNode = true;

                        if (rightEquationItem.IsReadyForEval())
                        {
                            accumlator.Add(rightEquationItem);
                        }
                        else
                        {
                            unresolved.Add(rightEquationItem);
                        }
                    }
                    else if (equationItem.Level != 0) //If not root, add to accumulator
                    {
                        accumlator.Add(equationItem);
                    }
                }
            }
        }
    }
}
