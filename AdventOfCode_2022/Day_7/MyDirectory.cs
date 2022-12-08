namespace AdventOfCode_2022.Day_7
{
    public class MyDirectory
    {
        public static long totalValidDirectoriesValue = 0;

        public static long smallestDirToDeleteVal = 70000000;


        public MyDirectory? Father { get; set; }

        public string Name = string.Empty;

        public List<MyDirectory> SubDirectories = new List<MyDirectory>();

        public List<MyFile> Files = new List<MyFile>();





        public long TotalValue()
        {
            long finalValue = 0;

            if (!SubDirectories.Any())
            {
                foreach (var file in Files)
                {
                    finalValue += file.Size;
                }

                return finalValue;
            }

            foreach(var dir in SubDirectories)
            {
                var dirVal = dir.TotalValue();

                if (dirVal <= 100000)
                {
                    totalValidDirectoriesValue += dirVal;
                }

                finalValue += dirVal;
            }

            foreach(var file in Files)
            {
                finalValue += file.Size;
            }

            return finalValue;
        }

        public long SmallestValuetoDelete(long minSpaceToFree)
        {
            long finalValue = 0;

            if (!SubDirectories.Any())
            {
                foreach (var file in Files)
                {
                    finalValue += file.Size;
                }

                return finalValue;
            }

            foreach (var dir in SubDirectories)
            {
                var dirVal = dir.SmallestValuetoDelete(minSpaceToFree);

                if(smallestDirToDeleteVal == 0) { }

                if((dirVal >= minSpaceToFree) && (dirVal < smallestDirToDeleteVal))
                {
                    smallestDirToDeleteVal = dirVal;
                }

                finalValue += dirVal;
            }

            foreach (var file in Files)
            {
                finalValue += file.Size;
            }

            return finalValue;
        }
    }
}
