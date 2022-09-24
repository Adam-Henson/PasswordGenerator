namespace PasswordGenerator.Models
{
    public class passwordModel
    {
        public string Password { get; set; }
        public int Numbers { get; set; }
        public string Upper { get; set; }
        public string Lower { get; set; }
        public bool HasPassword { get; set; }
        public passwordModel(string password, int numbers, string upper, string lower, bool hasPassword)
        {
            Password = password;
            Numbers = numbers;
            Upper = upper;
            Lower = lower;
            HasPassword = hasPassword;
        }
        public passwordModel()
        {

        }
    }
}
