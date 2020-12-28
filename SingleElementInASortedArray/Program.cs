using System;

namespace SingleElementInASortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsExampleOne = new int[] {1,1,2,3,3,4,4,8,8}; // Output should be 2
            int[] numsExampleTwo = new int[] {3,3,7,7,10,11,11}; // Output should be 10

            Console.WriteLine($"Output should be 2: {SingleNonDuplicate(numsExampleOne)}");
            Console.WriteLine($"Output should be 10: {SingleNonDuplicate(numsExampleTwo)}");
        }

        public static int SingleNonDuplicate(int[] nums)
        {
            return 3;
        }
    }
}
