using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidbasedproject.Classes
{
    public static class verifyUsers
    {
        public static string storeUser;
        public static string storePass;
        public static void checkUsernameAndPassword()
        {
            int counter = 0;
            string regId;
            const string userPath = "Text Files/Username.txt";
            string[] check, split;
            string storeUsername = "", storePassword = "";
            string password;

            Console.Write("Enter your registration id: ");
            regId = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            storeUser = regId;
            storePass = password;


            check = File.ReadAllLines(userPath);  // Read file
            foreach (var lines in check)
            {
                split = lines.Split(new char[] { ',' });
                if (split[0] == regId && split[1] == password)  // Match input with stored data
                {
                    storeUsername = split[0];
                    storePassword = split[1];
                }
            }

            if (regId != storeUsername || password != storePassword)  // If not matched
            {
                counter++;
                if (counter < 3)
                {
                    Console.WriteLine("Incorrect Username or password!");
                    checkUsernameAndPassword();  // Retry
                }
                else
                {
                    Console.WriteLine("Too many incorrect attempts. Exiting.");
                    Environment.Exit(1);  // Quit the program after 3 attempts
                }
            }
        }
    }
}
