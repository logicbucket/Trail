using System;
using System.Collections.Generic;
using System.Linq;

namespace Trial
{
    public class Evaluator
    {
        public static string Evaluate(List<EquationItem> equations)
        {
            //int levels = equations.Select(x => x.Level).Distinct().Count();
            var levels = equations.OrderByDescending(x => x.Level).Select(x => x.Level).Distinct().ToList();

            if (levels.Count() == 1)
             {
                return Solve(equations[0]);
            }
            else if (levels.Count() > 1)
            {
                string result = "";

                while (levels.Count() != 0)
                {
                    int currLevel = levels[0];

                    List<EquationItem> currentLevelEquationItems = equations.Where(x => x.Level == currLevel).ToList();

                    foreach (var equationItem in currentLevelEquationItems)
                    {
                        string solution = Solve(equationItem);

                        int parentId = equations.Where(x => x.Id == equationItem.Parent).Select(x =>x.Id).FirstOrDefault();

                        if (equationItem.IsFromParentRightNode)
                        {
                            equations.Where(x => x.Id == parentId).Select(x => x).First().RightNode.ParamString = solution;
                            equations.Where(x => x.Id == parentId).Select(x => x).First().RightNode.ParamValue = solution;
                        }
                        else
                        {
                            equations.Where(x => x.Id == parentId).Select(x => x).First().LeftNode.ParamString = solution;
                            equations.Where(x => x.Id == parentId).Select(x => x).First().LeftNode.ParamValue = solution;
                        }
                        result = solution;
                    }

                    levels.Remove(currLevel);
                }
                return result;
            }

            return "Can't calcualte this yet!"; //Dummy answer
        }

        private static string Solve(EquationItem equationItem)
        {
            Func<string, string, decimal> fn = Operator.GetFunction(equationItem.Operation);

            string left = equationItem.LeftNode.ParamString == "x"
                ? equationItem.VariableValue :
                  equationItem.LeftNode.ParamString;

            string right = equationItem.RightNode.ParamString == "x"
                ? equationItem.VariableValue :
                  equationItem.RightNode.ParamString;

            return fn(left, right).ToString();
        }
    }



}
