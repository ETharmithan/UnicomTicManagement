using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Validation
{
    public static class Validation
    {
        //Phone Validation
        public static bool ValidPhoneNumber(string phonenumber)
        {
            string pattern = @"^(\+94|0)\d{9}$";
            return Regex.IsMatch(phonenumber, pattern);
        }

        //Gmail Validation
        public static bool ValidGmail(string gmail)
        {
            string gmailpattern = @"^[a-zA-Z0-9_+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$";
            return Regex.IsMatch (gmail, gmailpattern);      
        }

        //Salary Validation
        public static bool ValidSalary(string salary)
        {
            return Convert.ToInt64(salary) > 0;
        }
    }
}
