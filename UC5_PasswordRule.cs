using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19RegexAssignment
{
    internal class UC5_PasswordRule
    {
        public static string CreatePassWordRule1 = "^[A-Za-z0-9]{8,16}$";

        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, CreatePassWordRule1);
        }
    }
}
