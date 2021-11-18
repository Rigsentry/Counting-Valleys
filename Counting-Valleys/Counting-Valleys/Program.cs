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
            countingValleys(8, "UDDDUDUU");
            //countingValleys(8, "DDUUDDUDUUUD");
        }

        public static int countingValleys(int steps, string path)
        {
            int level = 0;
            bool valley = false;
            int numberOfValleys = 0;
            foreach (var item in path)
            {
                if (item == 'U')
                    level++;
                else if (item == 'D')
                    level--;
                if (level < 0 && !valley)
                {
                    numberOfValleys++;
                    valley = true;
                }                    
                else if(level == 0 && valley)
                {
                    valley = false;                    
                }

            }
            return numberOfValleys;
        }
    }
}
