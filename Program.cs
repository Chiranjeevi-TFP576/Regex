// See https://aka.ms/new-console-template for more information
using Day19RegexAssignment;


Console.WriteLine("Welcome to User Registration Problem");
//Console.WriteLine("Enter 1 for First Name");
//Console.WriteLine("Enter 2 for Last Name");
//Console.WriteLine("Enter 3 for Email");
//Console.WriteLine("Enter 4 for Mobile number");
//Console.WriteLine("Enter 5 for PassWord Rule1");
//Console.WriteLine("Enter 6 for PassWord Rule2");
//Console.WriteLine("Enter 7 for PassWord Rule3");
Console.WriteLine("Enter 8 for PassWord Rule4");
//Console.WriteLine("Enter 9 for Email samples");

int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1: //First Name
        UC1_UserRegistration FirstNameRule = new UC1_UserRegistration();
        bool ValidName = FirstNameRule.validateString("SriRam");
        Console.WriteLine("{0}", (ValidName) ? "Valid Name" : "Invalid Name");
        break;
    case 2: //Last Name
        UC2_LastName LastNameRule = new UC2_LastName();
        bool ValidName2 = LastNameRule.validateString("Chiranjeevi Peyyela");
        Console.WriteLine("{0}", (ValidName2) ? "Valid Name" : "Invalid Name");
        break;
    case 3: //Eg:abc.xyz@bl.co.in
        Uc3_Email RegexemailRule = new Uc3_Email();
        bool Email1 = RegexemailRule.validateString("abc.xyz@bl.co.in");
        Console.WriteLine("{0}", (Email1) ? "Valid Email" : "Invalid Email");
        break;
    case 4: //Mobile Number with CountryCode
        UC4_MobileNumber MobileRule = new UC4_MobileNumber();
        bool Number1 = MobileRule.validateString("901 9866151331");
        Console.WriteLine("{0}", (Number1) ? "Valid Mobile Number" : "Invalid Mobilr Number");
        break;
    case 5://PasswordRule(min8/max16)
        UC5_PasswordRule CreatePassWordRule1 = new UC5_PasswordRule();
        bool PassWord1 = CreatePassWordRule1.validateString("chiru12345");
        Console.WriteLine("{0}", (PassWord1) ? "Valid PassWord" : "Invalid PassWord");
        break;
    case 6: //AtLeastOneUpperCase
        UC6_AtLeastOneUpperCase CreatePassWordRule2 = new UC6_AtLeastOneUpperCase();
        bool PassWord2 = CreatePassWordRule2.validateString("Chiru12345");
        Console.WriteLine("{0}", (PassWord2) ? "Valid PassWord" : "Invalid PassWord");
        break;
    case 7: // AtLeastOneNumber
        UC7_AtLeastOneNumber CreatePassWordRule3 = new UC7_AtLeastOneNumber();
        bool PassWord3 = CreatePassWordRule3.validateString("Chiranjeevi1");
        Console.WriteLine("{0}", (PassWord3) ? "Valid PassWord" : "Invalid PassWord");
        break;
    case 8: //ExactOneSpecialCharecter
        Uc8_ExactOneSpecialCharecter CreatePassWordRule4 = new Uc8_ExactOneSpecialCharecter();
        bool PassWord4 = CreatePassWordRule4.validateString("Chiru$14367");
        Console.WriteLine("{0}", (PassWord4) ? "Valid PassWord" : "Invalid PassWord");
        break;

    case 9: //All Emails
        AllEmailSample emailSample = new AllEmailSample();
        List<string> validtests = new List<string>() {"abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,
                                                     "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};

        foreach (var test in validtests)
        {
            bool result = emailSample.validateString(test);
            if (result)
            {
                Console.WriteLine("\n{0} is a valid email address", test);
            }
            else
            {
                Console.WriteLine("\n{0} is an invalid email address", test);
            }
        }
        break;

    default:
        Console.WriteLine("Enter a  valid number");
        break;

}