using System;
using ObstacleCourseTwoClassLibrary;
using ObstacleCourseTwo;

namespace ObstacleCourseTwoClassLibrary
{
    public static class EasyPart
    {

        // create array with 5 elements and fill it with 1's - no loops
        public static int[] CreateArray5ElementsAndFillWithOnesNoLoop()
        {
            int[] result = new int[5];
            result[0] = 1;
            result[1] = 1;
            result[2] = 1;
            result[3] = 1;
            result[4] = 1;
            return result;
        }

        // create array with 5 elements and fill it with 1's - for loop
        public static int[] CreateArray5ElementsAndFillWithOnesForLoop()
        {
            int[] result = new int[5];
            for (int i = 0; i < 5; i++)
            {
                result[i] = 1;
                Console.WriteLine(result[i]);
            }
            return result;
            //Console.WriteLine(result[i]);
        }

        // create array with N elements and fill it with 2's - for loop
        public static int[] CreateArrayNElementsAndFillWithTwosForLoop(int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = 2;
            }
            return result;
        }

        // create array with N elements and fill it with 3's - for loop
        public static int[] CreateArrayNElementsAndFillWithThreesForLoop(int n)
        {
            int[] result = new int[n];
            // write code here
            for (int i = 0; i < n; i++)
            {
                result[i] = 3;
            }
            return result;
        }

    }
}
