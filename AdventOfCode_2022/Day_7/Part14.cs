using AdventOfCode_2022.Day_7;
using Microsoft.VisualBasic;

namespace AdventOfCode_2022
{
    class Part14
    {
        public static long spaceNeededToUpdate = 30000000;
        public static long totalSpace = 70000000;

        public static async void Run()
        {
            MyDirectory outermostDirectory = new MyDirectory()
            {
                Name = "/"
            };

            MyDirectory currentDirectory = outermostDirectory;

            using (StreamReader sr = new StreamReader("D:\\ProyectosProgramacion\\AdventOfCode_2022\\AdventOfCode_2022\\Day_7\\input.txt"))
            {
                while(sr.Peek() != -1)
                {
                    var data = sr.ReadLine()!.Split(" ");

                    if(data is not null)
                    {
                        int val;
                        
                        if(Int32.TryParse(data[0], out val))
                        {
                            currentDirectory.Files.Add(new MyFile()
                            {
                                Name = data[1],
                                Size = val
                            });
                        }

                        switch (data[0])
                        {
                            case "$":

                                if(data[1] == "cd")
                                {
                                    if (data[2] == "..")
                                    {
                                        currentDirectory = currentDirectory.Father;
                                    }
                                    else if (data[2] == "/")
                                    {
                                        currentDirectory = outermostDirectory;
                                    }
                                    else
                                    {
                                        var nextDir = currentDirectory.SubDirectories.Where(x => x.Name == data[2]).FirstOrDefault();

                                        if(nextDir != null)
                                        {
                                            currentDirectory = nextDir;
                                        }
                                    }
                                }

                                break;

                            case "dir":

                                currentDirectory.SubDirectories.Add(new MyDirectory()
                                {
                                    Father = currentDirectory,
                                    Name = data[1]
                                });

                                break;

                            default:
                                break;
                        }
                    }
                }
            }

            var usedSpace = outermostDirectory.TotalValue();

            var unusedSpace = totalSpace - usedSpace;

            outermostDirectory.SmallestValuetoDelete(spaceNeededToUpdate - unusedSpace);

            var finalResult = MyDirectory.smallestDirToDeleteVal;

           Console.WriteLine(finalResult);
        }
    }
}
