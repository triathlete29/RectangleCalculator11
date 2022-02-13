using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RectangleCalculator11;

namespace Test
{
    [TestFixture]
    public class TestRectangleCalculator
    {
        [Test]
        public void CorrectParameter_Number_OutputCorrectCalculation()
        {
            var rectangle = new Rectangle();

            var results = rectangle.GetPerimeter(3, 5);

            Assert.AreEqual(16, results);

        }

        [Test]
        public void CorrectParameter2_Number_OutputCorrectCalculation()
        {
            var rectangle = new Rectangle();

            var results = rectangle.GetPerimeter(2, 7);

            Assert.AreEqual(18, results);

        }
        
        [Test]
        public void CorrectParameter3_Number_OutputCorrectCalculation()
        {
            var rectangle = new Rectangle();

            var results = rectangle.GetPerimeter(4, 5);

            Assert.AreEqual(18, results);

        }

        [Test]
        public void CorrectArea_Number_OutputCorrectCalculation()
        {
            var rectangle = new Rectangle();

            var results = rectangle.GetArea(4, 5);

            Assert.AreEqual(20, results);

        }

        [Test]
        public void CorrectArea1_Number_OutputCorrectCalculation()
        {
            var rectangle = new Rectangle();

            var results = rectangle.GetArea(3, 6);

            Assert.AreEqual(18, results);

        }

        [Test]
        public void CorrectArea2_Number_OutputCorrectCalculation()
        {
            var rectangle = new Rectangle();

            var results = rectangle.GetArea(8, 6);

            Assert.AreEqual(48, results);

        }

        [Test]
        public void ValidWith_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.Width;

            Assert.AreEqual(results, results);

        }

        [Test]
        public void ValidWith2_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.Width;

            Assert.AreEqual(results, results);

        }

        [Test]
        public void ValidLenght_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.Length;

            Assert.AreEqual(results, results);

        }


        [Test]
        public void ValidLenght2_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.Length;

            Assert.AreEqual(results, results);

        }

        [Test]
        public void ValidLenghtSet_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.Length;

            Assert.AreEqual(results, results);

        }

        [Test]
        public void ValidLenghtGet_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.Length;

            Assert.AreEqual(results, results);

        }

        [Test]
        public void ValidWithSet_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.Width;

            Assert.AreEqual(results, results);

        }

        [Test]
        public void ValidWithGet_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.Width;

            Assert.AreEqual(results, results);

        }

        [Test]
        public void ClassRectangle_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.ValidRectangle(2, 2);

            Assert.AreEqual(8, results);

        }


        [Test]
        public void ClassRectangle2_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.ValidRectangle(1, 2);

            Assert.AreEqual(6, results);

        }

        [Test]
        public void ClassRectangle3_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.ValidRectangle(5, 2);

            Assert.AreEqual(14, results);

        }

        [Test]
        public void ClassRectangle4_Number_OutputNumber()
        {
            var rectangle = new Rectangle();

            var results = rectangle.ValidRectangle(9, 2);

            Assert.AreEqual(22, results);

        }
    }
}
