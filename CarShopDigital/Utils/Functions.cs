using System.Text.RegularExpressions;

namespace CarShopDigital.Utils
{
    public static class Functions
    {
        public static bool ValidateId(int id)
        {
            if (id <= 0) return false;
            
            // Assuming ID should be numeric and exactly 9 characters
            return Regex.IsMatch(id.ToString(), @"^[0-9]{9}$");
        }

        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;

            // Password must be at least 8 characters, contain uppercase, lowercase, number
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasMinLength = new Regex(@".{8,}");

            return hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasLowerChar.IsMatch(password) && hasMinLength.IsMatch(password);
        }
    }
}