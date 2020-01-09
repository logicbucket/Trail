using System.Collections.Generic;
using System.Text;

namespace Trial
{
    public class Validator
    {
        public static string ValidateEquation(string equationText)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(equationText))
            {
                sb.AppendLine("Error : Equation is Empty");
                return sb.ToString();
            }

            if(equationText.Length > 40)
            {
                sb.AppendLine("Error : Equation Length exceded.");
            }

            if (HasInValidCharacters(equationText))
            {
                sb.AppendLine("Error : Input has Invalid Characters.");
            }

            List<string> symbolErrors = InvalidSymbol(equationText);
            if (symbolErrors.Count > 0)
            {
                sb.AppendLine($"Error : Contains Invalid Symbol Combinations : {symbolErrors[0]}");
            }

            return sb.ToString();
        }
        public static string ValidateVariableValue(string variableValue)
        {
            if (string.IsNullOrEmpty(variableValue))
            {
                return "Error : Value of x is required";
            }

            decimal numValue;
            if (!decimal.TryParse(variableValue, out numValue))
            {
               return "Error : The value of x is not a number";
            }

            return string.Empty;
        }

        public static bool HasInValidCharacters(string input)
        {
            /* The ^ will anchor the beginning of the string, the $ will anchor the end of the string,
             * and the + will match one or more of what precedes it(a number in this case).*/

            //Regex regex = new Regex("^[-0123456789\\]\\[()*+xcosin^]+$");
            //var hasSpecialChar = new Regex("\\$[\\^]\\.\\*");

            //return regex.IsMatch(input) || hasSpecialChar.IsMatch(input) ? false : true;

            return false;
        }

        public static List<string> InvalidSymbol(string input)
        {
            List<string> invalidSymbolCombinations = new List<string>()
            {
                "(+", "+)", "(*", "*)", "^)","sin[]","cos[]"
            };

            input = input.ToLower();

            foreach (var invalidCombo in invalidSymbolCombinations)
            {
                if (input.Contains(invalidCombo))
                    return new List<string>() { invalidCombo };
            }

            return new List<string>();
        }
    }
}
