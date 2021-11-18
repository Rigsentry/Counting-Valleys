using System;

namespace Counting_Valleys
{
    class Program
    {
        static void Main(string[] args)
        {

            var steps1 = 8;
            var path1 = "UDDDUDUU";

            var steps2 = 12;
            var path2 = "DDUUDDUDUUUD";

            var steps3 = 0;
            var path3 = "DDUUDDUDUUUDUDDDUUUDUDUDDUDUUUDUDDDDDUUUUUUDUDUDUDUDUDUUUU";

            Console.WriteLine("1- the number of valleys traversed is: " + countingValleys(steps1, path1));
            Console.WriteLine("2- the number of valleys traversed is: " + countingValleys(steps2, path2));
            Console.WriteLine("3- the number of valleys traversed is: " + countingValleys(steps3, path3));

            static int countingValleys(int steps, string path)
            {
                var waterLevel = 0;
                var valleys = 0;

                foreach(var direction in path)
                {
                    if (direction.Equals('U'))
                    {
                        waterLevel++;

                        //Only count when the hiker goes back to sea level
                        if (waterLevel == 0)
                        {
                            valleys++;
                        }
                    }
                    else
                    {
                        waterLevel--;                        
                    }
                }
                return valleys;
            }
        }
    }
}
