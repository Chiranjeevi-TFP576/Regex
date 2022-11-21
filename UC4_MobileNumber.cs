using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19RegexAssignment
{
    internal class UC4_MobileNumber 
    {
        //with Country code Moble Number{
        public static string MobileRule = "^[1-9]{1}[0-9]{1,2}[ ][1-9][0-9]{9}$";

        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, MobileRule);
        }
    }
}
