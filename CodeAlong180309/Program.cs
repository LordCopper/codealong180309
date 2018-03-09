using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong180309
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunningProgram = true;
            while (keepRunningProgram == true)
            {
                Console.WriteLine("Welcome to the program.");
                Console.WriteLine("Please make your chooses by inputing the corresponding number");
                Console.WriteLine("1) Cinema");
                Console.WriteLine("2) Repeat");
                Console.WriteLine("3) Third Word");
                Console.WriteLine("0) Quit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Cinema();
                        break;
                    case "2":
                        Repeat();
                        break;
                    case "3":
                        ThirdWord();
                        break;
                    case "0":
                        keepRunningProgram = false;
                        break;
                    default:
                        Console.WriteLine("--INCORRECT INPUT TRY AGAIN--");
                        break;
                }
            }
        }

        public static void Cinema()
        {
            int movieGoerAge, groupSize, groupPrice = 0;
            string input;

            do
            {
                Console.WriteLine("How many will be attending the cinema:");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out groupSize));

            

            for (int i = 0; i < groupSize; i++)
            {
                do
                {
                    Console.WriteLine("Please enter the age of the movie goer (numericaly):");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out movieGoerAge));

                if (movieGoerAge < 20 || movieGoerAge > 64)
                {
                    if (movieGoerAge == 0 || movieGoerAge >= 100)
                    {
                        groupPrice = groupPrice + 0;
                    }
                    else if (movieGoerAge < 20)
                    {
                        groupPrice += 80;
                    }
                    else
                    {
                        groupPrice += 90;
                    }
                }
                else
                {
                    groupPrice += 120;
                }
            }
            Console.WriteLine("The total comes to: " + groupPrice);
            #region ex
            //if (movieGoerAge < 20 || movieGoerAge > 64)
            //{
            //    if (movieGoerAge == 0 || movieGoerAge >= 100)
            //    {
            //        Console.WriteLine("Congratulations, free ticket!");
            //    }
            //    else if (movieGoerAge < 20)
            //    {
            //        Console.WriteLine("Kids deal: 80kr");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Senior citizen discount: 90kr");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Standard Price: 120kr");
            //}

            //if (movieGoerAge < 20)
            //{
            //    Console.WriteLine("Kids deal: 80kr");
            //}
            //else if (movieGoerAge > 64)
            //{
            //    Console.WriteLine("Senior citizen discount: 90kr");
            //}
            //else
            //{
            //    Console.WriteLine("Standard Price: 120kr");
            //}
            #endregion
        }

        public static void Repeat()
        {
            Console.WriteLine("Just write like whatever:");
            string input = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "." + input + ", ");
            }
        }

        public static void ThirdWord()
        {
            while (true)
            {
                Console.WriteLine("Please enter a sentence with at least three words");
                string input = Console.ReadLine();
                string[] theWords =
                    input
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (theWords.Length >= 3)
                {
                    Console.WriteLine(theWords[2]);
                    break;
                }
            }
        }
    }
}
