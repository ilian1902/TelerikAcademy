namespace ShortestSequenceOfOperations
{
    using System;
    using System.Threading;

    public class Startup
    {
        public static void Main()
        {
            CalculateSteps();
        }

        private static void CalculateSteps()
        {
            var nConstant = GetUserInput("n");
            var mConstant = GetUserInput("m");
            Console.WriteLine();

            Console.WriteLine("N => \"{0}\" || M => \"{1}\"", nConstant, mConstant);
            Console.WriteLine();

            var result = FindShortestSequenceOfOperations(0, nConstant, mConstant);

            Console.WriteLine();
            Console.WriteLine("Calculated in {0} steps!", result);

            Console.WriteLine();
            Console.WriteLine("Press enter to exit!");
            Console.ReadLine();
        }

        private static int FindShortestSequenceOfOperations(int counter, int nConstant, int mConstant)
        {
            try
            {
                var sum = nConstant;
                if ((sum * 2) <= mConstant)
                {
                    counter += 1;
                    sum = nConstant * 2;
                    Console.WriteLine("{0}. {1} * 2 = {2}", counter, nConstant, sum);
                }
                else if ((sum + 2) <= mConstant)
                {
                    counter += 1;
                    sum = nConstant + 2;
                    Console.WriteLine("{0}. {1} + 2 = {2}", counter, nConstant, sum);
                }
                else if ((sum + 1) <= mConstant)
                {
                    counter += 1;
                    sum = nConstant + 1;
                    Console.WriteLine("{0}. {1} + 1 = {2}", counter, nConstant, sum);
                }

                if (sum != mConstant)
                {
                    counter = FindShortestSequenceOfOperations(counter, sum, mConstant);
                }
            }
            catch (StackOverflowException ex)
            {
                throw new StackOverflowException("Invalid numbers, please check range!", ex);
            }

            return counter;
        }

        private static int GetUserInput(string constant)
        {
            int number;
            Console.WriteLine("Please enter \"{0}\": ", constant);
            var constantAsString = Console.ReadLine();

            try
            {
                if (constantAsString == null)
                {
                    throw new ArgumentNullException();
                }

                number = int.Parse(constantAsString);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You cannot pass null argument! Please try again!");

                Thread.Sleep(1200);
                Console.Clear();
                number = GetUserInput(constant);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format! Please try again!");

                Thread.Sleep(1200);
                Console.Clear();
                number = GetUserInput(constant);
            }

            return number;
        }
    }
}
