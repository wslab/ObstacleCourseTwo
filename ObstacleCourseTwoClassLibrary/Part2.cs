using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObstacleCourseTwoClassLibrary
{
    public class Part2
    {
        // example 1: set first element of array to 1
        public static void setFirstElementToOne(int [] arr)
        {
            arr[0] = 1;
        }

        // example 2: find sum of all numbers in array
        public static int CalculateSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        // find sum of all positive numbers in array
        public static int CalculateSumOfPositive(int[] arr)
        {
            int sum = 0;
            // code goes here
            return sum;
        }

        // find sum of all negative numbers in array
        public static int CalculateSumOfNegative(int[] arr)
        {
            int sum = 0;
            // code goes here
            return sum;
        }

        // replace all negavite numbers in array with 0
        public static void ReplaceNegativeWithZero(int[] arr)
        {
            // code goes here
        }

        // set all values in array to 3
        public static void SetAllValuesTo3(int[] arr)
        {
            // code goes here
        }

        // set all values in array to n
        public static void SetAllValuesToN(int[] arr, int n)
        {
            // code goes here
        }

        // double each number in array
        public static void DoubleEachNumber(int[] arr)
        {
            // code goes here
        }

        // create array of size 10 and fill with numbers from 1 to 10
        public static int[] Array1to10()
        {
            int[] result = new int[0]; // this line is not correct, fix it
            // code goes here
            return result;
        }

        // create array of size 11 and fill with numbers from 10 to 20
        public static int[] Array10to20()
        {
            int[] result = new int[0]; // this line is not correct, fix it
            // code goes here
            return result;
        }

        // create array of size 11 and fill with numbers from 30 down to 20
        public static int[] Array30to20()
        {
            int[] result = new int[0]; // this line is not correct, fix it
            // code goes here
            return result;
        }

        // create array of size n and populate with numbers from 1 to n
        // OneToN(5) -> [1,2,3,4,5]
        // OneToN(7) -> [1,2,3,4,5,6,7]
        public static int[] OneToN(int n)
        {
            int[] result = new int[0]; // this line is not correct, fix it
            // code goes here
            return result;
        }
    }
}
