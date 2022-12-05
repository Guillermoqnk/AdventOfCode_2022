using System.Net;
using System.Text;

namespace AdventOfCode_2022
{
     class Part7
    {
        public static async void Run()
        {
            string[] input;

            int totalSum = 0;

            using(StreamReader sr = new StreamReader("D:\\ProyectosProgramacion\\AdventOfCode_2022\\AdventOfCode_2022\\Day_4\\input.txt"))
            {
                input = sr.ReadToEnd().Split("\n");
            }

            foreach(string line in input)
            {
                if(line != "")
                {
                    var idPair = line.Split(',');

                    var firstId = idPair[0].Split('-');
                    var secondId = idPair[1].Split('-');

                    if (((Int32.Parse(firstId[0]) <= Int32.Parse(secondId[0])) && (Int32.Parse(firstId[1]) >= Int32.Parse(secondId[1]))) 
                        || ((Int32.Parse(firstId[0]) >= Int32.Parse(secondId[0])) && (Int32.Parse(firstId[1]) <= Int32.Parse(secondId[1]))))
                    {
                        totalSum += 1;
                    }
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}