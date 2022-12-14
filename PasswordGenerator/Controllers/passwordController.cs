using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;
using System.Reflection.Metadata;
using System.Text;

namespace PasswordGenerator.Controllers
{
    
    public class passwordController : Controller
    {
        
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

        public IActionResult GetPassword(int Length, bool HasLower, bool HasUpper, bool HasSpecial, bool HasNumbers)
        {
            passwordModel model = new passwordModel();

            StringBuilder pass = new StringBuilder();

            Random random = new Random();


            model.Numbers = "1234567890";
            model.Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            model.Lower = "abcdefghijklmnopqrstuvwxyz";
            model.Special = "!@#$%&*_+=-";

            string Password = model.Password;

            if (HasSpecial == true && HasNumbers == true && HasLower == true && HasUpper == true)
            {
                Password = model.Upper + model.Lower + model.Numbers + model.Special;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == true && HasNumbers == true && HasLower == true && HasUpper == false)
            {
                Password = model.Lower + model.Numbers + model.Special;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == true && HasNumbers == true && HasLower == false && HasUpper == false)
            {
                Password = model.Numbers + model.Special;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == true && HasNumbers == false && HasLower == false && HasUpper == false)
            {
                Password = model.Special;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == true && HasNumbers == true && HasLower == false && HasUpper == true)
            {
                Password = model.Upper + model.Numbers + model.Special;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == true && HasNumbers == false && HasLower == false && HasUpper == true)
            {
                Password = model.Upper + model.Special;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == false && HasNumbers == false && HasLower == false && HasUpper == true)
            {
                Password = model.Upper;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == true && HasNumbers == false && HasLower == true && HasUpper == true)
            {
                Password = model.Upper + model.Lower + model.Special;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == false && HasNumbers == false && HasLower == true && HasUpper == true)
            {
                Password = model.Upper + model.Lower;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == false && HasNumbers == false && HasLower == true && HasUpper == false)
            {
                Password = model.Lower;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == false && HasNumbers == true && HasLower == true && HasUpper == true)
            {
                Password = model.Upper + model.Lower + model.Numbers;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == false && HasNumbers == true && HasLower == true && HasUpper == false)
            {
                Password = model.Lower + model.Numbers;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == false && HasNumbers == true && HasLower == false && HasUpper == false)
            {
                Password = model.Numbers;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == true && HasNumbers == false && HasLower == true && HasUpper == false)
            {
                Password = model.Special + model.Lower;

                for (int i = 0; i < Length; i++)
                {
                    int index = random.Next(Password.Length);
                    pass.Append(Password[index]);
                }
                model.Password = pass.ToString();
            }

            if (HasSpecial == false && HasNumbers == false && HasLower == false && HasUpper == false)
            {
                model.Password = "Must include at least one.";
            }
            return View("Index", model);
        }
    }
}
