using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ObstacleCourseTwoClassLibrary;

namespace ObstacleCourseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateArray5ElementsAndFillWithOnesForLoop();
            
            
            //Console.ReadLine();
        }
        public static int[] CreateArray5ElementsAndFillWithOnesForLoop()
        {
            int[] result = new int[5];
            for (int i = 0; i < 5; i++)
            {
                result[i] = 1;
                Console.WriteLine(result[i]);
                Console.ReadLine();
            }
            return result;
            
        }
    }
}
