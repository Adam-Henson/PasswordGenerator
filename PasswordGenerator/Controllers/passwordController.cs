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
        //public string GetPassword()
        //{

        //}
        public IActionResult Index()
        {
            passwordModel model = new passwordModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string password, int numbers, string upper, string lower, bool hasPassword)
        {
            passwordModel model = new passwordModel(password, numbers, upper, lower, hasPassword);

            return View(model);
        }
    }
}
