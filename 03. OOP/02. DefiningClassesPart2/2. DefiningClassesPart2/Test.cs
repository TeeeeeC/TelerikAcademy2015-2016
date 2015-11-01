namespace _2.DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            Point3D point1 = new Point3D(1, 2, 3);
            Console.WriteLine(point1);
            Console.WriteLine(Point3D.InitialPoint);

            Point3D point2 = new Point3D(3, 4, 5);
            Console.WriteLine(point2);
            decimal distance = StaticPoint3D.CalculateDistance(point1, point2);
            Console.WriteLine(distance);

            Random rand = new Random();
            var path = new List<Path>();
            for (int i = 0; i < 5; i++)
            {
                Path point = new Path(new Point3D(rand.Next(0, 51), rand.Next(0, 51), rand.Next(0, 51)));
                path.Add(point);
            }

            PathStorage.SavePath(path);
            PathStorage.LoadPath();
            foreach (var point in PathStorage.ListOfPath)
            {
                Console.WriteLine(point);
            }

            var list = new GenericList<int>();
            list.Add(5);
            list.Add(53);
            list.Add(545);
            list.Add(5);
            list.Add(53);
            list.Add(545);
            Console.WriteLine(list[2]);
            list.RemoveAt(5);
            list.Add(5);
            Console.WriteLine(list[4]);
            Console.WriteLine(list.Count);
            list.Insert(1, 2);
            Console.WriteLine(list.FindElement(5));
            Console.WriteLine(list);
            list.Clear();

            for (int i = 0; i < 16; i++)
            {
                list.Add(2);
            }
            list.Insert(1, 5);
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());

            var listStr = new GenericList<string>();
            listStr.Add("pesho");
            Console.WriteLine(listStr[0]);

            Matrix<int> matrix = new Matrix<int>();
            matrix[0, 0] = 5;
            matrix[1, 0] = 2;

            Matrix<int> matrix1 = new Matrix<int>();
            matrix1[0, 0] = 5;
            matrix1[1, 0] = 2;

            Matrix<int> resultSum = matrix + matrix1;
            Matrix<int> resultSub = matrix - matrix1;
            Matrix<int> resultMul = matrix * matrix1;

            //matrix[0, 1] = 5;
            //matrix[1, 1] = 2;

            if(matrix)
            {
                Console.WriteLine("There is non-zero elements!");
            }
            else
            {
                Console.WriteLine("There is zero elements!");
            }

            var attributes = typeof(PathStorage).GetCustomAttributes(true);
            foreach (var attr in attributes)
            {
                var versionAttr = (VersionAtribute)attr;
                Console.WriteLine(versionAttr.Version);
            }
        }
    }
}
