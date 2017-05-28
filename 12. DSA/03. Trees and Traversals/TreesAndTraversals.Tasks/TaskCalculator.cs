namespace TreesAndTraversals.Tasks
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Numerics;

    public class TaskCalculator
    {
        private static int number;
        private static int indexRoot;
        private static List<TreeNode> leafs = new List<TreeNode>();
        private static BigInteger sum = new BigInteger();

        public TreeNode[] ParseTree()
        {
            number = int.Parse(Console.ReadLine());
            var nodes = new TreeNode[number];
            for (int i = 0; i < number; i++)
            {
                nodes[i] = new TreeNode(i);
            }

            for (int i = 0; i < number - 1; i++)
            {
                var currentPairs = Console.ReadLine().Split(' ');
                var parentValue = int.Parse(currentPairs[0]);
                var childValue = int.Parse(currentPairs[1]);

                nodes[childValue].Parent = nodes[parentValue];
                nodes[parentValue].Children.Add(nodes[childValue]);
            }

            Console.WriteLine();

            return nodes;
        }

        public void FindRoot(TreeNode[] nodes)
        {
            for (int i = 0; i < number; i++)
            {
                if (nodes[i].Parent == null)
                {
                    Console.WriteLine("Root: {0}", nodes[i].Value);
                    indexRoot = i;
                    break;
                }
            }
        }

        public void FindAllLeafs(TreeNode[] nodes)
        {
            Console.Write("Leafs: ");
            for (int i = 0; i < number; i++)
            {
                if (nodes[i].Children.Count == 0)
                {
                    Console.Write("{0}, ", nodes[i].Value);
                    leafs.Add(nodes[i]);
                }
            }

            Console.WriteLine();
        }

        public void FindAllMiddleNodes(TreeNode[] nodes)
        {
            Console.Write("Middle nodes: ");
            for (int i = 0; i < number; i++)
            {
                if (nodes[i].Children.Count > 0 && nodes[i].Parent != null)
                {
                    Console.Write("{0}, ", nodes[i].Value);
                }
            }

            Console.WriteLine();
        }

        public void FindLongestPath(TreeNode[] nodes)
        {
            var longestPath = FindPath(nodes[indexRoot]);
            Console.WriteLine("The longest path: {0}", longestPath);
        }

        public void FindAllPathByGivenSum(TreeNode[] nodes, long sum)
        {
            var root = nodes[indexRoot];
            for(int i=0; i < nodes.Length; i++)
            {
                long currSum = 0;
                var leaf = nodes[i];
                var answer = new Stack<long>();
                while (leaf.Parent != null)
                {
                    currSum += leaf.Value;
                    answer.Push(leaf.Value);
                    leaf = leaf.Parent;
                }

                currSum += root.Value;
                answer.Push(root.Value);
                if (currSum == sum)
                {
                    Console.Write("The sum {0}: ", sum);
                    while(answer.Count > 0)
                    {
                        Console.Write("{0}, ", answer.Pop());
                    }
                    Console.WriteLine();
                }
            }
        }

        public void TraverseWindowsDir(string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (var childDir in dirs)
                {
                    TraverseWindowsDir(childDir);
                }

                string[] files = Directory.GetFiles(path);
                foreach (var childFile in files)
                {
                    if (childFile.EndsWith(".exe"))
                    {
                        Console.WriteLine(childFile);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
        }

        public BigInteger DFSRecursive(Folder folder)
        {
            Console.Write(".");
            try
            {
                var dirInfo = new DirectoryInfo(folder.Name);
                DirectoryInfo[] dirs = dirInfo.GetDirectories();
                foreach (var childDir in dirs)
                {
                    var newFolder = new Folder { Name = childDir.FullName };
                    folder.ChildFolders.Add(newFolder);

                    DFSRecursive(newFolder);
                }

                FileInfo[] files = dirInfo.GetFiles();
                foreach (var file in files)
                {
                    var newFile = new File { Name = file.Name, Size = file.Length };
                    sum += file.Length;
                    folder.Files.Add(newFile);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return sum;
        }

        private static int FindPath(TreeNode root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            var maxPath = 1;
            foreach (var childNode in root.Children)
            {
                maxPath = Math.Max(maxPath, FindPath(childNode));
            }

            return maxPath + 1;
        }
    }
}
