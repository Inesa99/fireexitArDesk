using NewProject.MethodsConvertEndMath;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.ElementsCoordinats
{
    internal class Ways
    {
        internal PointF StartPoint { get; set; }
        internal PointF EndPoint { get; set; }
        internal PointF[] Doors { get; set; }
        internal PointF[] WalRoad { get; set; }
        internal List<PointF> Obstacles { get; set; }
        internal Wall Wall { get; set; }
        internal double LengthRoad { get; set; }
        internal List<PointF[]> CoorddinatesRoad { get; set; }
        internal ShortWay SortWay { get; set; }

        public Ways(PointF startPoint,
                    PointF endPoint,
                    PointF[] walRoad,
                    PointF[] doors,
                    List<PointF> obstacles,
                    Wall wall)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            WalRoad = walRoad;
            Doors = doors;
            Obstacles = obstacles;
            Wall = wall;
            LengthRoad = double.MaxValue;
            CoorddinatesRoad = new List<PointF[]>();
            SortWay = new ShortWay();
        }
        //PointF տիպի զանգվածների մուտքագրում CoorddinatesRoad-ի լիստի մեջ
        internal void AddCoorddinatsRoad()
        {
            foreach (var itam in Doors)
            {
                //պատի հետ հատում մուտքից մինչև դուռ
                IntersectionPoint point = IntersectionPoint.LineIntersection(StartPoint.X, 
                                                                           StartPoint.Y, 
                                                                           itam.X, itam.Y,
                                                                            WalRoad );
                //պատի հետ հատումը դռնից մինչև ելք 
                IntersectionPoint point1 = IntersectionPoint.LineIntersection(itam.X, itam.Y, 
                                                                                EndPoint.X, 
                                                                                EndPoint.Y,
                                                                               WalRoad);
                //Խոչընդոտների հետ հատում 

                //PointF hatum = IntersectionPoint.IsCrossed(
                //     StartPoint.X,
                //     StartPoint.Y,
                //     itam.X,
                //     itam.Y,
                //     IntersectionPoint.pointsObstacles);
                //if (hatum.X != itam.X || hatum.Y != itam.Y)
                //{
                //    PointF newDoor = IntersectionPoint.NearestDoor(hatum, Doors, itam);
                //    PointF[] points5 =
                //    {
                //        new PointF(StartPoint.X,  StartPoint.Y),
                //        hatum,
                //        newDoor
                //    };
                //    CoorddinatesRoad.Add(points5);
                //}

                if (point != null)
                {
                    PointF[] points =
                   {
                            StartPoint,
                            new PointF(point.X,point.Y),
                            IntersectionPoint.NearWallBypass(Wall.Start, 
                                                               Wall.End,
                                                               new PointF(point.X,point.Y)),
                            EndPoint };
                    CoorddinatesRoad.Add(points);
                }
                else if (point1 != null)
                {
                    PointF[] points =
                    {
                            StartPoint,
                            itam, //new PointF(itam.X,itam.Y),
                            new PointF(point1.X,point1.Y),
                            IntersectionPoint.NearWallBypass(Wall.Start, 
                                                               Wall.End,
                                                               new PointF(point1.X,point1.Y)),
                            EndPoint 
                    };
                    CoorddinatesRoad.Add(points);
                }
                else
                {
                    PointF[] points =
                    {
                            StartPoint,
                            itam,
                            EndPoint 
                    };
                    CoorddinatesRoad.Add(points);
                }

            }

                }
                //Ճանապարհի երկարություն
       internal void ShortWay(PointF[] points)
        {
            SortWay.LengthRoad = 0;
            for(int i = 0; i < points.Length - 1; i++)
            {
               SortWay.LengthRoad+= IntersectionPoint.DistanceTwoPoints(points[i],
                                                                        points[i + 1]);
            }
            if (LengthRoad > SortWay.LengthRoad)
            {
                LengthRoad = SortWay.LengthRoad;

                if (SortWay.CoorddinatesRoad.Count > 0)
                {
                    SortWay.CoorddinatesRoad.Clear();
                    SortWay.CoorddinatesRoad.Add(points);
                }
                else
                {
                    SortWay.CoorddinatesRoad.Add(points);
                }
            }
            else if (LengthRoad == SortWay.LengthRoad)
            {
                SortWay.CoorddinatesRoad.Add(points);
            }
            
        }
    }
}
