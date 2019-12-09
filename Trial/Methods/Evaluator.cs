using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                    List<EquationItem> currLevelEquations = equations.Where(x => x.Level == currLevel).ToList();
                    //Solve curr 1 , add to its parent param value
                    foreach (var curr in currLevelEquations)
                    {
                        string soln = Solve(curr);
                        int parentId = equations.Where(x => x.Id == curr.Parent).Select(x =>x.Id).SingleOrDefault();
                        //problem identfying right 'nodedness'
                        bool rightNode = curr.IsFromParentRightNode;
                        if (rightNode)
                        {
                            equations.Where(x => x.Id == parentId).Select(x => x).First().RightNode.ParamString = soln;
                            equations.Where(x => x.Id == parentId).Select(x => x).First().RightNode.ParamValue = soln;
                        }
                        else
                        {                            
                            equations.Where(x => x.Id == parentId).Select(x => x).First().LeftNode.ParamString = soln;
                            equations.Where(x => x.Id == parentId).Select(x => x).First().LeftNode.ParamValue = soln;
                        }
                        result = soln;
                    }

                    levels.Remove(currLevel);                    
                }
                return result;
            }
            
            return "Can't calcualte this yet!"; //Dummy answer
        }

        private static string Solve(EquationItem equation)
        {
            Func<string, string, decimal> fn = Operator.GetFunction(equation.Operation);

            string left = equation.LeftNode.ParamString == "x"
                ? equation.VariableValue :
                  equation.LeftNode.ParamString;

            string right = equation.RightNode.ParamString == "x"
                ? equation.VariableValue :
                  equation.RightNode.ParamString;

            return fn(left, right).ToString();
        }
    }

  

}
