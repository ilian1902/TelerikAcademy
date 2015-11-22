namespace CombinationNKSet
{
    using System;

    public class Startup
    {
        private const int N = 3;
        private const int K = 2;

        private static readonly string[] Set = { "hi", "a", "b" };

        private static readonly int[] Arr = new int[K];
        
        public static void Main()
        {
            ////  5.Write a recursive program for generating and printing all ordered
            ////  k - element subsets from n-element set(variations Vkn).
            ////       Example: n = 3, k = 2, set = { hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a),
            ////                                                  (a b), (b hi), (b a), (b b)
            
            GenerateCombinations(0);
        }

        private static void GenerateCombinations(int index)
        {
            if (index >= K)
            {
                PrintCombinations();
                return;
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    Arr[index] = i;
                    GenerateCombinations(index + 1);
                }
            }
        }

        private static void PrintCombinations()
        {
            Console.Write("( ");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Set[Arr[i]] + " ");
            }

            Console.WriteLine(")");
        }
    }
}
