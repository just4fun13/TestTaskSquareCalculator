using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareSolver.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquareSolver
{
    public class FiguresTester
    {
        private string trianFail = "Тестирование площади треугольника прошло с ошибкой";
        private string circleFail = "Тестирование площади окружности прошло с ошибкой";

        public void Circle_1_Sqr_Pi()
        {
            Figure circle = new Circle(1);
            Assert.AreEqual(circle.CalcSquare(), Math.PI, 0.0001f, circleFail);
        }

        public void Trian_3_4_5_Sqr_6()
        {
            Figure trian1 = new Triangle(3, 4, 5);
            Assert.AreEqual(trian1.CalcSquare(), 6, trianFail);
        }

        public void Trian_1_1_1_Sqr_root3div4()
        {
            Figure trian1 = new Triangle(1, 1, 1);
            Assert.AreEqual(trian1.CalcSquare(), Math.Sqrt(3)/4f, 0.01f, trianFail);
        }

        public FiguresTester()
        {
            Circle_1_Sqr_Pi();
            Trian_1_1_1_Sqr_root3div4();
            Trian_3_4_5_Sqr_6();
        }

    }
}
