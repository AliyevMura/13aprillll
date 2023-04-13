
using System.Text.RegularExpressions;

namespace CustomValidator
{

    public class Validator
    {
        public string ValidateUsername(string value)
        {
            if (value.Length >= 2)
            {
                return value;
            }
            else
            {
                return "username 3 herfden boyuk olmalidir";

            }

        }
        public bool ValidatePassword(string password)
        {

            if (password.Length < 8)
            {
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            if (!password.Any(char.IsSymbol))
            {
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                return false;
            }

            return true;



            //string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W)(?!.*\s).{8,}$";
            //return Regex.IsMatch(password, pattern);
            //regexle error verirdi bilmedim sebebibini
        }


        public string ValidateName(string value)
        {
            if (value.Length >= 2)
            {
                return value;
            }
            else
            {
                return "name 3 herfden boyuk olmalidir";
            }
        }




        public string ValidateSurame(string value)
        {
            if (value.Length >= 2)
            {
                return value;
            }
            else
            {
                return "Surname 3 herfden boyuk olmalidir";
            }
        }


        public int ValidateAge(int age)
        {
            if (age > 0)
            {
                return age;
            }
            else
            {
                return 0;
            }
        }
        public int ValidateBirthday(int birthday)
        {
            if (birthday > 1970) { 
            return birthday;
            }
            else
            {
                return 0;
            }
        }

    }
}