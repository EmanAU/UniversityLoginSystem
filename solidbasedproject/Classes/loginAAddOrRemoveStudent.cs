using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidbasedproject.Classes
{
    public class loginAAddOrRemoveStudent : IaddStudent, IremoveStudent
    {


        public void removeStudent() // To remove student
        {
            const string userPath = "Text Files/data.txt";

            string regId;
            Console.Write("Enter Registration Id: ");
            regId = Console.ReadLine();

            string[] readFile = File.ReadAllLines(userPath);  // get all data from file
            for (int i = 0; i < readFile.Length; i++)
            {
                string[] split = readFile[i].Split(new char[] { ',' });
                if (split[0] == regId)     // if registration id matched
                {
                    for (int j = 0; j < 6; j++)
                    {
                        split[j] = " ";
                    }

                    readFile[i] = string.Join(",", split);  // Update file record
                    File.WriteAllLines(userPath, readFile); //Write 
                    Console.WriteLine("Record Removed Successfully!");
                    break;
                }

            }
        }





        public void addStudent() //To aadd student;
        {
            const string userPath = "Text Files/data.txt";
            string regId, name, fatherName, department, semester, feeStauts;


            Console.Write("Enter registration Id of new student: ");   //input registration id
            regId = Console.ReadLine();

            Console.Write("Enter Name of new student: ");   //Input name
            name = Console.ReadLine();

            Console.Write("Enter Father Name of new student: ");      //input Father name
            fatherName = Console.ReadLine();

            Console.Write("Enter Department of new student: ");        //input Department
            department = Console.ReadLine();

            Console.Write("Enter Semester of new student: ");      //Input Semester
            semester = Console.ReadLine();

            Console.Write("Enter Fee Status (Paid or Unpaid) of new student: ");       //Input fee Status
            feeStauts = Console.ReadLine();


            string[] readFile = File.ReadAllLines(userPath);  // get all data from file
            for (int i = 0; i < readFile.Length; i++)
            {
                string[] split = readFile[i].Split(new char[] { ',' });
                if (split[0] == regId)     // if registration id matched
                {
                    Console.WriteLine("Record with current registration id already exists!");
                    Environment.Exit(-1);
                }

            }

            File.AppendAllText(userPath, regId + "," + name + "," +
                department + "," + semester + "," + fatherName
                + "," + feeStauts + Environment.NewLine);

            Console.WriteLine("Record Added Successfully!");

        }


    }
}
