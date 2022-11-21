using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19RegexAssignment
{
    internal class Uc8_ExactOneSpecialCharecter
    {
        public static string CreatePassWordRule4 = ("[A-Z]+[a-z]{4,16}[!@#$%&*]{1}[0-9]{2}");//One SpecialCharcter

        //public static string CreatePassWordRule4 = ("[a-zA-Z0-9]{0,}[A-Z]{1}[a-zA-Z0-9]{1,}[!*@#$%^&+=]?[a-zA-Z0-9]{1}[0-9]{1,}[a-zA-Z0-9]{1,}");
       // public static string CreatePassWordRule4 = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^!@#$%_]*[!@#$%_][^!@#$%_]*$)[a-zA-Z0-9!@#$%_]{8,}$";
        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, CreatePassWordRule4);
        }
    }
}
