using System;
using System.Xml.Schema;
namespace StudentMngmtSystem
{
    public class StudentBL
    {
        Student sObj = null;
        public StudentBL()
        {
            sObj = new Student();
        }
        public void AcceptStudentDetails()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine("  Student Management System  ");
                System.Console.WriteLine("==================================");

                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.Write("Enter Your RollNo : ");
                sObj.RollNo = Int32.Parse(Console.ReadLine());

                System.Console.Write("Enter Your Name : ");
                sObj.Name = Console.ReadLine();

                System.Console.Write("Enter Your Address : ");
                sObj.Address = Console.ReadLine();

                System.Console.Write("Enter Your Physics Marks : ");
                sObj.Phy = Int32.Parse(Console.ReadLine());

                System.Console.Write("Enter Your Chemistry Marks : ");
                sObj.Chem = Int32.Parse(Console.ReadLine());

                System.Console.Write("Enter Your Mathematics Marks : ");
                sObj.Maths = Int32.Parse(Console.ReadLine());
            }
            catch (InvalidMarksException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.Message);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        public int calcTotal()
        {
            sObj.Total = sObj.Phy + sObj.Chem + sObj.Maths;
            return sObj.Total;
        }

        public float CalcAvg()
        {
            sObj.Perc = sObj.Total / 3;
            return sObj.Perc;
        }

        public void CalcResult(out int myTotal, out float myPerc)
        {
            myTotal = sObj.Phy + sObj.Chem + sObj.Maths;
            myPerc = myTotal / 3;
        }
    }
}