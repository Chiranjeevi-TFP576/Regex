using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19RegexAssignment
{
    internal class UC7_AtLeastOneNumber
    {
        public static string CreatePassWordRule3 = ("^[A-Z]+[a-zA-Z]{6,16}[0-9]+");
        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, CreatePassWordRule3);
        }
    }
}
