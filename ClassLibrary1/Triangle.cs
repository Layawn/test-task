using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle : Figure
    {
        double sideA, sideB, sideC;
        public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            sideA = triangleSideA;
            sideB = triangleSideB;
            sideC = triangleSideC;
        }
        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }
        public double SideB
        {
            get { return sideB; }
            set { sideB = value < 0 ? -value : value; }
        }
        public double SideC { 
            get { return sideC; } 
            set { sideC = value < 0 ? -value : value; }
        }
        public override string Area()
        {
            double semPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString();
        }
        public override string Title()
        {
            if (Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2)) {
                return "Прямоугольнный треугольник";
            }
            else {
                return "Треугольник";
            }
        }
    }
}
