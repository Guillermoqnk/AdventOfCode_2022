using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode_2022
{
    class Part15
    {
        public static async void Run()
        {

            int visibleTrees = 0;

            bool upFree = true;
            bool downFree = true;
            bool rightFree = true;
            bool leftFree = true;

            int xLenght = 0;
            int yLenght = 0;

            using (StreamReader sr = new StreamReader("D:\\ProyectosProgramacion\\AdventOfCode_2022\\AdventOfCode_2022\\Day_8\\input.txt"))
            {
                var data = sr.ReadToEnd().Split("\n");

                xLenght = data[0].Length;
                yLenght = data.Length;

                char[,] formatedData = new char[xLenght , yLenght];

                for (int i = 0; i < xLenght; i++)
                {
                    if (data[i] != "")
                    {
                        var line = data[i].ToCharArray();

                        for (int j = 0; j < yLenght; j++)
                        {
                            formatedData[i,j] = line[j];
                        }
                    }
                    
                }

                sr.Close();

                for (int i = 0; i < xLenght; i++)
                {
                    for (int j = 0; j < yLenght; j++)
                    {
                        upFree = true;
                        downFree = true;
                        rightFree = true;
                        leftFree = true;

                        if(i == 0 || j == 0 || i == xLenght -1 || j == yLenght -1)
                        {
                            visibleTrees++;
                        }
                        else
                        {

                            for (int e = 1; e <= yLenght-1-j; e++)
                            {
                                if (rightFree)
                                {
                                    int right = Int32.Parse(Convert.ToString(formatedData[i, j + e]));

                                    if(right >= Int32.Parse(Convert.ToString(formatedData[i, j])))
                                    {
                                        rightFree = false;
                                        break;
                                    }
                                }                                
                            }

                            for (int e = 1; e <= j; e++)
                            {
                                if (leftFree)
                                {
                                    int left = Int32.Parse(Convert.ToString(formatedData[i, j - e]));

                                    if (left >= Int32.Parse(Convert.ToString(formatedData[i, j])))
                                    {
                                        leftFree = false;
                                        break;
                                    }
                                }
                            }

                            for (int e = 1; e <= xLenght - 1 - i; e++)
                            {
                                if (downFree)
                                {

                                    int down = Int32.Parse(Convert.ToString(formatedData[i + e, j]));

                                    if (down >= Int32.Parse(Convert.ToString(formatedData[i, j])))
                                    {
                                        downFree = false;
                                        break;
                                    }
                                }
                            }

                            for (int e = 1; e <= i; e++)
                            {
                                if (upFree)
                                {
                                    int up = Int32.Parse(Convert.ToString(formatedData[i - e, j]));

                                    if (up >= Int32.Parse(Convert.ToString(formatedData[i, j])))
                                    {
                                        upFree = false;
                                        break;
                                    }
                                }
                            }



                            if (upFree || downFree || rightFree|| leftFree)
                            {
                                visibleTrees++;
                            }
                        }

                    }
                }
            }

            Console.WriteLine(visibleTrees);
        }
    }
}