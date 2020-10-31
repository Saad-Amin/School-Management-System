using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace SchoolManagementSystem
{
    class Program
    {
        string[,] arr = new string[2, 5];
        string[,] arrResult = new string[2, 5];
        string a;
        string AA;
        public void Mainmenue()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("Press 0 - Log Out");
            Console.WriteLine("Press 1 - Home");
            Console.WriteLine("Press 2 - Add Student");
            Console.WriteLine("Press 3 - View Student");
            Console.WriteLine("Press 4 - Generate Result");
            Console.WriteLine("Press 5 - Exit");
            Console.WriteLine("===============================");
            int Opt = 0;
            Opt = Convert.ToInt32(Console.ReadLine());
            MenuSelector(Opt);
        }
        public void AddStudent()
        {
            string Opt;
            Console.WriteLine("******");
            Console.WriteLine("Add Student");
            Console.WriteLine("******");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Enter Student ID");
                        a = Console.ReadLine();
                        arr[i, j] = a;
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("Enter Student Name");
                        a = Console.ReadLine();
                        arr[i, j] = a;
                    }
                    else if (j == 2)
                    {
                        Console.WriteLine("Enter Student Father Name");
                        a = Console.ReadLine();
                        arr[i, j] = a;
                    }
                    else if (j == 3)
                    {
                        Console.WriteLine("Enter Student Age");
                        a = Console.ReadLine();
                        arr[i, j] = a;
                    }
                    else if (j == 4)
                    {
                        Console.WriteLine("Enter Student Class");
                        a = Console.ReadLine();
                        arr[i, j] = a;
                    }
                }
            }
            Console.WriteLine("=============================");
            Console.WriteLine("Press V to View student Or M for Main Menue");
            Opt = Console.ReadLine();
            if (Opt == "v")
            {
                Console.Clear();
                ViewStudent();
            }
            else
            {
                Console.Clear();
                Mainmenue();
            }
        }
        public void ViewStudent()
        {
            Console.Clear();
            Console.WriteLine("******");
            Console.WriteLine("View Student");
            Console.WriteLine("******");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Student ID :");
                        Console.WriteLine(arr[i, j] + " ");
                    }
                    else if (j == 1)
                    {
                        Console.Write("Student Name :");
                        Console.WriteLine(arr[i, j] + " ");
                    }
                    else if (j == 2)
                    {
                        Console.Write("Father Name :");
                        Console.WriteLine(arr[i, j] + " ");
                    }
                    else if (j == 3)
                    {
                        Console.Write("Student Age :");
                        Console.WriteLine(arr[i, j] + " ");
                    }
                    else if (j == 4)
                    {
                        Console.Write("Class :");
                        Console.WriteLine(arr[i, j] + " ");
                    }
                }
            };
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("Press 1 Main Menue");
            Console.WriteLine("Press 2 Add Student");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A == 1)
            {
                Mainmenue();
            }
            else if (A == 2)
            {
                AddStudent();
            }
        }
        public void GenerateResult()
        {
            Console.Clear();
            Console.WriteLine("**********");
            Console.WriteLine(" Student Result Generator ");
            Console.WriteLine("**********");
            for (int i = 0; i < arrResult.GetLength(0); i++)
            {
                for (int j = 0; j < arrResult.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Enter Student ID");
                        AA = Console.ReadLine();
                        arrResult[i, j] = AA;
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("Enter Student Name");
                        AA = Console.ReadLine();
                        arrResult[i, j] = AA;
                    }
                    else if (j == 2)
                    {
                        Console.WriteLine("Enter English Marks");
                        AA = Console.ReadLine();
                        arrResult[i, j] = AA;
                    }
                    else if (j == 3)
                    {
                        Console.WriteLine("Enter Urdu Marks");
                        AA = Console.ReadLine();
                        arrResult[i, j] = AA;
                    }
                    else if (j == 4)
                    {
                        Console.WriteLine("Enter Math Marks");
                        AA = Console.ReadLine();
                        arrResult[i, j] = AA;
                    }
                }
            }
            Console.WriteLine("Press 1 Main Menue");
            Console.WriteLine("Press 2 View Result");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A == 1)
            {
                Mainmenue();
            }
            else if (A == 2)
            {
                ViewResult();
            }
        }
        public void ViewResult()
        {
            Console.Clear();
            Console.WriteLine("******");
            Console.WriteLine("View Result");
            Console.WriteLine("******");
            Console.WriteLine();
            double SUM = 0;
            for (int i = 0; i < arrResult.GetLength(0); i++)
            {
                Console.WriteLine("********");
                for (int j = 0; j < arrResult.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Student ID :");
                        Console.WriteLine(arrResult[i, j] + " ");
                    }
                    else if (j == 1)
                    {
                        Console.Write("Student Name :");
                        Console.WriteLine(arrResult[i, j] + " ");
                    }
                    else if (j == 2)
                    {
                        Console.Write("English Marks :");
                        Console.WriteLine(arrResult[i, j] + " /100 ");
                        //  SUM = arrResult[i, j];
                    }
                    else if (j == 3)
                    {
                        Console.Write("Urdu Marks :");
                        Console.WriteLine(arrResult[i, j] + " /100 ");
                        //  SUM = SUM + arrResult[i, j];
                    }
                    else if (j == 4)
                    {
                        Console.Write("Math Marks");
                        Console.WriteLine(arrResult[i, j] + " /100 ");
                        // SUM = SUM + arrResult[i, j];
                    }
                }
                double PassingMarks = 33;
                double Percentage = 0;
                double EngMark = Convert.ToDouble(arrResult[i, 2]);
                double UrduMark = Convert.ToDouble(arrResult[i, 3]);
                double MathMark = Convert.ToDouble(arrResult[i, 4]);
                SUM = EngMark + UrduMark + MathMark;
                Console.WriteLine("Total Number " + SUM + " /300");
                if (EngMark < PassingMarks)
                {
                    Console.WriteLine("Fail in English");
                }
                else if (UrduMark < PassingMarks)
                {
                    Console.WriteLine("Fail in Urdu");
                }
                else if (MathMark < PassingMarks)
                {
                    Console.WriteLine("Fail in Maths");
                }
                Percentage = SUM * 100 / 300;
                if (Percentage <= 100 && Percentage >= 80)
                {
                    Console.WriteLine("A1 Grade ");
                }
                else if (Percentage <= 79 && Percentage >= 70)
                {
                    Console.WriteLine("A Grade ");
                }
                else if (Percentage <= 69 && Percentage >= 60)
                {
                    Console.WriteLine("B Grade ");
                }
                else if (Percentage <= 59 && Percentage >= 50)
                {
                    Console.WriteLine("C Grade ");
                }
                else if (Percentage <= 49 && Percentage >= 40)
                {
                    Console.WriteLine("D Grade ");
                }
                else
                {
                    Console.WriteLine("You Got Less then 40 %");
                    Console.WriteLine("You are Failed");
                }
                Console.WriteLine("********");
            };
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("Press any number to Main Menue ..");
            try
            {
                int A = Convert.ToInt32(Console.ReadLine());
                Mainmenue();
            }
            catch (Exception ex)
            {
                Environment.Exit(1);
            }
        }
        public void MenuSelector(int A)
        {
            if (A == 1)
            {
                Mainmenue();
            }
            else if (A == 2)
            {
                AddStudent();
            }
            else if (A == 3)
            {
                ViewStudent();
            }
            else if (A == 4)
            {
                GenerateResult();
            }
            else if (A == 5)
            {
                Console.WriteLine("Thank you for using School Management System");
                Console.WriteLine("Preparing for Close");
                Console.Write("Good Bye");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Environment.Exit(1);
            }
            else if (A == 0)
            {
                start();
            }
        }
        public bool Login(string UserName, string Password)
        {
            if (UserName == "Admin" && Password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool start()
        {
            Console.Clear();
            Console.WriteLine("***********");
            Console.WriteLine("School Management System");
            Console.WriteLine("***********");
            Console.WriteLine();
            Console.WriteLine("Please Login");
            string Uname, Pass;
            Console.Write("User Name :");
            Uname = Console.ReadLine();
            Console.Write("Password :");
            Pass = Console.ReadLine();
            Program pp = new Program();
            bool Login = pp.Login(Uname, Pass);
            if (Login == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            bool Check = true;
            int PwdCounter = 0;
            do
            {
                Program pp = new Program();
                bool Login = pp.start();
                if (Login == true)
                {
                    Console.WriteLine("Welcom Admin. ");
                    Console.Write("Loading");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    pp.Mainmenue();
                }
                else
                {
                    if (PwdCounter == 3)
                    {
                        Console.WriteLine("Sorry your Password is expired..");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Credentials.. ");
                        Console.Write("    Please Try Again.");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(1000);
                        }
                        Check = false;
                        PwdCounter++;
                    }
                }
            } while (Check == false);
            Console.ReadKey();
        }
    }
}