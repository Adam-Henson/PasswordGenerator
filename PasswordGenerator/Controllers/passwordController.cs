using Microsoft.AspNetCore.Mvc;
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

            model.Password = pass.ToString();
            model.Length = 10;

            model.Numbers = "1234567890";
            model.Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            model.Lower = "abcdefghijklmnopqrstuvwxyz";
            model.Special = "!@#$%^&*()_+=-";
            model.HasSpecial = false;
            model.HasNumbers = true;
            model.HasUpper = true;
            model.HasLower = true;
            model.Password = "";

            if (model.HasSpecial == false)
            {
                model.Password = pass.ToString(model.)
            }

            if(model.Password != null)
            {
                model.Password 
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
