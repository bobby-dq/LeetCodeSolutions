using System;
using System.Collections.Generic;
using static System.Math;

namespace FindMinDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the test subject    
            List<string> strings = new List<string>()
            {
                "05:31","22:08","00:35"
            };
            Console.WriteLine(TestMethod(strings));

        }

        static int TestMethod(List<string> timePoints)
        {


            List<int> timePointsInMins = new List<int>(); 

            // Parses each string data in timePoints list (eg. "23:59") into minutes (eg. 1439).
            for (int i = 0; i < timePoints.Count; i++)
            {
                int hoursToMins = Int32.Parse(timePoints[i].Substring(0,2))*60;
                int mins = Int32.Parse(timePoints[i].Substring(3));
                timePointsInMins.Add(hoursToMins+mins);
            }

            // Sorts the items in the timePointsInMins list in ascending order.
            timePointsInMins.Sort();

            // The initial value of variable "difference"
            // is the difference betweeen the last item and the first item in the timePointsInMins list
            int difference = (1440 - timePointsInMins[timePoints.Count - 1]) + timePointsInMins[0];

            // The difference between each item and the item after it is compared to variable "difference"
            // If less than the current value of variable "difference", this will be the new value for the variable "difference"
            // The difference between the last item and the first item is not included in this loop, since it was already calculated above.
            for (int i = 0; i < timePointsInMins.Count - 1; i++)
            {
                int differenceCheck = timePointsInMins[i+1] - timePointsInMins[i];
                if (differenceCheck < difference)
                {
                    difference = differenceCheck;
                }
            }
            
            return difference;

        }
    }
}
