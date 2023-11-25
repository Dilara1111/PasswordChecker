using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testPassword = Console.ReadLine();
            bool isValid = PasswordChecker(testPassword);
            if (!isValid) 
            {
                Console.WriteLine("Invalid Password");
            }
            else { Console.WriteLine("You are welcome"); }

               
        }
        static bool PasswordChecker(string password)
        {
            // Shifrenin 8den boyuk olmasini yoxlayir
            if (password.Length < 8)
            {
                return false;
            }
            // Shifrenin bosh olub-olmamasini yoxlayir
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            // Shifrede en azi bir boyuk herf olmasini yoxlayir
            if (!Regex.IsMatch(password, "[A - Z]+"))
            { 
                return false; 
            }
            //Shifrede en azi bir reqem olmasini yoxlayir
            if (!Regex.IsMatch(password, @"\d+"))
            {
                return false;
            }
            // SHifrede en azi bir kicik reqem olumasini yoxlayir
            if (!Regex.IsMatch(password, "[a-z]+"))
            {
                return false;
            }

            // Şifrede özel olmasını kontrol edir
            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]+"))
            {
                return false;
            }
            return true;




        }
    }
}
