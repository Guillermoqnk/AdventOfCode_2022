namespace ConsoleApp1
{
    public class Part4
    {
        public static void Run()
        {
            string[] dataSplited;

            int totalScore = 0;

            using (StreamReader sr = new StreamReader("C:\\Users\\guill\\OneDrive\\Escritorio\\input.txt"))
            {
                var inputData = sr.ReadToEnd();

                dataSplited = inputData.Split("\n");
            }

            foreach(string lineS in dataSplited)
            {

                if(lineS != "")
                {
                    var line = lineS.Split(" ");


                    if (line[0] == "A")
                    {
                        if (line[1] == "X")
                        {
                            totalScore += 3;
                            totalScore += 0;
                        }
                        if (line[1] == "Y")
                        {
                            totalScore += 1;
                            totalScore += 3;
                        }
                        if (line[1] == "Z")
                        {
                            totalScore += 2;
                            totalScore += 6;
                        }
                    }

                    if (line[0] == "B")
                    {
                        if (line[1] == "X")
                        {
                            totalScore += 1;
                            totalScore += 0;
                        }
                        if (line[1] == "Y")
                        {
                            totalScore += 2;
                            totalScore += 3;
                        }
                        if (line[1] == "Z")
                        {
                            totalScore += 3;
                            totalScore += 6;
                        }
                    }

                    if (line[0] == "C")
                    {
                        if (line[1] == "X")
                        {
                            totalScore += 2;
                            totalScore += 0;
                        }
                        if (line[1] == "Y")
                        {
                            totalScore += 3;
                            totalScore += 3;
                        }
                        if (line[1] == "Z")
                        {
                            totalScore += 1;
                            totalScore += 6;
                        }
                    }
                }
            }

            Console.WriteLine($"Final score: {totalScore}");
        }
    }
}