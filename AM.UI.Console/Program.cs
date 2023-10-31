// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");

Plane plane = new Plane();
plane.Capacity = 100;
plane.ManufactureDate = DateTime.Now;
plane.PlaneType = PlaneType.Boeing;

//Initialiseur d'objets
Plane plane2 = new Plane { Capacity=200
                          ,ManufactureDate= new DateTime(2023,09,17)
                          , PlaneType=PlaneType.Airbus};
//Afficher plane1
Console.WriteLine(plane2);