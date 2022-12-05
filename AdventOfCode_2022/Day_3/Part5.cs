using System.Net;
using System.Text;

namespace AdventOfCode_2022
{
     class Part5
    {
        public static async void Run()
        {
            string[] input;

            int totalSum = 0;

            using(StreamReader sr = new StreamReader("D:\\ProyectosProgramacion\\AdventOfCode_2022\\AdventOfCode_2022\\ThirdDay\\input.txt"))
            {
                input = sr.ReadToEnd().Split("\n");
            }

            foreach(string line in input)
            {
                if(line != "")
                {

                    var firstHalf = line.Substring(0, line.Length / 2).ToList();
                    var secondHalf = line.Substring(firstHalf.Count, line.Length / 2).ToList();

                    foreach(var x in firstHalf)
                    {
                        if (secondHalf.Contains(x))
                        {
                            totalSum += GetValue(x);
                            break;
                        }
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