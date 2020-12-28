using System;
using System.Collections.Generic;
using static System.Math;

namespace FindMinDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>()
            {
                "05:31","22:08","00:35"
            };
            Console.WriteLine(TestMethod(strings));

        }

        static int TestMethod(List<string> timePoints)
        {

            List<int> timePointsInMins = new List<int>(); 

            for (int i = 0; i < timePoints.Count; i++)
            {
                int hoursToMins = Int32.Parse(timePoints[i].Substring(0,2))*60;
                int mins = Int32.Parse(timePoints[i].Substring(3));
                timePointsInMins.Add(hoursToMins+mins);
            }
            timePointsInMins.Sort();
            foreach (int i in timePointsInMins)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("End of parsing and sorting");

            int difference = (1440 - timePointsInMins[timePoints.Count - 1]) + timePointsInMins[0];

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
