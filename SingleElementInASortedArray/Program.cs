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
            // This solution uses binary search
            // and the this solution is based on the following principles
            // if there is an array with digits that exactly appears twice (in which obviously we would end up with an even amount of digits)
            // the following are true:
            //      nums[evenIndex] == nums[evenIndex + 1];
            //      nums[evenIndex + 1] != nums[evenIndex + 2];
            // so now if we add a digit (that only appears once) in the array
            // only the digits after the added digit will not follow the mentioned statements
            
            int botIndex = 0;
            int topIndex = nums.Length - 1;

            while (botIndex < topIndex)
            {
                int midIndex = 2 * ((topIndex + botIndex) / 4);
                if (nums[midIndex] == nums[midIndex + 1])
                {
                    botIndex = midIndex + 2;
                }
                else
                {
                    topIndex = midIndex;
                }
            }
            return nums[botIndex];
        }
    }
}
