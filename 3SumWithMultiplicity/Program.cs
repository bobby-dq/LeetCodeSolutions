using System;

namespace _3SumWithMultiplicity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputA = {1,1,2,2,3,3,4,4,5,5};
            int targetA = 8;

            int[] inputB = {1,1,2,2,2,2};
            int targetB = 5;

            Console.WriteLine($"This should be 20: {ThreeSumMulti(inputA, targetA)}");
            Console.WriteLine($"This should be 12: {ThreeSumMulti(inputB, targetB)}");
        }
        public int ThreeSumMulti(int [] A, int target)
        {
            return default;
        }
    }
}
