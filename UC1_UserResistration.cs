using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19RegexAssignment
{
    internal class UC1_UserRegistration //FirstName
    {
        public static string FirstNameRule = "^[A-Z]{1}[a-z]{2,}$";

        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, FirstNameRule);
        }
    }
}

