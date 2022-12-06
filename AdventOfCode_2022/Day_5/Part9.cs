using System.Net;
using System.Text;

namespace AdventOfCode_2022
{
     class Part9
    {
        public static List<char> List_1 = new List<char> { 'D', 'H', 'N', 'Q', 'T', 'W', 'V', 'B' };

        public static List<char> List_2 = new List<char> { 'D', 'W', 'B' };

        public static List<char> List_3 = new List<char> { 'T', 'S', 'Q', 'W', 'J', 'C' };

        public static List<char> List_4 = new List<char> { 'F', 'J', 'R', 'N', 'Z', 'T', 'P' };

        public static List<char> List_5 = new List<char> { 'G', 'P', 'V', 'J', 'M', 'S', 'T' };

        public static List<char> List_6 = new List<char> { 'B', 'W', 'F', 'T', 'N' };

        public static List<char> List_7 = new List<char> { 'B', 'L', 'D', 'Q', 'F', 'H', 'V', 'N' };

        public static List<char> List_8 = new List<char> { 'H', 'P', 'F', 'R' };

        public static List<char> List_9 = new List<char> { 'Z', 'S', 'M', 'B', 'L', 'N', 'P', 'H' };

        public static Stack<char> stack_1 = new Stack<char>();

        public static Stack<char> stack_2 = new Stack<char>();

        public static Stack<char> stack_3 = new Stack<char>();

        public static Stack<char> stack_4 = new Stack<char>();

        public static Stack<char> stack_5 = new Stack<char>();

        public static Stack<char> stack_6 = new Stack<char>();

        public static Stack<char> stack_7 = new Stack<char>();

        public static Stack<char> stack_8 = new Stack<char>();

        public static Stack<char> stack_9 = new Stack<char>();

        public static async void Run()
        {
            string[] input;

            foreach (char c in List_1) 
            {
                stack_1.Push(c);
            }
            foreach (char c in List_2)
            {
                stack_2.Push(c);
            }
            foreach (char c in List_3)
            {
                stack_3.Push(c);
            }
            foreach (char c in List_4)
            {
                stack_4.Push(c);
            }
            foreach (char c in List_5)
            {
                stack_5.Push(c);
            }
            foreach (char c in List_6)
            {
                stack_6.Push(c);
            }
            foreach (char c in List_7)
            {
                stack_7.Push(c);
            }
            foreach (char c in List_8)
            {
                stack_8.Push(c);
            }
            foreach (char c in List_9)
            {
                stack_9.Push(c);
            }



            using (StreamReader sr = new StreamReader("D:\\ProyectosProgramacion\\AdventOfCode_2022\\AdventOfCode_2022\\Day_5\\input.txt"))
            {
                for(int i = 0; i < 10; i++)
                {
                    await sr.ReadLineAsync();
                }

                input = sr.ReadToEnd().Split("\n");
            }

            foreach(var line in input)
            {
                if(line != "")
                {
                    var lineData = line.Split(' ').ToList();

                    lineData.Remove("move");
                    lineData.Remove("from");
                    lineData.Remove("to");

                    for(int i = 1; i <= Convert.ToInt32(lineData[0]); i++)
                    {
                        switch (Convert.ToInt32(lineData[1]))
                        {
                            case 1:
                                MoveCrate(stack_1.Peek(), Convert.ToInt32(lineData[2]));
                                stack_1.Pop();
                                break;

                            case 2:
                                MoveCrate(stack_2.Peek(), Convert.ToInt32(lineData[2]));
                                stack_2.Pop();
                                break;

                            case 3:
                                MoveCrate(stack_3.Peek(), Convert.ToInt32(lineData[2]));
                                stack_3.Pop();
                                break;

                            case 4:
                                MoveCrate(stack_4.Peek(), Convert.ToInt32(lineData[2]));
                                stack_4.Pop();
                                break;

                            case 5:
                                MoveCrate(stack_5.Peek(), Convert.ToInt32(lineData[2]));
                                stack_5.Pop();
                                break;

                            case 6:
                                MoveCrate(stack_6.Peek(), Convert.ToInt32(lineData[2]));
                                stack_6.Pop();
                                break;

                            case 7:
                                MoveCrate(stack_7.Peek(), Convert.ToInt32(lineData[2]));
                                stack_7.Pop();
                                break;

                            case 8:
                                MoveCrate(stack_8.Peek(), Convert.ToInt32(lineData[2]));
                                stack_8.Pop();
                                break;

                            case 9:
                                MoveCrate(stack_9.Peek(), Convert.ToInt32(lineData[2]));
                                stack_9.Pop();
                                break;

                            default:
                                break;
                        }
                    }
                }
            }

            Console.WriteLine($"The Peek crate of each stack are: {stack_1.Peek()}{stack_2.Peek()}{stack_3.Peek()}{stack_4.Peek()}{stack_5.Peek()}{stack_6.Peek()}{stack_7.Peek()}{stack_8.Peek()}{stack_9.Peek()}");
        }

        public static void MoveCrate(char crateToMove, int stack)
        {
            switch (stack)
            {
                case 1:
                    stack_1.Push(crateToMove);
                    break;

                case 2:
                    stack_2.Push(crateToMove);
                    break;

                case 3:
                    stack_3.Push(crateToMove);
                    break;

                case 4:
                    stack_4.Push(crateToMove);
                    break;

                case 5:
                    stack_5.Push(crateToMove);
                    break;

                case 6:
                    stack_6.Push(crateToMove);
                    break;

                case 7:
                    stack_7.Push(crateToMove);
                    break;

                case 8:
                    stack_8.Push(crateToMove);
                    break;

                case 9:
                    stack_9.Push(crateToMove);
                    break;

                default:
                    break;
            }
        }
    }
}
