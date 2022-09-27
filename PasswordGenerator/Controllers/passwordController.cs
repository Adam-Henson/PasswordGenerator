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

            model.Password = pass.ToString();
            model.Length = 10;

            model.Numbers = "1234567890";
            model.Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            model.Lower = "abcdefghijklmnopqrstuvwxyz";
            model.Special = "!@#$%^&*()_+=-";
            model.HasSpecial = true;
            model.HasNumbers = true;
            model.HasUpper = true;
            model.HasLower = true;
            model.Password = model.Numbers + model.Upper + model.Lower + model.Special;


            if (model.HasSpecial == true && model.HasNumbers == true && model.HasLower == true && model.HasUpper == true)
            {
                model.Password = model.Upper + model.Lower + model.Numbers + model.Special;
            }

            if (model.HasSpecial == true && model.HasNumbers == true && model.HasLower == true && model.HasUpper == false)
            {
                model.Password = model.Lower + model.Numbers + model.Special;
            }

            if (model.HasSpecial == true && model.HasNumbers == true && model.HasLower == false && model.HasUpper == false)
            {
                model.Password = model.Numbers + model.Special;
            }

            if (model.HasSpecial == true && model.HasNumbers == false && model.HasLower == false && model.HasUpper == false)
            {
                model.Password = model.Special;
            }

            if (model.HasSpecial == true && model.HasNumbers == true && model.HasLower == false && model.HasUpper == true)
            {
                model.Password = model.Upper + model.Numbers + model.Special;
            }

            if (model.HasSpecial == true && model.HasNumbers == false && model.HasLower == false && model.HasUpper == true)
            {
                model.Password = model.Upper + model.Special;
            }

            if (model.HasSpecial == false && model.HasNumbers == false && model.HasLower == false && model.HasUpper == true)
            {
                model.Password = model.Upper;
            }

            if (model.HasSpecial == true && model.HasNumbers == false && model.HasLower == true && model.HasUpper == true)
            {
                model.Password = model.Upper + model.Lower + model.Special;
            }

            if (model.HasSpecial == false && model.HasNumbers == false && model.HasLower == true && model.HasUpper == true)
            {
                model.Password = model.Upper + model.Lower;
            }

            if (model.HasSpecial == false && model.HasNumbers == false && model.HasLower == true && model.HasUpper == false)
            {
                model.Password = model.Lower;
            }

            if (model.HasSpecial == false && model.HasNumbers == true && model.HasLower == true && model.HasUpper == true)
            {
                model.Password = model.Upper + model.Lower + model.Numbers;
            }

            if (model.HasSpecial == false && model.HasNumbers == true && model.HasLower == true && model.HasUpper == false)
            {
                model.Password = model.Lower + model.Numbers;
            }

            if (model.HasSpecial == false && model.HasNumbers == true && model.HasLower == false && model.HasUpper == false)
            {
                model.Password = model.Numbers;
            }

            if (model.HasSpecial == false && model.HasNumbers == false && model.HasLower == false && model.HasUpper == false)
            {
                Console.WriteLine("Must include at least one of these values. UpperCase, LowerCase, Special, Numbers");
                model.Password = "  ";
            }


            for (int i = 0; i < 10; i++)
            {
                int index = random.Next(model.Password.Length);
                pass.Append(model.Password[index]);
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
