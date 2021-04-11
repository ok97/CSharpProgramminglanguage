using System;

namespace MultiplePrograms
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("********* Choice Any One Program *********\n\n" + 
                "--------- 1.Replace String---------\nProgram User input and Replace String Template Hello<<UserName>>,How are you?\n \n" +
                "--------- 2.Flip Coin ---------\nFlip coin and print Percentage of Heads and Tails \n\n" +
                "--------- 3.Leap Year ---------\nEnter Any Year to check Year is Leap Year or Not\n\n" +
                "--------- 4.Power Of Two Function ---------\nThis Program takes a command-line argument N and prints a table of the Power\nof 2 that are less than or equal to 2 ^ N(Using Pow Method ).\n\n" +
                "--------- 5.Power Of Two ---------\nThis Program takes a command-line argument N and prints a table of the Power\nof 2 that are less than or equal to 2 ^ N.(Using For Loop ).\n\n" +
                "--------- 6.Harmonic ---------\nProgram to find sum of harmonic series 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms \n\n" +
                "--------- 7.Prime Factorization ---------\nCompute the prime factorization of N using brute force.\n\n" +
                "--------- 8.MultiDimentional ---------\n A library for reading in 2D arrays of Integers, double, or Booleans from standard\ninput and Printing them out to standard output.\n\n" +
                "--------- 9.Sum Of Triplet Value Zero ---------\nRead in N integer and counts the number of triples that sum to exactly 0.\n\n" +
                "--------- 10.Euclidean Distance ---------\nDistance that take two integer command-line arguments x, y and print the\nEuclideanln from the point (x, y) to the origin(0, 0).\n\n" +
                "--------- 11.QuadraticRoot ---------\nProgram Quadratic to find the roots of the equation a*x*x + b*x + c.\n \n" +
                "--------- 12.WindChill ---------\nProgram that takes two double command-line arguments t and v and prints the wind chill\n\n" +
                "--------- 13.Gambler ---------\nSimulates a gambler who start with $stake and place fair $1 bets untill he/she goes broke\n(i.e., has no money) or reach $goal.Keeps track of the number of times he / she wins and \nthe number of bets he / she makes.Run the experiment N times average the result and print of times out.\n\n" +
                "--------- 14.Read Num Of Coupons ---------\nGiven N Distinct Coupon Numbers, how many random numbers do you need to generate\ndistinct coupon number ? This program simulates this random process.\n\n" +
                "--------- 15.Stop Watch ---------\nProgram for measuring the time that elapses between the start and end clicks\n\n" +
                "--------- 16.Vending Machine ---------\nHere is 1,2,5,500 and 1000 Rs Notes which can be returned by Vending Machine.\nWrite program to calculate the minimum number of Notes as well as the Notes to be returned by \nthe vending Machine as a Change.\n\n" +
                "--------- 17.TicTacToe ---------\nProgram to play a Cross Game or Tic-Tac-Toe Game. Player 1 is the Computer and the\nPlayer 2 is the user. Player 1 take Random Cell that is the Column and Row.\n\n" +
                "--------- 18.Sum Of Triplet Unique Value ---------\nRead in N integer and counts the number of triples that sum to exactly 0\n\nEnter any One Program Number:- ");
            int Number = Convert.ToInt32(Console.ReadLine());
            switch (Number)
            {
                case 1:
                    ReplaceString replace = new ReplaceString();
                    replace.ReadInput();
                    Console.Read();
                    break;
                case 2:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.ReadInput();
                    Console.Read();
                    break;
                case 3:
                    LeapYear leapYear = new LeapYear();
                    leapYear.ReadInput();
                    Console.Read();
                    break;
                case 4:
                    poweroftwofunction.PowerFunction();
                    Console.Read();
                    break;
                case 5:
                    Poweroftwo poweroftwo = new Poweroftwo();
                    poweroftwo.ReadInput();
                    Console.Read();
                    break;
                case 6:
                    Harmonic harmonic = new Harmonic();
                    harmonic.ReadInput();
                    Console.Read();
                    break;
                case 7:
                    PrimeFactorization PrimeFactor = new PrimeFactorization();
                    PrimeFactor.ReadInput();
                    Console.Read();
                    break;
                case 8:
                    MultiDimentional TwoDimentionalarray = new MultiDimentional();
                    TwoDimentionalarray.ReadMultiArray();
                    Console.Read();
                    break;
                case 9:
                    SumOFTripletValueZero FindTriplets = new SumOFTripletValueZero();
                    FindTriplets.ReadInput();
                    Console.Read();
                    break;
                case 10:
                    EuclideanDistance Distance = new EuclideanDistance();
                    Distance.ReadInput();
                    Console.Read();
                    break;

                case 11:
                    QuadraticRoot quadraticRoot = new QuadraticRoot();
                    quadraticRoot.ReadInput();
                    Console.Read();
                    break;
                case 12:
                    WindChill windhill = new WindChill();
                    windhill.ReadInput();
                    Console.Read();
                    break;
                case 13:
                    Gambler FindWinLose = new Gambler();
                    FindWinLose.ReadInput();
                    Console.Read();
                    break;
                case 14:
                    ReadNumOfCoupons coupons = new ReadNumOfCoupons();
                    coupons.ReadInput();
                    Console.Read();
                    break;
                case 15:
                    StopWatch.Stpwatchout();
                    Console.Read();
                    break;
                case 16:
                    VendingMachine VMachine = new VendingMachine();
                    VMachine.ReadInput();
                    Console.Read();
                    break;
                case 17:
                    TicTacToe tic = new TicTacToe();
                    TicTacToe.TicTacToeGame();
                    Console.Read();
                    break;
                case 18:
                    Extra tripple = new Extra();
                    tripple.ReadInput();
                    Console.Read();
                    break;

            }

            //ReplaceString replace = new ReplaceString();
            //replace.ReadInput();
            //Console.Read();


            // FlipCoin flipCoin = new FlipCoin();
            //flipCoin.ReadInput();
            // Console.Read();


            //LeapYear leapYear = new LeapYear();
            //leapYear.ReadInput();
            //Console.Read();


            //Poweroftwo poweroftwo = new Poweroftwo();
            // poweroftwo.ReadInput();
            //Console.Read();

            //poweroftwofunction.PowerFunction();
            // Console.Read();

            //Harmonic harmonic = new Harmonic();
            //harmonic.ReadInput();
            //Console.Read();

            //PrimeFactorization PrimeFactor = new PrimeFactorization();
            //PrimeFactor.ReadInput();
            //Console.Read();

            //MultiDimentional TwoDimentionalarray = new MultiDimentional();
            //TwoDimentionalarray.ReadMultiArray();
            //Console.Read();


            // SumOFTripletValueZero FindTriplets = new SumOFTripletValueZero();
            //FindTriplets.ReadInput();
            // Console.Read();


            //EuclideanDistance Distance = new EuclideanDistance();
            //Distance.ReadInput();
            //Console.Read();

            //QuadraticRoot quadraticRoot = new QuadraticRoot();
            // quadraticRoot.ReadInput();
            //Console.Read();



            //WindChill windhill = new WindChill();
            //windhill.ReadInput();
            //Console.Read();


            //Gambler FindWinLose = new Gambler();
            // FindWinLose.ReadInput();
            // Console.Read();


            //ReadNumOfCoupons coupons = new ReadNumOfCoupons();
            //coupons.ReadInput();
            // Console.Read();

            //StopWatch.Stpwatchout();
            //Console.Read();

            // VendingMachine VMachine = new VendingMachine();
            // VMachine.ReadInput();
            // Console.Read();


            //Extra tripple = new Extra();
            //tripple.ReadInput();
            //Console.Read();


            // TicTacToe tic = new TicTacToe();
            // TicTacToe.TicTacToeGame();
            //Console.Read();




        }
    }
}
