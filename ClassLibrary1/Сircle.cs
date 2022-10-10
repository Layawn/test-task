using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Сircle : Figure
    {
        double sideA;
        public Сircle(double circleRadius)
        {
            sideA = circleRadius;
        }

        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }

        public override string Area()
        {
            return (3.14 * Math.Pow(sideA, 2)).ToString();
        }
        public override string Title()
        {
            return "Круг";
        }
    }
}
