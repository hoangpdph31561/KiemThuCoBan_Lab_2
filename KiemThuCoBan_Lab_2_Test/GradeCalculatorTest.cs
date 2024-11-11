using KiemThuCoBan_Lab_2_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuCoBan_Lab_2_Test
{
    [TestFixture]
    public class GradeCalculatorTest
    {
        private GradeCalculator _gradeCalculator;
        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }
        [TearDown]
        public void Teardown()
        {
            _gradeCalculator = null;
        }
        [Test]
        public void GradeCalculator_CalculateAverage_ReturnsAverageOfValidScores()
        {
            var result = _gradeCalculator.CalculateAverage(8, 9, 10);
            Assert.That(result, Is.EqualTo(9).Within(0.01));
        }

        [Test]
        public void GradeCalculator_CalculateAverage_ReturnsAverageOfScoresAtLowerBoundary()
        {
            var result = _gradeCalculator.CalculateAverage(0, 0, 0);
            Assert.That(result, Is.EqualTo(0).Within(0.01));
        }

        [Test]
        public void GradeCalculator_CalculateAverage_ReturnsAverageOfScoresAtUpperBoundary()
        {
            var result = _gradeCalculator.CalculateAverage(10, 10, 10);
            Assert.That(result, Is.EqualTo(10).Within(0.01));
        }

        [Test]
        public void GradeCalculator_CalculateAverage_ThrowsExceptionForNegativeMathScore()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _gradeCalculator.CalculateAverage(-1, 8, 9));
        }

        [Test]
        public void GradeCalculator_CalculateAverage_ThrowsExceptionForMathScoreAboveTen()
        {
           Assert.Throws<ArgumentOutOfRangeException>(() => _gradeCalculator.CalculateAverage(11, 8, 9));
        }

        [Test]
        public void GradeCalculator_CalculateAverage_ThrowsExceptionForNegativePhysicsScore()
        {
           Assert.Throws<ArgumentOutOfRangeException>(() => _gradeCalculator.CalculateAverage(8, -1, 9));
        }

        [Test]
        public void GradeCalculator_CalculateAverage_ThrowsExceptionForPhysicsScoreAboveTen()
        {
           Assert.Throws<ArgumentOutOfRangeException>(() => _gradeCalculator.CalculateAverage(8, 11, 9));
        }

        [Test]
        public void GradeCalculator_CalculateAverage_ThrowsExceptionForNegativeChemistryScore()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _gradeCalculator.CalculateAverage(8, 9, -1));
        }

        [Test]
        public void GradeCalculator_CalculateAverage_ThrowsExceptionForChemistryScoreAboveTen()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _gradeCalculator.CalculateAverage(8, 9, 11));
            
        }
    }
}
