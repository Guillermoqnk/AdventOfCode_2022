using System.Net;

namespace AdventOfCode_2022
{
     class Part1
    {
        public static async void Run()
        {
            string input = String.Empty;

            int higherCals = 0;

            var url = "https://adventofcode.com/2022/day/1/input";

            using var client = new HttpClient();

            try
            {
                var x = await client.GetAsync(url);
                Console.WriteLine(x);
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            var elfCalList = input.Split("\n\n");

            foreach(var elfCal in elfCalList)
            {
                int totalCals = 0;

                var localCals = elfCal.Split("\n");

                foreach(var cal in localCals)
                {
                    if(cal != ""){

                    totalCals += Convert.ToInt32(cal);
                    }
                }

                if(totalCals > higherCals) { higherCals = totalCals; }
            }

            Console.WriteLine($"The elf with higher cals is carring: {higherCals}");
        }
    }
}