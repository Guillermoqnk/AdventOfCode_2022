/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022
{
    public class Part2
    {
        public static void Run()
        {
            string input;

            int top1Cals = 0;
            int top2Cals = 0;
            int top3Cals = 0;

            using (StreamReader sr = new StreamReader("https://adventofcode.com/2022/day/1/input"))
            {
                input = sr.ReadToEnd();
            }


            var elfCalList = input.Split("\n\n");

            foreach (var elfCal in elfCalList)
            {
                int totalCals = 0;

                var localCals = elfCal.Split("\n");

                foreach (var cal in localCals)
                {
                    if (cal != "")
                    {

                        totalCals += Convert.ToInt32(cal);
                    }
                }

                if (totalCals > top3Cals) 
                {
                    top3Cals = totalCals; 

                    if(top3Cals > top2Cals)
                    {
                        var tempCals = top2Cals;

                        top2Cals = top3Cals;

                        top3Cals = tempCals;

                        if(top2Cals > top1Cals)
                        {
                            tempCals = top1Cals;

                            top1Cals = top2Cals;

                            top2Cals = tempCals;
                        }
                    }
                }
            }

            var totalCalsCarried = top1Cals + top2Cals + top3Cals;

            Console.WriteLine($"Total cals being carried by the TOP3 elves: {totalCalsCarried}");
        }
    }
}*/
