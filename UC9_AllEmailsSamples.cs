using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19RegexAssignment
{
    public class AllEmailSample
    { //Given Emails in Assignment
        public static string emailSample = "^[a-zA-Z0-9]+([@#%$&+.-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,})?$";

        public bool validateString(string Name)
        {
            return Regex.IsMatch(Name, emailSample);
        }
    }
}
