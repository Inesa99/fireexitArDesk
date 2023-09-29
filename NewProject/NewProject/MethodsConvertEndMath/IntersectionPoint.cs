using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject.MethodsConvertEndMath
{
    internal class IntersectionPoint
    {
        public static List<PointF> pointsDoors = new List<PointF>();
        public static List<PointF> pointsObstacles = new List<PointF>();
       
        public float X { get; set; }
        public float Y { get; set; }

        public IntersectionPoint(float x, float y)
        {
            X = x;
            Y = y;
        }
        //նոր Լաբելի ստեղծում
        public static void NewLabel(Point point, Form form, string nane)
        {
            Label namelabel = new Label();
            namelabel.Location = point;
            namelabel.Text = nane;
            namelabel.Size = new Size(20, 20);
            form.Controls.Add(namelabel);

        }
        // ավելացնե նոր կետ CoordinatsDoors
        public static void AddCoordinatsDoors(float x, float y)
        {
            pointsDoors.Add(new PointF(x, y));
        }
        // ավելացնե նոր կետ CoordinatsObstacles
        public static void AddCoordinatsObstacles(float x, float y)
        {
            pointsObstacles.Add(new PointF(x, y));
        }
        //կոտորակի հայտարարի արժեքի որոշում
        public static float review(float xA, float yA,
                                   float xA1, float yA1,
                                   float xB, float yB,
                                   float xB1, float yB1)
        {
            return ((xA - xA1) * (yB - yB1) - (yA - yA1) * (xB - xB1));
        }
        //մեծագույն կոորդինատի որոշում
        public static float maxCoordinat(float x, float x1)
        {
            return x > x1 ? x : x1;
        }
        //փոքրագույն կոորդինատի որոշում
        public static float minCoordinat(float x, float x1)
        {
            return x < x1 ? x : x1;
        }


        //պատի հետ հատում 
        public static IntersectionPoint LineIntersection(float xA, float yA,
                                                         float xA1, float yA1,
                                                         PointF[] points)
        {
            if (review(xA, yA,
                       xA1, yA1,
                       points[0].X, points[0].Y,
                       points[1].X, points[1].Y)
                       != 0)
            {
                float x = ((xA * yA1 - yA * xA1)
                          * (points[0].X - points[1].X)
                          - (xA - xA1) * (points[0].X * points[1].Y
                          - points[0].Y * points[1].X))
                          / review(xA, yA,
                                   xA1, yA1,
                                   points[0].X, points[0].Y,
                                   points[1].X, points[1].Y);

                float y = ((xA * yA1 - yA * xA1)
                          * (points[0].Y - points[1].Y)
                          - (yA - yA1) * (points[0].X * points[1].Y
                          - points[0].Y * points[1].X))
                          / review(xA, yA,
                                   xA1, yA1,
                                   points[0].X, points[0].Y,
                                   points[1].X, points[1].Y);

                // MessageBox.Show($"uxixner hatvum en x= {x} end y= {y} ketum");

                if (x > minCoordinat(points[0].X, points[1].X)
                    && x < maxCoordinat(points[0].X, points[1].X)
                     && y > minCoordinat(points[0].Y, points[1].Y)
                     && y < maxCoordinat(points[0].Y, points[1].Y))
                {
                    return new IntersectionPoint(x, y);
                }
                else
                {
                    return null;
                }

            }
            else
            {
                MessageBox.Show("uxixner chen hatvum ");
                return null;
            }

        }
        //մոտակա դուռ
        public static PointF NearestDoor(PointF obstacle,
                                        PointF[] pointsDoors,
                                        PointF door)
        {
            PointF newDoor = new PointF();
            float minNearstDoor = float.MaxValue;
            foreach (PointF point in pointsDoors)
            {
                if (minNearstDoor > DistanceTwoPoints(obstacle, point))
                {
                    minNearstDoor = DistanceTwoPoints(obstacle, point);
                    if (point.X != door.X
                     && point.Y != door.Y
                     && !ObstacleCrossing(obstacle.X, obstacle.Y,
                                           point.X, point.Y,
                                           pointsObstacles, out newDoor))
                    {
                        newDoor = point;
                    }

                    //minNearstDoor = DistanceTwoPoints(obstacle, point);
                   // newDoor = point;
                }
            }
            return newDoor;
        }
        //հատվածի երկարություն
        public static float DistanceTwoPoints(PointF p1,
                                              PointF p2)
        {
            return (float)Math.Sqrt(Math.Pow(p1.X - p2.X, 2)
                  + Math.Pow(p1.Y - p2.Y, 2));
        }

        // խոչընդոտի հետ հատում bool
        public static bool ObstacleCrossing(float xA,
                                            float yA,
                                            float xB,
                                            float yB,
                                            List<PointF> obstacles,
                                            out PointF pointF)
        {
            pointF = new PointF(xB, yB);
            bool crossing = false;
            foreach (var point in obstacles)
            {
                if ((point.X - xA) * (yB - yA) == (point.Y - yA) * (xB - xA)
                    && point.X >= minCoordinat(xA, xB)
                    && point.X <= maxCoordinat(xA, xB)
                    && point.Y >= minCoordinat(yA, yB)
                    && point.Y <= maxCoordinat(yA, yB))
                {
                    crossing = true;
                    pointF = point;
                }
            }

            return crossing;
        }
        //խոչընդոտի հետ հատում 
        public static PointF IsCrossed(float xA,
                                       float yA,
                                       float xB,
                                       float yB,
                                       List<PointF> obstacles)
        {
            PointF pointF = new PointF(xB, yB);

            foreach (var point in obstacles)
            {
                if ((point.X - xA) * (yB - yA) == (point.Y - yA) * (xB - xA)
                    && point.X >= minCoordinat(xA, xB)
                    && point.X <= maxCoordinat(xA, xB)
                    && point.Y >= minCoordinat(yA, yB)
                    && point.Y <= maxCoordinat(yA, yB))
                {

                    return point;

                }
            }
            return pointF;
        }
        //Պատի հատման կետից մոտակա ելք
        public static PointF NearWallBypass(PointF wallStart,
                                            PointF wallEnd,
                                            PointF crossing)
        {
            if (Math.Sqrt((Math.Pow((wallStart.X - crossing.X), 2))
                         + Math.Pow((wallStart.Y - crossing.Y), 2))
                    < Math.Sqrt((Math.Pow((wallEnd.X - crossing.X), 2))
                    + Math.Pow((wallEnd.Y - crossing.Y), 2)))
            {
                return wallStart;
            }
            else
            {
                return wallEnd;
            }
        }
    }
}
