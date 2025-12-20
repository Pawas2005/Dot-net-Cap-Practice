// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using StudentMngmtSystem;

StudentBL sBLobj = new StudentBL();

sBLobj.AcceptStudentDetails();
// sBLobj.calcTotal();
// sBLobj.CalcAvg();

int t1; //for Total
float p1; //for Percentage
sBLobj.CalcResult(out t1, out p1);

System.Console.Write($"Total:  {t1}");
Console.WriteLine();
System.Console.Write($"Percentage:  {p1}");