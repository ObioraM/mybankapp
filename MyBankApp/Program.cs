using System;
using System.Threading;

namespace MyBankApp
{
    public class Program 
    { 
        public static Tuple<string, string, string> principal;
        static void Main(string[] args)
        {
            FrmSplashScreen.WelcomeMessage();


            try
            {
                if (FrmRegister.Register())
                {
                    Console.WriteLine("\nRegistration was successful!\n");
                    Thread.Sleep(1500);
                    FrmSplashScreen.WelcomeMessage();

                    var loggedInUserDetails = FrmLogin.Login();

                    Console.WriteLine();
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("\n" + ex.Message + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message + "\n");
            }
        }
    }
}
