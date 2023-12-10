using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DebtManagment_BusinessLayer
{
    public class clsValidatePatterns
    {
        public const string FullNamPatterne = @"^([\u0600-\u06FF]+(\s+[\u0600-\u06FF]+)*)$";
        public const string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        public const string PhoneNumberPattern = @"^7[0-9]{8}$";
        public const string AddressPattern = @"^([\u0600-\u06FF]+(\s+[\u0600-\u06FF]+)*)(\s*-\s*([\u0600-\u06FF]+(\s+[\u0600-\u06FF]+)*))*$";
        public const string IdentityNumberPattern = @"^\d{11}$";
        public const string USerNamePattern = @"^[a-zA-Z0-9_-]{4,20}$";
        public const string PasswordPattern = @"^.{8,}$";

        //not implemented yet
        //public const string CommercialRegistrationPattern = @"";
        //public const string MaterialPattern = @"";

        public static bool IsMatch(string pattern, ref string value)
        {
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(value))
            {
                value = Regex.Replace(value, pattern, match => Regex.Replace(match.Value, @"\s+", " "));
                return true;
            }
            return false;
        }

 
    }
}
