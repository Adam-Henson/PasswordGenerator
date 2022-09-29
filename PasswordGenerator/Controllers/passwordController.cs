using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PasswordGenerator.Models;
using System.Text;

namespace PasswordGenerator.Controllers
{
    public class passwordController : Controller
    {
        public void Password()
        {
            //static void Main(string[] args)
            //{
            //    Console.Write("Enter the length:");
            //    int length = Convert.ToInt32(Console.ReadLine());

            //    if (length > 0)
            //    {
            //        Console.WriteLine(GeneratePassword(length));
            //    }
            //}
            ////public static string GeneratePassword(int length)
            //{
            //    const string chars = "1234567890" + "abcdefghijklmnopqrstuvwxyz" + "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "!@#$%^&*_+=-";

            //    StringBuilder stringBuilder = new StringBuilder();
            //    Random random = new Random();

            //    for (int i = 0; i < length; i++)
            //    {
            //        int index = random.Next(chars.Length);
            //        stringBuilder.Append(chars[index]);
            //    }

            //    return stringBuilder.ToString();
            //}
        }
        public string GetPassword()
        {
            passwordModel model = new passwordModel();

            StringBuilder pass = new StringBuilder();

            Random random = new Random();

            string Password = pass.ToString();
            int Length = 0;

            model.Numbers = "1234567890";
            model.Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            model.Lower = "abcdefghijklmnopqrstuvwxyz";
            model.Special = "!@#$%&*_+=-";
            bool HasSpecial = true;
            bool HasNumbers = true;
            bool HasUpper = true;
            bool HasLower = true;
            Password = model.Numbers + model.Upper + model.Lower + model.Special;


            if (HasSpecial == true && HasNumbers == true && HasLower == true && HasUpper == true)
            {
                Password = model.Upper + model.Lower + model.Numbers + model.Special;
            }

            if (HasSpecial == true && HasNumbers == true && HasLower == true && HasUpper == false)
            {
                Password = model.Lower + model.Numbers + model.Special;
            }

            if (HasSpecial == true && HasNumbers == true && HasLower == false && HasUpper == false)
            {
                Password = model.Numbers + model.Special;
            }

            if (HasSpecial == true && HasNumbers == false && HasLower == false && HasUpper == false)
            {
                Password = model.Special;
            }

            if (HasSpecial == true && HasNumbers == true && HasLower == false && HasUpper == true)
            {
                Password = model.Upper + model.Numbers + model.Special;
            }

            if (HasSpecial == true && HasNumbers == false && HasLower == false && HasUpper == true)
            {
                Password = model.Upper + model.Special;
            }

            if (HasSpecial == false && HasNumbers == false && HasLower == false && HasUpper == true)
            {
                Password = model.Upper;
            }

            if (HasSpecial == true && HasNumbers == false && HasLower == true && HasUpper == true)
            {
                Password = model.Upper + model.Lower + model.Special;
            }

            if (HasSpecial == false && HasNumbers == false && HasLower == true && HasUpper == true)
            {
                Password = model.Upper + model.Lower;
            }

            if (HasSpecial == false && HasNumbers == false && HasLower == true && HasUpper == false)
            {
                Password = model.Lower;
            }

            if (HasSpecial == false && HasNumbers == true && HasLower == true && HasUpper == true)
            {
                Password = model.Upper + model.Lower + model.Numbers;
            }

            if (HasSpecial == false && HasNumbers == true && HasLower == true && HasUpper == false)
            {
                Password = model.Lower + model.Numbers;
            }

            if (HasSpecial == false && HasNumbers == true && HasLower == false && HasUpper == false)
            {
                Password = model.Numbers;
            }

            if (HasSpecial == false && HasNumbers == false && HasLower == false && HasUpper == false)
            {
                Console.WriteLine("Must include at least one of these values. UpperCase, LowerCase, Special, Numbers");
                Password = "  ";
            }


            for (int i = 0; i < 10; i++)
            {
                int index = random.Next(Password.Length);
                pass.Append(Password[index]);
            }

            
            return pass.ToString();
        }
        public IActionResult Index()
        {
            passwordModel model = new passwordModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string password, int length, string numbers, string upper, string lower, string special, bool hasSpecial, bool hasUpper, bool hasNumbers, bool hasLower)
        {
            passwordModel model = new passwordModel(password, length, numbers, upper, lower, special, hasSpecial, hasUpper, hasNumbers, hasLower);

            return View(model);
        }
    }
}
