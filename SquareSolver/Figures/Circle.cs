using System;
using System.Collections.Generic;
using System.Text;

namespace SquareSolver.Figures
{
    public class Circle  : Figure
    {
        private float radius;

        public Circle(float rad) => radius = rad;

        public override float CalcSquare() =>
            radius * radius * (float) Math.PI;
    }
}
