using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mines
{
    public class Mines
    {
        public static void Main(string[] args)
        {
            const int MAX = 35;
            string command = string.Empty;
            char[,] playfield = GeneratePlayfield();
            char[,] mines = GenerateMines();
            int countedTurns = 0;
            bool isMine = false;
            List<Scores> scores = new List<Scores>(6);
            int row = 0;
            int column = 0;
            bool startedGame = true;
            bool endedGame = false;

            do
            { 
                // Try your luck to find cells without mines.
                if (startedGame)
                {
                    Console.WriteLine("Let's play on “Mines”. Try your luck to find cells without mines." +
                    " Command 'top' shows ranking, 'restart' begin new game, 'exit' quit game and say goodbye!");
                    PrintGame(playfield);
                    startedGame = false;
                }

                Console.Write("Please enter row and column : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= playfield.GetLength(0) && column <= playfield.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintRanking(scores);
                        break;
                    case "restart":
                        playfield = GeneratePlayfield();
                        mines = GenerateMines();
                        PrintGame(playfield);
                        isMine = false;
                        startedGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye, Bye!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                MakeTurn(playfield, mines, row, column);
                                countedTurns++;
                            }

                            if (MAX == countedTurns)
                            {
                                endedGame = true;
                            }
                            else
                            {
                                PrintGame(playfield);
                            }
                        }
                        else
                        {
                            isMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }

                if (isMine)
                {
                    PrintGame(mines);
                    Console.Write("\nBOOM! You died with {0} points. " + "What is your name: ", countedTurns);
                    string name = Console.ReadLine();
                    Scores players = new Scores(name, countedTurns);

                    if (scores.Count < 5)
                    {
                        scores.Add(players);
                    }
                    else
                    {
                        for (int index = 0; index < scores.Count; index++)
                        {
                            if (scores[index].Results < players.Results)
                            {
                                scores.Insert(index, players);
                                scores.RemoveAt(scores.Count - 1);
                                break;
                            }
                        }
                    }

                    scores.Sort((Scores result1, Scores result2) => result2.Name.CompareTo(result1.Name));
                    scores.Sort((Scores result1, Scores result2) => result2.Results.CompareTo(result1.Results));
                    PrintRanking(scores);

                    playfield = GeneratePlayfield();
                    mines = GenerateMines();
                    countedTurns = 0;
                    isMine = false;
                    startedGame = true;
                }

                if (endedGame)
                {
                    Console.WriteLine("\nCongratulations! You opened 35 cells and YOU WIN.");
                    PrintGame(mines);
                    Console.WriteLine("Please insert your name: ");
                    string name = Console.ReadLine();
                    Scores score = new Scores(name, countedTurns);
                    scores.Add(score);
                    PrintRanking(scores);
                    playfield = GeneratePlayfield();
                    mines = GenerateMines();
                    countedTurns = 0;
                    endedGame = false;
                    startedGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("Have a nice day!");
            Console.Read();
        }

        private static void PrintRanking(List<Scores> scores)
        {
            Console.WriteLine("\nScores:");

            if (scores.Count > 0)
            {
                for (int index = 0; index < scores.Count; index++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", index + 1, scores[index].Name, scores[index].Results);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty ranking!\n");
            }
        }

        private static void MakeTurn(char[,] playfield, char[,] mines, int row, int column)
        {
            char countedMines = CountAsterix(mines, row, column);
            mines[row, column] = countedMines;
            playfield[row, column] = countedMines;
        }

        private static void PrintGame(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);

                for (int column = 0; column < columns; column++)
                {
                    Console.Write(string.Format("{0} ", board[row, column]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GeneratePlayfield()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] GenerateMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] playfield = new char[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    playfield[row, column] = '-';
                }
            }

            List<int> numbers = new List<int>();
            while (numbers.Count < 15)
            {
                Random random = new Random();
                int number = random.Next(50);

                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
            }

            foreach (int number in numbers)
            {
                int column = number / columns;
                int row = number % columns;

                if (row == 0 && number != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playfield[column, row - 1] = '*';
            }

            return playfield;
        }

        private static void GetCountMines(char[,] playfield)
        {
            int columns = playfield.GetLength(0);
            int rows = playfield.GetLength(1);

            for (int column = 0; column < columns; column++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (playfield[column, row] != '*')
                    {
                        char countedMines = CountAsterix(playfield, column, row);
                        playfield[column, row] = countedMines;
                    }
                }
            }
        }

        private static char CountAsterix(char[,] playfield, int row, int column)
        {
            int counterAsterix = 0;
            int rows = playfield.GetLength(0);
            int columns = playfield.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playfield[row - 1, column] == '*')
                {
                    counterAsterix++;
                }
            }

            if (row + 1 < rows)
            {
                if (playfield[row + 1, column] == '*')
                {
                    counterAsterix++;
                }
            }

            if (column - 1 >= 0)
            {
                if (playfield[row, column - 1] == '*')
                {
                    counterAsterix++;
                }
            }

            if (column + 1 < columns)
            {
                if (playfield[row, column + 1] == '*')
                {
                    counterAsterix++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (playfield[row - 1, column - 1] == '*')
                {
                    counterAsterix++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (playfield[row - 1, column + 1] == '*')
                {
                    counterAsterix++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (playfield[row + 1, column - 1] == '*')
                {
                    counterAsterix++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (playfield[row + 1, column + 1] == '*')
                {
                    counterAsterix++;
                }
            }

            return char.Parse(counterAsterix.ToString());
        }

        public class Scores
        {
            private string name;
            private int scores;

            public Scores() 
            { 
            }

            public Scores(string name, int scores)
            {
                this.name = name;
                this.scores = scores;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Results
            {
                get { return this.scores; }
                set { this.scores = value; }
            }
        }
    }
}