using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidbasedproject.Classes
{
    public abstract class loginBChangingUserAndPass : IchangeUsername, IchangePassword
    {

        public void changeUsername()  // Method to change username
        {
            const string userPath = "Text Files/Username.txt";
            string currentUser, newUser;
            Console.Write("Enter current username: ");
            currentUser = Console.ReadLine();
            while (currentUser != verifyUsers.storeUser)
            {
                Console.Write("You have entered wrong username!\nEnter again: ");
                currentUser = Console.ReadLine();
            }
            Console.Write("Enter new username: ");
            newUser = Console.ReadLine();

            string[] readFile = File.ReadAllLines(userPath);  // Read file
            for (int i = 0; i < readFile.Length; i++)
            {
                string[] split = readFile[i].Split(new char[] { ',' });
                if (split[0] == currentUser)  // If current username matches
                {
                    split[0] = newUser;  // Change to new username
                    readFile[i] = string.Join(",", split);  // Update the file line
                    File.WriteAllLines(userPath, readFile);
                    Console.WriteLine("Username Changed Successfully!");
                    break;
                }
            }
        }
        public void changePassword()  // Method to change password 
        {

            const string userPath = "Text Files/Username.txt";
            string currentpass, newpass;
            Console.Write("Enter current password: ");
            currentpass = Console.ReadLine();
            Console.Write("Enter new password: ");
            newpass = Console.ReadLine();

            string[] readFile = File.ReadAllLines(userPath);  // Read all data from file
            for (int i = 0; i < readFile.Length; i++)
            {
                string[] split = readFile[i].Split(new char[] { ',' });
                if (split[1] == currentpass)     // If current password matches
                {
                    split[1] = newpass;  // Change to new password
                    readFile[i] = string.Join(",", split);  // Update file line
                    File.WriteAllLines(userPath, readFile); //Write the new password
                    Console.WriteLine("Password Changed Successfully!");
                    break;
                }
            }
        }
    }
}
