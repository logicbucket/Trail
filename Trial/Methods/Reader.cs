﻿using System.Collections.Generic;
using System.Linq;

namespace Trial
{
    public class Reader
    {
        public Reader()
        {

        }

        public static List<EquationItem> ReadEquationString(string input, string variableValue)
        {
            List<EquationItem> result = new List<EquationItem>();
            List<EquationItem> unresolved = new List<EquationItem>();
            bool stop = false;

            EquationItem root = EquationItem.GetRoot(input, variableValue);

            if (root == null) return result;

            result.Add(root);

            if (root.LeftNode.CanBeEvaluted() && root.RightNode.CanBeEvaluted())
            {
                return result;
            }

            EquationItem.Resolve(result, unresolved, root, 0);
            while (stop == false)
            {
                EquationItem temp = unresolved
                                    .Where(x => x.IsReadyForEval() == false)
                                    .FirstOrDefault();
                if (temp != null)
                {
                    EquationItem.Resolve(result, unresolved, temp, 0);
                    unresolved.Remove(temp);
                }

                stop = unresolved.Count == 0 || unresolved.All(x => x.IsReadyForEval()); //is 2nd codition needed?
            }

            return result;
        }
    }


}
