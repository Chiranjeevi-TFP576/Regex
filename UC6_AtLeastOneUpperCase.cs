using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19RegexAssignment
{
    internal class UC6_AtLeastOneUpperCase
    {
        public static string CreatePassWordRule2 = ("[A-Z]{1,}[a-z0-9]{7,15}");
        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, CreatePassWordRule2);
        }
    }
}
