namespace MathProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal static class MathProblemExam
    {
        internal static string DecimalIn19(ulong number)
        {
            StringBuilder digits = new StringBuilder();

            ulong numeralSystem = 19;

            do
            {
                ulong digit = number % numeralSystem;
                digits.Insert(0, ConverNumInChar(digit));
                number /= numeralSystem;
            }
            while (number > 0);

            return digits.ToString();
        }

        internal static string ConverNumInChar(ulong number)
        {
            switch (number)
            {
                case 0: return "a";
                case 1: return "b";
                case 2: return "c";
                case 3: return "d";
                case 4: return "e";
                case 5: return "f";
                case 6: return "g";
                case 7: return "h";
                case 8: return "i";
                case 9: return "j";
                case 10: return "k";
                case 11: return "l";
                case 12: return "m";
                case 13: return "n";
                case 14: return "o";
                case 15: return "p";
                case 16: return "q";
                case 17: return "r";
                case 18: return "s";

                default:
                    return null;
            }
        }

        internal static long PowerOfNineTeen(int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 19;
            }

            return result;
        }

        internal static ulong Convert19NumericSystem(string catsSystem)
        {
            ulong result = 0;
            var digit = new List<ulong>();

            foreach (var ch in catsSystem)
            {
                digit.Add((ulong)ch - 'a');
            }

            for (int i = 0; i < catsSystem.Length; i++)
            {
                result *= 19;
                result += digit[i];
            }

            return result;
        }

        private static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            string word = string.Empty;

            var digitInInt = new List<ulong>();
            ulong sumInDecimal = 0;

            StringBuilder numberOfWordIn19 = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                digitInInt.Add(Convert19NumericSystem(words[i]));
            }

            for (int i = 0; i < digitInInt.Count; i++)
            {
                sumInDecimal += digitInInt[i];
            }

            StringBuilder sumIn19 = new StringBuilder();

            sumIn19.Append(DecimalIn19(sumInDecimal));

            Console.WriteLine("{0} = {1}", sumIn19.ToString(), sumInDecimal);
        }
    }
}
