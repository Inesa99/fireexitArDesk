using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.MethodsConvertEndMath
{
    internal class MethodsConvert
    {
        internal float X;
        internal float Y;
       internal int x;
       internal int y;
        internal string stringX;
       internal string stringY;

        internal MethodsConvert(string X, string Y)
        {
            this.stringX = X;
            this.stringY = Y;
        }

        internal bool IsCordinatsNumericFloat()
        {
            return (float.TryParse(this.stringX, out X) && float.TryParse(this.stringY, out Y));
        }
       internal bool IsCordinatsNumericInt()
        {
            return (int.TryParse(this.stringX, out x) && int.TryParse(this.stringY, out y));
        }
    }
}
