namespace AdventOfCode_2022
{
    class Part11
    {
        static Queue<Char> subroutine = new Queue<Char>();

        public static async void Run()
        {

            int readedChars = 3;

            using (StreamReader sr = new StreamReader("D:\\ProyectosProgramacion\\AdventOfCode_2022\\AdventOfCode_2022\\Day_6\\input.txt"))
            {
                for(int i = 0; i < readedChars; i++)
                {
                    subroutine.Enqueue(Convert.ToChar(sr.Read()));
                }

                while (sr.Peek() > -1)
                {
                    readedChars++;

                    subroutine.Enqueue(Convert.ToChar(sr.Read()));
                    
                    if (!ExistsEquals(subroutine))
                    {
                        Console.WriteLine(readedChars);
                        break;
                    }

                    subroutine.Dequeue();
                }
            }

            Console.WriteLine();
        }

        public static bool ExistsEquals(Queue<char> values) 
        {
            var list = values.ToList();

            var duplicates = list.GroupBy(x => x)
                    .SelectMany(g => g.Skip(1))
                    .Distinct()
                    .ToList();

            return duplicates.Any();
        }
    }
}
