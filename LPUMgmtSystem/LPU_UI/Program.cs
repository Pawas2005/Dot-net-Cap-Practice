using LPU_BL;
using LPU_Entity;
using LPU_Exceptions;
using System;

namespace LPU_UI
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("\nStudent Management System");
            Console.WriteLine("================================");
            Console.WriteLine("1. Search Student By ID ");
            Console.WriteLine("2. Show All Students");
            Console.WriteLine("3. Add Student Details");
            Console.WriteLine("4. Update Student Details");
            Console.WriteLine("5. Drop Student Details");
            Console.WriteLine("6. Exit");
        }
        static void Main(string[] args)
        {
            StudentBL sblObj = null;
            sblObj = new StudentBL();
            bool exitProgram = false;

            do
            {
                try
                {
                    Menu();
                    int choice = 0;
                    Console.Write("Enter your choice : ");
                    choice = Int32.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: //Search Student By ID
                            {
                                try
                                {
                                    int id = 0;
                                    Console.Write("Enter Student ID to search : ");
                                    id = Int32.Parse(Console.ReadLine());

                                    Student sObj = sblObj.SearchStudentByID(id);

                                    if (sObj != null)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nID\t| Name\t\t| Course\t| Address");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("--------------------------------------------------------");
                                        Console.WriteLine($"{sObj.StudentID}\t| {sObj.Name}\t\t| {sObj.Course}\t\t| {sObj.Address}");
                                    }
                                }
                                catch (LPUException ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Error: {ex.Message}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                catch (FormatException)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Error: Please enter a valid numeric ID.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                break;
                            }

                        case 2: //Show All Students
                            {
                                try
                                {
                                    Console.Write("Enter Student Name to search (or press Enter to show all): ");
                                    string name = Console.ReadLine();
                                    
                                    List<Student> studList = sblObj.SearchStudentByName(name);

                                    if (studList != null && studList.Count > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nID\t| Name\t\t| Course\t| Address");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("--------------------------------------------------------");
                                        
                                        foreach (Student s in studList)
                                        {
                                            Console.WriteLine($"{s.StudentID}\t| {s.Name}\t\t| {s.Course}\t\t| {s.Address}");
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("No students found with that name.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                catch (LPUException ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Error: {ex.Message}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                break;
                            }

                        case 3: //Add Students
                            {
                                try
                                {
                                    Student newStudent = new Student();

                                    Console.Write("Enter Student ID: ");
                                    newStudent.StudentID = Int32.Parse(Console.ReadLine());

                                    Console.Write("Enter Student Name: ");
                                    newStudent.Name = Console.ReadLine();

                                    Console.WriteLine("Select Course:");
                                    Console.WriteLine("1. Mechanical (10)");
                                    Console.WriteLine("2. Electrical (20)");
                                    Console.WriteLine("3. Civil (30)");
                                    Console.WriteLine("4. CSE (40)");
                                    Console.WriteLine("5. IT (50)");
                                    Console.Write("Enter course choice: ");
                                    int courseChoice = Int32.Parse(Console.ReadLine());

                                    switch (courseChoice)
                                    {
                                        case 1:
                                            newStudent.Course = CourseType.Mechanical;
                                            break;
                                        case 2:
                                            newStudent.Course = CourseType.Electrical;
                                            break;
                                        case 3:
                                            newStudent.Course = CourseType.Civil;
                                            break;
                                        case 4:
                                            newStudent.Course = CourseType.CSE;
                                            break;
                                        case 5:
                                            newStudent.Course = CourseType.IT;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Invalid course selection. Defaulting to CSE.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            newStudent.Course = CourseType.CSE;
                                            break;
                                    }

                                    Console.Write("Enter Student Address: ");
                                    newStudent.Address = Console.ReadLine();

                                    bool result = sblObj.EnrollStudent(newStudent);

                                    if (result)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Student added successfully!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                catch (LPUException ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Error: {ex.Message}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                catch (FormatException)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Error: Please enter valid input.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                break;
                            }

                        case 4: //Update Student
                            {
                                try
                                {
                                    int id = 0;
                                    Console.Write("Enter Student ID to update: ");
                                    id = Int32.Parse(Console.ReadLine());

                                    Student updatedStudent = new Student();
                                    updatedStudent.StudentID = id;

                                    Console.Write("Enter New Student Name: ");
                                    updatedStudent.Name = Console.ReadLine();

                                    Console.WriteLine("Select New Course:");
                                    Console.WriteLine("1. Mechanical (10)");
                                    Console.WriteLine("2. Electrical (20)");
                                    Console.WriteLine("3. Civil (30)");
                                    Console.WriteLine("4. CSE (40)");
                                    Console.WriteLine("5. IT (50)");
                                    Console.Write("Enter course choice: ");
                                    int courseChoice = Int32.Parse(Console.ReadLine());

                                    switch (courseChoice)
                                    {
                                        case 1:
                                            updatedStudent.Course = CourseType.Mechanical;
                                            break;
                                        case 2:
                                            updatedStudent.Course = CourseType.Electrical;
                                            break;
                                        case 3:
                                            updatedStudent.Course = CourseType.Civil;
                                            break;
                                        case 4:
                                            updatedStudent.Course = CourseType.CSE;
                                            break;
                                        case 5:
                                            updatedStudent.Course = CourseType.IT;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Invalid course selection. Defaulting to CSE.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            updatedStudent.Course = CourseType.CSE;
                                            break;
                                    }

                                    Console.Write("Enter New Student Address: ");
                                    updatedStudent.Address = Console.ReadLine();

                                    bool result = sblObj.UpdateStudentDetails(id, updatedStudent);

                                    if (result)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Student updated successfully!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                catch (LPUException ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Error: {ex.Message}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                catch (FormatException)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Error: Please enter valid input.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                break;
                            }

                        case 5: //Drop Student
                            {
                                try
                                {
                                    int id = 0;
                                    Console.Write("Enter Student ID to delete: ");
                                    id = Int32.Parse(Console.ReadLine());

                                    Console.Write("Are you sure you want to delete this student? (Y/N): ");
                                    string confirmation = Console.ReadLine();

                                    if (confirmation.ToUpper() == "Y")
                                    {
                                        bool result = sblObj.DropStudentDetails(id);

                                        if (result)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Student deleted successfully!");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Delete operation cancelled.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                catch (LPUException ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Error: {ex.Message}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                catch (FormatException)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Error: Please enter a valid numeric ID.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                break;
                            }

                        case 6: //Exit
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Thank you for using Student Management System. Goodbye!");
                                Console.ForegroundColor = ConsoleColor.White;
                                exitProgram = true;
                                break;
                            }

                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Invalid choice. Please select a valid option (1-6).");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Please enter a valid numeric choice.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (!exitProgram);
        }
    }
}