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
        public static void setFirstElementToOne(int[] arr)
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
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    sum += arr[i];
            }
            return sum;
        }

        // find sum of all negative numbers in array
        public static int CalculateSumOfNegative(int[] arr)
        {
            int sum = 0;
            // code goes here
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    sum += arr[i];
            }
            return sum;
        }

        // replace all negavite numbers in array with 0
        public static void ReplaceNegativeWithZero(int[] arr)
        {
            // code goes here
            //сделала сама без подсказок
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    arr[i] = 0;
            }
        }

        // set all values in array to 3
        public static void SetAllValuesTo3(int[] arr)
        {
            // code goes here
            //сделала сама без подсказок
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 3;
            }
        }

        // set all values in array to n
        public static void SetAllValuesToN(int[] arr, int n)
        {
            // code goes here
            //сделала сама без подсказки
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = n;
            }
        }

        // double each number in array
        public static void DoubleEachNumber(int[] arr)
        {
            // code goes here
            //сделала сама
            int result = 2; //сначала инициировала int result =0, но это была ошибка. Тест помог найти ошибку!
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = result * arr[i];//ошибка была в этой линии. arr[i] = result * i; неправильно, так как индекс в результате был неправильный
                
            }
        }

        // create array of size 10 and fill with numbers from 1 to 10
        public static int[] Array1to10()
        {
            //int[] result = new int[0]; // this line is not correct, fix it
            int[] result = new int[10]; // there are 10 elements to fill in
                                        // code goes here
            //START: сделала сама без подсказок - способ номер один, но проблема может быть в большом количестве элементов
            //result[0] = 1;
            //result[1] = 2;
            //result[2] = 3;
            //result[3] = 4;
            //result[4] = 5;
            //result[5] = 6;
            //result[6] = 7;
            //result[7] = 8;
            //result[8] = 9;
            //result[9] = 10;
            //FINISH
            //Второй способ:


           for (int i = 0; i < result.Length; i++)
                {
                    //if (result[i] >= 1 || result [i] <=10)
                    if (result.Length >= 1 || result.Length <= 10)
                        result[i] = i;

                }



                return result;
        }

        // create array of size 11 and fill with numbers from 10 to 20
        public static int[] Array10to20()
        {
            //в этот раз решила не прописывать все элементы, так как их может быть много. Надо сделать цикл
            //int[] result = new int[0]; // this line is not correct, fix it
            int[] result = new int[11]; // array contains 11 elements
            // code goes here
            for (int i = 10; i < 11; i++)
            {
                if (result[i] < 20)
                    result[i] = i;
            }
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
            int[] result = new int[n]; // array with size n elements

            //int[] result = new int[0]; // this line is not correct, fix it
            // code goes here
            for (int i = 0; i < result.Length; i++)
            {
                result[n] = n;
            }
            return result;
        }
    }
}
