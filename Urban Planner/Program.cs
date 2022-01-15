using System;
using Urban_Planner.Models;

namespace Urban_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate - use the "new" keyword to create an instance of an object
            //initialize - give an instance an initial value

            Building FiveOneTwoEight = new Building("512 8th Avenue")
            {
                Width = 20,
                Depth = 40,
                Stories = 4
            };

            Building TwoSixFourNine = new Building("264 9th Avenue")
            {
                Width = 10,
                Depth = 50,
                Stories = 2
            };

            Building ThreeSevenTwoOne = new Building("372 1st Avenue")
            {
                Width = 50,
                Depth = 100,
                Stories = 10
            };

            Building FourFourFourThree = new Building("444 3rd Avenue")
            {
                Width = 100,
                Depth = 200,
                Stories = 20
            };

            FiveOneTwoEight.Construct();
            TwoSixFourNine.Construct();
            ThreeSevenTwoOne.Construct();
            FourFourFourThree.Construct();

            FiveOneTwoEight.Purchase("Mary Beth Hunter");
            TwoSixFourNine.Purchase("Skye Duff");
            ThreeSevenTwoOne.Purchase("Lauren Hignite");
            FourFourFourThree.Purchase("Jennifer Meadows");

            //FiveOneTwoEight.GiveDetails("512 8th Avenue");
            //Console.WriteLine(" ");
            //TwoSixFourNine.GiveDetails("264 9th Avenue");
            //Console.WriteLine(" ");
            //ThreeSevenTwoOne.GiveDetails("372 1st Avenue");
            //Console.WriteLine(" ");
            //FourFourFourThree.GiveDetails("444 3rd Avenue");
            //Console.WriteLine(" ");

            FiveOneTwoEight.GiveDetails();
            TwoSixFourNine.GiveDetails();
            ThreeSevenTwoOne.GiveDetails();
            FourFourFourThree.GiveDetails();
        }
    }
}
