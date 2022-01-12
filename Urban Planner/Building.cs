using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Planner
{
    class Building
    {
        //constructor
        //overloading - same name on multiple methods but different signature/takes different arguments
        public Building()
        {

        }
        public Building(string address)
        {
            _address = address;
        }

        //fields
        private string _designer = "Mary Beth Hunter";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        //public properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        private double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
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
            Console.WriteLine($"{_address}------------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

        //@ - string verbatim - will take every keystroke literally including new lines (enter key)
        public void GiveDetails()
        {
            string output = $@"
{_address}---------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space";

            Console.WriteLine(output);
        }
    }
}
