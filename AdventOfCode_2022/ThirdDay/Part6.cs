using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022
{
    public class Part6
    {
        public static void Run()
        {
            string[] input;

            int totalSum = 0;

            using (StreamReader sr = new StreamReader("D:\\ProyectosProgramacion\\AdventOfCode_2022\\AdventOfCode_2022\\ThirdDay\\input.txt"))
            {
                input = sr.ReadToEnd().Split("\n");
            }

            foreach (string line in input)
            {
                if (line != "")
                {

                }
            }

            for(int i = 0; i < input.Length; i += 3)
            {

                if((input[i] == "") || (input[i+1] == "") || (input[i+2] == "")){
                    break;
                }

                var rucksack_1 = input[i].ToList();
                var rucksack_2 = input[i+1].ToList();
                var rucksack_3 = input[i+2].ToList();

                foreach(var badge in rucksack_1)
                {
                    if(rucksack_2.Contains(badge) && (rucksack_3.Contains(badge)))
                    {
                        totalSum += GetValue(badge);
                        break;
                    }
                }
            }

            Console.WriteLine(totalSum);
        }


        private static int GetValue(char param)
        {
            if (Char.IsUpper(param))
            {
                return (int)param - 64 + 26;
            }
            else
            {
                return (int)param - 96;
            }
        }
    }
}
