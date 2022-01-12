using System;

namespace Urban_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue");
            Building TwoSixFourNine = new Building("264 9th Avenue");
            Building ThreeSevenTwoOne = new Building("372 1st Avenue");
            Building FourFourFourThree = new Building("444 3rd Avenue");

            FiveOneTwoEight.Width = 20;
            FiveOneTwoEight.Depth = 40;
            FiveOneTwoEight.Stories = 4;

            TwoSixFourNine.Width = 10;
            TwoSixFourNine.Depth = 50;
            TwoSixFourNine.Stories = 2;

            ThreeSevenTwoOne.Width = 50;
            ThreeSevenTwoOne.Depth = 100;
            ThreeSevenTwoOne.Stories = 10;

            FourFourFourThree.Width = 100;
            FourFourFourThree.Depth = 200;
            FourFourFourThree.Stories = 20;

            FiveOneTwoEight.Construct();
            TwoSixFourNine.Construct();
            ThreeSevenTwoOne.Construct();
            FourFourFourThree.Construct();

            FiveOneTwoEight.Purchase("Mary Beth Hunter");
            TwoSixFourNine.Purchase("Skye Duff");
            ThreeSevenTwoOne.Purchase("Lauren Hignite");
            FourFourFourThree.Purchase("Jennifer Meadows");

            FiveOneTwoEight.GiveDetails("512 8th Avenue");
            Console.WriteLine(" ");
            TwoSixFourNine.GiveDetails("264 9th Avenue");
            Console.WriteLine(" ");
            ThreeSevenTwoOne.GiveDetails("372 1st Avenue");
            Console.WriteLine(" ");
            FourFourFourThree.GiveDetails("444 3rd Avenue");
            Console.WriteLine(" ");
        }
    }
}
