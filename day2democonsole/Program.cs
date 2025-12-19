using System;
using Day2DemoConsole;  //for calling Student.cs file

class Program
{
    static void Main()
    {
        // Student sObj = new Student(123, "Alok", "Delhi");
        // sObj.DisplayDetails(sObj);

        // string[] cities = { "Pune", "Noida", "Gurgaon", "Patna" };

        // int i = 0;
        // while (i < cities.Length)
        // {
        //     Console.WriteLine(cities[i]);
        //     i++;
        // }

        //// foreach: used for printing array/collection
        // foreach (var item in cities)
        // {
        //     Console.WriteLine(item);
        // }

        // // 1.Calling HeightCategory.cs file
        // HeightCategory.HeightCategory.Run();

        // // 2.Calling Largest3.cs file 
        // largest.largest3.Run();

        //// 3.Calling LeapYr.cs file 
        //Leap.LeapYr.Run();

        // // 4.Calling QuadEqn.cs file 
        // Quad.QuadEqn.Run();

        // 5. calling AdmElg.cs file
        // admsn.admsnElg.Run();

        // //6. Calling Bills.cs file
        // bill.Ebills.Run();

        //7. Calling VowOrCon.cs file
        VowCon.VowORCon.Run();
    }
}