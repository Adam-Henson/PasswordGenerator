namespace PasswordGenerator.Models
{
    public class passwordModel
    {
        public static string Password { get; set; }
        public static int Length { get; set; }
        public string Numbers { get; set; }
        public string Upper { get; set; }
        public string Lower { get; set; }
        public string Special { get; set; }
        public static bool HasSpecial { get; set; }
        public static bool HasUpper { get; set; }
        public static bool HasNumbers { get; set; }
        public static bool HasLower { get; set; } 
        public passwordModel(string password, int length, string numbers, string upper, string lower, string special, bool hasSpecial, bool hasUpper, bool hasNumbers, bool hasLower)
        {
            Password = password;
            Length = length;
            Numbers = numbers;
            Upper = upper;
            Lower = lower;
            Special = special;
            HasSpecial = hasSpecial;
            HasUpper = hasUpper;
            HasNumbers = hasNumbers;
            HasLower = hasLower;
        }
        public passwordModel()
        {

        }
    }
}
