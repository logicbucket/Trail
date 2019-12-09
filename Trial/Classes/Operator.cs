using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    public static class Operator
    {
        public static  bool ArithmeticOpsOnly(string input)
        {
            foreach (var op in NonArithmeticOperations().Keys.ToList())
            {
                if (input.Contains(op)) return false;
            }
            return true;
        }

        public static Dictionary<string, string> Operations()
        {
            Dictionary<string, string> ops = new Dictionary<string, string>();
            foreach (var item in ArithmeticOperations())
            {
                ops.Add(item.Key, item.Value);
            }
            foreach (var item in NonArithmeticOperations())
            {
                ops.Add(item.Key, item.Value);
            }
            return ops;
        }

        public static Dictionary<string, string> NonArithmeticOperations()
        {
            Dictionary<string, string> ops = new Dictionary<string, string>();
            ops.Add("^", "Power");
            ops.Add("sin", "Sin");
            ops.Add("cos", "Cosine");
            return ops;
        }

        public static Dictionary<string, string> ArithmeticOperations()
        {
            Dictionary<string, string> ops = new Dictionary<string, string>();
            ops.Add("+", "Add");
            ops.Add("-", "Subtract");
            ops.Add("*", "Multiply");
            return ops;
        }
        
        #region  Functions

        public static Func<string, string, decimal> GetFunction(string opSymbol)
        {
            
            if( OpToFunctionMapper().TryGetValue(opSymbol, out Func<string, string, decimal> fn))
            {
                return fn;
            }
            return null;
        }

        public static Dictionary<string, Func<string, string, decimal>> OpToFunctionMapper()
        {
            Dictionary<string, Func<string, string, decimal>> ops =
                new Dictionary<string, Func<string, string, decimal>>();
            ops.Add("+", Add);
            ops.Add("-", Subtract);
            ops.Add("*", Multiply);
            ops.Add("sin", Sin);
            ops.Add("cos", Cosine);
            return ops;
        }

        private static decimal Add(string left, string right)
        {
            bool leftOk = decimal.TryParse(left, out decimal l);
            bool rightOk = decimal.TryParse(right, out decimal r);

            if (leftOk & rightOk)
                return l + r;
            else if (leftOk & !rightOk)
                return l;
            else if (!leftOk & rightOk)
                return r;
            else
                return 0m;
        }

        private static decimal Subtract(string left, string right)
        {
            bool leftOk = decimal.TryParse(left, out decimal l);
            bool rightOk = decimal.TryParse(right, out decimal r);

            if (leftOk & rightOk)
                return l - r;
            else if (leftOk & !rightOk)
                return l;
            else if (!leftOk & rightOk)
                return (-1.0m * r);
            else
                return 0m;
        }

        private static decimal Multiply(string left, string right)
        {
            bool leftOk = decimal.TryParse(left, out decimal l);
            bool rightOk = decimal.TryParse(right, out decimal r);

            if (leftOk & rightOk)
                return l * r;
            else if (leftOk & !rightOk)
                return l;
            else if (!leftOk & rightOk)
                return r;
            else
                return 0m;
        }

        private static decimal Sin(string left, string right)
        {
            bool leftOk = double.TryParse(left, out double val);

            if (leftOk)
                return Convert.ToDecimal(Math.Sin(val));
            else
                return 0m;
        }

        private static decimal Cosine(string left, string right)
        {
            bool leftOk = double.TryParse(left, out double val);

            if (leftOk)
                return Convert.ToDecimal(Math.Cos(val));
            else
                return 0m;
        }

        #endregion Functions
    }
}
