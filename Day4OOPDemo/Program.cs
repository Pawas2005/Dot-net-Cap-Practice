using Day4OOPDemo;

namespace OOPS
{
    // class Program
    // {
    //     static void Main()
    //     {
    //         UserDefinedTypes udt = new UserDefinedTypes();
    //         Emp obj = udt.GetEmpDetails(1001);
    //         Console.WriteLine(obj.id + " " + obj.name + " " + obj.job + " " + obj.sal + " " + obj.status);
    //         Console.ReadLine();
    //     }
    // }

    internal class Program
    {
        //Non-value returning method without parameters  
        public void Test1() //Static in behavior   
        {
            int x = 5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }
        }

        //Non-value returning method with parameters 
        public void Test2(int x, int ub) //Dynamic in behavior       
        {
            for (int i = 1; i <= ub; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }
        }

        //Value returning method without parameters 
        public string Test3() //Static in behavior   
        {
            string str = "hello world";
            str = str.ToUpper();
            return str;
        }

        //Value returning method with parameters 
        public string Test4(string str) //Dynamic in behavior   
        {
            str = str.ToUpper();
            return str;
        }

        static void Main()
        {
            Program p = new Program();
            
            //Calling non-value returning methods. 
            p.Test1();
            Console.WriteLine();
            p.Test2(8, 15);
            Console.WriteLine();

            //Calling value returning methods 
            string s1 = p.Test3();
            Console.WriteLine(s1);
            string s2 = p.Test4("hello india");
            Console.WriteLine(s2);
        }
    }
}