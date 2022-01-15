using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Planner.Models
{
    class Building
    {
        //constructor - same name and return type as the class
        //overloading - same name on multiple methods but different signature/takes different arguments
        public Building()
        {

        }
        public Building(string address)
        {
            Address = address;
        }

        public Building(string address, double width, double depth, int stories)
        {
            Address = address;
            Width = width;
            Depth = depth;
            Stories = stories;
        }

        //fields
        private string _designer = "Mary Beth Hunter";
        private DateTime _dateConstructed;
        private string _owner;

        //public properties
        public string Address { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
            //or
            //get => Width * Depth * (3 * Stories);
        }

        //public methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void GiveDetails(string building)
        {
            Console.WriteLine($"{Address}------------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

        //@ - string verbatim - will take every keystroke literally including new lines (enter key)
        public void PrintToConsole()
        {
            string output = $@"
{Address}---------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space";

            Console.WriteLine(output);
        }
    }
}
