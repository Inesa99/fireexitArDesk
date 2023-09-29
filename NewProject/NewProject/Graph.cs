using NewProject.ElementsCoordinats;
using NewProject.MethodsConvertEndMath;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Graph : Form
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        internal Wall wall { get;set;}
        public Graph()
        {
            InitializeComponent();
        }
        private void Graph_Load(object sender, EventArgs e)
        { }
        private void Graph_Load(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 12);
            PointF[] points1 =
            {
                 wall.Start,
                 wall.End,
            };
            e.Graphics.DrawLines(pen, points1);

            Pen bluePen = new Pen(Color.Blue, 4);
            Pen redPen = new Pen(Color.Red, 6);
            Ways ways = new Ways(StartPoint, 
                                  EndPoint,points1,
                                  Element.InternalDoors, 
                                  IntersectionPoint.pointsObstacles, 
                                  wall);

            ways.AddCoorddinatsRoad();
            foreach(var way in ways.CoorddinatesRoad)
            {
                e.Graphics.DrawLines(bluePen, way);
                ways.ShortWay(way);
            }
            if (ways.SortWay.CoorddinatesRoad.Count > 1)
            {
                foreach (var shortWay in ways.SortWay.CoorddinatesRoad)
                {
                    e.Graphics.DrawLines(redPen, shortWay);
                }
            }
            else { e.Graphics.DrawLines(redPen, ways.SortWay.CoorddinatesRoad[0]); }
           
        }
    }
}
