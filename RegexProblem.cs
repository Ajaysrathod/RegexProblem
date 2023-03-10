using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class RegexProblem
    {
        public void ValidateFirstName(string name)
        {
            //Ajay
            string firstName = "^[A-Z]{1}[a-z]{3,}?";
            if (Regex.IsMatch(name, firstName))
            {
                Console.WriteLine("First name is matching with Regex");
            }
            else
            {
                Console.WriteLine("FirstName is not matching with Regex");
            }
        }
        public void ValidateLastName(string name)
        {
            string lastName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("Last name is matching with Regex");
            }
            else
            {
                Console.WriteLine("Last Name is not matching with Regex");
            }

        }
        public void ValidateEmail(string email)
        {
            //abc.xyz@bridgelabz.co.in
            string emailID = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";

            if (Regex.IsMatch(email, emailID))
            {
                Console.WriteLine("Email id is matching with Regex");
            }
            else
            {
                Console.WriteLine("Email is not matching with Regex");
            }
        }
        public void ValidatePhoneNumber(string phoneNumber)
        {
            //"91 0143433425"
            string phoneNum = @"[0-9]{2}[ ][0-9]{10}";  //@"[0-9]{2}/s[0-9]{10}" Both are correct expressions
            if (Regex.IsMatch(phoneNumber, phoneNum))
            {
                Console.WriteLine("Phone Number is matching with Regex");
            }
            else
            {
                Console.WriteLine("Phone Number is not matching with Regex");
            }
        }
        public void ValidatePassword(string pswrd)
        {
            string password = @"[A-Z]{1}[a-z0-9]";
            if (Regex.IsMatch(pswrd, password))
            {
                Console.WriteLine("Password is matching with Regex");
            }
            else
            {
                Console.WriteLine("Password is not matching with Regex");
            }
        }
        public void ValidateStringPassword(string numPassword)
        {
            string password = "[A-Z]{1,}[a-z0-9]";
            if (Regex.IsMatch(numPassword, password))
            {
                Console.WriteLine("String Password is matching with Regex");
            }
            else
            {
                Console.WriteLine("String password is not matching with Regex");
            }
        }
        public void ValidateNumericPassword(string numPassword)
        {
            string password = "[a-zA-Z][0-9]{1,}";
            if (Regex.IsMatch(numPassword, password))
            {
                Console.WriteLine("Numeric Password is matching with Regex");
            }
            else
            {
                Console.WriteLine("Numeric password is not matching with Regex");
            }
        }
        public void ValidateSpecialCharacter(string character)
        {
            string spclChar = "[0-9a-zA-Z][!@#$%&*]{1}";
            if (Regex.IsMatch(character, spclChar))
            {
                Console.WriteLine("Special Character is matched with Regex");
            }
            else
            {
                Console.WriteLine("Special Character is not matched with Regex");
            }
        }
    }
}

