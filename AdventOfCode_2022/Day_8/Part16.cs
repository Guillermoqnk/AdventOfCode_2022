using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode_2022
{
    class Part16
    {
        public static async void Run()
        {

            int visibleTrees = 0;

            bool upFree = true;
            bool downFree = true;
            bool rightFree = true;
            bool leftFree = true;

            int upValue = 0;
            int downValue = 0;
            int rightValue = 0;
            int leftValue = 0;

            int maxScoreTree = 0;

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

                        upValue = 0;
                        downValue = 0;
                        rightValue = 0;
                        leftValue = 0;

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
                                        rightValue = e;
                                        break;
                                    }
                                }
                                
                                if(e == yLenght - 1 - j)
                                {
                                    rightValue = e;
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
                                        leftValue = e;
                                        break;
                                    }
                                }

                                if( e == j)
                                {
                                    leftValue = e;
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
                                        downValue = e;
                                        break;
                                    }
                                }

                                if(e == xLenght - 1 - i)
                                {
                                    downValue = e;
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
                                        upValue = e;
                                        break;
                                    }
                                }

                                if(e == i)
                                {
                                    upValue = e;
                                }
                            }



                            if (upFree || downFree || rightFree|| leftFree)
                            {
                                visibleTrees++;
                            }
                        }

                        var provValue = upValue * downValue * rightValue * leftValue;

                        if(provValue > maxScoreTree)
                        {
                            maxScoreTree = provValue;
                        }
                    }
                }
            }

            Console.WriteLine(maxScoreTree);
        }
    }
}