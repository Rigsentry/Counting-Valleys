using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valleys
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "UDDDUDUU";
            Console.WriteLine(countingValleys(path1));
            string path2 = "DDUUDDUDUUUD";
            Console.WriteLine(countingValleys(path2));
            Console.ReadKey();

        }
        public static int countingValleys(string path)
        {
            int altitude = 0;
            int preclimb = 0;
            int valleyCount = 0;
            foreach (char c in path)
            {
                preclimb = altitude;
                if (c == 'U')
                {
                    altitude++;
                }
                else
                {
                    altitude--;
                }
                if (preclimb < 0 && altitude == 0)
                {
                    valleyCount++;
                }
            }
            return valleyCount;
        }
    }
}
