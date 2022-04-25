using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquareSolver.Figures
{
    public class Triangle : Figure
    {
        float bigEdge, mediumEdge, smallEdge;
        private string wrongInput = "Введенные стороны не соответствуют неравенуству треугольника";

        public Triangle(float a, float b, float c)
        {
            bigEdge = Math.Max(a, Math.Max(b, c));
            smallEdge = Math.Min(a, Math.Min(b, c));
            mediumEdge = a + b + c - bigEdge - smallEdge;
            Assert.IsFalse(bigEdge > mediumEdge + smallEdge, wrongInput);
        }

        public override float CalcSquare()
        {
            if (bigEdge * bigEdge == mediumEdge * mediumEdge + smallEdge * smallEdge)
                return mediumEdge * smallEdge / 2f;
            float p = (bigEdge + mediumEdge + smallEdge) / 2f;
            return (float) Math.Sqrt(p * (p - bigEdge) * (p - mediumEdge) * (p - smallEdge));
        }
    }
}
