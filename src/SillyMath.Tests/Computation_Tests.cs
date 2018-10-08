using NUnit.Framework;
using SillyMath.Interfaces;

namespace SillyMath.Tests
{
    public class Computation_Tests
    {
        IComputation _computation;
        [SetUp]
        public void Init()
        {
            _computation = new Computation();
        }

        [TestCase(0, 0, 0)]
        [TestCase(1, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(2, 1, 1)]
        [TestCase(2, 2, 2)]
        [TestCase(3, 1, 2)]
        [TestCase(6, 4, 5)]
        public void MezzaSomma_Cases(int a, int b, int expectedResult)
        {
            var actualResult = _computation.MezzaSomma(a, b);
            Assert.AreEqual(expected: expectedResult, actual: actualResult);
        }
    }
}
