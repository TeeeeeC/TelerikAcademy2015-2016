namespace TreesAndTraversals.ConsoleClient
{
    using System;
    using System.Numerics;
    using Tasks;

    public class Startup
    {
        private const string Path = @"C:\WINDOWS";

        public static void Main()
        {
            var taskCalculator = new TaskCalculator();

            // 1.
            var nodes = taskCalculator.ParseTree();
            taskCalculator.FindRoot(nodes);
            taskCalculator.FindAllLeafs(nodes);
            taskCalculator.FindAllMiddleNodes(nodes);
            taskCalculator.FindLongestPath(nodes);
            taskCalculator.FindAllPathByGivenSum(nodes, 9);

            Console.WriteLine();

            // 2.
            Console.WriteLine(Path);
            taskCalculator.TraverseWindowsDir(Path);

            Console.WriteLine();

            // 3. To find the sum of subtree, just give subfolder from windows as a parameter
            var folder = new Folder { Name = @"C:\WINDOWS" };
            BigInteger sum = taskCalculator.DFSRecursive(folder);
            Console.WriteLine("The sum of all file's size is {0}!", sum);
        }
    }
}
