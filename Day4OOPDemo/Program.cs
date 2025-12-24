using Day4OOPDemo;

namespace OOPS
{
    class Program
    {
        static void Main()
        {
            UserDefinedTypes udt = new UserDefinedTypes();
            Emp obj = udt.GetEmpDetails(1001);
            Console.WriteLine(obj.id + " " + obj.name + " " + obj.job + " " + obj.sal + " " + obj.status);
            Console.ReadLine();
        }
    }
}