using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19RegexAssignment
{
    internal class Uc3_Email //Example: abc.xyz@bl.co.in
    {
        public static string RegexemailRule = "^[a-z]+([.][a-z]+)*[@][a-z]{2,}[.][a-z]{2,3}([.][a-zA-Z]{2})?$";

        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, RegexemailRule);
        }
    }
}
