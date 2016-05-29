using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimForms
{
    class Line
    {
        public int? startX;
        public int? startY;
        public int? endX;
        public int? endY;

        public Line()
        {
            startX = startY = endX = endY = null;
        }

        public Line(int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }
    }
}
