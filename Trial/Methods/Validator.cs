using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Trial
{
    public class Validator
    {
        public static string Validate(string input)
        {
            List<string> errors = new List<string>();
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(input))
            {
                sb.AppendLine("Error: Empty Input.");
                return sb.ToString();
            }

            if(input.Length > 40)
            {
                sb.AppendLine("Error: Equation Length exceded.");
            }

            if (HasInValidCharacters(input))
            {
                sb.AppendLine("Error: Input has Invalid Characters.");
            }

            List<string> symbolErrors = InvalidSymbol(input);
            if (symbolErrors.Count > 0)
            {
                sb.AppendLine($"Error: Contains Invalid Symbol combination : {symbolErrors[0]}");
            }

            return sb.ToString();
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
