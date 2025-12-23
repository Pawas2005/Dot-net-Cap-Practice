// Problem Statement: Employee Access & Salary Processing System
// Develop a menu-driven Java program for a company to process employee details and determine role, access level, and final salary.

using System;
using System.Security.Cryptography;

namespace Employee
{
    public class Employee
    {
        public static void Run()
        {
            //Step 1: Input Details
            Console.Write("Enter your Employee ID: ");
            int EmpID = int.Parse(Console.ReadLine());

            Console.Write("Enter the Name: ");
            string EmpName = Console.ReadLine();

            Console.Write("Enter the Age: ");
            int EmpAge = int.Parse(Console.ReadLine());

            //Step 2: Age Validation
            if(EmpAge < 21)
            {
                Console.Write("Employee is not eligible to work.");
                return; //stop execution
            }

            //Step 3: Department & Role Selection (Nested Switch)
            Console.WriteLine("Select Department: ");
            Console.WriteLine("1. IT");
            Console.WriteLine("2. HR");
            Console.WriteLine("3. Finance");
            int DeptChoice = int.Parse(Console.ReadLine());

            Console.Write("Enter Basic Salry: ");
            double basicSal = double.Parse(Console.ReadLine());

            String department = "";
            String role = "";
            double allowance = 0;

            switch (DeptChoice)
            {
                case 1:
                    department = "IT";
                    Console.WriteLine("1. Developer");
                    Console.WriteLine("2. Tester");
                    int itRole = int.Parse(Console.ReadLine());

                    switch (itRole)
                    {
                        case 1:
                            role = "Developer";
                            allowance = 30;
                            break;
                        case 2:
                            role = "Tester";
                            allowance = 25;
                            break;
                        default:
                            Console.WriteLine("Invalid IT Role.");
                            return;
                    }
                    break;
                
                case 2:
                    department = "HR";
                    Console.WriteLine("1. Recruiter.");
                    Console.WriteLine("2. Payroll");
                    int hrRole = int.Parse(Console.ReadLine());

                    switch (hrRole)
                    {
                        case 1:
                            role = "Recruiter";
                            allowance = 20;
                            break;
                        case 2:
                            role = "Payroll";
                            allowance = 22;
                            break;
                        default:
                            Console.WriteLine("Invalid HR Role.");
                            return;
                    }
                    break;
                
                case 3:
                    department = "Finance";
                    Console.WriteLine("1. Accountant.");
                    Console.WriteLine("2. Auditor");
                    int FinanceRole = int.Parse(Console.ReadLine());

                    switch (FinanceRole)
                    {
                        case 1:
                            role = "Accountant";
                            allowance = 28;
                            break;
                        case 2:
                            role = "Auditor";
                            allowance = 26;
                            break;
                        default:
                            Console.WriteLine("Invalid Finance Role.");
                            return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Department.");
                    return;
            }

            //Step 4: Salary Calculation
            double FinalSal = basicSal + (basicSal * allowance / 100);

            //Step5: Access Level Decision
            string accessLevel;

            if(FinalSal >= 60000 && department == "IT")
            {
                accessLevel = "Admin Access";
            }
            else if(FinalSal >= 60000)
            {
                accessLevel = "Manager Access";
            }
            else
            {
                accessLevel = "Employee Access";
            }

            //step6: Output
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine("Employee ID: " + EmpID);
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine("Employee Department: " + department);
            Console.WriteLine("Employee Role: " + role);
            Console.WriteLine("Employee Basic Salary: " + basicSal);
            Console.WriteLine("Employee Final Salary: " + FinalSal);
            Console.WriteLine("Access Level: " + accessLevel);
        }
    }
}