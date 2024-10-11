using NUnit.Framework;
using System;
using TriangleSolver;

namespace TraingleSolverClassLibrary
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ValidEquilateralTriangle_Input20and20and20_OutputEquilateraltriangle()
        {
            int side1 = 20;
            int side2 = 20;
            int side3 = 20;
            string expected = "Equilateral triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ValidIsoscelesTriangle_Input5and5and8_OutputIsoscelesTriangle()
        {
            int side1 = 5;
            int side2 = 5;
            int side3 = 8;
            string expected = "Isosceles triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ValidIsoscelesTriangle_Input9and6and9_OutputIsoscelesTriangle()
        {
            int side1 = 9;
            int side2 = 6;
            int side3 = 9;
            string expected = "Isosceles triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ValidIsoscelesTriangle_Input12and18and18_OutputIsoscelesTriangle()
        {
            int side1 = 12;
            int side2 = 18;
            int side3 = 18;
            string expected = "Isosceles triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ValidScaleneTriangle_Input500and600and700_OutputScaleneTriangle()
        {
            int side1 = 500;
            int side2 = 600;
            int side3 = 700;
            string expected = "Scalene triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ValidScaleneTriangle_Input1000and800and1200_OutputScaleneTriangle()
        {
            int side1 = 1000;
            int side2 = 800;
            int side3 = 1200;
            string expected = "Scalene triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ValidScaleneTriangle_Input750and850and900_OutputScaleneTriangle()
        {
            int side1 = 750;
            int side2 = 850;
            int side3 = 900;
            string expected = "Scalene triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ValidScaleneTriangle_Input1100and1400and1600_OutputScaleneTriangle()
        {
            int side1 = 1100;
            int side2 = 1400;
            int side3 = 1600;
            string expected = "Scalene triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ValidScaleneTriangle_Input900and1300and1500_OutputScaleneTriangle()
        {
            int side1 = 900;
            int side2 = 1300;
            int side3 = 1500;
            string expected = "Scalene triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ZeroLengthSide_Input0and150and300_OutputInvalidTriangle()
        {
            int side1 = 0;
            int side2 = 150;
            int side3 = 300;
            string expected = "Invalid Triangle - a zero has been detected";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ZeroLengthSide_Input250and0and400_OutputInvalidTriangle()
        {
            int side1 = 250;
            int side2 = 0;
            int side3 = 400;
            string expected = "Invalid Triangle - a zero has been detected";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ZeroLengthSide_Input600and500and0_OutputInvalidTriangle()
        {
            int side1 = 600;
            int side2 = 500;
            int side3 = 0;
            string expected = "Invalid Triangle - a zero has been detected";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void InvalidTriangle_Input18and2and15_OutputInvalidTriangle()
        {
            int side1 = 18;
            int side2 = 2;
            int side3 = 15;
            string expected = "INVALID!!";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void InvalidTriangle_Input20and10and5_OutputInvalidTriangle()
        {
            int side1 = 20;
            int side2 = 10;
            int side3 = 5;
            string expected = "INVALID!!";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void InvalidTriangle_Input35and10and15_OutputInvalidTriangle()
        {
            int side1 = 35;
            int side2 = 10;
            int side3 = 15;
            string expected = "INVALID!!";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}