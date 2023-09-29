using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NewProject
{
    internal class Element
    {
       
        public static int qauntOfDoor  { get; set; }
        public static int x { get; set; }
        public static int y { get; set; }

        public static int startX { get; set; }

        public static int startY { get; set; }

        public static int endX { get; set; }

        public static int endY { get; set; }
        public static int n { get; set; }

        public static PointF[] points = new PointF[3];
        public static PointF[] InternalDoors;
        public static List<int> listx = new List<int>();
        public static List<int> listy = new List<int>();


        public static Tuple<int, int> GetCordinate(string value1, string value2)
        {
            int x;
            int y;

            int.TryParse(value1, out x);
            int.TryParse(value2, out y);
            return Tuple.Create(x, y);
        }

        public static float Coordinatess(PointF[] point)
        {
            float lenght1 = (float)Math.Sqrt(Math.Pow(point[1].X - point[0].X, 2) + Math.Pow(point[1].Y - point[0].Y, 2));
            float lenght2 = (float)Math.Sqrt(Math.Pow(point[2].X - point[1].X, 2) + Math.Pow(point[2].Y - point[1].Y, 2));
            return lenght1 + lenght2;
        }
        //public static void Coordinates()
        //{
        //    List<int> listx = new List<int>();
        //    List<int> listy = new List<int>();
        //    List<double> list = new List<double>();
        //    int x, y;
        //    Console.WriteLine("Please enter start door");
        //    Console.Write("x -> ");
        //    int startX = int.Parse(Console.ReadLine());
        //    Console.Write("y -> ");
        //    int startY = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Please enter end door");
        //    Console.Write("x -> ");
        //    int endX = int.Parse(Console.ReadLine());
        //    Console.Write("y -> ");
        //    int endY = int.Parse(Console.ReadLine());
        //    List<double> list2 = new List<double>();
        //    Console.Write("Please enter count of doors ->");
        //    int n = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write($"door {i + 1} x ->");
        //        x = int.Parse(Console.ReadLine());
        //        Console.Write($"door {i + 1} y ->");
        //        y = int.Parse(Console.ReadLine());
        //        listx.Add(x);
        //        listy.Add(y);

        //    }
        //    for (int j = 0; j < n; j++)
        //    {
        //        double lenght = Math.Sqrt(Math.Pow(listx[j] - startX, 2) + Math.Pow(listy[j] - startY, 2));
        //        list.Add(lenght);


        //    }
        //    for (int j = 0; j < n; j++)
        //    {
        //        double lenght2 = Math.Sqrt(Math.Pow(endX - listx[j], 2) + Math.Pow(endY - listy[j], 2));
        //        list2.Add(lenght2);

        //    }
        //    double min = 99999;
        //    for (int i = 0; i < list2.Count; i++)
        //    {
        //        double finishLenght = list[i] + list2[i];
        //        if (finishLenght < min)
        //        {
        //            min = finishLenght;
        //        }
        //    }
        //    Console.WriteLine(min);
        //}
    }
}
