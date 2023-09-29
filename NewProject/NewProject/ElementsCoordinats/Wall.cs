using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.ElementsCoordinats
{
    internal class Wall
    {

        public PointF Start { get; set; }
        public PointF End { get; set; }
        public Wall(float startX, float startY, float endX, float endY)
        {
            Start = new PointF(startX, startY);
            End = new PointF(endX, endY);
        }
    }
}
