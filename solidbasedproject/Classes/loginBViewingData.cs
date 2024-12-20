using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidbasedproject.Classes
{
    public class loginBViewingData : IviewData
    {
        public void seeData()  // Method to view data based on registration ID
        {

            string checkUser = verifyUsers.storeUser;
            const string dataPath = "Text Files/data.txt";


            Console.WriteLine();
            Console.WriteLine("Registration Id".PadRight(20) + "Name".PadRight(20) + "Department".PadRight(20) +
                "Semester".PadRight(20) + "Father Name".PadRight(20) + "Fee Status".PadRight(20));
            string[] getRecords = File.ReadAllLines(dataPath);  // Read data file
            foreach (var line in getRecords)
            {
                string[] split = line.Split(new char[] { ',' });
                if (split[0] == checkUser)  // Match registration ID
                {
                    foreach (var field in split)
                        Console.Write(field.PadRight(20));  // Display data
                    return;
                }
            }
            Console.WriteLine("Record doesn't exist!");  // No match found
            seeData();  // Retry
        }
    }

}
