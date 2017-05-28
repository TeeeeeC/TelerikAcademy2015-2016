namespace LinearDataStructures.Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Operation
    {
        private readonly List<int> sequenceOfNumbers = new List<int> { 1, 2, 2, 3, 4, 4, 4, 6, 6, 7, 8, 8, 8, 8, 9, 9 };

        // 1.
        public void CalculateSumAndAverage()
        {
            var numbers = this.ParseInput();
            long sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("The sum is {0}!", sum);
            decimal avg = sum / numbers.Count;
            Console.WriteLine("The avg is {0}!", avg);
            Console.WriteLine();
        }

        // 2. 
        public void ReverseIntigers()
        {
            Console.Write("Enter numbers count: ");
            int length = 0;
            if (int.TryParse(Console.ReadLine(), out length))
            {
                var numbers = new Stack<int>();
                for (int i = 0; i < length; i++)
                {
                    int number = 0;
                    Console.Write("Enter number: ");
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        numbers.Push(number);
                    }
                }

                for (int i = 0; i < length; i++)
                {
                    Console.Write(numbers.Pop() + ", ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        // 3.
        public void SortIntegersASC()
        {
            var numbers = this.ParseInput();

            numbers.Sort();
            Console.Write("Sorted in ASC: ");
            foreach (var number in numbers)
            {
                Console.Write(number + ", ");
            }

            Console.WriteLine();
        }

        // 4.
        public void FindLongestSubsequenceOfEqualNumbers()
        {
            int maxLen = 0;
            int currLen = 1;
            int number = 0;
            for (int i = 1; i < this.sequenceOfNumbers.Count; i++)
            {
                if (this.sequenceOfNumbers[i - 1] == this.sequenceOfNumbers[i])
                {
                    currLen++;
                    if (maxLen < currLen)
                    {
                        maxLen = currLen;
                        number = this.sequenceOfNumbers[i];
                    }
                }
                else
                {
                    currLen = 1;
                }
            }

            var result = new List<int>();
            Console.Write("Subsequence of equal numbers: ");
            for (int i = 0; i < maxLen; i++)
            {
                result.Add(number);
                Console.Write(number + ", ");
            }

            Console.WriteLine();
        }

        // 5.
        public void RemoveAllNegativeNumbers(List<int> numbers)
        {
            Console.Write("Positive numbers: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                }
                else
                {
                    Console.Write(numbers[i] + ", ");
                }
            }

            Console.WriteLine();
        }

        // 6.
        public void RemoveAllNumbersThatOccurOddNumberOfTimes(List<int> numbers)
        {
            // Count each number how many times occurs in list
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var key = numbers[i];
                if (dict.ContainsKey(key))
                {
                    dict[key] += 1;
                }
                else
                {
                    dict.Add(key, 1);
                }
            }

            // Remove all key-value that value is odd number
            for (int j = 0; j < numbers.Count; j++)
            {
                if (dict[numbers[j]] % 2 == 1)
                {
                    numbers.RemoveAt(j);

                    // The list is reordered after deleting and in the next step we will miss number
                    j--;
                }
            }

            foreach (var number in numbers)
            {
                Console.Write(number + ", ");
            }

            Console.WriteLine();
        }

        // 7.
        public void CountHowManyTimeNumberOccursInInterval(List<int> numbers)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var key = numbers[i];

                if (key < 0 || 1000 < key)
                {
                    continue;
                }

                if (dict.ContainsKey(key))
                {
                    dict[key] += 1;
                }
                else
                {
                    dict.Add(key, 1);
                }
            }

            foreach (var number in dict)
            {
                Console.WriteLine(number.Key + " -> " + number.Value + " times");
            }

            Console.WriteLine();
        }

        // 8.
        public void FindMajorant(List<int> numbers)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var key = numbers[i];
                if (dict.ContainsKey(key))
                {
                    dict[key] += 1;
                }
                else
                {
                    dict.Add(key, 1);
                }
            }

            var majorant = (numbers.Count / 2) + 1;
            var foundPair = dict.OrderBy(i => i.Value)
                .Where(v => v.Value >= majorant)
                .FirstOrDefault();

            if (foundPair.Key != 0)
            {
                Console.WriteLine("Majorant is {0}!", foundPair.Key);
            }
            else
            {
                Console.WriteLine("The majorant number doesn't exist!");
            }
        }

        // 9. 
        public void PrintSequence(int number)
        {
            int len = 49 / 3;
            Console.Write("The sequence: {0}, ", number);

            var queue = new Queue<int>();
            queue.Enqueue(number);
            for (int i = 0; i < len; i++)
            {
                int previous = queue.Peek() + 1;
                queue.Enqueue(previous);
                int current = (2 * queue.Peek()) + 1;
                queue.Enqueue(current);
                int next = queue.Peek() + 2;
                queue.Enqueue(next);
                Console.Write("{0}, {1}, {2}, ", previous, current, next);

                queue.Dequeue();
            }
            Console.Write("{0}", queue.Peek() + 1);
            Console.WriteLine();
        }

        // 10.
        public void FindShortestSeqOfOperationFromNToM(int start, int end)
        {
            var queue = new Queue<int>();
            while (start != end)
            {
                queue.Enqueue(end);
                if (end / 2 >= start)
                {
                    if (end % 2 == 0)
                    {
                        end /= 2;
                    }
                    else
                    {
                        end--;
                    }
                }
                else
                {
                    if (end - 2 >= start)
                    {
                        end -= 2;
                    }
                    else
                    {
                        end--;
                    }
                }
            }

            queue.Enqueue(start);
            Console.WriteLine(string.Join(", ", queue.Reverse()));
        }


        // 14.
        public void FillMatrix(string[,] matrix, int startRow, int startColumn)
        {
            var result = TraverseBFS(matrix, startRow, startColumn);
            result[startRow, startColumn] = "*";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == "0")
                    {
                        matrix[i, j] = "u";
                    }

                    Console.Write(matrix[i, j].PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
        }

         
        private string[,] TraverseBFS(string[,] matrix, int startRow, int startColumn)
        {
            var queue = new Queue<Index>();
            var root = new Index { Row = startRow, Column = startColumn, Value = 0};
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var currRoot = queue.Dequeue();
                matrix[currRoot.Row, currRoot.Column] = currRoot.Value.ToString();
                currRoot.Value++;

                if (currRoot.Row + 1 < matrix.GetLength(0) && matrix[currRoot.Row + 1, currRoot.Column] == "0")
                {
                    currRoot.Children.Add(new Index { Row = currRoot.Row + 1, Column = currRoot.Column, Value = currRoot.Value });
                }

                if (currRoot.Row - 1 >= 0 && matrix[currRoot.Row - 1, currRoot.Column] == "0")
                {
                    currRoot.Children.Add(new Index { Row = currRoot.Row - 1, Column = currRoot.Column, Value = currRoot.Value });
                }

                if (currRoot.Column + 1 < matrix.GetLength(0) && matrix[currRoot.Row, currRoot.Column + 1] == "0")
                {
                    currRoot.Children.Add(new Index { Row = currRoot.Row, Column = currRoot.Column + 1, Value = currRoot.Value });
                }

                if (currRoot.Column - 1 >= 0 && matrix[currRoot.Row, currRoot.Column - 1] == "0")
                {
                    currRoot.Children.Add(new Index { Row = currRoot.Row, Column = currRoot.Column - 1, Value = currRoot.Value });
                }

                foreach (var index in currRoot.Children)
                {
                    queue.Enqueue(index);
                }
            }

            return matrix;
        }

        // Parser
        private List<int> ParseInput()
        {
            Console.WriteLine("To see the sum and average of integeres, enter empty line");
            Console.Write("Please enter positive integer: ");
            string line = Console.ReadLine();
            List<int> numbers = new List<int>();
            while (line != string.Empty)
            {
                int number = 0;
                if (int.TryParse(line, out number))
                {
                    if (number > 0)
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid positive integer!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid positive integer!");
                }

                Console.Write("Please enter positive integer: ");
                line = Console.ReadLine();
            }

            return numbers;
        }
    }
}
