using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Planner.Models
{
    class City
    {
        //constructor (ctor tab 2x)
        public City(string name, string mayor)
        {
            cityName = name;
            mayorName = mayor;
        }

        public City()
        {
        }

        //fields
        private int _cityEstablished = DateTime.Now.Year;

        //properties (prop tab 2x)
        public List<Building> Buildings { get; set; }
        public string cityName { get; set; }
        public string mayorName { get; set; }

        //method
        //public void addBuilding(string building, int stories)
        //{
        //    if (Buildings == null)
        //    {
        //        Buildings = new List<Building>();
        //    }
        //    var buildingToAdd = new Building(building, stories);
        //    Buildings.Add(buildingToAdd);
        //    Console.WriteLine($"You have added {building} to your city.");
        //}

        public void cityDetails()
        {
            foreach (Building building in Buildings)
            {
                Console.WriteLine($"{building.Address} is located in {cityName} where {mayorName} is the mayor. It is {building.Stories} stories tall!");
            }
        }

        //brian's example
        public void AddBuilding(Building building)
        {
            //stub out your class (make basic outline/put the methods you're going to need but don't have any code in yet)
            //TODO - define method logic (common to include TODO comments also)
            //throw new NotImplementedException("The AddBuilding method is not yet defined.");

            Buildings.Add(building);
        }

        public void AddBuilding(string address, double width, double depth, int stories)
        {
            if (Buildings == null)
            {
                Buildings = new List<Building>();
            }
            var building = new Building(address, width, depth, stories);
            Buildings.Add(building);
        }

        public void ListBuildings()
        {
            foreach (var building in Buildings)
            {
                building.PrintToConsole();
            }
        }

        public void PrintToConsole()
        {
            Console.WriteLine($@"
City Name: {cityName}
Mayor: {mayorName}
Year Established: {_cityEstablished}");
        }
    }
}
