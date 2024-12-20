using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidbasedproject.Classes
{
    public abstract class loginAChangeStudentDetails : IchangeName, IchangeFatherName, IchangeSemester,
    IchangeDepartment, IchangeFeeStatus, IchangeUsernameOfStudent, IchangePasswordOfStudent
    {

        public void seeData()  // Method to view data based on registration ID
        {
            const string dataPath = "F:\\Project Files\\data.txt";
            string reg;
            Console.Write("Enter the registration id: ");
            reg = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Registration Id".PadRight(20) + "Name".PadRight(20) + "Department".PadRight(20) +
                "Semester".PadRight(20) + "Father Name".PadRight(20) + "Fee Status".PadRight(20));
            string[] getRecords = File.ReadAllLines(dataPath);  // Read data file
            foreach (var line in getRecords)
            {
                string[] split = line.Split(new char[] { ',' });
                if (split[0] == reg)  // Match registration ID
                {
                    foreach (var field in split)
                        Console.Write(field.PadRight(20));  // Display data
                    return;
                }
            }
            Console.WriteLine("Record doesn't exist!");  // No match found
            seeData();  // Try again
        }



        public void modifyStudentUsername()
        {
            const string userPath = "F:\\Project Files\\Username.txt";
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
                if (split[0] == newUser)
                {
                    Console.WriteLine("This usernaem already exists");
                    Console.WriteLine("Try again!");
                    modifyStudentUsername();
                }
            }

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



        public void modifyStudentPassword()
        {
            const string userPath = "F:\\Project Files\\Username.txt";
            string regID, newpassword;
            Console.Write("Enter username of student: ");
            regID = Console.ReadLine();
            Console.WriteLine("Enter new password of student: ");
            newpassword = Console.ReadLine();

            string[] readFile = File.ReadAllLines(userPath);  // get all data from file
            for (int i = 0; i < readFile.Length; i++)
            {
                string[] split = readFile[i].Split(new char[] { ',' });
                if (split[0] == regID)     // if registration id matches
                {
                    split[1] = newpassword;  // Change to new password
                    readFile[i] = string.Join(",", split);  // Update file record
                    File.WriteAllLines(userPath, readFile); //Write the new password
                    Console.WriteLine("Password Changed Successfully!");
                    break;
                }
            }
        }


        public void modifyStudentName()
        {
            const string userPath = "F:\\Project Files\\data.txt";
            string regID, newName;
            Console.Write("Enter the registration id of student: ");
            regID = Console.ReadLine();
            Console.WriteLine("Enter the name you want to set: ");
            newName = Console.ReadLine();

            string[] readFile = File.ReadAllLines(userPath);  // get all data from file
            for (int i = 0; i < readFile.Length; i++)
            {
                string[] split = readFile[i].Split(new char[] { ',' });
                if (split[0] == regID)     // if registration id matches
                {
                    split[1] = newName;  // Change to new password
                    readFile[i] = string.Join(",", split);  // Update file record
                    File.WriteAllLines(userPath, readFile); //Write the new password
                    Console.WriteLine("Name Changed Successfully!");
                    break;
                }
            }
        }





        public void modifyStudentFatherName()
        {
            const string userPath = "F:\\Project Files\\data.txt";
            string regID, newFather;
            Console.Write("Enter the registration id of student: ");
            regID = Console.ReadLine();
            Console.WriteLine("Enter the name you want to set: ");
            newFather = Console.ReadLine();

            string[] readFile = File.ReadAllLines(userPath);  // get all data from file
            for (int i = 0; i < readFile.Length; i++)
            {
                string[] split = readFile[i].Split(new char[] { ',' });
                if (split[0] == regID)     // if registration id matches
                {
                    split[4] = newFather;  // Change to new password
                    readFile[i] = string.Join(",", split);  // Update file record
                    File.WriteAllLines(userPath, readFile); //Write the new password
                    Console.WriteLine("Name Changed Successfully!");
                    break;
                }
            }
        }



        public void modifyStudentSemester()
        {
            const string userPath = "F:\\Project Files\\data.txt";
            string regID, newSemester;
            Console.Write("Enter the registration id of student: ");
            regID = Console.ReadLine();
            Console.WriteLine("Enter the semester number you want to set: ");
            newSemester = Console.ReadLine();

            string[] readFile = File.ReadAllLines(userPath);  // get all data from file
            for (int i = 0; i < readFile.Length; i++)
            {
                string[] split = readFile[i].Split(new char[] { ',' });
                if (split[0] == regID)     // if registration id matches
                {
                    split[3] = newSemester;  // Change to new password
                    readFile[i] = string.Join(",", split);  // Update file record
                    File.WriteAllLines(userPath, readFile); //Write the new password
                    Console.WriteLine("Semester Changed Successfully!");
                    break;
                }
            }
        }



        public void modifyStudentDepartment()
        {
            const string userPath = "F:\\Project Files\\data.txt";
            string regID, newDepartment;
            Console.Write("Enter the registration id of student: ");
            regID = Console.ReadLine();
            Console.WriteLine("Enter name of department you want to set: ");
            newDepartment = Console.ReadLine();

            string[] readFile = File.ReadAllLines(userPath);  // get all data from file
            for (int i = 0; i < readFile.Length; i++)
            {
                string[] split = readFile[i].Split(new char[] { ',' });
                if (split[0] == regID)     // if registration id matches
                {
                    split[2] = newDepartment;  // Change to new password
                    readFile[i] = string.Join(",", split);  // Update file record
                    File.WriteAllLines(userPath, readFile); //Write the new password
                    Console.WriteLine("Depeartment Changed Successfully!");
                    break;
                }
            }
        }





        public void modifyStudentFeeStatus() //To change student fee status
        {
            const string userPath = "F:\\Project Files\\data.txt";

            string regId;
            Console.Write("Enter Registration Id: ");
            regId = Console.ReadLine();

            string[] readFile = File.ReadAllLines(userPath);  // get all data from file
            for (int i = 0; i < readFile.Length; i++)
            {
                string[] split = readFile[i].Split(new char[] { ',' });
                if (split[0] == regId)     // if fee is paid
                {
                    if (split[5] == "Paid")
                    {
                        split[5] = "Unpaid";  // Change 
                        readFile[i] = string.Join(",", split);  // Update file record
                        File.WriteAllLines(userPath, readFile); //Write 
                        Console.WriteLine("Fee Status Changed Successfully!");
                        break;
                    }
                    else if (split[5] == "Unpaid")
                    {
                        split[5] = "Paid";  // Change
                        readFile[i] = string.Join(",", split);  // Update file record
                        File.WriteAllLines(userPath, readFile); //Write 
                        Console.WriteLine("Fee Status Changed Successfully!");
                        break;
                    }
                }

            }
        }



    }
}
