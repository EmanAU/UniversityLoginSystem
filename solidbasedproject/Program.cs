using solidbasedproject;
using System;
using System.IO;
using solidbasedproject.Classes;

namespace ConsoleApp1
{

        internal class structure
        {
            static void menuMain()
            {
                Console.WriteLine("******Welcome to ES University login page");
                Console.WriteLine("\n1. Admin login");
                Console.WriteLine("2. Student login");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter: ");
            }
            static void menuAdmin1()
            {
                Console.WriteLine("*****Welcome to ES University Admin Portal!*****\n");
                Console.WriteLine("1. See Student Data");
                Console.WriteLine("2. Modify Student Data");
                Console.WriteLine("3. Add Student");
                Console.WriteLine("4. Remove Student");
                Console.WriteLine("5. Change Username");
                Console.WriteLine("6. Change Password");
                Console.WriteLine("7. Exit");
                Console.Write("\nEnter: ");
            }

            static void menuStudent1()
            {
                Console.WriteLine("*****Welcome to ES University Student Portal!\n");
                Console.WriteLine("1. See Your Data");
                Console.WriteLine("2. Change Username");
                Console.WriteLine("3. Change Password");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter: ");
            }

            static void inputValidation(int num1, int num2) // Method for input validation
            {
                Console.WriteLine("You can only enter between " + num1 + " and " + num2);
                Console.Write("Enter again: ");
            }
            public static void Main(string[] args)
            {

                Admin admin = new Admin();
                Student student = new Student();


                int choice1;        //variabel to store the choice of user
                int choiceAdmin;    //To enter admin choice
                int choiceAdminForModifying; //To enter b y admin to modify student's data
                int choiceStudentForActions = 4;    //To enter student choice



                menuMain();
                choice1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                while (choice1 > 3 || choice1 < 1)  //switch to show the menu to user
                {
                    inputValidation(1, 3);
                    choice1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }


                switch (choice1)
                {
                    case 1:
                        Console.WriteLine("*****Enter your username and password*****\n");
                        verifyUsers.checkUsernameAndPassword();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("*****Enter your username and password*****\n");
                        verifyUsers.checkUsernameAndPassword();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Thank You for Visiting!");
                        Environment.Exit(0);
                        break;

                }
                do
                {

                    switch (choice1) //After the username and password is entered correctly
                    {
                        case 1: // Enters as an admin
                            while (true) // Loop to allow repeated admin actions
                            {
                                menuAdmin1();
                                choiceAdmin = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                while (choiceAdmin > 7 || choiceAdmin < 1)
                                {
                                    inputValidation(1, 7);
                                    choiceAdmin = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }

                                switch (choiceAdmin)
                                {
                                    case 1:
                                        admin.seeData();
                                        break;
                                    case 2:
                                        Console.WriteLine("1. Modify Student's Registration Id");
                                        Console.WriteLine("2. Modify Student's Name");
                                        Console.WriteLine("3. Modify Student's Father Name");
                                        Console.WriteLine("4. Modify Student's Department");
                                        Console.WriteLine("5. Modify Student's Semester");
                                        Console.WriteLine("6. Modify Student's Fee Status");
                                        Console.WriteLine("7. Exit");
                                        Console.Write("\nEnter: ");
                                        choiceAdminForModifying = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine();
                                        while (choiceAdminForModifying < 1 || choiceAdminForModifying > 7)
                                        {
                                            inputValidation(1, 7);
                                            choiceAdminForModifying = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine();
                                        }

                                        switch (choiceAdminForModifying)
                                        {
                                            case 1:
                                                admin.modifyStudentUsername();
                                                Console.WriteLine();
                                                break;
                                            case 2:
                                                admin.modifyStudentName();
                                                Console.WriteLine();
                                                break;
                                            case 3:
                                                admin.modifyStudentFatherName();
                                                Console.WriteLine();
                                                break;
                                            case 4:
                                                admin.modifyStudentDepartment();
                                                Console.WriteLine();
                                                break;
                                            case 5:
                                                admin.modifyStudentSemester();
                                                Console.WriteLine();
                                                break;
                                            case 6:
                                                admin.modifyStudentFeeStatus();
                                                Console.WriteLine();
                                                break;
                                            case 7:
                                                break; // Exit the modifying menu
                                        }
                                        break;

                                    case 3:
                                        admin.addStudent();
                                        Console.WriteLine();
                                        break;

                                    case 4:
                                        admin.removeStudent();
                                        Console.WriteLine();
                                        break;

                                    case 5:
                                        admin.changeUsername();
                                        Console.WriteLine();
                                        break;
                                    case 6:
                                        admin.changePassword();
                                        Console.WriteLine();
                                        break;
                                    case 7:
                                        Environment.Exit(0);
                                        break;
                                }

                                if (choiceAdmin == 7) // Break the loop if the admin chooses to exit
                                {
                                    break; // Exit the admin menu loop
                                }
                            
                            }
                        break;
                    case 2: // Enters as a student
                        while (true) // Loop to allow repeated student actions
                        {
                            menuStudent1();
                            choiceStudentForActions = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            while (choiceStudentForActions > 4 || choiceStudentForActions < 1)
                            {
                                inputValidation(1, 4);
                                choiceStudentForActions = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                            }

                            switch (choiceStudentForActions)
                            {
                                case 1:
                                    student.seeData();
                                    break;
                                case 2:
                                    student.changeUsername();
                                    break;
                                case 3:
                                    student.changePassword();
                                    break;
                                case 4:
                                    Environment.Exit(0);
                                    break;
                            }

                            if (choiceStudentForActions == 4) // Exit the student menu
                            {
                                break; // Exit the student menu loop
                            }
                        }
                        break;
                }

            } while (choiceStudentForActions != 4);
        }
    }
}