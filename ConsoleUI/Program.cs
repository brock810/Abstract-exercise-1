using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        { 
                var vehicles = new List<Vehicle>();

                var car = new Car();
                car.Year = 2022;
                car.Make = "Tesla";
                car.Model = "Model S";
                car.HasTrunk = true;

                var motorcycle = new Motorcycle();
                motorcycle.Model = "Harley";
                motorcycle.Make = "Davison";
                motorcycle.Year = 1894;
                motorcycle.HasSideCart = true;

                Vehicle sedan = new Car();
                sedan.Year = 2003;
                sedan.Make = "Toyota";
                sedan.Model = "Camry";
                sedan.HasTrunk = true;

                Vehicle coup = new Car();
                coup.Year = 2011;
                coup.Make = "Subaru";
                coup.Model = "BRZ";
                coup.HasTrunk = true;
           

                vehicles.Add(car);
                vehicles.Add(motorcycle);
                vehicles.Add(sedan);
                vehicles.Add(coup);

                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine($"Year: {vehicle.Year}  Make: {vehicle.Make}  Model: {vehicle.Model}");
                    vehicle.DriveAbstract();
                    vehicle.DriveVirtual();
                    Console.WriteLine();
                }

                car.DriveAbstract();
                motorcycle.DriveVirtual();


                Console.ReadLine();
            }
        }
    }