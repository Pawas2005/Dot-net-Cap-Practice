// See https://aka.ms/new-console-template for more information
using InterfaceDemoProj;

Console.WriteLine("Demo on Interfaces");

// // MathClass m1 = new MathClass(); //Alok- Add
// IAdd m1 = new MathClass(); //for calling interface

// // MathClass m2 = new MathClass(); //Riya- Add, Sub
// IAddSub m2 = new MathClass();

// // MathClass m3 = new MathClass(); //Rajat- Add, Sub, Prod, Div
// IAll m3 = new MathClass();

//Approach 1
// Product pObj = new Product();

// pObj.ProdID = 101;
// pObj.Name = "Brossil Flask";
// pObj.Price = 899;


//Approach 2
//Object Init
Product pObj1 = new Product(){ProdID=102,Name="Luxor Marker",Price=77};

//Collection Init
List<Product> prodList = new List<Product>()
{
    new Product(){ProdID=101,Name="Luxor Marker",Price=77},
    new Product(){ProdID=102,Name="Max Don",Price=7777},
    new Product(){ProdID=103,Name="Chota Don",Price=777},
    new Product(){ProdID=104,Name="Bada Don",Price=999},
    new Product(){ProdID=105,Name="hotwheel Toy",Price=299},
    new Product(){ProdID=106,Name="Kamasutra Deo",Price=199},
};

foreach (var item in prodList)
{
    System.Console.WriteLine($"{item.ProdID}\t{item.Name}\t{item.Price}");
}