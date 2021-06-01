using MyBankApp.BusinessLogic;
using MyBankApp.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp
{
    public static class FrmLogin
    {
        private static readonly SecurityRepository securityRepository;
        static FrmLogin()
        {
            securityRepository = new SecurityRepository();
        }

        public static Tuple<string, string, string> Login()
        {
            Console.WriteLine("\nTo Login, please enter your Email and Password");

            // collect login credentials
            var email = Console.ReadLine();
            var password = Console.ReadLine();

            // is email valid?
            while (!Utility.IsEmailValid(email))
            {
                Console.WriteLine("\nInvalid email format.\n");

                Console.WriteLine("Enter your Email again Or enter 'E' to escape this propmt");
                email = Console.ReadLine();
                if (email.Equals("E"))
                    break;
            }

            // login using repository
            //return securityRepository.Login(email, password);

        }
    }
}
